<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDefault
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnDoExtract = New System.Windows.Forms.Button()
        Me.BackgroundWorkerFile = New System.ComponentModel.BackgroundWorker()
        Me.FolderBrowserDialogSource = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtSourceFolder = New System.Windows.Forms.TextBox()
        Me.btnSourceBrowse = New System.Windows.Forms.Button()
        Me.StatusStripMain = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBarStatus = New System.Windows.Forms.ToolStripProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxFeatures = New System.Windows.Forms.GroupBox()
        Me.TabMain = New System.Windows.Forms.TabControl()
        Me.TabHeader = New System.Windows.Forms.TabPage()
        Me.GroupBoxSubjectFeatures = New System.Windows.Forms.GroupBox()
        Me.cbMaxLongestRepeatingCharacterSubject = New System.Windows.Forms.CheckBox()
        Me.cbMinCharacterDiversitySubject = New System.Windows.Forms.CheckBox()
        Me.cbRatioNonAlphaNumToAllSubject = New System.Windows.Forms.CheckBox()
        Me.cbRatioDigitToAllSubject = New System.Windows.Forms.CheckBox()
        Me.cbRatioUpperToAllSubject = New System.Windows.Forms.CheckBox()
        Me.cbRatioUpperLowerSubject = New System.Windows.Forms.CheckBox()
        Me.cbSubjectFeatures = New System.Windows.Forms.CheckBox()
        Me.cbCountCharsSubject = New System.Windows.Forms.CheckBox()
        Me.cbAllCountCapWordSubject = New System.Windows.Forms.CheckBox()
        Me.cbCountCapWordSubject = New System.Windows.Forms.CheckBox()
        Me.cbAllCountDigitWordSubject = New System.Windows.Forms.CheckBox()
        Me.cbSingleCharWordsSubject = New System.Windows.Forms.CheckBox()
        Me.cbWordsMaxCharSubject = New System.Windows.Forms.CheckBox()
        Me.cbAlphaOnlySubject = New System.Windows.Forms.CheckBox()
        Me.cbSingleDigitWordsSubject = New System.Windows.Forms.CheckBox()
        Me.cbAlphaNumericSubject = New System.Windows.Forms.CheckBox()
        Me.SingleLetterWordsSubject = New System.Windows.Forms.CheckBox()
        Me.GroupBoxHeaderFeatures = New System.Windows.Forms.GroupBox()
        Me.cbHeaderFeatures = New System.Windows.Forms.CheckBox()
        Me.cbMultipartMixedUnique = New System.Windows.Forms.CheckBox()
        Me.cbMultipartAlternativeUnique = New System.Windows.Forms.CheckBox()
        Me.cbTextPlainUnique = New System.Windows.Forms.CheckBox()
        Me.cbX_Mailman_Version = New System.Windows.Forms.CheckBox()
        Me.cbYear = New System.Windows.Forms.CheckBox()
        Me.cbMonth = New System.Windows.Forms.CheckBox()
        Me.cbCountOfTo = New System.Windows.Forms.CheckBox()
        Me.cbDay = New System.Windows.Forms.CheckBox()
        Me.cbHour = New System.Windows.Forms.CheckBox()
        Me.cbMinute = New System.Windows.Forms.CheckBox()
        Me.cbSecond = New System.Windows.Forms.CheckBox()
        Me.cbGoogle = New System.Windows.Forms.CheckBox()
        Me.CbAOL = New System.Windows.Forms.CheckBox()
        Me.cbGOV = New System.Windows.Forms.CheckBox()
        Me.cbHotmail = New System.Windows.Forms.CheckBox()
        Me.cbMIL = New System.Windows.Forms.CheckBox()
        Me.cbYahoo = New System.Windows.Forms.CheckBox()
        Me.cbExample = New System.Windows.Forms.CheckBox()
        Me.cbReplayGoogle = New System.Windows.Forms.CheckBox()
        Me.cbReplayHotmail = New System.Windows.Forms.CheckBox()
        Me.cbReplayMIL = New System.Windows.Forms.CheckBox()
        Me.cbReplayYahoo = New System.Windows.Forms.CheckBox()
        Me.cbToGoogle = New System.Windows.Forms.CheckBox()
        Me.cbToAOL = New System.Windows.Forms.CheckBox()
        Me.cbToGOV = New System.Windows.Forms.CheckBox()
        Me.cbToHotmail = New System.Windows.Forms.CheckBox()
        Me.cbToMIL = New System.Windows.Forms.CheckBox()
        Me.cbToYahoo = New System.Windows.Forms.CheckBox()
        Me.cbToExample = New System.Windows.Forms.CheckBox()
        Me.cbToMSN = New System.Windows.Forms.CheckBox()
        Me.cbToLocalhost = New System.Windows.Forms.CheckBox()
        Me.cbReplayAOL = New System.Windows.Forms.CheckBox()
        Me.cbReplayGOV = New System.Windows.Forms.CheckBox()
        Me.TabPayload = New System.Windows.Forms.TabPage()
        Me.GroupBoxLexicalDiversity = New System.Windows.Forms.GroupBox()
        Me.cbLexicalDiversity = New System.Windows.Forms.CheckBox()
        Me.cbVocabularyRichness = New System.Windows.Forms.CheckBox()
        Me.cblegomena = New System.Windows.Forms.CheckBox()
        Me.cbDislegomena = New System.Windows.Forms.CheckBox()
        Me.cbYuleK = New System.Windows.Forms.CheckBox()
        Me.cbEntropy = New System.Windows.Forms.CheckBox()
        Me.cbSichel = New System.Windows.Forms.CheckBox()
        Me.cbHonore = New System.Windows.Forms.CheckBox()
        Me.GroupBoxReadabilityFeatures = New System.Windows.Forms.GroupBox()
        Me.cbWordLengthWithoutStopwords = New System.Windows.Forms.CheckBox()
        Me.cbInverseFI_WithoutStopwords = New System.Windows.Forms.CheckBox()
        Me.cbComplexWordsWithoutStopwords = New System.Windows.Forms.CheckBox()
        Me.cbFISimpleWithoutStopwords = New System.Windows.Forms.CheckBox()
        Me.cbSimpleWordsWithoutStopwords = New System.Windows.Forms.CheckBox()
        Me.cbFKRI_WithoutStopwords = New System.Windows.Forms.CheckBox()
        Me.cbFORCAST_WithoutStopwords = New System.Windows.Forms.CheckBox()
        Me.cbSMOG_WithoutStopWords = New System.Windows.Forms.CheckBox()
        Me.cbFRESWithoutStopwords = New System.Windows.Forms.CheckBox()
        Me.cbFogIndexWithoutStopWords = New System.Windows.Forms.CheckBox()
        Me.cbReadabilityFeatures = New System.Windows.Forms.CheckBox()
        Me.cbFogIndex = New System.Windows.Forms.CheckBox()
        Me.cbFRES = New System.Windows.Forms.CheckBox()
        Me.cbSMOGI = New System.Windows.Forms.CheckBox()
        Me.cbFORCAST = New System.Windows.Forms.CheckBox()
        Me.cbFISimple = New System.Windows.Forms.CheckBox()
        Me.cbInverseFI = New System.Windows.Forms.CheckBox()
        Me.cbSMOG = New System.Windows.Forms.CheckBox()
        Me.cbFKRI = New System.Windows.Forms.CheckBox()
        Me.cbARI = New System.Windows.Forms.CheckBox()
        Me.cbCLI = New System.Windows.Forms.CheckBox()
        Me.cbSimpleWords = New System.Windows.Forms.CheckBox()
        Me.cbComplexWords = New System.Windows.Forms.CheckBox()
        Me.cbWordLength = New System.Windows.Forms.CheckBox()
        Me.GroupBoxPayloadFeatures = New System.Windows.Forms.GroupBox()
        Me.cbTFISFWithoutStopwords = New System.Windows.Forms.CheckBox()
        Me.cbMaxLongestRepeatingCharacter = New System.Windows.Forms.CheckBox()
        Me.cbMinCharacterDiversity = New System.Windows.Forms.CheckBox()
        Me.cbUniqueHTMLAnchor = New System.Windows.Forms.CheckBox()
        Me.cbRatioNonAlphaNumToAll = New System.Windows.Forms.CheckBox()
        Me.cbRatioDigitToAll = New System.Windows.Forms.CheckBox()
        Me.cbRatioUpperToAll = New System.Windows.Forms.CheckBox()
        Me.cbRatioUpperLower = New System.Windows.Forms.CheckBox()
        Me.cbAvgWordsinSentences = New System.Windows.Forms.CheckBox()
        Me.cbAvgCharinParagraphs = New System.Windows.Forms.CheckBox()
        Me.cbAvgWordsinParagraphs = New System.Windows.Forms.CheckBox()
        Me.cbAvgSentenceinParagraphs = New System.Windows.Forms.CheckBox()
        Me.cbCountofParagraphs = New System.Windows.Forms.CheckBox()
        Me.cbPayloadFeatures = New System.Windows.Forms.CheckBox()
        Me.cbSpamWords = New System.Windows.Forms.CheckBox()
        Me.cbFunctionWords = New System.Windows.Forms.CheckBox()
        Me.cbHTMLAnchor = New System.Windows.Forms.CheckBox()
        Me.cbHTMLNotAnchor = New System.Windows.Forms.CheckBox()
        Me.cbHTMLImage = New System.Windows.Forms.CheckBox()
        Me.cbLongestCapital = New System.Windows.Forms.CheckBox()
        Me.cbCountCapWord = New System.Windows.Forms.CheckBox()
        Me.cbSenBegLower = New System.Windows.Forms.CheckBox()
        Me.cbCountLines = New System.Windows.Forms.CheckBox()
        Me.cbSenBegUpper = New System.Windows.Forms.CheckBox()
        Me.cbAllCountDigitWord = New System.Windows.Forms.CheckBox()
        Me.cbCountSentence = New System.Windows.Forms.CheckBox()
        Me.cbSingleCharWords = New System.Windows.Forms.CheckBox()
        Me.cbHTMLTags = New System.Windows.Forms.CheckBox()
        Me.cbDuplicateWords = New System.Windows.Forms.CheckBox()
        Me.cbCountLowerChars = New System.Windows.Forms.CheckBox()
        Me.cbTFISF = New System.Windows.Forms.CheckBox()
        Me.cbSingleDigitWords = New System.Windows.Forms.CheckBox()
        Me.cbAllCountCapWord = New System.Windows.Forms.CheckBox()
        Me.cbQuestionMark = New System.Windows.Forms.CheckBox()
        Me.cbSingleLetterWords = New System.Windows.Forms.CheckBox()
        Me.cbExclamationMark = New System.Windows.Forms.CheckBox()
        Me.cbCountUpperChars = New System.Windows.Forms.CheckBox()
        Me.cbComma = New System.Windows.Forms.CheckBox()
        Me.cbCountWord = New System.Windows.Forms.CheckBox()
        Me.cbSemiColon = New System.Windows.Forms.CheckBox()
        Me.cbColon = New System.Windows.Forms.CheckBox()
        Me.cbSingleQuote = New System.Windows.Forms.CheckBox()
        Me.cbPeriod = New System.Windows.Forms.CheckBox()
        Me.cbSpace = New System.Windows.Forms.CheckBox()
        Me.cbTab = New System.Windows.Forms.CheckBox()
        Me.cbDollar = New System.Windows.Forms.CheckBox()
        Me.cbEllipsis = New System.Windows.Forms.CheckBox()
        Me.cbWordsMinChar = New System.Windows.Forms.CheckBox()
        Me.cbMultipleExclamationMarks = New System.Windows.Forms.CheckBox()
        Me.cbAlphaOnly = New System.Windows.Forms.CheckBox()
        Me.cbAlphaChars = New System.Windows.Forms.CheckBox()
        Me.cbMultipleQuestionMarks = New System.Windows.Forms.CheckBox()
        Me.cbSpecialChars = New System.Windows.Forms.CheckBox()
        Me.cbWordsMaxChar = New System.Windows.Forms.CheckBox()
        Me.cbCountDigitChars = New System.Windows.Forms.CheckBox()
        Me.cbWordsAVGChar = New System.Windows.Forms.CheckBox()
        Me.cbCountWordLess3Char = New System.Windows.Forms.CheckBox()
        Me.cbCountChars = New System.Windows.Forms.CheckBox()
        Me.cbCountWordLonger6Char = New System.Windows.Forms.CheckBox()
        Me.cbAlphaNumeric = New System.Windows.Forms.CheckBox()
        Me.TabAttachments = New System.Windows.Forms.TabPage()
        Me.GroupBoxAttachmentFeatures = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cbAttachmentFeatures = New System.Windows.Forms.CheckBox()
        Me.cbCountOfAttachments = New System.Windows.Forms.CheckBox()
        Me.cbAllFeatures = New System.Windows.Forms.CheckBox()
        Me.StatusStripMain.SuspendLayout()
        Me.GroupBoxFeatures.SuspendLayout()
        Me.TabMain.SuspendLayout()
        Me.TabHeader.SuspendLayout()
        Me.GroupBoxSubjectFeatures.SuspendLayout()
        Me.GroupBoxHeaderFeatures.SuspendLayout()
        Me.TabPayload.SuspendLayout()
        Me.GroupBoxLexicalDiversity.SuspendLayout()
        Me.GroupBoxReadabilityFeatures.SuspendLayout()
        Me.GroupBoxPayloadFeatures.SuspendLayout()
        Me.TabAttachments.SuspendLayout()
        Me.GroupBoxAttachmentFeatures.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDoExtract
        '
        Me.btnDoExtract.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnDoExtract.Location = New System.Drawing.Point(6, 62)
        Me.btnDoExtract.Name = "btnDoExtract"
        Me.btnDoExtract.Size = New System.Drawing.Size(87, 23)
        Me.btnDoExtract.TabIndex = 3
        Me.btnDoExtract.Text = "Extract!!!"
        Me.btnDoExtract.UseVisualStyleBackColor = True
        '
        'BackgroundWorkerFile
        '
        Me.BackgroundWorkerFile.WorkerReportsProgress = True
        '
        'FolderBrowserDialogSource
        '
        Me.FolderBrowserDialogSource.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.FolderBrowserDialogSource.ShowNewFolderButton = False
        '
        'txtSourceFolder
        '
        Me.txtSourceFolder.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtSourceFolder.Location = New System.Drawing.Point(6, 27)
        Me.txtSourceFolder.Name = "txtSourceFolder"
        Me.txtSourceFolder.Size = New System.Drawing.Size(222, 20)
        Me.txtSourceFolder.TabIndex = 6
        '
        'btnSourceBrowse
        '
        Me.btnSourceBrowse.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnSourceBrowse.Location = New System.Drawing.Point(236, 27)
        Me.btnSourceBrowse.Name = "btnSourceBrowse"
        Me.btnSourceBrowse.Size = New System.Drawing.Size(87, 23)
        Me.btnSourceBrowse.TabIndex = 7
        Me.btnSourceBrowse.Text = "Browse"
        Me.btnSourceBrowse.UseVisualStyleBackColor = True
        '
        'StatusStripMain
        '
        Me.StatusStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.ProgressBarStatus})
        Me.StatusStripMain.Location = New System.Drawing.Point(0, 749)
        Me.StatusStripMain.Name = "StatusStripMain"
        Me.StatusStripMain.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStripMain.Size = New System.Drawing.Size(1524, 22)
        Me.StatusStripMain.TabIndex = 9
        Me.StatusStripMain.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'ProgressBarStatus
        '
        Me.ProgressBarStatus.Name = "ProgressBarStatus"
        Me.ProgressBarStatus.Size = New System.Drawing.Size(117, 16)
        Me.ProgressBarStatus.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Corpus Path:"
        '
        'GroupBoxFeatures
        '
        Me.GroupBoxFeatures.Controls.Add(Me.TabMain)
        Me.GroupBoxFeatures.Controls.Add(Me.cbAllFeatures)
        Me.GroupBoxFeatures.Location = New System.Drawing.Point(6, 91)
        Me.GroupBoxFeatures.Name = "GroupBoxFeatures"
        Me.GroupBoxFeatures.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.GroupBoxFeatures.Size = New System.Drawing.Size(1513, 655)
        Me.GroupBoxFeatures.TabIndex = 9
        Me.GroupBoxFeatures.TabStop = False
        '
        'TabMain
        '
        Me.TabMain.Controls.Add(Me.TabHeader)
        Me.TabMain.Controls.Add(Me.TabPayload)
        Me.TabMain.Controls.Add(Me.TabAttachments)
        Me.TabMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabMain.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TabMain.Location = New System.Drawing.Point(12, 23)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.SelectedIndex = 0
        Me.TabMain.Size = New System.Drawing.Size(1489, 622)
        Me.TabMain.TabIndex = 12
        '
        'TabHeader
        '
        Me.TabHeader.Controls.Add(Me.GroupBoxSubjectFeatures)
        Me.TabHeader.Controls.Add(Me.GroupBoxHeaderFeatures)
        Me.TabHeader.Location = New System.Drawing.Point(4, 22)
        Me.TabHeader.Name = "TabHeader"
        Me.TabHeader.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHeader.Size = New System.Drawing.Size(1481, 596)
        Me.TabHeader.TabIndex = 0
        Me.TabHeader.Text = "Header Features"
        Me.TabHeader.UseVisualStyleBackColor = True
        '
        'GroupBoxSubjectFeatures
        '
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.cbMaxLongestRepeatingCharacterSubject)
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.cbMinCharacterDiversitySubject)
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.cbRatioNonAlphaNumToAllSubject)
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.cbRatioDigitToAllSubject)
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.cbRatioUpperToAllSubject)
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.cbRatioUpperLowerSubject)
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.cbSubjectFeatures)
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.cbCountCharsSubject)
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.cbAllCountCapWordSubject)
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.cbCountCapWordSubject)
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.cbAllCountDigitWordSubject)
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.cbSingleCharWordsSubject)
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.cbWordsMaxCharSubject)
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.cbAlphaOnlySubject)
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.cbSingleDigitWordsSubject)
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.cbAlphaNumericSubject)
        Me.GroupBoxSubjectFeatures.Controls.Add(Me.SingleLetterWordsSubject)
        Me.GroupBoxSubjectFeatures.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxSubjectFeatures.Location = New System.Drawing.Point(572, 6)
        Me.GroupBoxSubjectFeatures.Name = "GroupBoxSubjectFeatures"
        Me.GroupBoxSubjectFeatures.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.GroupBoxSubjectFeatures.Size = New System.Drawing.Size(618, 229)
        Me.GroupBoxSubjectFeatures.TabIndex = 102
        Me.GroupBoxSubjectFeatures.TabStop = False
        '
        'cbMaxLongestRepeatingCharacterSubject
        '
        Me.cbMaxLongestRepeatingCharacterSubject.AutoSize = True
        Me.cbMaxLongestRepeatingCharacterSubject.Location = New System.Drawing.Point(224, 190)
        Me.cbMaxLongestRepeatingCharacterSubject.Name = "cbMaxLongestRepeatingCharacterSubject"
        Me.cbMaxLongestRepeatingCharacterSubject.Size = New System.Drawing.Size(218, 17)
        Me.cbMaxLongestRepeatingCharacterSubject.TabIndex = 105
        Me.cbMaxLongestRepeatingCharacterSubject.Tag = "MaxLongestRepeatingCharacterSubject"
        Me.cbMaxLongestRepeatingCharacterSubject.Text = "Max Longest Repeating Character"
        Me.cbMaxLongestRepeatingCharacterSubject.UseVisualStyleBackColor = True
        '
        'cbMinCharacterDiversitySubject
        '
        Me.cbMinCharacterDiversitySubject.AutoSize = True
        Me.cbMinCharacterDiversitySubject.Location = New System.Drawing.Point(15, 190)
        Me.cbMinCharacterDiversitySubject.Name = "cbMinCharacterDiversitySubject"
        Me.cbMinCharacterDiversitySubject.Size = New System.Drawing.Size(159, 17)
        Me.cbMinCharacterDiversitySubject.TabIndex = 104
        Me.cbMinCharacterDiversitySubject.Tag = "MinCharacterDiversitySubject"
        Me.cbMinCharacterDiversitySubject.Text = "Min Character Diversity"
        Me.cbMinCharacterDiversitySubject.UseVisualStyleBackColor = True
        '
        'cbRatioNonAlphaNumToAllSubject
        '
        Me.cbRatioNonAlphaNumToAllSubject.AutoSize = True
        Me.cbRatioNonAlphaNumToAllSubject.Location = New System.Drawing.Point(224, 167)
        Me.cbRatioNonAlphaNumToAllSubject.Name = "cbRatioNonAlphaNumToAllSubject"
        Me.cbRatioNonAlphaNumToAllSubject.Size = New System.Drawing.Size(344, 17)
        Me.cbRatioNonAlphaNumToAllSubject.TabIndex = 103
        Me.cbRatioNonAlphaNumToAllSubject.Tag = "RatioNonAlphaNumToAllSubject"
        Me.cbRatioNonAlphaNumToAllSubject.Text = "Max of ratio of non-alphanumeric to all char.(each word)"
        Me.cbRatioNonAlphaNumToAllSubject.UseVisualStyleBackColor = True
        '
        'cbRatioDigitToAllSubject
        '
        Me.cbRatioDigitToAllSubject.AutoSize = True
        Me.cbRatioDigitToAllSubject.Location = New System.Drawing.Point(224, 144)
        Me.cbRatioDigitToAllSubject.Name = "cbRatioDigitToAllSubject"
        Me.cbRatioDigitToAllSubject.Size = New System.Drawing.Size(266, 17)
        Me.cbRatioDigitToAllSubject.TabIndex = 102
        Me.cbRatioDigitToAllSubject.Tag = "RatioDigitToAllSubject"
        Me.cbRatioDigitToAllSubject.Text = "Max of ratio of digit to all char.(each word)"
        Me.cbRatioDigitToAllSubject.UseVisualStyleBackColor = True
        '
        'cbRatioUpperToAllSubject
        '
        Me.cbRatioUpperToAllSubject.AutoSize = True
        Me.cbRatioUpperToAllSubject.Location = New System.Drawing.Point(224, 121)
        Me.cbRatioUpperToAllSubject.Name = "cbRatioUpperToAllSubject"
        Me.cbRatioUpperToAllSubject.Size = New System.Drawing.Size(274, 17)
        Me.cbRatioUpperToAllSubject.TabIndex = 101
        Me.cbRatioUpperToAllSubject.Tag = "RatioUpperToAllSubject"
        Me.cbRatioUpperToAllSubject.Text = "Max of ratio of upper to all char.(each word)"
        Me.cbRatioUpperToAllSubject.UseVisualStyleBackColor = True
        '
        'cbRatioUpperLowerSubject
        '
        Me.cbRatioUpperLowerSubject.AutoSize = True
        Me.cbRatioUpperLowerSubject.Location = New System.Drawing.Point(224, 98)
        Me.cbRatioUpperLowerSubject.Name = "cbRatioUpperLowerSubject"
        Me.cbRatioUpperLowerSubject.Size = New System.Drawing.Size(247, 17)
        Me.cbRatioUpperLowerSubject.TabIndex = 100
        Me.cbRatioUpperLowerSubject.Tag = "RatioUpperLowerSubject"
        Me.cbRatioUpperLowerSubject.Text = "Max ratio of upper to lower(each word)"
        Me.cbRatioUpperLowerSubject.UseVisualStyleBackColor = True
        '
        'cbSubjectFeatures
        '
        Me.cbSubjectFeatures.AutoSize = True
        Me.cbSubjectFeatures.BackColor = System.Drawing.Color.White
        Me.cbSubjectFeatures.Location = New System.Drawing.Point(0, 0)
        Me.cbSubjectFeatures.Name = "cbSubjectFeatures"
        Me.cbSubjectFeatures.Size = New System.Drawing.Size(122, 17)
        Me.cbSubjectFeatures.TabIndex = 99
        Me.cbSubjectFeatures.Tag = "0"
        Me.cbSubjectFeatures.Text = "Subject Features"
        Me.cbSubjectFeatures.UseVisualStyleBackColor = False
        '
        'cbCountCharsSubject
        '
        Me.cbCountCharsSubject.AutoSize = True
        Me.cbCountCharsSubject.Location = New System.Drawing.Point(15, 52)
        Me.cbCountCharsSubject.Name = "cbCountCharsSubject"
        Me.cbCountCharsSubject.Size = New System.Drawing.Size(94, 17)
        Me.cbCountCharsSubject.TabIndex = 82
        Me.cbCountCharsSubject.Tag = "CountCharsSubject"
        Me.cbCountCharsSubject.Text = "Chars Count"
        Me.cbCountCharsSubject.UseVisualStyleBackColor = True
        '
        'cbAllCountCapWordSubject
        '
        Me.cbAllCountCapWordSubject.AutoSize = True
        Me.cbAllCountCapWordSubject.Location = New System.Drawing.Point(15, 75)
        Me.cbAllCountCapWordSubject.Name = "cbAllCountCapWordSubject"
        Me.cbAllCountCapWordSubject.Size = New System.Drawing.Size(144, 17)
        Me.cbAllCountCapWordSubject.TabIndex = 83
        Me.cbAllCountCapWordSubject.Tag = "AllCountCapWordSubject"
        Me.cbAllCountCapWordSubject.Text = "All Capitalized Words"
        Me.cbAllCountCapWordSubject.UseVisualStyleBackColor = True
        '
        'cbCountCapWordSubject
        '
        Me.cbCountCapWordSubject.AutoSize = True
        Me.cbCountCapWordSubject.Location = New System.Drawing.Point(15, 98)
        Me.cbCountCapWordSubject.Name = "cbCountCapWordSubject"
        Me.cbCountCapWordSubject.Size = New System.Drawing.Size(125, 17)
        Me.cbCountCapWordSubject.TabIndex = 85
        Me.cbCountCapWordSubject.Tag = "CountCapWordSubject"
        Me.cbCountCapWordSubject.Text = "Capitalized words"
        Me.cbCountCapWordSubject.UseVisualStyleBackColor = True
        '
        'cbAllCountDigitWordSubject
        '
        Me.cbAllCountDigitWordSubject.AutoSize = True
        Me.cbAllCountDigitWordSubject.Location = New System.Drawing.Point(15, 121)
        Me.cbAllCountDigitWordSubject.Name = "cbAllCountDigitWordSubject"
        Me.cbAllCountDigitWordSubject.Size = New System.Drawing.Size(108, 17)
        Me.cbAllCountDigitWordSubject.TabIndex = 87
        Me.cbAllCountDigitWordSubject.Tag = "AllCountDigitWordSubject"
        Me.cbAllCountDigitWordSubject.Text = "All Digit Words"
        Me.cbAllCountDigitWordSubject.UseVisualStyleBackColor = True
        '
        'cbSingleCharWordsSubject
        '
        Me.cbSingleCharWordsSubject.AutoSize = True
        Me.cbSingleCharWordsSubject.Location = New System.Drawing.Point(224, 75)
        Me.cbSingleCharWordsSubject.Name = "cbSingleCharWordsSubject"
        Me.cbSingleCharWordsSubject.Size = New System.Drawing.Size(131, 17)
        Me.cbSingleCharWordsSubject.TabIndex = 95
        Me.cbSingleCharWordsSubject.Tag = "SingleCharWordsSubject"
        Me.cbSingleCharWordsSubject.Text = "Single Char. Words"
        Me.cbSingleCharWordsSubject.UseVisualStyleBackColor = True
        '
        'cbWordsMaxCharSubject
        '
        Me.cbWordsMaxCharSubject.AutoSize = True
        Me.cbWordsMaxCharSubject.Location = New System.Drawing.Point(15, 29)
        Me.cbWordsMaxCharSubject.Name = "cbWordsMaxCharSubject"
        Me.cbWordsMaxCharSubject.Size = New System.Drawing.Size(125, 17)
        Me.cbWordsMaxCharSubject.TabIndex = 98
        Me.cbWordsMaxCharSubject.Tag = "WordsMaxCharSubject"
        Me.cbWordsMaxCharSubject.Text = "Max Word Length"
        Me.cbWordsMaxCharSubject.UseVisualStyleBackColor = True
        '
        'cbAlphaOnlySubject
        '
        Me.cbAlphaOnlySubject.AutoSize = True
        Me.cbAlphaOnlySubject.Location = New System.Drawing.Point(15, 144)
        Me.cbAlphaOnlySubject.Name = "cbAlphaOnlySubject"
        Me.cbAlphaOnlySubject.Size = New System.Drawing.Size(86, 17)
        Me.cbAlphaOnlySubject.TabIndex = 88
        Me.cbAlphaOnlySubject.Tag = "AlphaOnlySubject"
        Me.cbAlphaOnlySubject.Text = "Alpha Only"
        Me.cbAlphaOnlySubject.UseVisualStyleBackColor = True
        '
        'cbSingleDigitWordsSubject
        '
        Me.cbSingleDigitWordsSubject.AutoSize = True
        Me.cbSingleDigitWordsSubject.Location = New System.Drawing.Point(224, 52)
        Me.cbSingleDigitWordsSubject.Name = "cbSingleDigitWordsSubject"
        Me.cbSingleDigitWordsSubject.Size = New System.Drawing.Size(128, 17)
        Me.cbSingleDigitWordsSubject.TabIndex = 93
        Me.cbSingleDigitWordsSubject.Tag = "SingleDigitWordsSubject"
        Me.cbSingleDigitWordsSubject.Text = "Single Digit Words"
        Me.cbSingleDigitWordsSubject.UseVisualStyleBackColor = True
        '
        'cbAlphaNumericSubject
        '
        Me.cbAlphaNumericSubject.AutoSize = True
        Me.cbAlphaNumericSubject.Location = New System.Drawing.Point(15, 167)
        Me.cbAlphaNumericSubject.Name = "cbAlphaNumericSubject"
        Me.cbAlphaNumericSubject.Size = New System.Drawing.Size(109, 17)
        Me.cbAlphaNumericSubject.TabIndex = 89
        Me.cbAlphaNumericSubject.Tag = "AlphaNumericSubject"
        Me.cbAlphaNumericSubject.Text = "Alpha-Numeric"
        Me.cbAlphaNumericSubject.UseVisualStyleBackColor = True
        '
        'SingleLetterWordsSubject
        '
        Me.SingleLetterWordsSubject.AutoSize = True
        Me.SingleLetterWordsSubject.Location = New System.Drawing.Point(224, 29)
        Me.SingleLetterWordsSubject.Name = "SingleLetterWordsSubject"
        Me.SingleLetterWordsSubject.Size = New System.Drawing.Size(137, 17)
        Me.SingleLetterWordsSubject.TabIndex = 91
        Me.SingleLetterWordsSubject.Tag = "SingleLetterWordsSubject"
        Me.SingleLetterWordsSubject.Text = "Single Letter Words"
        Me.SingleLetterWordsSubject.UseVisualStyleBackColor = True
        '
        'GroupBoxHeaderFeatures
        '
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbHeaderFeatures)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbMultipartMixedUnique)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbMultipartAlternativeUnique)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbTextPlainUnique)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbX_Mailman_Version)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbYear)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbMonth)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbCountOfTo)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbDay)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbHour)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbMinute)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbSecond)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbGoogle)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.CbAOL)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbGOV)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbHotmail)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbMIL)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbYahoo)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbExample)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbReplayGoogle)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbReplayHotmail)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbReplayMIL)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbReplayYahoo)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbToGoogle)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbToAOL)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbToGOV)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbToHotmail)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbToMIL)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbToYahoo)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbToExample)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbToMSN)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbToLocalhost)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbReplayAOL)
        Me.GroupBoxHeaderFeatures.Controls.Add(Me.cbReplayGOV)
        Me.GroupBoxHeaderFeatures.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxHeaderFeatures.Location = New System.Drawing.Point(7, 6)
        Me.GroupBoxHeaderFeatures.Name = "GroupBoxHeaderFeatures"
        Me.GroupBoxHeaderFeatures.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.GroupBoxHeaderFeatures.Size = New System.Drawing.Size(542, 478)
        Me.GroupBoxHeaderFeatures.TabIndex = 103
        Me.GroupBoxHeaderFeatures.TabStop = False
        '
        'cbHeaderFeatures
        '
        Me.cbHeaderFeatures.AutoSize = True
        Me.cbHeaderFeatures.BackColor = System.Drawing.Color.White
        Me.cbHeaderFeatures.Location = New System.Drawing.Point(0, 0)
        Me.cbHeaderFeatures.Name = "cbHeaderFeatures"
        Me.cbHeaderFeatures.Size = New System.Drawing.Size(134, 17)
        Me.cbHeaderFeatures.TabIndex = 100
        Me.cbHeaderFeatures.Tag = "0"
        Me.cbHeaderFeatures.Text = "Metadata Features"
        Me.cbHeaderFeatures.UseVisualStyleBackColor = False
        '
        'cbMultipartMixedUnique
        '
        Me.cbMultipartMixedUnique.AutoSize = True
        Me.cbMultipartMixedUnique.Location = New System.Drawing.Point(339, 47)
        Me.cbMultipartMixedUnique.Name = "cbMultipartMixedUnique"
        Me.cbMultipartMixedUnique.Size = New System.Drawing.Size(159, 17)
        Me.cbMultipartMixedUnique.TabIndex = 104
        Me.cbMultipartMixedUnique.Tag = "MultipartMixedUnique"
        Me.cbMultipartMixedUnique.Text = "Multipart/Mixed unique"
        Me.cbMultipartMixedUnique.UseVisualStyleBackColor = True
        '
        'cbMultipartAlternativeUnique
        '
        Me.cbMultipartAlternativeUnique.AutoSize = True
        Me.cbMultipartAlternativeUnique.Location = New System.Drawing.Point(339, 70)
        Me.cbMultipartAlternativeUnique.Name = "cbMultipartAlternativeUnique"
        Me.cbMultipartAlternativeUnique.Size = New System.Drawing.Size(190, 17)
        Me.cbMultipartAlternativeUnique.TabIndex = 103
        Me.cbMultipartAlternativeUnique.Tag = "MultipartAlternativeUnique"
        Me.cbMultipartAlternativeUnique.Text = "Multipart/Alternative Unique"
        Me.cbMultipartAlternativeUnique.UseVisualStyleBackColor = True
        '
        'cbTextPlainUnique
        '
        Me.cbTextPlainUnique.AutoSize = True
        Me.cbTextPlainUnique.Location = New System.Drawing.Point(339, 26)
        Me.cbTextPlainUnique.Name = "cbTextPlainUnique"
        Me.cbTextPlainUnique.Size = New System.Drawing.Size(127, 17)
        Me.cbTextPlainUnique.TabIndex = 102
        Me.cbTextPlainUnique.Tag = "TextPlainUnique"
        Me.cbTextPlainUnique.Text = "Text/Plain Unique"
        Me.cbTextPlainUnique.UseVisualStyleBackColor = True
        '
        'cbX_Mailman_Version
        '
        Me.cbX_Mailman_Version.AutoSize = True
        Me.cbX_Mailman_Version.Location = New System.Drawing.Point(15, 164)
        Me.cbX_Mailman_Version.Name = "cbX_Mailman_Version"
        Me.cbX_Mailman_Version.Size = New System.Drawing.Size(133, 17)
        Me.cbX_Mailman_Version.TabIndex = 101
        Me.cbX_Mailman_Version.Tag = "X_Mailman_Version"
        Me.cbX_Mailman_Version.Text = "X-Mailman-Version"
        Me.cbX_Mailman_Version.UseVisualStyleBackColor = True
        '
        'cbYear
        '
        Me.cbYear.AutoSize = True
        Me.cbYear.Location = New System.Drawing.Point(15, 26)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(52, 17)
        Me.cbYear.TabIndex = 8
        Me.cbYear.Tag = "Year"
        Me.cbYear.Text = "Year"
        Me.cbYear.UseVisualStyleBackColor = True
        '
        'cbMonth
        '
        Me.cbMonth.AutoSize = True
        Me.cbMonth.Location = New System.Drawing.Point(15, 49)
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(62, 17)
        Me.cbMonth.TabIndex = 9
        Me.cbMonth.Tag = "Month"
        Me.cbMonth.Text = "Month"
        Me.cbMonth.UseVisualStyleBackColor = True
        '
        'cbCountOfTo
        '
        Me.cbCountOfTo.AutoSize = True
        Me.cbCountOfTo.Location = New System.Drawing.Point(184, 26)
        Me.cbCountOfTo.Name = "cbCountOfTo"
        Me.cbCountOfTo.Size = New System.Drawing.Size(91, 17)
        Me.cbCountOfTo.TabIndex = 99
        Me.cbCountOfTo.Tag = "CountOfTo"
        Me.cbCountOfTo.Text = "Count Of To"
        Me.cbCountOfTo.UseVisualStyleBackColor = True
        '
        'cbDay
        '
        Me.cbDay.AutoSize = True
        Me.cbDay.Location = New System.Drawing.Point(15, 72)
        Me.cbDay.Name = "cbDay"
        Me.cbDay.Size = New System.Drawing.Size(48, 17)
        Me.cbDay.TabIndex = 10
        Me.cbDay.Tag = "Day"
        Me.cbDay.Text = "Day"
        Me.cbDay.UseVisualStyleBackColor = True
        '
        'cbHour
        '
        Me.cbHour.AutoSize = True
        Me.cbHour.Location = New System.Drawing.Point(15, 95)
        Me.cbHour.Name = "cbHour"
        Me.cbHour.Size = New System.Drawing.Size(53, 17)
        Me.cbHour.TabIndex = 13
        Me.cbHour.Tag = "Hour"
        Me.cbHour.Text = "Hour"
        Me.cbHour.UseVisualStyleBackColor = True
        '
        'cbMinute
        '
        Me.cbMinute.AutoSize = True
        Me.cbMinute.Location = New System.Drawing.Point(15, 118)
        Me.cbMinute.Name = "cbMinute"
        Me.cbMinute.Size = New System.Drawing.Size(65, 17)
        Me.cbMinute.TabIndex = 12
        Me.cbMinute.Tag = "Minute"
        Me.cbMinute.Text = "Minute"
        Me.cbMinute.UseVisualStyleBackColor = True
        '
        'cbSecond
        '
        Me.cbSecond.AutoSize = True
        Me.cbSecond.Location = New System.Drawing.Point(15, 141)
        Me.cbSecond.Name = "cbSecond"
        Me.cbSecond.Size = New System.Drawing.Size(67, 17)
        Me.cbSecond.TabIndex = 11
        Me.cbSecond.Tag = "Second"
        Me.cbSecond.Text = "Second"
        Me.cbSecond.UseVisualStyleBackColor = True
        '
        'cbGoogle
        '
        Me.cbGoogle.AutoSize = True
        Me.cbGoogle.Location = New System.Drawing.Point(15, 187)
        Me.cbGoogle.Name = "cbGoogle"
        Me.cbGoogle.Size = New System.Drawing.Size(103, 17)
        Me.cbGoogle.TabIndex = 14
        Me.cbGoogle.Tag = "FromGoogle"
        Me.cbGoogle.Text = "From Google?"
        Me.cbGoogle.UseVisualStyleBackColor = True
        '
        'CbAOL
        '
        Me.CbAOL.AutoSize = True
        Me.CbAOL.Location = New System.Drawing.Point(15, 210)
        Me.CbAOL.Name = "CbAOL"
        Me.CbAOL.Size = New System.Drawing.Size(86, 17)
        Me.CbAOL.TabIndex = 15
        Me.CbAOL.Tag = "FromAOL"
        Me.CbAOL.Text = "From AOL?"
        Me.CbAOL.UseVisualStyleBackColor = True
        '
        'cbGOV
        '
        Me.cbGOV.AutoSize = True
        Me.cbGOV.Location = New System.Drawing.Point(15, 233)
        Me.cbGOV.Name = "cbGOV"
        Me.cbGOV.Size = New System.Drawing.Size(87, 17)
        Me.cbGOV.TabIndex = 16
        Me.cbGOV.Tag = "FromGOV"
        Me.cbGOV.Text = "From GOV?"
        Me.cbGOV.UseVisualStyleBackColor = True
        '
        'cbHotmail
        '
        Me.cbHotmail.AutoSize = True
        Me.cbHotmail.Location = New System.Drawing.Point(15, 256)
        Me.cbHotmail.Name = "cbHotmail"
        Me.cbHotmail.Size = New System.Drawing.Size(108, 17)
        Me.cbHotmail.TabIndex = 17
        Me.cbHotmail.Tag = "FromHotmail"
        Me.cbHotmail.Text = "From Hotmail?"
        Me.cbHotmail.UseVisualStyleBackColor = True
        '
        'cbMIL
        '
        Me.cbMIL.AutoSize = True
        Me.cbMIL.Location = New System.Drawing.Point(15, 279)
        Me.cbMIL.Name = "cbMIL"
        Me.cbMIL.Size = New System.Drawing.Size(85, 17)
        Me.cbMIL.TabIndex = 18
        Me.cbMIL.Tag = "FromMIL"
        Me.cbMIL.Text = "From MIL?"
        Me.cbMIL.UseVisualStyleBackColor = True
        '
        'cbYahoo
        '
        Me.cbYahoo.AutoSize = True
        Me.cbYahoo.Location = New System.Drawing.Point(15, 302)
        Me.cbYahoo.Name = "cbYahoo"
        Me.cbYahoo.Size = New System.Drawing.Size(99, 17)
        Me.cbYahoo.TabIndex = 19
        Me.cbYahoo.Tag = "FromYahoo"
        Me.cbYahoo.Text = "From Yahoo?"
        Me.cbYahoo.UseVisualStyleBackColor = True
        '
        'cbExample
        '
        Me.cbExample.AutoSize = True
        Me.cbExample.Location = New System.Drawing.Point(15, 325)
        Me.cbExample.Name = "cbExample"
        Me.cbExample.Size = New System.Drawing.Size(112, 17)
        Me.cbExample.TabIndex = 20
        Me.cbExample.Tag = "FromExample"
        Me.cbExample.Text = "From Example?"
        Me.cbExample.UseVisualStyleBackColor = True
        '
        'cbReplayGoogle
        '
        Me.cbReplayGoogle.AutoSize = True
        Me.cbReplayGoogle.Location = New System.Drawing.Point(184, 256)
        Me.cbReplayGoogle.Name = "cbReplayGoogle"
        Me.cbReplayGoogle.Size = New System.Drawing.Size(113, 17)
        Me.cbReplayGoogle.TabIndex = 50
        Me.cbReplayGoogle.Tag = "ReplayGoogle"
        Me.cbReplayGoogle.Text = "Replay Google?"
        Me.cbReplayGoogle.UseVisualStyleBackColor = True
        '
        'cbReplayHotmail
        '
        Me.cbReplayHotmail.AutoSize = True
        Me.cbReplayHotmail.Location = New System.Drawing.Point(184, 279)
        Me.cbReplayHotmail.Name = "cbReplayHotmail"
        Me.cbReplayHotmail.Size = New System.Drawing.Size(118, 17)
        Me.cbReplayHotmail.TabIndex = 53
        Me.cbReplayHotmail.Tag = "ReplayHotmail"
        Me.cbReplayHotmail.Text = "Replay Hotmail?"
        Me.cbReplayHotmail.UseVisualStyleBackColor = True
        '
        'cbReplayMIL
        '
        Me.cbReplayMIL.AutoSize = True
        Me.cbReplayMIL.Location = New System.Drawing.Point(184, 302)
        Me.cbReplayMIL.Name = "cbReplayMIL"
        Me.cbReplayMIL.Size = New System.Drawing.Size(95, 17)
        Me.cbReplayMIL.TabIndex = 54
        Me.cbReplayMIL.Tag = "ReplayMIL"
        Me.cbReplayMIL.Text = "Replay MIL?"
        Me.cbReplayMIL.UseVisualStyleBackColor = True
        '
        'cbReplayYahoo
        '
        Me.cbReplayYahoo.AutoSize = True
        Me.cbReplayYahoo.Location = New System.Drawing.Point(184, 325)
        Me.cbReplayYahoo.Name = "cbReplayYahoo"
        Me.cbReplayYahoo.Size = New System.Drawing.Size(109, 17)
        Me.cbReplayYahoo.TabIndex = 55
        Me.cbReplayYahoo.Tag = "ReplayYahoo"
        Me.cbReplayYahoo.Text = "Replay Yahoo?"
        Me.cbReplayYahoo.UseVisualStyleBackColor = True
        '
        'cbToGoogle
        '
        Me.cbToGoogle.AutoSize = True
        Me.cbToGoogle.Location = New System.Drawing.Point(184, 164)
        Me.cbToGoogle.Name = "cbToGoogle"
        Me.cbToGoogle.Size = New System.Drawing.Size(88, 17)
        Me.cbToGoogle.TabIndex = 41
        Me.cbToGoogle.Tag = "ToGoogle"
        Me.cbToGoogle.Text = "To Google?"
        Me.cbToGoogle.UseVisualStyleBackColor = True
        '
        'cbToAOL
        '
        Me.cbToAOL.AutoSize = True
        Me.cbToAOL.Location = New System.Drawing.Point(184, 187)
        Me.cbToAOL.Name = "cbToAOL"
        Me.cbToAOL.Size = New System.Drawing.Size(71, 17)
        Me.cbToAOL.TabIndex = 42
        Me.cbToAOL.Tag = "ToAOL"
        Me.cbToAOL.Text = "To AOL?"
        Me.cbToAOL.UseVisualStyleBackColor = True
        '
        'cbToGOV
        '
        Me.cbToGOV.AutoSize = True
        Me.cbToGOV.Location = New System.Drawing.Point(184, 210)
        Me.cbToGOV.Name = "cbToGOV"
        Me.cbToGOV.Size = New System.Drawing.Size(72, 17)
        Me.cbToGOV.TabIndex = 43
        Me.cbToGOV.Tag = "ToGOV"
        Me.cbToGOV.Text = "To GOV?"
        Me.cbToGOV.UseVisualStyleBackColor = True
        '
        'cbToHotmail
        '
        Me.cbToHotmail.AutoSize = True
        Me.cbToHotmail.Location = New System.Drawing.Point(184, 49)
        Me.cbToHotmail.Name = "cbToHotmail"
        Me.cbToHotmail.Size = New System.Drawing.Size(93, 17)
        Me.cbToHotmail.TabIndex = 44
        Me.cbToHotmail.Tag = "ToHotmail"
        Me.cbToHotmail.Text = "To Hotmail?"
        Me.cbToHotmail.UseVisualStyleBackColor = True
        '
        'cbToMIL
        '
        Me.cbToMIL.AutoSize = True
        Me.cbToMIL.Location = New System.Drawing.Point(184, 233)
        Me.cbToMIL.Name = "cbToMIL"
        Me.cbToMIL.Size = New System.Drawing.Size(70, 17)
        Me.cbToMIL.TabIndex = 45
        Me.cbToMIL.Tag = "ToMIL"
        Me.cbToMIL.Text = "To MIL?"
        Me.cbToMIL.UseVisualStyleBackColor = True
        '
        'cbToYahoo
        '
        Me.cbToYahoo.AutoSize = True
        Me.cbToYahoo.Location = New System.Drawing.Point(184, 72)
        Me.cbToYahoo.Name = "cbToYahoo"
        Me.cbToYahoo.Size = New System.Drawing.Size(84, 17)
        Me.cbToYahoo.TabIndex = 46
        Me.cbToYahoo.Tag = "ToYahoo"
        Me.cbToYahoo.Text = "To Yahoo?"
        Me.cbToYahoo.UseVisualStyleBackColor = True
        '
        'cbToExample
        '
        Me.cbToExample.AutoSize = True
        Me.cbToExample.Location = New System.Drawing.Point(184, 95)
        Me.cbToExample.Name = "cbToExample"
        Me.cbToExample.Size = New System.Drawing.Size(97, 17)
        Me.cbToExample.TabIndex = 49
        Me.cbToExample.Tag = "ToExample"
        Me.cbToExample.Text = "To Example?"
        Me.cbToExample.UseVisualStyleBackColor = True
        '
        'cbToMSN
        '
        Me.cbToMSN.AutoSize = True
        Me.cbToMSN.Location = New System.Drawing.Point(184, 118)
        Me.cbToMSN.Name = "cbToMSN"
        Me.cbToMSN.Size = New System.Drawing.Size(73, 17)
        Me.cbToMSN.TabIndex = 47
        Me.cbToMSN.Tag = "ToMSN"
        Me.cbToMSN.Text = "To MSN?"
        Me.cbToMSN.UseVisualStyleBackColor = True
        '
        'cbToLocalhost
        '
        Me.cbToLocalhost.AutoSize = True
        Me.cbToLocalhost.Location = New System.Drawing.Point(184, 141)
        Me.cbToLocalhost.Name = "cbToLocalhost"
        Me.cbToLocalhost.Size = New System.Drawing.Size(103, 17)
        Me.cbToLocalhost.TabIndex = 48
        Me.cbToLocalhost.Tag = "ToLocalhost"
        Me.cbToLocalhost.Text = "To Localhost?"
        Me.cbToLocalhost.UseVisualStyleBackColor = True
        '
        'cbReplayAOL
        '
        Me.cbReplayAOL.AutoSize = True
        Me.cbReplayAOL.Location = New System.Drawing.Point(184, 348)
        Me.cbReplayAOL.Name = "cbReplayAOL"
        Me.cbReplayAOL.Size = New System.Drawing.Size(96, 17)
        Me.cbReplayAOL.TabIndex = 51
        Me.cbReplayAOL.Tag = "ReplayAOL"
        Me.cbReplayAOL.Text = "Replay AOL?"
        Me.cbReplayAOL.UseVisualStyleBackColor = True
        '
        'cbReplayGOV
        '
        Me.cbReplayGOV.AutoSize = True
        Me.cbReplayGOV.Location = New System.Drawing.Point(184, 371)
        Me.cbReplayGOV.Name = "cbReplayGOV"
        Me.cbReplayGOV.Size = New System.Drawing.Size(97, 17)
        Me.cbReplayGOV.TabIndex = 52
        Me.cbReplayGOV.Tag = "ReplayGOV"
        Me.cbReplayGOV.Text = "Replay GOV?"
        Me.cbReplayGOV.UseVisualStyleBackColor = True
        '
        'TabPayload
        '
        Me.TabPayload.Controls.Add(Me.GroupBoxLexicalDiversity)
        Me.TabPayload.Controls.Add(Me.GroupBoxReadabilityFeatures)
        Me.TabPayload.Controls.Add(Me.GroupBoxPayloadFeatures)
        Me.TabPayload.Location = New System.Drawing.Point(4, 22)
        Me.TabPayload.Name = "TabPayload"
        Me.TabPayload.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPayload.Size = New System.Drawing.Size(1481, 596)
        Me.TabPayload.TabIndex = 1
        Me.TabPayload.Text = "Payload / Email Body Features"
        Me.TabPayload.UseVisualStyleBackColor = True
        '
        'GroupBoxLexicalDiversity
        '
        Me.GroupBoxLexicalDiversity.Controls.Add(Me.cbLexicalDiversity)
        Me.GroupBoxLexicalDiversity.Controls.Add(Me.cbVocabularyRichness)
        Me.GroupBoxLexicalDiversity.Controls.Add(Me.cblegomena)
        Me.GroupBoxLexicalDiversity.Controls.Add(Me.cbDislegomena)
        Me.GroupBoxLexicalDiversity.Controls.Add(Me.cbYuleK)
        Me.GroupBoxLexicalDiversity.Controls.Add(Me.cbEntropy)
        Me.GroupBoxLexicalDiversity.Controls.Add(Me.cbSichel)
        Me.GroupBoxLexicalDiversity.Controls.Add(Me.cbHonore)
        Me.GroupBoxLexicalDiversity.Location = New System.Drawing.Point(1060, 359)
        Me.GroupBoxLexicalDiversity.Name = "GroupBoxLexicalDiversity"
        Me.GroupBoxLexicalDiversity.Size = New System.Drawing.Size(411, 192)
        Me.GroupBoxLexicalDiversity.TabIndex = 107
        Me.GroupBoxLexicalDiversity.TabStop = False
        '
        'cbLexicalDiversity
        '
        Me.cbLexicalDiversity.AutoSize = True
        Me.cbLexicalDiversity.BackColor = System.Drawing.Color.White
        Me.cbLexicalDiversity.Location = New System.Drawing.Point(0, 0)
        Me.cbLexicalDiversity.Name = "cbLexicalDiversity"
        Me.cbLexicalDiversity.Size = New System.Drawing.Size(172, 17)
        Me.cbLexicalDiversity.TabIndex = 106
        Me.cbLexicalDiversity.Tag = "0"
        Me.cbLexicalDiversity.Text = "Lexical Diversity Features"
        Me.cbLexicalDiversity.UseVisualStyleBackColor = False
        '
        'cbVocabularyRichness
        '
        Me.cbVocabularyRichness.AutoSize = True
        Me.cbVocabularyRichness.Location = New System.Drawing.Point(6, 29)
        Me.cbVocabularyRichness.Name = "cbVocabularyRichness"
        Me.cbVocabularyRichness.Size = New System.Drawing.Size(142, 17)
        Me.cbVocabularyRichness.TabIndex = 108
        Me.cbVocabularyRichness.Tag = "VocabularyRichness"
        Me.cbVocabularyRichness.Text = "Vocabulary Richness"
        Me.cbVocabularyRichness.UseVisualStyleBackColor = True
        '
        'cblegomena
        '
        Me.cblegomena.AutoSize = True
        Me.cblegomena.Location = New System.Drawing.Point(6, 52)
        Me.cblegomena.Name = "cblegomena"
        Me.cblegomena.Size = New System.Drawing.Size(121, 17)
        Me.cblegomena.TabIndex = 109
        Me.cblegomena.Tag = "Legomena"
        Me.cblegomena.Text = "Hapax legomena"
        Me.cblegomena.UseVisualStyleBackColor = True
        '
        'cbDislegomena
        '
        Me.cbDislegomena.AutoSize = True
        Me.cbDislegomena.Location = New System.Drawing.Point(6, 75)
        Me.cbDislegomena.Name = "cbDislegomena"
        Me.cbDislegomena.Size = New System.Drawing.Size(137, 17)
        Me.cbDislegomena.TabIndex = 112
        Me.cbDislegomena.Tag = "Dislegomena"
        Me.cbDislegomena.Text = "Hapax dislegomena"
        Me.cbDislegomena.UseVisualStyleBackColor = True
        '
        'cbYuleK
        '
        Me.cbYuleK.AutoSize = True
        Me.cbYuleK.Location = New System.Drawing.Point(6, 121)
        Me.cbYuleK.Name = "cbYuleK"
        Me.cbYuleK.Size = New System.Drawing.Size(57, 17)
        Me.cbYuleK.TabIndex = 110
        Me.cbYuleK.Tag = "YuleK"
        Me.cbYuleK.Text = "YuleK"
        Me.cbYuleK.UseVisualStyleBackColor = True
        '
        'cbEntropy
        '
        Me.cbEntropy.AutoSize = True
        Me.cbEntropy.Location = New System.Drawing.Point(6, 98)
        Me.cbEntropy.Name = "cbEntropy"
        Me.cbEntropy.Size = New System.Drawing.Size(123, 17)
        Me.cbEntropy.TabIndex = 111
        Me.cbEntropy.Tag = "Entropy"
        Me.cbEntropy.Text = "Entropy measure"
        Me.cbEntropy.UseVisualStyleBackColor = True
        '
        'cbSichel
        '
        Me.cbSichel.AutoSize = True
        Me.cbSichel.Location = New System.Drawing.Point(6, 144)
        Me.cbSichel.Name = "cbSichel"
        Me.cbSichel.Size = New System.Drawing.Size(66, 17)
        Me.cbSichel.TabIndex = 113
        Me.cbSichel.Tag = "Sichel"
        Me.cbSichel.Text = "SichelS"
        Me.cbSichel.UseVisualStyleBackColor = True
        '
        'cbHonore
        '
        Me.cbHonore.AutoSize = True
        Me.cbHonore.Location = New System.Drawing.Point(6, 167)
        Me.cbHonore.Name = "cbHonore"
        Me.cbHonore.Size = New System.Drawing.Size(67, 17)
        Me.cbHonore.TabIndex = 114
        Me.cbHonore.Tag = "Honore"
        Me.cbHonore.Text = "Honore"
        Me.cbHonore.UseVisualStyleBackColor = True
        '
        'GroupBoxReadabilityFeatures
        '
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbWordLengthWithoutStopwords)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbInverseFI_WithoutStopwords)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbComplexWordsWithoutStopwords)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbFISimpleWithoutStopwords)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbSimpleWordsWithoutStopwords)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbFKRI_WithoutStopwords)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbFORCAST_WithoutStopwords)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbSMOG_WithoutStopWords)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbFRESWithoutStopwords)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbFogIndexWithoutStopWords)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbReadabilityFeatures)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbFogIndex)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbFRES)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbSMOGI)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbFORCAST)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbFISimple)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbInverseFI)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbSMOG)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbFKRI)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbARI)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbCLI)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbSimpleWords)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbComplexWords)
        Me.GroupBoxReadabilityFeatures.Controls.Add(Me.cbWordLength)
        Me.GroupBoxReadabilityFeatures.Location = New System.Drawing.Point(1060, 21)
        Me.GroupBoxReadabilityFeatures.Name = "GroupBoxReadabilityFeatures"
        Me.GroupBoxReadabilityFeatures.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.GroupBoxReadabilityFeatures.Size = New System.Drawing.Size(413, 332)
        Me.GroupBoxReadabilityFeatures.TabIndex = 106
        Me.GroupBoxReadabilityFeatures.TabStop = False
        '
        'cbWordLengthWithoutStopwords
        '
        Me.cbWordLengthWithoutStopwords.AutoSize = True
        Me.cbWordLengthWithoutStopwords.Location = New System.Drawing.Point(182, 72)
        Me.cbWordLengthWithoutStopwords.Name = "cbWordLengthWithoutStopwords"
        Me.cbWordLengthWithoutStopwords.Size = New System.Drawing.Size(209, 17)
        Me.cbWordLengthWithoutStopwords.TabIndex = 121
        Me.cbWordLengthWithoutStopwords.Tag = "WordLengthWithoutStopwords"
        Me.cbWordLengthWithoutStopwords.Text = "Word Length Without Stopwords"
        Me.cbWordLengthWithoutStopwords.UseVisualStyleBackColor = True
        '
        'cbInverseFI_WithoutStopwords
        '
        Me.cbInverseFI_WithoutStopwords.AutoSize = True
        Me.cbInverseFI_WithoutStopwords.Location = New System.Drawing.Point(182, 141)
        Me.cbInverseFI_WithoutStopwords.Name = "cbInverseFI_WithoutStopwords"
        Me.cbInverseFI_WithoutStopwords.Size = New System.Drawing.Size(192, 17)
        Me.cbInverseFI_WithoutStopwords.TabIndex = 106
        Me.cbInverseFI_WithoutStopwords.Tag = "InverseFI_WithoutStopwords"
        Me.cbInverseFI_WithoutStopwords.Text = "InverseFI Without Stopwords"
        Me.cbInverseFI_WithoutStopwords.UseVisualStyleBackColor = True
        '
        'cbComplexWordsWithoutStopwords
        '
        Me.cbComplexWordsWithoutStopwords.AutoSize = True
        Me.cbComplexWordsWithoutStopwords.Location = New System.Drawing.Point(182, 49)
        Me.cbComplexWordsWithoutStopwords.Name = "cbComplexWordsWithoutStopwords"
        Me.cbComplexWordsWithoutStopwords.Size = New System.Drawing.Size(225, 17)
        Me.cbComplexWordsWithoutStopwords.TabIndex = 120
        Me.cbComplexWordsWithoutStopwords.Tag = "ComplexWordsWithoutStopwords"
        Me.cbComplexWordsWithoutStopwords.Text = "Complex Words Without Stopwords"
        Me.cbComplexWordsWithoutStopwords.UseVisualStyleBackColor = True
        '
        'cbFISimpleWithoutStopwords
        '
        Me.cbFISimpleWithoutStopwords.AutoSize = True
        Me.cbFISimpleWithoutStopwords.Location = New System.Drawing.Point(182, 118)
        Me.cbFISimpleWithoutStopwords.Name = "cbFISimpleWithoutStopwords"
        Me.cbFISimpleWithoutStopwords.Size = New System.Drawing.Size(189, 17)
        Me.cbFISimpleWithoutStopwords.TabIndex = 105
        Me.cbFISimpleWithoutStopwords.Tag = "FISimpleWithoutStopwords"
        Me.cbFISimpleWithoutStopwords.Text = "FI Simple Without Stopwords"
        Me.cbFISimpleWithoutStopwords.UseVisualStyleBackColor = True
        '
        'cbSimpleWordsWithoutStopwords
        '
        Me.cbSimpleWordsWithoutStopwords.AutoSize = True
        Me.cbSimpleWordsWithoutStopwords.Location = New System.Drawing.Point(182, 26)
        Me.cbSimpleWordsWithoutStopwords.Name = "cbSimpleWordsWithoutStopwords"
        Me.cbSimpleWordsWithoutStopwords.Size = New System.Drawing.Size(214, 17)
        Me.cbSimpleWordsWithoutStopwords.TabIndex = 119
        Me.cbSimpleWordsWithoutStopwords.Tag = "SimpleWordsWithoutStopwords"
        Me.cbSimpleWordsWithoutStopwords.Text = "Simple Words Without Stopwords"
        Me.cbSimpleWordsWithoutStopwords.UseVisualStyleBackColor = True
        '
        'cbFKRI_WithoutStopwords
        '
        Me.cbFKRI_WithoutStopwords.AutoSize = True
        Me.cbFKRI_WithoutStopwords.Location = New System.Drawing.Point(182, 210)
        Me.cbFKRI_WithoutStopwords.Name = "cbFKRI_WithoutStopwords"
        Me.cbFKRI_WithoutStopwords.Size = New System.Drawing.Size(163, 17)
        Me.cbFKRI_WithoutStopwords.TabIndex = 104
        Me.cbFKRI_WithoutStopwords.Tag = "FKRI_WithoutStopwords"
        Me.cbFKRI_WithoutStopwords.Text = "FKRI Without Stopwords"
        Me.cbFKRI_WithoutStopwords.UseVisualStyleBackColor = True
        '
        'cbFORCAST_WithoutStopwords
        '
        Me.cbFORCAST_WithoutStopwords.AutoSize = True
        Me.cbFORCAST_WithoutStopwords.Location = New System.Drawing.Point(182, 187)
        Me.cbFORCAST_WithoutStopwords.Name = "cbFORCAST_WithoutStopwords"
        Me.cbFORCAST_WithoutStopwords.Size = New System.Drawing.Size(188, 17)
        Me.cbFORCAST_WithoutStopwords.TabIndex = 103
        Me.cbFORCAST_WithoutStopwords.Tag = "FORCAST_WithoutStopwords"
        Me.cbFORCAST_WithoutStopwords.Text = "FORCAST Without Stopwords"
        Me.cbFORCAST_WithoutStopwords.UseVisualStyleBackColor = True
        '
        'cbSMOG_WithoutStopWords
        '
        Me.cbSMOG_WithoutStopWords.AutoSize = True
        Me.cbSMOG_WithoutStopWords.Location = New System.Drawing.Point(182, 233)
        Me.cbSMOG_WithoutStopWords.Name = "cbSMOG_WithoutStopWords"
        Me.cbSMOG_WithoutStopWords.Size = New System.Drawing.Size(175, 17)
        Me.cbSMOG_WithoutStopWords.TabIndex = 102
        Me.cbSMOG_WithoutStopWords.Tag = "SMOG_WithoutStopWords"
        Me.cbSMOG_WithoutStopWords.Text = "SMOG Without Stop Words"
        Me.cbSMOG_WithoutStopWords.UseVisualStyleBackColor = True
        '
        'cbFRESWithoutStopwords
        '
        Me.cbFRESWithoutStopwords.AutoSize = True
        Me.cbFRESWithoutStopwords.Location = New System.Drawing.Point(182, 164)
        Me.cbFRESWithoutStopwords.Name = "cbFRESWithoutStopwords"
        Me.cbFRESWithoutStopwords.Size = New System.Drawing.Size(200, 17)
        Me.cbFRESWithoutStopwords.TabIndex = 101
        Me.cbFRESWithoutStopwords.Tag = "FRESWithoutStopwords"
        Me.cbFRESWithoutStopwords.Text = "FRES Index Without Stopwords"
        Me.cbFRESWithoutStopwords.UseVisualStyleBackColor = True
        '
        'cbFogIndexWithoutStopWords
        '
        Me.cbFogIndexWithoutStopWords.AutoSize = True
        Me.cbFogIndexWithoutStopWords.Location = New System.Drawing.Point(182, 95)
        Me.cbFogIndexWithoutStopWords.Name = "cbFogIndexWithoutStopWords"
        Me.cbFogIndexWithoutStopWords.Size = New System.Drawing.Size(195, 17)
        Me.cbFogIndexWithoutStopWords.TabIndex = 100
        Me.cbFogIndexWithoutStopWords.Tag = "FogIndexWithoutStopWords"
        Me.cbFogIndexWithoutStopWords.Text = "Fog Index Without StopWords"
        Me.cbFogIndexWithoutStopWords.UseVisualStyleBackColor = True
        '
        'cbReadabilityFeatures
        '
        Me.cbReadabilityFeatures.AutoSize = True
        Me.cbReadabilityFeatures.BackColor = System.Drawing.Color.White
        Me.cbReadabilityFeatures.Location = New System.Drawing.Point(0, 0)
        Me.cbReadabilityFeatures.Name = "cbReadabilityFeatures"
        Me.cbReadabilityFeatures.Size = New System.Drawing.Size(143, 17)
        Me.cbReadabilityFeatures.TabIndex = 99
        Me.cbReadabilityFeatures.Tag = "0"
        Me.cbReadabilityFeatures.Text = "Readability Features"
        Me.cbReadabilityFeatures.UseVisualStyleBackColor = False
        '
        'cbFogIndex
        '
        Me.cbFogIndex.AutoSize = True
        Me.cbFogIndex.Location = New System.Drawing.Point(23, 95)
        Me.cbFogIndex.Name = "cbFogIndex"
        Me.cbFogIndex.Size = New System.Drawing.Size(82, 17)
        Me.cbFogIndex.TabIndex = 67
        Me.cbFogIndex.Tag = "FogIndex"
        Me.cbFogIndex.Text = "Fog Index"
        Me.cbFogIndex.UseVisualStyleBackColor = True
        '
        'cbFRES
        '
        Me.cbFRES.AutoSize = True
        Me.cbFRES.Location = New System.Drawing.Point(23, 164)
        Me.cbFRES.Name = "cbFRES"
        Me.cbFRES.Size = New System.Drawing.Size(89, 17)
        Me.cbFRES.TabIndex = 68
        Me.cbFRES.Tag = "FRES"
        Me.cbFRES.Text = "FRES Index"
        Me.cbFRES.UseVisualStyleBackColor = True
        '
        'cbSMOGI
        '
        Me.cbSMOGI.AutoSize = True
        Me.cbSMOGI.Location = New System.Drawing.Point(23, 256)
        Me.cbSMOGI.Name = "cbSMOGI"
        Me.cbSMOGI.Size = New System.Drawing.Size(105, 17)
        Me.cbSMOGI.TabIndex = 69
        Me.cbSMOGI.Tag = "SMOG-I"
        Me.cbSMOGI.Text = "SMOG-I Index"
        Me.cbSMOGI.UseVisualStyleBackColor = True
        '
        'cbFORCAST
        '
        Me.cbFORCAST.AutoSize = True
        Me.cbFORCAST.Location = New System.Drawing.Point(23, 187)
        Me.cbFORCAST.Name = "cbFORCAST"
        Me.cbFORCAST.Size = New System.Drawing.Size(113, 17)
        Me.cbFORCAST.TabIndex = 70
        Me.cbFORCAST.Tag = "FORCAST"
        Me.cbFORCAST.Text = "FORCAST Index"
        Me.cbFORCAST.UseVisualStyleBackColor = True
        '
        'cbFISimple
        '
        Me.cbFISimple.AutoSize = True
        Me.cbFISimple.Location = New System.Drawing.Point(23, 118)
        Me.cbFISimple.Name = "cbFISimple"
        Me.cbFISimple.Size = New System.Drawing.Size(114, 17)
        Me.cbFISimple.TabIndex = 73
        Me.cbFISimple.Tag = "FISimple"
        Me.cbFISimple.Text = "FI Simple Index"
        Me.cbFISimple.UseVisualStyleBackColor = True
        '
        'cbInverseFI
        '
        Me.cbInverseFI.AutoSize = True
        Me.cbInverseFI.Location = New System.Drawing.Point(23, 141)
        Me.cbInverseFI.Name = "cbInverseFI"
        Me.cbInverseFI.Size = New System.Drawing.Size(120, 17)
        Me.cbInverseFI.TabIndex = 74
        Me.cbInverseFI.Tag = "InverseFI"
        Me.cbInverseFI.Text = "Inverse FI Index"
        Me.cbInverseFI.UseVisualStyleBackColor = True
        '
        'cbSMOG
        '
        Me.cbSMOG.AutoSize = True
        Me.cbSMOG.Location = New System.Drawing.Point(23, 233)
        Me.cbSMOG.Name = "cbSMOG"
        Me.cbSMOG.Size = New System.Drawing.Size(95, 17)
        Me.cbSMOG.TabIndex = 75
        Me.cbSMOG.Tag = "SMOG"
        Me.cbSMOG.Text = "SMOG Index"
        Me.cbSMOG.UseVisualStyleBackColor = True
        '
        'cbFKRI
        '
        Me.cbFKRI.AutoSize = True
        Me.cbFKRI.Location = New System.Drawing.Point(23, 210)
        Me.cbFKRI.Name = "cbFKRI"
        Me.cbFKRI.Size = New System.Drawing.Size(88, 17)
        Me.cbFKRI.TabIndex = 71
        Me.cbFKRI.Tag = "FKRI"
        Me.cbFKRI.Text = "FKRI Index"
        Me.cbFKRI.UseVisualStyleBackColor = True
        '
        'cbARI
        '
        Me.cbARI.AutoSize = True
        Me.cbARI.Location = New System.Drawing.Point(23, 279)
        Me.cbARI.Name = "cbARI"
        Me.cbARI.Size = New System.Drawing.Size(83, 17)
        Me.cbARI.TabIndex = 76
        Me.cbARI.Tag = "ARI"
        Me.cbARI.Text = "ARI Index"
        Me.cbARI.UseVisualStyleBackColor = True
        '
        'cbCLI
        '
        Me.cbCLI.AutoSize = True
        Me.cbCLI.Location = New System.Drawing.Point(23, 302)
        Me.cbCLI.Name = "cbCLI"
        Me.cbCLI.Size = New System.Drawing.Size(80, 17)
        Me.cbCLI.TabIndex = 77
        Me.cbCLI.Tag = "CLI"
        Me.cbCLI.Text = "CLI Index"
        Me.cbCLI.UseVisualStyleBackColor = True
        '
        'cbSimpleWords
        '
        Me.cbSimpleWords.AutoSize = True
        Me.cbSimpleWords.Location = New System.Drawing.Point(23, 26)
        Me.cbSimpleWords.Name = "cbSimpleWords"
        Me.cbSimpleWords.Size = New System.Drawing.Size(139, 17)
        Me.cbSimpleWords.TabIndex = 65
        Me.cbSimpleWords.Tag = "SimpleWords"
        Me.cbSimpleWords.Text = "Simple Words Count"
        Me.cbSimpleWords.UseVisualStyleBackColor = True
        '
        'cbComplexWords
        '
        Me.cbComplexWords.AutoSize = True
        Me.cbComplexWords.Location = New System.Drawing.Point(23, 49)
        Me.cbComplexWords.Name = "cbComplexWords"
        Me.cbComplexWords.Size = New System.Drawing.Size(150, 17)
        Me.cbComplexWords.TabIndex = 66
        Me.cbComplexWords.Tag = "ComplexWords"
        Me.cbComplexWords.Text = "Complex Words Count"
        Me.cbComplexWords.UseVisualStyleBackColor = True
        '
        'cbWordLength
        '
        Me.cbWordLength.AutoSize = True
        Me.cbWordLength.Location = New System.Drawing.Point(23, 72)
        Me.cbWordLength.Name = "cbWordLength"
        Me.cbWordLength.Size = New System.Drawing.Size(98, 17)
        Me.cbWordLength.TabIndex = 72
        Me.cbWordLength.Tag = "WordLength"
        Me.cbWordLength.Text = "Word Length"
        Me.cbWordLength.UseVisualStyleBackColor = True
        '
        'GroupBoxPayloadFeatures
        '
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbTFISFWithoutStopwords)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbMaxLongestRepeatingCharacter)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbMinCharacterDiversity)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbUniqueHTMLAnchor)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbRatioNonAlphaNumToAll)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbRatioDigitToAll)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbRatioUpperToAll)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbRatioUpperLower)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbAvgWordsinSentences)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbAvgCharinParagraphs)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbAvgWordsinParagraphs)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbAvgSentenceinParagraphs)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbCountofParagraphs)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbPayloadFeatures)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbSpamWords)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbFunctionWords)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbHTMLAnchor)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbHTMLNotAnchor)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbHTMLImage)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbLongestCapital)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbCountCapWord)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbSenBegLower)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbCountLines)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbSenBegUpper)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbAllCountDigitWord)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbCountSentence)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbSingleCharWords)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbHTMLTags)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbDuplicateWords)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbCountLowerChars)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbTFISF)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbSingleDigitWords)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbAllCountCapWord)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbQuestionMark)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbSingleLetterWords)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbExclamationMark)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbCountUpperChars)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbComma)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbCountWord)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbSemiColon)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbColon)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbSingleQuote)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbPeriod)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbSpace)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbTab)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbDollar)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbEllipsis)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbWordsMinChar)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbMultipleExclamationMarks)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbAlphaOnly)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbAlphaChars)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbMultipleQuestionMarks)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbSpecialChars)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbWordsMaxChar)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbCountDigitChars)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbWordsAVGChar)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbCountWordLess3Char)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbCountChars)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbCountWordLonger6Char)
        Me.GroupBoxPayloadFeatures.Controls.Add(Me.cbAlphaNumeric)
        Me.GroupBoxPayloadFeatures.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxPayloadFeatures.Location = New System.Drawing.Point(9, 8)
        Me.GroupBoxPayloadFeatures.Name = "GroupBoxPayloadFeatures"
        Me.GroupBoxPayloadFeatures.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.GroupBoxPayloadFeatures.Size = New System.Drawing.Size(1025, 543)
        Me.GroupBoxPayloadFeatures.TabIndex = 105
        Me.GroupBoxPayloadFeatures.TabStop = False
        '
        'cbTFISFWithoutStopwords
        '
        Me.cbTFISFWithoutStopwords.AutoSize = True
        Me.cbTFISFWithoutStopwords.Location = New System.Drawing.Point(238, 397)
        Me.cbTFISFWithoutStopwords.Name = "cbTFISFWithoutStopwords"
        Me.cbTFISFWithoutStopwords.Size = New System.Drawing.Size(167, 17)
        Me.cbTFISFWithoutStopwords.TabIndex = 118
        Me.cbTFISFWithoutStopwords.Tag = "TFISFWithoutStopwords"
        Me.cbTFISFWithoutStopwords.Text = "TF-ISF Without Stopword"
        Me.cbTFISFWithoutStopwords.UseVisualStyleBackColor = True
        '
        'cbMaxLongestRepeatingCharacter
        '
        Me.cbMaxLongestRepeatingCharacter.AutoSize = True
        Me.cbMaxLongestRepeatingCharacter.Location = New System.Drawing.Point(463, 466)
        Me.cbMaxLongestRepeatingCharacter.Name = "cbMaxLongestRepeatingCharacter"
        Me.cbMaxLongestRepeatingCharacter.Size = New System.Drawing.Size(218, 17)
        Me.cbMaxLongestRepeatingCharacter.TabIndex = 117
        Me.cbMaxLongestRepeatingCharacter.Tag = "MaxLongestRepeatingCharacter"
        Me.cbMaxLongestRepeatingCharacter.Text = "Max Longest Repeating Character"
        Me.cbMaxLongestRepeatingCharacter.UseVisualStyleBackColor = True
        '
        'cbMinCharacterDiversity
        '
        Me.cbMinCharacterDiversity.AutoSize = True
        Me.cbMinCharacterDiversity.Location = New System.Drawing.Point(463, 443)
        Me.cbMinCharacterDiversity.Name = "cbMinCharacterDiversity"
        Me.cbMinCharacterDiversity.Size = New System.Drawing.Size(159, 17)
        Me.cbMinCharacterDiversity.TabIndex = 116
        Me.cbMinCharacterDiversity.Tag = "MinCharacterDiversity"
        Me.cbMinCharacterDiversity.Text = "Min Character Diversity"
        Me.cbMinCharacterDiversity.UseVisualStyleBackColor = True
        '
        'cbUniqueHTMLAnchor
        '
        Me.cbUniqueHTMLAnchor.AutoSize = True
        Me.cbUniqueHTMLAnchor.Location = New System.Drawing.Point(15, 167)
        Me.cbUniqueHTMLAnchor.Name = "cbUniqueHTMLAnchor"
        Me.cbUniqueHTMLAnchor.Size = New System.Drawing.Size(142, 17)
        Me.cbUniqueHTMLAnchor.TabIndex = 115
        Me.cbUniqueHTMLAnchor.Tag = "UniqueHTMLAnchor"
        Me.cbUniqueHTMLAnchor.Text = "Unique HTML Anchor"
        Me.cbUniqueHTMLAnchor.UseVisualStyleBackColor = True
        '
        'cbRatioNonAlphaNumToAll
        '
        Me.cbRatioNonAlphaNumToAll.AutoSize = True
        Me.cbRatioNonAlphaNumToAll.Location = New System.Drawing.Point(463, 420)
        Me.cbRatioNonAlphaNumToAll.Name = "cbRatioNonAlphaNumToAll"
        Me.cbRatioNonAlphaNumToAll.Size = New System.Drawing.Size(344, 17)
        Me.cbRatioNonAlphaNumToAll.TabIndex = 107
        Me.cbRatioNonAlphaNumToAll.Tag = "RatioNonAlphaNumToAll"
        Me.cbRatioNonAlphaNumToAll.Text = "Max of ratio of non-alphanumeric to all char.(each word)"
        Me.cbRatioNonAlphaNumToAll.UseVisualStyleBackColor = True
        '
        'cbRatioDigitToAll
        '
        Me.cbRatioDigitToAll.AutoSize = True
        Me.cbRatioDigitToAll.Location = New System.Drawing.Point(463, 397)
        Me.cbRatioDigitToAll.Name = "cbRatioDigitToAll"
        Me.cbRatioDigitToAll.Size = New System.Drawing.Size(266, 17)
        Me.cbRatioDigitToAll.TabIndex = 106
        Me.cbRatioDigitToAll.Tag = "RatioDigitToAll"
        Me.cbRatioDigitToAll.Text = "Max of ratio of digit to all char.(each word)"
        Me.cbRatioDigitToAll.UseVisualStyleBackColor = True
        '
        'cbRatioUpperToAll
        '
        Me.cbRatioUpperToAll.AutoSize = True
        Me.cbRatioUpperToAll.Location = New System.Drawing.Point(463, 374)
        Me.cbRatioUpperToAll.Name = "cbRatioUpperToAll"
        Me.cbRatioUpperToAll.Size = New System.Drawing.Size(274, 17)
        Me.cbRatioUpperToAll.TabIndex = 105
        Me.cbRatioUpperToAll.Tag = "RatioUpperToAll"
        Me.cbRatioUpperToAll.Text = "Max of ratio of upper to all char.(each word)"
        Me.cbRatioUpperToAll.UseVisualStyleBackColor = True
        '
        'cbRatioUpperLower
        '
        Me.cbRatioUpperLower.AutoSize = True
        Me.cbRatioUpperLower.Location = New System.Drawing.Point(463, 351)
        Me.cbRatioUpperLower.Name = "cbRatioUpperLower"
        Me.cbRatioUpperLower.Size = New System.Drawing.Size(247, 17)
        Me.cbRatioUpperLower.TabIndex = 104
        Me.cbRatioUpperLower.Tag = "RatioUpperLower"
        Me.cbRatioUpperLower.Text = "Max ratio of upper to lower(each word)"
        Me.cbRatioUpperLower.UseVisualStyleBackColor = True
        '
        'cbAvgWordsinSentences
        '
        Me.cbAvgWordsinSentences.AutoSize = True
        Me.cbAvgWordsinSentences.Location = New System.Drawing.Point(463, 328)
        Me.cbAvgWordsinSentences.Name = "cbAvgWordsinSentences"
        Me.cbAvgWordsinSentences.Size = New System.Drawing.Size(226, 17)
        Me.cbAvgWordsinSentences.TabIndex = 103
        Me.cbAvgWordsinSentences.Tag = "AvgWordsinSentences"
        Me.cbAvgWordsinSentences.Text = "Avg. number of word per sentences"
        Me.cbAvgWordsinSentences.UseVisualStyleBackColor = True
        '
        'cbAvgCharinParagraphs
        '
        Me.cbAvgCharinParagraphs.AutoSize = True
        Me.cbAvgCharinParagraphs.Location = New System.Drawing.Point(463, 305)
        Me.cbAvgCharinParagraphs.Name = "cbAvgCharinParagraphs"
        Me.cbAvgCharinParagraphs.Size = New System.Drawing.Size(251, 17)
        Me.cbAvgCharinParagraphs.TabIndex = 102
        Me.cbAvgCharinParagraphs.Tag = "AvgCharinParagraphs"
        Me.cbAvgCharinParagraphs.Text = "Avg number of character per paragraph"
        Me.cbAvgCharinParagraphs.UseVisualStyleBackColor = True
        '
        'cbAvgWordsinParagraphs
        '
        Me.cbAvgWordsinParagraphs.AutoSize = True
        Me.cbAvgWordsinParagraphs.Location = New System.Drawing.Point(463, 282)
        Me.cbAvgWordsinParagraphs.Name = "cbAvgWordsinParagraphs"
        Me.cbAvgWordsinParagraphs.Size = New System.Drawing.Size(233, 17)
        Me.cbAvgWordsinParagraphs.TabIndex = 101
        Me.cbAvgWordsinParagraphs.Tag = "AvgWordsinParagraphs"
        Me.cbAvgWordsinParagraphs.Text = "Avg. number of words pre paragraph"
        Me.cbAvgWordsinParagraphs.UseVisualStyleBackColor = True
        '
        'cbAvgSentenceinParagraphs
        '
        Me.cbAvgSentenceinParagraphs.AutoSize = True
        Me.cbAvgSentenceinParagraphs.Location = New System.Drawing.Point(463, 259)
        Me.cbAvgSentenceinParagraphs.Name = "cbAvgSentenceinParagraphs"
        Me.cbAvgSentenceinParagraphs.Size = New System.Drawing.Size(257, 17)
        Me.cbAvgSentenceinParagraphs.TabIndex = 100
        Me.cbAvgSentenceinParagraphs.Tag = "AvgSentenceinParagraphs"
        Me.cbAvgSentenceinParagraphs.Text = "Avg. number of sentences per paragraph"
        Me.cbAvgSentenceinParagraphs.UseVisualStyleBackColor = True
        '
        'cbCountofParagraphs
        '
        Me.cbCountofParagraphs.AutoSize = True
        Me.cbCountofParagraphs.Location = New System.Drawing.Point(238, 443)
        Me.cbCountofParagraphs.Name = "cbCountofParagraphs"
        Me.cbCountofParagraphs.Size = New System.Drawing.Size(141, 17)
        Me.cbCountofParagraphs.TabIndex = 99
        Me.cbCountofParagraphs.Tag = "CountofParagraphs"
        Me.cbCountofParagraphs.Text = "Count of Paragraphs"
        Me.cbCountofParagraphs.UseVisualStyleBackColor = True
        '
        'cbPayloadFeatures
        '
        Me.cbPayloadFeatures.AutoSize = True
        Me.cbPayloadFeatures.BackColor = System.Drawing.Color.White
        Me.cbPayloadFeatures.Location = New System.Drawing.Point(0, 0)
        Me.cbPayloadFeatures.Name = "cbPayloadFeatures"
        Me.cbPayloadFeatures.Size = New System.Drawing.Size(140, 17)
        Me.cbPayloadFeatures.TabIndex = 98
        Me.cbPayloadFeatures.Tag = "0"
        Me.cbPayloadFeatures.Text = "Email Body Features"
        Me.cbPayloadFeatures.UseVisualStyleBackColor = False
        '
        'cbSpamWords
        '
        Me.cbSpamWords.AutoSize = True
        Me.cbSpamWords.Location = New System.Drawing.Point(15, 29)
        Me.cbSpamWords.Name = "cbSpamWords"
        Me.cbSpamWords.Size = New System.Drawing.Size(97, 17)
        Me.cbSpamWords.TabIndex = 0
        Me.cbSpamWords.Tag = "SpamWords"
        Me.cbSpamWords.Text = "Spam Words"
        Me.cbSpamWords.UseVisualStyleBackColor = True
        '
        'cbFunctionWords
        '
        Me.cbFunctionWords.AutoSize = True
        Me.cbFunctionWords.Location = New System.Drawing.Point(15, 52)
        Me.cbFunctionWords.Name = "cbFunctionWords"
        Me.cbFunctionWords.Size = New System.Drawing.Size(113, 17)
        Me.cbFunctionWords.TabIndex = 6
        Me.cbFunctionWords.Tag = "FunctionWords"
        Me.cbFunctionWords.Text = "Function Words"
        Me.cbFunctionWords.UseVisualStyleBackColor = True
        '
        'cbHTMLAnchor
        '
        Me.cbHTMLAnchor.AutoSize = True
        Me.cbHTMLAnchor.Location = New System.Drawing.Point(15, 75)
        Me.cbHTMLAnchor.Name = "cbHTMLAnchor"
        Me.cbHTMLAnchor.Size = New System.Drawing.Size(100, 17)
        Me.cbHTMLAnchor.TabIndex = 1
        Me.cbHTMLAnchor.Tag = "HTMLAnchor"
        Me.cbHTMLAnchor.Text = "HTML Anchor"
        Me.cbHTMLAnchor.UseVisualStyleBackColor = True
        '
        'cbHTMLNotAnchor
        '
        Me.cbHTMLNotAnchor.AutoSize = True
        Me.cbHTMLNotAnchor.Location = New System.Drawing.Point(15, 98)
        Me.cbHTMLNotAnchor.Name = "cbHTMLNotAnchor"
        Me.cbHTMLNotAnchor.Size = New System.Drawing.Size(122, 17)
        Me.cbHTMLNotAnchor.TabIndex = 2
        Me.cbHTMLNotAnchor.Tag = "HTMLNotAnchor"
        Me.cbHTMLNotAnchor.Text = "HTML Not Anchor"
        Me.cbHTMLNotAnchor.UseVisualStyleBackColor = True
        '
        'cbHTMLImage
        '
        Me.cbHTMLImage.AutoSize = True
        Me.cbHTMLImage.Location = New System.Drawing.Point(15, 144)
        Me.cbHTMLImage.Name = "cbHTMLImage"
        Me.cbHTMLImage.Size = New System.Drawing.Size(97, 17)
        Me.cbHTMLImage.TabIndex = 97
        Me.cbHTMLImage.Tag = "HTMLImage"
        Me.cbHTMLImage.Text = "HTML Image"
        Me.cbHTMLImage.UseVisualStyleBackColor = True
        '
        'cbLongestCapital
        '
        Me.cbLongestCapital.AutoSize = True
        Me.cbLongestCapital.Location = New System.Drawing.Point(463, 236)
        Me.cbLongestCapital.Name = "cbLongestCapital"
        Me.cbLongestCapital.Size = New System.Drawing.Size(277, 17)
        Me.cbLongestCapital.TabIndex = 80
        Me.cbLongestCapital.Tag = "LongestCapital"
        Me.cbLongestCapital.Text = "Longest sequence of adjacent capital letters"
        Me.cbLongestCapital.UseVisualStyleBackColor = True
        '
        'cbCountCapWord
        '
        Me.cbCountCapWord.AutoSize = True
        Me.cbCountCapWord.Location = New System.Drawing.Point(463, 167)
        Me.cbCountCapWord.Name = "cbCountCapWord"
        Me.cbCountCapWord.Size = New System.Drawing.Size(127, 17)
        Me.cbCountCapWord.TabIndex = 84
        Me.cbCountCapWord.Tag = "CountCapWord"
        Me.cbCountCapWord.Text = "Capitalized Words"
        Me.cbCountCapWord.UseVisualStyleBackColor = True
        '
        'cbSenBegLower
        '
        Me.cbSenBegLower.AutoSize = True
        Me.cbSenBegLower.Location = New System.Drawing.Point(463, 213)
        Me.cbSenBegLower.Name = "cbSenBegLower"
        Me.cbSenBegLower.Size = New System.Drawing.Size(238, 17)
        Me.cbSenBegLower.TabIndex = 57
        Me.cbSenBegLower.Tag = "SenBegLower"
        Me.cbSenBegLower.Text = "Number of Sentence begin with Lower"
        Me.cbSenBegLower.UseVisualStyleBackColor = True
        '
        'cbCountLines
        '
        Me.cbCountLines.AutoSize = True
        Me.cbCountLines.Location = New System.Drawing.Point(238, 420)
        Me.cbCountLines.Name = "cbCountLines"
        Me.cbCountLines.Size = New System.Drawing.Size(106, 17)
        Me.cbCountLines.TabIndex = 78
        Me.cbCountLines.Tag = "CountLines"
        Me.cbCountLines.Text = "Count Of Lines"
        Me.cbCountLines.UseVisualStyleBackColor = True
        '
        'cbSenBegUpper
        '
        Me.cbSenBegUpper.AutoSize = True
        Me.cbSenBegUpper.Location = New System.Drawing.Point(463, 190)
        Me.cbSenBegUpper.Name = "cbSenBegUpper"
        Me.cbSenBegUpper.Size = New System.Drawing.Size(241, 17)
        Me.cbSenBegUpper.TabIndex = 56
        Me.cbSenBegUpper.Tag = "SenBegUpper"
        Me.cbSenBegUpper.Text = "Number of Sentence begin with Upper "
        Me.cbSenBegUpper.UseVisualStyleBackColor = True
        '
        'cbAllCountDigitWord
        '
        Me.cbAllCountDigitWord.AutoSize = True
        Me.cbAllCountDigitWord.Location = New System.Drawing.Point(463, 144)
        Me.cbAllCountDigitWord.Name = "cbAllCountDigitWord"
        Me.cbAllCountDigitWord.Size = New System.Drawing.Size(108, 17)
        Me.cbAllCountDigitWord.TabIndex = 86
        Me.cbAllCountDigitWord.Tag = "AllCountDigitWord"
        Me.cbAllCountDigitWord.Text = "All Digit Words"
        Me.cbAllCountDigitWord.UseVisualStyleBackColor = True
        '
        'cbCountSentence
        '
        Me.cbCountSentence.AutoSize = True
        Me.cbCountSentence.Location = New System.Drawing.Point(15, 443)
        Me.cbCountSentence.Name = "cbCountSentence"
        Me.cbCountSentence.Size = New System.Drawing.Size(115, 17)
        Me.cbCountSentence.TabIndex = 21
        Me.cbCountSentence.Tag = "CountSentence"
        Me.cbCountSentence.Text = "Sentence Count"
        Me.cbCountSentence.UseVisualStyleBackColor = True
        '
        'cbSingleCharWords
        '
        Me.cbSingleCharWords.AutoSize = True
        Me.cbSingleCharWords.Location = New System.Drawing.Point(463, 75)
        Me.cbSingleCharWords.Name = "cbSingleCharWords"
        Me.cbSingleCharWords.Size = New System.Drawing.Size(131, 17)
        Me.cbSingleCharWords.TabIndex = 94
        Me.cbSingleCharWords.Tag = "SingleCharWords"
        Me.cbSingleCharWords.Text = "Single Char. Words"
        Me.cbSingleCharWords.UseVisualStyleBackColor = True
        '
        'cbHTMLTags
        '
        Me.cbHTMLTags.AutoSize = True
        Me.cbHTMLTags.Location = New System.Drawing.Point(15, 121)
        Me.cbHTMLTags.Name = "cbHTMLTags"
        Me.cbHTMLTags.Size = New System.Drawing.Size(104, 17)
        Me.cbHTMLTags.TabIndex = 3
        Me.cbHTMLTags.Tag = "HTMLTags"
        Me.cbHTMLTags.Text = "HTML All Tags"
        Me.cbHTMLTags.UseVisualStyleBackColor = True
        '
        'cbDuplicateWords
        '
        Me.cbDuplicateWords.AutoSize = True
        Me.cbDuplicateWords.Location = New System.Drawing.Point(463, 98)
        Me.cbDuplicateWords.Name = "cbDuplicateWords"
        Me.cbDuplicateWords.Size = New System.Drawing.Size(151, 17)
        Me.cbDuplicateWords.TabIndex = 81
        Me.cbDuplicateWords.Tag = "DuplicateWords"
        Me.cbDuplicateWords.Text = "Count DuplicateWords"
        Me.cbDuplicateWords.UseVisualStyleBackColor = True
        '
        'cbCountLowerChars
        '
        Me.cbCountLowerChars.AutoSize = True
        Me.cbCountLowerChars.Location = New System.Drawing.Point(238, 351)
        Me.cbCountLowerChars.Name = "cbCountLowerChars"
        Me.cbCountLowerChars.Size = New System.Drawing.Size(131, 17)
        Me.cbCountLowerChars.TabIndex = 79
        Me.cbCountLowerChars.Tag = "CountLowerChars"
        Me.cbCountLowerChars.Text = "Lower Chars Count"
        Me.cbCountLowerChars.UseVisualStyleBackColor = True
        '
        'cbTFISF
        '
        Me.cbTFISF.AutoSize = True
        Me.cbTFISF.Location = New System.Drawing.Point(238, 374)
        Me.cbTFISF.Name = "cbTFISF"
        Me.cbTFISF.Size = New System.Drawing.Size(62, 17)
        Me.cbTFISF.TabIndex = 7
        Me.cbTFISF.Tag = "TFISF"
        Me.cbTFISF.Text = "TF-ISF"
        Me.cbTFISF.UseVisualStyleBackColor = True
        '
        'cbSingleDigitWords
        '
        Me.cbSingleDigitWords.AutoSize = True
        Me.cbSingleDigitWords.Location = New System.Drawing.Point(463, 52)
        Me.cbSingleDigitWords.Name = "cbSingleDigitWords"
        Me.cbSingleDigitWords.Size = New System.Drawing.Size(128, 17)
        Me.cbSingleDigitWords.TabIndex = 92
        Me.cbSingleDigitWords.Tag = "SingleDigitWords"
        Me.cbSingleDigitWords.Text = "Single Digit Words"
        Me.cbSingleDigitWords.UseVisualStyleBackColor = True
        '
        'cbAllCountCapWord
        '
        Me.cbAllCountCapWord.AutoSize = True
        Me.cbAllCountCapWord.Location = New System.Drawing.Point(463, 121)
        Me.cbAllCountCapWord.Name = "cbAllCountCapWord"
        Me.cbAllCountCapWord.Size = New System.Drawing.Size(144, 17)
        Me.cbAllCountCapWord.TabIndex = 62
        Me.cbAllCountCapWord.Tag = "AllCountCapWord"
        Me.cbAllCountCapWord.Text = "All Capitalized Words"
        Me.cbAllCountCapWord.UseVisualStyleBackColor = True
        '
        'cbQuestionMark
        '
        Me.cbQuestionMark.AutoSize = True
        Me.cbQuestionMark.Location = New System.Drawing.Point(238, 29)
        Me.cbQuestionMark.Name = "cbQuestionMark"
        Me.cbQuestionMark.Size = New System.Drawing.Size(80, 17)
        Me.cbQuestionMark.TabIndex = 22
        Me.cbQuestionMark.Tag = "QuestionMark"
        Me.cbQuestionMark.Text = """?"" Count"
        Me.cbQuestionMark.UseVisualStyleBackColor = True
        '
        'cbSingleLetterWords
        '
        Me.cbSingleLetterWords.AutoSize = True
        Me.cbSingleLetterWords.Location = New System.Drawing.Point(463, 29)
        Me.cbSingleLetterWords.Name = "cbSingleLetterWords"
        Me.cbSingleLetterWords.Size = New System.Drawing.Size(137, 17)
        Me.cbSingleLetterWords.TabIndex = 90
        Me.cbSingleLetterWords.Tag = "SingleLetterWords"
        Me.cbSingleLetterWords.Text = "Single Letter Words"
        Me.cbSingleLetterWords.UseVisualStyleBackColor = True
        '
        'cbExclamationMark
        '
        Me.cbExclamationMark.AutoSize = True
        Me.cbExclamationMark.Location = New System.Drawing.Point(238, 52)
        Me.cbExclamationMark.Name = "cbExclamationMark"
        Me.cbExclamationMark.Size = New System.Drawing.Size(77, 17)
        Me.cbExclamationMark.TabIndex = 23
        Me.cbExclamationMark.Tag = "ExclamationMark"
        Me.cbExclamationMark.Text = """!"" Count"
        Me.cbExclamationMark.UseVisualStyleBackColor = True
        '
        'cbCountUpperChars
        '
        Me.cbCountUpperChars.AutoSize = True
        Me.cbCountUpperChars.Location = New System.Drawing.Point(238, 328)
        Me.cbCountUpperChars.Name = "cbCountUpperChars"
        Me.cbCountUpperChars.Size = New System.Drawing.Size(131, 17)
        Me.cbCountUpperChars.TabIndex = 36
        Me.cbCountUpperChars.Tag = "CountUpperChars"
        Me.cbCountUpperChars.Text = "Upper Chars Count"
        Me.cbCountUpperChars.UseVisualStyleBackColor = True
        '
        'cbComma
        '
        Me.cbComma.AutoSize = True
        Me.cbComma.Location = New System.Drawing.Point(238, 75)
        Me.cbComma.Name = "cbComma"
        Me.cbComma.Size = New System.Drawing.Size(77, 17)
        Me.cbComma.TabIndex = 24
        Me.cbComma.Tag = "Comma"
        Me.cbComma.Text = ""","" Count"
        Me.cbComma.UseVisualStyleBackColor = True
        '
        'cbCountWord
        '
        Me.cbCountWord.AutoSize = True
        Me.cbCountWord.Location = New System.Drawing.Point(15, 466)
        Me.cbCountWord.Name = "cbCountWord"
        Me.cbCountWord.Size = New System.Drawing.Size(98, 17)
        Me.cbCountWord.TabIndex = 31
        Me.cbCountWord.Tag = "CountWord"
        Me.cbCountWord.Text = "Words Count"
        Me.cbCountWord.UseVisualStyleBackColor = True
        '
        'cbSemiColon
        '
        Me.cbSemiColon.AutoSize = True
        Me.cbSemiColon.Location = New System.Drawing.Point(238, 98)
        Me.cbSemiColon.Name = "cbSemiColon"
        Me.cbSemiColon.Size = New System.Drawing.Size(77, 17)
        Me.cbSemiColon.TabIndex = 25
        Me.cbSemiColon.Tag = "SemiColon"
        Me.cbSemiColon.Text = """;"" Count"
        Me.cbSemiColon.UseVisualStyleBackColor = True
        '
        'cbColon
        '
        Me.cbColon.AutoSize = True
        Me.cbColon.Location = New System.Drawing.Point(238, 121)
        Me.cbColon.Name = "cbColon"
        Me.cbColon.Size = New System.Drawing.Size(77, 17)
        Me.cbColon.TabIndex = 26
        Me.cbColon.Tag = "Colon"
        Me.cbColon.Text = """:"" Count"
        Me.cbColon.UseVisualStyleBackColor = True
        '
        'cbSingleQuote
        '
        Me.cbSingleQuote.AutoSize = True
        Me.cbSingleQuote.Location = New System.Drawing.Point(238, 144)
        Me.cbSingleQuote.Name = "cbSingleQuote"
        Me.cbSingleQuote.Size = New System.Drawing.Size(83, 17)
        Me.cbSingleQuote.TabIndex = 27
        Me.cbSingleQuote.Tag = "SingleQuote"
        Me.cbSingleQuote.Text = """ ' "" Count"
        Me.cbSingleQuote.UseVisualStyleBackColor = True
        '
        'cbPeriod
        '
        Me.cbPeriod.AutoSize = True
        Me.cbPeriod.Location = New System.Drawing.Point(238, 167)
        Me.cbPeriod.Name = "cbPeriod"
        Me.cbPeriod.Size = New System.Drawing.Size(77, 17)
        Me.cbPeriod.TabIndex = 28
        Me.cbPeriod.Tag = "Period"
        Me.cbPeriod.Text = """."" Count"
        Me.cbPeriod.UseVisualStyleBackColor = True
        '
        'cbSpace
        '
        Me.cbSpace.AutoSize = True
        Me.cbSpace.Location = New System.Drawing.Point(238, 190)
        Me.cbSpace.Name = "cbSpace"
        Me.cbSpace.Size = New System.Drawing.Size(77, 17)
        Me.cbSpace.TabIndex = 29
        Me.cbSpace.Tag = "Space"
        Me.cbSpace.Text = """ "" Count"
        Me.cbSpace.UseVisualStyleBackColor = True
        '
        'cbTab
        '
        Me.cbTab.AutoSize = True
        Me.cbTab.Location = New System.Drawing.Point(238, 213)
        Me.cbTab.Name = "cbTab"
        Me.cbTab.Size = New System.Drawing.Size(83, 17)
        Me.cbTab.TabIndex = 30
        Me.cbTab.Tag = "Tab"
        Me.cbTab.Text = "Tab Count"
        Me.cbTab.UseVisualStyleBackColor = True
        '
        'cbDollar
        '
        Me.cbDollar.AutoSize = True
        Me.cbDollar.Location = New System.Drawing.Point(238, 236)
        Me.cbDollar.Name = "cbDollar"
        Me.cbDollar.Size = New System.Drawing.Size(81, 17)
        Me.cbDollar.TabIndex = 60
        Me.cbDollar.Tag = "Dollar"
        Me.cbDollar.Text = """$"" Count"
        Me.cbDollar.UseVisualStyleBackColor = True
        '
        'cbEllipsis
        '
        Me.cbEllipsis.AutoSize = True
        Me.cbEllipsis.Location = New System.Drawing.Point(238, 259)
        Me.cbEllipsis.Name = "cbEllipsis"
        Me.cbEllipsis.Size = New System.Drawing.Size(99, 17)
        Me.cbEllipsis.TabIndex = 40
        Me.cbEllipsis.Tag = "Ellipsis"
        Me.cbEllipsis.Text = "Ellipsis Count"
        Me.cbEllipsis.UseVisualStyleBackColor = True
        '
        'cbWordsMinChar
        '
        Me.cbWordsMinChar.AutoSize = True
        Me.cbWordsMinChar.Location = New System.Drawing.Point(15, 236)
        Me.cbWordsMinChar.Name = "cbWordsMinChar"
        Me.cbWordsMinChar.Size = New System.Drawing.Size(121, 17)
        Me.cbWordsMinChar.TabIndex = 64
        Me.cbWordsMinChar.Tag = "WordsMinChar"
        Me.cbWordsMinChar.Text = "Min Word Length"
        Me.cbWordsMinChar.UseVisualStyleBackColor = True
        '
        'cbMultipleExclamationMarks
        '
        Me.cbMultipleExclamationMarks.AutoSize = True
        Me.cbMultipleExclamationMarks.Location = New System.Drawing.Point(238, 305)
        Me.cbMultipleExclamationMarks.Name = "cbMultipleExclamationMarks"
        Me.cbMultipleExclamationMarks.Size = New System.Drawing.Size(108, 17)
        Me.cbMultipleExclamationMarks.TabIndex = 59
        Me.cbMultipleExclamationMarks.Tag = "MultipleExclamationMarks"
        Me.cbMultipleExclamationMarks.Text = "Mult. ""!"" Count"
        Me.cbMultipleExclamationMarks.UseVisualStyleBackColor = True
        '
        'cbAlphaOnly
        '
        Me.cbAlphaOnly.AutoSize = True
        Me.cbAlphaOnly.Location = New System.Drawing.Point(15, 397)
        Me.cbAlphaOnly.Name = "cbAlphaOnly"
        Me.cbAlphaOnly.Size = New System.Drawing.Size(86, 17)
        Me.cbAlphaOnly.TabIndex = 61
        Me.cbAlphaOnly.Tag = "AlphaOnly"
        Me.cbAlphaOnly.Text = "Alpha Only"
        Me.cbAlphaOnly.UseVisualStyleBackColor = True
        '
        'cbAlphaChars
        '
        Me.cbAlphaChars.AutoSize = True
        Me.cbAlphaChars.Location = New System.Drawing.Point(15, 374)
        Me.cbAlphaChars.Name = "cbAlphaChars"
        Me.cbAlphaChars.Size = New System.Drawing.Size(129, 17)
        Me.cbAlphaChars.TabIndex = 39
        Me.cbAlphaChars.Tag = "AlphaChars"
        Me.cbAlphaChars.Text = "Alpha Chars Count"
        Me.cbAlphaChars.UseVisualStyleBackColor = True
        '
        'cbMultipleQuestionMarks
        '
        Me.cbMultipleQuestionMarks.AutoSize = True
        Me.cbMultipleQuestionMarks.Location = New System.Drawing.Point(238, 282)
        Me.cbMultipleQuestionMarks.Name = "cbMultipleQuestionMarks"
        Me.cbMultipleQuestionMarks.Size = New System.Drawing.Size(114, 17)
        Me.cbMultipleQuestionMarks.TabIndex = 58
        Me.cbMultipleQuestionMarks.Tag = "MultipleQuestionMarks"
        Me.cbMultipleQuestionMarks.Text = "Multi. ""?"" Count"
        Me.cbMultipleQuestionMarks.UseVisualStyleBackColor = True
        '
        'cbSpecialChars
        '
        Me.cbSpecialChars.AutoSize = True
        Me.cbSpecialChars.Location = New System.Drawing.Point(15, 351)
        Me.cbSpecialChars.Name = "cbSpecialChars"
        Me.cbSpecialChars.Size = New System.Drawing.Size(137, 17)
        Me.cbSpecialChars.TabIndex = 38
        Me.cbSpecialChars.Tag = "SpecialChars"
        Me.cbSpecialChars.Text = "Special Chars Count"
        Me.cbSpecialChars.UseVisualStyleBackColor = True
        '
        'cbWordsMaxChar
        '
        Me.cbWordsMaxChar.AutoSize = True
        Me.cbWordsMaxChar.Location = New System.Drawing.Point(15, 190)
        Me.cbWordsMaxChar.Name = "cbWordsMaxChar"
        Me.cbWordsMaxChar.Size = New System.Drawing.Size(125, 17)
        Me.cbWordsMaxChar.TabIndex = 63
        Me.cbWordsMaxChar.Tag = "WordsMaxChar"
        Me.cbWordsMaxChar.Text = "Max Word Length"
        Me.cbWordsMaxChar.UseVisualStyleBackColor = True
        '
        'cbCountDigitChars
        '
        Me.cbCountDigitChars.AutoSize = True
        Me.cbCountDigitChars.Location = New System.Drawing.Point(15, 328)
        Me.cbCountDigitChars.Name = "cbCountDigitChars"
        Me.cbCountDigitChars.Size = New System.Drawing.Size(123, 17)
        Me.cbCountDigitChars.TabIndex = 37
        Me.cbCountDigitChars.Tag = "CountDigitChars"
        Me.cbCountDigitChars.Text = "Digit Chars Count"
        Me.cbCountDigitChars.UseVisualStyleBackColor = True
        '
        'cbWordsAVGChar
        '
        Me.cbWordsAVGChar.AutoSize = True
        Me.cbWordsAVGChar.Location = New System.Drawing.Point(15, 213)
        Me.cbWordsAVGChar.Name = "cbWordsAVGChar"
        Me.cbWordsAVGChar.Size = New System.Drawing.Size(127, 17)
        Me.cbWordsAVGChar.TabIndex = 34
        Me.cbWordsAVGChar.Tag = "WordsAVGChar"
        Me.cbWordsAVGChar.Text = "AVG. Word Length"
        Me.cbWordsAVGChar.UseVisualStyleBackColor = True
        '
        'cbCountWordLess3Char
        '
        Me.cbCountWordLess3Char.AutoSize = True
        Me.cbCountWordLess3Char.Location = New System.Drawing.Point(15, 259)
        Me.cbCountWordLess3Char.Name = "cbCountWordLess3Char"
        Me.cbCountWordLess3Char.Size = New System.Drawing.Size(140, 17)
        Me.cbCountWordLess3Char.TabIndex = 32
        Me.cbCountWordLess3Char.Tag = "CountWordLess3Char"
        Me.cbCountWordLess3Char.Text = "Words 3 char or less"
        Me.cbCountWordLess3Char.UseVisualStyleBackColor = True
        '
        'cbCountChars
        '
        Me.cbCountChars.AutoSize = True
        Me.cbCountChars.Location = New System.Drawing.Point(15, 305)
        Me.cbCountChars.Name = "cbCountChars"
        Me.cbCountChars.Size = New System.Drawing.Size(94, 17)
        Me.cbCountChars.TabIndex = 35
        Me.cbCountChars.Tag = "CountChars"
        Me.cbCountChars.Text = "Chars Count"
        Me.cbCountChars.UseVisualStyleBackColor = True
        '
        'cbCountWordLonger6Char
        '
        Me.cbCountWordLonger6Char.AutoSize = True
        Me.cbCountWordLonger6Char.Location = New System.Drawing.Point(15, 282)
        Me.cbCountWordLonger6Char.Name = "cbCountWordLonger6Char"
        Me.cbCountWordLonger6Char.Size = New System.Drawing.Size(142, 17)
        Me.cbCountWordLonger6Char.TabIndex = 33
        Me.cbCountWordLonger6Char.Tag = "CountWordLonger6Char"
        Me.cbCountWordLonger6Char.Text = "Words Longer 6 char"
        Me.cbCountWordLonger6Char.UseVisualStyleBackColor = True
        '
        'cbAlphaNumeric
        '
        Me.cbAlphaNumeric.AutoSize = True
        Me.cbAlphaNumeric.Location = New System.Drawing.Point(15, 420)
        Me.cbAlphaNumeric.Name = "cbAlphaNumeric"
        Me.cbAlphaNumeric.Size = New System.Drawing.Size(109, 17)
        Me.cbAlphaNumeric.TabIndex = 4
        Me.cbAlphaNumeric.Tag = "AlphaNumeric"
        Me.cbAlphaNumeric.Text = "Alpha-Numeric"
        Me.cbAlphaNumeric.UseVisualStyleBackColor = True
        '
        'TabAttachments
        '
        Me.TabAttachments.Controls.Add(Me.GroupBoxAttachmentFeatures)
        Me.TabAttachments.Location = New System.Drawing.Point(4, 22)
        Me.TabAttachments.Name = "TabAttachments"
        Me.TabAttachments.Size = New System.Drawing.Size(1481, 596)
        Me.TabAttachments.TabIndex = 2
        Me.TabAttachments.Text = "Attachments Features"
        Me.TabAttachments.UseVisualStyleBackColor = True
        '
        'GroupBoxAttachmentFeatures
        '
        Me.GroupBoxAttachmentFeatures.Controls.Add(Me.CheckBox1)
        Me.GroupBoxAttachmentFeatures.Controls.Add(Me.cbAttachmentFeatures)
        Me.GroupBoxAttachmentFeatures.Controls.Add(Me.cbCountOfAttachments)
        Me.GroupBoxAttachmentFeatures.Location = New System.Drawing.Point(9, 12)
        Me.GroupBoxAttachmentFeatures.Name = "GroupBoxAttachmentFeatures"
        Me.GroupBoxAttachmentFeatures.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.GroupBoxAttachmentFeatures.Size = New System.Drawing.Size(378, 85)
        Me.GroupBoxAttachmentFeatures.TabIndex = 105
        Me.GroupBoxAttachmentFeatures.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(15, 45)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(218, 17)
        Me.CheckBox1.TabIndex = 97
        Me.CheckBox1.Tag = "UniqueContentTypesAttachment"
        Me.CheckBox1.Text = "UniqueContent Types Attachment"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cbAttachmentFeatures
        '
        Me.cbAttachmentFeatures.AutoSize = True
        Me.cbAttachmentFeatures.BackColor = System.Drawing.Color.White
        Me.cbAttachmentFeatures.Location = New System.Drawing.Point(0, 0)
        Me.cbAttachmentFeatures.Name = "cbAttachmentFeatures"
        Me.cbAttachmentFeatures.Size = New System.Drawing.Size(147, 17)
        Me.cbAttachmentFeatures.TabIndex = 10
        Me.cbAttachmentFeatures.Tag = "0"
        Me.cbAttachmentFeatures.Text = "Attachment Features"
        Me.cbAttachmentFeatures.UseVisualStyleBackColor = False
        '
        'cbCountOfAttachments
        '
        Me.cbCountOfAttachments.AutoSize = True
        Me.cbCountOfAttachments.Location = New System.Drawing.Point(15, 21)
        Me.cbCountOfAttachments.Name = "cbCountOfAttachments"
        Me.cbCountOfAttachments.Size = New System.Drawing.Size(151, 17)
        Me.cbCountOfAttachments.TabIndex = 96
        Me.cbCountOfAttachments.Tag = "CountOfAttachments"
        Me.cbCountOfAttachments.Text = "Count Of Attachments"
        Me.cbCountOfAttachments.UseVisualStyleBackColor = True
        '
        'cbAllFeatures
        '
        Me.cbAllFeatures.AutoSize = True
        Me.cbAllFeatures.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cbAllFeatures.Location = New System.Drawing.Point(0, 0)
        Me.cbAllFeatures.Name = "cbAllFeatures"
        Me.cbAllFeatures.Size = New System.Drawing.Size(93, 17)
        Me.cbAllFeatures.TabIndex = 10
        Me.cbAllFeatures.Tag = "0"
        Me.cbAllFeatures.Text = "All Features"
        Me.cbAllFeatures.UseVisualStyleBackColor = True
        '
        'frmDefault
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1524, 771)
        Me.Controls.Add(Me.GroupBoxFeatures)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStripMain)
        Me.Controls.Add(Me.btnSourceBrowse)
        Me.Controls.Add(Me.txtSourceFolder)
        Me.Controls.Add(Me.btnDoExtract)
        Me.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.MaximizeBox = False
        Me.Name = "frmDefault"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email Features Extarctions"
        Me.StatusStripMain.ResumeLayout(False)
        Me.StatusStripMain.PerformLayout()
        Me.GroupBoxFeatures.ResumeLayout(False)
        Me.GroupBoxFeatures.PerformLayout()
        Me.TabMain.ResumeLayout(False)
        Me.TabHeader.ResumeLayout(False)
        Me.GroupBoxSubjectFeatures.ResumeLayout(False)
        Me.GroupBoxSubjectFeatures.PerformLayout()
        Me.GroupBoxHeaderFeatures.ResumeLayout(False)
        Me.GroupBoxHeaderFeatures.PerformLayout()
        Me.TabPayload.ResumeLayout(False)
        Me.GroupBoxLexicalDiversity.ResumeLayout(False)
        Me.GroupBoxLexicalDiversity.PerformLayout()
        Me.GroupBoxReadabilityFeatures.ResumeLayout(False)
        Me.GroupBoxReadabilityFeatures.PerformLayout()
        Me.GroupBoxPayloadFeatures.ResumeLayout(False)
        Me.GroupBoxPayloadFeatures.PerformLayout()
        Me.TabAttachments.ResumeLayout(False)
        Me.GroupBoxAttachmentFeatures.ResumeLayout(False)
        Me.GroupBoxAttachmentFeatures.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDoExtract As Button
    Friend WithEvents BackgroundWorkerFile As System.ComponentModel.BackgroundWorker
    Friend WithEvents FolderBrowserDialogSource As FolderBrowserDialog
    Friend WithEvents txtSourceFolder As TextBox
    Friend WithEvents btnSourceBrowse As Button
    Friend WithEvents StatusStripMain As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents ProgressBarStatus As ToolStripProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBoxFeatures As GroupBox
    Friend WithEvents cbAllFeatures As CheckBox
    Friend WithEvents TabMain As TabControl
    Friend WithEvents TabHeader As TabPage
    Friend WithEvents GroupBoxHeaderFeatures As GroupBox
    Friend WithEvents cbMultipartMixedUnique As CheckBox
    Friend WithEvents cbMultipartAlternativeUnique As CheckBox
    Friend WithEvents cbTextPlainUnique As CheckBox
    Friend WithEvents cbX_Mailman_Version As CheckBox
    Friend WithEvents cbHeaderFeatures As CheckBox
    Friend WithEvents cbYear As CheckBox
    Friend WithEvents cbMonth As CheckBox
    Friend WithEvents cbCountOfTo As CheckBox
    Friend WithEvents cbDay As CheckBox
    Friend WithEvents cbHour As CheckBox
    Friend WithEvents cbMinute As CheckBox
    Friend WithEvents cbSecond As CheckBox
    Friend WithEvents cbGoogle As CheckBox
    Friend WithEvents CbAOL As CheckBox
    Friend WithEvents cbGOV As CheckBox
    Friend WithEvents cbHotmail As CheckBox
    Friend WithEvents cbMIL As CheckBox
    Friend WithEvents cbYahoo As CheckBox
    Friend WithEvents cbExample As CheckBox
    Friend WithEvents cbReplayGoogle As CheckBox
    Friend WithEvents cbReplayHotmail As CheckBox
    Friend WithEvents cbReplayMIL As CheckBox
    Friend WithEvents cbReplayYahoo As CheckBox
    Friend WithEvents cbToGoogle As CheckBox
    Friend WithEvents cbToAOL As CheckBox
    Friend WithEvents cbToGOV As CheckBox
    Friend WithEvents cbToHotmail As CheckBox
    Friend WithEvents cbToMIL As CheckBox
    Friend WithEvents cbToYahoo As CheckBox
    Friend WithEvents cbToExample As CheckBox
    Friend WithEvents cbToMSN As CheckBox
    Friend WithEvents cbToLocalhost As CheckBox
    Friend WithEvents cbReplayAOL As CheckBox
    Friend WithEvents cbReplayGOV As CheckBox
    Friend WithEvents GroupBoxSubjectFeatures As GroupBox
    Friend WithEvents cbMaxLongestRepeatingCharacterSubject As CheckBox
    Friend WithEvents cbMinCharacterDiversitySubject As CheckBox
    Friend WithEvents cbRatioNonAlphaNumToAllSubject As CheckBox
    Friend WithEvents cbRatioDigitToAllSubject As CheckBox
    Friend WithEvents cbRatioUpperToAllSubject As CheckBox
    Friend WithEvents cbRatioUpperLowerSubject As CheckBox
    Friend WithEvents cbSubjectFeatures As CheckBox
    Friend WithEvents cbCountCharsSubject As CheckBox
    Friend WithEvents cbAllCountCapWordSubject As CheckBox
    Friend WithEvents cbCountCapWordSubject As CheckBox
    Friend WithEvents cbAllCountDigitWordSubject As CheckBox
    Friend WithEvents cbSingleCharWordsSubject As CheckBox
    Friend WithEvents cbWordsMaxCharSubject As CheckBox
    Friend WithEvents cbAlphaOnlySubject As CheckBox
    Friend WithEvents cbSingleDigitWordsSubject As CheckBox
    Friend WithEvents cbAlphaNumericSubject As CheckBox
    Friend WithEvents SingleLetterWordsSubject As CheckBox
    Friend WithEvents TabPayload As TabPage
    Friend WithEvents GroupBoxLexicalDiversity As GroupBox
    Friend WithEvents cbLexicalDiversity As CheckBox
    Friend WithEvents cbVocabularyRichness As CheckBox
    Friend WithEvents cblegomena As CheckBox
    Friend WithEvents cbDislegomena As CheckBox
    Friend WithEvents cbYuleK As CheckBox
    Friend WithEvents cbEntropy As CheckBox
    Friend WithEvents cbSichel As CheckBox
    Friend WithEvents cbHonore As CheckBox
    Friend WithEvents GroupBoxReadabilityFeatures As GroupBox
    Friend WithEvents cbInverseFI_WithoutStopwords As CheckBox
    Friend WithEvents cbFISimpleWithoutStopwords As CheckBox
    Friend WithEvents cbFKRI_WithoutStopwords As CheckBox
    Friend WithEvents cbFORCAST_WithoutStopwords As CheckBox
    Friend WithEvents cbSMOG_WithoutStopWords As CheckBox
    Friend WithEvents cbFRESWithoutStopwords As CheckBox
    Friend WithEvents cbFogIndexWithoutStopWords As CheckBox
    Friend WithEvents cbReadabilityFeatures As CheckBox
    Friend WithEvents cbFogIndex As CheckBox
    Friend WithEvents cbFRES As CheckBox
    Friend WithEvents cbSMOGI As CheckBox
    Friend WithEvents cbFORCAST As CheckBox
    Friend WithEvents cbFISimple As CheckBox
    Friend WithEvents cbInverseFI As CheckBox
    Friend WithEvents cbSMOG As CheckBox
    Friend WithEvents cbFKRI As CheckBox
    Friend WithEvents cbARI As CheckBox
    Friend WithEvents cbCLI As CheckBox
    Friend WithEvents GroupBoxPayloadFeatures As GroupBox
    Friend WithEvents cbWordLengthWithoutStopwords As CheckBox
    Friend WithEvents cbComplexWordsWithoutStopwords As CheckBox
    Friend WithEvents cbSimpleWordsWithoutStopwords As CheckBox
    Friend WithEvents cbTFISFWithoutStopwords As CheckBox
    Friend WithEvents cbMaxLongestRepeatingCharacter As CheckBox
    Friend WithEvents cbMinCharacterDiversity As CheckBox
    Friend WithEvents cbUniqueHTMLAnchor As CheckBox
    Friend WithEvents cbRatioNonAlphaNumToAll As CheckBox
    Friend WithEvents cbRatioDigitToAll As CheckBox
    Friend WithEvents cbRatioUpperToAll As CheckBox
    Friend WithEvents cbRatioUpperLower As CheckBox
    Friend WithEvents cbAvgWordsinSentences As CheckBox
    Friend WithEvents cbAvgCharinParagraphs As CheckBox
    Friend WithEvents cbAvgWordsinParagraphs As CheckBox
    Friend WithEvents cbAvgSentenceinParagraphs As CheckBox
    Friend WithEvents cbCountofParagraphs As CheckBox
    Friend WithEvents cbPayloadFeatures As CheckBox
    Friend WithEvents cbSpamWords As CheckBox
    Friend WithEvents cbFunctionWords As CheckBox
    Friend WithEvents cbHTMLAnchor As CheckBox
    Friend WithEvents cbHTMLNotAnchor As CheckBox
    Friend WithEvents cbHTMLImage As CheckBox
    Friend WithEvents cbLongestCapital As CheckBox
    Friend WithEvents cbCountCapWord As CheckBox
    Friend WithEvents cbSenBegLower As CheckBox
    Friend WithEvents cbCountLines As CheckBox
    Friend WithEvents cbSenBegUpper As CheckBox
    Friend WithEvents cbAllCountDigitWord As CheckBox
    Friend WithEvents cbCountSentence As CheckBox
    Friend WithEvents cbSingleCharWords As CheckBox
    Friend WithEvents cbHTMLTags As CheckBox
    Friend WithEvents cbWordLength As CheckBox
    Friend WithEvents cbDuplicateWords As CheckBox
    Friend WithEvents cbCountLowerChars As CheckBox
    Friend WithEvents cbTFISF As CheckBox
    Friend WithEvents cbSingleDigitWords As CheckBox
    Friend WithEvents cbAllCountCapWord As CheckBox
    Friend WithEvents cbQuestionMark As CheckBox
    Friend WithEvents cbSingleLetterWords As CheckBox
    Friend WithEvents cbComplexWords As CheckBox
    Friend WithEvents cbExclamationMark As CheckBox
    Friend WithEvents cbSimpleWords As CheckBox
    Friend WithEvents cbCountUpperChars As CheckBox
    Friend WithEvents cbComma As CheckBox
    Friend WithEvents cbCountWord As CheckBox
    Friend WithEvents cbSemiColon As CheckBox
    Friend WithEvents cbColon As CheckBox
    Friend WithEvents cbSingleQuote As CheckBox
    Friend WithEvents cbPeriod As CheckBox
    Friend WithEvents cbSpace As CheckBox
    Friend WithEvents cbTab As CheckBox
    Friend WithEvents cbDollar As CheckBox
    Friend WithEvents cbEllipsis As CheckBox
    Friend WithEvents cbWordsMinChar As CheckBox
    Friend WithEvents cbMultipleExclamationMarks As CheckBox
    Friend WithEvents cbAlphaOnly As CheckBox
    Friend WithEvents cbAlphaChars As CheckBox
    Friend WithEvents cbMultipleQuestionMarks As CheckBox
    Friend WithEvents cbSpecialChars As CheckBox
    Friend WithEvents cbWordsMaxChar As CheckBox
    Friend WithEvents cbCountDigitChars As CheckBox
    Friend WithEvents cbWordsAVGChar As CheckBox
    Friend WithEvents cbCountWordLess3Char As CheckBox
    Friend WithEvents cbCountChars As CheckBox
    Friend WithEvents cbCountWordLonger6Char As CheckBox
    Friend WithEvents cbAlphaNumeric As CheckBox
    Friend WithEvents TabAttachments As TabPage
    Friend WithEvents GroupBoxAttachmentFeatures As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cbAttachmentFeatures As CheckBox
    Friend WithEvents cbCountOfAttachments As CheckBox
End Class
