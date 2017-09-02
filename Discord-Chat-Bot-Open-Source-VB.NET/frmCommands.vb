Public Class frmCommands
    Private Sub frmCommands_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " --- " & frmMain.Text
        lvCommands.Enabled = True
    End Sub
End Class