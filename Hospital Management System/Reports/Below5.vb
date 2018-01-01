Imports MySql.Data.MySqlClient
Public Class Below5

    Private Sub Below5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectDB()
        Dim adapter As New MySqlDataAdapter
        Dim ds As New DataSet1
        adapter.SelectCommand = New MySqlCommand("select PatientNO,Patient_Name,Age,Gender,Tel,Diagnosis,Entry_Date from outpattreatment where  Age  < 5 ", conn)
        adapter.Fill(ds.Tables(0))
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Blw5.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()

        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1_Below5", ds.Tables(0)))

        ReportViewer1.DocumentMapCollapsed = True

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class