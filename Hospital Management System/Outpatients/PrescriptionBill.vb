Imports MySql.Data.MySqlClient
Public Class PrescriptionBill
    Dim OQ As Integer
    Dim NQ As Integer
    Dim prevB As Integer
    Dim newB As String
    Dim stt As String
    Sub fillgrid()
        connectDB()
        RefreshDB()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsourse As New BindingSource
        Try
            Dim query As String
            stt = "NF"
            query = "select Batch,Medicine,Strength,Dose,Duration,EDate from outpatpresciption where  PatientNo = '" & txtpno.Text & "' and  EDate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' and status = '" & stt & "'"
            COMMAND = New MySqlCommand(query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bsourse.DataSource = dbdataset
            DataGridViewDoc.DataSource = bsourse
            SDA.Update(dbdataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub

    Sub getprice()
        connectDB()

        If lbldid.Text = "" Then
            MsgBox("No record Selected", MsgBoxStyle.Critical)
            lbldid.Focus()
        Else

            Dim sp As Integer
            sql = "select Selling_Price from drugentry where Batch= '" & lbldid.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                sp = dr(0)
            End While
            txtcost.Text = sp
            dr.Close()
        End If
        'Call clear()
        'Me.Close()
    End Sub
    Sub Math()
        connectDB()

        If lbldid.Text = "" Then
            MsgBox("No record Selected", MsgBoxStyle.Critical)
            lbldid.Focus()
        Else


            sql = "select Quantity from drugentry where Batch= '" & lbldid.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                OQ = dr(0)
            End While
            NQ = OQ - Val(txtqty.Text)
            dr.Close()

            Dim cmd1 As New MySqlCommand
            'Dim dr2 As MySqlDataReader
            sql = "Update drugentry set Quantity =  '" & NQ & "'  where Batch = '" & lbldid.Text & "' "
            cmd1 = New MySqlCommand(sql, conn)
            cmd1.ExecuteNonQuery()
            'MessageBox.Show("prescription Successfully completed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        'Call clear()
        'Me.Close()
    End Sub
    Sub updatestatus()
        connectDB()
        Dim query As String
        ''Dim dr As MySqlDataReader
        Dim cmdd As New MySqlCommand
        Dim sttt As String
        sttt = "F"
        query = "update outpatpresciption set status  = '" & sttt & "'  where PatientNo = '" & txtpno.Text & "' and Batch = '" & lbldid.Text & "' and EDate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "'"
        cmdd = New MySqlCommand(query, conn)
        cmdd.ExecuteNonQuery()

        conn.Close()
        '' dr.Close()
    End Sub

    Private Sub getTotals()
        Try
            Dim I As Integer
            For I = 0 To DataGridViewFinal.RowCount - 1
                lblTT.Text = Val(Format(lblTT.Text, "General Number")) + Val(DataGridViewFinal.Rows.Item(I).Cells(7).Value)
                lblTT.Text = Format(lblTT.Text, "Standard")
                lblTT.Text = Format(lblTT.Text, "Standard")
            Next
        Catch
        End Try
    End Sub
    Private Function Totals() As Double
        'On Error Resume Next
        Dim total As Double = 0
        Dim i As Integer = 0

        For i = 0 To DataGridViewFinal.Rows.Count - 1
            total = total + Convert.ToDouble(DataGridViewFinal.Rows(i).Cells("Cost").Value)
        Next i

        Return total
    End Function
    Sub fillFinalgrid()
        connectDB()
        RefreshDB()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsourse As New BindingSource
        Try
            Dim query As String
            query = "select PatientNo,PatientName,Batch,MedName,Strength,Dose,Entry_Date,Cost from outpatfinaldrugbill where  PatientNo = '" & txtpno.Text & "' and  Entry_Date = '" & Format(DateTime.Today, "yyyy-MM-dd") & "'"
            COMMAND = New MySqlCommand(query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bsourse.DataSource = dbdataset
            DataGridViewFinal.DataSource = bsourse
            SDA.Update(dbdataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub txtdosage_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        checkstock()
    End Sub
    Private Sub checkstock()
        connectDB()
        Dim query As String
        Dim dr As MySqlDataReader
        Dim cmdd As New MySqlCommand
        query = "select Quantity from drugentry where Batch = '" & lbldid.Text & "'"
        cmdd = New MySqlCommand(query, conn)
        dr = cmdd.ExecuteReader
        If dr.Read Then
            prevB = dr.GetString("Quantity")
            If Val(txtqty.Text) > prevB Then
                MsgBox("No Enough stock. Remaining stock is:" & prevB, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "excess")
                'txtqnty.Text = ""
                txtqty.Select()
                txtqty.BackColor = Color.Tomato
            Else
                txtqty.BackColor = Color.White
            End If
        Else

        End If

        conn.Close()
        dr.Close()
    End Sub

    Private Sub btnOK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        connectDB()


        Dim query As String


        If txtpno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtpno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf lblTT.Text = "" Then
            MsgBox("No bill ", MsgBoxStyle.Critical)

        Else
            query = "Insert into outpatdrugtotal(PatientNo,PatientName,Totals,Edate) values('" & txtpno.Text & "','" & txtpname.Text & "','" & txttcost.Text & "','" & Format(DateTime.Today, "yyyy-MM-dd") & "')"
            cmd = New MySqlCommand(query, conn)
            dr.Close()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Billing Successfully completed", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtpno.Clear()
            txtpname.Clear()
            txtmedname.Clear()
            txtStrength.Clear()
            txtqty.Clear()
            txtprice.Clear()
            txtcost.Clear()
            txtdose.Clear()
            lbldid.Text = ""
            DataGridViewFinal.DataSource = Nothing

        End If

        dr.Dispose()
        conn.Close()
    End Sub

    Private Sub cmdsearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        connectDB()
        Dim READER As MySqlDataReader
        Dim cmd As New MySqlCommand
        Dim sql As String

        If txtpno.Text = "" Then
            MsgBox("Please Type patient NO", MsgBoxStyle.Critical)
            txtpno.Focus()
        Else

            Try

                stt = "NF"
                ' connectDB()
                sql = "Select * from outpatpresciption where PatientNO= '" & txtpno.Text & "' and 	EDate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' and status = '" & stt & "'"
                cmd = New MySqlCommand(sql, conn)
                READER = cmd.ExecuteReader

                If READER.Read = False Then
                    MsgBox("No record found", MsgBoxStyle.Critical)
                    ' Call clear()
                Else
                    Me.txtpname.Text = READER.GetString("PatientName")
                    Me.txtpname.ReadOnly = True
                    Me.txtpname.BackColor = Color.Aqua
                    fillgrid()
                End If
            Catch ex As MySqlException
                MsgBox(e.ToString)
            Finally
                disconnect()
                ' READER.Close()
            End Try


        End If
    End Sub

    Private Sub btnadd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        connectDB()

        Dim stt As String
        Dim query As String
        stt = "NT"
        query = "Insert into outpatfinaldrugbill(PatientNo,PatientName,Batch,MedName,Strength,Dose,Quantity,Cost,Entry_Date) values('" & txtpno.Text & "','" & txtpname.Text & "','" & lbldid.Text & "','" & txtmedname.Text & "','" & txtStrength.Text & "','" & txtdose.Text & "','" & txtqty.Text & "','" & txtprice.Text & "','" & Format(DateTime.Today, "yyyy-MM-dd") & "')"

        If txtpno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtpno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtmedname.Text = "" Then
            MsgBox("No drug Selected", MsgBoxStyle.Critical)
            txtmedname.Focus()
        ElseIf txtprice.Text = "" Then
            MsgBox("Price field is empty", MsgBoxStyle.Critical)
            txtprice.Focus()

        Else
            sql = "select * from outpatfinaldrugbill where PatientNO= '" & txtpno.Text & "' and Batch = '" & lbldid.Text & "'  and Entry_Date = '" & Format(DateTime.Today, "yyyy-MM-dd") & "'  "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            If dr.Read = False Then
                cmd = New MySqlCommand(query, conn)
                dr.Close()
                cmd.ExecuteNonQuery()
                ' Reduce drug Quantity
                Call Math()


                'Delete the previous doctors prescriptions
                Dim cmd1 As New MySqlCommand
                Dim dr2 As MySqlDataReader
                sql = "Delete from  outpatpresciption where PatientNO= '" & txtpno.Text & "' and Batch = '" & lbldid.Text & "' and EDate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "'  "
                cmd1 = New MySqlCommand(sql, conn)
                dr2 = cmd1.ExecuteReader
                'Call clear()
                MessageBox.Show("prescription Successful ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                updatestatus()
                fillgrid()
                fillFinalgrid()
                getTotals()
                Me.lblTT.Text = Totals()
                Me.txttcost.Text = Totals()
                txtmedname.Clear()
                txtStrength.Clear()
                txtqty.Clear()
                txtprice.Clear()

            Else
                MessageBox.Show("Record already exist for this client", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error)
                fillFinalgrid()
            End If

            dr.Dispose()
            conn.Close()
        End If

    End Sub

    Private Sub txtcost_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcost.TextChanged
        txtprice.Text = Val(txtqty.Text) * Val(txtcost.Text)
    End Sub

    Private Sub txtdosage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        txtprice.Text = Val(txtqty.Text) * Val(txtcost.Text)
    End Sub

    Private Sub DataGridViewDoc_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewDoc.CellMouseClick
        On Error Resume Next
        If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
        Me.lbldid.Text = DataGridViewDoc.Item(0, e.RowIndex).Value
        Me.txtmedname.Text = DataGridViewDoc.Item(1, e.RowIndex).Value
        Me.txtStrength.Text = DataGridViewDoc.Item(2, e.RowIndex).Value
        Me.txtdose.Text = DataGridViewDoc.Item(3, e.RowIndex).Value

        Call getprice()
    End Sub

    Private Sub PrescriptionBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class