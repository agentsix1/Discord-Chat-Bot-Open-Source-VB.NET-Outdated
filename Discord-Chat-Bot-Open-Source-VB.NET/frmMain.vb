Imports Discord
Public Class frmMain
    'The my.settings.build will be removed and replaced with a actual build number for a actual release.
    Public ver As String = "DEV build " & My.Settings.Build
    Public selectedChannel = "Console"
    Public current_theme As String
    Public channels As Dictionary(Of String, String()) = New Dictionary(Of String, String())
    Dim HotKeyRegistry As New HotKeyRegistryClass(Me.Handle)



    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HotKeyRegistry.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.D1) 'Connect
        HotKeyRegistry.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.D2) 'Disconnect
        HotKeyRegistry.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.D3) 'Settings
        HotKeyRegistry.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.D4) 'Chat Autoscroll
        HotKeyRegistry.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.D5) 'Default Commands
        HotKeyRegistry.Register(HotKeyRegistryClass.Modifiers.MOD_CTRL, Keys.D6) 'Users
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
        tmrHotkeys.Enabled = True
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

    Private Sub menuHandler(sender As Object, e As MouseEventArgs) Handles miAbout.MouseDown, miChatAutoScroll.MouseDown, miCommandWiki.MouseDown, miConnect.MouseDown, miCustomCommands.MouseDown, miDeafultCommands.MouseDown, miDisconnect.MouseDown, miExit.MouseDown, miFile.MouseDown, miHelp.MouseDown, miSettings.MouseDown, miSettingsMenu.MouseDown, miSupport.MouseDown, miUsers.MouseDown, miWebsite.MouseDown
        If miAbout.Selected Then

        ElseIf miChatAutoScroll.Selected Then

        ElseIf miCommandWiki.Selected Then
            Process.Start("https://github.com/agentsix1/Discord-Chat-Bot-Open-Source-VB.NET/wiki")
        ElseIf miConnect.Selected Then
            connect()
        ElseIf miCustomCommands.Selected Then

        ElseIf miDeafultCommands.Selected Then
            frmCommands.Show()
        ElseIf miDisconnect.Selected Then
            disconnect()
        ElseIf miExit.Selected Then
            Me.Close()
        ElseIf miFile.Selected Then

        ElseIf miHelp.Selected Then

        ElseIf miSettings.Selected Then
            frmSettings.Show()
        ElseIf miSettingsMenu.Selected Then

        ElseIf miSupport.Selected Then
            Process.Start("https://opendownloads.gq/discord/#support")
        ElseIf miUsers.Selected Then
            frmUsers.Show()
        ElseIf miWebsite.Selected Then
            Process.Start("https://opendownloads.gq/discord/")
        End If
    End Sub
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = HotKeyRegistryClass.Messages.WM_HOTKEY Then
            Dim ID As String = m.WParam.ToString()
            Select Case ID
                Case 0
                    connect()
                Case 1
                    disconnect()
                Case 2
                    frmSettings.Show()
                Case 3
                    'Chat Autoscroll
                Case 4
                    frmCommands.Show()
                Case 5
                    frmUsers.Show()
                Case 6
            End Select
        End If
        MyBase.WndProc(m)
    End Sub
End Class

Public NotInheritable Class HotKeyRegistryClass

    Private Declare Function RegisterHotKey Lib "user32.dll" (ByVal handle As IntPtr, ByVal id As Int32, ByVal fsModifier As Int32, ByVal vk As Int32) As Int32
    Private Declare Function UnregisterHotKey Lib "user32.dll" (ByVal handle As IntPtr, ByVal id As Int32) As Int32

    Private Handle As IntPtr = IntPtr.Zero
    Private Registry As New System.Collections.Generic.List(Of Int32)

    Public Enum Messages
        [WM_HOTKEY] = &H312
    End Enum
    Public Enum Modifiers
        [MOD_ALT] = &H1
        [MOD_CTRL] = &H2
        [MOD_SHIFT] = &H4
    End Enum


    Sub New(ByVal Handle As IntPtr)
        Me.Handle = Handle
    End Sub

    Public Sub New()
    End Sub

    Public Function Register(ByVal Modifier As Int32, ByVal Key As System.Windows.Forms.Keys) As Int32
        Dim ret As Int32

        ret = NextAvailableIndex()
        Call RegisterHotKey(Me.Handle, ret, Modifier, Key)
        Registry.Insert(ret, ret)
        Return ret
    End Function
    Public Sub Unregister(ByVal ID As Int32)
        Call UnregisterHotKey(Me.Handle, ID)
        Registry.Remove(ID)
    End Sub

    Private Function NextAvailableIndex() As Int32
        Dim ret As Int32 = 0
        Dim n As Int32 = 0

        For i As Int32 = 0 To Registry.Count - 1
            If Registry(i) = n Then
                n = n + 1
            ElseIf n < Registry(i) Then
                Return n
            End If
        Next
        If n = Registry.Count Then
            Return Registry.Count
        End If
        Return ret
    End Function

End Class
