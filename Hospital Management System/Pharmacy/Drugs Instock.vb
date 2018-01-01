Imports MySql.Data.MySqlClient
Public Class Drugs_Instock

    Private Sub Drugs_Instock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Filldg()
    End Sub
    Sub Filldg()


        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select Batch,Drug_Name,Strength,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date from drugentry where Quantity > 0 order by Drug_Name ASC"
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            DataGridView1.DataSource = bs
            da.Update(ds)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conn.Dispose()

        End Try

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'With Prescription
        '    .cmbDrgName.Text = Me.DataGridView1.DataSource.ToString
        '    .Show()
        'End With
    End Sub

    Private Sub Analgestics()
        Try
            Dim ds As New DataSet
            Dim query As String

            connectDB()
            RefreshDB()
            Dim SDA As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsourse As New BindingSource
            Dim dp As String = "ANALGESTICS"
            Try
                query = "select Batch,Drug_Name,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date from drugentry where Form = '" & dp & "'"
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub PainKillers()
        Try
            Dim ds As New DataSet
            Dim query As String

            connectDB()
            RefreshDB()
            Dim SDA As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsourse As New BindingSource
            Dim dp As String = "PainKiller"
            Try
                query = "select Drug_Name,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date from drugentry where Form = '" & dp & "'"
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AntiAcids()
        Try
            Dim ds As New DataSet
            Dim query As String

            connectDB()
            RefreshDB()
            Dim SDA As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsourse As New BindingSource
            Dim dp As String = "ANTACIDS"
            Try
                query = "select Drug_Name,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date from drugentry where Form = '" & dp & "'"
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Cough_syrup()
        Try
            Dim ds As New DataSet
            Dim query As String

            connectDB()
            RefreshDB()
            Dim SDA As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsourse As New BindingSource
            Dim dp As String = "COUGH SYRUP"
            Try
                query = "select Drug_Name,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date from drugentry where Form = '" & dp & "'"
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub creams()
        Try
            Dim ds As New DataSet
            Dim query As String

            connectDB()
            RefreshDB()
            Dim SDA As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsourse As New BindingSource
            Dim dp As String = "CREAMS"
            Try
                query = "select Drug_Name,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date from drugentry where Form = '" & dp & "'"
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Antibiotics()
        Try
            Dim ds As New DataSet
            Dim query As String

            connectDB()
            RefreshDB()
            Dim SDA As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsourse As New BindingSource
            Dim dp As String = "ANTIBIOTICS"
            Try
                query = "select Drug_Name,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date from drugentry where Form = '" & dp & "'"
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Antifungal()
        Try
            Dim ds As New DataSet
            Dim query As String

            connectDB()
            RefreshDB()
            Dim SDA As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsourse As New BindingSource
            Dim dp As String = "ANTIFUNGAL"
            Try
                query = "select Drug_Name,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date from drugentry where Form = '" & dp & "'"
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub suppliments()
        Try
            Dim ds As New DataSet
            Dim query As String

            connectDB()
            RefreshDB()
            Dim SDA As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsourse As New BindingSource
            Dim dp As String = "SUPPLIMENTS"
            Try
                query = "select Drug_Name,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date from drugentry where Form = '" & dp & "'"
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Antiseptic()
        Try
            Dim ds As New DataSet
            Dim query As String

            connectDB()
            RefreshDB()
            Dim SDA As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsourse As New BindingSource
            Dim dp As String = "ANTISEPTIC"
            Try
                query = "select Drug_Name,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date from drugentry where Form = '" & dp & "'"
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Dewormers()
        Try
            Dim ds As New DataSet
            Dim query As String

            connectDB()
            RefreshDB()
            Dim SDA As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsourse As New BindingSource
            Dim dp As String = "DEWORMERS"
            Try
                query = "select Drug_Name,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date from drugentry where Form = '" & dp & "'"
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub All()

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select Drug_Name,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date from drugentry where Quantity > 0"
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            DataGridView1.DataSource = bs
            da.Update(ds)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conn.Dispose()

        End Try

    End Sub
    Private Sub Injections()
        Try
            Dim ds As New DataSet
            Dim query As String

            connectDB()
            RefreshDB()
            Dim SDA As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsourse As New BindingSource
            Dim dp As String = "INJECTABLES"
            Try
                query = "select Drug_Name,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date from drugentry where Form = '" & dp & "'"
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub EyeDrops()
        Try
            Dim ds As New DataSet
            Dim query As String

            connectDB()
            RefreshDB()
            Dim SDA As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsourse As New BindingSource
            Dim dp As String = "EYE DROPS"
            Try
                query = "select Drug_Name,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date from drugentry where Form = '" & dp & "'"
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Ointment()
        Try
            Dim ds As New DataSet
            Dim query As String

            connectDB()
            RefreshDB()
            Dim SDA As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsourse As New BindingSource
            Dim dp As String = "OINTMENT/GEL"
            Try
                query = "select Drug_Name,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date from drugentry where Form = '" & dp & "'"
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If optpain.Checked = True Then
    '        PainKillers()

    '    ElseIf optAntiacids.Checked = True Then
    '        AntiAcids()
    '    ElseIf Rdoanalgestics.Checked = True Then
    '        Analgestics()
    '    ElseIf OptDeworm.Checked = True Then
    '        Dewormers()
    '    ElseIf OptEyedrops.Checked = True Then
    '        EyeDrops()
    '    ElseIf OptSup.Checked = True Then
    '        suppliments()
    '    ElseIf optOintment.Checked = True Then
    '        Ointment()
    '    ElseIf OptEyedrops.Checked = True Then
    '        EyeDrops()
    '    ElseIf OptFungal.Checked = True Then
    '        Antifungal()
    '    ElseIf OptAntiSep.Checked = True Then
    '        Antiseptic()
    '    ElseIf optcough.Checked = True Then
    '        Cough_syrup()
    '    ElseIf OptCream.Checked = True Then
    '        creams()
    '    ElseIf optantibio.Checked = True Then
    '        Antibiotics()
    '    ElseIf RdoInject.Checked = True Then
    '        Injections()
    '    ElseIf RdoAll.Checked = True Then
    '        All()
    '    Else
    '        MsgBox("You must select a Category", MsgBoxStyle.Critical)

    '    End If
    'End Sub

    Private Sub txtsearch_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select Batch,Drug_Name,Strength,Form,Quantity,Buying_Price,Selling_Price,Expiry_Date from drugentry where Quantity > 0 and Drug_Name like '" & txtsearch.Text & "%'"
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            DataGridView1.DataSource = bs
            da.Update(ds)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conn.Dispose()

        End Try
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        On Error Resume Next
        With Prescription
            If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
            .lblid.Text = DataGridView1.Item(0, e.RowIndex).Value
            .TxtDname.Text = DataGridView1.Item(1, e.RowIndex).Value
            .txtStrength.Text = DataGridView1.Item(2, e.RowIndex).Value

            Me.Hide()

            Prescription.StartPosition = FormStartPosition.CenterScreen
            Prescription.Show()
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class