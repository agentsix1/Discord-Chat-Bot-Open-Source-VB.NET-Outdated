<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomCommands
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
        Me.gbEditCommand = New System.Windows.Forms.GroupBox()
        Me.gbAddCommand = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'gbEditCommand
        '
        Me.gbEditCommand.Location = New System.Drawing.Point(799, 261)
        Me.gbEditCommand.Name = "gbEditCommand"
        Me.gbEditCommand.Size = New System.Drawing.Size(209, 254)
        Me.gbEditCommand.TabIndex = 5
        Me.gbEditCommand.TabStop = False
        Me.gbEditCommand.Text = "Edit Command"
        '
        'gbAddCommand
        '
        Me.gbAddCommand.Location = New System.Drawing.Point(799, 1)
        Me.gbAddCommand.Name = "gbAddCommand"
        Me.gbAddCommand.Size = New System.Drawing.Size(209, 254)
        Me.gbAddCommand.TabIndex = 4
        Me.gbAddCommand.TabStop = False
        Me.gbAddCommand.Text = "Add Command"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(796, 797)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'frmCustomCommands
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 797)
        Me.Controls.Add(Me.gbEditCommand)
        Me.Controls.Add(Me.gbAddCommand)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmCustomCommands"
        Me.Text = "frmCustomCommands"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbEditCommand As GroupBox
    Friend WithEvents gbAddCommand As GroupBox
    Friend WithEvents ListView1 As ListView
End Class
