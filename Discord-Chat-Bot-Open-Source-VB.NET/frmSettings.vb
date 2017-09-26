Public Class frmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tvMenu.Nodes.Item(0).Expand()
        tvMenu.Nodes.Item(1).Expand()
        lblSettingsSplash.Text = lblSettingsSplash.Text.Replace("%N%", vbCrLf)
    End Sub

    Private Sub tvMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvMenu.AfterSelect
        If e.Node.Index > -1 Then
            Select Case e.Node.Text
                Case "Bot Settings"
                    gbDetails.Visible = False
                    gbSettings.Visible = False
                    lblSettingsSplash.Visible = True
                    lblSettingsSplash.Text = "Welcome to the Settings!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To view the settings please select an option on the lef" &
    "t." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All edits will be made with the menus listed on the left."
                Case "Details"
                    gbDetails.Visible = True
                    gbSettings.Visible = False
                    lblSettingsSplash.Visible = False
                    lblSettingsSplash.Text = "Welcome to the Settings!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To view the settings please select an option on the lef" &
    "t." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All edits will be made with the menus listed on the left."
                Case "Settings"
                    gbSettings.Visible = True
                    gbDetails.Visible = False
                    lblSettingsSplash.Visible = False
                    lblSettingsSplash.Text = "Welcome to the Settings!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To view the settings please select an option on the lef" &
    "t." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All edits will be made with the menus listed on the left."
                Case "Messages"
                    gbSettings.Visible = False
                    gbDetails.Visible = False
                    lblSettingsSplash.Visible = True
                    lblSettingsSplash.Text = """Messages"" is not yet added."
                Case "Greet Message"
                    gbSettings.Visible = False
                    gbDetails.Visible = False
                    lblSettingsSplash.Visible = True
                    lblSettingsSplash.Text = """Greet Messages"" is not yet added."
                Case "Idle Message"
                    gbSettings.Visible = False
                    gbDetails.Visible = False
                    lblSettingsSplash.Visible = True
                    lblSettingsSplash.Text = """Idle Messages"" is not yet added."
            End Select
        End If
    End Sub
End Class