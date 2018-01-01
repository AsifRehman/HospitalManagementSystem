Imports MySql.Data.MySqlClient
Public Class DailyFP

    Private Sub DailyFP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Filldg()
        count()
        lblcost.Text = Totals()
    End Sub
    Sub count()
        connectDB()
        Try

            Dim nqt As Integer
            sql = " select count(PatientNO) as  TT  from fplanning "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                nqt = dr("TT".ToString)
            End While
            RefreshDB()


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
            sql = "select PatientNo,Patient_Name,NationalID,Age,Marital_Status,Method,Period,Tel,Price,Entry_Date,Status,Remarks from fplanning order by PatientNo  "
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
    Private Function Totals() As Double
        'On Error Resume Next
        Dim Total As Double = 0
        Dim i As Integer = 0

        For i = 0 To DataGridView1.Rows.Count - 1
            Total = Total + Convert.ToDouble(DataGridView1.Rows(i).Cells("Price").Value)
        Next i
        Return Total
    End Function
    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select PatientNo,Patient_Name,NationalID,Age,Marital_Status,Method,Period,Tel,Price,Entry_Date,Status,Remarks from fplanning  where  Patient_Name  like '" & txtsearch.Text & "%'"
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            DataGridView1.DataSource = bs
            da.Update(ds)
            conn.Close()
            lblcost.Text = Totals()
        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conn.Dispose()

        End Try
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource
        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select PatientNo,Patient_Name,NationalID,Age,Marital_Status,Method,Period,Tel,Price,Entry_Date,Status,Remarks from fplanning where Entry_Date = '" & DateTimePicker1.Text & "' order by Patient_Name "
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            DataGridView1.DataSource = bs
            da.Update(ds)
            conn.Close()
            lblcost.Text = Totals()
        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DailyFP_Load(sender, e)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
