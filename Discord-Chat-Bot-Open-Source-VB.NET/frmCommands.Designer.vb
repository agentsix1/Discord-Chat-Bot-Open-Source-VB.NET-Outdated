<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommands
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
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "say", System.Drawing.Color.Gainsboro, System.Drawing.Color.DimGray, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "This command simply takes any text found after the initial commands and the bot s" &
                    "ays that in chat.", System.Drawing.Color.SkyBlue, System.Drawing.Color.DimGray, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "say {any text here}", System.Drawing.SystemColors.Info, System.Drawing.Color.DimGray, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "1"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "True")}, -1)
        Me.lvCommands = New System.Windows.Forms.ListView()
        Me.chCommand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chHowTo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPermission = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblPermissionValue = New System.Windows.Forms.Label()
        Me.tbPermission = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chEnabled = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblEnabled = New System.Windows.Forms.Label()
        Me.rbEnabled = New System.Windows.Forms.RadioButton()
        Me.rbDisabled = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lvCommands
        '
        Me.lvCommands.BackColor = System.Drawing.Color.DimGray
        Me.lvCommands.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCommand, Me.chDescription, Me.chHowTo, Me.chPermission, Me.chEnabled})
        Me.lvCommands.ForeColor = System.Drawing.Color.Gainsboro
        Me.lvCommands.HideSelection = False
        Me.lvCommands.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.lvCommands.Location = New System.Drawing.Point(0, 0)
        Me.lvCommands.MultiSelect = False
        Me.lvCommands.Name = "lvCommands"
        Me.lvCommands.Size = New System.Drawing.Size(987, 603)
        Me.lvCommands.TabIndex = 0
        Me.lvCommands.UseCompatibleStateImageBehavior = False
        Me.lvCommands.View = System.Windows.Forms.View.Details
        '
        'chCommand
        '
        Me.chCommand.Text = "Command"
        Me.chCommand.Width = 85
        '
        'chDescription
        '
        Me.chDescription.Text = "Description"
        Me.chDescription.Width = 480
        '
        'chHowTo
        '
        Me.chHowTo.Text = "How To Use"
        Me.chHowTo.Width = 159
        '
        'chPermission
        '
        Me.chPermission.Text = "Permission Value"
        Me.chPermission.Width = 98
        '
        'lblPermissionValue
        '
        Me.lblPermissionValue.AutoSize = True
        Me.lblPermissionValue.Location = New System.Drawing.Point(5, 609)
        Me.lblPermissionValue.Name = "lblPermissionValue"
        Me.lblPermissionValue.Size = New System.Drawing.Size(87, 13)
        Me.lblPermissionValue.TabIndex = 8
        Me.lblPermissionValue.Text = "Permission Value"
        '
        'tbPermission
        '
        Me.tbPermission.BackColor = System.Drawing.Color.DimGray
        Me.tbPermission.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPermission.Enabled = False
        Me.tbPermission.ForeColor = System.Drawing.Color.White
        Me.tbPermission.Location = New System.Drawing.Point(98, 609)
        Me.tbPermission.MaxLength = 3
        Me.tbPermission.Name = "tbPermission"
        Me.tbPermission.Size = New System.Drawing.Size(63, 13)
        Me.tbPermission.TabIndex = 7
        Me.tbPermission.Text = "0"
        Me.tbPermission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Silver
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(737, 604)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Silver
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(818, 604)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'chEnabled
        '
        Me.chEnabled.Text = "Enabled State"
        Me.chEnabled.Width = 82
        '
        'lblEnabled
        '
        Me.lblEnabled.AutoSize = True
        Me.lblEnabled.Location = New System.Drawing.Point(167, 609)
        Me.lblEnabled.Name = "lblEnabled"
        Me.lblEnabled.Size = New System.Drawing.Size(74, 13)
        Me.lblEnabled.TabIndex = 12
        Me.lblEnabled.Text = "Enabled State"
        '
        'rbEnabled
        '
        Me.rbEnabled.AutoSize = True
        Me.rbEnabled.Location = New System.Drawing.Point(247, 607)
        Me.rbEnabled.Name = "rbEnabled"
        Me.rbEnabled.Size = New System.Drawing.Size(64, 17)
        Me.rbEnabled.TabIndex = 13
        Me.rbEnabled.TabStop = True
        Me.rbEnabled.Text = "Enabled"
        Me.rbEnabled.UseVisualStyleBackColor = True
        '
        'rbDisabled
        '
        Me.rbDisabled.AutoSize = True
        Me.rbDisabled.Location = New System.Drawing.Point(317, 607)
        Me.rbDisabled.Name = "rbDisabled"
        Me.rbDisabled.Size = New System.Drawing.Size(66, 17)
        Me.rbDisabled.TabIndex = 14
        Me.rbDisabled.TabStop = True
        Me.rbDisabled.Text = "Disabled"
        Me.rbDisabled.UseVisualStyleBackColor = True
        '
        'frmCommands
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(905, 632)
        Me.Controls.Add(Me.rbDisabled)
        Me.Controls.Add(Me.rbEnabled)
        Me.Controls.Add(Me.lblEnabled)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblPermissionValue)
        Me.Controls.Add(Me.tbPermission)
        Me.Controls.Add(Me.lvCommands)
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCommands"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Commands"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvCommands As ListView
    Friend WithEvents chCommand As ColumnHeader
    Friend WithEvents chDescription As ColumnHeader
    Friend WithEvents chHowTo As ColumnHeader
    Friend WithEvents chPermission As ColumnHeader
    Friend WithEvents lblPermissionValue As Label
    Friend WithEvents tbPermission As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents chEnabled As ColumnHeader
    Friend WithEvents lblEnabled As Label
    Friend WithEvents rbEnabled As RadioButton
    Friend WithEvents rbDisabled As RadioButton
End Class
