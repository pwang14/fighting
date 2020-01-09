Public Class Start

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles lblStart.Click
        GlobalGame.game = New Game
        GlobalGame.Game.Show()
        Me.Close()
    End Sub

    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles lblInstructions.Click
        Dim nfrm = New Instructions
        nfrm.Show()
        Me.Close()
    End Sub

    Private Sub lblMinimize_Click(sender As Object, e As EventArgs) Handles lblMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        End
    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalGame.music = True Then
            chkSound.Checked = True
        Else
            chkSound.Checked = False
        End If
    End Sub

    Private Sub chkSound_CheckedChanged(sender As Object, e As EventArgs) Handles chkSound.CheckedChanged
        If chkSound.Checked = True Then
            GlobalGame.music = True
            My.Settings.Music = True
            My.Settings.Save()
        Else
            GlobalGame.music = False
            My.Settings.Music = False
            My.Settings.Save()
        End If
    End Sub
End Class