
Imports MySql.Data.MySqlClient

Public Class SelfRequest_Results

  

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        
        connectDB()
        If txtpno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtpno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtlabresult.Text = "" Then
            MsgBox("Result field is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtrmks.Text = "" Then
            MsgBox("Diagnosis field is empty", MsgBoxStyle.Critical)
            txtpname.Focus()


        Else
            sql = "Insert into outpatientlabresult(PatientNO,Patient_Name,Lab_Results,Diagnosis,Edate) values('" & txtpno.Text & "','" & txtpname.Text & "','" & txtlabresult.Text & "','" & txtrmks.Text & "', '" & DateTime.Today & "')"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtrmks.Text = ""
            txtpno.Text = ""
            txtpname.Text = ""
            txtlabresult.Text = ""
        End If
        ' dr.Dispose()
        conn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class