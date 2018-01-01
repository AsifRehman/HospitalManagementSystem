Imports MySql.Data.MySqlClient
Public Class Phyc_Exam

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        connectDB()

        If txtpno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtpno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()

        Else
            sql = "Insert into outpattreatment(PatientNO,Patient_Name,Age,Gender,Tel,Complains,History,LabInvestigation,Diagnosis,NextReview,Entry_Date) values('" & txtpno.Text & "','" & txtpname.Text & "','" & txtage.Text & "','" & txtgender.Text & "','" & txttel.Text & "','" & txtchief.Text & "','" & txthistory.Text & "','" & txtlabInvs.Text & "','" & txtdiag.Text & "','" & DtpReveiw.Text & "','" & Format(DateTime.Today, "yyyy-MM-dd") & "')"
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()


            MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call clear()
            With Consultation
                .Filldg()
            End With
            Me.Close()
        End If
        dr.Dispose()
        conn.Close()
    End Sub
    Sub clear()
        txtpno.Text = ""
        txtpname.Text = ""
        txtage.Text = ""
        txtchief.Text = ""
        txthistory.Text = ""
        txtlabInvs.Text = ""
        txtdiag.Text = ""
        DtpReveiw.Text = Format(DateTime.Today, "yyyy-MM-dd")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Phyc_Exam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class