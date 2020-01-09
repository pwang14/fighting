Public Class Music
    Dim countmusic As Integer = 240

    Private Sub Music_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
    End Sub

    Private Sub tmrMusic_Tick(sender As Object, e As EventArgs) Handles tmrMusic.Tick
        countmusic += 1
        If countmusic >= 7 Then
            countmusic = 0
            My.Computer.Audio.Play(My.Resources.Background_Music, AudioPlayMode.Background)
        End If
        If GlobalGame.music = False Then
            countmusic = 7
            My.Computer.Audio.Stop()
        End If
    End Sub
End Class