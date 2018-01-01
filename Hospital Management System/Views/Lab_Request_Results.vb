Imports MySql.Data.MySqlClient
Public Class Lab_Request_Results

    Private Sub Lab_Request_Results_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Filldg()
        count()
    End Sub
    Sub count()
        connectDB()
        Try

            Dim nqt As Integer
            sql = " select count(outpatientlabresult.PatientNo) as  TT  from outpatientlabrequest,outpatientlabresult where outpatientlabrequest.PatientNo = outpatientlabresult.PatientNo "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                nqt = dr("TT".ToString)
            End While
            RefreshDB()
            lblNo.Text = nqt

        Catch ex As MySqlException
            MsgBox(ex.ToString)

        Finally
            cmd.Dispose()
            conn.Close()
        End Try


    End Sub
    Sub Filldg()

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select outpatientlabrequest.Edate,outpatientlabrequest.PatientNo,outpatientlabrequest.Patient_Name,outpatientlabrequest.TestName,outpatientlabresult.Lab_Results from outpatientlabrequest,outpatientlabresult where outpatientlabrequest.PatientNo = outpatientlabresult.PatientNo order by Edate  "
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

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "Select Edate,LabNo,PatientNo,Patient_Name,Lab_Results,Diagnosis from outpatientlabresult where Patient_Name like '" & txtsearch.Text & "%'order By Patient_Name "
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