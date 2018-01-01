Imports MySql.Data.MySqlClient
Public Class Counter_Sale
    Dim prevB As Integer
    Dim newB As Integer

    Private Sub Counter_Sale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If lblid.Text = "." Then
            lblid.Text = "1"
        End If
        AutogenSaleid()
        fillCounterSaleCombo()
        AutogenSaleid()
    End Sub
    Sub AutogenSaleid()
        connectDB()
        Try

            Dim number As Double
            Dim COMMAND As New MySqlCommand
            sql = "select max(SaleID) FROM counterdrugtotals ORDER BY SaleID DESC "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = False Then
                number = 1
                lblid.Text = number
            Else
                number = Val(dr.GetString(0))

                lblid.Text = number + 1
            End If

            COMMAND.Dispose()
        Catch ex As Exception
            'MsgBox(ex.ToString)
        Finally

            conn.Close()
        End Try
    End Sub

    Private Sub cbodrgname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim READER As MySqlDataReader
        'Dim sql As String
        'Try
        '    connectDB()
        '    'Dim Lbqst As String
        '    'Lbqst = "YES"
        '    sql = "select DrugCode,Selling_Price from drugentry where Drug_Name = '" & txtdName.Text & "' "
        '    cmd = New MySqlCommand(sql, conn)
        '    READER = cmd.ExecuteReader
        '    While READER.Read
        '        txtdrugcode.Text = READER.GetString("DrugCode")
        '        txtdrugcode.ReadOnly = True
        '        txtprice.Text = READER.GetString("Selling_Price")
        '        txtprice.ReadOnly = True

        '    End While
        '    conn.Close()
        'Catch ex As MySqlException
        '    MsgBox(ex.ToString)
        'Finally
        '    conn.Dispose()
        'End Try

    End Sub
    Private Function Totals() As Double
        'On Error Resume Next
        Dim total As Double = 0
        Dim i As Integer = 0

        For i = 0 To DataGridView1.Rows.Count - 1
            total = total + Convert.ToDouble(DataGridView1.Rows(i).Cells("Totals").Value)
        Next i

        Return total
    End Function

    Sub checkstock()
        connectDB()
        Dim query As String
        Dim dr As MySqlDataReader
        Dim cmdd As New MySqlCommand
        query = "select Quantity from drugentry where DrugCode = '" & txtdrugcode.Text & "'"
        cmdd = New MySqlCommand(query, conn)
        dr = cmdd.ExecuteReader
        If dr.Read Then
            prevB = dr.GetString("Quantity")
            If Val(txtqty.Text) > prevB Then
                MsgBox("No Enough stock. Remaining stock is:" & prevB, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "excess")
                'txtqnty.Text = ""
                txtqty.Select()
                txtqty.BackColor = Color.Tomato
                btnadd.Visible = False
            Else
                txtqty.BackColor = Color.White
                btnadd.Visible = True
            End If
        Else

        End If

        conn.Close()
        dr.Close()
    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        checkstock()
        txttotal.Text = Val(txtprice.Text) * Val(txtqty.Text)
    End Sub

    Private Sub txtprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprice.TextChanged
        txttotal.Text = Val(txtprice.Text) * Val(txtqty.Text)
    End Sub


 
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        connectDB()

        If lblid.Text = "." Then
            MsgBox("No sales record to save", MsgBoxStyle.Critical)
            lblid.Focus()
        ElseIf txtTT.Text = "" Then
            MsgBox("Totals Field is empty", MsgBoxStyle.Critical)
            txtTT.Focus()
        ElseIf txtcash.Text = "" Then
            MsgBox("Cash field is empty", MsgBoxStyle.Critical)
            txtcash.Focus()
        ElseIf txtbal.Text = "" Then
            MsgBox("Balance field is empty", MsgBoxStyle.Critical)
            txtbal.Focus()

        Else
            sql = "Insert into counterdrugtotals(SaleID,Totals,Paid,Balance,Edate) values('" & lblid.Text & "','" & txtTT.Text & "','" & txtcash.Text & "','" & txtbal.Text & "','" & Format(DateTime.Today, "yyyy-MM-dd") & "')"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Call clear()
        End If
        dr.Dispose()
        conn.Close()
        'With CounterReceipt
        '    .lblrecNO.Text = Me.lblid.Text
        '    '.lblrecNO.Text = Val(Me.lblid.Text)

        '    .ShowDialog()
        'End With
        Call clear()
        AutogenSaleid()
    End Sub
    Sub clear()
        txtTT.Text = ""
        txtcash.Text = ""
        txtbal.Text = ""
        lblid.Text = "."
        txtdrugcode.Text = ""
        txtdName.Text = ""
        txtprice.Text = ""
        txtqty.Text = ""
        txttotal.Text = ""
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        connectDB()

        Dim stt As String
        Dim query As String
        stt = "NT"
        query = "Insert into counterdrugbill(SaleID,DrugID,DrugName,Price,Quantity,Totals,EDate) values('" & lblid.Text & "','" & txtdrugcode.Text & "','" & txtdName.Text & "','" & txtprice.Text & "','" & txtqty.Text & "','" & txttotal.Text & "','" & Format(DateTime.Today, "yyyy-MM-dd") & "')"

        If txtdrugcode.Text = "" Then
            MsgBox("No drug selected", MsgBoxStyle.Critical)
            txtdrugcode.Focus()
        ElseIf txtqty.Text = "" Then
            MsgBox("Quantity field is empty", MsgBoxStyle.Critical)
            txtqty.Focus()


        Else
            sql = "select * from counterdrugbill where DrugID= '" & txtdrugcode.Text & "' and SaleID = '" & lblid.Text & "'  and EDate = '" & DateTime.Today & "'  "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            If dr.Read = False Then
                cmd = New MySqlCommand(query, conn)
                dr.Close()
                cmd.ExecuteNonQuery()
                fillgrid()
                compute()
                Me.txtTT.Text = Totals()
                'txtmedname.Clear()
                'txtdays.Clear()
                MessageBox.Show("prescription Successfully completed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtdrugcode.Text = ""
                txtdName.Text = ""
                txtprice.Text = ""
                txtqty.Text = ""
                txttotal.Text = ""
                AutogenSaleid()
            Else
                MessageBox.Show("Record already exist for this client", "Dublicate", MessageBoxButtons.OK, MessageBoxIcon.Error)
                fillgrid()
                Me.txtTT.Text = Totals()
            End If

            dr.Dispose()
            conn.Close()
        End If

    End Sub
    Private Sub compute()
        connectDB()
        Dim query As String
        Dim dr As MySqlDataReader
        Dim cmdd As New MySqlCommand
        query = "select Quantity from drugentry where DrugCode = '" & txtdrugcode.Text & "'"
        cmdd = New MySqlCommand(query, conn)
        dr = cmdd.ExecuteReader

        If dr.Read Then
            prevB = dr.GetString("Quantity")
        End If

        If Val(txtqty.Text) = 0 Or txtqty.Text = "" Then
            MsgBox("You cannot sell ZERO quantity", MsgBoxStyle.Critical)
            txtqty.Focus()

        Else

            newB = prevB - Val(txtqty.Text)
            dr.Close()

            sql = "update drugentry set Quantity = '" & newB & "'  where DrugCode = '" & txtdrugcode.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            conn.Close()
            dr.Close()
        End If


    End Sub
    Sub fillgrid()
        connectDB()
        RefreshDB()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsourse As New BindingSource
        Try
            Dim query As String
            query = "select SaleID,DrugID,DrugName,Price,Quantity,Totals,EDate from  counterdrugbill where  SaleID = '" & lblid.Text & "' and  EDate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "'"
            COMMAND = New MySqlCommand(query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bsourse.DataSource = dbdataset
            DataGridView1.DataSource = bsourse
            SDA.Update(dbdataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub txtTT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTT.TextChanged
        txtbal.Text = Val(txtTT.Text) - Val(txtcash.Text)
    End Sub

    Private Sub txtcash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcash.TextChanged
        txtbal.Text = Val(txtTT.Text) - Val(txtcash.Text)
    End Sub


    Private Sub btnqpi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnqpi.Click
        QuickPickDrug.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub txtdrugcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdrugcode.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtdrugcode.Text = "" Then
            MsgBox("Select a record to delete", MsgBoxStyle.Critical)
            txtdrugcode.Focus()
        Else
            connectDB()
            Dim cmd As New MySqlCommand
            Dim reply As String
            sql = "Delete from counterdrugbill where DrugID= '" & txtdrugcode.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            reply = MsgBox("Are you sure you want to delete this record???", MsgBoxStyle.YesNoCancel, "Delete")
            If reply = MsgBoxResult.Yes Then
                dr = cmd.ExecuteReader
                MessageBox.Show("Data Delete Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                fillgrid()
                txtdrugcode.Text = ""
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
        Me.txtdrugcode.Text = DataGridView1.Item(1, e.RowIndex).Value
        Me.txtdName.Text = DataGridView1.Item(2, e.RowIndex).Value
        Me.txtprice.Text = DataGridView1.Item(3, e.RowIndex).Value
        Me.txtqty.Text = DataGridView1.Item(4, e.RowIndex).Value
        Me.txttotal.Text = DataGridView1.Item(5, e.RowIndex).Value
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class