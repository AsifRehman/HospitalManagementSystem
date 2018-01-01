<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultation
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
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
        Me.txtId = New System.Windows.Forms.TextBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.btnResults = New System.Windows.Forms.Button
        Me.btnLab = New System.Windows.Forms.Button
        Me.BtnDrugs = New System.Windows.Forms.Button
        Me.btnReviews = New System.Windows.Forms.Button
        Me.BtnTreat = New System.Windows.Forms.Button
        Me.btnPhyc = New System.Windows.Forms.Button
        Me.btnVitals = New System.Windows.Forms.Button
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.lblVno = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtpaymode = New System.Windows.Forms.TextBox
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnReset = New System.Windows.Forms.Button
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.LinkLabel3)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.lblVno)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1091, 442)
        Me.Panel1.TabIndex = 0
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(448, 80)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(140, 19)
        Me.LinkLabel3.TabIndex = 31
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "View Patient Profile"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(235, 64)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(26, 20)
        Me.txtId.TabIndex = 34
        Me.txtId.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Azure
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Garamond", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(936, 71)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(119, 32)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightCyan
        Me.GroupBox4.Controls.Add(Me.Button10)
        Me.GroupBox4.Controls.Add(Me.Button9)
        Me.GroupBox4.Controls.Add(Me.btnResults)
        Me.GroupBox4.Controls.Add(Me.btnLab)
        Me.GroupBox4.Controls.Add(Me.BtnDrugs)
        Me.GroupBox4.Controls.Add(Me.btnReviews)
        Me.GroupBox4.Controls.Add(Me.BtnTreat)
        Me.GroupBox4.Controls.Add(Me.btnPhyc)
        Me.GroupBox4.Controls.Add(Me.btnVitals)
        Me.GroupBox4.Location = New System.Drawing.Point(2, 62)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(229, 373)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Red
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(3, 265)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(223, 32)
        Me.Button10.TabIndex = 13
        Me.Button10.Text = "View Pending Treatments"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(3, 233)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(223, 32)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "Family Planning && Procedures"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'btnResults
        '
        Me.btnResults.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResults.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnResults.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResults.Image = Global.Hospital_Management_System.My.Resources.Resources.transactions1
        Me.btnResults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResults.Location = New System.Drawing.Point(3, 201)
        Me.btnResults.Name = "btnResults"
        Me.btnResults.Size = New System.Drawing.Size(223, 32)
        Me.btnResults.TabIndex = 11
        Me.btnResults.Text = "View Patient's Lab Results"
        Me.btnResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnResults.UseVisualStyleBackColor = True
        '
        'btnLab
        '
        Me.btnLab.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLab.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLab.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLab.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLab.Image = Global.Hospital_Management_System.My.Resources.Resources.accounts1
        Me.btnLab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLab.Location = New System.Drawing.Point(3, 170)
        Me.btnLab.Name = "btnLab"
        Me.btnLab.Size = New System.Drawing.Size(223, 31)
        Me.btnLab.TabIndex = 10
        Me.btnLab.Text = "Send  Patient  Laboratory"
        Me.btnLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLab.UseVisualStyleBackColor = True
        '
        'BtnDrugs
        '
        Me.BtnDrugs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDrugs.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDrugs.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDrugs.Image = Global.Hospital_Management_System.My.Resources.Resources.purchase_return1
        Me.BtnDrugs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDrugs.Location = New System.Drawing.Point(3, 138)
        Me.BtnDrugs.Name = "BtnDrugs"
        Me.BtnDrugs.Size = New System.Drawing.Size(223, 32)
        Me.BtnDrugs.TabIndex = 9
        Me.BtnDrugs.Text = "View  Medicines  In stock"
        Me.BtnDrugs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDrugs.UseVisualStyleBackColor = True
        '
        'btnReviews
        '
        Me.btnReviews.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReviews.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReviews.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReviews.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReviews.Image = Global.Hospital_Management_System.My.Resources.Resources.payroll_period
        Me.btnReviews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReviews.Location = New System.Drawing.Point(3, 107)
        Me.btnReviews.Name = "btnReviews"
        Me.btnReviews.Size = New System.Drawing.Size(223, 31)
        Me.btnReviews.TabIndex = 8
        Me.btnReviews.Text = "Review  Today's  Patients"
        Me.btnReviews.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReviews.UseVisualStyleBackColor = True
        '
        'BtnTreat
        '
        Me.BtnTreat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTreat.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTreat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTreat.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTreat.Image = Global.Hospital_Management_System.My.Resources.Resources.login_user2
        Me.BtnTreat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTreat.Location = New System.Drawing.Point(3, 77)
        Me.BtnTreat.Name = "BtnTreat"
        Me.BtnTreat.Size = New System.Drawing.Size(223, 30)
        Me.BtnTreat.TabIndex = 7
        Me.BtnTreat.Text = "Treatment && Prescription"
        Me.BtnTreat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTreat.UseVisualStyleBackColor = True
        '
        'btnPhyc
        '
        Me.btnPhyc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPhyc.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPhyc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPhyc.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhyc.Image = Global.Hospital_Management_System.My.Resources.Resources.Notepad11
        Me.btnPhyc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPhyc.Location = New System.Drawing.Point(3, 46)
        Me.btnPhyc.Name = "btnPhyc"
        Me.btnPhyc.Size = New System.Drawing.Size(223, 31)
        Me.btnPhyc.TabIndex = 6
        Me.btnPhyc.Text = "Add Physical Examination"
        Me.btnPhyc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPhyc.UseVisualStyleBackColor = True
        '
        'btnVitals
        '
        Me.btnVitals.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVitals.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVitals.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVitals.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVitals.Image = Global.Hospital_Management_System.My.Resources.Resources.invoice_printing2
        Me.btnVitals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVitals.Location = New System.Drawing.Point(3, 16)
        Me.btnVitals.Name = "btnVitals"
        Me.btnVitals.Size = New System.Drawing.Size(223, 30)
        Me.btnVitals.TabIndex = 5
        Me.btnVitals.Text = "Take  Patient  Vital  Data"
        Me.btnVitals.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVitals.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(267, 80)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(146, 19)
        Me.LinkLabel1.TabIndex = 30
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Current Patient's  Notes"
        '
        'lblVno
        '
        Me.lblVno.AutoSize = True
        Me.lblVno.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVno.ForeColor = System.Drawing.Color.Red
        Me.lblVno.Location = New System.Drawing.Point(580, 62)
        Me.lblVno.Name = "lblVno"
        Me.lblVno.Size = New System.Drawing.Size(26, 19)
        Me.lblVno.TabIndex = 29
        Me.lblVno.Text = "No"
        Me.lblVno.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(438, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 19)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Total visits"
        Me.Label7.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.txtpaymode)
        Me.Panel2.Controls.Add(Me.LinkLabel2)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Label6)
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
        Me.Panel2.Size = New System.Drawing.Size(1091, 61)
        Me.Panel2.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Hospital_Management_System.My.Resources.Resources.close
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(951, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 24)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Close Form"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtpaymode
        '
        Me.txtpaymode.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaymode.Location = New System.Drawing.Point(699, 31)
        Me.txtpaymode.Name = "txtpaymode"
        Me.txtpaymode.Size = New System.Drawing.Size(97, 25)
        Me.txtpaymode.TabIndex = 29
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(820, 6)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(53, 19)
        Me.LinkLabel2.TabIndex = 31
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Refresh"
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
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.MintCream
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.Hospital_Management_System.My.Resources.Resources.explorer
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(813, 31)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(108, 24)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Find Patient"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(711, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 18)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Pay Mode"
        '
        'txtpname
        '
        Me.txtpname.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpname.Location = New System.Drawing.Point(205, 31)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(188, 25)
        Me.txtpname.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(209, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Patient Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(411, 5)
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
        Me.txtPno.Size = New System.Drawing.Size(101, 25)
        Me.txtPno.TabIndex = 26
        '
        'txtage
        '
        Me.txtage.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(399, 31)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(68, 25)
        Me.txtage.TabIndex = 17
        '
        'txttel
        '
        Me.txttel.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttel.Location = New System.Drawing.Point(571, 31)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(122, 25)
        Me.txttel.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Patient No:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(477, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(577, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Telephone"
        '
        'txtgender
        '
        Me.txtgender.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgender.Location = New System.Drawing.Point(473, 31)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(92, 25)
        Me.txtgender.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnReset)
        Me.GroupBox3.Controls.Add(Me.txtsearch)
        Me.GroupBox3.Location = New System.Drawing.Point(612, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(279, 43)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search By Name"
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(719, 9)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 17
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(29, 14)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(236, 23)
        Me.txtsearch.TabIndex = 16
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(237, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(842, 333)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Information"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 15)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(831, 312)
        Me.DataGridView1.TabIndex = 0
        '
        'Consultation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1098, 457)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Consultation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consultation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtpaymode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txttel As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtgender As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtPno As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblVno As System.Windows.Forms.Label
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents btnResults As System.Windows.Forms.Button
    Friend WithEvents btnLab As System.Windows.Forms.Button
    Friend WithEvents BtnDrugs As System.Windows.Forms.Button
    Friend WithEvents btnReviews As System.Windows.Forms.Button
    Friend WithEvents BtnTreat As System.Windows.Forms.Button
    Friend WithEvents btnPhyc As System.Windows.Forms.Button
    Friend WithEvents btnVitals As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
End Class
