Imports MySql.Data.MySqlClient
Public Class Outside_Prescription

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        connectDB()

        connectDB()

        If txtpno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtpno.Focus()

        Else
            sql = "Insert into OutsidePresc(PatientNo,PatientName,MedName, Entry_Date) values('" & txtpno.Text & "','" & txtpname.Text & "','" & txtmedname.Text & "','" & DateTime.Today & "')"

            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call clear()
        End If
        dr.Dispose()
        conn.Close()
        Me.Close()
    End Sub
    Sub clear()
        txtmedname.Text = ""
        txtpno.Text = ""
        txtpname.Text = ""
    End Sub
End Class