Imports MySql.Data.MySqlClient
Public Class LabTestPayment
    Dim stt As String
    Private Sub LabTestPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''txtpno.Clear()
        txtpname.Clear()
        txttotal.Clear()
        txtpaid.Clear()
        DataGridView1.DataSource = Nothing
    End Sub
    Sub Filldg()


        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        stt = "NP"

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select TestNO,TestName,Charges from outpatientlabrequest where PatientNO = '" & txtpno.Text & "' and  Status = '" & stt & "' "
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
        Dim total As Double = 0
        Dim i As Integer = 0

        For i = 0 To DataGridView1.Rows.Count - 1
            total = total + Convert.ToDouble(DataGridView1.Rows(i).Cells("Charges").Value)
        Next i

        Return total
    End Function
    Private Sub txtsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.Click
        If txtpno.Text = "" Then
            MsgBox("Please Type patient NO", MsgBoxStyle.Critical)
            txtpno.Focus()
        Else
            Filldg()
            profile()
            txttotal.Text = Totals()
        End If
    End Sub
    Sub profile()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        stt = "NP"
        If txtpno.Text = "" Then
            MsgBox("Please Type patient NO", MsgBoxStyle.Critical)
            txtpno.Focus()
        Else
            connectDB()

            sql = "select * from outpatientlabrequest where PatientNO = '" & txtpno.Text & "' and  Status = '" & stt & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = False Then
                MsgBox("No Record found", MsgBoxStyle.Critical)
                ' Call clear()
            Else
                Me.txtpname.Text = dr.GetString("Patient_Name")
                Me.txtpname.ReadOnly = True
                Me.txtpname.BackColor = Color.Aqua

                disconnect()
                dr.Close()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error Resume Next
        If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
        Me.lblNo.Text = DataGridView1.Item(0, e.RowIndex).Value
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndrop.Click
        If lblNo.Text = "." Then
            MsgBox("You have not selected any record", MsgBoxStyle.Critical)
            lblNo.Focus()


        Else
            connectDB()
            Dim cmd As New MySqlCommand
            Dim reply As String
            sql = "delete from outpatientlabrequest  where TestNO = '" & lblNo.Text & "' "
            cmd = New MySqlCommand(sql, conn)

            reply = MsgBox("Are you sure you want to delete this record???", MsgBoxStyle.YesNoCancel, "Delete")
            If reply = MsgBoxResult.Yes Then
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Delete Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Filldg()
                txttotal.Text = Totals()
            Else

            End If
        End If
        '
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpay.Click

        If lblNo.Text = "." Then
            MsgBox("You have not selected any record", MsgBoxStyle.Critical)
            lblNo.Focus()


        Else
            connectDB()
            Dim cmd As New MySqlCommand
            stt = "P"
            sql = "update outpatientlabrequest set  Status='" & stt & "' where PatientNO= '" & txtpno.Text & "'   "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            MessageBox.Show("Data Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With LabReceipt
                .lblTotal.Text = Me.txttotal.Text
                .lblCash.Text = Me.txtpaid.Text
                .lblrecNO.Text = Me.txtpno.Text
                .lblname.Text = Me.txtpname.Text
                .Show()
            End With





            Filldg()

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class