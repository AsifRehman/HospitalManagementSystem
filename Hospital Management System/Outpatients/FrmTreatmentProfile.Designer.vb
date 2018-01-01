<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTreatmentProfile
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtproc = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtpres = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtdiag = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtinvs = New System.Windows.Forms.TextBox
        Me.txthistory = New System.Windows.Forms.TextBox
        Me.txtcomplains = New System.Windows.Forms.TextBox
        Me.dgProcedure = New System.Windows.Forms.DataGridView
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.dgTreat = New System.Windows.Forms.DataGridView
        Me.Label13 = New System.Windows.Forms.Label
        Me.dgw = New System.Windows.Forms.DataGridView
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblVno = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtpname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPno = New System.Windows.Forms.TextBox
        Me.txtage = New System.Windows.Forms.TextBox
        Me.txttel = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtgender = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgProcedure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dgTreat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.dgProcedure)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 475)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtproc)
        Me.GroupBox3.Location = New System.Drawing.Point(163, 366)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(703, 100)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Patient Procedures Done"
        '
        'txtproc
        '
        Me.txtproc.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproc.Location = New System.Drawing.Point(9, 19)
        Me.txtproc.Multiline = True
        Me.txtproc.Name = "txtproc"
        Me.txtproc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtproc.Size = New System.Drawing.Size(685, 73)
        Me.txtproc.TabIndex = 21
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtpres)
        Me.GroupBox2.Location = New System.Drawing.Point(162, 260)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(703, 100)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient Prescription"
        '
        'txtpres
        '
        Me.txtpres.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpres.Location = New System.Drawing.Point(9, 19)
        Me.txtpres.Multiline = True
        Me.txtpres.Name = "txtpres"
        Me.txtpres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtpres.Size = New System.Drawing.Size(685, 73)
        Me.txtpres.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtdiag)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtinvs)
        Me.GroupBox1.Controls.Add(Me.txthistory)
        Me.GroupBox1.Controls.Add(Me.txtcomplains)
        Me.GroupBox1.Location = New System.Drawing.Point(162, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(703, 192)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Treatment Profile"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(97, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Laboratory Investigation"
        '
        'txtdiag
        '
        Me.txtdiag.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiag.Location = New System.Drawing.Point(357, 128)
        Me.txtdiag.Multiline = True
        Me.txtdiag.Name = "txtdiag"
        Me.txtdiag.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdiag.Size = New System.Drawing.Size(337, 58)
        Me.txtdiag.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(467, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Diagnosis"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(440, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "History of Presenting Illness"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Chief Complains"
        '
        'txtinvs
        '
        Me.txtinvs.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvs.Location = New System.Drawing.Point(9, 128)
        Me.txtinvs.Multiline = True
        Me.txtinvs.Name = "txtinvs"
        Me.txtinvs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtinvs.Size = New System.Drawing.Size(337, 58)
        Me.txtinvs.TabIndex = 22
        '
        'txthistory
        '
        Me.txthistory.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthistory.Location = New System.Drawing.Point(357, 30)
        Me.txthistory.Multiline = True
        Me.txthistory.Name = "txthistory"
        Me.txthistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txthistory.Size = New System.Drawing.Size(337, 73)
        Me.txthistory.TabIndex = 21
        '
        'txtcomplains
        '
        Me.txtcomplains.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomplains.Location = New System.Drawing.Point(9, 30)
        Me.txtcomplains.Multiline = True
        Me.txtcomplains.Name = "txtcomplains"
        Me.txtcomplains.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtcomplains.Size = New System.Drawing.Size(337, 73)
        Me.txtcomplains.TabIndex = 20
        '
        'dgProcedure
        '
        Me.dgProcedure.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgProcedure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProcedure.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgProcedure.Location = New System.Drawing.Point(9, 372)
        Me.dgProcedure.Name = "dgProcedure"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgProcedure.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgProcedure.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgProcedure.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProcedure.Size = New System.Drawing.Size(146, 91)
        Me.dgProcedure.TabIndex = 40
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.dgTreat)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.dgw)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.lblVno)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(4, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(155, 408)
        Me.Panel3.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(33, 294)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "View Procedure"
        '
        'dgTreat
        '
        Me.dgTreat.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgTreat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTreat.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgTreat.Location = New System.Drawing.Point(7, 198)
        Me.dgTreat.Name = "dgTreat"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.dgTreat.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgTreat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgTreat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTreat.Size = New System.Drawing.Size(144, 92)
        Me.dgTreat.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "View Prescription"
        '
        'dgw
        '
        Me.dgw.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgw.Location = New System.Drawing.Point(7, 58)
        Me.dgw.Name = "dgw"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(144, 117)
        Me.dgw.StandardTab = True
        Me.dgw.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "View Treatment Profile"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 10)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "==========================="
        '
        'lblVno
        '
        Me.lblVno.AutoSize = True
        Me.lblVno.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVno.ForeColor = System.Drawing.Color.Red
        Me.lblVno.Location = New System.Drawing.Point(89, 14)
        Me.lblVno.Name = "lblVno"
        Me.lblVno.Size = New System.Drawing.Size(16, 19)
        Me.lblVno.TabIndex = 31
        Me.lblVno.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(9, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Total Visits:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.txtpname)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtPno)
        Me.Panel2.Controls.Add(Me.txtage)
        Me.Panel2.Controls.Add(Me.txttel)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtgender)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(874, 61)
        Me.Panel2.TabIndex = 9
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Image = Global.Hospital_Management_System.My.Resources.Resources.refresh1
        Me.LinkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel1.Location = New System.Drawing.Point(747, 33)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(109, 19)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Refresh Form"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.Hospital_Management_System.My.Resources.Resources.search
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(126, 30)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(73, 26)
        Me.btnSearch.TabIndex = 27
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtpname
        '
        Me.txtpname.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpname.Location = New System.Drawing.Point(205, 31)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(210, 25)
        Me.txtpname.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(215, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Patient Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(437, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Age"
        '
        'txtPno
        '
        Me.txtPno.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPno.Location = New System.Drawing.Point(6, 31)
        Me.txtPno.Name = "txtPno"
        Me.txtPno.Size = New System.Drawing.Size(113, 25)
        Me.txtPno.TabIndex = 26
        '
        'txtage
        '
        Me.txtage.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(425, 31)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(68, 25)
        Me.txtage.TabIndex = 17
        '
        'txttel
        '
        Me.txttel.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttel.Location = New System.Drawing.Point(594, 31)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(147, 25)
        Me.txttel.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Patient No:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(510, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(602, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Telephone"
        '
        'txtgender
        '
        Me.txtgender.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgender.Location = New System.Drawing.Point(504, 31)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(84, 25)
        Me.txtgender.TabIndex = 21
        '
        'FrmTreatmentProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 475)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmTreatmentProfile"
        Me.Text = "FrmTreatmentProfile"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgProcedure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgTreat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPno As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txttel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtgender As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblVno As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents dgTreat As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtdiag As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtinvs As System.Windows.Forms.TextBox
    Friend WithEvents txthistory As System.Windows.Forms.TextBox
    Friend WithEvents txtcomplains As System.Windows.Forms.TextBox
    Friend WithEvents dgProcedure As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtproc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpres As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
