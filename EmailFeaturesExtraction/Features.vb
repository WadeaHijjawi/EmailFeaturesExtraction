Imports System.IO
Imports System.Text.RegularExpressions
Imports HtmlAgilityPack
Imports edu.stanford.nlp.ling
Imports edu.stanford.nlp.tagger.maxent
Imports java.io
Imports java.util

Public Class Features
    Public FeatureDictionary As New Dictionary(Of String, String)
    Private SpamWordList As New List(Of String)
    Private FunctionWordList As New List(Of String)
    Dim jarRoot As String
    Dim tagger As MaxentTagger

    Public Sub test(ByVal FeatureKey As String, ByVal email As CDO.Message)
        'Dim Wordsdt As New DataTable()
        'Wordsdt.Columns.Add("Word", GetType(String))

        'Wordsdt.Rows.Add("Wadea")
        'Wordsdt.Rows.Add("Wadea")
        'Wordsdt.Rows.Add("Wadea")

        'Dim query = From row In Wordsdt.AsEnumerable()
        '            Group By Word = row.Field(Of String)("Word")
        '            Into WordCount = Group
        '            Select Word, WordCount

        'For Each x In query
        '    MessageBox.Show(x.Word)

        'Next

        'Dim s As String = Wordsdt.AsEnumerable().Select(Function(r) r.Field(Of String)("Word")).Distinct().Count().ToString()

        '   Dim s As String = email.Fields.Item("urn:schemas:mailheader:content-type").Value




    End Sub

    Sub New(ByVal V_TabMain As TabControl)
        Dim file As StreamReader

        For Each p As TabPage In V_TabMain.TabPages
            For Each c In p.Controls
                If TypeOf (c) Is CheckBox Then
                    If Not (CType(c, CheckBox).Tag = "0" OrElse CType(c, CheckBox).Tag = "1") Then
                        If CType(c, CheckBox).Checked Then
                            FeatureDictionary.Add(c.Tag, "")
                        End If
                    End If
                ElseIf TypeOf (c) Is GroupBox Then
                    For Each ch As CheckBox In c.Controls
                        If Not (ch.Tag = "0" OrElse ch.Tag = "1") Then
                            If ch.Checked Then
                                FeatureDictionary.Add(ch.Tag, "")
                            End If
                        End If
                    Next
                End If
            Next
        Next

        file = New StreamReader("SpamWords.txt")
        While Not file.EndOfStream
            SpamWordList.Add(file.ReadLine())
        End While
        file.Close()

        file = New StreamReader("FunctionWords.txt")
        While Not file.EndOfStream
            FunctionWordList.Add(file.ReadLine())
        End While
        file.Close()

        jarRoot = "models\models"
        tagger = New MaxentTagger(jarRoot + "\wsj-0-18-bidirectional-nodistsim.tagger")

    End Sub

    Public Sub Controller(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Select Case FeatureKey
            Case "SimpleWords"
                CalcSimpleWords(FeatureKey, email)
            Case "SimpleWordsWithoutStopwords"
                CalcSimpleWordsWithoutStopwords(FeatureKey, email)
            Case "ComplexWords"
                CalcComplexWords(FeatureKey, email)
            Case "ComplexWordsWithoutStopwords"
                CalcComplexWordsWithoutStopwords(FeatureKey, email)
            Case "FogIndex"
                CalcFogIndex(FeatureKey, email)
            Case "FogIndexWithoutStopWords"
                CalcFogIndexWithoutStopWords(FeatureKey, email)
            Case "FISimple"
                CalcFISimple(FeatureKey, email)
            Case "FISimpleWithoutStopwords"
                CalcFISimpleWithoutStopwords(FeatureKey, email)
            Case "InverseFI"
                CalcInverseFI(FeatureKey, email)
            Case "InverseFI_WithoutStopwords"
                CalcInverseFIWithoutStopwords(FeatureKey, email)
            Case "FRES"
                CalcFRES(FeatureKey, email)
            Case "FRESWithoutStopwords"
                CalcFRESWithoutStopWords(FeatureKey, email)
            Case "SMOG-I"
                CalcSMOGI(FeatureKey, email)
            Case "SMOG"
                CalcSMOG(FeatureKey, email)
            Case "SMOG_WithoutStopWords"
                CalcSMOGWithoutStopwords(FeatureKey, email)
            Case "FORCAST"
                CalcFORCAST(FeatureKey, email)
            Case "FORCAST_WithoutStopwords"
                CalcFORCASTWithoutStopwords(FeatureKey, email)
            Case "FKRI"
                CalcFKRI(FeatureKey, email)
            Case "FKRI_WithoutStopwords"
                CalcFKRIWithoutStopwords(FeatureKey, email)
            Case "ARI"
                CalcARI(FeatureKey, email)
            Case "CLI"
                CalcCLI(FeatureKey, email)
            Case "WordLength"
                CalcWordLength(FeatureKey, email)
            Case "WordLengthWithoutStopwords"
                CalcWordLengthWithoutStopwords(FeatureKey, email)
            Case "SpamWords"
                CalcSpamWords(FeatureKey, email)
            Case "HTMLImage"
                CalcHTMLImage(FeatureKey, email)
            Case "HTMLAnchor"
                CalcHTMLAnchor(FeatureKey, email)
            Case "HTMLNotAnchor"
                CalcHTMLNotAnchor(FeatureKey, email)
            Case "HTMLTags"
                CalcHTMLTags(FeatureKey, email)
            Case "AlphaNumeric"
                CalcAlphaNumeric(FeatureKey, email)
            Case "AlphaNumericSubject"
                CalcAlphaNumericSubject(FeatureKey, email)
            Case "AlphaOnly"
                CalcAlphaOnly(FeatureKey, email)
            Case "AlphaOnlySubject"
                CalcAlphaOnlySubject(FeatureKey, email)
            Case "Verbs"
                CalcVerbs(FeatureKey, email)
            Case "FunctionWords"
                CalcFunctionWords(FeatureKey, email)
            Case "TFISF"
                CalcTFISF(FeatureKey, email)
            Case "TFISFWithoutStopwords"
                CalcTFISFWithoutStopwords(FeatureKey, email)
            Case "Year"
                GetYear(FeatureKey, email)
            Case "Month"
                GetMonth(FeatureKey, email)
            Case "Day"
                GetDay(FeatureKey, email)
            Case "Hour"
                GetHour(FeatureKey, email)
            Case "Minute"
                GetMinute(FeatureKey, email)
            Case "Second"
                GetSecond(FeatureKey, email)
            Case "FromGoogle"
                isFromGoogle(FeatureKey, email)
            Case "FromAOL"
                isFromAOL(FeatureKey, email)
            Case "FromGOV"
                isFromGOV(FeatureKey, email)
            Case "FromHotmail"
                isFromHotmail(FeatureKey, email)
            Case "FromMIL"
                isFromMIL(FeatureKey, email)
            Case "FromYahoo"
                isFromYAHOO(FeatureKey, email)
            Case "FromExample"
                isFromExample(FeatureKey, email)
            Case "ReplayGoogle"
                isReplayGoogle(FeatureKey, email)
            Case "ReplayAOL"
                isReplayAOL(FeatureKey, email)
            Case "ReplayGOV"
                isReplayGOV(FeatureKey, email)
            Case "ReplayHotmail"
                isReplayHotmail(FeatureKey, email)
            Case "ReplayMIL"
                isReplayMIL(FeatureKey, email)
            Case "ReplayYahoo"
                isReplayYAHOO(FeatureKey, email)
            Case "ToGoogle"
                isToGoogle(FeatureKey, email)
            Case "ToAOL"
                isToAOL(FeatureKey, email)
            Case "ToGOV"
                isToGOV(FeatureKey, email)
            Case "ToHotmail"
                isToHotmail(FeatureKey, email)
            Case "ToMIL"
                isToMIL(FeatureKey, email)
            Case "ToYahoo"
                isToYAHOO(FeatureKey, email)
            Case "ToExample"
                isToExample(FeatureKey, email)
            Case "ToMSN"
                isToMSN(FeatureKey, email)
            Case "ToLocalhost"
                isToLocalhost(FeatureKey, email)
            Case "CountSentence"
                CalcCountOfSentence(FeatureKey, email)
            Case "QuestionMark"
                CountOfQuestionMark(FeatureKey, email)
            Case "ExclamationMark"
                CountOfExclamationMark(FeatureKey, email)
            Case "Comma"
                CountOfComma(FeatureKey, email)
            Case "SemiColon"
                CountOfSemiColon(FeatureKey, email)
            Case "Colon"
                CountOfColon(FeatureKey, email)
            Case "SingleQuote"
                CountOfSingleQuote(FeatureKey, email)
            Case "Period"
                CountOfPeriod(FeatureKey, email)
            Case "Space"
                CountOfSpace(FeatureKey, email)
            Case "Tab"
                CountOfTab(FeatureKey, email)
            Case "Dollar"
                CountOfDollar(FeatureKey, email)
            Case "Ellipsis"
                CountOfEllipsis(FeatureKey, email)
            Case "CountWord"
                CalcCountWords(FeatureKey, email)
            Case "AllCountCapWord"
                CalcAllCapWord(FeatureKey, email)
            Case "AllCountCapWordSubject"
                CalcAllCapWordSubject(FeatureKey, email)
            Case "AllCountDigitWord"
                CalcAllDigitWord(FeatureKey, email)
            Case "AllCountDigitWordSubject"
                CalcAllDigitWordSubject(FeatureKey, email)
            Case "CountCapWord"
                CalcCapWord(FeatureKey, email)
            Case "CountCapWordSubject"
                CalcCapWordSubject(FeatureKey, email)
            Case "CountWordLess3Char"
                CalcCountWordLess3(FeatureKey, email)
            Case "CountWordLonger6Char"
                CalcCountWordLonger6(FeatureKey, email)
            Case "WordsAVGChar"
                CalcCountWordAVG(FeatureKey, email)
            Case "WordsMaxCharSubject"
                CalcCountWordMaxSubject(FeatureKey, email)
            Case "WordsMaxChar"
                CalcCountWordMax(FeatureKey, email)
            Case "WordsMinChar"
                CalcCountWordMin(FeatureKey, email)
            Case "CountChars"
                CalcCountChars(FeatureKey, email)
            Case "CountCharsSubject"
                CalcCountCharsSubject(FeatureKey, email)
            Case "CountUpperChars"
                CalcCountUpperChars(FeatureKey, email)
            Case "CountLowerChars"
                CalcCountLowerChars(FeatureKey, email)
            Case "CountDigitChars"
                CalcCountDigitChars(FeatureKey, email)
            Case "SpecialChars"
                CalcCountSpecialChars(FeatureKey, email)
            Case "AlphaChars"
                CalcCountAlphaChars(FeatureKey, email)
            Case "SenBegUpper"
                CalcCountSenBegUpper(FeatureKey, email)
            Case "SenBegLower"
                CalcCountSenBegLower(FeatureKey, email)
            Case "MultipleQuestionMarks"
                CountOfMultipleQuestionMarks(FeatureKey, email)
            Case "MultipleExclamationMarks"
                CountOfMultipleExclamationMarks(FeatureKey, email)
            Case "CountLines"
                CountOfLines(FeatureKey, email)
            Case "LongestCapital"
                CalcCountLongestCapital(FeatureKey, email)
            Case "DuplicateWords"
                CalcCountDuplicateWords(FeatureKey, email)
            Case "SingleLetterWords"
                CalcSingleLetterWords(FeatureKey, email)
            Case "SingleLetterWordsSubject"
                CalcSingleLetterWordsSubject(FeatureKey, email)
            Case "SingleDigitWords"
                CalcSingleDigitWords(FeatureKey, email)
            Case "SingleDigitWordsSubject"
                CalcSingleDigitWordsSubject(FeatureKey, email)
            Case "SingleCharWords"
                CalcSingleCharWords(FeatureKey, email)
            Case "SingleCharWordsSubject"
                CalcSingleCharWordsSubject(FeatureKey, email)
            Case "CountOfAttachments"
                CountOfAttachments(FeatureKey, email)
            Case "CountOfTo"
                CountOfTo(FeatureKey, email)
            Case "CountofParagraphs"
                CountofParagraphs(FeatureKey, email)
            Case "AvgSentenceinParagraphs"
                AvgSentenceinParagraphs(FeatureKey, email)
            Case "AvgWordsinParagraphs"
                AvgWordsinParagraphs(FeatureKey, email)
            Case "AvgCharinParagraphs"
                AvgCharinParagraphs(FeatureKey, email)
            Case "AvgWordsinSentences"
                AvgWordsinSentences(FeatureKey, email)
            Case "RatioUpperLower"
                RatioUpperLower(FeatureKey, email)
            Case "RatioUpperLowerSubject"
                RatioUpperLowerSubject(FeatureKey, email)
            Case "RatioUpperToAll"
                RatioUpperToAll(FeatureKey, email)
            Case "RatioUpperToAllSubject"
                RatioUpperToAllSubject(FeatureKey, email)
            Case "RatioDigitToAll"
                RatioDigitToAll(FeatureKey, email)
            Case "RatioDigitToAllSubject"
                RatioDigitToAllSubject(FeatureKey, email)
            Case "RatioNonAlphaNumToAll"
                RatioNonAlphaNumToAll(FeatureKey, email)
            Case "RatioNonAlphaNumToAllSubject"
                RatioNonAlphaNumToAllSubject(FeatureKey, email)
            Case "X_Mailman_Version"
                X_Mailman_Version(FeatureKey, email)
            Case "VocabularyRichness"
                VocabularyRichness(FeatureKey, email)
            Case "Legomena"
                Legomena(FeatureKey, email)
            Case "YuleK"
                YuleK(FeatureKey, email)
            Case "Entropy"
                Entropy(FeatureKey, email)
            Case "TextPlainUnique"
                TextPlainUnique(FeatureKey, email)
            Case "MultipartAlternativeUnique"
                MultipartAlternativeUnique(FeatureKey, email)
            Case "MultipartMixedUnique"
                MultipartMixedUnique(FeatureKey, email)
            Case "Dislegomena"
                DisLegomena(FeatureKey, email)
            Case "Sichel"
                Sichel(FeatureKey, email)
            Case "Honore"
                Honore(FeatureKey, email)
            Case "UniqueHTMLAnchor"
                CalcUniqueHTMLAnchor(FeatureKey, email)
            Case "UniqueContentTypesAttachment"
                UniqueContentTypesAttachment(FeatureKey, email)
            Case "MinCharacterDiversity"
                MinCharacterDiversity(FeatureKey, email)
            Case "MinCharacterDiversitySubject"
                MinCharacterDiversitySubject(FeatureKey, email)
            Case "MaxLongestRepeatingCharacter"
                MaxLongestRepeatingCharacter(FeatureKey, email)
            Case "MaxLongestRepeatingCharacterSubject"
                MaxLongestRepeatingCharacterSubject(FeatureKey, email)
        End Select

    End Sub

    Private Function CountSyllable(ByVal word As String) As Integer
        word = word.ToLower.Trim.Replace("ome", "um").Replace("ime", "im").Replace("imn", "imen").Replace("ine", "in").Replace("ely", "ly").Replace("ure", "ur").Replace("ery", "ry")
        Dim lastWasVowel As Boolean = False
        Dim vowels As New List(Of Char)
        vowels.AddRange({"a", "e", "i", "o", "u", "y"})
        Dim count As Integer = 0
        For Each c As Char In word
            If vowels.Contains(c) Then
                If Not lastWasVowel Then
                    count += 1
                End If
                lastWasVowel = True
            Else
                lastWasVowel = False
            End If
        Next

        If (word.EndsWith("ing") OrElse word.EndsWith("ings")) Then
            If (word.Length > 4 AndAlso vowels.Contains(word(word.Length - 4))) Then
                count += 1
            End If
        End If


        If (word.EndsWith("e") AndAlso Not word.EndsWith("le")) Then
            count -= 1
        End If


        If (word.EndsWith("es")) Then
            If (word.Length > 4 AndAlso vowels.Contains(word(word.Length - 4))) Then
                count -= 1
            End If
        End If


        If (word.EndsWith("e's")) Then
            If (word.Length > 5 AndAlso vowels.Contains(word(word.Length - 5))) Then
                count -= 1
            End If
        End If


        If (word.EndsWith("ed") AndAlso Not word.EndsWith("ted") AndAlso Not word.EndsWith("ded")) Then
            count -= 1
        End If


        Return IIf(count < 0, 0, count)

    End Function

    Private Function SumSyllable(ByVal email As CDO.Message) As Integer

        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml

        Dim CountS As Integer = 0


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    CountS += CountSyllable(s(i).ToString)
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    CountS += CountSyllable(s(i).ToString)
                Next
            Next
        End If

        Return CountS

    End Function

    Private Function SumSyllableWithoutStopwords(ByVal email As CDO.Message) As Integer

        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml

        Dim CountS As Integer = 0


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If Not FunctionWordList.Contains(s(i).ToString) Then
                        CountS += CountSyllable(s(i).ToString)
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If Not FunctionWordList.Contains(s(i).ToString) Then
                        CountS += CountSyllable(s(i).ToString)
                    End If
                Next
            Next
        End If

        Return CountS

    End Function
    Private Function CountSimpleWords(ByVal email As CDO.Message) As Integer
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml

        Dim CountS As Integer


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    CountS = CountSyllable(s(i).ToString)
                    If CountS <> 0 AndAlso CountS <= 2 Then
                        C += 1
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    CountS = CountSyllable(s(i).ToString)
                    If CountS <> 0 AndAlso CountS <= 2 Then
                        C += 1
                    End If
                Next
            Next
        End If

        Return C

    End Function

    Private Function CountSimpleWordsWithoutStopwords(ByVal email As CDO.Message) As Integer
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml

        Dim CountS As Integer


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If Not FunctionWordList.Contains(s(i).ToString) Then
                        CountS = CountSyllable(s(i).ToString)
                        If CountS <> 0 AndAlso CountS <= 2 Then
                            C += 1
                        End If
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If Not FunctionWordList.Contains(s(i).ToString) Then
                        CountS = CountSyllable(s(i).ToString)
                        If CountS <> 0 AndAlso CountS <= 2 Then
                            C += 1
                        End If
                    End If
                Next
            Next
        End If

        Return C

    End Function

    Private Function CountComplexWords(ByVal email As CDO.Message) As Integer
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml

        Dim CountS As Integer


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    CountS = CountSyllable(s(i).ToString)
                    If CountS <> 0 AndAlso CountS >= 3 Then
                        C += 1
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    CountS = CountSyllable(s(i).ToString)
                    If CountS <> 0 AndAlso CountS >= 3 Then
                        C += 1
                    End If
                Next
            Next
        End If

        Return C

    End Function

    Private Function CountComplexWordsWithoutStopwords(ByVal email As CDO.Message) As Integer
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml

        Dim CountS As Integer


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If Not FunctionWordList.Contains(s(i).ToString) Then
                        CountS = CountSyllable(s(i).ToString)
                        If CountS <> 0 AndAlso CountS >= 3 Then
                            C += 1
                        End If
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If Not FunctionWordList.Contains(s(i).ToString) Then
                        CountS = CountSyllable(s(i).ToString)
                        If CountS <> 0 AndAlso CountS >= 3 Then
                            C += 1
                        End If
                    End If
                Next
            Next
        End If

        Return C

    End Function

    Private Function CountWords(ByVal email As CDO.Message) As Integer
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsLetter(ch)) = s(i).ToString.Count Then
                        C += 1
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsLetter(ch)) = s(i).ToString.Count Then
                        C += 1
                    End If
                Next
            Next
        End If

        Return C

    End Function

    Private Function CountWordsWithoutStopWords(ByVal email As CDO.Message) As Integer
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If Not FunctionWordList.Contains(s(i).ToString) Then
                        If s(i).ToString.Count(Function(ch As Char) Char.IsLetter(ch)) = s(i).ToString.Count Then
                            C += 1
                        End If
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If Not FunctionWordList.Contains(s(i).ToString) Then
                        If s(i).ToString.Count(Function(ch As Char) Char.IsLetter(ch)) = s(i).ToString.Count Then
                            C += 1
                        End If
                    End If
                Next
            Next
        End If

        Return C

    End Function

    Private Function CountOfSentance(ByVal email As CDO.Message)
        Dim text As String
        Dim sentencesText
        Dim html As String
        Dim sentenceshtml
        Dim SentencesCount As Integer = 0

        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))
            SentencesCount += CType(sentencesText, List).size
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))
            SentencesCount += CType(sentenceshtml, List).size
        End If

        Return SentencesCount
    End Function

    Private Sub CalcSimpleWords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = CountSimpleWords(email)
    End Sub
    Private Sub CalcSimpleWordsWithoutStopwords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = CountSimpleWordsWithoutStopwords(email)
    End Sub

    Private Sub CalcComplexWords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = CountComplexWords(email)
    End Sub

    Private Sub CalcComplexWordsWithoutStopwords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = CountComplexWordsWithoutStopwords(email)
    End Sub

    Private Sub CalcFogIndex(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim CS As Integer = CountOfSentance(email)
        Dim CW As Integer = CountWords(email)
        If CS <> 0 AndAlso CW <> 0 Then
            FeatureDictionary.Item(FeatureKey) = 0.4 * ((CountWords(email) / CS) + (100 * (CountComplexWords(email) / CW)))
        Else
            FeatureDictionary.Item(FeatureKey) = 0
        End If
    End Sub

    Private Sub CalcFogIndexWithoutStopWords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim CS As Integer = CountOfSentance(email)
        Dim CW As Integer = CountWordsWithoutStopWords(email)
        If CS <> 0 AndAlso CW <> 0 Then
            FeatureDictionary.Item(FeatureKey) = 0.4 * ((CountWordsWithoutStopWords(email) / CS) + (100 * (CountComplexWordsWithoutStopwords(email) / CW)))
        Else
            FeatureDictionary.Item(FeatureKey) = 0
        End If
    End Sub

    Private Sub CalcFISimple(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim CS As Integer = CountOfSentance(email)
        Dim CW As Integer = CountWords(email)
        If CS <> 0 AndAlso CW <> 0 Then
            FeatureDictionary.Item(FeatureKey) = 0.4 * ((CountWords(email) / CS) + (100 * (CountSimpleWords(email) / CW)))
        Else
            FeatureDictionary.Item(FeatureKey) = 0
        End If
    End Sub

    Private Sub CalcFISimpleWithoutStopwords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim CS As Integer = CountOfSentance(email)
        Dim CW As Integer = CountWordsWithoutStopWords(email)
        If CS <> 0 AndAlso CW <> 0 Then
            FeatureDictionary.Item(FeatureKey) = 0.4 * ((CountWordsWithoutStopWords(email) / CS) + (100 * (CountSimpleWordsWithoutStopwords(email) / CW)))
        Else
            FeatureDictionary.Item(FeatureKey) = 0
        End If
    End Sub

    Private Sub CalcInverseFI(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = (1 / (0.4 * ((CountWords(email) / CountOfSentance(email)) + (100 * (CountComplexWords(email) / CountWords(email))))))
    End Sub

    Private Sub CalcInverseFIWithoutStopwords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = (1 / (0.4 * ((CountWordsWithoutStopWords(email) / CountOfSentance(email)) + (100 * (CountComplexWordsWithoutStopwords(email) / CountWordsWithoutStopWords(email))))))
    End Sub

    Private Sub CalcFRES(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim CS As Integer = CountOfSentance(email)
        Dim CW As Integer = CountWords(email)
        If CS <> 0 AndAlso CW <> 0 Then
            FeatureDictionary.Item(FeatureKey) = 206.835 - (1.015 * (CountWords(email) / CS)) - (84.6 * (SumSyllable(email) / CW))
        Else
            FeatureDictionary.Item(FeatureKey) = 0
        End If

    End Sub
    Private Sub CalcFRESWithoutStopWords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim CS As Integer = CountOfSentance(email)
        Dim CW As Integer = CountWordsWithoutStopWords(email)
        If CS <> 0 AndAlso CW <> 0 Then
            FeatureDictionary.Item(FeatureKey) = 206.835 - (1.015 * (CountWordsWithoutStopWords(email) / CS)) - (84.6 * (SumSyllableWithoutStopwords(email) / CW))
        Else
            FeatureDictionary.Item(FeatureKey) = 0
        End If
    End Sub

    Private Sub CalcSMOGI(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = 1.043 * Math.Sqrt(30 * (CountComplexWords(email) / CountOfSentance(email))) + 3.1219
    End Sub

    Private Sub CalcSMOG(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = Math.Sqrt(30 * (CountComplexWords(email) / CountOfSentance(email))) + 3
    End Sub
    Private Sub CalcSMOGWithoutStopwords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = Math.Sqrt(30 * (CountComplexWordsWithoutStopwords(email) / CountOfSentance(email))) + 3
    End Sub

    Private Sub CalcFORCAST(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = 20 - (CountSimpleWords(email) / 10)
    End Sub

    Private Sub CalcFORCASTWithoutStopwords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = 20 - (CountSimpleWordsWithoutStopwords(email) / 10)
    End Sub

    Private Sub CalcFKRI(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim CS As Integer = CountOfSentance(email)
        Dim CW As Integer = CountWords(email)
        If CS <> 0 AndAlso CW <> 0 Then
            FeatureDictionary.Item(FeatureKey) = (0.39 * (CountSimpleWords(email) / CS)) + (11.8 * (SumSyllable(email) / CW)) - 15.59
        Else
            FeatureDictionary.Item(FeatureKey) = 0
        End If
    End Sub
    Private Sub CalcFKRIWithoutStopwords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim CS As Integer = CountOfSentance(email)
        Dim CW As Integer = CountWordsWithoutStopWords(email)
        If CS <> 0 AndAlso CW <> 0 Then
            FeatureDictionary.Item(FeatureKey) = (0.39 * (CountSimpleWordsWithoutStopwords(email) / CS)) + (11.8 * (SumSyllableWithoutStopwords(email) / CW)) - 15.59
        Else
            FeatureDictionary.Item(FeatureKey) = 0
        End If
    End Sub

    Private Sub CalcARI(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim q As Integer = 0
        q += email.TextBody.Length
        q += email.HTMLBody.Length
        Dim CS As Integer = CountOfSentance(email)
        Dim CW As Integer = CountSimpleWords(email)
        If CS <> 0 AndAlso CW <> 0 Then
            FeatureDictionary.Item(FeatureKey) = (4.71 * (q / CW)) + (0.5 * (CountSimpleWords(email) / CS)) - 21.43
        Else
            FeatureDictionary.Item(FeatureKey) = 0
        End If
    End Sub

    Private Sub CalcCLI(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim q As Integer = 0
        q += email.TextBody.Length
        q += email.HTMLBody.Length
        Dim W As Integer = CountWords(email)
        Dim CW As Integer = CountSimpleWords(email)
        If W <> 0 AndAlso CW <> 0 Then
            FeatureDictionary.Item(FeatureKey) = (0.0588 * (q / W)) - (0.296 * (CountOfSentance(email) / CW)) - 15.8
        Else
            FeatureDictionary.Item(FeatureKey) = 0
        End If

    End Sub

    Private Sub CalcWordLength(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim CW As Integer = CountWords(email)
        If CW <> 0 Then
            FeatureDictionary.Item(FeatureKey) = SumSyllable(email) / CW
        Else
            FeatureDictionary.Item(FeatureKey) = 0
        End If
    End Sub

    Private Sub CalcWordLengthWithoutStopwords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim CW As Integer = CountWordsWithoutStopWords(email)
        If CW <> 0 Then
            FeatureDictionary.Item(FeatureKey) = SumSyllableWithoutStopwords(email) / CW
        Else
            FeatureDictionary.Item(FeatureKey) = 0
        End If

    End Sub

    Private Sub CalcSpamWords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim AllMatchResults As MatchCollection
        Dim RegexObj As Regex
        Dim c As Integer = 0
        For Each s As String In SpamWordList
            RegexObj = New Regex(" " + s.ToLower + " ")
            AllMatchResults = RegexObj.Matches(email.TextBody.ToLower)
            c += AllMatchResults.Count
            AllMatchResults = RegexObj.Matches(email.HTMLBody.ToLower)
            c += AllMatchResults.Count
        Next
        FeatureDictionary.Item(FeatureKey) = c
    End Sub
    Private Sub CalcHTMLImage(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim h As New HtmlAgilityPack.HtmlDocument
        Dim c As Integer = 0
        Dim root As HtmlNode

        If email.HTMLBody <> "" Then
            h.LoadHtml(email.HTMLBody)
            root = h.DocumentNode
            For Each link As HtmlNode In root.Descendants("img")
                c += 1
            Next
        End If


        If email.TextBody <> "" Then
            h.LoadHtml(email.TextBody)
            root = h.DocumentNode
            For Each link As HtmlNode In root.Descendants("img")
                c += 1
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CalcHTMLAnchor(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim h As New HtmlAgilityPack.HtmlDocument
        Dim c As Integer = 0
        Dim root As HtmlNode

        If email.HTMLBody <> "" Then
            h.LoadHtml(email.HTMLBody)
            root = h.DocumentNode
            For Each link As HtmlNode In root.Descendants("a")
                c += 1
            Next
        End If


        If email.TextBody <> "" Then
            h.LoadHtml(email.TextBody)
            root = h.DocumentNode
            For Each link As HtmlNode In root.Descendants("a")
                c += 1
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CalcHTMLNotAnchor(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim h As New HtmlAgilityPack.HtmlDocument
        Dim c As Integer = 0
        Dim n As Integer = 0
        Dim root As HtmlNode

        If email.HTMLBody <> "" Then
            h.LoadHtml(email.HTMLBody)
            root = h.DocumentNode
            n += root.Descendants.Count
            For Each link As HtmlNode In root.Descendants("a")
                c += 1
            Next
        End If


        If email.TextBody <> "" Then
            h.LoadHtml(email.TextBody)
            root = h.DocumentNode
            n += root.Descendants.Count
            For Each link As HtmlNode In root.Descendants("a")
                c += 1
            Next
        End If


        FeatureDictionary.Item(FeatureKey) = n - c
    End Sub

    Private Sub CalcHTMLTags(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim h As New HtmlAgilityPack.HtmlDocument
        Dim n As Integer = 0
        Dim root As HtmlNode

        If email.HTMLBody <> "" Then
            h.LoadHtml(email.HTMLBody)
            root = h.DocumentNode
            n += root.Descendants.Count
        End If


        If email.TextBody <> "" Then
            h.LoadHtml(email.TextBody)
            root = h.DocumentNode
            n += root.Descendants.Count
        End If


        FeatureDictionary.Item(FeatureKey) = n
    End Sub

    Private Sub CalcAlphaNumeric(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim alphaNumMatchesText As MatchCollection = Regex.Matches(email.TextBody, "(?=\w{2,})(?=\w*\d+)(?=\w*\p{L}+)(\w{2,})",
       RegexOptions.CultureInvariant Or RegexOptions.IgnoreCase)
        Dim alphaNumMatchesHTML As MatchCollection = Regex.Matches(email.HTMLBody, "(?=\w{2,})(?=\w*\d+)(?=\w*\p{L}+)(\w{2,})",
       RegexOptions.CultureInvariant Or RegexOptions.IgnoreCase)
        FeatureDictionary.Item(FeatureKey) = alphaNumMatchesText.Count + alphaNumMatchesHTML.Count
    End Sub

    Private Sub CalcAlphaNumericSubject(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim alphaNumMatchesText As MatchCollection = Regex.Matches(email.Subject, "(?=\w{2,})(?=\w*\d+)(?=\w*\p{L}+)(\w{2,})",
       RegexOptions.CultureInvariant Or RegexOptions.IgnoreCase)

        FeatureDictionary.Item(FeatureKey) = alphaNumMatchesText.Count
    End Sub

    Private Sub CalcAlphaOnlySubject(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText




        If email.Subject <> "" Then
            text = email.Subject
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsLetter(ch)) = s(i).ToString.Count Then
                        C += 1
                    End If
                Next
            Next
        End If





        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcAlphaOnly(ByVal FeatureKey As String, ByVal email As CDO.Message)

        FeatureDictionary.Item(FeatureKey) = CountWords(email)

    End Sub

    Private Sub CalcSingleLetterWords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsLetter(ch)) = s(i).ToString.Count AndAlso s(i).ToString.Count = 1 Then
                        C += 1
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsLetter(ch)) = s(i).ToString.Count AndAlso s(i).ToString.Count = 1 Then
                        C += 1
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcSingleLetterWordsSubject(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText

        If email.Subject <> "" Then
            text = email.Subject
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsLetter(ch)) = s(i).ToString.Count AndAlso s(i).ToString.Count = 1 Then
                        C += 1
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcSingleDigitWords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsDigit(ch)) = s(i).ToString.Count AndAlso s(i).ToString.Count = 1 Then
                        C += 1
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsDigit(ch)) = s(i).ToString.Count AndAlso s(i).ToString.Count = 1 Then
                        C += 1
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcSingleDigitWordsSubject(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText

        If email.Subject <> "" Then
            text = email.Subject
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsDigit(ch)) = s(i).ToString.Count AndAlso s(i).ToString.Count = 1 Then
                        C += 1
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcSingleCharWords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count = 1 Then
                        C += 1
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count = 1 Then
                        C += 1
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcSingleCharWordsSubject(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText

        If email.Subject <> "" Then
            text = email.Subject
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count = 1 Then
                        C += 1
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub
    Private Sub CalcAllCapWord(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsUpper(ch)) = s(i).ToString.Count Then
                        C += 1
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsUpper(ch)) = s(i).ToString.Count Then
                        C += 1
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcAllCapWordSubject(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText

        If email.Subject <> "" Then
            text = email.Subject
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsUpper(ch)) = s(i).ToString.Count Then
                        C += 1
                    End If
                Next
            Next
        End If
        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcAllDigitWord(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsDigit(ch)) = s(i).ToString.Count Then
                        C += 1
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsDigit(ch)) = s(i).ToString.Count Then
                        C += 1
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcAllDigitWordSubject(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText

        If email.Subject <> "" Then
            text = email.Subject
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsDigit(ch)) = s(i).ToString.Count Then
                        C += 1
                    End If
                Next
            Next
        End If
        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcCapWord(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If Char.IsUpper(s(i).ToString(0)) Then
                        C += 1
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If Char.IsUpper(s(i).ToString(0)) Then
                        C += 1
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcCapWordSubject(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText

        If email.Subject <> "" Then
            text = email.Subject
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If Char.IsUpper(s(i).ToString(0)) Then
                        C += 1
                    End If
                Next
            Next
        End If
        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcVerbs(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText
        Dim taggedSentenceText As List

        Dim html As String
        Dim sentenceshtml
        Dim taggedSentencehtml As List


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text)).toArray()

            For Each s As ArrayList In sentencesText
                taggedSentenceText = tagger.tagSentence(s)
                For Each t As TaggedWord In taggedSentenceText.toArray
                    If t.tag.Contains("VB") Then
                        C += 1
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html)).toArray()

            For Each s As ArrayList In sentenceshtml
                taggedSentencehtml = tagger.tagSentence(s)
                For Each t As TaggedWord In taggedSentencehtml.toArray
                    If t.tag.Contains("VB") Then
                        C += 1
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcFunctionWords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim AllMatchResults As MatchCollection
        Dim RegexObj As Regex
        Dim c As Integer = 0
        For Each s As String In FunctionWordList
            RegexObj = New Regex(" " + s.ToLower + " ")
            AllMatchResults = RegexObj.Matches(email.TextBody.ToLower)
            c += AllMatchResults.Count
            AllMatchResults = RegexObj.Matches(email.HTMLBody.ToLower)
            c += AllMatchResults.Count
        Next
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CalcTFISF(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Int64 = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        Dim SentencesCount As Integer = 0
        Dim TermDictionary As New Dictionary(Of String, Integer())
        Dim flg As Integer = 0



        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))
            SentencesCount += CType(sentencesText, List).size

            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If Not TermDictionary.ContainsKey(s(i).ToString) Then
                        TermDictionary.Add(s(i).ToString, {1, 1})
                        flg = 1
                    Else
                        TermDictionary(s(i).ToString)(0) += 1
                        If flg = 0 Then
                            TermDictionary(s(i).ToString)(1) += 1
                            flg = 1
                        End If
                    End If
                Next
                flg = 0
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))
            SentencesCount += CType(sentenceshtml, List).size

            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If Not TermDictionary.ContainsKey(s(i).ToString) Then
                        TermDictionary.Add(s(i).ToString, {1, 1})
                        flg = 1
                    Else
                        TermDictionary(s(i).ToString)(0) += 1
                        If flg = 0 Then
                            TermDictionary(s(i).ToString)(1) += 1
                            flg = 1
                        End If
                    End If
                Next
                flg = 0
            Next
        End If



        For Each k As String In TermDictionary.Keys.ToArray
            C += (1 + Math.Log(TermDictionary(k)(0))) * (Math.Log(SentencesCount / TermDictionary(k)(1)))
        Next

        FeatureDictionary.Item(FeatureKey) = C


    End Sub

    Private Sub CalcTFISFWithoutStopwords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Int64 = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        Dim SentencesCount As Integer = 0
        Dim TermDictionary As New Dictionary(Of String, Integer())
        Dim flg As Integer = 0



        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))
            SentencesCount += CType(sentencesText, List).size

            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If Not FunctionWordList.Contains(s(i).ToString) Then
                        If Not TermDictionary.ContainsKey(s(i).ToString) Then
                            TermDictionary.Add(s(i).ToString, {1, 1})
                            flg = 1
                        Else
                            TermDictionary(s(i).ToString)(0) += 1
                            If flg = 0 Then
                                TermDictionary(s(i).ToString)(1) += 1
                                flg = 1
                            End If
                        End If
                    End If
                Next
                flg = 0
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))
            SentencesCount += CType(sentenceshtml, List).size

            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If Not FunctionWordList.Contains(s(i).ToString) Then
                        If Not TermDictionary.ContainsKey(s(i).ToString) Then
                            TermDictionary.Add(s(i).ToString, {1, 1})
                            flg = 1
                        Else
                            TermDictionary(s(i).ToString)(0) += 1
                            If flg = 0 Then
                                TermDictionary(s(i).ToString)(1) += 1
                                flg = 1
                            End If
                        End If
                    End If
                Next
                flg = 0
            Next
        End If



        For Each k As String In TermDictionary.Keys.ToArray
            C += (1 + Math.Log(TermDictionary(k)(0))) * (Math.Log(SentencesCount / TermDictionary(k)(1)))
        Next

        FeatureDictionary.Item(FeatureKey) = C


    End Sub

    Private Sub GetYear(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = email.ReceivedTime.Year
    End Sub

    Private Sub GetMonth(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = email.ReceivedTime.Month
    End Sub

    Private Sub GetDay(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = email.ReceivedTime.DayOfWeek
    End Sub

    Private Sub GetHour(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = email.ReceivedTime.Hour
    End Sub

    Private Sub GetMinute(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = email.ReceivedTime.Minute
    End Sub

    Private Sub GetSecond(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = email.ReceivedTime.Second
    End Sub

    Private Sub isFromGoogle(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.From.ToUpper.Contains("GMAIL.COM") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isFromAOL(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.From.ToUpper.Contains("AOL.COM") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isFromGOV(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.From.ToUpper.Contains(".GOV") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isFromHotmail(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.From.ToUpper.Contains("HOTMAIL.COM") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isFromMIL(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.From.ToUpper.Contains(".MIL") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isFromYAHOO(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.From.ToUpper.Contains("YAHOO.COM") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isFromExample(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.From.ToUpper.Contains("EXAMPLE.COM") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isReplayGoogle(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.ReplyTo.ToUpper.Contains("GMAIL.COM") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isReplayAOL(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.ReplyTo.ToUpper.Contains("AOL.COM") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isReplayGOV(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.ReplyTo.ToUpper.Contains(".GOV") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isReplayHotmail(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.ReplyTo.ToUpper.Contains("HOTMAIL.COM") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isReplayMIL(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.ReplyTo.ToUpper.Contains(".MIL") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isReplayYAHOO(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.ReplyTo.ToUpper.Contains("YAHOO.COM") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isToGoogle(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.To.ToUpper.Contains("GMAIL.COM") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isToAOL(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.To.ToUpper.Contains("AOL.COM") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isToGOV(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.To.ToUpper.Contains(".GOV") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isToHotmail(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.To.ToUpper.Contains("HOTMAIL.COM") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isToMIL(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.To.ToUpper.Contains(".MIL") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isToYAHOO(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.To.ToUpper.Contains("YAHOO.COM") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isToExample(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.To.ToUpper.Contains("EXAMPLE.COM") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isToMSN(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.To.ToUpper.Contains("MSN") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub isToLocalhost(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim flg As Integer
        If email.To.ToUpper.Contains("LOCALHOST") Then
            flg = 1
        Else
            flg = 0
        End If
        FeatureDictionary.Item(FeatureKey) = flg
    End Sub

    Private Sub CalcCountOfSentence(ByVal FeatureKey As String, ByVal email As CDO.Message)

        FeatureDictionary.Item(FeatureKey) = CountOfSentance(email)


    End Sub

    Private Sub CountOfQuestionMark(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.TextBody.Count(Function(ch As Char) ch = "?")
        c += email.HTMLBody.Count(Function(ch As Char) ch = "?")
        FeatureDictionary.Item(FeatureKey) = c
    End Sub


    Private Sub CountOfMultipleQuestionMarks(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim AllMatchResults As MatchCollection
        Dim RegexObj As Regex
        Dim c As Integer = 0
        RegexObj = New Regex("\?{2,}")
        AllMatchResults = RegexObj.Matches(email.TextBody.ToLower)
        c += AllMatchResults.Count
        AllMatchResults = RegexObj.Matches(email.HTMLBody.ToLower)
        c += AllMatchResults.Count

        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CountOfMultipleExclamationMarks(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim AllMatchResults As MatchCollection
        Dim RegexObj As Regex
        Dim c As Integer = 0
        RegexObj = New Regex("\!{2,}")
        AllMatchResults = RegexObj.Matches(email.TextBody.ToLower)
        c += AllMatchResults.Count
        AllMatchResults = RegexObj.Matches(email.HTMLBody.ToLower)
        c += AllMatchResults.Count

        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CountOfExclamationMark(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.TextBody.Count(Function(ch As Char) ch = "!")
        c += email.HTMLBody.Count(Function(ch As Char) ch = "!")
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CountOfComma(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.TextBody.Count(Function(ch As Char) ch = ",")
        c += email.HTMLBody.Count(Function(ch As Char) ch = ",")
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CountOfSemiColon(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.TextBody.Count(Function(ch As Char) ch = ";")
        c += email.HTMLBody.Count(Function(ch As Char) ch = ";")
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CountOfColon(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.TextBody.Count(Function(ch As Char) ch = ":")
        c += email.HTMLBody.Count(Function(ch As Char) ch = ":")
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CountOfSingleQuote(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.TextBody.Count(Function(ch As Char) ch = "'")
        c += email.HTMLBody.Count(Function(ch As Char) ch = "'")
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CountOfPeriod(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.TextBody.Count(Function(ch As Char) ch = ".")
        c += email.HTMLBody.Count(Function(ch As Char) ch = ".")
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CountOfSpace(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.TextBody.Count(Function(ch As Char) ch = " ")
        c += email.HTMLBody.Count(Function(ch As Char) ch = " ")
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CountOfTab(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.TextBody.Count(Function(ch As Char) ch = ControlChars.Tab)
        c += email.HTMLBody.Count(Function(ch As Char) ch = ControlChars.Tab)
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CountOfDollar(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.TextBody.Count(Function(ch As Char) ch = "$")
        c += email.HTMLBody.Count(Function(ch As Char) ch = "$")
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CountOfEllipsis(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim AllMatchResults As MatchCollection
        Dim RegexObj As Regex
        Dim c As Integer = 0
        RegexObj = New Regex("\.{3}")
        AllMatchResults = RegexObj.Matches(email.TextBody.ToLower)
        c += AllMatchResults.Count
        AllMatchResults = RegexObj.Matches(email.HTMLBody.ToLower)
        c += AllMatchResults.Count

        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CalcCountWords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If Not s(i).ToString.Count(Function(ch As Char) Not Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                        C += 1
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If Not s(i).ToString.Count(Function(ch As Char) Not Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                        C += 1
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcCountWordLess3(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If Not s(i).ToString.Count(Function(ch As Char) Not Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                        If s(i).ToString.Count <= 3 Then
                            C += 1
                        End If
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If Not s(i).ToString.Count(Function(ch As Char) Not Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                        If s(i).ToString.Count <= 3 Then
                            C += 1
                        End If
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcCountWordLonger6(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If Not s(i).ToString.Count(Function(ch As Char) Not Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                        If s(i).ToString.Count > 6 Then
                            C += 1
                        End If
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If Not s(i).ToString.Count(Function(ch As Char) Not Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                        If s(i).ToString.Count > 6 Then
                            C += 1
                        End If
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcCountWordAVG(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Decimal = 0.0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml

        Dim WordCount As Integer = 0
        Dim CharCount As Integer = 0

        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If Not s(i).ToString.Count(Function(ch As Char) Not Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then

                        CharCount += s(i).ToString.Count


                    End If
                Next
                WordCount += s.size
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If Not s(i).ToString.Count(Function(ch As Char) Not Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                        CharCount += s(i).ToString.Count
                    End If
                Next
                WordCount += s.size
            Next
        End If

        C = CharCount / WordCount

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcCountWordMax(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                        If C < s(i).ToString.Count Then
                            C = s(i).ToString.Count
                        End If
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                        If C < s(i).ToString.Count Then
                            C = s(i).ToString.Count
                        End If
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcCountWordMaxSubject(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText




        If email.Subject <> "" Then
            text = email.Subject
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                        If C < s(i).ToString.Count Then
                            C = s(i).ToString.Count
                        End If
                    End If
                Next
            Next
        End If


        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcCountWordMin(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim flg As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                        If C > s(i).ToString.Count OrElse flg = 0 Then
                            C = s(i).ToString.Count
                            flg = 1
                        End If
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                        If C > s(i).ToString.Count OrElse flg = 0 Then
                            C = s(i).ToString.Count
                            flg = 1
                        End If
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcCountChars(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.TextBody.Count()
        c += email.HTMLBody.Count()
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CalcCountCharsSubject(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.Subject.Count()
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CalcCountUpperChars(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.TextBody.Count(Function(ch As Char) Char.IsUpper(ch))
        c += email.HTMLBody.Count(Function(ch As Char) Char.IsUpper(ch))
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CalcCountLowerChars(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.TextBody.Count(Function(ch As Char) Char.IsLower(ch))
        c += email.HTMLBody.Count(Function(ch As Char) Char.IsLower(ch))
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CalcCountDigitChars(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.TextBody.Count(Function(ch As Char) Char.IsDigit(ch))
        c += email.HTMLBody.Count(Function(ch As Char) Char.IsDigit(ch))
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CalcCountSpecialChars(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.TextBody.Count(Function(ch As Char) Not Char.IsLetterOrDigit(ch) AndAlso ch <> vbCrLf AndAlso ch <> vbCr AndAlso ch <> vbLf)
        c += email.HTMLBody.Count(Function(ch As Char) Not Char.IsLetterOrDigit(ch) AndAlso ch <> vbCrLf AndAlso ch <> vbCr AndAlso ch <> vbLf)
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CalcCountAlphaChars(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        c += email.TextBody.Count(Function(ch As Char) Char.IsLetter(ch))
        c += email.HTMLBody.Count(Function(ch As Char) Char.IsLetter(ch))
        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CalcCountSenBegUpper(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If Char.IsLetter(s(i).ToString.Chars(0)) Then
                        If Char.IsUpper(s(i).ToString.Chars(0)) Then
                            C += 1
                        End If
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If Char.IsLetter(s(i).ToString.Chars(0)) Then
                        If Char.IsUpper(s(i).ToString.Chars(0)) Then
                            C += 1
                        End If
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CalcCountSenBegLower(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If Char.IsLetter(s(i).ToString.Chars(0)) Then
                        If Char.IsLower(s(i).ToString.Chars(0)) Then
                            C += 1
                        End If
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If Char.IsLetter(s(i).ToString.Chars(0)) Then
                        If Char.IsLower(s(i).ToString.Chars(0)) Then
                            C += 1
                        End If
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = C

    End Sub

    Private Sub CountOfLines(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim t As New TextBox
        Dim c As Integer = 0
        t.Text = email.TextBody
        c += t.Lines.Length
        t.Text = ""
        t.Text = email.HTMLBody
        c += t.Lines.Length

        FeatureDictionary.Item(FeatureKey) = c
    End Sub

    Private Sub CalcCountLongestCapital(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim longest As Integer = 0
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    For Each ch As Char In s(i).ToString
                        If Char.IsUpper(ch) Then
                            C += 1
                        Else
                            If longest < C Then
                                longest = C
                            End If
                            C = 0
                        End If
                    Next
                    If longest < C Then
                        longest = C
                    End If
                    C = 0
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    For Each ch As Char In s(i).ToString
                        If Char.IsUpper(ch) Then
                            C += 1
                        Else
                            If longest < C Then
                                longest = C
                            End If
                            C = 0
                        End If
                    Next
                    If longest < C Then
                        longest = C
                    End If
                    C = 0
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = longest

    End Sub

    Private Sub CalcCountDuplicateWords(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml


        Dim TermDictionary As New Dictionary(Of String, Integer)

        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                        If Not TermDictionary.ContainsKey(s(i).ToString.ToLower) Then
                            TermDictionary.Add(s(i).ToString.ToLower, 1)
                        Else
                            TermDictionary(s(i).ToString.ToLower) += 1

                        End If
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                        If Not TermDictionary.ContainsKey(s(i).ToString.ToLower) Then
                            TermDictionary.Add(s(i).ToString.ToLower, 1)
                        Else
                            TermDictionary(s(i).ToString.ToLower) += 1

                        End If
                    End If
                Next
            Next
        End If



        For Each k As String In TermDictionary.Keys.ToArray
            If TermDictionary(k) > 1 Then
                C += 1
            End If
        Next

        FeatureDictionary.Item(FeatureKey) = C


    End Sub

    Private Sub CountOfAttachments(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = email.Attachments.Count
    End Sub
    Private Sub CountOfTo(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = email.To.Split(",").Count
    End Sub
    Private Sub CountofParagraphs(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim c As Integer = 0
        Dim h As New HtmlAgilityPack.HtmlDocument
        Dim root As HtmlNode
        If email.TextBody <> "" Then
            Dim sArray() As String = email.TextBody.Split({vbCrLf, vbLf}, StringSplitOptions.RemoveEmptyEntries)
            For Each str As String In sArray
                If str.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) >= 1 Then
                    c += 1
                End If
            Next
        End If
        If email.HTMLBody <> "" Then
            h.LoadHtml(email.HTMLBody)
            root = h.DocumentNode
            For Each link As HtmlNode In root.Descendants("p")
                c += 1
            Next
        End If
        FeatureDictionary.Item(FeatureKey) = c
    End Sub
    Private Sub AvgSentenceinParagraphs(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim text As String
        Dim sentencesText
        Dim html As String
        Dim sentenceshtml
        Dim SentencesCount As Integer = 0

        Dim c As Integer = 0
        Dim h As New HtmlAgilityPack.HtmlDocument
        Dim root As HtmlNode
        If email.TextBody <> "" Then
            Dim sArray() As String = email.TextBody.Split({vbCrLf, vbLf}, StringSplitOptions.RemoveEmptyEntries)
            For Each str As String In sArray
                If str.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) >= 1 Then
                    text = str
                    sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))
                    SentencesCount += CType(sentencesText, List).size
                    c += 1
                End If
            Next
        End If
        If email.HTMLBody <> "" Then
            h.LoadHtml(email.HTMLBody)
            root = h.DocumentNode
            For Each link As HtmlNode In root.Descendants("p")
                html = link.InnerText
                sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))
                SentencesCount += CType(sentenceshtml, List).size
                c += 1
            Next
        End If
        FeatureDictionary.Item(FeatureKey) = IIf(c <> 0, SentencesCount / c, 0)

    End Sub

    Private Sub AvgWordsinParagraphs(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim text As String
        Dim sentencesText
        Dim html As String
        Dim sentenceshtml
        Dim WordsCount As Integer = 0

        Dim c As Integer = 0
        Dim h As New HtmlAgilityPack.HtmlDocument
        Dim root As HtmlNode
        If email.TextBody <> "" Then
            Dim sArray() As String = email.TextBody.Split({vbCrLf, vbLf}, StringSplitOptions.RemoveEmptyEntries)
            For Each str As String In sArray
                If str.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) >= 1 Then
                    text = str
                    sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))
                    For Each s As ArrayList In sentencesText
                        For i As Integer = 0 To s.size - 1
                            If s(i).ToString.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                                WordsCount += 1
                            End If
                        Next
                    Next
                    c += 1
                End If
            Next
        End If
        If email.HTMLBody <> "" Then
            h.LoadHtml(email.HTMLBody)
            root = h.DocumentNode
            For Each link As HtmlNode In root.Descendants("p")
                html = link.InnerText
                sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))
                For Each s As ArrayList In sentenceshtml
                    For i As Integer = 0 To s.size - 1
                        If s(i).ToString.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                            WordsCount += 1
                        End If
                    Next
                Next
                c += 1
            Next
        End If
        FeatureDictionary.Item(FeatureKey) = IIf(c <> 0, WordsCount / c, 0)

    End Sub

    Private Sub AvgCharinParagraphs(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim text As String
        Dim sentencesText
        Dim html As String
        Dim sentenceshtml
        Dim CharCount As Integer = 0

        Dim c As Integer = 0
        Dim h As New HtmlAgilityPack.HtmlDocument
        Dim root As HtmlNode
        If email.TextBody <> "" Then
            Dim sArray() As String = email.TextBody.Split({vbCrLf, vbLf}, StringSplitOptions.RemoveEmptyEntries)
            For Each str As String In sArray
                If str.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) >= 1 Then
                    text = str
                    sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))
                    For Each s As ArrayList In sentencesText
                        For i As Integer = 0 To s.size - 1
                            If s(i).ToString.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                                CharCount += s(i).ToString.Count
                            End If
                        Next
                    Next
                    c += 1
                End If
            Next
        End If
        If email.HTMLBody <> "" Then
            h.LoadHtml(email.HTMLBody)
            root = h.DocumentNode
            For Each link As HtmlNode In root.Descendants("p")
                html = link.InnerText
                sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))
                For Each s As ArrayList In sentenceshtml
                    For i As Integer = 0 To s.size - 1
                        If s(i).ToString.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                            CharCount += s(i).ToString.Count
                        End If
                    Next
                Next
                c += 1
            Next
        End If
        FeatureDictionary.Item(FeatureKey) = IIf(c <> 0, CharCount / c, 0)

    End Sub

    Private Sub AvgWordsinSentences(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim C As Integer = 0
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml
        Dim WordCount As Integer = 0


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                        WordCount += 1
                    End If
                Next
                C += 1
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count(Function(ch As Char) Char.IsLetterOrDigit(ch)) = s(i).ToString.Count Then
                        WordCount += 1
                    End If
                Next
                C += 1
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = WordCount / C


    End Sub

    Private Sub RatioUpperLower(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml

        Dim LowerCharCount As Integer = 0
        Dim UpperCharCount As Integer = 0
        Dim ratio As Decimal = 0.0
        Dim Maxratio As Decimal = 0.0

        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    LowerCharCount = s(i).ToString.Count(Function(ch As Char) Char.IsLower(ch))
                    UpperCharCount = s(i).ToString.Count(Function(ch As Char) Char.IsUpper(ch))
                    If LowerCharCount <> 0 AndAlso UpperCharCount <> 0 Then
                        ratio = UpperCharCount / LowerCharCount
                        If ratio > Maxratio Then
                            Maxratio = ratio
                        End If
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    LowerCharCount = s(i).ToString.Count(Function(ch As Char) Char.IsLower(ch))
                    UpperCharCount = s(i).ToString.Count(Function(ch As Char) Char.IsUpper(ch))
                    If LowerCharCount <> 0 AndAlso UpperCharCount <> 0 Then
                        ratio = UpperCharCount / LowerCharCount
                        If ratio > Maxratio Then
                            Maxratio = ratio
                        End If
                    End If
                Next
            Next
        End If



        FeatureDictionary.Item(FeatureKey) = Maxratio

    End Sub

    Private Sub RatioUpperLowerSubject(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim text As String
        Dim sentencesText


        Dim LowerCharCount As Integer = 0
        Dim UpperCharCount As Integer = 0
        Dim ratio As Decimal = 0.0
        Dim Maxratio As Decimal = 0.0


        text = email.Subject
        sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    LowerCharCount = s(i).ToString.Count(Function(ch As Char) Char.IsLower(ch))
                    UpperCharCount = s(i).ToString.Count(Function(ch As Char) Char.IsUpper(ch))
                    If LowerCharCount <> 0 AndAlso UpperCharCount <> 0 Then
                        ratio = UpperCharCount / LowerCharCount
                        If ratio > Maxratio Then
                            Maxratio = ratio
                        End If
                    End If
                Next
            Next





        FeatureDictionary.Item(FeatureKey) = Maxratio

    End Sub

    Private Sub RatioUpperToAll(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml

        Dim CharCount As Integer = 0
        Dim UpperCharCount As Integer = 0
        Dim ratio As Decimal = 0.0
        Dim Maxratio As Decimal = 0.0

        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    CharCount = s(i).ToString.Count
                    UpperCharCount = s(i).ToString.Count(Function(ch As Char) Char.IsUpper(ch))
                    If CharCount <> 0 AndAlso UpperCharCount <> 0 Then
                        ratio = UpperCharCount / CharCount
                        If ratio > Maxratio Then
                            Maxratio = ratio
                        End If
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    CharCount = s(i).ToString.Count
                    UpperCharCount = s(i).ToString.Count(Function(ch As Char) Char.IsUpper(ch))
                    If CharCount <> 0 AndAlso UpperCharCount <> 0 Then
                        ratio = UpperCharCount / CharCount
                        If ratio > Maxratio Then
                            Maxratio = ratio
                        End If
                    End If
                Next
            Next
        End If



        FeatureDictionary.Item(FeatureKey) = Maxratio

    End Sub


    Private Sub RatioUpperToAllSubject(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim text As String
        Dim sentencesText

        Dim CharCount As Integer = 0
        Dim UpperCharCount As Integer = 0
        Dim ratio As Decimal = 0.0
        Dim Maxratio As Decimal = 0.0


        text = email.Subject
        sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


        For Each s As ArrayList In sentencesText
            For i As Integer = 0 To s.size - 1
                CharCount = s(i).ToString.Count
                UpperCharCount = s(i).ToString.Count(Function(ch As Char) Char.IsUpper(ch))
                If CharCount <> 0 AndAlso UpperCharCount <> 0 Then
                    ratio = UpperCharCount / CharCount
                    If ratio > Maxratio Then
                        Maxratio = ratio
                    End If
                End If
            Next
        Next

        FeatureDictionary.Item(FeatureKey) = Maxratio

    End Sub

    Private Sub RatioDigitToAll(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml

        Dim CharCount As Integer = 0
        Dim DigitCount As Integer = 0
        Dim ratio As Decimal = 0.0
        Dim Maxratio As Decimal = 0.0

        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    CharCount = s(i).ToString.Count
                    DigitCount = s(i).ToString.Count(Function(ch As Char) Char.IsDigit(ch))
                    If CharCount <> 0 AndAlso DigitCount <> 0 Then
                        ratio = DigitCount / CharCount
                        If ratio > Maxratio Then
                            Maxratio = ratio
                        End If
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    CharCount = s(i).ToString.Count
                    DigitCount = s(i).ToString.Count(Function(ch As Char) Char.IsDigit(ch))
                    If CharCount <> 0 AndAlso DigitCount <> 0 Then
                        ratio = DigitCount / CharCount
                        If ratio > Maxratio Then
                            Maxratio = ratio
                        End If
                    End If
                Next
            Next
        End If



        FeatureDictionary.Item(FeatureKey) = Maxratio

    End Sub

    Private Sub RatioDigitToAllSubject(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim text As String
        Dim sentencesText

        Dim CharCount As Integer = 0
        Dim DigitCount As Integer = 0
        Dim ratio As Decimal = 0.0
        Dim Maxratio As Decimal = 0.0

        text = email.Subject
        sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    CharCount = s(i).ToString.Count
                    DigitCount = s(i).ToString.Count(Function(ch As Char) Char.IsDigit(ch))
                    If CharCount <> 0 AndAlso DigitCount <> 0 Then
                        ratio = DigitCount / CharCount
                        If ratio > Maxratio Then
                            Maxratio = ratio
                        End If
                    End If
                Next
            Next


            FeatureDictionary.Item(FeatureKey) = Maxratio

    End Sub

    Private Sub RatioNonAlphaNumToAll(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml

        Dim CharCount As Integer = 0
        Dim NonCount As Integer = 0
        Dim ratio As Decimal = 0.0
        Dim Maxratio As Decimal = 0.0

        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    CharCount = s(i).ToString.Count
                    NonCount = s(i).ToString.Count(Function(ch As Char) Not Char.IsLetterOrDigit(ch))
                    If CharCount <> 0 AndAlso NonCount <> 0 AndAlso CharCount <> NonCount Then
                        ratio = NonCount / CharCount
                        If ratio > Maxratio Then
                            Maxratio = ratio
                        End If
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    CharCount = s(i).ToString.Count
                    NonCount = s(i).ToString.Count(Function(ch As Char) Not Char.IsLetterOrDigit(ch))
                    If CharCount <> 0 AndAlso NonCount <> 0 AndAlso CharCount <> NonCount Then
                        ratio = NonCount / CharCount
                        If ratio > Maxratio Then
                            Maxratio = ratio
                        End If
                    End If
                Next
            Next
        End If



        FeatureDictionary.Item(FeatureKey) = Maxratio

    End Sub

    Private Sub RatioNonAlphaNumToAllSubject(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim text As String
        Dim sentencesText

        Dim CharCount As Integer = 0
        Dim NonCount As Integer = 0
        Dim ratio As Decimal = 0.0
        Dim Maxratio As Decimal = 0.0

        text = email.Subject
        sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


        For Each s As ArrayList In sentencesText
            For i As Integer = 0 To s.size - 1
                CharCount = s(i).ToString.Count
                NonCount = s(i).ToString.Count(Function(ch As Char) Not Char.IsLetterOrDigit(ch))
                If CharCount <> 0 AndAlso NonCount <> 0 AndAlso CharCount <> NonCount Then
                    ratio = NonCount / CharCount
                    If ratio > Maxratio Then
                        Maxratio = ratio
                    End If
                End If
            Next
        Next


        FeatureDictionary.Item(FeatureKey) = Maxratio

    End Sub

    Private Sub X_Mailman_Version(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = IIf(email.Fields.Item("urn:schemas:mailheader:X-Mailman-Version").Value <> "", email.Fields.Item("urn:schemas:mailheader:X-Mailman-Version").Value, "0")
    End Sub
    Private Sub VocabularyRichness(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim Wordsdt As New DataTable()
        Wordsdt.Columns.Add("Word", GetType(String))
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml

        Dim DistinctWordsCount As Integer = 0
        Dim WordsCount As Integer = 0


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    Wordsdt.Rows.Add(s(i).ToString)
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    Wordsdt.Rows.Add(s(i).ToString)
                Next
            Next
        End If

        WordsCount = Wordsdt.Rows.Count
        DistinctWordsCount = Wordsdt.AsEnumerable().Select(Function(r) r.Field(Of String)("Word")).Distinct().Count().ToString()

        FeatureDictionary.Item(FeatureKey) = DistinctWordsCount / WordsCount


    End Sub

    Private Sub Legomena(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim Wordsdt As New DataTable()
        Wordsdt.Columns.Add("Word", GetType(String))

        Dim legomenaVal As Integer = 0

        Dim text As String
        Dim sentencesText

        Dim html As String
        Dim sentenceshtml

        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))

            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    Wordsdt.Rows.Add(s(i).ToString)
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    Wordsdt.Rows.Add(s(i).ToString)
                Next
            Next
        End If


        Dim query = From row In Wordsdt.AsEnumerable()
                    Group By Word = row.Field(Of String)("Word")
                    Into WordCount = Group
                    Select Word, WordCount


        For Each w In query
            If w.WordCount.Count = 1 Then
                legomenaVal += 1
            End If
        Next

        FeatureDictionary.Item(FeatureKey) = legomenaVal


    End Sub

    Private Sub YuleK(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim Wordsdt As New DataTable()
        Wordsdt.Columns.Add("Word", GetType(String))

        Dim WordsCountDt As New DataTable()
        WordsCountDt.Columns.Add("Word", GetType(String))
        WordsCountDt.Columns.Add("Count", GetType(Integer))

        Dim OccursDt As New DataTable
        OccursDt.Columns.Add("Count", GetType(Integer))
        OccursDt.Columns.Add("CountOfCount", GetType(Integer))

        Dim k As Decimal = 0.0

        Dim text As String
        Dim sentencesText

        Dim html As String
        Dim sentenceshtml

        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))

            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    Wordsdt.Rows.Add(s(i).ToString)
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))

            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    Wordsdt.Rows.Add(s(i).ToString)
                Next
            Next
        End If


        Dim query = From row In Wordsdt.AsEnumerable()
                    Group By Word = row.Field(Of String)("Word")
                    Into WordCount = Group
                    Select Word, WordCount

        For Each w In query
            WordsCountDt.Rows.Add(w.Word, w.WordCount.Count)
        Next



        Dim query2 = From row In WordsCountDt.AsEnumerable()
                     Group By cnt = row.Field(Of Integer)("Count")
                     Into countcnt = Group
                     Order By cnt
                     Select cnt, countcnt

        For Each c In query2
            OccursDt.Rows.Add(c.cnt, c.countcnt.Count)
        Next

        Dim N As Integer = Wordsdt.Rows.Count
        For Each r In OccursDt.Rows
            k += Math.Pow(r("Count"), 2) * r("CountOfCount")
        Next
        k = ((k - N) / Math.Pow(N, 2))
        k = Math.Pow(10, 4) * k

        FeatureDictionary.Item(FeatureKey) = k


    End Sub

    Private Sub Entropy(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim Wordsdt As New DataTable()
        Wordsdt.Columns.Add("Word", GetType(String))

        Dim WordsCountDt As New DataTable()
        WordsCountDt.Columns.Add("Word", GetType(String))
        WordsCountDt.Columns.Add("Count", GetType(Integer))

        Dim OccursDt As New DataTable
        OccursDt.Columns.Add("Count", GetType(Integer))
        OccursDt.Columns.Add("CountOfCount", GetType(Integer))

        Dim E As Decimal = 0.0

        Dim text As String
        Dim sentencesText

        Dim html As String
        Dim sentenceshtml

        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))

            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    Wordsdt.Rows.Add(s(i).ToString)
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))

            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    Wordsdt.Rows.Add(s(i).ToString)
                Next
            Next
        End If


        Dim query = From row In Wordsdt.AsEnumerable()
                    Group By Word = row.Field(Of String)("Word")
                    Into WordCount = Group
                    Select Word, WordCount

        For Each w In query
            WordsCountDt.Rows.Add(w.Word, w.WordCount.Count)
        Next



        Dim query2 = From row In WordsCountDt.AsEnumerable()
                     Group By cnt = row.Field(Of Integer)("Count")
                     Into countcnt = Group
                     Order By cnt
                     Select cnt, countcnt

        For Each c In query2
            OccursDt.Rows.Add(c.cnt, c.countcnt.Count)
        Next

        Dim N As Integer = Wordsdt.Rows.Count
        For Each r In OccursDt.Rows
            E += r("CountOfCount") * (-1 * Math.Log(r("Count") / N)) * (r("Count") / N)
        Next


        FeatureDictionary.Item(FeatureKey) = E


    End Sub

    Private Sub TextPlainUnique(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = IIf(email.Fields.Item("urn:schemas:mailheader:content-type").Value.ToString.ToLower.Contains("text/plain"), 1, 0)
    End Sub
    Private Sub MultipartAlternativeUnique(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = IIf(email.Fields.Item("urn:schemas:mailheader:content-type").Value.ToString.ToLower.Contains("multipart/alternative"), 1, 0)
    End Sub
    Private Sub MultipartMixedUnique(ByVal FeatureKey As String, ByVal email As CDO.Message)
        FeatureDictionary.Item(FeatureKey) = IIf(email.Fields.Item("urn:schemas:mailheader:content-type").Value.ToString.ToLower.Contains("multipart/mixed"), 1, 0)
    End Sub

    Private Sub DisLegomena(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim Wordsdt As New DataTable()
        Wordsdt.Columns.Add("Word", GetType(String))

        Dim dislegomenaVal As Integer = 0

        Dim text As String
        Dim sentencesText

        Dim html As String
        Dim sentenceshtml

        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))

            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    Wordsdt.Rows.Add(s(i).ToString)
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    Wordsdt.Rows.Add(s(i).ToString)
                Next
            Next
        End If


        Dim query = From row In Wordsdt.AsEnumerable()
                    Group By Word = row.Field(Of String)("Word")
                    Into WordCount = Group
                    Select Word, WordCount


        For Each w In query
            If w.WordCount.Count = 2 Then
                dislegomenaVal += 1
            End If
        Next

        FeatureDictionary.Item(FeatureKey) = dislegomenaVal


    End Sub

    Private Sub Sichel(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim Wordsdt As New DataTable()
        Wordsdt.Columns.Add("Word", GetType(String))
        Dim text As String
        Dim sentencesText
        Dim dislegomenaVal As Integer = 0

        Dim html As String
        Dim sentenceshtml

        Dim DistinctWordsCount As Integer = 0



        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    Wordsdt.Rows.Add(s(i).ToString)
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    Wordsdt.Rows.Add(s(i).ToString)
                Next
            Next
        End If

        Dim query = From row In Wordsdt.AsEnumerable()
                    Group By Word = row.Field(Of String)("Word")
                    Into WordCount = Group
                    Select Word, WordCount


        For Each w In query
            If w.WordCount.Count = 2 Then
                dislegomenaVal += 1
            End If
        Next


        DistinctWordsCount = Wordsdt.AsEnumerable().Select(Function(r) r.Field(Of String)("Word")).Distinct().Count().ToString()

        FeatureDictionary.Item(FeatureKey) = dislegomenaVal / DistinctWordsCount


    End Sub

    Private Sub Honore(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim Wordsdt As New DataTable()
        Wordsdt.Columns.Add("Word", GetType(String))
        Dim text As String
        Dim sentencesText


        Dim html As String
        Dim sentenceshtml

        Dim DistinctWordsCount As Integer = 0
        Dim WordsCount As Integer = 0
        Dim legomenaVal As Integer = 0

        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    Wordsdt.Rows.Add(s(i).ToString)
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    Wordsdt.Rows.Add(s(i).ToString)
                Next
            Next
        End If

        WordsCount = Wordsdt.Rows.Count
        DistinctWordsCount = Wordsdt.AsEnumerable().Select(Function(r) r.Field(Of String)("Word")).Distinct().Count().ToString()

        Dim query = From row In Wordsdt.AsEnumerable()
                    Group By Word = row.Field(Of String)("Word")
                    Into WordCount = Group
                    Select Word, WordCount


        For Each w In query
            If w.WordCount.Count = 1 Then
                legomenaVal += 1
            End If
        Next


        FeatureDictionary.Item(FeatureKey) = IIf(legomenaVal / DistinctWordsCount <> 1, 100 * (Math.Log(WordsCount) / (1 - (legomenaVal / DistinctWordsCount))), 0)

    End Sub
    Private Sub CalcUniqueHTMLAnchor(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim h As New HtmlAgilityPack.HtmlDocument
        Dim root As HtmlNode
        Dim AList As New List(Of String)

        If email.HTMLBody <> "" Then
            h.LoadHtml(email.HTMLBody)
            root = h.DocumentNode
            For Each link As HtmlNode In root.Descendants("a")
                If link.Attributes.Count <> 0 Then
                    If Not AList.Contains(link.Attributes.Item(0).Value) Then
                        AList.Add(link.Attributes.Item(0).Value)
                    End If
                End If
            Next
        End If


        If email.TextBody <> "" Then
            h.LoadHtml(email.TextBody)
            root = h.DocumentNode
            For Each link As HtmlNode In root.Descendants("a")
                If link.Attributes.Count <> 0 Then
                    If Not AList.Contains(link.Attributes.Item(0).Value) Then
                        AList.Add(link.Attributes.Item(0).Value)
                    End If
                End If
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = AList.Count
    End Sub
    Private Sub UniqueContentTypesAttachment(ByVal FeatureKey As String, ByVal email As CDO.Message)
        Dim AList As New List(Of String)
        For Each att As CDO.IBodyPart In email.Attachments
            If Not AList.Contains(att.ContentMediaType) Then
                AList.Add(att.ContentMediaType)
            End If
        Next

        FeatureDictionary.Item(FeatureKey) = AList.Count
    End Sub
    Private Sub MinCharacterDiversity(ByVal FeatureKey As String, ByVal email As CDO.Message)


        Dim text As String
        Dim sentencesText

        Dim html As String
        Dim sentenceshtml

        Dim DistinctChar As Integer = 0
        Dim WordLength As Integer = 0
        Dim charDiversity As Decimal = 0.0
        Dim MincharDiversity As Decimal = 0.0


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))

            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count <> 1 Then
                        DistinctChar = s(i).ToString.ToCharArray.Distinct.Count
                        WordLength = s(i).ToString.Count
                        charDiversity = Math.Pow(WordLength, 1 / DistinctChar)
                        If MincharDiversity = 0.0 Then
                            MincharDiversity = charDiversity
                        ElseIf MincharDiversity > charDiversity
                            MincharDiversity = charDiversity
                        End If
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count <> 1 Then
                        DistinctChar = s(i).ToString.ToCharArray.Distinct.Count
                        WordLength = s(i).ToString.Count
                        charDiversity = Math.Pow(WordLength, 1 / DistinctChar)
                        If MincharDiversity = 0.0 Then
                            MincharDiversity = charDiversity
                        ElseIf MincharDiversity > charDiversity
                            MincharDiversity = charDiversity
                        End If
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = MincharDiversity


    End Sub

    Private Sub MinCharacterDiversitySubject(ByVal FeatureKey As String, ByVal email As CDO.Message)


        Dim text As String
        Dim sentencesText

        Dim DistinctChar As Integer = 0
        Dim WordLength As Integer = 0
        Dim charDiversity As Decimal = 0.0
        Dim MincharDiversity As Decimal = 0.0


        If email.Subject <> "" Then
            text = email.Subject
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))


            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count <> 1 Then
                        DistinctChar = s(i).ToString.ToCharArray.Distinct.Count
                        WordLength = s(i).ToString.Count
                        charDiversity = Math.Pow(WordLength, 1 / DistinctChar)
                        If MincharDiversity = 0.0 Then
                            MincharDiversity = charDiversity
                        ElseIf MincharDiversity > charDiversity
                            MincharDiversity = charDiversity
                        End If
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = MincharDiversity


    End Sub

    Private Sub MaxLongestRepeatingCharacter(ByVal FeatureKey As String, ByVal email As CDO.Message)


        Dim text As String
        Dim sentencesText

        Dim html As String
        Dim sentenceshtml

        Dim r As Integer = 1
        Dim MaxR As Integer = 1


        If email.TextBody <> "" Then
            text = email.TextBody
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))

            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count <> 1 Then
                        For j As Integer = 1 To s(i).ToString.Count - 1
                            If s(i).ToString.Chars(j - 1) = s(i).ToString.Chars(j) Then
                                r += 1
                            Else
                                If r > MaxR Then
                                    MaxR = r
                                End If
                                r = 1
                            End If
                        Next
                    End If
                Next
            Next
        End If

        If email.HTMLBody <> "" Then
            html = email.HTMLBody
            sentenceshtml = MaxentTagger.tokenizeText(New java.io.StringReader(html))


            For Each s As ArrayList In sentenceshtml
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count <> 1 Then
                        For j As Integer = 1 To s(i).ToString.Count - 1
                            If s(i).ToString.Chars(j - 1) = s(i).ToString.Chars(j) Then
                                r += 1
                            Else
                                If r > MaxR Then
                                    MaxR = r
                                End If
                                r = 1
                            End If
                        Next
                    End If
                Next
            Next
        End If

        FeatureDictionary.Item(FeatureKey) = MaxR


    End Sub

    Private Sub MaxLongestRepeatingCharacterSubject(ByVal FeatureKey As String, ByVal email As CDO.Message)


        Dim text As String
        Dim sentencesText

        Dim r As Integer = 1
        Dim MaxR As Integer = 1


        If email.Subject <> "" Then
            text = email.Subject
            sentencesText = MaxentTagger.tokenizeText(New java.io.StringReader(text))

            For Each s As ArrayList In sentencesText
                For i As Integer = 0 To s.size - 1
                    If s(i).ToString.Count <> 1 Then
                        For j As Integer = 1 To s(i).ToString.Count - 1
                            If s(i).ToString.Chars(j - 1) = s(i).ToString.Chars(j) Then
                                r += 1
                            Else
                                If r > MaxR Then
                                    MaxR = r
                                End If
                                r = 1
                            End If
                        Next
                    End If
                Next
            Next
        End If



        FeatureDictionary.Item(FeatureKey) = MaxR


    End Sub


End Class
