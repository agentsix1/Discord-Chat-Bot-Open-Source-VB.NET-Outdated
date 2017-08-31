Public Class frmMain
    'The my.settings.build will be removed and replaced with a actual build number for a actual release.
    Public ver As String = "DEV build " & My.Settings.Build
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The next 3 lines of code will only be seen in the development versions. As it would keep count builds if the user ran the program haha.
        My.Settings.Build += 1
        My.Settings.Save()
        ver = "DEV build " & My.Settings.Build
        Me.Text = Me.Text.Replace("%VER%", ver)
    End Sub
End Class
