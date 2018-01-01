Imports MySql.Data.MySqlClient
Public Class LabResults

    Private Sub LabResults_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectDB()
        Dim adapter As New MySqlDataAdapter
        Dim ds As New DataSet1
        adapter.SelectCommand = New MySqlCommand("select PatientNO,Patient_Name,Lab_Results,Diagnosis,Edate from outpatientlabresult", conn)
        adapter.Fill(ds.Tables(0))
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Lab.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()

        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1_Lab_Results", ds.Tables(0)))

        ReportViewer1.DocumentMapCollapsed = True

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class