<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFamplan
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.txtpno = New System.Windows.Forms.TextBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtpname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtage = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtcharges = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txttel = New System.Windows.Forms.TextBox
        Me.cboMethod = New System.Windows.Forms.ComboBox
        Me.txtpid = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtremarks = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdupdate = New System.Windows.Forms.Button
        Me.cmdnew = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdclose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtwight = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtbp = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.DtpReveiw = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox3.Controls.Add(Me.LinkLabel2)
        Me.GroupBox3.Controls.Add(Me.cmdsearch)
        Me.GroupBox3.Controls.Add(Me.txtpno)
        Me.GroupBox3.Controls.Add(Me.LinkLabel1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(843, 56)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search New Client Here By No."
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(663, 21)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(142, 19)
        Me.LinkLabel2.TabIndex = 6
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Click here for Revisits"
        '
        'cmdsearch
        '
        Me.cmdsearch.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.cmdsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdsearch.Image = Global.Hospital_Management_System.My.Resources.Resources.PrintPreview
        Me.cmdsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdsearch.Location = New System.Drawing.Point(428, 17)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(83, 30)
        Me.cmdsearch.TabIndex = 28
        Me.cmdsearch.Text = "Search"
        Me.cmdsearch.UseVisualStyleBackColor = False
        '
        'txtpno
        '
        Me.txtpno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpno.Location = New System.Drawing.Point(143, 17)
        Me.txtpno.Multiline = True
        Me.txtpno.Name = "txtpno"
        Me.txtpno.Size = New System.Drawing.Size(279, 30)
        Me.txtpno.TabIndex = 27
        Me.txtpno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Linen
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(545, 24)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(69, 14)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Reporting"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 65)
        Me.Panel1.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 19)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Remarks"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Name"
        '
        'txtpname
        '
        Me.txtpname.Location = New System.Drawing.Point(149, 30)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(234, 20)
        Me.txtpname.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(402, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 19)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Age"
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(395, 30)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(134, 20)
        Me.txtage.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(274, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Period"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 19)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Method"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(589, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 19)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Charges"
        '
        'txtcharges
        '
        Me.txtcharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcharges.ForeColor = System.Drawing.Color.Maroon
        Me.txtcharges.Location = New System.Drawing.Point(554, 151)
        Me.txtcharges.Multiline = True
        Me.txtcharges.Name = "txtcharges"
        Me.txtcharges.Size = New System.Drawing.Size(148, 30)
        Me.txtcharges.TabIndex = 60
        Me.txtcharges.Text = "0.00"
        Me.txtcharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(552, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Telephone:"
        '
        'txttel
        '
        Me.txttel.Location = New System.Drawing.Point(554, 31)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(148, 20)
        Me.txttel.TabIndex = 62
        '
        'cboMethod
        '
        Me.cboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMethod.FormattingEnabled = True
        Me.cboMethod.Location = New System.Drawing.Point(11, 77)
        Me.cboMethod.Name = "cboMethod"
        Me.cboMethod.Size = New System.Drawing.Size(124, 21)
        Me.cboMethod.TabIndex = 63
        '
        'txtpid
        '
        Me.txtpid.Location = New System.Drawing.Point(11, 30)
        Me.txtpid.Name = "txtpid"
        Me.txtpid.Size = New System.Drawing.Size(124, 20)
        Me.txtpid.TabIndex = 65
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 19)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Client No"
        '
        'txtremarks
        '
        Me.txtremarks.Location = New System.Drawing.Point(11, 123)
        Me.txtremarks.Multiline = True
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtremarks.Size = New System.Drawing.Size(518, 57)
        Me.txtremarks.TabIndex = 69
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.Controls.Add(Me.cmdupdate)
        Me.Panel3.Controls.Add(Me.cmdnew)
        Me.Panel3.Controls.Add(Me.cmdsave)
        Me.Panel3.Controls.Add(Me.cmdclose)
        Me.Panel3.Location = New System.Drawing.Point(728, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(132, 177)
        Me.Panel3.TabIndex = 70
        '
        'cmdupdate
        '
        Me.cmdupdate.BackColor = System.Drawing.Color.Honeydew
        Me.cmdupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdupdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdupdate.Image = Global.Hospital_Management_System.My.Resources.Resources.refresh
        Me.cmdupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdupdate.Location = New System.Drawing.Point(31, 96)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(77, 28)
        Me.cmdupdate.TabIndex = 5
        Me.cmdupdate.Text = "Update"
        Me.cmdupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdupdate.UseVisualStyleBackColor = False
        '
        'cmdnew
        '
        Me.cmdnew.BackColor = System.Drawing.Color.Honeydew
        Me.cmdnew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdnew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnew.Image = Global.Hospital_Management_System.My.Resources.Resources.add1
        Me.cmdnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdnew.Location = New System.Drawing.Point(31, 13)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(77, 28)
        Me.cmdnew.TabIndex = 0
        Me.cmdnew.Text = "New"
        Me.cmdnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdnew.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.Honeydew
        Me.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdsave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.Image = Global.Hospital_Management_System.My.Resources.Resources.save
        Me.cmdsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdsave.Location = New System.Drawing.Point(31, 58)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(77, 28)
        Me.cmdsave.TabIndex = 1
        Me.cmdsave.Text = "Save"
        Me.cmdsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'cmdclose
        '
        Me.cmdclose.BackColor = System.Drawing.Color.Honeydew
        Me.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdclose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.Image = Global.Hospital_Management_System.My.Resources.Resources.close
        Me.cmdclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdclose.Location = New System.Drawing.Point(31, 136)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(77, 29)
        Me.cmdclose.TabIndex = 4
        Me.cmdclose.Text = "Close"
        Me.cmdclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdclose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Client Type"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"New Client", "Re-Visits"})
        Me.cboStatus.Location = New System.Drawing.Point(149, 77)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboStatus.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(398, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 19)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "Weight"
        '
        'txtwight
        '
        Me.txtwight.Location = New System.Drawing.Point(395, 77)
        Me.txtwight.Name = "txtwight"
        Me.txtwight.Size = New System.Drawing.Size(134, 20)
        Me.txtwight.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(563, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 19)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Blood Pressure"
        '
        'txtbp
        '
        Me.txtbp.Location = New System.Drawing.Point(554, 77)
        Me.txtbp.Name = "txtbp"
        Me.txtbp.Size = New System.Drawing.Size(148, 20)
        Me.txtbp.TabIndex = 76
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 230)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(860, 232)
        Me.DataGridView1.TabIndex = 77
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MintCream
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(857, 41)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search by Client Name"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(252, 9)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(279, 26)
        Me.txtSearch.TabIndex = 28
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Aquamarine
        Me.Panel2.Controls.Add(Me.DtpReveiw)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.txtbp)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtwight)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.cboStatus)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.txtremarks)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtpid)
        Me.Panel2.Controls.Add(Me.cboMethod)
        Me.Panel2.Controls.Add(Me.txttel)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtcharges)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtage)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtpname)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(863, 528)
        Me.Panel2.TabIndex = 22
        '
        'DtpReveiw
        '
        Me.DtpReveiw.CalendarMonthBackground = System.Drawing.Color.AntiqueWhite
        Me.DtpReveiw.CalendarTitleBackColor = System.Drawing.Color.SaddleBrown
        Me.DtpReveiw.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpReveiw.Location = New System.Drawing.Point(278, 78)
        Me.DtpReveiw.Name = "DtpReveiw"
        Me.DtpReveiw.Size = New System.Drawing.Size(105, 20)
        Me.DtpReveiw.TabIndex = 79
        '
        'frmFamplan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(863, 529)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFamplan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFamplan"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents txtpno As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcharges As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttel As System.Windows.Forms.TextBox
    Friend WithEvents cboMethod As System.Windows.Forms.ComboBox
    Friend WithEvents txtpid As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtremarks As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtwight As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtbp As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DtpReveiw As System.Windows.Forms.DateTimePicker
End Class
