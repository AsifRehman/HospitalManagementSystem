<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabReceipt
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblname = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.dgw = New System.Windows.Forms.DataGridView
        Me.TestNO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TestName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Charges = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblrecNO = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label23 = New System.Windows.Forms.Label
        Me.lbluser = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblLine = New System.Windows.Forms.Label
        Me.lblCash = New System.Windows.Forms.Label
        Me.Cash = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.TotalAmount = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.cmdprint = New System.Windows.Forms.Button
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblname)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.dgw)
        Me.Panel1.Controls.Add(Me.lblrecNO)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 461)
        Me.Panel1.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(0, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(297, 13)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "----------------------------------------------------------"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Patient Name:"
        '
        'lblname
        '
        Me.lblname.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(100, 165)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(168, 13)
        Me.lblname.TabIndex = 71
        Me.lblname.Text = "name"
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-2, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(297, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "----------------------------------------------------------"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "OP No:"
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        Me.dgw.AllowUserToResizeColumns = False
        Me.dgw.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgw.ColumnHeadersHeight = 18
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TestNO, Me.TestName, Me.Charges})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.White
        Me.dgw.Location = New System.Drawing.Point(1, 188)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgw.Size = New System.Drawing.Size(296, 100)
        Me.dgw.TabIndex = 39
        '
        'TestNO
        '
        Me.TestNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TestNO.HeaderText = "Test ID"
        Me.TestNO.Name = "TestNO"
        Me.TestNO.ReadOnly = True
        Me.TestNO.Width = 55
        '
        'TestName
        '
        Me.TestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TestName.HeaderText = "Test Name"
        Me.TestName.Name = "TestName"
        Me.TestName.ReadOnly = True
        Me.TestName.Width = 130
        '
        'Charges
        '
        Me.Charges.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Charges.HeaderText = "Charges"
        Me.Charges.Name = "Charges"
        Me.Charges.ReadOnly = True
        Me.Charges.Width = 60
        '
        'lblrecNO
        '
        Me.lblrecNO.AutoSize = True
        Me.lblrecNO.Location = New System.Drawing.Point(66, 152)
        Me.lblrecNO.Name = "lblrecNO"
        Me.lblrecNO.Size = New System.Drawing.Size(14, 13)
        Me.lblrecNO.TabIndex = 48
        Me.lblrecNO.Text = "6"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 17)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Laboratory Payment Receipt"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.lbluser)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.lblLine)
        Me.Panel3.Controls.Add(Me.lblCash)
        Me.Panel3.Controls.Add(Me.Cash)
        Me.Panel3.Controls.Add(Me.lblTotal)
        Me.Panel3.Controls.Add(Me.TotalAmount)
        Me.Panel3.Location = New System.Drawing.Point(3, 294)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(297, 134)
        Me.Panel3.TabIndex = 46
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(60, 88)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(172, 14)
        Me.Label23.TabIndex = 88
        Me.Label23.Text = """Your Health, Our Concern"""
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(181, 107)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(34, 19)
        Me.lbluser.TabIndex = 58
        Me.lbluser.Text = "user"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(291, 19)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "-----------------------------------------------"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 19)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Served by:"
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine.Location = New System.Drawing.Point(4, 69)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(288, 19)
        Me.lblLine.TabIndex = 54
        Me.lblLine.Text = "==============================="
        '
        'lblCash
        '
        Me.lblCash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.Location = New System.Drawing.Point(181, 54)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(80, 15)
        Me.lblCash.TabIndex = 50
        Me.lblCash.Text = "0.00"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cash
        '
        Me.Cash.AutoSize = True
        Me.Cash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cash.Location = New System.Drawing.Point(61, 50)
        Me.Cash.Name = "Cash"
        Me.Cash.Size = New System.Drawing.Size(95, 19)
        Me.Cash.TabIndex = 53
        Me.Cash.Text = "Cash             :"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(182, 22)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(80, 19)
        Me.lblTotal.TabIndex = 45
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalAmount
        '
        Me.TotalAmount.AutoSize = True
        Me.TotalAmount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmount.Location = New System.Drawing.Point(59, 22)
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.Size = New System.Drawing.Size(97, 19)
        Me.TotalAmount.TabIndex = 46
        Me.TotalAmount.Text = "Total Amount :"
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(186, 126)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(80, 13)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(26, 126)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(117, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdprint
        '
        Me.cmdprint.BackColor = System.Drawing.Color.Yellow
        Me.cmdprint.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.Location = New System.Drawing.Point(120, 434)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(98, 28)
        Me.cmdprint.TabIndex = 5
        Me.cmdprint.Text = "Print"
        Me.cmdprint.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(79, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 15)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "Telephone: 0721401354"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 15)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "P.O. Box 447, Nkubu - Meru"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 17)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Kathera Medical Services"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 461)
        Me.Controls.Add(Me.cmdprint)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LabReceipt"
        Me.Text = "LabReceipt"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents lblrecNO As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents Cash As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents TotalAmount As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents cmdprint As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents TestNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TestName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Charges As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
