<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Outpatient_Billing
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblPyt = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label13 = New System.Windows.Forms.Label
        Me.dgw = New System.Windows.Forms.DataGridView
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblRecNO = New System.Windows.Forms.TextBox
        Me.txtpatno = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.lbltime = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDrCharges = New System.Windows.Forms.TextBox
        Me.btnsearch = New System.Windows.Forms.Button
        Me.txtpno = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtothers = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtlabcost = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtfp = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtdrugcost = New System.Windows.Forms.TextBox
        Me.txtTBill = New System.Windows.Forms.TextBox
        Me.txtpatname = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtbalance = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtpaid = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtimmune = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.lblPyt)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.dgw)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(914, 465)
        Me.Panel1.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(353, 203)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(666, 13)
        Me.Label18.TabIndex = 120
        Me.Label18.Text = "============================================Today Balances=======================" & _
            "=============================="
        '
        'lblPyt
        '
        Me.lblPyt.AutoSize = True
        Me.lblPyt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPyt.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPyt.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPyt.Location = New System.Drawing.Point(682, 3)
        Me.lblPyt.Name = "lblPyt"
        Me.lblPyt.Size = New System.Drawing.Size(28, 15)
        Me.lblPyt.TabIndex = 119
        Me.lblPyt.Text = "0.00"
        Me.lblPyt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 24
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(352, 219)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(558, 189)
        Me.DataGridView1.TabIndex = 118
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(349, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(562, 16)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "Today Payments:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgw.Location = New System.Drawing.Point(352, 20)
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.Size = New System.Drawing.Size(558, 178)
        Me.dgw.TabIndex = 99
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(5, 411)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(906, 53)
        Me.Panel3.TabIndex = 98
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Snow
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(351, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 28)
        Me.Button2.TabIndex = 77
        Me.Button2.Text = "&Update Patient's Balances "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Image = Global.Hospital_Management_System.My.Resources.Resources.print1
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(17, 13)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(123, 28)
        Me.btnsave.TabIndex = 73
        Me.btnsave.Text = "&Save && Print"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Snow
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Hospital_Management_System.My.Resources.Resources.close
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(818, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 28)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "&Close  "
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.txtimmune)
        Me.Panel2.Controls.Add(Me.lblRecNO)
        Me.Panel2.Controls.Add(Me.txtpatno)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.lbltime)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtDrCharges)
        Me.Panel2.Controls.Add(Me.btnsearch)
        Me.Panel2.Controls.Add(Me.txtpno)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtothers)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtlabcost)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtfp)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtdrugcost)
        Me.Panel2.Controls.Add(Me.txtTBill)
        Me.Panel2.Controls.Add(Me.txtpatname)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(344, 323)
        Me.Panel2.TabIndex = 97
        '
        'lblRecNO
        '
        Me.lblRecNO.Location = New System.Drawing.Point(105, 28)
        Me.lblRecNO.Name = "lblRecNO"
        Me.lblRecNO.Size = New System.Drawing.Size(105, 20)
        Me.lblRecNO.TabIndex = 125
        '
        'txtpatno
        '
        Me.txtpatno.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatno.Location = New System.Drawing.Point(288, 58)
        Me.txtpatno.Multiline = True
        Me.txtpatno.Name = "txtpatno"
        Me.txtpatno.Size = New System.Drawing.Size(53, 25)
        Me.txtpatno.TabIndex = 124
        Me.txtpatno.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 19)
        Me.Label14.TabIndex = 122
        Me.Label14.Text = "Receipt No:"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.Red
        Me.lbltime.Location = New System.Drawing.Point(257, 35)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(43, 15)
        Me.lbltime.TabIndex = 121
        Me.lbltime.Text = "Label15"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(218, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 19)
        Me.Label15.TabIndex = 120
        Me.Label15.Text = "Date:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(-41, 189)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(427, 13)
        Me.Label17.TabIndex = 119
        Me.Label17.Text = "======================================================================"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(-6, 116)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(427, 13)
        Me.Label16.TabIndex = 118
        Me.Label16.Text = "======================================================================"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Red
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(344, 16)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Search Patient Bills Using Patient Number"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDrCharges
        '
        Me.txtDrCharges.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrCharges.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtDrCharges.Location = New System.Drawing.Point(7, 160)
        Me.txtDrCharges.Name = "txtDrCharges"
        Me.txtDrCharges.Size = New System.Drawing.Size(112, 26)
        Me.txtDrCharges.TabIndex = 114
        Me.txtDrCharges.Text = "0"
        Me.txtDrCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnsearch
        '
        Me.btnsearch.AutoSize = True
        Me.btnsearch.BackColor = System.Drawing.Color.Snow
        Me.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Image = Global.Hospital_Management_System.My.Resources.Resources.search
        Me.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsearch.Location = New System.Drawing.Point(216, 58)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(66, 25)
        Me.btnsearch.TabIndex = 78
        Me.btnsearch.Text = "&Search"
        Me.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'txtpno
        '
        Me.txtpno.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpno.Location = New System.Drawing.Point(87, 58)
        Me.txtpno.Multiline = True
        Me.txtpno.Name = "txtpno"
        Me.txtpno.Size = New System.Drawing.Size(123, 25)
        Me.txtpno.TabIndex = 87
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 19)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "Consultation Fee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Patient No."
        '
        'txtothers
        '
        Me.txtothers.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtothers.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtothers.Location = New System.Drawing.Point(175, 226)
        Me.txtothers.Name = "txtothers"
        Me.txtothers.Size = New System.Drawing.Size(142, 26)
        Me.txtothers.TabIndex = 108
        Me.txtothers.Text = "0"
        Me.txtothers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(180, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 19)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Procedures"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Drug Total"
        '
        'txtlabcost
        '
        Me.txtlabcost.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlabcost.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtlabcost.Location = New System.Drawing.Point(19, 289)
        Me.txtlabcost.Name = "txtlabcost"
        Me.txtlabcost.Size = New System.Drawing.Size(134, 26)
        Me.txtlabcost.TabIndex = 105
        Me.txtlabcost.Text = "0"
        Me.txtlabcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 19)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Lab Charges"
        '
        'txtfp
        '
        Me.txtfp.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfp.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtfp.Location = New System.Drawing.Point(19, 226)
        Me.txtfp.Name = "txtfp"
        Me.txtfp.Size = New System.Drawing.Size(133, 26)
        Me.txtfp.TabIndex = 103
        Me.txtfp.Text = "0"
        Me.txtfp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Family Planning"
        '
        'txtdrugcost
        '
        Me.txtdrugcost.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrugcost.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtdrugcost.Location = New System.Drawing.Point(128, 160)
        Me.txtdrugcost.Name = "txtdrugcost"
        Me.txtdrugcost.Size = New System.Drawing.Size(82, 26)
        Me.txtdrugcost.TabIndex = 101
        Me.txtdrugcost.Text = "0"
        Me.txtdrugcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTBill
        '
        Me.txtTBill.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTBill.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtTBill.Location = New System.Drawing.Point(175, 289)
        Me.txtTBill.Name = "txtTBill"
        Me.txtTBill.Size = New System.Drawing.Size(142, 26)
        Me.txtTBill.TabIndex = 100
        Me.txtTBill.Text = "0"
        Me.txtTBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpatname
        '
        Me.txtpatname.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatname.Location = New System.Drawing.Point(87, 91)
        Me.txtpatname.Multiline = True
        Me.txtpatname.Name = "txtpatname"
        Me.txtpatname.Size = New System.Drawing.Size(230, 22)
        Me.txtpatname.TabIndex = 99
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(180, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 19)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Total Bill"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 19)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "FullNames"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.MediumAquamarine
        Me.GroupBox4.Controls.Add(Me.txtbalance)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtpaid)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txttotal)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(3, 329)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(344, 79)
        Me.GroupBox4.TabIndex = 92
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Payment Section"
        '
        'txtbalance
        '
        Me.txtbalance.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtbalance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbalance.ForeColor = System.Drawing.Color.Red
        Me.txtbalance.Location = New System.Drawing.Point(245, 38)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.Size = New System.Drawing.Size(93, 30)
        Me.txtbalance.TabIndex = 14
        Me.txtbalance.Text = "0"
        Me.txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(257, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Balance"
        '
        'txtpaid
        '
        Me.txtpaid.BackColor = System.Drawing.SystemColors.InfoText
        Me.txtpaid.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaid.ForeColor = System.Drawing.Color.Lime
        Me.txtpaid.Location = New System.Drawing.Point(118, 38)
        Me.txtpaid.Name = "txtpaid"
        Me.txtpaid.Size = New System.Drawing.Size(121, 30)
        Me.txtpaid.TabIndex = 12
        Me.txtpaid.Text = "0"
        Me.txtpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(122, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Cash Tendered"
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.SystemColors.InfoText
        Me.txttotal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.Red
        Me.txttotal.Location = New System.Drawing.Point(7, 38)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(101, 30)
        Me.txttotal.TabIndex = 10
        Me.txttotal.Text = "0"
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(26, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Total Bill"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(231, 138)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 19)
        Me.Label19.TabIndex = 127
        Me.Label19.Text = "Immunization"
        '
        'txtimmune
        '
        Me.txtimmune.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimmune.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtimmune.Location = New System.Drawing.Point(222, 160)
        Me.txtimmune.Name = "txtimmune"
        Me.txtimmune.Size = New System.Drawing.Size(105, 26)
        Me.txtimmune.TabIndex = 126
        Me.txtimmune.Text = "0"
        Me.txtimmune.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Outpatient_Billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(914, 465)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Outpatient_Billing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbalance As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtpaid As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtpno As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtDrCharges As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtothers As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtlabcost As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtfp As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdrugcost As System.Windows.Forms.TextBox
    Friend WithEvents txtTBill As System.Windows.Forms.TextBox
    Friend WithEvents txtpatname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblPyt As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtpatno As System.Windows.Forms.TextBox
    Friend WithEvents lblRecNO As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtimmune As System.Windows.Forms.TextBox
End Class
