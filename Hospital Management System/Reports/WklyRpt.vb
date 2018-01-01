Imports MySql.Data.MySqlClient
Public Class WklyRpt
    Dim y As Integer
    Dim found As Boolean
    Private Sub WklyRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        found = False
    End Sub
    Private Sub LoadItemstoDatagrid()
        Dim totStockOut As Double
        Dim totSales As Double
        'found = True
        Try

            ' sql = "SELECT outpatientlabrequest.PatientNO, outpatientlabrequest.Patient_Name, outpatientlabrequest.TestName, outpatientlabresult.Lab_Results, outpatientlabrequest.Charges,outpatientlabrequest.Edate FROM outpatientlabrequest,outpatientlabresult WHERE outpatientlabrequest.PatientNO = outpatientlabresult.PatientNO AND  Edate BETWEEN '" & Me.DateTimePicker1.Value.ToString("MM/dd/yyyy") & "' AND  '" & Me.DateTimePicker2.Value.ToString("MM/dd/yyyy") & "' ORDER By Edate"
            sql = "SELECT PatientNO,Patient_Name,TestName,Charges,Edate FROM outpatientlabrequest WHERE Edate BETWEEN '" & Me.DateTimePicker1.Value.ToString("dd-MMM-yy") & "' AND  '" & Me.DateTimePicker2.Value.ToString("dd-MMM-yy") & "' ORDER By Edate"


            connectDB()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            dgw.Rows.Clear()
            totStockOut = 0.0
            totSales = 0.0
            y = 0
            'If dr.Read = True Then
            'found = True
            Do While dr.Read = True
                dgw.Rows.Add(dr("PatientNO"), dr("Patient_Name"), dr("TestName"), Format(dr("Charges"), "#,##0.00"), dr("Edate"))
                y += 17
                'totStockOut += dr("totalQuantity")
                'totSales += (dr("ItemPrice") * dr("TotalQuantity"))
            Loop
            dgw.Height += y
            'lblTotalStocksIn.Text = totStockOut
            'lblSales.Text = Format(totSales, "#,##0.00")
            Panel3.Location = New Point(Me.Panel3.Location.X, Me.Panel3.Location.Y + y)
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
    Sub total()
        connectDB()
        Dim READER As MySqlDataReader
        Dim cmd As New MySqlCommand
        Dim sql As String
        Dim stt As Integer
        Try

            'stt = "NF"
            ' connectDB()
            sql = "Select sum(Charges) as Total FROM outpatientlabrequest WHERE Edate BETWEEN '" & Me.DateTimePicker1.Value.ToString("dd-MMM-yy") & "' AND  '" & Me.DateTimePicker2.Value.ToString("dd-MMM-yy") & "' ORDER By Edate"
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader

            If READER.Read = False Then
                MsgBox("No record found", MsgBoxStyle.Critical)
                ' Call clear()
            Else
                Try
                    stt = READER.GetString("Total")
                Catch ex As Exception
                    MsgBox("No record found", MsgBoxStyle.Critical)
                End Try


            End If

            lblcost.Text = Format(stt, "#,##0.00")
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If found = True Then

        LoadItemstoDatagrid()
        total()
        PrintDialog1.Document = Me.PrintDocument1
        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            Panel1.Height += y
            PrintDocument1.Print()
            Me.Close()
        End If
        'Else
        'MsgBox("No record found for your query", MsgBoxStyle.Critical, "Null record")
        'Exit Sub
        'End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class