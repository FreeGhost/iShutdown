Imports System.ComponentModel
Imports System.Threading

Public Class MainWindow
    Dim H, M, S As Integer
    Dim AllowedChars As String = "0123456789"
    Public IsForced As Boolean
    Dim MutexOBJ As Mutex, MutexKey As String = "jA0ECQMCW2Fgp4+LRiWy0j4B1BmwDl7LYbjp9DRUizzqVVSQIOcMkoTKnOgHwzAU/nMEtNoTEllHnJjDipHPxNcAsXizWeCJd+6f7Cnr6A===DS2V"

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MutexOBJ = New Mutex(False, MutexKey)
        If MutexOBJ.WaitOne(0, False) = False Then
            MutexOBJ.Close()
            MutexOBJ = Nothing
            MsgBox("Could not launch iShutdown" & vbCrLf & "Only one instance of iShutdown can be run at a time.", MsgBoxStyle.Critical, "iShutdown - ERROR")
            Close()
        End If
        Left = My.Computer.Screen.WorkingArea.Width - Width - 16
        Top = My.Computer.Screen.WorkingArea.Height + 16
        ShowHideTimer.Start()
    End Sub

    Private Sub ShowHideTimer_Tick(sender As Object, e As EventArgs) Handles ShowHideTimer.Tick
        If ShowHideTimer.Tag = "Show" Then
            If Top > My.Computer.Screen.WorkingArea.Height - Height - 16 Then
                Top -= 10
                ShowHideTimer.Start()
            Else
                Top = My.Computer.Screen.WorkingArea.Height - Height - 16
                ShowHideTimer.Stop()
            End If
        ElseIf ShowHideTimer.Tag = "Hide" Then
            If Top < My.Computer.Screen.WorkingArea.Height + 16 Then
                Top += 10
                ShowHideTimer.Start()
            Else
                Top = My.Computer.Screen.WorkingArea.Height + 16
                ShowHideTimer.Stop()
                Hide()
                NotifyIcon.Visible = True
            End If
        End If
    End Sub

    Private Sub HoursComboBox_LostFocus(sender As Object, e As EventArgs) Handles HoursComboBox.LostFocus
        If Not HoursComboBox.Text = "Hours" Then
            Dim CheckInt As Integer
            Try
                CheckInt = HoursComboBox.Text
                If CheckInt > 24 Then
                    HoursComboBox.Text = "Hours"
                    HoursComboBox.ForeColor = Color.Gray
                    Beep()
                Else
                    HoursComboBox.ForeColor = Color.Black
                End If
            Catch
                HoursComboBox.Text = "Hours"
                HoursComboBox.ForeColor = Color.Gray
                Beep()
            End Try
        End If
    End Sub

    Private Sub HoursComboBox_DropDown(sender As Object, e As EventArgs) Handles HoursComboBox.DropDown
        HoursComboBox.ForeColor = Color.Black
    End Sub

    Private Sub HoursComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles HoursComboBox.DropDownClosed
        HoursComboBox.ForeColor = Color.Gray
    End Sub

    Private Sub HoursComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HoursComboBox.KeyPress
        If AllowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = False
        End If
    End Sub

    Private Sub HoursComboBox_TextChanged(sender As Object, e As EventArgs) Handles HoursComboBox.TextChanged
        If HoursComboBox.Text = "Hours" Then
            HoursComboBox.ForeColor = Color.Gray
        Else
            HoursComboBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub MinutesComboBox_LostFocus(sender As Object, e As EventArgs) Handles MinutesComboBox.LostFocus
        If Not MinutesComboBox.Text = "Minutes" Then
            Dim CheckInt As Integer
            Try
                CheckInt = MinutesComboBox.Text
                If CheckInt > 60 Then
                    MinutesComboBox.Text = "Minutes"
                    MinutesComboBox.ForeColor = Color.Gray
                    Beep()
                Else
                    MinutesComboBox.ForeColor = Color.Black
                End If
            Catch
                MinutesComboBox.Text = "Minutes"
                MinutesComboBox.ForeColor = Color.Gray
                Beep()
            End Try
        End If
    End Sub

    Private Sub MinutesComboBox_DropDown(sender As Object, e As EventArgs) Handles MinutesComboBox.DropDown
        MinutesComboBox.ForeColor = Color.Black
    End Sub

    Private Sub MinutesComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles MinutesComboBox.DropDownClosed
        MinutesComboBox.ForeColor = Color.Gray
    End Sub

    Private Sub MinutesComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MinutesComboBox.KeyPress
        If AllowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = False
        End If
    End Sub

    Private Sub MinutesComboBox_TextChanged(sender As Object, e As EventArgs) Handles MinutesComboBox.TextChanged
        If MinutesComboBox.Text = "Minutes" Then
            MinutesComboBox.ForeColor = Color.Gray
        Else
            MinutesComboBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub SecondsComboBox_LostFocus(sender As Object, e As EventArgs) Handles SecondsComboBox.LostFocus
        If Not SecondsComboBox.Text = "Seconds" Then
            Dim CheckInt As Integer
            Try
                CheckInt = SecondsComboBox.Text
                If CheckInt > 60 Then
                    SecondsComboBox.Text = "Seconds"
                    SecondsComboBox.ForeColor = Color.Gray
                    Beep()
                Else
                    SecondsComboBox.ForeColor = Color.Black
                End If
            Catch
                SecondsComboBox.Text = "Seconds"
                SecondsComboBox.ForeColor = Color.Gray
                Beep()
            End Try
        End If
    End Sub

    Private Sub SecondsComboBox_DropDown(sender As Object, e As EventArgs) Handles SecondsComboBox.DropDown
        SecondsComboBox.ForeColor = Color.Black
    End Sub

    Private Sub SecondsComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles SecondsComboBox.DropDownClosed
        SecondsComboBox.ForeColor = Color.Gray
    End Sub

    Private Sub SecondsComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SecondsComboBox.KeyPress
        If AllowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = False
        End If
    End Sub

    Private Sub SecondsComboBox_TextChanged(sender As Object, e As EventArgs) Handles SecondsComboBox.TextChanged
        If SecondsComboBox.Text = "Seconds" Then
            SecondsComboBox.ForeColor = Color.Gray
        Else
            SecondsComboBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ActionComboBox_Validating(sender As Object, e As CancelEventArgs) Handles ActionComboBox.Validating
        If Not "Shutdown Restart Hibernate Log off".Contains(ActionComboBox.Text) Then
            ActionComboBox.Select()
            Beep()
        End If
    End Sub

    Private Sub StartBUT_Click(sender As Object, e As EventArgs) Handles StartBUT.Click
        Try
            If Not HoursComboBox.Text = "Hours" Then
                H = HoursComboBox.Text
                If Not H < 24 Then GoTo HTimeError
            End If
            If Not MinutesComboBox.Text = "Minutes" Then
                M = MinutesComboBox.Text
                If Not M < 60 Then GoTo MTimeError
            End If
            If Not SecondsComboBox.Text = "Seconds" Then
                S = SecondsComboBox.Text
                If Not S < 60 Then GoTo STimeError
            End If
            If Not "Shutdown Restart Hibernate Log off".Contains(ActionComboBox.Text) Then GoTo ATimeError
            ShowHideTimer.Tag = "Hide"
            ShowHideTimer.Start()
            CountDownTimer.Start()
            HideStopBUTLabel.Visible = False
        Catch
            SecondsComboBox.Text = "Seconds"
            SecondsComboBox.ForeColor = Color.Gray
            SecondsComboBox.Text = "Minutes"
            SecondsComboBox.ForeColor = Color.Gray
            SecondsComboBox.Text = "Hours"
            SecondsComboBox.ForeColor = Color.Gray
            Beep()
        End Try
        Exit Sub
