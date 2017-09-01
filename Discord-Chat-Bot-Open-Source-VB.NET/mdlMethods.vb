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
End Module
