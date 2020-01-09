Public Class Start

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles bntStart.Click
        If InStr(txtWord.Text, " ") = 0 And txtWord.Text <> "" Then
            Data.word = txtWord.Text
            Dim nfrm As New Game
            nfrm.Show()
            Me.Hide()
        Else
            MsgBox("Please enter a valid word")
        End If
    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class