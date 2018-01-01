Imports MySql.Data.MySqlClient
Public Class frmlogin
    Dim level As String

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        connectDB()

        Try

            sql = "select * from login where UserName='" & Trim(txtUsername.Text) & "' and Password='" & Trim(txtPassword.Text) & "'"
            COMMAND = New MySqlCommand(sql, conn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            If READER.Read Then
                count = count + 1
                level = READER.GetString("Role")
            End If
            If count = 1 Then
                '' MsgBox("login successful ", MsgBoxStyle.Information)
                If level = "Administrator" Then
                    Main.Show()
                    Main.User.Text = txtUsername.Text
                    Main.UserType.Text = level
                    Me.Hide()
                    level = READER.GetString("Role")

                ElseIf level = "Receptionist" Then
                    Main.MasterToolStripMenuItem.Visible = False
                    Main.financeToolStripMenuItem39.Visible = False
                    Main.ReportsToolStripMenuItem49.Visible = False
                    Main.UsersToolStripMenuItem.Visible = False
                    Main.ConsultationToolStripMenuItem9.Visible = False
                    Main.LabResultsToolStripMenuItem.Visible = False
                    Main.ProceduresToolStripMenuItem.Visible = False
                    Main.PharmacyToolStripMenuItem.Visible = False
                    Main.ReceivePatientsToolStripMenuItem.Visible = False
                    Main.ToolStripButton6.Visible = False
                    Main.ToolStripButton1.Visible = False
                    Main.ToolStripButton7.Visible = False
                    Main.ToolStripButton1.Visible = False
                    Main.Show()
                    Main.User.Text = txtUsername.Text
                    Main.UserType.Text = level
                    Me.Hide()

                ElseIf level = "Doctor" Then
                    Main.MasterToolStripMenuItem.Visible = False
                    Main.financeToolStripMenuItem39.Visible = False
                    Main.ReportsToolStripMenuItem.Visible = False
                    Main.UsersToolStripMenuItem.Visible = False
                    Main.ToolStripButton6.Visible = False
                    Main.ToolStripButton1.Visible = False

                    Main.Show()
                    Main.User.Text = txtUsername.Text
                    Main.UserType.Text = level
                    Me.Hide()

                ElseIf level = "Lab_Tec" Then
                    Main.MasterToolStripMenuItem.Visible = False
                    Main.ReportsToolStripMenuItem49.Visible = False
                    Main.UsersToolStripMenuItem.Visible = False
                    Main.ViewsToolStripMenuItem32.Visible = False
                    Main.OutpatientToolStripMenuItem3.Visible = False
                    Main.BillingToolStripMenuItem.Visible = False
                    Main.LabTestPaymentToolStripMenuItem.Visible = False
                    Main.PrescribeDrugsToolStripMenuItem.Visible = False
                    Main.SellOverTheCounterToolStripMenuItem.Visible = False
                    Main.financeToolStripMenuItem39.Visible = False
                    Main.ToolStripButton6.Visible = False
                    Main.ToolStripButton1.Visible = False
                    Main.ToolStripButton12.Visible = False
                    Main.ToolStripButton9.Visible = False
                    Main.ToolStripButton4.Visible = False
                    Main.ToolStripDropDownButton3.Visible = False
                    Main.ToolStripButton8.Visible = False
                    Main.ProceduresToolStripMenuItem.Visible = False
                    Main.ToolStripButton7.Visible = False
                    Main.ToolStripMenuItem1.Visible = False
                    Main.PharmacyToolStripMenuItem.Visible = False
                    Main.ToolStripButton2.Visible = False
                    Main.Show()
                    Main.User.Text = txtUsername.Text
                    Main.UserType.Text = level
                    Me.Hide()


                ElseIf level = "Pharmacist" Then
                    Main.ReportsToolStripMenuItem.Visible = False
                    Main.UsersToolStripMenuItem.Visible = False
                    Main.ManageOutpatientsToolStripMenuItem.Visible = False
                    Main.BillingToolStripMenuItem.Visible = False
                    Main.LabTestPaymentToolStripMenuItem.Visible = False
                    Main.MasterToolStripMenuItem.Visible = False
                    'MDI.SellOverTheCounterToolStripMenuItem.Visible = False
                    Main.ToolStripButton6.Visible = False
                    Main.ToolStripButton1.Visible = False
                    Main.ToolStripButton12.Visible = False
                    Main.ToolStripButton9.Visible = False
                    Main.ToolStripButton4.Visible = False
                    'MDI.ToolStripDropDownButton3.Visible = False
                    Main.ToolStripButton8.Visible = False
                    Main.ProceduresToolStripMenuItem.Visible = False
                    Main.ToolStripButton7.Visible = False
                    Main.ToolStripMenuItem1.Visible = False
                    'MDI.InventoryToolStripMenuItem.Visible = False
                    'MDI.PharmacyToolStripMenuItem.Visible = False
                    Main.ToolStripButton2.Visible = False
                    Main.Show()
                    Main.User.Text = txtUsername.Text
                    Main.UserType.Text = level
                    Me.Hide()

                End If
            ElseIf count > 1 Then
                MsgBox("login has a Duplicate Values ", MsgBoxStyle.Critical)
            Else
                MsgBox("ERROR! Wrong User Name or Password ", MsgBoxStyle.Critical)
            End If
            conn.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lnkExit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkExit.LinkClicked
        If MsgBox("Are you sure you want to Turn off system?", MsgBoxStyle.YesNo, "Close Window") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub lnkAbout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAbout.LinkClicked
        frmAbout.ShowDialog()
    End Sub
    Private Sub clear()
        txtUsername.Text = ""
        txtPassword.Text = ""

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call clear()
    End Sub
End Class