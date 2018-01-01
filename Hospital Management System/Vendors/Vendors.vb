Imports MySql.Data.MySqlClient
Public Class Vendors
    Dim query As String
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvname.TextChanged

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        connectDB()

        query = "Insert into  vendor(VendorName,Company,Address,Telephone,City,Email,EntryDate) values('" & txtvname.Text & "','" & txtcompany.Text & "','" & txtaddress.Text & "','" & txttel.Text & "','" & txtcity.Text & "','" & txtemail.Text & "','" & DateTime.Today & "')"

        If txtvname.Text = "" Then
            MsgBox("Vender name field is empty", MsgBoxStyle.Critical)
            txtvname.Focus()
        ElseIf txtcompany.Text = "" Then
            MsgBox("Company name field is empty", MsgBoxStyle.Critical)
            txtcompany.Focus()
        ElseIf txttel.Text = "" Then
            MsgBox("Telephone field is empty", MsgBoxStyle.Critical)
            txttel.Focus()


        Else
            sql = "select * from vendor where VendorName= '" & txtvname.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            If dr.Read = False Then
                cmd = New MySqlCommand(query, conn)
                dr.Close()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Filldg()
                Call clear()
            Else

                MsgBox("This Record Already exists. Add quantity", MsgBoxStyle.Critical)


            End If
        End If
        dr.Dispose()
        conn.Close()
    End Sub
    Sub clear()
        txtvname.Text = ""
        txtcompany.Text = ""
        txtaddress.Text = ""
        txttel.Text = ""
        txtcity.Text = ""
        txtemail.Text = ""
    End Sub
    Sub Filldg()
        connectDB()
        RefreshDB()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsourse As New BindingSource
        Try
            Dim query As String
            query = "select VendorName,Company,Address,Telephone,City,Email,EntryDate from vendor "
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

    Private Sub Vendors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Filldg()
    End Sub
End Class