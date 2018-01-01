Public Class frmSplashScreen
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
      


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Timer1.Tag = Timer1.Tag + 1
        'ProgressBar1.Value = ProgressBar1.Value + 1
        'Me.lblpercentage.Text = ProgressBar1.Value & "%"
        'If ProgressBar1.Value < 10 Then
        '    Me.lblLoading.Text = "Intializing Digital Environment, Please standby......"
        'ElseIf ProgressBar1.Value < 40 Then
        '    Me.lblLoading.Text = "Connecting To LocalServer................."
        'ElseIf ProgressBar1.Value < 60 Then
        '    Me.lblLoading.Text = "Applying System Settings................."
        'ElseIf ProgressBar1.Value < 80 Then
        '    Me.lblLoading.Text = "Intergrating Database Configuration................."
        'ElseIf ProgressBar1.Value < 90 Then
        '    Me.lblLoading.Text = "Openning system, please wait................."
        'End If
        'If ProgressBar1.Value = 100 Then
        '    Me.Hide()
        '    frmlogin.Show()
        '    Timer1.Enabled = False
        'End If
    End Sub
    'Dim y As Integer
    'Dim i As Integer
    'Private Sub frmSplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Fadein()
    '    '  Me.Height = 0
    '    ' Timer1.Enabled = True
    '    Timer2.Enabled = True
    '    Timer1.Start()
    '    Timer1.Interval = 50
    'End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    'y += 10
    '    'Me.Height = y
    '    'If y = 260 Then
    '    '    y = 0
    '    '    Timer1.Enabled = False
    '    '    Timer2.Enabled = True
    '    ProgressBar1.Increment(1)

    '    If ProgressBar1.Value = ProgressBar1.Maximum Then
    '        Timer1.Enabled = False
    '        frmlogin.Show()
    '        Me.Hide()

    '    End If

    'End Sub

    'Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
    '    i += 1
    '    If i > 4 Then
    '        frmlogin.Show()
    '        '[frmLogin.Show()
    '        Me.Hide()
    '        Timer2.Enabled = False
    '    End If


    'End Sub

    'Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

   
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Timer3.Tag = Timer3.Tag + 1
        'VCircularProgressBar1.Increment(1)
        VCircularProgressBar1.Value = VCircularProgressBar1.Value + 1

        If VCircularProgressBar1.Value = 100 Then
            Timer3.Enabled = False
            Me.Hide()
            Main.ShowDialog()
            'frmlogin.Show()

        End If
    End Sub

    Private Sub frmSplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class