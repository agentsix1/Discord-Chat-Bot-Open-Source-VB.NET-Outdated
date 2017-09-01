Imports Discord
Public Class frmMain
    'The my.settings.build will be removed and replaced with a actual build number for a actual release.
    Public ver As String = "DEV build " & My.Settings.Build
    Public selectedChannel = "Console"
    Public current_theme As String = getConfig("current-theme", "settings")
    Public WithEvents discord As New DiscordClient
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The next 3 lines of code will only be seen in the development versions. As it would keep count builds if the user ran the program haha.
        My.Settings.Build += 1
        My.Settings.Save()
        ver = "DEV build " & My.Settings.Build
        Me.Text = Me.Text.Replace("%VER%", ver)

        If Not System.IO.File.Exists(Application.StartupPath() & "\Resources\settings.ini") Then
            System.IO.File.WriteAllText(Application.StartupPath() & "\Resources\settings.ini", My.Resources.settings)
        End If
        updateTheme()
        wbUsers.Navigate("about:blank")
        wbServer.Navigate("about:blank")
        wbChat.Navigate("about:blank")
        My.Settings.Users = "<body bgcolor=" & getConfig("users-background-html", current_theme) & ">" & vbCrLf
        My.Settings.Chat = "<body bgcolor=" & getConfig("chat-background-html", current_theme) & ">" & vbCrLf
        My.Settings.Server = "<body bgcolor=" & getConfig("server-background-html", current_theme) & ">" & vbCrLf
        My.Settings.Save()

    End Sub
    Dim onetime = True
    Private Sub tmrGeneral_Tick(sender As Object, e As EventArgs) Handles tmrGeneral.Tick
        If discord.State = ConnectionState.Connected Then

        ElseIf onetime Then
            wbUsers.DocumentText = My.Settings.Users
            wbServer.DocumentText = My.Settings.Server
            wbChat.DocumentText = My.Settings.Chat
            onetime = False
        End If
    End Sub
End Class
