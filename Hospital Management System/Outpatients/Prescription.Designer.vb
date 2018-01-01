<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prescription
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
        Me.txtStrength = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.btnadd = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtgender = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtpname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtpno = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.txtdose = New System.Windows.Forms.ComboBox
        Me.TxtDname = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtDuration = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblid = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtStrength
        '
        Me.txtStrength.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStrength.Location = New System.Drawing.Point(88, 148)
        Me.txtStrength.Name = "txtStrength"
        Me.txtStrength.Size = New System.Drawing.Size(132, 25)
        Me.txtStrength.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 18)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Batch No."
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(377, 53)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(221, 19)
        Me.LinkLabel3.TabIndex = 23
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Click here for External Prescription"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(14, 61)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(121, 15)
        Me.LinkLabel2.TabIndex = 22
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Click To Pick Drugs"
        '
        'btnadd
        '
        Me.btnadd.AutoSize = True
        Me.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnadd.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Image = Global.Hospital_Management_System.My.Resources.Resources.add1
        Me.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadd.Location = New System.Drawing.Point(211, 207)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(79, 28)
        Me.btnadd.TabIndex = 14
        Me.btnadd.Text = "Add List"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(293, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(345, 148)
        Me.DataGridView1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Drug Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Strength"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Dose"
        '
        'txtgender
        '
        Me.txtgender.Location = New System.Drawing.Point(543, 17)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(95, 20)
        Me.txtgender.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(471, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Gender:"
        '
        'txtpname
        '
        Me.txtpname.Location = New System.Drawing.Point(282, 17)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(183, 20)
        Me.txtpname.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Fullnames:"
        '
        'txtpno
        '
        Me.txtpno.Location = New System.Drawing.Point(100, 18)
        Me.txtpno.Name = "txtpno"
        Me.txtpno.Size = New System.Drawing.Size(88, 20)
        Me.txtpno.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = " Patient No:"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.MintCream
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.Hospital_Management_System.My.Resources.Resources.app_exit1
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(543, 254)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(71, 31)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "&Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.MintCream
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsave.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Image = Global.Hospital_Management_System.My.Resources.Resources.Apply_16x161
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(22, 254)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(74, 31)
        Me.btnsave.TabIndex = 15
        Me.btnsave.Text = "&Okay"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'txtdose
        '
        Me.txtdose.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtdose.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdose.FormattingEnabled = True
        Me.txtdose.Items.AddRange(New Object() {"QD ", "BD", "TDS", "QID ", "Q5 "})
        Me.txtdose.Location = New System.Drawing.Point(88, 179)
        Me.txtdose.Name = "txtdose"
        Me.txtdose.Size = New System.Drawing.Size(132, 26)
        Me.txtdose.TabIndex = 34
        Me.txtdose.Text = "---Select Dose---"
        '
        'TxtDname
        '
        Me.TxtDname.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDname.Location = New System.Drawing.Point(88, 119)
        Me.TxtDname.Name = "TxtDname"
        Me.TxtDname.Size = New System.Drawing.Size(199, 25)
        Me.TxtDname.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.txtDuration)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtdose)
        Me.Panel1.Controls.Add(Me.TxtDname)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.txtStrength)
        Me.Panel1.Controls.Add(Me.lblid)
        Me.Panel1.Controls.Add(Me.LinkLabel3)
        Me.Panel1.Controls.Add(Me.txtgender)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtpno)
        Me.Panel1.Controls.Add(Me.txtpname)
        Me.Panel1.Controls.Add(Me.LinkLabel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 311)
        Me.Panel1.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 288)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(643, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "=================================================================================" & _
            "========================="
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(643, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "=================================================================================" & _
            "========================="
        '
        'txtDuration
        '
        Me.txtDuration.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuration.Location = New System.Drawing.Point(88, 210)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(117, 25)
        Me.txtDuration.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 18)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Duration"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(643, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "=================================================================================" & _
            "========================="
        '
        'lblid
        '
        Me.lblid.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(88, 90)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(199, 25)
        Me.lblid.TabIndex = 32
        '
        'Prescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(649, 311)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Prescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prescription"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpno As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtgender As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStrength As System.Windows.Forms.TextBox
    Friend WithEvents txtdose As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDname As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblid As System.Windows.Forms.TextBox
    Friend WithEvents txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
