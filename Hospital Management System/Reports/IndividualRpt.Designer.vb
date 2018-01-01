<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndividualRpt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.cmdprint = New System.Windows.Forms.Button
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.lbluser = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dgw = New System.Windows.Forms.DataGridView
        Me.MedName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label52 = New System.Windows.Forms.Label
        Me.lblres = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.lblsex = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.lblages = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.lbltell = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.lblImpress = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.lblExam = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.lblHistory = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.lblComplains = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.lblpatNo = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.lblpname = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdprint
        '
        Me.cmdprint.BackColor = System.Drawing.Color.Yellow
        Me.cmdprint.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.Location = New System.Drawing.Point(207, 714)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(98, 28)
        Me.cmdprint.TabIndex = 7
        Me.cmdprint.Text = "Print"
        Me.cmdprint.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.dgw)
        Me.Panel1.Controls.Add(Me.Label52)
        Me.Panel1.Controls.Add(Me.lblres)
        Me.Panel1.Controls.Add(Me.Label51)
        Me.Panel1.Controls.Add(Me.lblsex)
        Me.Panel1.Controls.Add(Me.Label50)
        Me.Panel1.Controls.Add(Me.lblages)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.lbltell)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.Label32)
        Me.Panel1.Controls.Add(Me.lblImpress)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.lblExam)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.lblHistory)
        Me.Panel1.Controls.Add(Me.Label38)
        Me.Panel1.Controls.Add(Me.Label39)
        Me.Panel1.Controls.Add(Me.lblComplains)
        Me.Panel1.Controls.Add(Me.Label41)
        Me.Panel1.Controls.Add(Me.lblpatNo)
        Me.Panel1.Controls.Add(Me.Label43)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblpname)
        Me.Panel1.Controls.Add(Me.Label47)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 707)
        Me.Panel1.TabIndex = 75
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(191, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 18)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Telephone: 0721972153"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.lbluser)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Location = New System.Drawing.Point(3, 597)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(558, 107)
        Me.Panel3.TabIndex = 84
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(14, 81)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 13)
        Me.Label18.TabIndex = 88
        Me.Label18.Text = "Stamp Here"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(307, 81)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(248, 13)
        Me.Label19.TabIndex = 87
        Me.Label19.Text = "Dr's Signature: ..................................."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(177, 13)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(172, 14)
        Me.Label23.TabIndex = 86
        Me.Label23.Text = """Your Health, Our Concern"""
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(285, 40)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(36, 14)
        Me.lbluser.TabIndex = 85
        Me.lbluser.Text = "user"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(201, 40)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 14)
        Me.Label26.TabIndex = 84
        Me.Label26.Text = "Served By:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(178, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 18)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "P.O. Box 10796-00200, Nairobi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(191, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 18)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Prince Alvin Medical Centre"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        Me.dgw.AllowUserToResizeColumns = False
        Me.dgw.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgw.ColumnHeadersHeight = 18
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedName})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.White
        Me.dgw.Location = New System.Drawing.Point(56, 501)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw.Size = New System.Drawing.Size(495, 78)
        Me.dgw.TabIndex = 83
        '
        'MedName
        '
        Me.MedName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.MedName.HeaderText = "Prescribed Drugs"
        Me.MedName.Name = "MedName"
        Me.MedName.ReadOnly = True
        Me.MedName.Width = 500
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(234, 151)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(76, 14)
        Me.Label52.TabIndex = 82
        Me.Label52.Text = "Residence:"
        '
        'lblres
        '
        Me.lblres.AutoSize = True
        Me.lblres.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblres.Location = New System.Drawing.Point(313, 151)
        Me.lblres.Name = "lblres"
        Me.lblres.Size = New System.Drawing.Size(15, 14)
        Me.lblres.TabIndex = 81
        Me.lblres.Text = "6"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(126, 151)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(35, 14)
        Me.Label51.TabIndex = 80
        Me.Label51.Text = "Sex:"
        '
        'lblsex
        '
        Me.lblsex.AutoSize = True
        Me.lblsex.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsex.Location = New System.Drawing.Point(167, 151)
        Me.lblsex.Name = "lblsex"
        Me.lblsex.Size = New System.Drawing.Size(15, 14)
        Me.lblsex.TabIndex = 79
        Me.lblsex.Text = "6"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(17, 151)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(36, 14)
        Me.Label50.TabIndex = 78
        Me.Label50.Text = "Age:"
        '
        'lblages
        '
        Me.lblages.AutoSize = True
        Me.lblages.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblages.Location = New System.Drawing.Point(76, 151)
        Me.lblages.Name = "lblages"
        Me.lblages.Size = New System.Drawing.Size(15, 14)
        Me.lblages.TabIndex = 77
        Me.lblages.Text = "6"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(-3, 115)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(592, 13)
        Me.Label21.TabIndex = 74
        Me.Label21.Text = "---------------------------------------------------------------------------------" & _
            "------------------------------------"
        '
        'lbltell
        '
        Me.lbltell.AutoSize = True
        Me.lbltell.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltell.Location = New System.Drawing.Point(460, 128)
        Me.lbltell.Name = "lbltell"
        Me.lbltell.Size = New System.Drawing.Size(45, 14)
        Me.lbltell.TabIndex = 73
        Me.lbltell.Text = "Tel No"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(385, 128)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(77, 14)
        Me.Label22.TabIndex = 72
        Me.Label22.Text = "Mobile No :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(10, 165)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(542, 13)
        Me.Label28.TabIndex = 63
        Me.Label28.Text = "---------------------------------------------------------------------------------" & _
            "--------------------------"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(53, 485)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(82, 13)
        Me.Label32.TabIndex = 60
        Me.Label32.Text = "Treatments"
        '
        'lblImpress
        '
        Me.lblImpress.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpress.Location = New System.Drawing.Point(42, 421)
        Me.lblImpress.Name = "lblImpress"
        Me.lblImpress.Size = New System.Drawing.Size(509, 64)
        Me.lblImpress.TabIndex = 59
        Me.lblImpress.Text = "no"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(58, 408)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(70, 13)
        Me.Label34.TabIndex = 58
        Me.Label34.Text = "Diagnosis"
        '
        'lblExam
        '
        Me.lblExam.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExam.Location = New System.Drawing.Point(39, 347)
        Me.lblExam.Name = "lblExam"
        Me.lblExam.Size = New System.Drawing.Size(512, 61)
        Me.lblExam.TabIndex = 57
        Me.lblExam.Text = "no"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(55, 334)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(174, 13)
        Me.Label36.TabIndex = 56
        Me.Label36.Text = "Laboratory/Investigation"
        '
        'lblHistory
        '
        Me.lblHistory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistory.Location = New System.Drawing.Point(36, 259)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(515, 75)
        Me.lblHistory.TabIndex = 55
        Me.lblHistory.Text = "no"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(55, 246)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(167, 13)
        Me.Label38.TabIndex = 54
        Me.Label38.Text = "History and Examination"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(13, 128)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(78, 14)
        Me.Label39.TabIndex = 51
        Me.Label39.Text = "Patient No:"
        '
        'lblComplains
        '
        Me.lblComplains.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplains.Location = New System.Drawing.Point(36, 191)
        Me.lblComplains.Name = "lblComplains"
        Me.lblComplains.Size = New System.Drawing.Size(515, 55)
        Me.lblComplains.TabIndex = 50
        Me.lblComplains.Text = "no"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(55, 178)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(74, 13)
        Me.Label41.TabIndex = 49
        Me.Label41.Text = "Complains"
        '
        'lblpatNo
        '
        Me.lblpatNo.AutoSize = True
        Me.lblpatNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpatNo.Location = New System.Drawing.Point(97, 128)
        Me.lblpatNo.Name = "lblpatNo"
        Me.lblpatNo.Size = New System.Drawing.Size(15, 14)
        Me.lblpatNo.TabIndex = 48
        Me.lblpatNo.Text = "6"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(149, 98)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(233, 17)
        Me.Label43.TabIndex = 47
        Me.Label43.Text = "Consultation && Treatment Form"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(407, 77)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(118, 13)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(36, 77)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(121, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblpname
        '
        Me.lblpname.AutoSize = True
        Me.lblpname.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpname.Location = New System.Drawing.Point(270, 128)
        Me.lblpname.Name = "lblpname"
        Me.lblpname.Size = New System.Drawing.Size(50, 14)
        Me.lblpname.TabIndex = 1
        Me.lblpname.Text = "pname"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(165, 128)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(101, 14)
        Me.Label47.TabIndex = 1
        Me.Label47.Text = "Patient Name :"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'IndividualRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 745)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdprint)
        Me.Name = "IndividualRpt"
        Me.Text = "IndividualRpt"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdprint As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents lblres As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents lblsex As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents lblages As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lbltell As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lblImpress As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents lblExam As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblHistory As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents lblComplains As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents lblpatNo As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblpname As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents MedName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
