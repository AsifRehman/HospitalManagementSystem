Imports MySql.Data.MySqlClient

Public Class Sick_Off
    Dim query As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        connectDB()

        'Dim stt As String
        'stt = "NT"
        query = "Insert into sick_off(PatientNO,PName,Age,Gender,Location,Tel,Charges,Compains,History,Examination,impression,LabInvestigation,NextReview,Entry_Date) values('" & txtpno.Text & "','" & txtpname.Text & "','" & txtage.Text & "','" & cbogender.Text & "','" & txtlocation.Text & "','" & txttel.Text & "','" & txtcharges.Text & "','" & txtchief.Text & "','" & txthistory.Text & "','" & txtexam.Text & "','" & txtexpres.Text & "','" & txtlab.Text & "','" & DtpReveiw.Text & "','" & DateTime.Today & "')"

        If txtpno.Text = "" Then
            MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
            txtpno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtage.Text = "" Then
            MsgBox("Patient Age is empty", MsgBoxStyle.Critical)
            txtage.Focus()
        ElseIf txttel.Text = "" Then
            MsgBox("Patient Telephone is empty", MsgBoxStyle.Critical)
            txttel.Focus()
        ElseIf txtcharges.Text = "" Then
            MsgBox("Charges Field is empty", MsgBoxStyle.Critical)
            txtcharges.Focus()
        Else
            sql = "select * from sick_off where PatientNO= '" & txtpno.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            If dr.Read = False Then
                cmd = New MySqlCommand(query, conn)
                dr.Close()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

                With SickOffReceipt
                    .lblPNO.Text = Me.txtpno.Text

                    .ShowDialog()
                End With


                Call clear()
                Call AutoGenRegno()
                'Filldg()
            Else

            End If
            dr.Dispose()
            conn.Close()
        End If
    End Sub
    Private Sub AutoGenRegno()

        Try
            connectDB()
            Dim num As String
            num = 100

            sql = " select PatientNO from sick_off order by PatientNO desc"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtpno.Text = dr("PatientNO") + 1
            Else
                txtpno.Text = num

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub
    Sub clear()
        txtpno.Text = ""
        txtpname.Text = ""
        txtage.Text = ""
        cbogender.Text = ""
        txtlocation.Text = ""
        txttel.Text = ""
        txtcharges.Text = ""
        txtchief.Text = ""
        txthistory.Text = ""
        txtexam.Text = ""
        txtexpres.Text = ""
        txtlab.Text = ""
        DtpReveiw.Text = DateTime.Today
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        clear()
        AutoGenRegno()
    End Sub

    Private Sub Sick_Off_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutoGenRegno()
    End Sub

    Private Sub txtexam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtexam.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class