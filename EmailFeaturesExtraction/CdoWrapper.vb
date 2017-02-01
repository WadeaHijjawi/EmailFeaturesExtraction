Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Net.Mail
Imports System.Reflection
Imports System.Text
Imports System.Threading.Tasks
Imports CDO
Imports ADODB
Public Class CdoWrapper
    Public Shared Function LoadMessage(emlFilePath As String) As CDO.Message
        Try
            Dim msg As CDO.Message = New MessageClass()
            Dim stream As ADODB.Stream = New StreamClass()

            stream.Open(Type.Missing, ADODB.ConnectModeEnum.adModeUnknown, ADODB.StreamOpenOptionsEnum.adOpenStreamUnspecified, String.Empty, String.Empty)
            'stream.Type = ADODB.StreamTypeEnum.adTypeBinary; // Don't parse UTF8 byte headers
            stream.LoadFromFile(emlFilePath)
            stream.Flush()
            msg.DataSource.OpenObject(stream, "_Stream")
            msg.DataSource.Save()

            Return msg
        Catch ex As Exception

        End Try
    End Function

    Public Shared Function GetString(bodypart As IBodyPart) As String
        Dim bodyBytes = bodypart.GetDecodedContentStream().ToByteArray()
        Dim bodyPartCharset = Encoding.GetEncoding(bodypart.Charset)
        Dim byteArrayEncoding = Encoding.Unicode
        ' all UTF-x formats are saved in UTF-16 by ADODB
        If bodyPartCharset.IsSingleByte Then
            byteArrayEncoding = bodyPartCharset
        End If
        ' US-ASCII
        Dim result = byteArrayEncoding.GetString(bodyBytes)
        Return result
    End Function
    Public Shared Function ToByteArray(stream As ADODB.Stream) As Byte()
        Dim data As Byte()

        Dim tempSubFolderPath = TempSubfolder()
        Try
            Dim tempFilePath = Path.Combine(tempSubFolderPath, "stream.tmp")
            ' ADODB cannot convert streams to .net byte arrays, but this works
            stream.SaveToFile(tempFilePath)
            data = File.ReadAllBytes(tempFilePath)
        Finally
            Dim d As New DirectoryInfo(tempSubFolderPath)
            d.Delete(recursive:=True)
        End Try

        Return data
    End Function


    Public Shared Function TempSubfolder() As String
        Dim subFolderName = Guid.NewGuid().ToString().Replace("-", "")
        Dim systemTempFolderPath = System.Environment.GetEnvironmentVariable("TEMP")
        Dim folderPath = Path.Combine(systemTempFolderPath, subFolderName)
        Directory.CreateDirectory(folderPath)
        Return folderPath
    End Function



End Class
