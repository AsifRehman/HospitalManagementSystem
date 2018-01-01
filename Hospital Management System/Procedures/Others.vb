Imports MySql.Data.MySqlClient
Public Class Others

    Private Sub txtsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsave.Click
        connectDB()
        Dim query As String

        If txtpno.Text = "" Then
            MsgBox("Patient Name is empty", MsgBoxStyle.Critical)
            txtpno.Focus()
        ElseIf cboprname.Text = "" Then
            MsgBox("Procedure Name field is empty", MsgBoxStyle.Critical)
            cboprname.Focus()
        ElseIf txtage.Text = "" Then
            MsgBox("Patient Age is empty", MsgBoxStyle.Critical)
            txtage.Focus()
        ElseIf txtcharges.Text = "" Then
            MsgBox("C is empty", MsgBoxStyle.Critical)
            txtcharges.Focus()

        Else
            query = "Insert into other_procedures(PatientNo,PatientName,Age,Gender,Tel,Procedure_Name,Reason,Charges,Entry_Date) values('" & txtpno.Text & "','" & txtpname.Text & "','" & txtage.Text & "','" & cbogender.Text & "','" & txttel.Text & "','" & cboprname.Text & "','" & txtReason.Text & "','" & txtcharges.Text & "','" & Format(DateTime.Today, "yyyy-MM-dd") & "')"
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call clear()
            Filldg()


        End If
        'dr.Dispose()
        conn.Close()
    End Sub
    Sub clear()

        txtpno.Clear()
        txtpname.Clear()
        txtage.Clear()
        cbogender.DataSource = Nothing
        txttel.Clear()
        cboprname.DataSource = Nothing
        txtReason.Clear()
        txtcharges.Clear()
    End Sub
    Sub Filldg()

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "SELECT PatientNo,PatientName,Age,Gender,Tel,Procedure_Name,Reason,Charges,Entry_Date FROM other_procedures "
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
            End Try

        End If
    End Sub

    Private Sub Others_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Filldg()
        fillprocedure()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Call clear()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub cboprname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboprname.SelectedIndexChanged
        Dim READER As MySqlDataReader
        Dim sql As String
        Try
            connectDB()
            sql = "select Cost from Proce_Entry where Name = '" & cboprname.Text & "' "
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