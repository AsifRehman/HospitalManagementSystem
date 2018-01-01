Imports MySql.Data.MySqlClient
Public Class FrmTreament

    Sub Lab()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        If txtSearch.Text = "" Then
            MsgBox("Please Type patient NO", MsgBoxStyle.Critical)
            txtSearch.Focus()
        Else
            connectDB()

            sql = "select * from outpatientlabresult where PatientNO = '" & txtSearch.Text & "'  AND Edate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = False Then
                MsgBox("No Record found", MsgBoxStyle.Critical)

            Else
                Me.txtlabInvs.Text = dr.GetString("Lab_Results")
                disconnect()
                dr.Close()
            End If
        End If
    End Sub
    Sub vitals()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        If txtSearch.Text = "" Then
            MsgBox("Please Type patient NO", MsgBoxStyle.Critical)
            txtSearch.Focus()
        Else
            connectDB()

            sql = "select * from outpatientvitals where PatientNO = '" & txtSearch.Text & "'  AND Edate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = False Then
                MsgBox("No Record found", MsgBoxStyle.Critical)

            Else
                Me.txtbp.Text = dr.GetString("BP")
                Me.txtpr.Text = dr.GetString("PR")
                Me.txtrr.Text = dr.GetString("RR")
                Me.txttemp.Text = dr.GetString("Temp")
                disconnect()
                dr.Close()
            End If
        End If
    End Sub

    Sub profileDocCharges()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader

        If txtSearch.Text = "" Then
            MsgBox("Please Type the patient NO", MsgBoxStyle.Critical)
            txtSearch.Focus()
        Else
            connectDB()
            sql = "Select * from outpattreatment where PatientNO= '" & txtSearch.Text & "'AND Entry_Date = '" & Format(DateTime.Today, "yyyy-MM-dd") & "'  "
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            If dr.Read = False Then
                MsgBox("This record was not found", MsgBoxStyle.Critical)

            Else
                Me.txtPno.Text = dr.GetString("PatientNO")
                Me.txtpname.Text = dr.GetString("Patient_Name")
                Me.txtage.Text = dr.GetString("Age")
                Me.txtgender.Text = dr.GetString("Gender")
                Me.txttel.Text = dr.GetString("Tel")
                Me.txtchief.Text = dr.GetString("Complains")
                Me.txthistory.Text = dr.GetString("History")

            End If
            disconnect()
            dr.Close()

        End If

    End Sub

   

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If txtPno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtPno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtage.Text = "" Then
            MsgBox("Patient Age is empty", MsgBoxStyle.Critical)
            txtage.Focus()
        ElseIf txttel.Text = "" Then
            MsgBox("Patient Telephone is empty", MsgBoxStyle.Critical)
            txttel.Focus()
        Else
            connectDB()
            Dim cmd1 As New MySqlCommand
            Dim dr2 As MySqlDataReader
            sql = "update outpattreatment set Patient_Name = '" & txtpname.Text & "',Age = '" & txtage.Text & "',Gender = '" & txtgender.Text & "',Diagnosis = '" & txtdiag.Text & "',Tel = '" & txttel.Text & "',LabInvestigation='" & txtlabInvs.Text & "' where PatientNO= '" & txtPno.Text & "' "
            cmd1 = New MySqlCommand(sql, conn)
            dr2 = cmd1.ExecuteReader
            MessageBox.Show("Saved Successfully, Proceed to prescrption", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)

            With Prescription
                .txtpno.Text = txtPno.Text
                .txtpname.Text = txtpname.Text
                .txtgender.Text = txtgender.Text
                .ShowDialog()
            End With
            Call clear()
        End If
    End Sub
    Sub clear()
        txtgender.Text = ""
        txttel.Text = ""
        txtPno.Text = ""
        txtpname.Text = ""
        txtage.Text = ""
        txtchief.Text = ""
        txthistory.Text = ""
        txtlabInvs.Text = ""
        txtdiag.Text = ""
        txttemp.Text = ""
        txtbp.Text = ""
        txtrr.Text = ""
        txtpr.Text = ""
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Close()
    End Sub
   

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        clear()
    End Sub

    
    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        profileDocCharges()
        Lab()
        vitals()
    End Sub
End Class