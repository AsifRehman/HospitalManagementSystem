<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_Report
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
        Me.txtpname = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtexpres = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtexam = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txthistory = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtchief = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbopno = New System.Windows.Forms.ComboBox
        Me.btnprint = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtpname
        '
        Me.txtpname.Location = New System.Drawing.Point(389, 12)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(151, 20)
        Me.txtpname.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(277, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Patient Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Patient No:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox3.Controls.Add(Me.txtexpres)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtexam)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txthistory)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtchief)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(545, 283)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Treatment Summary"
        '
        'txtexpres
        '
        Me.txtexpres.Location = New System.Drawing.Point(128, 209)
        Me.txtexpres.Multiline = True
        Me.txtexpres.Name = "txtexpres"
        Me.txtexpres.Size = New System.Drawing.Size(398, 57)
        Me.txtexpres.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 229)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Diagnosis"
        '
        'txtexam
        '
        Me.txtexam.Location = New System.Drawing.Point(128, 137)
        Me.txtexam.Multiline = True
        Me.txtexam.Name = "txtexam"
        Me.txtexam.Size = New System.Drawing.Size(398, 66)
        Me.txtexam.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 27)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Lab Investigation"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txthistory
        '
        Me.txthistory.Location = New System.Drawing.Point(128, 71)
        Me.txthistory.Multiline = True
        Me.txthistory.Name = "txthistory"
        Me.txthistory.Size = New System.Drawing.Size(398, 60)
        Me.txthistory.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 47)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "History and Examination"
        '
        'txtchief
        '
        Me.txtchief.Location = New System.Drawing.Point(128, 8)
        Me.txtchief.Multiline = True
        Me.txtchief.Name = "txtchief"
        Me.txtchief.Size = New System.Drawing.Size(398, 57)
        Me.txtchief.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = " Chief Complain"
        '
        'cbopno
        '
        Me.cbopno.FormattingEnabled = True
        Me.cbopno.Location = New System.Drawing.Point(109, 11)
        Me.cbopno.Name = "cbopno"
        Me.cbopno.Size = New System.Drawing.Size(149, 21)
        Me.cbopno.TabIndex = 16
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.Lime
        Me.btnprint.Location = New System.Drawing.Point(218, 327)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(88, 26)
        Me.btnprint.TabIndex = 17
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'Patient_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 359)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.cbopno)
        Me.Controls.Add(Me.txtpname)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Patient_Report"
        Me.Text = "Patient Treatment Form"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtexpres As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtexam As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txthistory As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtchief As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbopno As System.Windows.Forms.ComboBox
    Friend WithEvents btnprint As System.Windows.Forms.Button
End Class
