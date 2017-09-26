Imports System.Text.RegularExpressions

Module mdlMethods
    Function getConfig(loct As String, file As String, type As String) As Object
        Dim settings() = System.IO.File.ReadAllLines(Application.StartupPath & "\Resources\" & file & ".ini")
        For Each line As String In settings
            If Split(line, ": ")(0).Equals(loct) Then
                Select Case type
                    Case "str"
                        Return Split(line, ": ")(1)
                    Case "strarr"
                        Return Split(Split(line, ": ")(1), ",")
                    Case "int"
                        Return Integer.Parse(Split(line, ": ")(1))
                    Case "intarr"
                        Dim temp As Integer() = {}
                        Dim i = 0
                        For Each a As String In Split(Split(line, ": ")(1), ",")
                            temp(i) = Integer.Parse(a)
                            i += 1
                        Next
                        Return temp
                    Case "bln"
                        If Split(line, ": ")(1).Equals("true") Then
                            Return True
                        Else
                            Return False
                        End If
                End Select
            End If
        Next
        Return ""
    End Function

    Function getConfig(loct As String, file As String) As String
        Dim settings() = System.IO.File.ReadAllLines(Application.StartupPath & "\Resources\" & file & ".ini")
        For Each line As String In settings
            If Split(line, ": ")(0).Equals(loct) Then
                Return Split(line, ": ")(1)
            End If
        Next
        Return ""
    End Function

    Public Sub setConfig(loct As String, value As String, file As String)
        Dim settings() = System.IO.File.ReadAllLines(Application.StartupPath & "\Resources\" & file & ".ini")
        Dim settingsa = System.IO.File.ReadAllText(Application.StartupPath & "\Resources\" & file & ".ini")
        Try
            Dim i = 0
            If settingsa.Contains(loct & ": ") Then
                getConfig(loct, file)
                For Each line As String In settings
                    If Split(line, ": ")(0).Equals(loct) Then
                        If Not value = "" Then
                            settings(i) = loct & ": " & value
                        Else
                            Dim a = settings.ToList()
                            a.RemoveAt(i)
                            settings = a.ToArray
                        End If
                    End If
                    i += 1
                Next
            Else
                If settings.Count = 0 Then
                    settings = {loct & ": " & value}
                Else
                    Dim a As String() = settings
                    Dim b As List(Of String) = a.ToList
                    b.Add(loct & ": " & value)
                    settings = b.ToArray
                End If
            End If
            System.IO.File.WriteAllLines(Application.StartupPath & "\Resources\" & file & ".ini", settings)
        Catch ex As ArgumentNullException
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub updateTheme()
        frmMain.BackColor = Drawing.Color.FromName(getConfig("main-backcolor", frmMain.current_theme))
        frmMain.ForeColor = Drawing.Color.FromName(getConfig("main-backcolor", frmMain.current_theme))
        frmMain.msMenu.BackColor = Drawing.Color.FromName(getConfig("menu-backcolor", frmMain.current_theme))
        frmMain.msMenu.ForeColor = Drawing.Color.FromName(getConfig("menu-forecolor", frmMain.current_theme))
        frmMain.tsChannels.BackColor = Drawing.Color.FromName(getConfig("channel-bar-backcolor", frmMain.current_theme))
        For Each item As ToolStripItem In frmMain.tsChannels.Items
            If item.Text.Equals(frmMain.selectedChannel) Then
                item.BackColor = Drawing.Color.FromName(getConfig("channel-tab-backcolor-selected", frmMain.current_theme))
                item.ForeColor = Drawing.Color.FromName(getConfig("channel-tab-forecolor-selected", frmMain.current_theme))
            Else
                item.BackColor = Drawing.Color.FromName(getConfig("channel-tab-backcolor-unselected", frmMain.current_theme))
                item.ForeColor = Drawing.Color.FromName(getConfig("channel-tab-forecolor-unselected", frmMain.current_theme))
            End If
        Next
    End Sub

    Function removeHTML(ByVal html As String) As String
        ' Remove HTML tags.
        Return Regex.Replace(html, "<.*?>", "")
    End Function

    Public Sub toggleCommandEdit(state As Boolean)

        If state Then
            If frmCommands.lvCommands.SelectedItems(0).Index > -1 Then
                frmCommands.btnEdit.Enabled = False
                frmCommands.btnSave.Enabled = True
                frmCommands.tbPermission.Enabled = True
                frmCommands.tbPermission.Text = frmCommands.lvCommands.SelectedItems(0).SubItems.Item(3).Text
                frmCommands.rbEnabled.Enabled = True
                frmCommands.rbDisabled.Enabled = True
                If frmCommands.lvCommands.SelectedItems(0).SubItems.Item(4).Text.Equals("True") Then
                    frmCommands.rbEnabled.Checked = True
                Else
                    frmCommands.rbDisabled.Checked = True
                End If
            End If
        Else
            frmCommands.btnEdit.Enabled = True
            frmCommands.btnSave.Enabled = False
            frmCommands.tbPermission.Enabled = False
            frmCommands.tbPermission.Text = "0"
            frmCommands.rbEnabled.Enabled = False
            frmCommands.rbDisabled.Enabled = False
            frmCommands.rbEnabled.Checked = False
            frmCommands.rbDisabled.Checked = False
        End If
    End Sub

    Public Sub wait(ByVal interval As Integer)
        Dim stopW As New Stopwatch
        stopW.Start()
        Do While stopW.ElapsedMilliseconds < interval
            ' Allows your UI to remain responsive
            Application.DoEvents()
        Loop
        stopW.Stop()
    End Sub

    Public Sub addChat(where As String, add As String)
        Try
            Dim tempa As String() = frmMain.channels(where)
            Dim temp As List(Of String) = tempa.ToList
            temp.Add("<font color=" & getConfig("chat-brackets-html", frmMain.current_theme) & "><</font><font color=" & getConfig("chat-time-html", frmMain.current_theme) & ">" & DateTime.Now.ToString("HH:mm:ss") & "</font><font color=" & getConfig("chat-brackets-html", frmMain.current_theme) & ">></font> " & add)
            tempa = temp.ToArray
            frmMain.channels.Remove(where)
            frmMain.channels.Add(where, tempa)
            updateChatBrowser(where)
        Catch ex As Exception
            Try
                Dim tempa As String() = frmMain.channels(where)
                Dim temp As List(Of String) = tempa.ToList
                temp.Add("<font color=" & getConfig("chat-brackets-html", frmMain.current_theme) & "><</font><font color=" & getConfig("chat-time-html", frmMain.current_theme) & ">" & DateTime.Now.ToString("HH:mm:ss") & "</font><font color=" & getConfig("chat-brackets-html", frmMain.current_theme) & ">></font> " & add)
                tempa = temp.ToArray
                frmMain.channels.Add(where, tempa)
                updateChatBrowser(where)
            Catch ex1 As Exception
            End Try
        End Try
    End Sub

    Public Function getChat(where As String) As String()
        Return frmMain.channels(where)
    End Function

    Public Function getChat(where As String, type As String) As Object
        Select Case type
            Case "str"
                Dim output As String = ""
                For Each line As String In frmMain.channels(where)
                    output += line
                Next
                Return output
        End Select
    End Function

    Public Function addGetChat(where As String, add As String) As String()
        addChat(where, "<font color=" & getConfig("chat-brackets-html", frmMain.current_theme) & "><</font><font color=" & getConfig("chat-time-html", frmMain.current_theme) & ">" & DateTime.Now.ToString("HH:mm:ss") & "</font><font color=" & getConfig("chat-brackets-html", frmMain.current_theme) & ">></font> " & add)
        updateChatBrowser(where)
        Return getChat(where)
    End Function

    Public Sub clearChat(where As String)
        Try
            frmMain.channels.Remove(where)
            frmMain.channels.Add(where, {"<body bgcolor=" & getConfig("chat-background-html", frmMain.current_theme) & ">"})
        Catch ex As Exception
        End Try
    End Sub

    Public Sub createChat(where As String)
        Try
            frmMain.channels.Add(where, {"<body bgcolor=" & getConfig("chat-background-html", frmMain.current_theme) & ">"})
        Catch ex As Exception
        End Try
    End Sub

    Public Sub updateChatBrowser(channel As String)
        frmMain.wbChat.Navigate("about:blank")
        Dim html As String = ""
        For Each str As String In getChat(channel)
            html += str
        Next
        frmMain.wbChat.DocumentText = html
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


End Module
