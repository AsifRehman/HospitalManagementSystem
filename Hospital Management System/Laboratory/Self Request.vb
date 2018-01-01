Imports MySql.Data.MySqlClient
Public Class Self_Request
    Dim stt As String
    Dim query As String
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Sub filldg()
        connectDB()
        RefreshDB()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsourse As New BindingSource
        Try
            Dim query As String
            query = "select * from outpatientlabrequest"
            COMMAND = New MySqlCommand(query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bsourse.DataSource = dbdataset
            DataGridView2.DataSource = bsourse
            SDA.Update(dbdataset)
            conn.Close()
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub AutogenDrgID()
        Try
            connectDB()
            Dim num As String
            num = "1001"

            sql = " SELECT LabNo FROM outpatientlabrequest Order By LabNo Desc"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtpno.Text = dr("LabNo") + 1
                txtpno.ReadOnly = True
            Else
                txtpno.Text = num
                txtpno.ReadOnly = True
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub
    Private Sub Self_Request_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutogenDrgID()
        fillLabtest()
        filldg()
    End Sub
    Sub fillLabtest()
        connectDB()
        RefreshDB()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsourse As New BindingSource
        Try
            Dim query As String
            query = "select ID,TestName,Duration,Charges from labtest "
            COMMAND = New MySqlCommand(query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bsourse.DataSource = dbdataset
            Dgv.DataSource = bsourse
            SDA.Update(dbdataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

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

    Sub fillLabRequest()
        connectDB()
        RefreshDB()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsourse As New BindingSource
        Try
            Dim query As String
            Dim stt As String
            stt = "NP"
            query = "select PatientNO,Patient_Name,TestNO,TestName,Charges,Edate from outpatientlabrequest where PatientNO = '" & txtpno.Text & "' and Edate = '" & DateTime.Today & "' and Status = '" & stt & "'"
            COMMAND = New MySqlCommand(query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bsourse.DataSource = dbdataset
            DataGridView1.DataSource = bsourse
            SDA.Update(dbdataset)
            conn.Close()
            txttotal.Text = Totals()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        txttotal.Text = Totals()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource
        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select * from outpatientlabrequest where Patient_Name like '" & txtSearch.Text & "%'"
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            DataGridView2.DataSource = bs
            da.Update(ds)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conn.Dispose()

        End Try

    End Sub

    Private Sub btnsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
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
            Reset()
        End If
    End Sub

    Private Sub cmdadd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        connectDB()
        Dim query As String
        Dim stt As String
        stt = "NP"
        query = "Insert into outpatientlabrequest(PatientNO,Patient_Name,TestNO,TestName,Charges,Status,Edate) values('" & txtpno.Text & "','" & txtpname.Text & "','" & lblNo.Text & "','" & txttestName.Text & "','" & txtchages.Text & "','" & stt & "','" & DateTime.Today & "')"
        If txtpno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtpno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()

        Else
            sql = "select * from outpatientlabrequest where PatientNO = '" & txtpno.Text & "' and TestName = '" & txttestName.Text & "' and  Edate = '" & DateTime.Today & "' and Status = '" & stt & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            If dr.Read = False Then
                cmd = New MySqlCommand(query, conn)
                dr.Close()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txttestName.Text = ""
                txtchages.Text = ""
                lblNo.Text = ""
                txttotal.Text = Totals()
                fillLabRequest()
            Else

                MessageBox.Show("Data Already exist", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        conn.Close()
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        With SelfRequest_Results
            .txtpno.Text = txtpno.Text
            .txtpname.Text = txtpname.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbal.TextChanged

    End Sub

    Private Sub txttotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotal.TextChanged
        txtbal.Text = Val(txttotal.Text) - Val(txtpaid.Text)
    End Sub

    Private Sub txtpaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpaid.TextChanged
        txtbal.Text = Val(txttotal.Text) - Val(txtpaid.Text)
    End Sub

    Private Sub Dgv_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgv.CellMouseDoubleClick
        Try
            If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
            Me.lblNo.Text = Dgv.Item(0, e.RowIndex).Value
            Me.txttestName.Text = Dgv.Item(1, e.RowIndex).Value
            Me.txttestName.ReadOnly = True
            Me.txttestName.BackColor = Color.Aqua
            Me.txtchages.Text = Dgv.Item(3, e.RowIndex).Value
            Me.txtchages.ReadOnly = True
            'Me.StartPosition = FormStartPosition.CenterScreen
            'Me.Show()
        Catch ex As Exception
            MsgBox("Invalid move. Please select the record", MsgBoxStyle.Critical)
        End Try
    End Sub
    Sub Reset()
        txtpaid.Text = ""
        txtbal.Text = ""
        txttestName.Text = ""
        txtchages.Text = ""
        txttotal.Text = ""
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub DataGridView2_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDoubleClick
        On Error Resume Next
        If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
        Me.txtpno.Text = DataGridView2.Item(1, e.RowIndex).Value
        Me.txtpno.ReadOnly = True
        Me.txtpname.Text = DataGridView2.Item(2, e.RowIndex).Value
    End Sub
End Class