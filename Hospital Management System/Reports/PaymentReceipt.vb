Imports MySql.Data.MySqlClient
Public Class PaymentReceipt
    Dim READER As MySqlDataReader
    Dim READER1 As MySqlDataReader
    Dim cmd1 As New MySqlCommand
    Dim y As Integer
    Private Sub PaymentReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'lblSubtotal.Text = Val(lblTotal.Text) - Val(lblVat.Text)
            cmd1.Dispose()
            lbluser.Text = Main.Text
            conn.Close()
            LoadReceiptInfo()

            cmdprint_Click(sender, e)
        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub LoadReceiptInfo()
        Try
            dr.Close()

            sql = "SELECT * from outpatpayments where PatientNO = '" & Me.lblpno.Text & "'"
            connectDB()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then

                'lblrecNO.Text = dr("RecNo")
                lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
                lblTime.Text = Date.Now.ToString("hh:mm:ss")
                lblpno.Text = dr("PatientNO")
                'lblpname.Text = dr("Patient_Name")
                lblConsultation.Text = dr("Consult_Fee")
                lbldrg.Text = FormatNumber(dr("drug"))
                lblFP.Text = FormatNumber(dr("FP"))
                lblmch.Text = FormatNumber(dr("MCH"))
                lblLab.Text = FormatNumber(dr("Lab"))
                lblothers.Text = FormatNumber(dr("Others"))
                lblTotal.Text = FormatNumber(dr("TotalBill"))
                lblCash.Text = FormatNumber(dr("Paid"))
                lblChange.Text = FormatNumber(dr("Balance"))

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

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        'PrintDocument1.Print()
        'Me.Close()
        PrintDialog1.Document = Me.PrintDocument1
        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            Panel1.Height += y
            PrintDocument1.Print()
            Me.Close()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1

    End Sub
End Class