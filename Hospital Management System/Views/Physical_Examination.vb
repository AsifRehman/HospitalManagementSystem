Imports MySql.Data.MySqlClient
Public Class Physical_Examination

    Private Sub Physical_Examination_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Filldg()
        count()
    End Sub
    Sub count()
        connectDB()
        Try

            Dim nqt As Integer
            sql = " select count(PatientNO) as  TT  from outpattreatment "
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
            sql = "select Entry_Date,PatientNO,Patient_Name,Age,Complains,History,LabInvestigation,Diagnosis,NextReview from outpattreatment order by Entry_Date  "
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
            sql = "select PatientNO,Patient_Name,Age,Compains,History,LabInvestigation,impression,NextReview,Entry_Date from outpattreatment  where  Patient_Name  like '" & txtsearch.Text & "%'"
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