Public Class Intro
    Dim count As Integer

    Private Sub Intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrIntro.Enabled = True
    End Sub

    Private Sub tmrIntro_Tick(sender As Object, e As EventArgs) Handles tmrIntro.Tick
        count += 1
        If count = 36 Then
            Dim nfrm2 = New Music
        else If count >= 40 Then
        Dim nfrm = New Start()
        nfrm.Show()
        count = 0
        tmrIntro.Enabled = False
        Me.Hide()
        End If
    End Sub
End Class