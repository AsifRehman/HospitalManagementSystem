Imports MySql.Data.MySqlClient
Public Class testentry
    Dim dr As MySqlDataReader
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        connectDB()

        If txttestname.Text = "" Then
            MsgBox("Test Name is empty", MsgBoxStyle.Critical)
            txttestname.Focus()
        ElseIf txtcharges.Text = "" Then
            MsgBox("Charges field is empty", MsgBoxStyle.Critical)
            txtcharges.Focus()

        Else
            sql = "Insert into labtest(TestName,Duration,Charges,Edate) values('" & txttestname.Text & "','" & txtduration.Text & "','" & txtcharges.Text & "', '" & DateTime.Today & " ')"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            filltestEntry()
            txttestname.Text = ""
            txtcharges.Text = ""
            txtduration.Text = ""
        End If
        ' dr.Dispose()
        conn.Close()
    End Sub

    Private Sub testentry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        filltestEntry()
    End Sub
    Sub filltestEntry()
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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If lblid.Text = "id" Then
            MsgBox("you have not selected any record", MsgBoxStyle.Critical)

        ElseIf txttestname.Text = "" Then
            MsgBox("Test Name is empty", MsgBoxStyle.Critical)
            txttestname.Focus()


        Else
            connectDB()
            Dim cmd As New MySqlCommand
            '  ,,,,,,,Charges
            sql = "update labtest set TestName='" & txttestname.Text & "',Duration='" & txtduration.Text & "',Charges= '" & txtcharges.Text & "' where ID= '" & lblid.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            MessageBox.Show("Data Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            filltestEntry()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
        Me.lblid.Text = DataGridView1.Item(0, e.RowIndex).Value
        Me.txttestname.Text = DataGridView1.Item(1, e.RowIndex).Value
        'Me.txttestname.ReadOnly = True
        Me.txttestname.BackColor = Color.Aqua
        Me.txtduration.Text = DataGridView1.Item(2, e.RowIndex).Value
        'Me.txtduration.ReadOnly = True
        Me.txtcharges.Text = DataGridView1.Item(3, e.RowIndex).Value
        'Me.txtcharges.ReadOnly = True
  
        'btnSave.Visible = False

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select ID,TestName,Duration,Charges from labtest where TestName like '" & TextBox6.Text & "%'"
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