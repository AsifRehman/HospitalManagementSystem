Imports MySql.Data.MySqlClient
Public Class OutpatLabTreatment

    Private Sub frmLab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call filllabCombo()
        lbltime.Text = DateTime.Today
    End Sub

    Private Sub cbopno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbopno.SelectedIndexChanged
        Dim READER As MySqlDataReader
        Dim sql As String
        Try
            connectDB()
            'Dim Lbqst As String
            'Lbqst = "YES"
            sql = "select Patient_Name from outpatientlabrequest where PatientNo = '" & cbopno.Text & "' and  Edate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "' "
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader
            While READER.Read
                txtpname.Text = READER.GetString("Patient_Name")
                txtpname.ReadOnly = True


            End While
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            conn.Dispose()
        End Try
        fillTests()
    End Sub
    Sub fillTests()
        connectDB()
        RefreshDB()
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsourse As New BindingSource
        Try
            Dim query As String
            query = "select TestName,Edate,Charges from outpatientlabrequest where  PatientNo = '" & cbopno.Text & "' and  Edate = '" & Format(DateTime.Today, "yyyy-MM-dd") & "'"
            COMMAND = New MySqlCommand(query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbdataset)
            bsourse.DataSource = dbdataset
            DataGridView1.DataSource = bsourse
            SDA.Update(dbdataset)
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Try
            If cbopno.Text = "" Then
                MsgBox("Patient Number is empty", MsgBoxStyle.Critical)
                cbopno.Focus()
            ElseIf txtpname.Text = "" Then
                MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
                txtpname.Focus()
            ElseIf txtlresults.Text = "" Then
                MsgBox("Lab Result is empty", MsgBoxStyle.Critical)
                txtlresults.Focus()


            Else
                connectDB()
                Dim cmd As New MySqlCommand
                sql = "Insert Into outpatientlabresult(PatientNO,Patient_Name,Lab_Results,Edate) VALUES ('" & cbopno.Text & _
                "','" & txtpname.Text & _
                "','" & txtlresults.Text & _
                "','" & Format(DateTime.Today, "yyyy-MM-dd") & "')"
                cmd = New MySqlCommand(sql, conn)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Me.Close()
                Call clear()
            End If
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Sub clear()
        txtlresults.Clear()
        txtpname.Clear()
        cbopno.Text = ""

        DataGridView1.DataSource = Nothing
        cbopno.DataSource = Nothing
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub
End Class