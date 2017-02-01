Imports System.IO
Imports CDO
Public Class frmDefault
    Dim i As Integer = 0
    Dim FileCount As Integer
    Dim file As StreamWriter
    Dim fileFeatures As StreamWriter
    Dim flgFileClose As Integer = -1
    Dim f As Features
    Dim di As DirectoryInfo
    Dim SubFolder As DirectoryInfo
    Dim OutputFolder As DirectoryInfo
    Private Sub btnDoExtract_Click(sender As Object, e As EventArgs) Handles btnDoExtract.Click
        If TestCheckBox() Then
            btnSourceBrowse.Enabled = False
            txtSourceFolder.Enabled = False
            btnDoExtract.Enabled = False
            GroupBoxFeatures.Enabled = False
            lblStatus.Text = "Initialization⁯..."
            BackgroundWorkerFile.RunWorkerAsync()
        Else
            MessageBox.Show("Please check at least one features.", "Features Extraction Process has been terminated", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BackgroundWorkerFile_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerFile.DoWork
        f = New Features(TabMain)
        di = New DirectoryInfo(txtSourceFolder.Text)
        FileCount = di.GetFiles.Count
        SubFolder = New DirectoryInfo(txtSourceFolder.Text)
        OutputFolder = SubFolder.CreateSubdirectory(Now.Year.ToString + "_" + Now.Month.ToString + "_" + Now.Day.ToString + "_" + Now.Hour.ToString + "_" + Now.Minute.ToString + "_" + Now.Second.ToString)
        Me.Invoke(New MethodInvoker(AddressOf VisibleProgressBar))


        Dim v As Decimal = 0.00
        Dim EmailHeaderString As String = ""
        Dim EmailFeaturesHeaderString As String = "FileName"
        Dim Delimiter As String = "|"
        Dim DelimiterFeatures As String = ","

        EmailHeaderString = "FileName" + Delimiter + "ReceivedTime" + Delimiter + "From" + Delimiter + "To" + Delimiter + "CC" +
                  Delimiter + "BCC" + Delimiter + "Subject" + Delimiter + "HTMLBody" + Delimiter + "TextBody"

        For Each k As String In f.FeatureDictionary.Keys.ToArray
            EmailFeaturesHeaderString += DelimiterFeatures + k
        Next

        file = My.Computer.FileSystem.OpenTextFileWriter(OutputFolder.FullName + "\Email.txt", False)
        file.WriteLine(EmailHeaderString)

        fileFeatures = My.Computer.FileSystem.OpenTextFileWriter(OutputFolder.FullName + "\EmailFeatures.csv", False)
        fileFeatures.WriteLine(EmailFeaturesHeaderString)
        flgFileClose = 0


        For Each fi In di.GetFiles()

            Try
                Dim email As CDO.Message = CdoWrapper.LoadMessage(fi.FullName)
                Dim EmailFrom As String = email.From
                Dim EmailTo As String = email.To
                Dim EmailCC As String = email.CC
                Dim EmailBCC As String = email.BCC
                Dim EmailSubject As String = email.Subject
                Dim EmailHTMLBody As String = email.HTMLBody
                Dim EmailTextBody As String = email.TextBody
                Dim EmailTime As String = email.ReceivedTime.ToString
                Dim EmailFullString As String = ""
                Dim FeaturesFullString As String = fi.Name

                f.test("s", email)



                For Each k As String In f.FeatureDictionary.Keys.ToArray
                    f.Controller(k, email)
                    FeaturesFullString += DelimiterFeatures + f.FeatureDictionary.Item(k)
                Next

                EmailFullString = fi.Name + Delimiter + EmailTime + Delimiter + EmailFrom + Delimiter + EmailTo + Delimiter + EmailCC +
                Delimiter + EmailBCC + Delimiter + EmailSubject + Delimiter + EmailHTMLBody.Replace(Chr(10), "").Replace(Chr(13), "").Replace("|", ",") + Delimiter + EmailTextBody.Replace(Chr(10), "").Replace(Chr(13), "").Replace("|", ",")


                file.WriteLine(EmailFullString)
                fileFeatures.WriteLine(FeaturesFullString)
            Catch ex As Exception
                Dim fileEx As StreamWriter
                fileEx = My.Computer.FileSystem.OpenTextFileWriter(OutputFolder.FullName + "\Error.txt", True)
                fileEx.WriteLine(fi.Name + "____  " + ex.ToString)
                fileEx.Close()
            End Try

            i = i + 1
            v = (i / FileCount) * 100
            BackgroundWorkerFile.ReportProgress(v)
        Next
        file.Close()
        fileFeatures.Close()
        flgFileClose = 1
        Dim answer As DialogResult = MessageBox.Show("The output folder is: <Corpus path>\" + OutputFolder.Name + " .Do you want to open it NOW?!", "Extraction Process has been completed", MessageBoxButtons.YesNo)
        If answer = DialogResult.Yes Then
            Process.Start(OutputFolder.FullName)
        End If
    End Sub

    Private Sub BackgroundWorkerFile_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorkerFile.ProgressChanged
        lblStatus.Text = i.ToString + "/" + FileCount.ToString + " ( " + e.ProgressPercentage.ToString + "%  ) "
        ProgressBarStatus.Value = e.ProgressPercentage

        If e.ProgressPercentage = 100 Then
            btnSourceBrowse.Enabled = True
            txtSourceFolder.Enabled = True
            btnDoExtract.Enabled = True
            GroupBoxFeatures.Enabled = True
        End If
    End Sub

    Private Sub btnSourceBrowse_Click(sender As Object, e As EventArgs) Handles btnSourceBrowse.Click
        If FolderBrowserDialogSource.ShowDialog = DialogResult.OK Then
            txtSourceFolder.Text = FolderBrowserDialogSource.SelectedPath
        End If
    End Sub

    Private Sub frmDefault_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If flgFileClose = 0 Then
            file.Close()
            fileFeatures.Close()
        End If
    End Sub
    Sub VisibleProgressBar()
        ProgressBarStatus.Visible = True
        lblStatus.Text = i.ToString + "/" + FileCount.ToString + " ( " + "0" + "%  ) "
        ProgressBarStatus.Value = 0
    End Sub

    Private Sub cbAllFeatures_CheckedChanged(sender As Object, e As EventArgs) Handles cbAllFeatures.CheckedChanged
        If cbAllFeatures.Tag = "0" Then
            For Each p As TabPage In TabMain.TabPages
                For Each c In p.Controls
                    If TypeOf (c) Is CheckBox Then
                        CType(c, CheckBox).Checked = True
                    ElseIf TypeOf (c) Is GroupBox Then
                        For Each ch As CheckBox In c.Controls
                            ch.Checked = True
                        Next
                    End If
                Next
            Next
                cbAllFeatures.Tag = "1"
        Else
            For Each p As TabPage In TabMain.TabPages
                For Each c In p.Controls
                    If TypeOf (c) Is CheckBox Then
                        CType(c, CheckBox).Checked = False
                    ElseIf TypeOf (c) Is GroupBox Then
                        For Each ch As CheckBox In c.Controls
                            ch.Checked = False
                        Next
                    End If
                Next
            Next
                cbAllFeatures.Tag = "0"
        End If
    End Sub

    Private Sub cbPayloadFeatures_CheckedChanged(sender As Object, e As EventArgs) Handles cbPayloadFeatures.CheckedChanged
        If cbPayloadFeatures.Tag = "0" Then
            For Each ch As CheckBox In GroupBoxPayloadFeatures.Controls
                ch.Checked = True
            Next
            cbPayloadFeatures.Tag = "1"
        Else
            For Each ch As CheckBox In GroupBoxPayloadFeatures.Controls
                ch.Checked = False
            Next
            cbPayloadFeatures.Tag = "0"
        End If
    End Sub

    Private Sub cbHeaderFeatures_CheckedChanged(sender As Object, e As EventArgs) Handles cbHeaderFeatures.CheckedChanged
        If cbHeaderFeatures.Tag = "0" Then
            For Each ch As CheckBox In GroupBoxHeaderFeatures.Controls
                ch.Checked = True
            Next
            cbHeaderFeatures.Tag = "1"
        Else
            For Each ch As CheckBox In GroupBoxHeaderFeatures.Controls
                ch.Checked = False
            Next
            cbHeaderFeatures.Tag = "0"
        End If
    End Sub

    Private Sub cbSubjectFeatures_CheckedChanged(sender As Object, e As EventArgs) Handles cbSubjectFeatures.CheckedChanged
        If cbSubjectFeatures.Tag = "0" Then
            For Each ch As CheckBox In GroupBoxSubjectFeatures.Controls
                ch.Checked = True
            Next
            cbSubjectFeatures.Tag = "1"
        Else
            For Each ch As CheckBox In GroupBoxSubjectFeatures.Controls
                ch.Checked = False
            Next
            cbSubjectFeatures.Tag = "0"
        End If
    End Sub

    Private Sub cbReadabilityFeatures_CheckedChanged(sender As Object, e As EventArgs) Handles cbReadabilityFeatures.CheckedChanged
        If cbReadabilityFeatures.Tag = "0" Then
            For Each ch As CheckBox In GroupBoxReadabilityFeatures.Controls
                ch.Checked = True
            Next
            cbReadabilityFeatures.Tag = "1"
        Else
            For Each ch As CheckBox In GroupBoxReadabilityFeatures.Controls
                ch.Checked = False
            Next
            cbReadabilityFeatures.Tag = "0"
        End If
    End Sub

    Private Sub cbAttachmentFeatures_CheckedChanged(sender As Object, e As EventArgs) Handles cbAttachmentFeatures.CheckedChanged
        If cbAttachmentFeatures.Tag = "0" Then
            For Each ch As CheckBox In GroupBoxAttachmentFeatures.Controls
                ch.Checked = True
            Next
            cbAttachmentFeatures.Tag = "1"
        Else
            For Each ch As CheckBox In GroupBoxAttachmentFeatures.Controls
                ch.Checked = False
            Next
            cbAttachmentFeatures.Tag = "0"
        End If
    End Sub
    Private Sub cbLexicalDiversity_CheckedChanged(sender As Object, e As EventArgs) Handles cbLexicalDiversity.CheckedChanged
        If cbLexicalDiversity.Tag = "0" Then
            For Each ch As CheckBox In GroupBoxLexicalDiversity.Controls
                ch.Checked = True
            Next
            cbLexicalDiversity.Tag = "1"
        Else
            For Each ch As CheckBox In GroupBoxLexicalDiversity.Controls
                ch.Checked = False
            Next
            cbLexicalDiversity.Tag = "0"
        End If
    End Sub

    Private Function TestCheckBox() As Boolean
        Dim flg As Boolean = False
        For Each p As TabPage In TabMain.TabPages
            For Each c In p.Controls
                If TypeOf (c) Is CheckBox Then

                    If CType(c, CheckBox).Checked Then
                        flg = True
                        Return flg
                    End If

                ElseIf TypeOf (c) Is GroupBox Then
                    For Each ch As CheckBox In c.Controls
                        If ch.Checked Then
                            flg = True
                            Return flg
                        End If
                    Next
                End If
            Next
        Next
        Return flg
    End Function

End Class
