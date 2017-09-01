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
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cbAnnounceStream = New System.Windows.Forms.ComboBox()
        Me.lblAnnounceStream = New System.Windows.Forms.Label()
        Me.chkAutoConnect = New System.Windows.Forms.CheckBox()
        Me.chkAutoScroll = New System.Windows.Forms.CheckBox()
        Me.cbServers = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnApplyClose = New System.Windows.Forms.Button()
        Me.gbSettings = New System.Windows.Forms.GroupBox()
        Me.lblTrigger = New System.Windows.Forms.Label()
        Me.tbTrigger = New System.Windows.Forms.TextBox()
        Me.btnAddServer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbClientID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbToken = New System.Windows.Forms.TextBox()
        Me.gbDetails = New System.Windows.Forms.GroupBox()
        Me.gbSettings.SuspendLayout()
        Me.gbDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(144, 255)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(58, 23)
        Me.btnApply.TabIndex = 9
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(293, 255)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(51, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cbAnnounceStream
        '
        Me.cbAnnounceStream.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbAnnounceStream.Enabled = False
        Me.cbAnnounceStream.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAnnounceStream.ForeColor = System.Drawing.Color.White
        Me.cbAnnounceStream.FormattingEnabled = True
        Me.cbAnnounceStream.Location = New System.Drawing.Point(9, 82)
        Me.cbAnnounceStream.Name = "cbAnnounceStream"
        Me.cbAnnounceStream.Size = New System.Drawing.Size(321, 21)
        Me.cbAnnounceStream.TabIndex = 5
        '
        'lblAnnounceStream
        '
        Me.lblAnnounceStream.AutoSize = True
        Me.lblAnnounceStream.Location = New System.Drawing.Point(6, 66)
        Me.lblAnnounceStream.Name = "lblAnnounceStream"
        Me.lblAnnounceStream.Size = New System.Drawing.Size(166, 13)
        Me.lblAnnounceStream.TabIndex = 4
        Me.lblAnnounceStream.Text = "Streamer Announcement Channel"
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
        Me.btnApplyClose.Location = New System.Drawing.Point(208, 255)
        Me.btnApplyClose.Name = "btnApplyClose"
        Me.btnApplyClose.Size = New System.Drawing.Size(79, 23)
        Me.btnApplyClose.TabIndex = 8
        Me.btnApplyClose.Text = "Apply && Close"
        Me.btnApplyClose.UseVisualStyleBackColor = True
        '
        'gbSettings
        '
        Me.gbSettings.Controls.Add(Me.cbAnnounceStream)
        Me.gbSettings.Controls.Add(Me.lblAnnounceStream)
        Me.gbSettings.Controls.Add(Me.chkAutoConnect)
        Me.gbSettings.Controls.Add(Me.chkAutoScroll)
        Me.gbSettings.Controls.Add(Me.cbServers)
        Me.gbSettings.Controls.Add(Me.Label3)
        Me.gbSettings.ForeColor = System.Drawing.Color.White
        Me.gbSettings.Location = New System.Drawing.Point(8, 130)
        Me.gbSettings.Name = "gbSettings"
        Me.gbSettings.Size = New System.Drawing.Size(336, 116)
        Me.gbSettings.TabIndex = 6
        Me.gbSettings.TabStop = False
        Me.gbSettings.Text = "Bot Settings"
        '
        'lblTrigger
        '
        Me.lblTrigger.AutoSize = True
        Me.lblTrigger.Location = New System.Drawing.Point(249, 88)
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
        Me.tbTrigger.Location = New System.Drawing.Point(295, 88)
        Me.tbTrigger.MaxLength = 1
        Me.tbTrigger.Name = "tbTrigger"
        Me.tbTrigger.Size = New System.Drawing.Size(30, 13)
        Me.tbTrigger.TabIndex = 4
        Me.tbTrigger.Text = "!"
        Me.tbTrigger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddServer
        '
        Me.btnAddServer.Enabled = False
        Me.btnAddServer.ForeColor = System.Drawing.Color.Black
        Me.btnAddServer.Location = New System.Drawing.Point(9, 83)
        Me.btnAddServer.Name = "btnAddServer"
        Me.btnAddServer.Size = New System.Drawing.Size(78, 23)
        Me.btnAddServer.TabIndex = 5
        Me.btnAddServer.Text = "Add Server"
        Me.btnAddServer.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bot Client ID"
        '
        'tbClientID
        '
        Me.tbClientID.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbClientID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbClientID.ForeColor = System.Drawing.Color.White
        Me.tbClientID.Location = New System.Drawing.Point(9, 64)
        Me.tbClientID.Name = "tbClientID"
        Me.tbClientID.Size = New System.Drawing.Size(321, 13)
        Me.tbClientID.TabIndex = 2
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
        Me.gbDetails.Controls.Add(Me.lblTrigger)
        Me.gbDetails.Controls.Add(Me.tbTrigger)
        Me.gbDetails.Controls.Add(Me.btnAddServer)
        Me.gbDetails.Controls.Add(Me.Label2)
        Me.gbDetails.Controls.Add(Me.tbClientID)
        Me.gbDetails.Controls.Add(Me.Label1)
        Me.gbDetails.Controls.Add(Me.tbToken)
        Me.gbDetails.ForeColor = System.Drawing.Color.White
        Me.gbDetails.Location = New System.Drawing.Point(8, 7)
        Me.gbDetails.Name = "gbDetails"
        Me.gbDetails.Size = New System.Drawing.Size(336, 116)
        Me.gbDetails.TabIndex = 5
        Me.gbDetails.TabStop = False
        Me.gbDetails.Text = "Bot Detail Settings"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(359, 289)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnApplyClose)
        Me.Controls.Add(Me.gbSettings)
        Me.Controls.Add(Me.gbDetails)
        Me.Name = "frmSettings"
        Me.Text = "frmSettings"
        Me.gbSettings.ResumeLayout(False)
        Me.gbSettings.PerformLayout()
        Me.gbDetails.ResumeLayout(False)
        Me.gbDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnApply As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents cbAnnounceStream As ComboBox
    Friend WithEvents lblAnnounceStream As Label
    Friend WithEvents chkAutoConnect As CheckBox
    Friend WithEvents chkAutoScroll As CheckBox
    Friend WithEvents cbServers As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnApplyClose As Button
    Friend WithEvents gbSettings As GroupBox
    Friend WithEvents lblTrigger As Label
    Friend WithEvents tbTrigger As TextBox
    Friend WithEvents btnAddServer As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbClientID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbToken As TextBox
    Friend WithEvents gbDetails As GroupBox
End Class