HTimeError:
        SecondsComboBox.Text = "Hours"
        SecondsComboBox.ForeColor = Color.Gray
        Beep()
        Exit Sub
MTimeError:
        SecondsComboBox.Text = "Minutes"
        SecondsComboBox.ForeColor = Color.Gray
        Beep()
        Exit Sub
STimeError:
        SecondsComboBox.Text = "Seconds"
        SecondsComboBox.ForeColor = Color.Gray
        Beep()
        Exit Sub
ATimeError:
        ActionComboBox.Select()
        Beep()
    End Sub

    Private Sub CountDownTimer_Tick(sender As Object, e As EventArgs) Handles CountDownTimer.Tick
        If S = 0 Then
            If M = 0 Then
                If H = 0 Then
                    Dim IsForcedChar As String = ""
                    If IsForced Then
                        IsForcedChar = "-f "
                    End If
                    Select Case ActionComboBox.Text
                        Case "Shutdown"
                            Shell("shutdown -s " & IsForcedChar & "-t 00")
                        Case "Restart"
                            Shell("shutdown -r " & IsForcedChar & "-t 00")
                        Case "Hibernate"
                            Shell("shutdown /h")
                        Case "Log off"
                            Shell("shutdown -l " & IsForcedChar & "-t 00")
                    End Select
                    CountDownTimer.Stop()
                Else
                    H -= 1
                    M = 60
                    S = 60
                End If
            Else
                M -= 1
                S = 60
            End If
        Else
            S -= 1
        End If
        HoursComboBox.Text = H
        MinutesComboBox.Text = M
        SecondsComboBox.Text = S
        CountDownTimer.Start()
    End Sub

    Private Sub StopBUT_Click(sender As Object, e As EventArgs) Handles StopBUT.Click
        CountDownTimer.Stop()
        HideStopBUTLabel.Visible = False
    End Sub

    Private Sub SettingsBUT_Click(sender As Object, e As EventArgs) Handles SettingsBUT.Click
        SettingsWindow.Show()
    End Sub

    Private Sub AboutBUT_Click(sender As Object, e As EventArgs) Handles AboutBUT.Click, AboutToolStripMenuItem.Click
        AboutPanel.Visible = True
    End Sub

