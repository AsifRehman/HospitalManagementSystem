Imports MySql.Data.MySqlClient
Public Class Vitals

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        connectDB()

        connectDB()

        If txtpno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtpno.Focus()

        Else
            sql = "Insert into outpatientvitals(PatientNo,PatientName,Temp,BP,RR,PR,Weight,Edate) values('" & txtpno.Text & "','" & txtpname.Text & "','" & txttemp.Text & "','" & txtbp.Text & "','" & txtrr.Text & "','" & txtpr.Text & "','" & txtweight.Text & "','" & Format(DateTime.Today, "yyyy-MM-dd") & "')"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call clear()
        End If
        dr.Dispose()
        conn.Close()

    End Sub
    Sub clear()
        txtpno.Text = ""
        txtpname.Text = ""
        txttemp.Text = ""
        txtbp.Text = ""
        txtrr.Text = ""
        txtweight.Text = ""
        txtpr.Text = ""
        txtage.Text = ""
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class