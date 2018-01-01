Imports MySql.Data.MySqlClient
Public Class Patient_Report

    Private Sub Patient_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillPatientReport()
    End Sub

    Private Sub cbopno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbopno.SelectedIndexChanged
        Dim READER As MySqlDataReader
        Dim sql As String
        Try
            connectDB()
            'Dim Lbqst As String
            'Lbqst = "YES"
            sql = "select * from outpattreatment where PatientNo = '" & cbopno.Text & "' and  Entry_Date = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' "
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            While READER.Read
                txtpname.Text = READER.GetString("Patient_Name")
                txtpname.ReadOnly = True
                txtchief.Text = READER.GetString("Complains")
                txtchief.ReadOnly = True
                txthistory.Text = READER.GetString("History")
                txthistory.ReadOnly = True
                txtexam.Text = READER.GetString("LabInvestigation")
                txtexam.ReadOnly = True
                txtexpres.Text = READER.GetString("Diagnosis")
                txtexpres.ReadOnly = True

            End While
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conn.Dispose()
        End Try

    End Sub
    Private Sub clear()
        txtpname.Text = ""
        txtchief.Text = ""
        txthistory.Text = ""
        txtexam.Text = ""
        txtexpres.Text = ""
        fillPatientReport()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click

        With IndividualRpt
            .lblpatNo.Text = Me.cbopno.Text

            .ShowDialog()
        End With
        Call clear()

    End Sub
End Class