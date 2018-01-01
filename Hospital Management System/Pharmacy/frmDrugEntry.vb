Imports MySql.Data.MySqlClient


Public Class frmDrugEntry
    Dim query As String
    Private Sub frmDrugEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Getdata()
        Auto()
    End Sub
    Private Sub Auto()

        Try
            connectDB()
            Dim num As String
            num = "1001"

            sql = " select 	DrugCode from drugentry order by DrugCode desc"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtdID.Text = dr("DrugCode") + 1
                txtdID.ReadOnly = True
            Else
                txtdID.Text = num
                txtdID.ReadOnly = True
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub
    Sub Getdata()
        connectDB()
        Try
            sql = "SELECT DrugCode,Batch,Drug_Name,Strength,Form,Quantity,discount,Buying_Price,Selling_Price,Expiry_Date  FROM drugentry "
            connectDB()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            ListView1.Items.Clear()
            Dim x As ListViewItem

            Do While dr.Read = True
                x = New ListViewItem(dr("DrugCode").ToString)
                x.SubItems.Add(dr("Batch"))
                x.SubItems.Add(dr("Drug_Name"))
                x.SubItems.Add(dr("Strength"))
                x.SubItems.Add(dr("Form"))
                x.SubItems.Add(dr("Quantity"))
                x.SubItems.Add(dr("discount"))
                x.SubItems.Add(dr("Buying_Price"))
                x.SubItems.Add(dr("Selling_Price"))
                x.SubItems.Add(dr("Expiry_Date"))

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            'conn.Close()
        End Try
    End Sub
   
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        connectDB()
        query = "Insert into drugentry(DrugCode,Batch,Drug_Name,Strength,Form,Quantity,discount,Buying_Price,Selling_Price,Expiry_Date) values('" & txtdID.Text & "','" & txtBatch.Text & "','" & txtdrgname.Text & "','" & txtmeasure.Text & "','" & cboform.Text & "','" & txtquantity.Text & "','" & txtdiscount.Text & "' ,'" & txtBprice.Text & "','" & txtSprice.Text & "','" & dtpex.Text & "')"
        If txtquantity.Text = "" Then
            MsgBox("Quantity filed is empty", MsgBoxStyle.Critical)
            txtquantity.Focus()
        ElseIf txtSprice.Text = "" Then
            MsgBox("Silling price field is empty", MsgBoxStyle.Critical)
            txtSprice.Focus()

        Else
            sql = "select * from drugentry where Batch= '" & txtBatch.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            If dr.Read = False Then
                cmd = New MySqlCommand(query, conn)
                dr.Close()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Getdata()
                Call clear()
                Auto()
            Else
                MsgBox("This Record Already exists. Add quantity", MsgBoxStyle.Critical)
            End If
            dr.Dispose()
            conn.Close()
        End If

    End Sub
    Sub clear()

        txtdrgname.Text = ""
        txtBatch.Text = ""
        cboform.Text = ""
        txtmeasure.Text = ""
        txtquantity.Text = ""
        txtBprice.Text = ""
        txtSprice.Text = ""
        txtdiscount.Text = ""
        txtRegPrice.Text = ""
        txtTax.Text = ""
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If txtdID.Text = "" Then
            MsgBox("Drug Number is empty", MsgBoxStyle.Critical)
            txtdID.Focus()
        Else
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "update drugentry  set Batch ='" & txtBatch.Text & "',Drug_Name='" & txtdrgname.Text & "',Strength='" & txtmeasure.Text & "',Form= '" & cboform.Text & "',Quantity= '" & txtquantity.Text & "',discount='" & txtdiscount.Text & "' ,Buying_Price='" & txtBprice.Text & "',Selling_Price='" & txtSprice.Text & "',Expiry_Date='" & dtpex.Text & "' where DrugCode= '" & txtdID.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            'dr = cmd.ExecuteReader
            dr = cmd.ExecuteReader
            MessageBox.Show("Data Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Getdata()
            clear()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        btnSave.Visible = True
        btnUpdate.Visible = False
        cmddelete.Visible = False
    End Sub

    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        If txtdID.Text = "" Then
            MsgBox("Drug Number is empty", MsgBoxStyle.Critical)
            txtdID.Focus()
        ElseIf txtdrgname.Text = "" Then
            MsgBox("Drug Name is empty", MsgBoxStyle.Critical)
            txtdrgname.Focus()
        Else
            connectDB()
            Dim cmd As New MySqlCommand
            Dim reply As String
            sql = "Delete from drugentry where DrugCode= '" & txtdID.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            reply = MsgBox("Are you sure you want to delete this record???", MsgBoxStyle.YesNoCancel, "Delete")
            If reply = MsgBoxResult.Yes Then
                dr = cmd.ExecuteReader
                MessageBox.Show("Data Delete Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Getdata()
                Call clear()

            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            sql = "SELECT DrugCode,Batch,Drug_Name,Form,Quantity,discount,Buying_Price,Selling_Price,Expiry_Date  FROM drugentry WHERE Drug_Name LIKE '" & txtsearch.Text & "%' order By Drug_Name ASC "
            connectDB()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            ListView1.Items.Clear()
            Dim x As ListViewItem
            Do While dr.Read = True
                x = New ListViewItem(dr("DrugCode").ToString)
                x.SubItems.Add(dr("Batch"))
                x.SubItems.Add(dr("Drug_Name"))
                x.SubItems.Add(dr("Strength"))
                x.SubItems.Add(dr("Form"))
                x.SubItems.Add(dr("Quantity"))
                x.SubItems.Add(dr("discount"))
                x.SubItems.Add(dr("Buying_Price"))
                x.SubItems.Add(dr("Selling_Price"))
                x.SubItems.Add(dr("Expiry_Date")) 
                ListView1.Items.Add(x)

                'ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            'conn.Dispose()
            'conn.Close()
        End Try


      

    End Sub

    Private Sub txtBprice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBprice.TextChanged
        txtSprice.Text = Val(txtBprice.Text) * 1.33 + Val(txtttax.Text)
        txtttax.Text = Val(txtBprice.Text) * Val(txtTax.Text) / 100

    End Sub

    Private Sub txtTax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTax.TextChanged
        txtttax.Text = Val(txtBprice.Text) * Val(txtTax.Text) / 100
        txtSprice.Text = Val(txtBprice.Text) * 1.33 + Val(txtttax.Text)

    End Sub

    Private Sub rdoDiscount_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDiscount.CheckedChanged
        If rdoDiscount.Checked = True Then
            GroupBox4.Enabled = True
        ElseIf rdoDiscount.Checked = False Then
            GroupBox4.Enabled = False
        End If
    End Sub

    Private Sub txtdiscouted_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdiscouted.TextChanged
        txtBprice.Text = Val(txtRegPrice.Text) - Val(txtdiscouted.Text)

    End Sub

    Private Sub txtdiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdiscount.TextChanged
        txtdiscouted.Text = Val(txtdiscount.Text) / 100 * Val(txtRegPrice.Text)
    End Sub

    Private Sub txtRegPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRegPrice.TextChanged
        txtdiscouted.Text = Val(txtdiscount.Text) / 100 * Val(txtRegPrice.Text)
        txtBprice.Text = Val(txtRegPrice.Text) - Val(txtdiscouted.Text)

    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        On Error Resume Next
        Me.txtdID.Text = ListView1.FocusedItem.Text
        Me.txtBatch.Text = ListView1.FocusedItem.SubItems(1).Text
        Me.txtdrgname.Text = ListView1.FocusedItem.SubItems(2).Text
        Me.txtmeasure.Text = ListView1.FocusedItem.SubItems(3).Text
        Me.cboform.Text = ListView1.FocusedItem.SubItems(4).Text
        Me.txtquantity.Text = ListView1.FocusedItem.SubItems(5).Text
        Me.txtdiscount.Text = ListView1.FocusedItem.SubItems(6).Text
        Me.txtBprice.Text = ListView1.FocusedItem.SubItems(7).Text
        Me.txtSprice.Text = ListView1.FocusedItem.SubItems(8).Text
        Me.dtpex.Text = ListView1.FocusedItem.SubItems(9).Text
        btnSave.Visible = False
        btnUpdate.Visible = True
    End Sub

    Private Sub ListView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListView1.KeyDown
        With AddDrugQuantity
            .txtdID.Text = Me.ListView1.FocusedItem.Text
            .txtdname.Text = Me.ListView1.FocusedItem.SubItems(2).Text
            .txtdname.ReadOnly = True
            .txtprvqty.Text = Me.ListView1.FocusedItem.SubItems(5).Text
            .txtprvqty.ReadOnly = True
            .dtpExpdate.Text = Me.ListView1.FocusedItem.SubItems(9).Text
            .txtsprice.Text = Me.ListView1.FocusedItem.SubItems(8).Text
            .txtsprice.ReadOnly = True
            .ShowDialog()
        End With
    End Sub

End Class