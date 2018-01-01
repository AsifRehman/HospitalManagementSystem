Imports MySql.Data.MySqlClient

Public Class frmLock

    Private Sub frmLock_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmLock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        AcceptButton = Button1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ValidatePassword()
    End Sub
    Private Sub ValidatePassword()
        Try
            sql = "SELECT * FROM login WHERE Password = '" & TextBox1.Text & "'"
            connectDB()
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader()

            If dr.Read = True Then
                MsgBox("System Unlocked", MsgBoxStyle.Information, "")
                Me.Close()
            Else
                MsgBox("Invalid Password.", MsgBoxStyle.Critical, "Invalid")
                TextBox1.SelectAll()
                TextBox1.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "taskmgr" Then
                selProcess.Kill()
                Exit For
            End If
        Next
    End Sub
End Class