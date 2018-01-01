<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pending_Patients
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.PatientNO = New System.Windows.Forms.ColumnHeader
        Me.PName = New System.Windows.Forms.ColumnHeader
        Me.Age = New System.Windows.Forms.ColumnHeader
        Me.Gender = New System.Windows.Forms.ColumnHeader
        Me.Location = New System.Windows.Forms.ColumnHeader
        Me.Tel = New System.Windows.Forms.ColumnHeader
        Me.Pay_Mode = New System.Windows.Forms.ColumnHeader
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(677, 338)
        Me.Panel1.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PatientNO, Me.PName, Me.Age, Me.Gender, Me.Location, Me.Tel, Me.Pay_Mode})
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(671, 332)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'PatientNO
        '
        Me.PatientNO.Text = "PatientNO"
        '
        'PName
        '
        Me.PName.Text = "PName"
        Me.PName.Width = 160
        '
        'Age
        '
        Me.Age.Text = "Age"
        '
        'Gender
        '
        Me.Gender.Text = "Gender"
        '
        'Location
        '
        Me.Location.Text = "Location"
        Me.Location.Width = 120
        '
        'Tel
        '
        Me.Tel.Text = "Tel"
        Me.Tel.Width = 100
        '
        'Pay_Mode
        '
        Me.Pay_Mode.Text = "Pay_Mode"
        Me.Pay_Mode.Width = 100
        '
        'Pending_Patients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 338)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Pending_Patients"
        Me.Text = "Pending Patients"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents PatientNO As System.Windows.Forms.ColumnHeader
    Friend WithEvents PName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Age As System.Windows.Forms.ColumnHeader
    Friend WithEvents Gender As System.Windows.Forms.ColumnHeader
    Friend WithEvents Location As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tel As System.Windows.Forms.ColumnHeader
    Friend WithEvents Pay_Mode As System.Windows.Forms.ColumnHeader
End Class
