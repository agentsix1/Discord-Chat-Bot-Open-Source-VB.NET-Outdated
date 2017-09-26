Imports Discord
Module mdlDiscord
    Public WithEvents discord As New DiscordClient
    Dim tmrConnect As Timer = New Timer()
    Public connected_server As String = ""
    Public Sub connect()
        Try
            If Not getConfig("bot-token", "settings").Equals("empty") Then
                discord.Connect(getConfig("bot-token", "settings"), TokenType.Bot)
                tmrConnect.Interval = 100
                tmrConnect.Enabled = True
                AddHandler tmrConnect.Tick, AddressOf tmrConnect_Tick
            Else
                addChat("Console", "<font color=" & getConfig("chat-failed-to-connect-html", frmMain.current_theme) & ">Failed to connect to the server. No bot token was found.</font><br>")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub disconnect()
        Try
            discord.Disconnect()
            addChat("Console", "<font color=" & getConfig("chat-disconnected-html", frmMain.current_theme) & ">Disconnected</font><br>")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim connecting As Boolean = False
    Dim onetime As Integer = 0
    Public Sub tmrConnect_Tick(sender As Object, e As EventArgs)
        If discord.State = ConnectionState.Connected Then
            Try
                If onetime = 0 Then
                    If getConfig("connected-server", "settings").Equals("empty") Then
                        setConfig("connected-server", discord.Servers.FirstOrDefault().Name, "settings")
                        connected_server = getConfig("connected-server", "settings")
                    Else
                        connected_server = getConfig("connected-server", "settings")
                    End If
                    addChat("Console", "<font color=" & getConfig("chat-connected-html", frmMain.current_theme) & ">Connected!</font><br>")
                        onetime += 1
                        connecting = False
                        Try

                        Catch ex As Exception

                        End Try
                    End If
            Catch ex As Exception

            End Try
            connecting = False
        ElseIf discord.State = ConnectionState.Connecting Then
            Try
                If Not connecting Then
                    addChat("Console", "<font color=" & getConfig("chat-connecting-html", frmMain.current_theme) & ">Connecting...</font><br>")
                    connecting = True
                    onetime = 0
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
End Module
