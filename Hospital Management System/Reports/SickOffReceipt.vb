Imports MySql.Data.MySqlClient
Public Class SickOffReceipt

    Private Sub SickOffReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            '' cmd1.Dispose()
            lbluser.Text = Main.Text
            conn.Close()
            LoadReceiptInfo()
            ''LoadItemstoDatagrid()
            ''Loadprofile()
            cmdprint_Click(sender, e)
        Catch ex As MySqlException
            MsgBox(ex.Message)

        End Try

    End Sub
    'Private Sub Loadprofile()
    '    Try
    '        dr.Close()
    '        sql = "SELECT * from outpatregistration where PatientNO = '" & Me.lblPNO.Text & "' and Entry_Date = '" & DateTime.Today & "'"
    '        connectDB()
    '        cmd = New MySqlCommand(sql, conn)
    '        dr = cmd.ExecuteReader

    '        If dr.Read = True Then
    '            lblsex.Text = dr("Gender")
    '            lblres.Text = dr("Location")
    '            lbltell.Text = dr("Tel")
    '        Else
    '            MsgBox("No records found from the sales repository", MsgBoxStyle.Critical)

    '        End If
    '        cmd.Dispose()
    '        conn.Close()
    '        dr.Close()
    '    Catch ex As MySqlException
    '        MsgBox(ex.ToString)
    '    Finally
    '        cmd.Dispose()
    '        conn.Close()
    '        dr.Close()
    '    End Try
    'End Sub
    Private Sub LoadReceiptInfo()
        Try
            dr.Close()

            sql = "SELECT * from sick_off where PatientNO = '" & Me.lblPNO.Text & "'"
            connectDB()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then

                lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
                lblTime.Text = Date.Now.ToString("hh:mm:ss")

                lblpname.Text = dr("PName")
                lblComplains.Text = dr("Compains")
                lblres.Text = dr("Location")
                lblsex.Text = dr("Gender")
                lbltell.Text = dr("Tel")
                lblages.Text = dr("Age")
                lblHistory.Text = dr("History")
                lblExam.Text = dr("Examination")
                lblImpress.Text = dr("impression")
                lblLabinv.Text = dr("LabInvestigation")

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
    'Private Sub LoadItemstoDatagrid()
    '    connectDB()

    '    Dim y As Integer
    '    Try

    '        'fillDG()
    '        sql = "Select MedName from outpatfinaldrugbill where PatientNo = '" & Me.lblPNO.Text & "' and Entry_Date = '" & DateTime.Today & "'"

    '        cmd = New MySqlCommand(sql, conn)
    '        READER = cmd.ExecuteReader
    '        dgw.Rows.Clear()
    '        Do While READER.Read = True
    '            dgw.Rows.Add(READER("MedName"))
    '            dgw.Height += 19
    '            y += 25
    '        Loop

    '        ''Panel2.Location = New Point(18, 287 + y)
    '        Panel1.Height += y
    '        Me.Height += y
    '        dgw.Height -= 20

    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    Finally
    '        cmd.Dispose()
    '        conn.Close()
    '        dr.Close()
    '    End Try
    'End Sub
    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        PrintDocument1.Print()
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class