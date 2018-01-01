
Imports MySql.Data.MySqlClient
Public Class frmFamplan
    Private Sub frmFamplan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectDB()
        Filldg()
        fillFamilyPlanning()

    End Sub
    Sub Filldg()

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "SELECT PatientNo,Patient_Name,Age,Method,Status,Period,Tel,Weight,Bp,Price,Remarks FROM fplanning  "
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
   
    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        cmdsave.Visible = True
        cmdupdate.Visible = False
        
        Call clear()
    End Sub
    Sub clear()
        txtpid.Text = ""
        txtpname.Text = ""
        txtage.Text = ""
        cboMethod.Text = ""
        txtcharges.Text = "0.00"
        txttel.Text = ""
        txtremarks.Text = ""
        txtwight.Text = "0"
        cboStatus.Text = ""
        txtbp.Text = ""
        DtpReveiw.Text = Format(DateTime.Today, "yyyy-MM-dd")



    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        connectDB()
        Dim query As String

        If txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtcharges.Text = "" Then
            MsgBox("charges are empty", MsgBoxStyle.Critical)
            txtcharges.Focus()
        ElseIf txtage.Text = "" Then
            MsgBox("Patient Age is empty", MsgBoxStyle.Critical)
            txtage.Focus()
        ElseIf cboMethod.Text = "" Then
            MsgBox("Method field is empty", MsgBoxStyle.Critical)
            cboMethod.Focus()

        Else
            query = "Insert into  fplanning (PatientNo,Patient_Name,Age,Method,Status,Period,Tel,Weight,Bp,Remarks,Price,Entry_Date) values('" & txtpid.Text & "','" & txtpname.Text & "','" & txtage.Text & "','" & cboMethod.Text & "','" & cboStatus.Text & "','" & DtpReveiw.Value.Now & "','" & txttel.Text & "','" & txtwight.Text & "','" & txtbp.Text & "','" & txtremarks.Text & "','" & txtcharges.Text & "','" & Format(DateTime.Today, "yyyy-MM-dd") & "')"
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call clear()
            Filldg()

        End If
        dr.Dispose()
        conn.Close()
    End Sub

    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click

        If txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtcharges.Text = "" Then
            MsgBox("charges are empty", MsgBoxStyle.Critical)
            txtcharges.Focus()
        ElseIf txtage.Text = "" Then
            MsgBox("Patient Age is empty", MsgBoxStyle.Critical)
            txtage.Focus()
        ElseIf cboMethod.Text = "" Then
            MsgBox("Method field is empty", MsgBoxStyle.Critical)
            cboMethod.Focus()

        Else
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "update fplanning set Patient_Name='" & txtpname.Text & "',Age='" & txtage.Text & "',Method = '" & cboMethod.Text & "',Period= '" & DtpReveiw.Value.Date & "',Price= '" & txtcharges.Text & "',Tel= '" & txttel.Text & "',Status= '" & cboStatus.Text & "',Remarks= '" & txtremarks.Text & "' where PatientNo= '" & txtpno.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            MessageBox.Show("Data Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Filldg()
        End If
    End Sub



    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtcharges.Text = "" Then
            MsgBox("charges are empty", MsgBoxStyle.Critical)
            txtcharges.Focus()
        ElseIf txtage.Text = "" Then
            MsgBox("Patient Age is empty", MsgBoxStyle.Critical)
            txtage.Focus()
        ElseIf cboMethod.Text = "" Then
            MsgBox("Method field is empty", MsgBoxStyle.Critical)
            cboMethod.Focus()

        Else
            connectDB()
            Dim cmd As New MySqlCommand
            Dim reply As String
            sql = "delete from fplanning  where PatientNo= '" & txtpno.Text & "' and Method = '" & cboMethod.Text & "'  "
            cmd = New MySqlCommand(sql, conn)

            reply = MsgBox("Are you sure you want to delete this record???", MsgBoxStyle.YesNoCancel, "Delete")
            If reply = MsgBoxResult.Yes Then
                dr = cmd.ExecuteReader
                MessageBox.Show("Data Delete Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Filldg()
            Else

            End If
        End If
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub


    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        connectDB()
        Dim READER As MySqlDataReader
        Dim cmd As New MySqlCommand
        Dim sql As String

        If txtpno.Text = "" Then
            MsgBox("Please Type patient NO", MsgBoxStyle.Critical)
            txtpno.Focus()
        Else

            Try

                ' connectDB()
                sql = "Select * from outpatregistration where PatientNO= '" & txtpno.Text & "' and 	Entry_Date = '" & Format(DateTime.Today, "yyyy-MM-dd") & "'"
                cmd = New MySqlCommand(sql, conn)
                READER = cmd.ExecuteReader

                If READER.Read = False Then
                    MsgBox("No record found", MsgBoxStyle.Critical)
                    ' Call clear()
                Else
                    Me.txtpid.Text = READER.GetString("PatientNO")
                    Me.txtpid.ReadOnly = True
                    Me.txtpid.BackColor = Color.Aqua
                    Me.txtpname.Text = READER.GetString("PName")
                    Me.txtpname.ReadOnly = True
                    Me.txtpname.BackColor = Color.Aqua
                    Me.txtage.Text = READER.GetString("Age")
                    Me.txtage.ReadOnly = True
                    Me.txtage.BackColor = Color.Aqua
                    Me.txttel.Text = READER.GetString("Tel")
                    Me.txttel.ReadOnly = True
                    Me.txttel.BackColor = Color.Aqua
                End If
            Catch ex As MySqlException
                MsgBox(ex.ToString)
            Finally
                disconnect()
                ' READER.Close()
            End Try


        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FPReport.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frmfPlanRevisits.ShowDialog()
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

    Private Sub cboMethod_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMethod.SelectedIndexChanged
        Dim READER As MySqlDataReader
        Dim sql As String
        Try
            connectDB()
            sql = "select Cost from tblfp where Name = '" & cboMethod.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            While READER.Read
                txtcharges.Text = READER.GetString("Cost")
                txtcharges.ReadOnly = True

            End While
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conn.Dispose()
        End Try
    End Sub

End Class