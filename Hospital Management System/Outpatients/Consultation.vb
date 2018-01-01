Imports MySql.Data.MySqlClient
Public Class Consultation

    Sub count()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        If txtPno.Text = "" Then
            MsgBox("Please Type patient NO", MsgBoxStyle.Critical)
            txtsearch.Focus()

        Else
            connectDB()
            sql = "select count(PatientNO)as Pno from outpatregistration where PatientNO= '" & txtPno.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = False Then
                Call clear()
            Else

                Me.lblVno.Text = dr.GetString("Pno")
            End If
            disconnect()
            dr.Close()

        End If
    End Sub

    Private Sub Consultation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillConsultPNO()
        Filldg()
    End Sub
    Sub Filldg()

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select T_ID,PatientNO,Patient_Name,Age,gender, Tel,Complains,History,Diagnosis,LabInvestigation,NextReview,Entry_Date from outpattreatment"
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
    Private Sub cmbopid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim READER As MySqlDataReader
        Dim sql As String
        Try
            connectDB()
            sql = "Select * from outpatregistration where PatientNO= '" & txtPno.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            While READER.Read
                txtpname.Text = READER.GetString("PName")
                txtpname.ReadOnly = True
                txtpname.BackColor = Color.Aqua
                txtage.Text = READER.GetString("Age")
                txtage.ReadOnly = True
                txtage.BackColor = Color.Aqua
                txtgender.Text = READER.GetString("Gender")
                txtgender.ReadOnly = True
                txtgender.BackColor = Color.Aqua
                txttel.Text = READER.GetString("Tel")
                txttel.ReadOnly = True
                txttel.BackColor = Color.Aqua
                txtpaymode.Text = READER.GetString("Pay_Mode")
                txtage.ReadOnly = True
                txtage.BackColor = Color.Aqua
            End While
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Filldg()
    End Sub

    Sub proc()
        'Dim da As New MySqlDataAdapter
        'Dim ds As New DataTable
        'Dim bs As New BindingSource

        'Try
        '    connectDB()
        '    Dim cmd As New MySqlCommand
        '    sql = "select Procedure_Name, Entry_Date from other_procedures where PatientNO= '" & txtPno.Text & "' "
        '    cmd = New MySqlCommand(sql, conn)
        '    da.SelectCommand = cmd
        '    da.Fill(ds)
        '    bs.DataSource = ds
        '    dgProcedure.DataSource = bs
        '    da.Update(ds)
        '    conn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
    Sub profile()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        If txtPno.Text = "" Then
            MsgBox("Please Type the patient NO", MsgBoxStyle.Critical)
            txtPno.Focus()
        Else
            connectDB()
            sql = "Select * from outpatregistration where PatientNO= '" & txtPno.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            If dr.Read = False Then
                MsgBox("This record was not found", MsgBoxStyle.Critical)

            Else
                Me.txtpname.Text = dr.GetString("PName")
                Me.txtpname.ReadOnly = True
                Me.txtpname.BackColor = Color.Honeydew
                Me.txtage.Text = dr.GetString("Age")
                Me.txtage.ReadOnly = True
                Me.txtage.BackColor = Color.Honeydew
                Me.txtgender.Text = dr.GetString("Gender")
                Me.txtgender.ReadOnly = True
                Me.txtgender.BackColor = Color.Honeydew
                Me.txttel.Text = dr.GetString("Tel")
                Me.txttel.ReadOnly = True
                Me.txttel.BackColor = Color.Honeydew
                Me.txtpaymode.Text = dr.GetString("Pay_Mode")
                Me.txtpaymode.ReadOnly = True
                Me.txtpaymode.BackColor = Color.Honeydew
            End If
            disconnect()
            dr.Close()

        End If
    End Sub
    Sub clear()
        Me.txtPno.Text = ""
        Me.txtpname.Text = ""
        Me.txtage.Text = ""
        Me.txtgender.Text = ""
        Me.txttel.Text = ""
        Me.txtpaymode.Text = ""
    End Sub

    Sub Getdata()
        'Dim da As New MySqlDataAdapter
        'Dim ds As New DataTable
        'Dim bs As New BindingSource

        'Try
        '    connectDB()
        '    Dim cmd As New MySqlCommand
        '    sql = "select Complains,History,LabInvestigation,Diagnosis,Entry_Date from outpattreatment where PatientNO= '" & txtPno.Text & "' "
        '    cmd = New MySqlCommand(sql, conn)
        '    da.SelectCommand = cmd
        '    da.Fill(ds)
        '    bs.DataSource = ds
        '    dgw.DataSource = bs
        '    da.Update(ds)
        '    conn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
    Sub FilldgTreat()
        'Dim da As New MySqlDataAdapter
        'Dim ds As New DataTable
        'Dim bs As New BindingSource
        'Try
        '    connectDB()
        '    Dim cmd As New MySqlCommand
        '    sql = "select MedName, Entry_Date from outpatfinaldrugbill where PatientNO= '" & txtPno.Text & "' "
        '    cmd = New MySqlCommand(sql, conn)
        '    da.SelectCommand = cmd
        '    da.Fill(ds)
        '    bs.DataSource = ds
        '    dgTreat.DataSource = bs
        '    conn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub
    Sub FilldgDiag()
        'Dim da As New MySqlDataAdapter
        'Dim ds As New DataTable
        'Dim bs As New BindingSource
        'Try
        '    connectDB()
        '    Dim cmd As New MySqlCommand
        '    sql = "select MedName, Entry_Date from outsidepresc where PatientNO= '" & txtPno.Text & "' "
        '    cmd = New MySqlCommand(sql, conn)
        '    da.SelectCommand = cmd
        '    da.Fill(ds)
        '    bs.DataSource = ds
        '    dgExternal.DataSource = bs
        '    da.Update(ds)
        '    conn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try


    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select T_ID,PatientNO,Patient_Name,Age,gender, Tel Complains,History,Diagnosis,LabInvestigation,NextReview,Entry_Date from outpattreatment where Patient_Name like '" & txtsearch.Text & "%'"
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

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        clear()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Try
            If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
            Me.txtId.Text = DataGridView1.Item(0, e.RowIndex).Value
            Me.txtPno.Text = DataGridView1.Item(1, e.RowIndex).Value
            Me.txtpname.Text = DataGridView1.Item(2, e.RowIndex).Value
            Me.txtage.Text = DataGridView1.Item(3, e.RowIndex).Value
            Me.txtgender.Text = DataGridView1.Item(4, e.RowIndex).Value
            Me.txttel.Text = DataGridView1.Item(5, e.RowIndex).Value
        Catch ex As Exception
            MsgBox("Invalid move. Please select the record", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ifexist.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        With FrmTreament
            .ShowDialog()
        End With
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        txtage.Text = ""
        txtpname.Text = ""
        txtpaymode.Text = ""
        txtgender.Text = ""
        txttel.Text = ""
        txtPno.Text = ""

    End Sub

    Private Sub btnReviews_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReviews.Click
        Reviews.Show()
    End Sub

    Private Sub btnResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResults.Click
        LabResult.ShowDialog()
    End Sub

    Private Sub BtnTreat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTreat.Click
        If txtPno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtPno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtage.Text = "" Then
            MsgBox("Patient Age is empty", MsgBoxStyle.Critical)
            txtage.Focus()
        Else
            With Prescription
                .txtpno.Text = Me.txtPno.Text
                .txtpno.BackColor = Color.Aqua
                .txtpno.ReadOnly = True
                .txtpname.Text = Me.txtpname.Text
                .txtpname.BackColor = Color.Aqua
                .txtpname.ReadOnly = True
                .txtgender.Text = Me.txtgender.Text
                .txtgender.BackColor = Color.Aqua
                .txtgender.ReadOnly = True
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub btnVitals_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVitals.Click
        If txtPno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtPno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtage.Text = "" Then
            MsgBox("Patient Age is empty", MsgBoxStyle.Critical)
            txtage.Focus()
        Else
            With Vitals
                .txtpno.Text = Me.txtPno.Text
                .txtpno.BackColor = Color.Aqua
                .txtpno.ReadOnly = True
                .txtpname.Text = Me.txtpname.Text
                .txtpname.BackColor = Color.Aqua
                .txtpname.ReadOnly = True
                .txtage.Text = Me.txtage.Text
                .txtage.BackColor = Color.Aqua
                .txtage.ReadOnly = True

                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub btnLab_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLab.Click
        If txtPno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtPno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtage.Text = "" Then
            MsgBox("Patient Age is empty", MsgBoxStyle.Critical)
            txtage.Focus()
        Else
            With Lab_Request
                .txtpno.Text = Me.txtPno.Text
                .txtpno.BackColor = Color.Aqua
                .txtpno.ReadOnly = True
                .txtpname.Text = Me.txtpname.Text
                .txtpname.BackColor = Color.Aqua
                .txtpname.ReadOnly = True
                .txtage.Text = Me.txtage.Text
                .txtage.BackColor = Color.Aqua
                .txtage.ReadOnly = True
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub btnPhyc_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhyc.Click
        If txtPno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtPno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtage.Text = "" Then
            MsgBox("Patient Age is empty", MsgBoxStyle.Critical)
            txtage.Focus()
        Else
            With Phyc_Exam
                .txtpno.Text = Me.txtPno.Text
                .txtpno.ReadOnly = True
                .txtpname.Text = Me.txtpname.Text
                .txtpname.ReadOnly = True
                .txtage.Text = Me.txtage.Text
                .txtage.ReadOnly = True
                .txtgender.Text = Me.txtgender.Text
                .txtgender.ReadOnly = True
                .txttel.Text = Me.txttel.Text
                .txttel.ReadOnly = True

                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Select_Procedure.ShowDialog()
    End Sub

    Private Sub btnSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        profile()
        count()
        Getdata()
        FilldgDiag()
        FilldgTreat()
        proc()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtId.Text = "" Then
            MsgBox("Treatment Id is empty", MsgBoxStyle.Critical)
            txtPno.Focus()


        Else
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "delete from outpattreatment  where T_ID = '" & txtId.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            Dim reply As String
            reply = MsgBox("Are you sure you want to delete this record???", MsgBoxStyle.YesNo, "Delete")
            If reply = MsgBoxResult.Yes Then
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Deleted successfully Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Filldg()
                clear()
            Else

            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        FrmTreatmentProfile.ShowDialog()
    End Sub
End Class