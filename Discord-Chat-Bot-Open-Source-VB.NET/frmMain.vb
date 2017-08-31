Public Class frmMain
    Public ver As String = "DEV build " & My.Settings.Build
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Build += 1
        My.Settings.Save()
        ver = "DEV build " & My.Settings.Build
        Me.Text = Me.Text.Replace("%VER%", ver)
    End Sub
End Class
