<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdates
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
        Me.gbUpdates = New System.Windows.Forms.GroupBox()
        Me.wbUpdates = New System.Windows.Forms.WebBrowser()
        Me.rbDev = New System.Windows.Forms.RadioButton()
        Me.rbStable = New System.Windows.Forms.RadioButton()
        Me.rbBeta = New System.Windows.Forms.RadioButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSnooze = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.gbUpdates.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbUpdates
        '
        Me.gbUpdates.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbUpdates.Controls.Add(Me.wbUpdates)
        Me.gbUpdates.Location = New System.Drawing.Point(12, 12)
        Me.gbUpdates.Name = "gbUpdates"
        Me.gbUpdates.Size = New System.Drawing.Size(471, 414)
        Me.gbUpdates.TabIndex = 0
        Me.gbUpdates.TabStop = False
        Me.gbUpdates.Text = "Updates"
        '
        'wbUpdates
        '
        Me.wbUpdates.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wbUpdates.Location = New System.Drawing.Point(3, 16)
        Me.wbUpdates.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbUpdates.Name = "wbUpdates"
        Me.wbUpdates.Size = New System.Drawing.Size(465, 395)
        Me.wbUpdates.TabIndex = 0
        '
        'rbDev
        '
        Me.rbDev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbDev.AutoSize = True
        Me.rbDev.Location = New System.Drawing.Point(395, 432)
        Me.rbDev.Name = "rbDev"
        Me.rbDev.Size = New System.Drawing.Size(88, 17)
        Me.rbDev.TabIndex = 1
        Me.rbDev.Text = "Dev Updates"
        Me.rbDev.UseVisualStyleBackColor = True
        '
        'rbStable
        '
        Me.rbStable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbStable.AutoSize = True
        Me.rbStable.Checked = True
        Me.rbStable.Location = New System.Drawing.Point(12, 432)
        Me.rbStable.Name = "rbStable"
        Me.rbStable.Size = New System.Drawing.Size(98, 17)
        Me.rbStable.TabIndex = 2
        Me.rbStable.TabStop = True
        Me.rbStable.Text = "Stable Updates"
        Me.rbStable.UseVisualStyleBackColor = True
        '
        'rbBeta
        '
        Me.rbBeta.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.rbBeta.AutoSize = True
        Me.rbBeta.Location = New System.Drawing.Point(201, 432)
        Me.rbBeta.Name = "rbBeta"
        Me.rbBeta.Size = New System.Drawing.Size(90, 17)
        Me.rbBeta.TabIndex = 3
        Me.rbBeta.Text = "Beta Updates"
        Me.rbBeta.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(408, 459)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSnooze
        '
        Me.btnSnooze.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSnooze.Location = New System.Drawing.Point(201, 459)
        Me.btnSnooze.Name = "btnSnooze"
        Me.btnSnooze.Size = New System.Drawing.Size(75, 23)
        Me.btnSnooze.TabIndex = 5
        Me.btnSnooze.Text = "Snooze"
        Me.btnSnooze.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Location = New System.Drawing.Point(12, 459)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmUpdates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 494)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSnooze)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.rbBeta)
        Me.Controls.Add(Me.rbStable)
        Me.Controls.Add(Me.rbDev)
        Me.Controls.Add(Me.gbUpdates)
        Me.Name = "frmUpdates"
        Me.Text = "Updates"
        Me.gbUpdates.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbUpdates As GroupBox
    Friend WithEvents wbUpdates As WebBrowser
    Friend WithEvents rbDev As RadioButton
    Friend WithEvents rbStable As RadioButton
    Friend WithEvents rbBeta As RadioButton
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSnooze As Button
    Friend WithEvents btnUpdate As Button
End Class
