Imports MySql.Data.MySqlClient
Public Class Prescription

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Prescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillOutpatPrescription()
        fillgrid()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        connectDB()
        Dim stt As String
        stt = "NF"
        If txtpno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtpno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf TxtDname.Text = "" Then
            MsgBox("Drug Name is empty", MsgBoxStyle.Critical)
            TxtDname.Focus()

        Else
            sql = "Insert into outpatpresciption(PatientNo,PatientName,Gender,Batch,Medicine,Strength,Dose,Duration,status,EDate) values('" & txtpno.Text & "','" & txtpname.Text & "','" & txtgender.Text & "','" & lblid.Text & "','" & TxtDname.Text & "','" & txtStrength.Text & "','" & txtdose.Text & "','" & txtDuration.Text & "','" & stt & "','" & Format(DateTime.Today, "yyyy-MM-dd") & "')"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            fillgrid()
            Call clear()
        End If
        dr.Dispose()
        conn.Close()
    End Sub
    Sub clear()
        lblid.Text = ""
        TxtDname.Text = ""
        txtdose.Text = ""
        txtStrength.Text = ""
        txtDuration.Text = ""
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        If lblid.Text = "" Then
            MsgBox("Select a record to delete", MsgBoxStyle.Critical)
            lblid.Focus()
        Else
            connectDB()
            Dim cmd As New MySqlCommand
            Dim reply As String
            sql = "Delete from outpatpresciption where Batch= '" & lblid.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            reply = MsgBox("Are you sure you want to delete this record???", MsgBoxStyle.YesNoCancel, "Delete")
            If reply = MsgBoxResult.Yes Then
                dr = cmd.ExecuteReader
                MessageBox.Show("Data Delete Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                fillgrid()
                lblid.Text = ""
            End If
        End If
    End Sub
    Sub fillgrid()
        connectDB()
        RefreshDB()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsourse As New BindingSource
        Try
            Dim query As String
            query = "select Batch,PatientNo,PatientName,Medicine,Strength,Dose,Duration,EDate from outpatpresciption where  PatientNo = '" & txtpno.Text & "' and  EDate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "'"
            COMMAND = New MySqlCommand(query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bsourse.DataSource = dbdataset
            DataGridView1.DataSource = bsourse
            SDA.Update(dbdataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Me.Close()
        'TxtDname.Items.Clear()
    End Sub

    Private Sub cmbDrgName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim READER As MySqlDataReader
        Dim sql As String
        Try
            connectDB()
            'Dim Lbqst As String
            'Lbqst = "YES"
            sql = "select * from drugentry where Drug_Name = '" & TxtDname.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            While READER.Read
                lblid.Text = READER.GetString("Batch")
                txtStrength.Text = READER.GetString("Strength")


            End While
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Drugs_Instock.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
        Me.lblid.Text = DataGridView1.Item(0, e.RowIndex).Value
        'Me.cmbDrgName.Text = DataGridView1.Item(2, e.RowIndex).Value
        'Me.txtq.Text = DataGridView1.Item(3, e.RowIndex).Value
        'Me.txtqty.Text = DataGridView1.Item(4, e.RowIndex).Value
        'Me.txttotal.Text = DataGridView1.Item(5, e.RowIndex).Value
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        If txtpno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtpno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtgender.Text = "" Then
            MsgBox("Patient gender is empty", MsgBoxStyle.Critical)
            txtgender.Focus()
        Else
            With Outside_Prescription
                .txtpno.Text = Me.txtpno.Text
                .txtpno.BackColor = Color.Aqua
                .txtpno.ReadOnly = True
                .txtpname.Text = Me.txtpname.Text
                .txtpname.BackColor = Color.Aqua
                .txtpname.ReadOnly = True
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class