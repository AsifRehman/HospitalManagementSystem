Imports MySql.Data.MySqlClient
Public Class Outpatient_Billing
    Private Sub Auto()
        Try
            connectDB()
            Dim num As String
            num = "1"

            sql = " select RecNo from outpatpayments order by RecNo desc"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                lblRecNO.Text = dr("RecNo") + 1
                lblRecNO.ReadOnly = True
            Else
                lblRecNO.Text = num
                lblRecNO.ReadOnly = True
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Sub profileDocCharges()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        If txtpno.Text = "" Then
            MsgBox("Please Type patient NO", MsgBoxStyle.Critical)
            txtpno.Focus()
        Else
            connectDB()

            sql = "select * from outpatregistration where PatientNO = '" & txtpno.Text & "' "
            'AND Entry_Date = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = False Then
                MsgBox("No Record found", MsgBoxStyle.Critical)
                ' Call clear()
            Else
                Me.txtpatname.Text = dr.GetString("PName")
                Me.txtpatname.ReadOnly = True
                Me.txtpatname.BackColor = Color.Aqua
                Me.txtDrCharges.Text = dr.GetString("Charges")
                Me.txtDrCharges.BackColor = Color.Aqua
                Me.txtDrCharges.ReadOnly = True
                disconnect()
                dr.Close()
            End If
        End If
    End Sub
    Sub immunize()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Try


            If txtpno.Text = "" Then
                MsgBox("Please Type patient NO", MsgBoxStyle.Critical)
                txtpno.Focus()
            Else
                connectDB()
                sql = "select sum(Charges) as Total from immunization where PatientNO = '" & txtpno.Text & "' AND Entry_Date = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' "
                cmd = New MySqlCommand(sql, conn)
                dr = cmd.ExecuteReader

                If dr.Read = False Then
                    'lblfp.Visible = True
                    'lblfp.Text = "No  FP Record found"

                Else
                    'lblfp.Visible = False
                    Me.txtimmune.Text = dr.GetString("Total")
                    Me.txtimmune.ReadOnly = True
                    Me.txtimmune.BackColor = Color.PaleVioletRed
                End If
            End If

        Catch ex As Exception
            'lblfp.Visible = True
            txtfp.Clear()
            'lblfp.Text = "No  FP Record found"
        End Try
        disconnect()
    End Sub

    Sub Labcost()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Try

            If txtpno.Text = "" Then
                MsgBox("Please Type patient NO", MsgBoxStyle.Critical)
                txtpno.Focus()
            Else
                connectDB()
                sql = "select sum(Charges) as lcost from outpatientlabrequest where PatientNO = '" & txtpno.Text & "' AND Edate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' "
                cmd = New MySqlCommand(sql, conn)
                dr = cmd.ExecuteReader

                If dr.Read = False Then

                Else
                    'lbllabcost.Visible = False
                    Me.txtlabcost.Text = dr.GetString("lcost")
                    Me.txtlabcost.ReadOnly = True
                    Me.txtlabcost.BackColor = Color.PaleVioletRed
                End If
            End If
        Catch ex As Exception
            'lbllabcost.Visible = True
            txtlabcost.Clear()
            'lbllabcost.Text = "No lab Record found"
        End Try
        disconnect()
        ' dr.Close()


    End Sub
    Sub Drugcost()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Try


            If txtpno.Text = "" Then
                MsgBox("Please Type patient NO", MsgBoxStyle.Critical)
                txtpno.Focus()
            Else
                connectDB()
                sql = "select sum(Totals) as Total from outpatdrugtotal where PatientNO = '" & txtpno.Text & "' AND Edate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' "
                cmd = New MySqlCommand(sql, conn)
                dr = cmd.ExecuteReader

                If dr.Read = False Then
                    'lbldrugcost.Visible = True
                    'lbldrugcost.Text = "No Drug Cost Record found"

                Else
                    'lbldrugcost.Visible = False
                    Me.txtdrugcost.Text = dr.GetString("Total")
                    Me.txtdrugcost.ReadOnly = True
                    Me.txtdrugcost.BackColor = Color.PaleVioletRed
                End If
            End If
        Catch ex As Exception
            'lbldrugcost.Visible = True
            txtdrugcost.Clear()
            'lbldrugcost.Text = "No Drug Cost Record found"
        End Try
        disconnect()
        ' dr.Close()


    End Sub
    Sub FP()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Try


            If txtpno.Text = "" Then
                MsgBox("Please Type patient NO", MsgBoxStyle.Critical)
                txtpno.Focus()
            Else
                connectDB()
                sql = "select sum(Price) as Total from fplanning where PatientNO = '" & txtpno.Text & "' AND Entry_Date = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' "
                cmd = New MySqlCommand(sql, conn)
                dr = cmd.ExecuteReader

                If dr.Read = False Then
                    'lblfp.Visible = True
                    'lblfp.Text = "No  FP Record found"

                Else
                    'lblfp.Visible = False
                    Me.txtfp.Text = dr.GetString("Total")
                    Me.txtfp.ReadOnly = True
                    Me.txtfp.BackColor = Color.PaleVioletRed
                End If
            End If

        Catch ex As Exception
            'lblfp.Visible = True
            txtfp.Clear()
            'lblfp.Text = "No  FP Record found"
        End Try
        disconnect()

    End Sub

    Sub OTHERS()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Try

            If txtpno.Text = "" Then
                MsgBox("Please Type patient NO", MsgBoxStyle.Critical)
                txtpno.Focus()
            Else
                connectDB()
                sql = "select sum(Charges) as Total from other_procedures where PatientNO = '" & txtpno.Text & "' AND Entry_Date = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' "
                cmd = New MySqlCommand(sql, conn)
                dr = cmd.ExecuteReader

                If dr.Read = False Then
                    'lblothers.Visible = True
                    'lblothers.Text = "Other procedures Record  Not found"

                Else
                    'lblothers.Visible = False
                    Me.txtothers.Text = dr.GetString("Total")
                    Me.txtothers.ReadOnly = True
                    Me.txtothers.BackColor = Color.PaleVioletRed
                End If
            End If

        Catch ex As Exception
            'lblothers.Visible = True
            txtothers.Clear()
            'lblothers.Text = "Other procedures Record found"
        End Try
        disconnect()

    End Sub

    Private Sub btnsearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        profileDocCharges()
        Drugcost()
        FP()
        Labcost()
        OTHERS()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Sub clear()
        txtTBill.Text = ""
        txtpno.Text = ""
        txtpatname.Text = ""
        txtdrugcost.Text = "0.00"
        txtfp.Text = "0.00"
        txtlabcost.Text = "0.00"
        txtothers.Text = "0.00"
        txttotal.Text = "0.00"
        txtpaid.Text = "0.00"
        txtbalance.Text = "0.00"
        txtDrCharges.Text = "0.00"
    End Sub


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        connectDB()

        Dim stt As String
        Dim query As String
        stt = "NT"
        query = "Insert into outpatpayments(RecNo,PatientNO,Patient_Name,drug,Consult_Fee,FP,Lab,MCH,Others,TotalBill,Paid,Balance,PaymentDate) values('" & lblRecNO.Text & "','" & txtpno.Text & "','" & txtpatname.Text & "','" & txtDrCharges.Text & "','" & txtdrugcost.Text & "','" & txtfp.Text & "','" & txtlabcost.Text & "','" & txtimmune.Text & "','" & txtothers.Text & "','" & txttotal.Text & "','" & txtpaid.Text & "','" & txtbalance.Text & "','" & Format(DateTime.Today, "yyyy-MM-dd") & "')"

        If txtpno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtpno.Focus()
        ElseIf txtpatname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpatname.Focus()
        ElseIf txtpaid.Text = "" Then
            MsgBox("Paid field is empty", MsgBoxStyle.Critical)
            txtpaid.Focus()
        Else
            sql = "select * from outpatpayments where PatientNO= '" & txtpno.Text & "' and TotalBill = '" & txttotal.Text & "' and Balance = '" & txtbalance.Text & "' and PaymentDate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            If dr.Read = False Then
                cmd = New MySqlCommand(query, conn)
                dr.Close()
                cmd.ExecuteNonQuery()
                MessageBox.Show(" Paid Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'With PaymentReceipt
                '    .lblrecNO.Text = lblRecNO.Text
                '    .lblpno.Text = txtpatno.Text
                '    .lblpname.Text = txtpatname.Text
                '    .lblConsultation.Text = txtDrCharges.Text
                '    .lbldrg.Text = txtdrugcost.Text
                '    .lblFP.Text = txtfp.Text
                '    .lblLab.Text = txtlabcost.Text
                '    .lblothers.Text = txtothers.Text
                '    .lblTotal.Text = txttotal.Text
                '    .lblCash.Text = txtpaid.Text
                '    .lblChange.Text = txtbalance.Text
                '    .ShowDialog()
                'End With

                Outpatient_Billing_Load(sender, e)
            Else
                MessageBox.Show("Payment for this client client has alredy been done", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            dr.Dispose()
            conn.Close()
            Call clear()
            Call Auto()
        End If

    End Sub



    Private Sub txtdrugcost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdrugcost.TextChanged
        txtTBill.Text = Val(txtdrugcost.Text) + Val(txtfp.Text) + Val(txtlabcost.Text) + Val(txtothers.Text) + Val(txtDrCharges.Text)
    End Sub

    Private Sub txtfp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfp.TextChanged
        txtTBill.Text = Val(txtdrugcost.Text) + Val(txtfp.Text) + Val(txtlabcost.Text) + Val(txtothers.Text) + Val(txtDrCharges.Text)
    End Sub

    Private Sub txtothers_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtothers.TextChanged
        txtTBill.Text = Val(txtdrugcost.Text) + Val(txtfp.Text) + Val(txtlabcost.Text) + Val(txtothers.Text) + Val(txtDrCharges.Text)

    End Sub

    Private Sub txtlabcost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlabcost.TextChanged
        txtTBill.Text = Val(txtdrugcost.Text) + Val(txtfp.Text) + Val(txtlabcost.Text) + Val(txtothers.Text) + Val(txtDrCharges.Text)

    End Sub

    Private Sub txtDrCharges_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDrCharges.TextChanged
        txtTBill.Text = Val(txtdrugcost.Text) + Val(txtfp.Text) + Val(txtlabcost.Text) + Val(txtothers.Text) + Val(txtDrCharges.Text)
    End Sub

    Private Sub txtTBill_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTBill.TextChanged
        txttotal.Text = Val(txtTBill.Text)

    End Sub

    Private Sub txttotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotal.TextChanged
        txtbalance.Text = Val(txttotal.Text) - Val(txtpaid.Text)
    End Sub

    Private Sub txtpaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpaid.TextChanged
        txtbalance.Text = Val(txttotal.Text) - Val(txtpaid.Text)
    End Sub

    Private Sub Outpatient_Billing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Getdata()
        Auto()
        LoadBal()
        lbltime.Text = Format(DateTime.Today, "yyyy-MM-dd")

    End Sub
    Public Sub LoadBal()

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
            DataGridView1.DataSource = bs
            da.Update(ds)
            conn.Close()
            cal()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Getdata()

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select PatientNO,Patient_Name,TotalBill,Paid,Balance,PaymentDate from outpatpayments Where PaymentDate ='" & Format(DateTime.Today, "yyyy-MM-dd") & "'"
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
    Private Function Totals() As Double
        'On Error Resume Next
        Dim Total As Double = 0
        Dim i As Integer = 0

        For i = 0 To dgw.Rows.Count - 1
            Total = Total + Convert.ToDouble(dgw.Rows(i).Cells("Paid").Value)
        Next i
        Return Total
    End Function
    Sub cal()
        lblPyt.Text = Format(Totals, "#,###.##")
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Update_Payments.ShowDialog()
    End Sub

    Private Sub txtpno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpno.TextChanged
        txtpatno.Text = txtpno.Text
    End Sub
End Class