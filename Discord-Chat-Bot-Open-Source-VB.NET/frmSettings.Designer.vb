<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Details")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Settings")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bot Settings", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Greet Message")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Idle Message")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Messages", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17})
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chkAutoConnect = New System.Windows.Forms.CheckBox()
        Me.chkAutoScroll = New System.Windows.Forms.CheckBox()
        Me.cbServers = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnApplyClose = New System.Windows.Forms.Button()
        Me.gbSettings = New System.Windows.Forms.GroupBox()
        Me.lblTrigger = New System.Windows.Forms.Label()
        Me.tbTrigger = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbToken = New System.Windows.Forms.TextBox()
        Me.gbDetails = New System.Windows.Forms.GroupBox()
        Me.tvMenu = New System.Windows.Forms.TreeView()
        Me.lblSettingsSplash = New System.Windows.Forms.Label()
        Me.gbSettings.SuspendLayout()
        Me.gbDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(298, 162)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(58, 23)
        Me.btnApply.TabIndex = 9
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(447, 162)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(51, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkAutoConnect
        '
        Me.chkAutoConnect.AutoSize = True
        Me.chkAutoConnect.Location = New System.Drawing.Point(154, 40)
        Me.chkAutoConnect.Name = "chkAutoConnect"
        Me.chkAutoConnect.Size = New System.Drawing.Size(147, 17)
        Me.chkAutoConnect.TabIndex = 3
        Me.chkAutoConnect.Text = "Auto Connect On Launch"
        Me.chkAutoConnect.UseVisualStyleBackColor = True
        '
        'chkAutoScroll
        '
        Me.chkAutoScroll.AutoSize = True
        Me.chkAutoScroll.Location = New System.Drawing.Point(9, 40)
        Me.chkAutoScroll.Name = "chkAutoScroll"
        Me.chkAutoScroll.Size = New System.Drawing.Size(139, 17)
        Me.chkAutoScroll.TabIndex = 2
        Me.chkAutoScroll.Text = "Chat Auto Scroll Default"
        Me.chkAutoScroll.UseVisualStyleBackColor = True
        '
        'cbServers
        '
        Me.cbServers.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbServers.Enabled = False
        Me.cbServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbServers.ForeColor = System.Drawing.Color.White
        Me.cbServers.FormattingEnabled = True
        Me.cbServers.Location = New System.Drawing.Point(87, 13)
        Me.cbServers.Name = "cbServers"
        Me.cbServers.Size = New System.Drawing.Size(243, 21)
        Me.cbServers.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Current Server"
        '
        'btnApplyClose
        '
        Me.btnApplyClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplyClose.Location = New System.Drawing.Point(362, 162)
        Me.btnApplyClose.Name = "btnApplyClose"
        Me.btnApplyClose.Size = New System.Drawing.Size(79, 23)
        Me.btnApplyClose.TabIndex = 8
        Me.btnApplyClose.Text = "Apply && Close"
        Me.btnApplyClose.UseVisualStyleBackColor = True
        '
        'gbSettings
        '
        Me.gbSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.gbSettings.Controls.Add(Me.lblTrigger)
        Me.gbSettings.Controls.Add(Me.chkAutoConnect)
        Me.gbSettings.Controls.Add(Me.tbTrigger)
        Me.gbSettings.Controls.Add(Me.chkAutoScroll)
        Me.gbSettings.Controls.Add(Me.cbServers)
        Me.gbSettings.Controls.Add(Me.Label3)
        Me.gbSettings.ForeColor = System.Drawing.Color.White
        Me.gbSettings.Location = New System.Drawing.Point(166, 12)
        Me.gbSettings.Name = "gbSettings"
        Me.gbSettings.Size = New System.Drawing.Size(336, 75)
        Me.gbSettings.TabIndex = 6
        Me.gbSettings.TabStop = False
        Me.gbSettings.Text = "Bot Settings"
        Me.gbSettings.Visible = False
        '
        'lblTrigger
        '
        Me.lblTrigger.AutoSize = True
        Me.lblTrigger.Location = New System.Drawing.Point(257, 56)
        Me.lblTrigger.Name = "lblTrigger"
        Me.lblTrigger.Size = New System.Drawing.Size(40, 13)
        Me.lblTrigger.TabIndex = 5
        Me.lblTrigger.Text = "Trigger"
        '
        'tbTrigger
        '
        Me.tbTrigger.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tbTrigger.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbTrigger.ForeColor = System.Drawing.Color.White
        Me.tbTrigger.Location = New System.Drawing.Point(303, 56)
        Me.tbTrigger.MaxLength = 1
        Me.tbTrigger.Name = "tbTrigger"
        Me.tbTrigger.Size = New System.Drawing.Size(30, 13)
        Me.tbTrigger.TabIndex = 4
        Me.tbTrigger.Text = "!"
        Me.tbTrigger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bot Token"
        '
        'tbToken
        '
        Me.tbToken.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbToken.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbToken.ForeColor = System.Drawing.Color.White
        Me.tbToken.Location = New System.Drawing.Point(9, 32)
        Me.tbToken.Name = "tbToken"
        Me.tbToken.Size = New System.Drawing.Size(321, 13)
        Me.tbToken.TabIndex = 0
        '
        'gbDetails
        '
        Me.gbDetails.Controls.Add(Me.Label1)
        Me.gbDetails.Controls.Add(Me.tbToken)
        Me.gbDetails.ForeColor = System.Drawing.Color.White
        Me.gbDetails.Location = New System.Drawing.Point(166, 12)
        Me.gbDetails.Name = "gbDetails"
        Me.gbDetails.Size = New System.Drawing.Size(336, 64)
        Me.gbDetails.TabIndex = 5
        Me.gbDetails.TabStop = False
        Me.gbDetails.Text = "Bot Detail Settings"
        Me.gbDetails.Visible = False
        '
        'tvMenu
        '
        Me.tvMenu.AllowDrop = True
        Me.tvMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tvMenu.BackColor = System.Drawing.Color.Black
        Me.tvMenu.ForeColor = System.Drawing.Color.White
        Me.tvMenu.Location = New System.Drawing.Point(0, 0)
        Me.tvMenu.Name = "tvMenu"
        TreeNode13.BackColor = System.Drawing.Color.Black
        TreeNode13.ForeColor = System.Drawing.Color.White
        TreeNode13.Name = "cnDetails"
        TreeNode13.Text = "Details"
        TreeNode14.Name = "cnSettings"
        TreeNode14.Text = "Settings"
        TreeNode15.BackColor = System.Drawing.Color.Black
        TreeNode15.ForeColor = System.Drawing.Color.White
        TreeNode15.Name = "nodeBotSettings"
        TreeNode15.Text = "Bot Settings"
        TreeNode16.Name = "cnGreet"
        TreeNode16.Text = "Greet Message"
        TreeNode17.Name = "cnIdle"
        TreeNode17.Text = "Idle Message"
        TreeNode18.Name = "nodeMessages"
        TreeNode18.Text = "Messages"
        Me.tvMenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode18})
        Me.tvMenu.ShowRootLines = False
        Me.tvMenu.Size = New System.Drawing.Size(160, 191)
        Me.tvMenu.TabIndex = 10
        '
        'lblSettingsSplash
        '
        Me.lblSettingsSplash.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSettingsSplash.ForeColor = System.Drawing.Color.White
        Me.lblSettingsSplash.Location = New System.Drawing.Point(166, 9)
        Me.lblSettingsSplash.Name = "lblSettingsSplash"
        Me.lblSettingsSplash.Size = New System.Drawing.Size(336, 147)
        Me.lblSettingsSplash.TabIndex = 11
        Me.lblSettingsSplash.Text = "Welcome to the Settings!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To view the settings please select an option on the lef" &
    "t." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All edits will be made with the menus listed on the left."
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(507, 191)
        Me.Controls.Add(Me.lblSettingsSplash)
        Me.Controls.Add(Me.tvMenu)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnApplyClose)
        Me.Controls.Add(Me.gbSettings)
        Me.Controls.Add(Me.gbDetails)
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.gbSettings.ResumeLayout(False)
        Me.gbSettings.PerformLayout()
        Me.gbDetails.ResumeLayout(False)
        Me.gbDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnApply As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents chkAutoConnect As CheckBox
    Friend WithEvents chkAutoScroll As CheckBox
    Friend WithEvents cbServers As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnApplyClose As Button
    Friend WithEvents gbSettings As GroupBox
    Friend WithEvents lblTrigger As Label
    Friend WithEvents tbTrigger As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbToken As TextBox
    Friend WithEvents gbDetails As GroupBox
    Friend WithEvents tvMenu As TreeView
    Friend WithEvents lblSettingsSplash As Label
End Class
