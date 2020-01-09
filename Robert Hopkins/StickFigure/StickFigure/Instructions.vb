Public Class Instructions

    Private Sub cmbPlayer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayer.SelectedIndexChanged
        If cmbPlayer.SelectedIndex = 0 Then
            lblActions1.Visible = True
            lblActions2.Visible = False
        ElseIf cmbPlayer.SelectedIndex = 1 Then
            lblActions2.Visible = True
            lblActions1.Visible = False
        Else
            lblActions1.Visible = False
            lblActions2.Visible = False
        End If
    End Sub

    Private Sub Instructions_click(sender As Object, e As EventArgs) Handles MyBase.MouseClick
        cmbPlayer.Focus()
        cmbPlayer.SelectionStart =cmbPlayer.Text.Length
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim nfrm = New Start
        nfrm.Show()
        Me.Close()
    End Sub
End Class