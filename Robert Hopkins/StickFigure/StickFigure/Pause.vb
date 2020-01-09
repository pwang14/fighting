Public Class Pause

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim nfrm = New Start
        nfrm.Show()
        Me.Close()
        GlobalGame.game.Close()
    End Sub

    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
        GlobalGame.game.Show()
        Me.Close()
    End Sub
End Class