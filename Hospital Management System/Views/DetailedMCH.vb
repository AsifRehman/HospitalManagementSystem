Imports MySql.Data.MySqlClient
Public Class DetailedMCH

    Private Sub DetailedMCH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select Vaccine_Name from imm_vaccine where PatientNo= '" & lblpno.Text & "'  and Entry_Date= '" & lbldate.Text & "' order by Vaccine_Name  "
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