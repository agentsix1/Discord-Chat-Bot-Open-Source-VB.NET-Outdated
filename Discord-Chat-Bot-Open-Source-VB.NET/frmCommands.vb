Public Class frmCommands
    Private Sub frmCommands_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " --- " & frmMain.Text
        lvCommands.Enabled = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            toggleCommandEdit(True)
        Catch ex As Exception
            toggleCommandEdit(False)
        End Try
    End Sub

    Private Sub lvCommands_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCommands.SelectedIndexChanged
        Try
            If lvCommands.SelectedItems(0).Index > -1 Then
            End If
        Catch ex As Exception
            toggleCommandEdit(False)
        End Try

    End Sub
End Class