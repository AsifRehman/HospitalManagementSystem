Imports MySql.Data.MySqlClient
Public Class LabReceipt
    Dim y As Integer
    Private Sub LabReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'lblSubtotal.Text = Val(lblTotal.Text) - Val(lblVat.Text)
            ' cmd1.Dispose()
            lbluser.Text = Main.Text
            conn.Close()
            LoadReceiptInfo()
            LoadItemstoDatagrid()
            'cmdprint_Click(sender, e)
        Catch ex As MySqlException
            MsgBox(ex.Message)


        End Try
    End Sub
    Private Sub LoadReceiptInfo()
        Try
            dr.Close()
            Dim stt As String
            stt = "P"
            sql = "Select * from outpatientlabrequest  where PatientNO= '" & lblrecNO.Text & "' and Status='" & stt & "'"
            connectDB()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then

                'lblInvoice.Text = dr("SaleID")
                lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
                lblTime.Text = Date.Now.ToString("hh:mm:ss")
                'lblTotal.Text = FormatNumber(dr("Totals"))
                'lblCash.Text = FormatNumber(dr("Paid"))

                'LoadItemstoDatagrid()

            Else
                MsgBox("No records found from the sales repository", MsgBoxStyle.Critical)

            End If
            cmd.Dispose()
            conn.Close()
            dr.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
            dr.Close()
        End Try
    End Sub
    Private Sub LoadItemstoDatagrid()
        connectDB()

        Dim y As Integer
        Try
            Dim stt As String
            stt = "P"
            'fillDG()
            sql = "Select TestNO,TestName,Charges from outpatientlabrequest  where PatientNO= '" & lblrecNO.Text & "' and Status='" & stt & "'"
            y = 0
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            dgw.Rows.Clear()
            Do While READER.Read = True
                dgw.Rows.Add(READER("TestNO"), READER("TestName"), READER("Charges"))
                y += 17
            Loop
            dgw.Height += y

            Panel3.Location = New Point(Me.Panel3.Location.X, Me.Panel3.Location.Y + y)


        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
            dr.Close()
        End Try
    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        'PrintDocument1.Print()
        'Me.Close()
        'Payment.Close()

        'lblfrom.Text = DateTimePicker1.Text
        'lblto.Text = DateTimePicker2.Text
        'LoadItemstoDatagrid()
        'Count()
        PrintDialog1.Document = Me.PrintDocument1
        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            Panel1.Height += y
            PrintDocument1.Print()
            Me.Close()
        End If







    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        'Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        'e.Graphics.DrawImage(bm, 0, 0)
        'Dim aPS As New PageSetupDialog
        'aPS.Document = PrintDocument1

        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)

        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))

        e.Graphics.DrawImage(bm, 0, 40)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub

    Private Sub lblOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class