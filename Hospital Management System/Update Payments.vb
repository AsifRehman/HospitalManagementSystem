
Imports MySql.Data.MySqlClient

Public Class Update_Payments

    Private Sub Update_Payments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Getdata()
    End Sub
    Public Sub Getdata()

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select PatientNO,Patient_Name,TotalBill,Paid,Balance,PaymentDate from outpatpayments where Balance > 0"
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            dgw.DataSource = bs
            da.Update(ds)
            conn.Close()
            cal()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgw_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgw.CellMouseClick

        Try
            If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
            Me.txtpno.Text = dgw.Item(0, e.RowIndex).Value
            Me.txtpname.Text = dgw.Item(1, e.RowIndex).Value
            Me.txtTT.Text = dgw.Item(4, e.RowIndex).Value
            Me.txtdateTreated.Text = dgw.Item(5, e.RowIndex).Value
            Me.txtdateTreated.ReadOnly = True
        Catch ex As Exception
            MsgBox("Invalid move. Please select the record", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtTT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTT.TextChanged
        txtbalance.Text = Val(txtTT.Text) - Val(txtpaid.Text)
    End Sub

    Private Sub txtpaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpaid.TextChanged
        txtbalance.Text = Val(txtTT.Text) - Val(txtpaid.Text)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        
        Dim prevpaid As Integer
        Dim TTpaid As Integer

        connectDB()


        sql = "select PatientNO,Patient_Name,TotalBill,Paid,Balance,PaymentDate from outpatpayments where PatientNO= '" & txtpno.Text & "' and Balance > 0 "
        cmd = New MySqlCommand(sql, conn)
        dr = cmd.ExecuteReader
        While dr.Read
            prevpaid = dr(3)
            'prevbal = dr(6)
        End While
        dr.Close()
        TTpaid = prevpaid + Val(txtpaid.Text)
        
        sql = "Update outpatpayments set Balance = '" & txtbalance.Text & "', Paid = '" & TTpaid & "' where PatientNO = '" & txtpno.Text & "' and Balance > 0 "
        cmd = New MySqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Saved Successfully", MsgBoxStyle.Information)
        Getdata()
        cal()
        conn.Close()
        Reset()


    End Sub
    Sub Reset()
        txtdateTreated.Text = ""
        txtpaid.Text = ""
        txtpname.Text = ""
        txtpno.Text = ""
        txtTT.Text = ""
        txtbalance.Text = ""

    End Sub
    Private Function Totals() As Double
        'On Error Resume Next
        Dim Total As Double = 0
        Dim i As Integer = 0

        For i = 0 To dgw.Rows.Count - 1
            Total = Total + Convert.ToDouble(dgw.Rows(i).Cells("Balance").Value)
        Next i
        Return Total
    End Function
    Sub cal()
        lblPyt.Text = Format(Totals, "#,###.##")
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select PatientNO,Patient_Name,TotalBill,Paid,Balance,PaymentDate from outpatpayments where Patient_Name like '" & txtsearch.Text & "%' and Balance > 0 "
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            dgw.DataSource = bs
            da.Update(ds)
            conn.Close()
            cal()
        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conn.Dispose()

        End Try
    End Sub

    Private Sub dgw_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellContentClick

    End Sub
End Class