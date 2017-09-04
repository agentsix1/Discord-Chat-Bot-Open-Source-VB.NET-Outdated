Imports Discord
Public Class frmMain
    'The my.settings.build will be removed and replaced with a actual build number for a actual release.
    Public ver As String = "DEV build " & My.Settings.Build
    Public selectedChannel = "Console"
    Public current_theme As String
    Public channels As Dictionary(Of String, String()) = New Dictionary(Of String, String())
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The next 3 lines of code will only be seen in the development versions. As it would keep count builds if the user ran the program haha.
        My.Settings.Build += 1
        My.Settings.Save()
        ver = "DEV build " & My.Settings.Build
        Me.Text = Me.Text.Replace("%VER%", ver)
        If Not System.IO.Directory.Exists(Application.StartupPath() & "\Resources") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath() & "\Resources")
        End If
        If Not System.IO.File.Exists(Application.StartupPath() & "\Resources\settings.ini") Then
            System.IO.File.WriteAllText(Application.StartupPath() & "\Resources\settings.ini", My.Resources.settings)
        End If
        If Not System.IO.File.Exists(Application.StartupPath() & "\Resources\default-theme.ini") Then
            System.IO.File.WriteAllText(Application.StartupPath() & "\Resources\default-theme.ini", My.Resources.default_theme)
        End If
        current_theme = getConfig("current-theme", "settings")
        updateTheme()
        wbUsers.Navigate("about:blank")
        wbServer.Navigate("about:blank")
        wbChat.Navigate("about:blank")
        Dim consoleHTML As String() = {"<body bgcolor=" & getConfig("chat-background-html", current_theme) & ">"}
        Dim allChannelsHTML As String() = {"<body bgcolor=" & getConfig("chat-background-html", current_theme) & ">"}
        channels.Add("Console", consoleHTML)
        channels.Add("All Channels", allChannelsHTML)
        addChat("Console", "<font color=white>--- </font> <font color=lime>Discord Chat Bot (</font><font color=orange>Open Source</font><font color=lime>)</font><font color=darkgray> vDev Build " & My.Settings.Build & " </font><font color=white>---</font><br>")
        My.Settings.Users = "<body bgcolor=" & getConfig("users-background-html", current_theme) & ">" & vbCrLf
        My.Settings.Server = "<body bgcolor=" & getConfig("server-background-html", current_theme) & ">" & vbCrLf
        My.Settings.Save()
        tmrGeneral.Enabled = True
    End Sub

    Dim onetime As Boolean = True
    Dim abc As Integer = 0

    Private Sub tmrGeneral_Tick(sender As Object, e As EventArgs) Handles tmrGeneral.Tick

        If discord.State = ConnectionState.Connected Then

        ElseIf onetime Then
            Dim html = ""
            For Each it As String In channels("Console")
                html += it
            Next
            wbChat.DocumentText = html
            My.Settings.Chat = html
            My.Settings.Save()
            wbUsers.DocumentText = My.Settings.Users
            wbServer.DocumentText = My.Settings.Server
            'wbChat.DocumentText = My.Settings.Chat
            onetime = False
        End If
    End Sub

    Private Sub miDeafultCommands_Click(sender As Object, e As EventArgs) Handles miDeafultCommands.Click
        frmCommands.Show()
    End Sub

    Private Sub miSettings_Click(sender As Object, e As EventArgs) Handles miSettings.Click
        frmSettings.Show()
    End Sub

    Private Sub miExit_Click(sender As Object, e As EventArgs) Handles miExit.Click
        Me.Close()
    End Sub

    Private Sub miWebsite_Click(sender As Object, e As EventArgs) Handles miWebsite.Click
        Process.Start("https://opendownloads.gq/discord/")
    End Sub

    Private Sub miCommandWiki_Click(sender As Object, e As EventArgs) Handles miCommandWiki.Click
        Process.Start("https://github.com/agentsix1/Discord-Chat-Bot-Open-Source-VB.NET/wiki")
    End Sub

    Private Sub miSupport_Click(sender As Object, e As EventArgs) Handles miSupport.Click
        Process.Start("https://opendownloads.gq/discord/#support")
    End Sub

    Public Sub DisableSound()
        Dim keyValue As String
        keyValue = " &#37;SystemRoot%\Media\"
        If Environment.OSVersion.Version.Major = 5 AndAlso Environment.OSVersion.Version.Minor > 0 Then
            keyValue += "Windows XP Start.wav"
        ElseIf Environment.OSVersion.Version.Major = 6 Then
            keyValue += "Windows Navigation Start.wav"
        Else
            Return
        End If
        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("AppEvents\Schemes\Apps\Explorer\Navigating\.Current", True)
        key.SetValue(Nothing, "", Microsoft.Win32.RegistryValueKind.ExpandString)
    End Sub

    Public Sub EnableSound()
        Dim keyValue As String
        keyValue = "%SystemRoot%\Media\"
        If Environment.OSVersion.Version.Major = 5 AndAlso Environment.OSVersion.Version.Minor > 0 Then
            keyValue += "Windows XP Start.wav"
        ElseIf Environment.OSVersion.Version.Major = 6 Then
            keyValue += "Windows Navigation Start.wav"
        Else
            Return
        End If
        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("AppEvents\Schemes\Apps\Explorer\Navigating\.Current", True)
        key.SetValue(Nothing, keyValue, Microsoft.Win32.RegistryValueKind.ExpandString)
    End Sub

    Private Sub Hotkeys_click(sender As Object, e As KeyEventArgs) Handles tsChannels.KeyDown, msMenu.KeyDown, cbMessage.KeyDown, Me.KeyDown, tbMessage.KeyDown
        If e.KeyCode() = Keys.F1 Then
            'Connect
        ElseIf e.KeyCode() = Keys.F2 Then
            'Disconnect
        ElseIf e.KeyCode() = Keys.F3 Then
            frmSettings.Show()
        ElseIf e.KeyCode() = Keys.F4 Then
            'Chat Auto Scroll
        ElseIf e.KeyCode() = Keys.F6 Then
            frmCommands.Show()
        End If
    End Sub
    Private Sub Hotkeys_click(ByVal sender As Object, ByVal e As HtmlElementEventArgs)
        If e.KeyPressedCode() = Keys.F1 Then
            'Connect
        ElseIf e.KeyPressedCode() = Keys.F2 Then
            'Disconnect
        ElseIf e.KeyPressedCode() = Keys.F3 Then
            frmSettings.Show()
        ElseIf e.KeyPressedCode() = Keys.F4 Then
            'Auto Scroll
        ElseIf e.KeyPressedCode() = Keys.F6 Then
            frmCommands.Show()
        End If
    End Sub

    Private Sub wbChat_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles wbChat.PreviewKeyDown, wbServer.PreviewKeyDown, wbUsers.PreviewKeyDown

        If e.KeyCode() = Keys.F1 Then
            'Connect
        ElseIf e.KeyCode() = Keys.F2 Then
            'Disconnect
        ElseIf e.KeyCode() = Keys.F3 Then
            frmSettings.Show()
        ElseIf e.KeyCode() = Keys.F4 Then
            'Auto Scroll
        ElseIf e.KeyCode() = Keys.F6 Then
            frmCommands.Show()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class
