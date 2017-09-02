<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrStreamerUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.cbMessage = New System.Windows.Forms.ComboBox()
        Me.tslAll = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsChannels = New System.Windows.Forms.ToolStrip()
        Me.tmrAlert = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGeneral = New System.Windows.Forms.Timer(Me.components)
        Me.tbMessage = New System.Windows.Forms.TextBox()
        Me.wbUsers = New System.Windows.Forms.WebBrowser()
        Me.wbServer = New System.Windows.Forms.WebBrowser()
        Me.tmrStream = New System.Windows.Forms.Timer(Me.components)
        Me.wbChat = New System.Windows.Forms.WebBrowser()
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.miFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.miConnect = New System.Windows.Forms.ToolStripMenuItem()
        Me.miDisconnect = New System.Windows.Forms.ToolStripMenuItem()
        Me.miExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.miSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.miHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.miAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCustomCommands = New System.Windows.Forms.ToolStripMenuItem()
        Me.miDeafultCommands = New System.Windows.Forms.ToolStripMenuItem()
        Me.miChatAutoScroll = New System.Windows.Forms.ToolStripMenuItem()
        Me.miWebsite = New System.Windows.Forms.ToolStripMenuItem()
        Me.miCommandWiki = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsChannels.SuspendLayout()
        Me.msMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrStreamerUpdate
        '
        Me.tmrStreamerUpdate.Interval = 60000
        '
        'cbMessage
        '
        Me.cbMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMessage.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cbMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMessage.ForeColor = System.Drawing.Color.White
        Me.cbMessage.FormattingEnabled = True
        Me.cbMessage.Location = New System.Drawing.Point(0, 684)
        Me.cbMessage.Name = "cbMessage"
        Me.cbMessage.Size = New System.Drawing.Size(1197, 21)
        Me.cbMessage.TabIndex = 16
        Me.cbMessage.Visible = False
        '
        'tslAll
        '
        Me.tslAll.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tslAll.Name = "tslAll"
        Me.tslAll.Size = New System.Drawing.Size(73, 22)
        Me.tslAll.Text = "All Channels"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripLabel1.Text = "Console"
        '
        'tsChannels
        '
        Me.tsChannels.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsChannels.AutoSize = False
        Me.tsChannels.BackColor = System.Drawing.Color.Black
        Me.tsChannels.Dock = System.Windows.Forms.DockStyle.None
        Me.tsChannels.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsChannels.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tslAll})
        Me.tsChannels.Location = New System.Drawing.Point(0, 23)
        Me.tsChannels.Name = "tsChannels"
        Me.tsChannels.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsChannels.Size = New System.Drawing.Size(977, 25)
        Me.tsChannels.TabIndex = 15
        '
        'tmrAlert
        '
        Me.tmrAlert.Enabled = True
        Me.tmrAlert.Interval = 1000
        '
        'tmrGeneral
        '
        Me.tmrGeneral.Enabled = True
        Me.tmrGeneral.Interval = 10
        '
        'tbMessage
        '
        Me.tbMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMessage.BackColor = System.Drawing.SystemColors.HotTrack
        Me.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMessage.ForeColor = System.Drawing.Color.White
        Me.tbMessage.Location = New System.Drawing.Point(0, 683)
        Me.tbMessage.Name = "tbMessage"
        Me.tbMessage.Size = New System.Drawing.Size(1197, 22)
        Me.tbMessage.TabIndex = 13
        '
        'wbUsers
        '
        Me.wbUsers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wbUsers.Location = New System.Drawing.Point(977, 104)
        Me.wbUsers.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbUsers.Name = "wbUsers"
        Me.wbUsers.Size = New System.Drawing.Size(220, 581)
        Me.wbUsers.TabIndex = 12
        '
        'wbServer
        '
        Me.wbServer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wbServer.Location = New System.Drawing.Point(977, 24)
        Me.wbServer.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbServer.Name = "wbServer"
        Me.wbServer.ScrollBarsEnabled = False
        Me.wbServer.Size = New System.Drawing.Size(220, 80)
        Me.wbServer.TabIndex = 11
        '
        'tmrStream
        '
        Me.tmrStream.Interval = 12000
        '
        'wbChat
        '
        Me.wbChat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wbChat.Location = New System.Drawing.Point(0, 47)
        Me.wbChat.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbChat.Name = "wbChat"
        Me.wbChat.Size = New System.Drawing.Size(977, 638)
        Me.wbChat.TabIndex = 10
        '
        'msMenu
        '
        Me.msMenu.BackColor = System.Drawing.SystemColors.Control
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFile, Me.miSettings, Me.miHelp})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Size = New System.Drawing.Size(1197, 24)
        Me.msMenu.TabIndex = 18
        Me.msMenu.Text = "MenuStrip1"
        '
        'miFile
        '
        Me.miFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miConnect, Me.miDisconnect, Me.miExit})
        Me.miFile.Name = "miFile"
        Me.miFile.Size = New System.Drawing.Size(37, 20)
        Me.miFile.Text = "File"
        '
        'miConnect
        '
        Me.miConnect.Name = "miConnect"
        Me.miConnect.Size = New System.Drawing.Size(197, 22)
        Me.miConnect.Text = "Connect                      F1"
        '
        'miDisconnect
        '
        Me.miDisconnect.Name = "miDisconnect"
        Me.miDisconnect.Size = New System.Drawing.Size(197, 22)
        Me.miDisconnect.Text = "Disconnect                 F2"
        '
        'miExit
        '
        Me.miExit.Name = "miExit"
        Me.miExit.Size = New System.Drawing.Size(197, 22)
        Me.miExit.Text = "Exit"
        '
        'miSettings
        '
        Me.miSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miCustomCommands, Me.miDeafultCommands, Me.miChatAutoScroll})
        Me.miSettings.Name = "miSettings"
        Me.miSettings.Size = New System.Drawing.Size(61, 20)
        Me.miSettings.Text = "Settings"
        '
        'miHelp
        '
        Me.miHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miAbout, Me.miWebsite, Me.miCommandWiki})
        Me.miHelp.Name = "miHelp"
        Me.miHelp.Size = New System.Drawing.Size(44, 20)
        Me.miHelp.Text = "Help"
        '
        'miAbout
        '
        Me.miAbout.Name = "miAbout"
        Me.miAbout.Size = New System.Drawing.Size(157, 22)
        Me.miAbout.Text = "About"
        '
        'miCustomCommands
        '
        Me.miCustomCommands.Name = "miCustomCommands"
        Me.miCustomCommands.Size = New System.Drawing.Size(198, 22)
        Me.miCustomCommands.Text = "Custom Commands"
        '
        'miDeafultCommands
        '
        Me.miDeafultCommands.Name = "miDeafultCommands"
        Me.miDeafultCommands.Size = New System.Drawing.Size(198, 22)
        Me.miDeafultCommands.Text = "Default Commands"
        '
        'miChatAutoScroll
        '
        Me.miChatAutoScroll.Checked = True
        Me.miChatAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.miChatAutoScroll.Name = "miChatAutoScroll"
        Me.miChatAutoScroll.Size = New System.Drawing.Size(198, 22)
        Me.miChatAutoScroll.Text = "Chat Autoscroll          F4"
        '
        'miWebsite
        '
        Me.miWebsite.Name = "miWebsite"
        Me.miWebsite.Size = New System.Drawing.Size(157, 22)
        Me.miWebsite.Text = "Website"
        '
        'miCommandWiki
        '
        Me.miCommandWiki.Name = "miCommandWiki"
        Me.miCommandWiki.Size = New System.Drawing.Size(157, 22)
        Me.miCommandWiki.Text = "Command Wiki"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1197, 705)
        Me.Controls.Add(Me.msMenu)
        Me.Controls.Add(Me.cbMessage)
        Me.Controls.Add(Me.tsChannels)
        Me.Controls.Add(Me.tbMessage)
        Me.Controls.Add(Me.wbUsers)
        Me.Controls.Add(Me.wbServer)
        Me.Controls.Add(Me.wbChat)
        Me.Name = "frmMain"
        Me.Text = "Discord Chat Bot (Open Source) v%VER% - Made By: Agentsix1/Jeremy"
        Me.tsChannels.ResumeLayout(False)
        Me.tsChannels.PerformLayout()
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrStreamerUpdate As Timer
    Friend WithEvents cbMessage As ComboBox
    Friend WithEvents tslAll As ToolStripLabel
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents tsChannels As ToolStrip
    Friend WithEvents tmrAlert As Timer
    Friend WithEvents tmrGeneral As Timer
    Friend WithEvents tbMessage As TextBox
    Friend WithEvents wbUsers As WebBrowser
    Friend WithEvents wbServer As WebBrowser
    Friend WithEvents tmrStream As Timer
    Friend WithEvents wbChat As WebBrowser
    Friend WithEvents msMenu As MenuStrip
    Friend WithEvents miFile As ToolStripMenuItem
    Friend WithEvents miConnect As ToolStripMenuItem
    Friend WithEvents miDisconnect As ToolStripMenuItem
    Friend WithEvents miExit As ToolStripMenuItem
    Friend WithEvents miSettings As ToolStripMenuItem
    Friend WithEvents miHelp As ToolStripMenuItem
    Friend WithEvents miAbout As ToolStripMenuItem
    Friend WithEvents miCustomCommands As ToolStripMenuItem
    Friend WithEvents miDeafultCommands As ToolStripMenuItem
    Friend WithEvents miChatAutoScroll As ToolStripMenuItem
    Friend WithEvents miWebsite As ToolStripMenuItem
    Friend WithEvents miCommandWiki As ToolStripMenuItem
End Class
