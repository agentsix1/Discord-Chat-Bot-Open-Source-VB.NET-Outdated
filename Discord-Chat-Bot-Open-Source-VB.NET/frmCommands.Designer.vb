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
                    "ays that in chat.", System.Drawing.Color.SkyBlue, System.Drawing.Color.DimGray, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "say {any text here}", System.Drawing.SystemColors.Info, System.Drawing.Color.DimGray, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "1")}, -1)
        Me.lvCommands = New System.Windows.Forms.ListView()
        Me.chCommand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chHowTo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPermission = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbCommands = New System.Windows.Forms.TextBox()
        Me.lblCommands = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.tbDescriptions = New System.Windows.Forms.TextBox()
        Me.lblHowToUse = New System.Windows.Forms.Label()
        Me.tbHowToUse = New System.Windows.Forms.TextBox()
        Me.lblPermissionValue = New System.Windows.Forms.Label()
        Me.tbPermission = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lvCommands
        '
        Me.lvCommands.BackColor = System.Drawing.Color.DimGray
        Me.lvCommands.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCommand, Me.chDescription, Me.chHowTo, Me.chPermission})
        Me.lvCommands.ForeColor = System.Drawing.Color.Gainsboro
        Me.lvCommands.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.lvCommands.Location = New System.Drawing.Point(0, 0)
        Me.lvCommands.Name = "lvCommands"
        Me.lvCommands.Size = New System.Drawing.Size(829, 603)
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
        'tbCommands
        '
        Me.tbCommands.BackColor = System.Drawing.Color.DimGray
        Me.tbCommands.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCommands.Enabled = False
        Me.tbCommands.ForeColor = System.Drawing.Color.White
        Me.tbCommands.Location = New System.Drawing.Point(59, 610)
        Me.tbCommands.Name = "tbCommands"
        Me.tbCommands.Size = New System.Drawing.Size(123, 13)
        Me.tbCommands.TabIndex = 1
        '
        'lblCommands
        '
        Me.lblCommands.AutoSize = True
        Me.lblCommands.Location = New System.Drawing.Point(-1, 610)
        Me.lblCommands.Name = "lblCommands"
        Me.lblCommands.Size = New System.Drawing.Size(54, 13)
        Me.lblCommands.TabIndex = 2
        Me.lblCommands.Text = "Command"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(188, 610)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "Description"
        '
        'tbDescriptions
        '
        Me.tbDescriptions.BackColor = System.Drawing.Color.DimGray
        Me.tbDescriptions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbDescriptions.Enabled = False
        Me.tbDescriptions.ForeColor = System.Drawing.Color.White
        Me.tbDescriptions.Location = New System.Drawing.Point(254, 610)
        Me.tbDescriptions.Name = "tbDescriptions"
        Me.tbDescriptions.Size = New System.Drawing.Size(456, 13)
        Me.tbDescriptions.TabIndex = 3
        '
        'lblHowToUse
        '
        Me.lblHowToUse.AutoSize = True
        Me.lblHowToUse.Location = New System.Drawing.Point(63, 635)
        Me.lblHowToUse.Name = "lblHowToUse"
        Me.lblHowToUse.Size = New System.Drawing.Size(67, 13)
        Me.lblHowToUse.TabIndex = 6
        Me.lblHowToUse.Text = "How To Use"
        '
        'tbHowToUse
        '
        Me.tbHowToUse.BackColor = System.Drawing.Color.DimGray
        Me.tbHowToUse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbHowToUse.Enabled = False
        Me.tbHowToUse.ForeColor = System.Drawing.Color.White
        Me.tbHowToUse.Location = New System.Drawing.Point(136, 635)
        Me.tbHowToUse.Name = "tbHowToUse"
        Me.tbHowToUse.Size = New System.Drawing.Size(320, 13)
        Me.tbHowToUse.TabIndex = 5
        '
        'lblPermissionValue
        '
        Me.lblPermissionValue.AutoSize = True
        Me.lblPermissionValue.Location = New System.Drawing.Point(462, 635)
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
        Me.tbPermission.Location = New System.Drawing.Point(555, 635)
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
        Me.btnEdit.Location = New System.Drawing.Point(736, 605)
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
        Me.btnSave.Location = New System.Drawing.Point(736, 630)
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
        'frmCommands
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(823, 657)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblPermissionValue)
        Me.Controls.Add(Me.tbPermission)
        Me.Controls.Add(Me.lblHowToUse)
        Me.Controls.Add(Me.tbHowToUse)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.tbDescriptions)
        Me.Controls.Add(Me.lblCommands)
        Me.Controls.Add(Me.tbCommands)
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
    Friend WithEvents tbCommands As TextBox
    Friend WithEvents lblCommands As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents tbDescriptions As TextBox
    Friend WithEvents lblHowToUse As Label
    Friend WithEvents tbHowToUse As TextBox
    Friend WithEvents lblPermissionValue As Label
    Friend WithEvents tbPermission As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Timer1 As Timer
End Class
