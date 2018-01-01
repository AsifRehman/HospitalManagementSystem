Imports MySql.Data.MySqlClient
Public Class AddDrugQuantity
    Dim COMMAND As New MySqlCommand
    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click
        connectDB()
        Try
            Dim odqt As Integer
            Dim nqt As Integer
            sql = " select Quantity from drugentry where DrugCode = '" & txtdID.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                odqt = dr(0)
            End While
            RefreshDB()
            nqt = Val(odqt) + Val(txtdqty.Text)

            sql = " Update drugentry set  Quantity = '" & nqt & "' where DrugCode = '" & txtdID.Text & "'"
            COMMAND = New MySqlCommand(sql, conn)
            COMMAND.ExecuteNonQuery()
            frmDrugEntry.Getdata()
        Catch ex As MySqlException
            MsgBox(ex.ToString)

        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        txtdqty.Text = ""
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class