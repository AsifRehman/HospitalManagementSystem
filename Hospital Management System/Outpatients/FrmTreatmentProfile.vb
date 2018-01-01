
Imports MySql.Data.MySqlClient

Public Class FrmTreatmentProfile
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Getdata()
        count()
        FilldgTreat()
        proc()
        profile()
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
            End If
            disconnect()
            dr.Close()

        End If
    End Sub
    Sub count()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        If txtPno.Text = "" Then
            MsgBox("Please Type patient NO", MsgBoxStyle.Critical)
            txtPno.Focus()

        Else
            connectDB()
            sql = "select count(PatientNO)as Pno from outpatregistration where PatientNO= '" & txtPno.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = False Then

            Else

                Me.lblVno.Text = dr.GetString("Pno")
            End If
            disconnect()
            dr.Close()

        End If
    End Sub
   
    Sub Getdata()
        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select Entry_Date, Complains,History,LabInvestigation,Diagnosis from outpattreatment where PatientNO= '" & txtPno.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            dgw.DataSource = bs
            da.Update(ds)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub proc()
        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select Entry_Date, Procedure_Name from other_procedures where PatientNO= '" & txtPno.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            dgProcedure.DataSource = bs
            da.Update(ds)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub FilldgTreat()
        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource
        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select Entry_Date,MedName from outpatfinaldrugbill where PatientNO= '" & txtPno.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds)
            bs.DataSource = ds
            dgTreat.DataSource = bs
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgw_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgw.CellMouseClick
        On Error Resume Next
        If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
        Me.txtcomplains.Text = dgw.Item(1, e.RowIndex).Value
        Me.txthistory.Text = dgw.Item(2, e.RowIndex).Value
        Me.txtinvs.Text = dgw.Item(3, e.RowIndex).Value
        Me.txtdiag.Text = dgw.Item(4, e.RowIndex).Value
    End Sub

    Private Sub dgTreat_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgTreat.CellMouseClick
        On Error Resume Next
        If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
        Me.txtpres.Text = dgTreat.Item(1, e.RowIndex).Value
    End Sub

    Private Sub dgProcedure_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgProcedure.CellMouseClick
        On Error Resume Next
        If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
        Me.txtproc.Text = dgProcedure.Item(1, e.RowIndex).Value
        
    End Sub
   

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        txtage.Text = ""
        txtpname.Text = ""
        txtcomplains.Text = ""
        txtgender.Text = ""
        txttel.Text = ""
        txtPno.Text = ""
        txtpres.Text = ""
        txtdiag.Text = ""
        txthistory.Text = ""
        txtinvs.Text = ""
        txtproc.Text = ""
    End Sub

    Private Sub FrmTreatmentProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class