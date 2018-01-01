Imports MySql.Data.MySqlClient
Public Class IndividualRpt
    Dim y As Integer
    Private Sub IndividualRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            lblDate.Text = DateTime.Today
            lbluser.Text = Main.Text
            conn.Close()
            LoadReceiptInfo()
            LoadItemstoDatagrid()
            Loadprofile()
            cmdprint_Click(sender, e)
        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub LoadItemstoDatagrid()
        connectDB()

        Dim y As Integer
        Try

            'fillDG()
            sql = "Select MedName from outpatfinaldrugbill where PatientNo = '" & Me.lblpatNo.Text & "' and Entry_Date = '" & Format(DateTime.Today, "yyyy-MM-dd") & "'"
            y = 0
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            dgw.Rows.Clear()
            Do While READER.Read = True
                dgw.Rows.Add(READER("MedName"))
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
    Private Sub Loadprofile()
        Try
            dr.Close()
            sql = "SELECT * from outpatregistration where PatientNO = '" & Me.lblpatNo.Text & "'"
            connectDB()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                lblres.Text = dr("Location")

            Else
                MsgBox("Residence not available", MsgBoxStyle.Critical)

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
    Private Sub LoadReceiptInfo()
        Try
            dr.Close()

            sql = "SELECT * from outpattreatment where PatientNO = '" & Me.lblpatNo.Text & "' and Entry_Date = '" & Format(DateTime.Today, "yyyy-MM-dd") & "'"
            connectDB()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then

                lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
                lblTime.Text = Date.Now.ToString("hh:mm:ss")

                lblpname.Text = dr("Patient_Name")
                lbltell.Text = dr("Tel")
                lblages.Text = dr("Age")
                lblsex.Text = dr("Gender")
                lblComplains.Text = dr("Complains")
                lblages.Text = dr("Age")
                lblHistory.Text = dr("History")
                lblExam.Text = dr("LabInvestigation")
                lblImpress.Text = dr("Diagnosis")
                ''lblLabinv.Text = dr("LabInvestigation")

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