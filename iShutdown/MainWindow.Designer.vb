<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.CloseBUT = New System.Windows.Forms.Label()
        Me.SettingsBUT = New System.Windows.Forms.Label()
        Me.AboutBUT = New System.Windows.Forms.Label()
        Me.StartBUT = New System.Windows.Forms.Label()
        Me.ActionComboBox = New System.Windows.Forms.ComboBox()
        Me.HoursComboBox = New System.Windows.Forms.ComboBox()
        Me.MinutesComboBox = New System.Windows.Forms.ComboBox()
        Me.SecondsComboBox = New System.Windows.Forms.ComboBox()
        Me.ShowHideTimer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIconCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowIShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideBUT = New System.Windows.Forms.Label()
        Me.CountDownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.HideStopBUTLabel = New System.Windows.Forms.Label()
        Me.StopBUT = New System.Windows.Forms.Label()
        Me.AboutPanel = New System.Windows.Forms.Panel()
        Me.TermsAndConditionsBUT = New System.Windows.Forms.Label()
        Me.WebsiteBUT = New System.Windows.Forms.Label()
        Me.TwitterBUT = New System.Windows.Forms.Label()
        Me.YouTubeBUT = New System.Windows.Forms.Label()
        Me.NotifyIconCMS.SuspendLayout()
        Me.AboutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'CloseBUT
        '
        Me.CloseBUT.BackColor = System.Drawing.Color.Transparent
        Me.CloseBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseBUT.Location = New System.Drawing.Point(373, 1)
        Me.CloseBUT.Name = "CloseBUT"
        Me.CloseBUT.Size = New System.Drawing.Size(20, 20)
        Me.CloseBUT.TabIndex = 0
        '
        'SettingsBUT
        '
        Me.SettingsBUT.BackColor = System.Drawing.Color.Transparent
        Me.SettingsBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingsBUT.Location = New System.Drawing.Point(10, 14)
        Me.SettingsBUT.Name = "SettingsBUT"
        Me.SettingsBUT.Size = New System.Drawing.Size(40, 40)
        Me.SettingsBUT.TabIndex = 1
        '
        'AboutBUT
        '
        Me.AboutBUT.BackColor = System.Drawing.Color.Transparent
        Me.AboutBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutBUT.Location = New System.Drawing.Point(10, 162)
        Me.AboutBUT.Name = "AboutBUT"
        Me.AboutBUT.Size = New System.Drawing.Size(40, 40)
        Me.AboutBUT.TabIndex = 2
        '
        'StartBUT
        '
        Me.StartBUT.BackColor = System.Drawing.Color.Transparent
        Me.StartBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartBUT.Location = New System.Drawing.Point(77, 176)
        Me.StartBUT.Name = "StartBUT"
        Me.StartBUT.Size = New System.Drawing.Size(40, 18)
        Me.StartBUT.TabIndex = 3
        '
        'ActionComboBox
        '
        Me.ActionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActionComboBox.FormattingEnabled = True
        Me.ActionComboBox.Items.AddRange(New Object() {"Shutdown", "Restart", "Hibernate", "Log off"})
        Me.ActionComboBox.Location = New System.Drawing.Point(194, 120)
        Me.ActionComboBox.Name = "ActionComboBox"
        Me.ActionComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ActionComboBox.TabIndex = 4
        Me.ActionComboBox.Text = "Shutdown"
        '
        'HoursComboBox
        '
        Me.HoursComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HoursComboBox.ForeColor = System.Drawing.Color.Gray
        Me.HoursComboBox.FormattingEnabled = True
        Me.HoursComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.HoursComboBox.Location = New System.Drawing.Point(77, 86)
        Me.HoursComboBox.Name = "HoursComboBox"
        Me.HoursComboBox.Size = New System.Drawing.Size(76, 21)
        Me.HoursComboBox.TabIndex = 5
        Me.HoursComboBox.Text = "Hours"
        '
        'MinutesComboBox
        '
        Me.MinutesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinutesComboBox.ForeColor = System.Drawing.Color.Gray
        Me.MinutesComboBox.FormattingEnabled = True
        Me.MinutesComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60"})
        Me.MinutesComboBox.Location = New System.Drawing.Point(159, 86)
        Me.MinutesComboBox.Name = "MinutesComboBox"
        Me.MinutesComboBox.Size = New System.Drawing.Size(76, 21)
        Me.MinutesComboBox.TabIndex = 6
        Me.MinutesComboBox.Text = "Minutes"
        '
        'SecondsComboBox
        '
        Me.SecondsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SecondsComboBox.ForeColor = System.Drawing.Color.Gray
        Me.SecondsComboBox.FormattingEnabled = True
        Me.SecondsComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60"})
        Me.SecondsComboBox.Location = New System.Drawing.Point(241, 86)
        Me.SecondsComboBox.Name = "SecondsComboBox"
        Me.SecondsComboBox.Size = New System.Drawing.Size(76, 21)
        Me.SecondsComboBox.TabIndex = 7
        Me.SecondsComboBox.Text = "Seconds"
        '
        'ShowHideTimer
        '
        Me.ShowHideTimer.Interval = 1
        Me.ShowHideTimer.Tag = "Show"
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.NotifyIconCMS
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "iShutdown"
        '
        'NotifyIconCMS
        '
        Me.NotifyIconCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowIShutdownToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.NotifyIconCMS.Name = "ContextMenuStrip1"
        Me.NotifyIconCMS.ShowImageMargin = False
        Me.NotifyIconCMS.Size = New System.Drawing.Size(139, 76)
        '
        'ShowIShutdownToolStripMenuItem
        '
        Me.ShowIShutdownToolStripMenuItem.Name = "ShowIShutdownToolStripMenuItem"
        Me.ShowIShutdownToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ShowIShutdownToolStripMenuItem.Text = "Show iShutdown"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(135, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'HideBUT
        '
        Me.HideBUT.BackColor = System.Drawing.Color.Transparent
        Me.HideBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideBUT.Location = New System.Drawing.Point(340, 1)
        Me.HideBUT.Name = "HideBUT"
        Me.HideBUT.Size = New System.Drawing.Size(20, 20)
        Me.HideBUT.TabIndex = 8
        '
        'CountDownTimer
        '
        Me.CountDownTimer.Interval = 1000
        Me.CountDownTimer.Tag = ""
        '
        'HideStopBUTLabel
        '
        Me.HideStopBUTLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.HideStopBUTLabel.Location = New System.Drawing.Point(128, 172)
        Me.HideStopBUTLabel.Name = "HideStopBUTLabel"
        Me.HideStopBUTLabel.Size = New System.Drawing.Size(48, 26)
        Me.HideStopBUTLabel.TabIndex = 9
        '
        'StopBUT
        '
        Me.StopBUT.BackColor = System.Drawing.Color.Transparent
        Me.StopBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StopBUT.Location = New System.Drawing.Point(132, 177)
        Me.StopBUT.Name = "StopBUT"
        Me.StopBUT.Size = New System.Drawing.Size(40, 18)
        Me.StopBUT.TabIndex = 10
        '
        'AboutPanel
        '
        Me.AboutPanel.BackgroundImage = Global.iShutdown.My.Resources.Resources.AboutPanelBG
        Me.AboutPanel.Controls.Add(Me.TermsAndConditionsBUT)
        Me.AboutPanel.Controls.Add(Me.WebsiteBUT)
        Me.AboutPanel.Controls.Add(Me.TwitterBUT)
        Me.AboutPanel.Controls.Add(Me.YouTubeBUT)
        Me.AboutPanel.Location = New System.Drawing.Point(0, 0)
        Me.AboutPanel.Name = "AboutPanel"
        Me.AboutPanel.Size = New System.Drawing.Size(410, 210)
        Me.AboutPanel.TabIndex = 11
        Me.AboutPanel.Visible = False
        '
        'TermsAndConditionsBUT
        '
        Me.TermsAndConditionsBUT.BackColor = System.Drawing.Color.Transparent
        Me.TermsAndConditionsBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TermsAndConditionsBUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TermsAndConditionsBUT.Location = New System.Drawing.Point(146, 110)
        Me.TermsAndConditionsBUT.Name = "TermsAndConditionsBUT"
        Me.TermsAndConditionsBUT.Size = New System.Drawing.Size(115, 11)
        Me.TermsAndConditionsBUT.TabIndex = 14
        '
        'WebsiteBUT
        '
        Me.WebsiteBUT.BackColor = System.Drawing.Color.Transparent
        Me.WebsiteBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WebsiteBUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WebsiteBUT.Location = New System.Drawing.Point(146, 140)
        Me.WebsiteBUT.Name = "WebsiteBUT"
        Me.WebsiteBUT.Size = New System.Drawing.Size(118, 52)
        Me.WebsiteBUT.TabIndex = 13
        Me.WebsiteBUT.Tag = ""
        '
        'TwitterBUT
        '
        Me.TwitterBUT.BackColor = System.Drawing.Color.Transparent
        Me.TwitterBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TwitterBUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TwitterBUT.Location = New System.Drawing.Point(274, 141)
        Me.TwitterBUT.Name = "TwitterBUT"
        Me.TwitterBUT.Size = New System.Drawing.Size(52, 52)
        Me.TwitterBUT.TabIndex = 12
        '
        'YouTubeBUT
        '
        Me.YouTubeBUT.BackColor = System.Drawing.Color.Transparent
        Me.YouTubeBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.YouTubeBUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.YouTubeBUT.Location = New System.Drawing.Point(84, 141)
        Me.YouTubeBUT.Name = "YouTubeBUT"
        Me.YouTubeBUT.Size = New System.Drawing.Size(52, 52)
        Me.YouTubeBUT.TabIndex = 11
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.iShutdown.My.Resources.Resources.MainWindow
        Me.ClientSize = New System.Drawing.Size(410, 210)
        Me.ControlBox = False
        Me.Controls.Add(Me.AboutPanel)
        Me.Controls.Add(Me.HideStopBUTLabel)
        Me.Controls.Add(Me.StopBUT)
        Me.Controls.Add(Me.HideBUT)
        Me.Controls.Add(Me.SecondsComboBox)
        Me.Controls.Add(Me.MinutesComboBox)
        Me.Controls.Add(Me.HoursComboBox)
        Me.Controls.Add(Me.ActionComboBox)
        Me.Controls.Add(Me.StartBUT)
        Me.Controls.Add(Me.AboutBUT)
        Me.Controls.Add(Me.SettingsBUT)
        Me.Controls.Add(Me.CloseBUT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iShutdown"
        Me.NotifyIconCMS.ResumeLayout(False)
        Me.AboutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CloseBUT As Label
    Friend WithEvents SettingsBUT As Label
    Friend WithEvents AboutBUT As Label
    Friend WithEvents StartBUT As Label
    Friend WithEvents ActionComboBox As ComboBox
    Friend WithEvents HoursComboBox As ComboBox
    Friend WithEvents MinutesComboBox As ComboBox
    Friend WithEvents SecondsComboBox As ComboBox
    Friend WithEvents ShowHideTimer As Timer
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents NotifyIconCMS As ContextMenuStrip
    Friend WithEvents ShowIShutdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideBUT As Label
    Friend WithEvents CountDownTimer As Timer
    Friend WithEvents HideStopBUTLabel As Label
    Friend WithEvents StopBUT As Label
    Friend WithEvents AboutPanel As Panel
    Friend WithEvents TermsAndConditionsBUT As Label
    Friend WithEvents WebsiteBUT As Label
    Friend WithEvents TwitterBUT As Label
    Friend WithEvents YouTubeBUT As Label
End Class
