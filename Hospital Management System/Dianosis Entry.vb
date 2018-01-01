Imports MySql.Data.MySqlClient

Public Class Dianosis_Entry
    Dim dr As MySqlDataReader
   
   
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        connectDB()

        If txtcode.Text = "" Then
            MsgBox("diagnosis code is empty", MsgBoxStyle.Critical)
            txtcode.Focus()
        ElseIf txtdiag.Text = "" Then
            MsgBox("diagnosis field is empty", MsgBoxStyle.Critical)
            txtdiag.Focus()
        ElseIf txtsubdiag.Text = "" Then
            MsgBox("sub diagnosis field is empty", MsgBoxStyle.Critical)
            txtsubdiag.Focus()

        Else
            sql = "Insert into diagnosis(Code,Diagnosis,Sub_diag) values('" & txtcode.Text & "','" & txtdiag.Text & "','" & txtsubdiag.Text & "')"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'filltestEntry()
            txtcode.Text = ""
            txtdiag.Text = ""
            txtsubdiag.Text = ""
        End If
        ' dr.Dispose()
        conn.Close()
    End Sub
End Class