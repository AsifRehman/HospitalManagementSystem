Imports MySql.Data.MySqlClient
Public Class GeneralMCH

    Private Sub GeneralMCH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Filldg()
        count()
    End Sub
    Sub count()
        connectDB()
        Try

            Dim nqt As Integer
            sql = " select count(PatientNO) as  TT  from immunization "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                nqt = dr("TT".ToString)
            End While
            lblNo.Text = nqt
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
            sql = "select PatientNo,Patient_Name,Age,ParentName,Parent_Tel,Weight,Duration,Charges,Remarks,Entry_Date from immunization order by Patient_Name  "
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
            sql = "select PatientNo,Patient_Name,Age,ParentName,Parent_Tel,Weight,Duration,Charges,Remarks,Entry_Date from immunization where Patient_Name  like '" & txtsearch.Text & "%'"
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            DataGridView1.DataSource = bs
            da.Update(ds)
            conn.Close()
            'lblcost.Text = Totals()
        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conn.Dispose()

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

        On Error Resume Next
        If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
        With DetailedMCH
            .lbldate.Text = DataGridView1.Item(0, e.RowIndex).Value
            .lblpno.Text = DataGridView1.Item(1, e.RowIndex).Value
            .lblpname.Text = DataGridView1.Item(2, e.RowIndex).Value
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub
End Class