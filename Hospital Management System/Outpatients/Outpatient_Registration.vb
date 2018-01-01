Imports MySql.Data.MySqlClient
Public Class Outpatient_Registration
    Dim query As String
 
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        connectDB()

        Dim stt As String
        stt = "NT"
        query = "Insert into outpatregistration(PatientNO,PName,Age,Gender,Location,Tel,Pay_Mode,Charges,Entry_Date,Status) values('" & txtpno.Text & "','" & txtpname.Text & "','" & txtage.Text & "','" & cbogender.Text & "','" & txtlocation.Text & "','" & txttel.Text & "','" & cboPay.Text & "','" & txtcharges.Text & "','" & Format(DateTime.Today, "yyyy-MM-dd") & "','" & stt & "')"

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

        Else
            sql = "select * from outpatregistration where PatientNO= '" & txtpno.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            If dr.Read = False Then
                cmd = New MySqlCommand(query, conn)
                dr.Close()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call clear()
                Call AutoGenRegno()
                Filldg()
            Else

                MessageBox.Show("Data Exists", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
                
            End If
            dr.Dispose()
            conn.Close()
        End If

    End Sub

    Sub clear()
        txtpno.Text = ""
        txtpname.Text = ""
        txtage.Text = ""
        cbogender.Text = ""
        txtlocation.Text = ""
        txttel.Text = ""
        cboPay.Text = ""
        txtcharges.Text = ""
        AutoGenRegno()

    End Sub

    Private Sub AutoGenRegno()

        Try
            connectDB()
            Dim num As String
            num = "1001"

            sql = " select PatientNO from outpatregistration order by PatientNO desc"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtpno.Text = dr("PatientNO") + 1
                txtpno.ReadOnly = True
            Else
                txtpno.Text = num
                txtpno.ReadOnly = True
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        If e.RowIndex < 0 Then MsgBox("select an item", "", MsgBoxStyle.Critical)
        Me.txtpno.Text = DataGridView1.Item(0, e.RowIndex).Value
        Me.txtpno.ReadOnly = True
        Me.txtpname.Text = DataGridView1.Item(1, e.RowIndex).Value
        Me.txtage.Text = DataGridView1.Item(2, e.RowIndex).Value
        Me.cbogender.Text = DataGridView1.Item(3, e.RowIndex).Value
        Me.txtlocation.Text = DataGridView1.Item(4, e.RowIndex).Value
        Me.txttel.Text = DataGridView1.Item(5, e.RowIndex).Value
        Me.cboPay.Text = DataGridView1.Item(6, e.RowIndex).Value
        Me.txtcharges.Text = DataGridView1.Item(7, e.RowIndex).Value

        btnUpdate.Visible = True
        btnSave.Visible = False
        cmddelete.Visible = True
        'Me.Hide()
        'Me.StartPosition = FormStartPosition.CenterScreen
        'Me.Show()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        btnUpdate.Visible = False
        btnSave.Visible = True
        Filldg()
        clear()
        AutoGenRegno()
    End Sub

    Sub Filldg()


        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select PatientNO,PName,Age,Gender,Location,Tel,Pay_Mode,Charges,Entry_Date from outpatregistration where PName  like '" & txtsearch.Text & "%'"
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
    Private Sub Outpatient_Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AutoGenRegno()
        Filldg()
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged

        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select PatientNO,PName,Age,Gender,Location,Tel,Pay_Mode,Charges,Entry_Date from outpatregistration  where PName  like '" & txtsearch.Text & "%'"
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtpno.Text = "" Then
            MsgBox("Patient No is empty", MsgBoxStyle.Critical)
            txtpno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Child Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtage.Text = "" Then
            MsgBox("Patient Age is empty", MsgBoxStyle.Critical)
            txtage.Focus()


        Else
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "delete from outpatregistration  where PatientNo= '" & txtpno.Text & "' "
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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
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
        Else
            connectDB()
            Dim cmd1 As New MySqlCommand
            Dim dr2 As MySqlDataReader
            sql = "update outpatregistration set PName = '" & txtpname.Text & "',Age = '" & txtage.Text & "',Gender = '" & cbogender.Text & "',Location = '" & txtlocation.Text & "',Tel = '" & txttel.Text & "',Pay_Mode='" & cboPay.Text & "' where PatientNO= '" & txtpno.Text & "' "
            cmd1 = New MySqlCommand(sql, conn)
            dr2 = cmd1.ExecuteReader
            MessageBox.Show("Data updated successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call clear()
            Call AutoGenRegno()
            Filldg()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim da As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource

        Try
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "select PatientNO,PName,Age,Gender,Location,Tel,Pay_Mode,Charges,Entry_Date from outpatregistration where Tel  like '" & TextBox1.Text & "%'"
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        If txtpno.Text = "" Then
            MsgBox("Patient No is empty", MsgBoxStyle.Critical)
            txtpno.Focus()
        ElseIf txtpname.Text = "" Then
            MsgBox("Child Name is empty", MsgBoxStyle.Critical)
            txtpname.Focus()
        ElseIf txtage.Text = "" Then
            MsgBox("Patient Age is empty", MsgBoxStyle.Critical)
            txtage.Focus()


        Else
            connectDB()
            Dim cmd As New MySqlCommand
            sql = "delete from outpatregistration  where PatientNo= '" & txtpno.Text & "' "
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

    Private Sub txtpname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpname.KeyPress
        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            txtpname.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub

End Class