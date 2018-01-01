Imports MySql.Data.MySqlClient
Public Class frmfPlanRevisits

    Private Sub frmfPlanRevisits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Filldg()
    End Sub
    Sub Filldg()

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "SELECT PatientNo,Patient_Name,Age,Method,Period,Tel,Weight,Bp,Price,Status,Remarks FROM fplanning  "
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

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select PatientNo,Patient_Name,Age,Method,Period,Tel,Weight,Bp,Price,Status,Remarks FROM fplanning where Patient_Name like '" & txtSearch.Text & "%'"
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        On Error Resume Next
        If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
        frmFamplan.txtpid.Text = DataGridView1.Item(0, e.RowIndex).Value
        frmFamplan.txtpname.Text = DataGridView1.Item(1, e.RowIndex).Value
        frmFamplan.txtpname.BackColor = Color.Aqua
        frmFamplan.txtage.Text = DataGridView1.Item(2, e.RowIndex).Value
        frmFamplan.txtage.BackColor = Color.Aqua
        frmFamplan.txttel.Text = DataGridView1.Item(3, e.RowIndex).Value
        frmFamplan.txttel.BackColor = Color.Aqua
        Me.Hide()
        frmFamplan.Show()
    End Sub
End Class