Imports MySql.Data.MySqlClient
Public Class DailyDrug_Cost

    Private Sub DailyDrug_Cost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Filldg()
        count()
        lblcost.Text = Format(Totals, "#,###.00")
    End Sub
    Private Function Totals() As Double
        'On Error Resume Next
        Dim Total As Double = 0
        Dim i As Integer = 0

        For i = 0 To DataGridView1.Rows.Count - 1
            Total = Total + Convert.ToDouble(DataGridView1.Rows(i).Cells("Totals").Value)
        Next i
        Return Total
    End Function
    Sub count()
        connectDB()
        Try

            Dim nqt As Integer
            sql = " select count(PatientNO) as  TT  from outpatdrugtotal "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                nqt = dr("TT".ToString)
            End While
            RefreshDB()
            lblNo.Text = nqt

        Catch ex As MySqlException
            MsgBox(ex.ToString)

        Finally
            cmd.Dispose()
            conn.Close()
        End Try


    End Sub
    Sub Filldg()

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select Edate,PatientNo,PatientName,Totals from outpatdrugtotal order by Edate  "
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

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select Edate,PatientNo,PatientName,Totals from outpatdrugtotal where  PatientName  like '" & txtsearch.Text & "%'  order by Edate   "
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            DataGridView1.DataSource = bs
            da.Update(ds)
            conn.Close()
            lblcost.Text = Format(Totals, "#,###.00")
        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conn.Dispose()

        End Try
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        DailyDrug_Cost_Load(sender, e)
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource
        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select Edate,PatientNo,PatientName,Totals from outpatdrugtotal where Edate = '" & DateTimePicker1.Text & "' order by PatientName "
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            DataGridView1.DataSource = bs
            da.Update(ds)
            conn.Close()
            lblcost.Text = Format(Totals, "#,###.00")
        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

        On Error Resume Next
        If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
        With DetailedDrugCost
            .lbldate.Text = DataGridView1.Item(0, e.RowIndex).Value
            .lblpno.Text = DataGridView1.Item(1, e.RowIndex).Value
            .lblpname.Text = DataGridView1.Item(2, e.RowIndex).Value
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub
End Class