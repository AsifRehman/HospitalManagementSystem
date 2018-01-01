Imports MySql.Data.MySqlClient
Public Class frmAddNew_User

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DataGridView1.Rows(e.RowIndex)
            txtuser.Text = row.Cells("UserName").Value.ToString
            txtpass.Text = row.Cells("password").Value.ToString
            cbolevel.Text = row.Cells("Role").Value.ToString
            lblid.Text = row.Cells("Aid").Value.ToString

        End If
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        connectDB()
        Try
            If txtuser.Text = "" Then
                MsgBox("Kindly Enter UserName", MsgBoxStyle.Critical)
                txtuser.Focus()
            ElseIf txtpass.Text = "" Then
                MsgBox("Kindly Enter Password", MsgBoxStyle.Critical)
                txtpass.Focus()
            ElseIf cbolevel.Text = "" Then
                MsgBox("Kindly Enter User Level", MsgBoxStyle.Critical)
                cbolevel.Focus()

            Else
                sql = "insert into login (UserName,password,Role) values('" & txtuser.Text & "','" & txtpass.Text & "','" & cbolevel.Text & "') "
                COMMAND = New MySqlCommand(sql, conn)

                READER = COMMAND.ExecuteReader

                MsgBox("User Added Successfully", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtuser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuser.KeyPress
        'If Not Char.IsLetter(e.KeyChar) Then e.Handled = True 'ignore everything but letter keys

    End Sub
    Sub filldatagrid()
        conn.Close()
        connectDB()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsourse As New BindingSource
        Try
            ' conn.Open()

            Dim query As String
            query = "select Aid,UserName,password,Role from login"
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
    Sub clear()
        txtpass.Clear()
        txtpass.Clear()
        cbolevel.Text = ""
    End Sub

    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click
        connectDB()
        Try

            sql = "update login set UserName ='" & txtuser.Text & "',Role ='" & cbolevel.Text & "',password='" & txtpass.Text & "' where Aid='" & lblid.Text & "'"
            COMMAND = New MySqlCommand(sql, conn)
            READER = COMMAND.ExecuteReader
            MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
            cmdsave.Enabled = True
            clear()
            filldatagrid()
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        filldatagrid()
    End Sub

    Private Sub frmAddNew__User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        If lblid.Text = "" Then
            MsgBox("Select a record to delete", MsgBoxStyle.Critical)
            lblid.Focus()
        Else
            connectDB()
            Dim cmd As New MySqlCommand
            Dim reply As String
            sql = "Delete from login where Aid= '" & lblid.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            reply = MsgBox("Are you sure you want to delete this record???", MsgBoxStyle.YesNoCancel, "Delete")
            If reply = MsgBoxResult.Yes Then
                dr = cmd.ExecuteReader
                MessageBox.Show("Data Delete Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                filldatagrid()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtpass.Text = ""
        txtuser.Text = ""
        cbolevel.Text = ""
    End Sub

    Private Sub txtuser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.TextChanged

    End Sub
End Class