<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Immunization
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdupdate = New System.Windows.Forms.Button
        Me.cmdclose = New System.Windows.Forms.Button
        Me.cmddelete = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdnew = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnadd = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboImmName = New System.Windows.Forms.ComboBox
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.txtremarks = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtpid = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtweight = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtage = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboDuration = New System.Windows.Forms.ComboBox
        Me.txtparentTel = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtchange = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtParentName = New System.Windows.Forms.TextBox
        Me.txtpname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightCyan
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 594)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(606, 14)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(116, 13)
        Me.LinkLabel2.TabIndex = 39
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Vaccine Report Report"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(503, 14)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(71, 13)
        Me.LinkLabel1.TabIndex = 38
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Profile Report"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 379)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(740, 209)
        Me.DataGridView1.TabIndex = 35
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox5.Controls.Add(Me.cmdsearch)
        Me.GroupBox5.Controls.Add(Me.txtsearch)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(4, 30)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(740, 34)
        Me.GroupBox5.TabIndex = 34
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Search"
        '
        'cmdsearch
        '
        Me.cmdsearch.Location = New System.Drawing.Point(393, 8)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(84, 26)
        Me.cmdsearch.TabIndex = 45
        Me.cmdsearch.Text = "Search"
        Me.cmdsearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtsearch.Location = New System.Drawing.Point(137, 7)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(240, 21)
        Me.txtsearch.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 15)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Search by Patient No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkCyan
        Me.GroupBox2.Controls.Add(Me.cmdupdate)
        Me.GroupBox2.Controls.Add(Me.cmdclose)
        Me.GroupBox2.Controls.Add(Me.cmddelete)
        Me.GroupBox2.Controls.Add(Me.cmdsave)
        Me.GroupBox2.Controls.Add(Me.cmdnew)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 326)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(736, 47)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'cmdupdate
        '
        Me.cmdupdate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdupdate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdupdate.Location = New System.Drawing.Point(282, 9)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(95, 30)
        Me.cmdupdate.TabIndex = 5
        Me.cmdupdate.Text = "Update"
        Me.cmdupdate.UseVisualStyleBackColor = False
        '
        'cmdclose
        '
        Me.cmdclose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdclose.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.Location = New System.Drawing.Point(574, 9)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(95, 30)
        Me.cmdclose.TabIndex = 4
        Me.cmdclose.Text = "Close"
        Me.cmdclose.UseVisualStyleBackColor = False
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmddelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmddelete.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.Location = New System.Drawing.Point(422, 9)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(95, 30)
        Me.cmddelete.TabIndex = 3
        Me.cmddelete.Text = "Delete"
        Me.cmddelete.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdsave.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(137, 10)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(95, 30)
        Me.cmdsave.TabIndex = 1
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'cmdnew
        '
        Me.cmdnew.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdnew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdnew.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnew.Location = New System.Drawing.Point(6, 10)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(95, 29)
        Me.cmdnew.TabIndex = 0
        Me.cmdnew.Text = "New"
        Me.cmdnew.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.txtremarks)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtpid)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtweight)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtage)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cboDuration)
        Me.GroupBox3.Controls.Add(Me.txtparentTel)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtchange)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtParentName)
        Me.GroupBox3.Controls.Add(Me.txtpname)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 69)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(736, 251)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Linen
        Me.GroupBox4.Controls.Add(Me.btnadd)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.cboImmName)
        Me.GroupBox4.Controls.Add(Me.DataGridView2)
        Me.GroupBox4.Location = New System.Drawing.Point(319, 94)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(411, 143)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Vaccination"
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Lime
        Me.btnadd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(294, 13)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(67, 23)
        Me.btnadd.TabIndex = 6
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Immunization Name"
        '
        'cboImmName
        '
        Me.cboImmName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboImmName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboImmName.FormattingEnabled = True
        Me.cboImmName.Items.AddRange(New Object() {"Polio", "Penta", "Vitamin A", "Pneumococol", "IPV", "Measles", "Weight", "Rota", "Deworming", "BCG"})
        Me.cboImmName.Location = New System.Drawing.Point(130, 15)
        Me.cboImmName.Name = "cboImmName"
        Me.cboImmName.Size = New System.Drawing.Size(158, 21)
        Me.cboImmName.TabIndex = 25
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 42)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(364, 92)
        Me.DataGridView2.TabIndex = 0
        '
        'txtremarks
        '
        Me.txtremarks.Location = New System.Drawing.Point(71, 102)
        Me.txtremarks.Multiline = True
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtremarks.Size = New System.Drawing.Size(242, 135)
        Me.txtremarks.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 118)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Remarks"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Patient NO"
        '
        'txtpid
        '
        Me.txtpid.Location = New System.Drawing.Point(99, 14)
        Me.txtpid.Name = "txtpid"
        Me.txtpid.Size = New System.Drawing.Size(120, 20)
        Me.txtpid.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(266, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "ParentTel"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(523, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Weight"
        '
        'txtweight
        '
        Me.txtweight.Location = New System.Drawing.Point(579, 44)
        Me.txtweight.Name = "txtweight"
        Me.txtweight.Size = New System.Drawing.Size(130, 20)
        Me.txtweight.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(524, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Age"
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(579, 14)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(130, 20)
        Me.txtage.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Parent Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 383)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 16
        '
        'cboDuration
        '
        Me.cboDuration.FormattingEnabled = True
        Me.cboDuration.Items.AddRange(New Object() {"6Weeks", "10Weeks", "14Weeks", "9 Months", "12 Months", "18Months", "24 Months", "60 Months"})
        Me.cboDuration.Location = New System.Drawing.Point(95, 75)
        Me.cboDuration.Name = "cboDuration"
        Me.cboDuration.Size = New System.Drawing.Size(154, 21)
        Me.cboDuration.TabIndex = 15
        '
        'txtparentTel
        '
        Me.txtparentTel.Location = New System.Drawing.Point(346, 43)
        Me.txtparentTel.Name = "txtparentTel"
        Me.txtparentTel.Size = New System.Drawing.Size(146, 20)
        Me.txtparentTel.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 12
        '
        'txtchange
        '
        Me.txtchange.Location = New System.Drawing.Point(346, 69)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.Size = New System.Drawing.Size(146, 20)
        Me.txtchange.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(275, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Charges"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Duration"
        '
        'txtParentName
        '
        Me.txtParentName.Location = New System.Drawing.Point(99, 44)
        Me.txtParentName.Name = "txtParentName"
        Me.txtParentName.Size = New System.Drawing.Size(153, 20)
        Me.txtParentName.TabIndex = 5
        '
        'txtpname
        '
        Me.txtpname.Location = New System.Drawing.Point(334, 17)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(158, 20)
        Me.txtpname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(236, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Patient's Name"
        '
        'Immunization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 608)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Immunization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Immunization"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtweight As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboDuration As System.Windows.Forms.ComboBox
    Friend WithEvents txtparentTel As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtchange As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtParentName As System.Windows.Forms.TextBox
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpid As System.Windows.Forms.TextBox
    Friend WithEvents txtremarks As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboImmName As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
