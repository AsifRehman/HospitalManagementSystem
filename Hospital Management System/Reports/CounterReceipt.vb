
Imports MySql.Data.MySqlClient
Public Class CounterReceipt
    Dim READER As MySqlDataReader
    Dim READER1 As MySqlDataReader
    Dim cmd1 As New MySqlCommand
    Dim y As Integer

    Private Sub Receipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'lblSubtotal.Text = Val(lblTotal.Text) - Val(lblVat.Text)
            cmd1.Dispose()
            lbluser.Text = Main.Text
            conn.Close()
            LoadReceiptInfo()
            LoadItemstoDatagrid()
            cmdprint_Click(sender, e)
        Catch ex As MySqlException
            MsgBox(ex.Message)


        End Try

    End Sub
    Private Sub LoadItemstoDatagrid()
        connectDB()


        Try

            'fillDG()
            sql = "Select DrugName as Item_Name,Quantity,Price,Totals from counterdrugbill where SaleID = '" & Me.lblrecNO.Text & "'"
            y = 0
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            dgw.Rows.Clear()
            Do While READER.Read = True
                dgw.Rows.Add(READER("Item_Name"), READER("Quantity"), READER("Price"), READER("Totals"))
          
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
    Sub fillDG()
        connectDB()
        RefreshDB()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsourse As New BindingSource
        Try
            Dim query As String
            query = "Select DrugName as Item_Name,Quantity as qty,Totals from counterdrugbill where SaleID = '" & Me.lblrecNO.Text & "'"
            COMMAND = New MySqlCommand(query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bsourse.DataSource = dbdataset
            dgw.DataSource = bsourse
            SDA.Update(dbdataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub LoadReceiptInfo()
        Try
            dr.Close()

            sql = "SELECT * from counterdrugtotals where SaleID = '" & Me.lblrecNO.Text & "'"
            connectDB()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then

                'lblInvoice.Text = dr("SaleID")
                lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
                lblTime.Text = Date.Now.ToString("hh:mm:ss")
                lblTotal.Text = FormatNumber(dr("Totals"))
                lblCash.Text = FormatNumber(dr("Paid"))
                lblChange.Text = FormatNumber(dr("Balance"))
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

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)

        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))

        e.Graphics.DrawImage(bm, 0, 40)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub
    

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgw_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellContentClick

    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        'PrintDocument1.Print()
        'Me.Close()
        'If found = True Then
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
        'Else
        'MsgBox("No record found for your query", MsgBoxStyle.Critical, "Null record")
        'Exit Sub
        'End If
    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class