Imports MySql.Data.MySqlClient
Public Class LabResult

    Private Sub cbopno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbopno.SelectedIndexChanged
        Dim READER As MySqlDataReader
        Dim sql As String
        Try
            connectDB()
            'Dim Lbqst As String
            'Lbqst = "YES"
            sql = "select Patient_Name,Lab_Results from outpatientlabresult where PatientNo = '" & cbopno.Text & "' and  Edate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' "
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            While READER.Read
                txtpname.Text = READER.GetString("Patient_Name")
                txtpname.ReadOnly = True
                txtlresults.Text = READER.GetString("Lab_Results")
                txtlresults.ReadOnly = True

            End While
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conn.Dispose()
        End Try
        'fillTests()
    End Sub
  
    Private Sub LabResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        filllabResult()
    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If cbopno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            cbopno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()

        Else
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "update outpattreatment set Diagnosis='" & txtdiag.Text & "' where PatientNo = '" & cbopno.Text & "' and Entry_Date = '" & Format(DateTime.Today, "yyyy-MM-dd") & "'"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Saved Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)


            With Prescription
                .txtpno.Text = Me.cbopno.Text
                .txtpno.BackColor = Color.Aqua
                .txtpno.ReadOnly = True
                .txtpname.Text = Me.txtpname.Text
                .txtpname.BackColor = Color.Aqua
                .ShowDialog()
            End With
        End If
    End Sub
End Class