Imports MySql.Data.MySqlClient
Public Class ifexist

    Private Sub ifexist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Filldg()
    End Sub
    Sub Filldg()


        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select PatientNO,PName,Age,Gender,Location,Tel,Pay_Mode,Entry_Date from outpatregistration "
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

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
        Consultation.txtPno.Text = DataGridView1.Item(0, e.RowIndex).Value
        Consultation.txtpname.Text = DataGridView1.Item(1, e.RowIndex).Value
        Consultation.txtpname.BackColor = Color.Aqua
        Consultation.txtage.Text = DataGridView1.Item(2, e.RowIndex).Value
        Consultation.txtage.BackColor = Color.Aqua
        Consultation.txtgender.Text = DataGridView1.Item(3, e.RowIndex).Value
        Consultation.txtgender.BackColor = Color.Aqua
        Consultation.txttel.Text = DataGridView1.Item(5, e.RowIndex).Value
        Consultation.txttel.BackColor = Color.Aqua
        Consultation.txtpaymode.Text = DataGridView1.Item(6, e.RowIndex).Value
        Consultation.txtpaymode.BackColor = Color.Aqua
        
        Me.Hide()
        Outpatient_Registration.StartPosition = FormStartPosition.CenterScreen
        Outpatient_Registration.Show()
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select PatientNO,PName,Age,Gender,Location,Tel,Pay_Mode,Entry_Date from outpatregistration where PName like '" & txtsearch.Text & "%'"
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
End Class