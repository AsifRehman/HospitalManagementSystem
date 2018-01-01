Imports MySql.Data.MySqlClient

Public Class Monthly_Payment_View
    Dim Y As Integer
    Private Sub Monthly_Payment_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = DateTime.Today
        Filldg()
    End Sub
    Private Function Totals() As Double
        'On Error Resume Next
        Dim Total As Double = 0
        Dim i As Integer = 0

        For i = 0 To dgw.Rows.Count - 1
            Total = Total + Convert.ToDouble(dgw.Rows(i).Cells("Totals").Value)
        Next i
        Return Total
    End Function
    Sub Filldg()

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "SELECT PatientNo,Patient_Name,drug,FP,MCH,Others,TotalBill,Paid,Balance,PaymentDate FROM outpatpayments order by PaymentDate "
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            dgw.DataSource = bs
            da.Update(ds)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conn.Dispose()

        End Try
    End Sub
    Private Sub LoadItemstoDatagrid()
        Dim totStockOut As Double
        Dim totSales As Double
        'found = True
        Try

            ' sql = "SELECT outpatientlabrequest.PatientNO, outpatientlabrequest.Patient_Name, outpatientlabrequest.TestName, outpatientlabresult.Lab_Results, outpatientlabrequest.Charges,outpatientlabrequest.Edate FROM outpatientlabrequest,outpatientlabresult WHERE outpatientlabrequest.PatientNO = outpatientlabresult.PatientNO AND  Edate BETWEEN '" & Me.DateTimePicker1.Value.ToString("MM/dd/yyyy") & "' AND  '" & Me.DateTimePicker2.Value.ToString("MM/dd/yyyy") & "' ORDER By Edate"
            sql = "SELECT PatientNo,Patient_Name,drug,FP,MCH,Others,TotalBill,Paid,Balance,PaymentDate FROM outpatpayments WHERE PaymentDate BETWEEN '" & Me.DateTimePicker1.Value.ToString("dd-MMM-yy") & "' AND  '" & Me.DateTimePicker2.Value.ToString("dd-MMM-yy") & "' ORDER By PaymentDate"


            connectDB()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            dgw.Rows.Clear()
            totStockOut = 0.0
            totSales = 0.0
            Y = 0
            'If dr.Read = True Then
            'found = True
            Do While dr.Read = True
                dgw.Rows.Add(dr("PatientNO"), dr("Patient_Name"), dr("drug"), dr("FP"), dr("MCH"), dr("Others"), dr("TotalBill"), dr("Paid"), dr("Balance"), dr("PaymentDate"))
                Y += 17
                'totStockOut += dr("totalQuantity")
                'totSales += (dr("ItemPrice") * dr("TotalQuantity"))
            Loop
            dgw.Height += Y
            'lblTotalStocksIn.Text = totStockOut
            'lblSales.Text = Format(totSales, "#,##0.00")
            'Panel3.Location = New Point(Me.Panel3.Location.X, Me.Panel3.Location.Y + y)
            'Else
            'found = False
            'MsgBox("No record found for your query", MsgBoxStyle.Critical, "Null record")
            'Exit Sub

            'End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If found = True Then
        lblfrom.Text = DateTimePicker1.Text
        lblto.Text = DateTimePicker2.Text
        LoadItemstoDatagrid()
        Count()
        PrintDialog1.Document = Me.PrintDocument1
        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            Panel1.Height += Y
            PrintDocument1.Print()
            'Me.Close()
        End If
        'Else
        'MsgBox("No record found for your query", MsgBoxStyle.Critical, "Null record")
        'Exit Sub
        'End If
    End Sub
    Sub Count()
        connectDB()
        Dim READER As MySqlDataReader
        Dim cmd As New MySqlCommand
        Dim sql As String
        Dim stt As Integer
        Try

            
            sql = "Select COUNT(PatientNO) as TNO FROM outpatpayments WHERE PaymentDate BETWEEN '" & Me.DateTimePicker1.Value.ToString("dd-MMM-yy") & "' AND  '" & Me.DateTimePicker2.Value.ToString("dd-MMM-yy") & "' ORDER By PaymentDate"
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader

            If READER.Read = False Then
                MsgBox("No record found", MsgBoxStyle.Critical)
                lblNo.Text = 0
            Else
                Try
                    stt = READER.GetString("TNO")
                Catch ex As Exception
                    MsgBox("No record found", MsgBoxStyle.Critical)
                End Try


            End If

            lblNo.Text = Format(stt, "#,###.00")
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            disconnect()
            ' READER.Close()
        End Try

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)

        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))

        e.Graphics.DrawImage(bm, 0, 40)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub
End Class