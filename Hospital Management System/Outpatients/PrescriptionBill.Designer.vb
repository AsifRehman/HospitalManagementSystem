<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrescriptionBill
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
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtdose = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblTT = New System.Windows.Forms.Label
        Me.txttcost = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.txtcost = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtprice = New System.Windows.Forms.TextBox
        Me.DataGridViewFinal = New System.Windows.Forms.DataGridView
        Me.lbldid = New System.Windows.Forms.Label
        Me.btnadd = New System.Windows.Forms.Button
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.txtStrength = New System.Windows.Forms.TextBox
        Me.txtmedname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridViewDoc = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.txtpno = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtpname = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtdose)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtcost)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtprice)
        Me.Panel1.Controls.Add(Me.DataGridViewFinal)
        Me.Panel1.Controls.Add(Me.lbldid)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.txtqty)
        Me.Panel1.Controls.Add(Me.txtStrength)
        Me.Panel1.Controls.Add(Me.txtmedname)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 340)
        Me.Panel1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(396, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 18)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Quantity"
        '
        'txtdose
        '
        Me.txtdose.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdose.Location = New System.Drawing.Point(297, 183)
        Me.txtdose.Name = "txtdose"
        Me.txtdose.Size = New System.Drawing.Size(91, 23)
        Me.txtdose.TabIndex = 68
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblTT)
        Me.Panel2.Controls.Add(Me.txttcost)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnOK)
        Me.Panel2.Location = New System.Drawing.Point(3, 272)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(793, 60)
        Me.Panel2.TabIndex = 67
        '
        'lblTT
        '
        Me.lblTT.AutoSize = True
        Me.lblTT.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTT.ForeColor = System.Drawing.Color.Red
        Me.lblTT.Location = New System.Drawing.Point(153, 22)
        Me.lblTT.Name = "lblTT"
        Me.lblTT.Size = New System.Drawing.Size(33, 19)
        Me.lblTT.TabIndex = 63
        Me.lblTT.Text = "0.00"
        Me.lblTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txttcost
        '
        Me.txttcost.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttcost.Location = New System.Drawing.Point(557, 22)
        Me.txttcost.Name = "txttcost"
        Me.txttcost.Size = New System.Drawing.Size(97, 25)
        Me.txttcost.TabIndex = 66
        Me.txttcost.Text = "0.00"
        Me.txttcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(432, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 19)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Pharmacist Cost"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 19)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "System Total Cost"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Snow
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Image = Global.Hospital_Management_System.My.Resources.Resources.Apply_16x16
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.Location = New System.Drawing.Point(716, 20)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(66, 26)
        Me.btnOK.TabIndex = 59
        Me.btnOK.Text = "Okay"
        Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'txtcost
        '
        Me.txtcost.BackColor = System.Drawing.Color.DarkCyan
        Me.txtcost.Location = New System.Drawing.Point(395, 134)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(60, 20)
        Me.txtcost.TabIndex = 64
        Me.txtcost.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(302, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 18)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Price"
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(297, 229)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(92, 23)
        Me.txtprice.TabIndex = 60
        '
        'DataGridViewFinal
        '
        Me.DataGridViewFinal.AllowUserToAddRows = False
        Me.DataGridViewFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFinal.Location = New System.Drawing.Point(459, 90)
        Me.DataGridViewFinal.Name = "DataGridViewFinal"
        Me.DataGridViewFinal.Size = New System.Drawing.Size(332, 170)
        Me.DataGridViewFinal.TabIndex = 48
        '
        'lbldid
        '
        Me.lbldid.AutoSize = True
        Me.lbldid.Location = New System.Drawing.Point(473, 70)
        Me.lbldid.Name = "lbldid"
        Me.lbldid.Size = New System.Drawing.Size(21, 13)
        Me.lbldid.TabIndex = 58
        Me.lbldid.Text = "did"
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnadd.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Image = Global.Hospital_Management_System.My.Resources.Resources.add2
        Me.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadd.Location = New System.Drawing.Point(399, 229)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(56, 23)
        Me.btnadd.TabIndex = 57
        Me.btnadd.Text = "ADD"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'txtqty
        '
        Me.txtqty.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(394, 183)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(61, 23)
        Me.txtqty.TabIndex = 56
        '
        'txtStrength
        '
        Me.txtStrength.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStrength.Location = New System.Drawing.Point(297, 135)
        Me.txtStrength.Name = "txtStrength"
        Me.txtStrength.Size = New System.Drawing.Size(92, 23)
        Me.txtStrength.TabIndex = 55
        '
        'txtmedname
        '
        Me.txtmedname.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmedname.Location = New System.Drawing.Point(297, 90)
        Me.txtmedname.Name = "txtmedname"
        Me.txtmedname.Size = New System.Drawing.Size(158, 23)
        Me.txtmedname.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Medicine"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(311, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Strength"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(302, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 18)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Dose"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.GroupBox1.Controls.Add(Me.DataGridViewDoc)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 192)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doctor's Prescription"
        '
        'DataGridViewDoc
        '
        Me.DataGridViewDoc.AllowUserToAddRows = False
        Me.DataGridViewDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDoc.Location = New System.Drawing.Point(7, 15)
        Me.DataGridViewDoc.Name = "DataGridViewDoc"
        Me.DataGridViewDoc.Size = New System.Drawing.Size(267, 170)
        Me.DataGridViewDoc.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdsearch)
        Me.GroupBox2.Controls.Add(Me.txtpno)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtpname)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(789, 60)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search by Patient No"
        '
        'cmdsearch
        '
        Me.cmdsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdsearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsearch.Image = Global.Hospital_Management_System.My.Resources.Resources.search2
        Me.cmdsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdsearch.Location = New System.Drawing.Point(283, 23)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(79, 26)
        Me.cmdsearch.TabIndex = 28
        Me.cmdsearch.Text = "Search"
        Me.cmdsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdsearch.UseVisualStyleBackColor = True
        '
        'txtpno
        '
        Me.txtpno.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpno.Location = New System.Drawing.Point(128, 24)
        Me.txtpno.Name = "txtpno"
        Me.txtpno.Size = New System.Drawing.Size(139, 26)
        Me.txtpno.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 18)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Patient Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(398, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Patient Name:"
        '
        'txtpname
        '
        Me.txtpname.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpname.Location = New System.Drawing.Point(499, 24)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(279, 26)
        Me.txtpname.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(405, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 18)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Batch No:"
        '
        'PrescriptionBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(796, 340)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PrescriptionBill"
        Me.Text = "PrescriptionBill"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txttcost As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcost As System.Windows.Forms.TextBox
    Friend WithEvents lblTT As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents DataGridViewFinal As System.Windows.Forms.DataGridView
    Friend WithEvents lbldid As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents txtStrength As System.Windows.Forms.TextBox
    Friend WithEvents txtmedname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewDoc As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents txtpno As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdose As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
