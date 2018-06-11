<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsWindow))
        Me.SaveBUT = New System.Windows.Forms.Label()
        Me.CloseBUT = New System.Windows.Forms.Label()
        Me.SIASSCheckBox = New System.Windows.Forms.PictureBox()
        Me.ForceActionCheckBox = New System.Windows.Forms.PictureBox()
        CType(Me.SIASSCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForceActionCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaveBUT
        '
        Me.SaveBUT.BackColor = System.Drawing.Color.Transparent
        Me.SaveBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveBUT.Location = New System.Drawing.Point(37, 160)
        Me.SaveBUT.Name = "SaveBUT"
        Me.SaveBUT.Size = New System.Drawing.Size(40, 18)
        Me.SaveBUT.TabIndex = 5
        '
        'CloseBUT
        '
        Me.CloseBUT.BackColor = System.Drawing.Color.Transparent
        Me.CloseBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseBUT.Location = New System.Drawing.Point(372, 1)
        Me.CloseBUT.Name = "CloseBUT"
        Me.CloseBUT.Size = New System.Drawing.Size(20, 20)
        Me.CloseBUT.TabIndex = 4
        '
        'SIASSCheckBox
        '
        Me.SIASSCheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SIASSCheckBox.Image = Global.iShutdown.My.Resources.Resources.CheckBox_UnChecked
        Me.SIASSCheckBox.Location = New System.Drawing.Point(294, 68)
        Me.SIASSCheckBox.Name = "SIASSCheckBox"
        Me.SIASSCheckBox.Size = New System.Drawing.Size(17, 17)
        Me.SIASSCheckBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.SIASSCheckBox.TabIndex = 6
        Me.SIASSCheckBox.TabStop = False
        Me.SIASSCheckBox.Tag = "UnChecked"
        '
        'ForceActionCheckBox
        '
        Me.ForceActionCheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForceActionCheckBox.Image = Global.iShutdown.My.Resources.Resources.CheckBox_UnChecked
        Me.ForceActionCheckBox.Location = New System.Drawing.Point(328, 106)
        Me.ForceActionCheckBox.Name = "ForceActionCheckBox"
        Me.ForceActionCheckBox.Size = New System.Drawing.Size(17, 17)
        Me.ForceActionCheckBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ForceActionCheckBox.TabIndex = 7
        Me.ForceActionCheckBox.TabStop = False
        Me.ForceActionCheckBox.Tag = "UnChecked"
        '
        'SettingsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.iShutdown.My.Resources.Resources.SettingsWindow
        Me.ClientSize = New System.Drawing.Size(410, 210)
        Me.Controls.Add(Me.ForceActionCheckBox)
        Me.Controls.Add(Me.SIASSCheckBox)
        Me.Controls.Add(Me.SaveBUT)
        Me.Controls.Add(Me.CloseBUT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SettingsWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iShutdown"
        CType(Me.SIASSCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForceActionCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveBUT As Label
    Friend WithEvents CloseBUT As Label
    Friend WithEvents SIASSCheckBox As PictureBox
    Friend WithEvents ForceActionCheckBox As PictureBox
End Class
