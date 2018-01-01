<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.UserType = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnlogin = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.panel1 = New System.Windows.Forms.Panel
        Me.label1 = New System.Windows.Forms.Label
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.panel9 = New System.Windows.Forms.Panel
        Me.lnkGSoft = New System.Windows.Forms.LinkLabel
        Me.label7 = New System.Windows.Forms.Label
        Me.panel7 = New System.Windows.Forms.Panel
        Me.label6 = New System.Windows.Forms.Label
        Me.label5 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.lnkAbout = New System.Windows.Forms.LinkLabel
        Me.lnkOrderOnline = New System.Windows.Forms.LinkLabel
        Me.lnkHelp = New System.Windows.Forms.LinkLabel
        Me.lnkExit = New System.Windows.Forms.LinkLabel
        Me.panel8 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserType
        '
        Me.UserType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserType.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserType.Location = New System.Drawing.Point(103, 118)
        Me.UserType.Name = "UserType"
        Me.UserType.Size = New System.Drawing.Size(55, 22)
        Me.UserType.TabIndex = 31
        Me.UserType.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(172, 113)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancel"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.SystemColors.Info
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogin.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Image = CType(resources.GetObject("btnlogin.Image"), System.Drawing.Image)
        Me.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogin.Location = New System.Drawing.Point(18, 113)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 28)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.Text = "Login"
        Me.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Info
        Me.txtPassword.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(3, 75)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(244, 25)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password :"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Info
        Me.txtUsername.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(3, 26)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(244, 25)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User Name :"
        '
        'panel1
        '
        Me.panel1.BackgroundImage = CType(resources.GetObject("panel1.BackgroundImage"), System.Drawing.Image)
        Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(280, 28)
        Me.panel1.TabIndex = 254
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(34, 6)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(218, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "MedPlus Hospital Care  | User Authentication"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(5, 2)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(24, 21)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'panel9
        '
        Me.panel9.BackgroundImage = CType(resources.GetObject("panel9.BackgroundImage"), System.Drawing.Image)
        Me.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel9.Controls.Add(Me.lnkGSoft)
        Me.panel9.Controls.Add(Me.label7)
        Me.panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel9.Location = New System.Drawing.Point(0, 213)
        Me.panel9.Name = "panel9"
        Me.panel9.Size = New System.Drawing.Size(280, 26)
        Me.panel9.TabIndex = 257
        '
        'lnkGSoft
        '
        Me.lnkGSoft.AutoSize = True
        Me.lnkGSoft.BackColor = System.Drawing.Color.Transparent
        Me.lnkGSoft.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkGSoft.Location = New System.Drawing.Point(91, 7)
        Me.lnkGSoft.Name = "lnkGSoft"
        Me.lnkGSoft.Size = New System.Drawing.Size(118, 13)
        Me.lnkGSoft.TabIndex = 26
        Me.lnkGSoft.TabStop = True
        Me.lnkGSoft.Text = "Tech-StarTechnologies"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(12, 7)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(83, 13)
        Me.label7.TabIndex = 1
        Me.label7.Text = "Developed By - "
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.Color.Silver
        Me.panel7.Location = New System.Drawing.Point(5, 183)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(263, 3)
        Me.panel7.TabIndex = 265
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.Color.Gray
        Me.label6.Location = New System.Drawing.Point(104, 191)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(9, 13)
        Me.label6.TabIndex = 264
        Me.label6.Text = "|"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.ForeColor = System.Drawing.Color.Gray
        Me.label5.Location = New System.Drawing.Point(164, 191)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(9, 13)
        Me.label5.TabIndex = 263
        Me.label5.Text = "|"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.Color.Gray
        Me.label4.Location = New System.Drawing.Point(226, 191)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(9, 13)
        Me.label4.TabIndex = 262
        Me.label4.Text = "|"
        '
        'lnkAbout
        '
        Me.lnkAbout.AutoSize = True
        Me.lnkAbout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkAbout.Location = New System.Drawing.Point(178, 192)
        Me.lnkAbout.Name = "lnkAbout"
        Me.lnkAbout.Size = New System.Drawing.Size(35, 13)
        Me.lnkAbout.TabIndex = 261
        Me.lnkAbout.TabStop = True
        Me.lnkAbout.Text = "About"
        '
        'lnkOrderOnline
        '
        Me.lnkOrderOnline.AutoSize = True
        Me.lnkOrderOnline.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkOrderOnline.Location = New System.Drawing.Point(17, 191)
        Me.lnkOrderOnline.Name = "lnkOrderOnline"
        Me.lnkOrderOnline.Size = New System.Drawing.Size(66, 13)
        Me.lnkOrderOnline.TabIndex = 260
        Me.lnkOrderOnline.TabStop = True
        Me.lnkOrderOnline.Text = "Order Online"
        '
        'lnkHelp
        '
        Me.lnkHelp.AutoSize = True
        Me.lnkHelp.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkHelp.Location = New System.Drawing.Point(124, 191)
        Me.lnkHelp.Name = "lnkHelp"
        Me.lnkHelp.Size = New System.Drawing.Size(29, 13)
        Me.lnkHelp.TabIndex = 259
        Me.lnkHelp.TabStop = True
        Me.lnkHelp.Text = "Help"
        '
        'lnkExit
        '
        Me.lnkExit.AutoSize = True
        Me.lnkExit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkExit.Location = New System.Drawing.Point(242, 192)
        Me.lnkExit.Name = "lnkExit"
        Me.lnkExit.Size = New System.Drawing.Size(24, 13)
        Me.lnkExit.TabIndex = 258
        Me.lnkExit.TabStop = True
        Me.lnkExit.Text = "Exit"
        '
        'panel8
        '
        Me.panel8.BackColor = System.Drawing.Color.Silver
        Me.panel8.Location = New System.Drawing.Point(5, 208)
        Me.panel8.Name = "panel8"
        Me.panel8.Size = New System.Drawing.Size(263, 3)
        Me.panel8.TabIndex = 266
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.UserType)
        Me.Panel2.Controls.Add(Me.btnlogin)
        Me.Panel2.Controls.Add(Me.txtUsername)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Location = New System.Drawing.Point(7, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(261, 148)
        Me.Panel2.TabIndex = 267
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(280, 239)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panel7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.lnkAbout)
        Me.Controls.Add(Me.lnkOrderOnline)
        Me.Controls.Add(Me.lnkHelp)
        Me.Controls.Add(Me.lnkExit)
        Me.Controls.Add(Me.panel8)
        Me.Controls.Add(Me.panel9)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel9.ResumeLayout(False)
        Me.panel9.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UserType As System.Windows.Forms.TextBox
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents panel9 As System.Windows.Forms.Panel
    Private WithEvents lnkGSoft As System.Windows.Forms.LinkLabel
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents panel7 As System.Windows.Forms.Panel
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents lnkAbout As System.Windows.Forms.LinkLabel
    Private WithEvents lnkOrderOnline As System.Windows.Forms.LinkLabel
    Private WithEvents lnkHelp As System.Windows.Forms.LinkLabel
    Private WithEvents lnkExit As System.Windows.Forms.LinkLabel
    Private WithEvents panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
