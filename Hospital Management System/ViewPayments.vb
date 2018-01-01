Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class ViewPayments

    Private Sub ViewPayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Getdata()
    End Sub
    Public Sub Getdata()

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select PID, PatientNO,Patient_Name,TotalBill,Paid,Balance,PaymentDate from outpatpayments "
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            dgw.DataSource = bs
            da.Update(ds)
            conn.Close()
            cal()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Totals() As Double
        On Error Resume Next
        Dim Total As Double = 0
        Dim i As Integer = 0

        For i = 0 To dgw.Rows.Count - 1
            Total = Total + Convert.ToDouble(dgw.Rows(i).Cells("Paid").Value)
        Next i
        Return Total
    End Function
    Sub cal()
        lblPyt.Text = Format(Totals, "#,###.##")
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try
            Dim ds As New DataSet
            Dim query As String

            connectDB()
            RefreshDB()
            Dim SDA As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsourse As New BindingSource
            Try
                query = "select PID,PatientNO,Patient_Name,TotalBill,Paid,Balance,PaymentDate from outpatpayments where (PaymentDate  between '" & Dtpfrom.Text & "' and '" & DtpTo.Text & "')"
                COMMAND = New MySqlCommand(query, conn)
                SDA.SelectCommand = COMMAND
                SDA.Fill(dbdataset)
                bsourse.DataSource = dbdataset
                dgw.DataSource = bsourse
                SDA.Update(dbdataset)
                conn.Close()
                cal()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)

            Finally
                conn.Dispose()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        connectDB()

        Dim ds As New DataSet
        Dim query As String
        Dim da As MySqlDataAdapter
        Dim rpt As New ReportDocument


        query = "Select PID,PatientNO,Patient_Name,TotalBill,Paid,Balance,PaymentDate from outpatpayments"
        da = New MySql.Data.MySqlClient.MySqlDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds, "outpatpayments")
        'rpt.SetDataSource(ds)
        'PayRpt.CrystalReportViewer1.ReportSource = rpt
        ''rpt.SummaryInfo.ReportTitle = "Crystal Report1"
        'PayRpt.Text = "Crystal Report1"
        'PayRpt.Show()

        conn.Close()
        'PayRpt.Show()
    End Sub
End Class