#Region "AboutPanel"
    Private Sub TermsAndConditionsBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles TermsAndConditionsBUT.Click
        Process.Start("https://mousa.alfhaily.me/Apps/LICENSE")
    End Sub

    Private Sub YouTubeBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles YouTubeBUT.Click
        Process.Start("https://www.youtube.com/channel/UCWeRjXP-I7OmAwKKF8xHCFQ")
    End Sub

    Private Sub TwitterBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles TwitterBUT.Click
        Process.Start("https://twitter.com/FreeGh0o0st")
    End Sub

    Private Sub WebsiteBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles WebsiteBUT.Click
        Process.Start("https://mousa.alfhaily.me")
    End Sub

    Private Sub AboutPanel_Click(sender As Object, e As EventArgs) Handles AboutPanel.Click
        AboutPanel.Visible = False
    End Sub
#End Region

    Private Sub NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        ShowWindow()
    End Sub

    Private Sub ShowIShutdownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowIShutdownToolStripMenuItem.Click
        ShowWindow()
    End Sub

    Sub ShowWindow()
        Show()
        NotifyIcon.Visible = False
        ShowHideTimer.Tag = "Show"
        ShowHideTimer.Start()
    End Sub

    Private Sub HideBUT_Click(sender As Object, e As EventArgs) Handles HideBUT.Click
        ShowHideTimer.Tag = "Hide"
        ShowHideTimer.Start()
    End Sub

    Private Sub CloseBUT_Click(sender As Object, e As EventArgs) Handles CloseBUT.Click, CloseToolStripMenuItem.Click
        Close()
    End Sub
End Class
