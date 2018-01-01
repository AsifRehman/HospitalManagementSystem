Imports MySql.Data.MySqlClient
Public Class Lab_Request

    Private Sub Lab_Request_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillLabtest()
    End Sub
    Sub fillLabtest()
        connectDB()
        RefreshDB()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsourse As New BindingSource
        Try
            Dim query As String
            query = "select ID,TestName,Duration,Charges from labtest "
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


    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
            Me.lblNo.Text = DataGridView1.Item(0, e.RowIndex).Value
            Me.txttestName.Text = DataGridView1.Item(1, e.RowIndex).Value
            Me.txttestName.ReadOnly = True
            Me.txttestName.BackColor = Color.Aqua
            Me.txtchages.Text = DataGridView1.Item(3, e.RowIndex).Value
            Me.txtchages.ReadOnly = True
            'Me.StartPosition = FormStartPosition.CenterScreen
            'Me.Show()
        Catch ex As Exception
            MsgBox("Invalid move. Please select the record", MsgBoxStyle.Critical)
        End Try
        
    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        connectDB()
        Dim query As String
        Dim stt As String
        stt = "NP"
        query = "Insert into outpatientlabrequest(PatientNO,Patient_Name,TestNO,TestName,Charges,Status,Edate) values('" & txtpno.Text & "','" & txtpname.Text & "','" & lblNo.Text & "','" & txttestName.Text & "','" & txtchages.Text & "','" & stt & "','" & Format(DateTime.Today, "yyyy-MM-dd") & "')"
        If txtpno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtpno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()

        Else
            sql = "select * from outpatientlabrequest where PatientNO = '" & txtpno.Text & "' and TestName = '" & txttestName.Text & "' and  Edate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' and Status = '" & stt & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            If dr.Read = False Then
                cmd = New MySqlCommand(query, conn)
                dr.Close()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txttestName.Text = ""
                txtchages.Text = ""
                lblNo.Text = ""
                fillLabRequest()
            Else

                MessageBox.Show("Data Already exist", "Dublicate", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        dr.Dispose()
        conn.Close()
    End Sub
    Sub fillLabRequest()
        connectDB()
        RefreshDB()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsourse As New BindingSource
        Try
            Dim query As String
            Dim stt As String
            stt = "NP"
            query = "select PatientNO,Patient_Name,TestNO,TestName,Charges,Edate from outpatientlabrequest where PatientNO = '" & txtpno.Text & "' and Edate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' and Status = '" & stt & "'"
            COMMAND = New MySqlCommand(query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bsourse.DataSource = dbdataset
            DGv.DataSource = bsourse
            SDA.Update(dbdataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub cmdsend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsend.Click

        MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtage.Clear()
        txtchages.Clear()
        txtpname.Clear()
        txtpno.Clear()
        txttestName.Clear()
        DGv.DataSource = Nothing
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select ID,TestName,Duration,Charges from labtest where TestName like '" & TextBox1.Text & "%'"
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            DataGridView1.DataSource = bs
            da.Update(ds)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conn.Dispose()

        End Try

    End Sub
End Class