
Imports MySql.Data.MySqlClient

Public Class FrmFpMethods_Entry

    Private Sub AutogenDrgID()
        Try
            Dim number As Double
            number = "1"
            sql = "SELECT F_ID FROM tblfp Order By F_ID Desc"
            connectDB()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                txtpid.Text = dr("F_ID") + 1
            Else
                txtpid.Text = number
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            'conn.Close()
        End Try
    End Sub
    Sub fillProcedure()
        connectDB()
        RefreshDB()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsourse As New BindingSource
        Try
            Dim query As String
            query = "select F_ID,Name,Cost from tblFp "
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


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        connectDB()

        If txtname.Text = "" Then
            MsgBox("Test Name is empty", MsgBoxStyle.Critical)
            txtname.Focus()
        ElseIf txtcost.Text = "" Then
            MsgBox("Charges field is empty", MsgBoxStyle.Critical)
            txtcost.Focus()

        Else
            sql = "Insert into tblFp(F_ID,Name,Cost) values('" & txtpid.Text & "','" & txtname.Text & "','" & txtcost.Text & "')"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            fillProcedure()
            txtcost.Text = ""
            txtname.Text = ""
        End If
        AutogenDrgID()
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
        Me.txtpid.Text = DataGridView1.Item(0, e.RowIndex).Value
        Me.txtname.Text = DataGridView1.Item(1, e.RowIndex).Value
        Me.txtname.BackColor = Color.Aqua
        Me.txtcost.Text = DataGridView1.Item(2, e.RowIndex).Value
        btnSave.Visible = False
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If txtpid.Text = "id" Then
            MsgBox("you have not selected any record", MsgBoxStyle.Critical)

        ElseIf txtname.Text = "" Then
            MsgBox("Procedure Name is empty", MsgBoxStyle.Critical)
            txtname.Focus()

        Else
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "update tblFp set Name='" & txtname.Text & "',Cost='" & txtcost.Text & "' where F_ID= '" & txtpid.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            MessageBox.Show("Data Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            fillProcedure()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmFpMethods_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillProcedure()
        AutogenDrgID()
    End Sub
End Class