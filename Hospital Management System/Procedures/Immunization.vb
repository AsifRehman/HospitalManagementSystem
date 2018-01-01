Imports MySql.Data.MySqlClient
Public Class Immunization


    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        connectDB()
        Dim query As String

        If txtParentName.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtParentName.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Child Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtage.Text = "" Then
            MsgBox("Patient Age is empty", MsgBoxStyle.Critical)
            txtage.Focus()
        ElseIf txtparentTel.Text = "" Then
            MsgBox("Patient Tel is empty", MsgBoxStyle.Critical)
            txtparentTel.Focus()

        Else
            query = "Insert into immunization(PatientNo,Patient_Name,Age,ParentName,Parent_Tel,Weight,Duration,Charges,Remarks,Entry_Date) values('" & txtsearch.Text & "','" & txtpname.Text & "','" & txtage.Text & "','" & txtParentName.Text & "','" & txtparentTel.Text & "','" & txtweight.Text & "','" & cboDuration.Text & "','" & txtchange.Text & "','" & txtremarks.Text & "','" & Format(DateTime.Today, "yyyy-MM-dd") & "')"
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call clear()

            Filldg()

        End If
        ' dr.Dispose()
        conn.Close()
    End Sub
    Sub clear()
        'txtentyNo.Text = ""
        txtpname.Text = ""
        txtParentName.Text = ""
        txtage.Text = ""
        txtweight.Text = ""
        cboImmName.Text = ""
        cboDuration.Text = ""
        txtparentTel.Text = ""
        txtchange.Text = ""

    End Sub

    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click
        If txtsearch.Text = "" Then
            MsgBox("Patient NO is empty", MsgBoxStyle.Critical)
            txtsearch.Focus()
        ElseIf txtParentName.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtParentName.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Child Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtage.Text = "" Then
            MsgBox("Patient Age is empty", MsgBoxStyle.Critical)
            txtage.Focus()
        ElseIf txtparentTel.Text = "" Then
            MsgBox("Patient Tel is empty", MsgBoxStyle.Critical)
            txtparentTel.Focus()

        Else
            connectDB()
            Dim cmd As New MySqlCommand
            '  ,,,,,,,Charges
            sql = "update immunization set Patient_Name='" & txtpname.Text & "',Age='" & txtage.Text & "',ParentName= '" & txtParentName.Text & "',Parent_Tel= '" & txtparentTel.Text & "',Im_Name= '" & cboImmName.Text & "',Weight= '" & txtweight.Text & "',Duration= '" & cboDuration.Text & "',Charges= '" & txtchange.Text & "' where PatientNo= '" & txtsearch.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            MessageBox.Show("Data Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Filldg()
        End If
    End Sub

    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        cmdsave.Visible = True
        cmdupdate.Visible = False
        cmddelete.Visible = False
        Me.txtpid.ReadOnly = False
        Me.txtpid.Text = ""
        Call clear()
    End Sub

    Private Sub Immunization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectDB()
        Filldg()
        'lbldate.Text = DateTime.Today

    End Sub

    Sub Filldg()

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "SELECT ID,PatientNo,Patient_Name,Age,ParentName,Parent_Tel,Weight,Duration,Charges, Remarks FROM immunization "
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
        On Error Resume Next
        If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
        Me.txtpid.Text = DataGridView1.Item(1, e.RowIndex).Value
        Me.txtpid.ReadOnly = True
        Me.txtpname.Text = DataGridView1.Item(2, e.RowIndex).Value
        Me.txtage.Text = DataGridView1.Item(3, e.RowIndex).Value
        Me.txtParentName.Text = DataGridView1.Item(4, e.RowIndex).Value
        Me.txtparentTel.Text = DataGridView1.Item(5, e.RowIndex).Value
        Me.txtweight.Text = DataGridView1.Item(6, e.RowIndex).Value
        Me.cboDuration.Text = DataGridView1.Item(7, e.RowIndex).Value
        Me.txtchange.Text = DataGridView1.Item(8, e.RowIndex).Value
        Me.txtremarks.Text = DataGridView1.Item(9, e.RowIndex).Value
        'btnSave.Visible = False

    End Sub
    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        If txtsearch.Text = "" Then
            MsgBox("Patient NO is empty", MsgBoxStyle.Critical)
            txtsearch.Focus()
        ElseIf txtParentName.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtParentName.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Child Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtage.Text = "" Then
            MsgBox("Patient Age is empty", MsgBoxStyle.Critical)
            txtage.Focus()
        ElseIf txtparentTel.Text = "" Then
            MsgBox("Patient Tel is empty", MsgBoxStyle.Critical)
            txtparentTel.Focus()

        Else
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "delete from immunization  where PatientNo= '" & txtsearch.Text & "' and  Im_Name = '" & cboImmName.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            Dim reply As String
            reply = MsgBox("Are you sure you want to delete this record???", MsgBoxStyle.YesNo, "Delete")
            If reply = MsgBoxResult.Yes Then

                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Deleted successfully Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Filldg()
            Else

            End If
        End If
    End Sub

    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
        connectDB()
        Dim READER As MySqlDataReader
        Dim cmd As New MySqlCommand
        Dim sql As String

        If txtsearch.Text = "" Then
            MsgBox("Please Type patient NO", MsgBoxStyle.Critical)
            txtsearch.Focus()
        Else

            Try

                ' connectDB()
                sql = "Select * from outpatregistration where PatientNO= '" & txtsearch.Text & "' and 	Entry_Date = '" & Format(DateTime.Today, "yyyy-MM-dd") & "'"
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
                End If
            Catch ex As MySqlException
                MsgBox(ex.ToString)
            Finally
                disconnect()
                ' READER.Close()
            End Try


        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim query As String
        connectDB()

        query = "Insert into imm_vaccine(PatientNO,PatientName,Age,Telephone,Vaccine_Name,Entry_Date) values('" & txtsearch.Text & "','" & txtpname.Text & "','" & txtage.Text & "','" & txtparentTel.Text & "','" & cboImmName.Text & "','" & Format(DateTime.Today, "yyyy-MM-dd") & "')"
        If txtsearch.Text = "" Then
            MsgBox("Patient NO is empty", MsgBoxStyle.Critical)
            txtsearch.Focus()
        ElseIf txtParentName.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtParentName.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Child Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtage.Text = "" Then
            MsgBox("Patient Age is empty", MsgBoxStyle.Critical)
            txtage.Focus()
        ElseIf txtparentTel.Text = "" Then
            MsgBox("Patient Tel is empty", MsgBoxStyle.Critical)
            txtparentTel.Focus()
        ElseIf cboImmName.Text = "" Then
            MsgBox("No vaccine Selected", MsgBoxStyle.Critical)
            cboImmName.Focus()

        Else
            sql = "select * from imm_vaccine where PatientNO= '" & txtsearch.Text & "' and Vaccine_Name= '" & cboImmName.Text & "' and Entry_Date =  '" & Format(DateTime.Today, "yyyy-MM-dd") & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            If dr.Read = False Then
                cmd = New MySqlCommand(query, conn)
                dr.Close()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Done", "Saved", MessageBoxButtons.OK)
                cboImmName.Text = ""
                'Call AutoGenRegno()
                FillVaccine()
            Else

                MessageBox.Show("Data Already Exists", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FillVaccine()
            End If
        End If
        ' dr.Dispose()
        conn.Close()



    End Sub
    Sub FillVaccine()

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "SELECT ID,Vaccine_Name,Entry_Date FROM imm_vaccine where PatientNO= '" & txtsearch.Text & "'  and Entry_Date =  '" & Format(DateTime.Today, "yyyy-MM-dd") & "' "
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

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MCHWklyReport.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MCHProfileRpt.Show()
    End Sub
End Class