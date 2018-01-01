Imports MySql.Data.MySqlClient
Public Class QuickPickDrug

    Private Sub QuickPickDrug_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadLv()
    End Sub
    Sub LoadLv()
        Try
            sql = "SELECT DrugCode,Batch,Drug_Name,Strength,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date FROM drugentry "
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

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try
            sql = "SELECT DrugCode,Batch,Drug_Name,Strength,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date  FROM drugentry WHERE Drug_Name LIKE '" & txtsearch.Text & "%' order By Drug_Name "
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
            conn.Close()
        End Try
    End Sub

    

    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        '    With Counter_Sale
        '        .txtdrugcode.Text = Me.ListView1.FocusedItem.Text
        '        .cbodrgname.Text = Me.ListView1.FocusedItem.SubItems(2).Text
        '        .txtprice.Text = Me.ListView1.FocusedItem.SubItems(7).Text
        '        .txtprice.Text = Me.ListView1.FocusedItem.SubItems(7).Text
        '        .txtprice.ReadOnly = True
        '        .Show()
        '    End With
        '    Me.Close()
    End Sub

    Private Sub ListView1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'With Prescription
        '    .cmbDrgName.Text = Me.ListView1.FocusedItem.Text
        '    .Show()
        'End With
    End Sub

    Private Sub ListView1_MouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
        With Counter_Sale
            .txtdrugcode.Text = Me.ListView1.FocusedItem.Text
            .txtBatch.Text = Me.ListView1.FocusedItem.SubItems(1).Text
            .txtdName.Text = Me.ListView1.FocusedItem.SubItems(2).Text
            .txtdName.ReadOnly = True
            .txtprice.Text = Me.ListView1.FocusedItem.SubItems(7).Text
            '.txt.Text = Me.ListView1.FocusedItem.SubItems(7).Text
            .txtprice.ReadOnly = True
            .Show()

        End With
        Me.Close()
    End Sub

End Class