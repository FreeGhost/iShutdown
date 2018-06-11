Public Class SettingsWindow

    Private Sub SettingsWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.StartAtStartup = "Yes" Then
            SIASSCheckBox.Image = My.Resources.CheckBox_Checked
            SIASSCheckBox.Tag = "Checked"
        End If
        If My.Settings.ForceAction = "Yes" Then
            ForceActionCheckBox.Image = My.Resources.CheckBox_Checked
            ForceActionCheckBox.Tag = "Checked"
        End If
    End Sub

    Private Sub SIASSCheckBox_Click(sender As Object, e As EventArgs) Handles SIASSCheckBox.Click
        If SIASSCheckBox.Tag = "UnChecked" Then
            SIASSCheckBox.Image = My.Resources.CheckBox_Checked
            SIASSCheckBox.Tag = "Checked"
        Else
            SIASSCheckBox.Image = My.Resources.CheckBox_UnChecked
            SIASSCheckBox.Tag = "UnChecked"
        End If
    End Sub

    Private Sub ForceActionCheckBox_Click(sender As Object, e As EventArgs) Handles ForceActionCheckBox.Click
        If ForceActionCheckBox.Tag = "UnChecked" Then
            ForceActionCheckBox.Image = My.Resources.CheckBox_Checked
            ForceActionCheckBox.Tag = "Checked"
        Else
            ForceActionCheckBox.Image = My.Resources.CheckBox_UnChecked
            ForceActionCheckBox.Tag = "UnChecked"
        End If
    End Sub

    Private Sub SaveBUT_Click(sender As Object, e As EventArgs) Handles SaveBUT.Click
        Dim Value As String = Application.ExecutablePath
        Dim KeyName As String = "Software\Microsoft\Windows\CurrentVersion\Run"
        If SIASSCheckBox.Tag = "Checked" Then
            My.Computer.Registry.CurrentUser.OpenSubKey(KeyName, True).SetValue("iShutdown", Value)
            My.Settings.StartAtStartup = "Yes"
        Else
            My.Computer.Registry.CurrentUser.OpenSubKey(KeyName, True).DeleteValue("iShutdown", False)
            My.Settings.StartAtStartup = "No"
        End If
        If ForceActionCheckBox.Tag = "Checked" Then
            MainWindow.IsForced = True
            My.Settings.ForceAction = "Yes"
        Else
            MainWindow.IsForced = False
            My.Settings.ForceAction = "No"
        End If
        My.Settings.Save()
        Close()
    End Sub

    Private Sub CloseBUT_Click(sender As Object, e As EventArgs) Handles CloseBUT.Click
        Close()
    End Sub
End Class