Imports MySql.Data.MySqlClient
Public Class Pending_Patients

    Private Sub Pending_Patients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LvLoadadmit()
    End Sub
    Private Sub LvLoadadmit()
        Try
            Dim STT As String = "NT"
            sql = "SELECT PatientNO,PName,Age,Gender,Location,Tel,Pay_Mode FROM outpatregistration WHERE Status = '" & STT & "'"
            connectDB()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            ListView1.Items.Clear()
            Dim x As ListViewItem

            Do While dr.Read = True
                x = New ListViewItem(dr("PatientNO").ToString)
                x.SubItems.Add(dr("PName"))
                x.SubItems.Add(dr("Age"))
                x.SubItems.Add(dr("Gender"))
                x.SubItems.Add(dr("Location"))
                x.SubItems.Add(dr("Tel"))
                x.SubItems.Add(dr("Pay_Mode"))
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()

        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class