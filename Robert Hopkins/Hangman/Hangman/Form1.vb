Public Class Game

    Dim word As String = Data.word
    Dim bodyparts(5) As PowerPacks.Shape
    Dim buttons(25) As Button
    Dim letters(Len(word)) As Label
    Dim wrong As Integer = 0
    Dim guess As Boolean
    Dim win As Boolean

    Sub generate()
        Dim mypoint As Point = New Point(40, 275)
        Dim letter As Integer = 65

        For x = 0 To 25
            If x Mod 13 = 0 Then
                mypoint.X = 40
                mypoint.Y = mypoint.Y + 50
            End If
            buttons(x) = New Button
            buttons(x).Width = 40
            buttons(x).Height = 40
            buttons(x).Location = mypoint
            buttons(x).TabStop = False
            buttons(x).Text = Chr(letter)
            buttons(x).Font = New Font("League Gothic", 16, FontStyle.Regular)

            letter += 1
            mypoint.X = mypoint.X + 50

            AddHandler buttons(x).Click, AddressOf Clicked
            Me.Controls.Add(buttons(x))
        Next

        mypoint.X = 275
        mypoint.Y = 150

        For x = 0 To Len(word) - 1
            letters(x) = New Label
            letters(x).AccessibleDescription = Mid(word, x + 1, 1).ToUpper
            letters(x).Location = mypoint
            letters(x).Text = "_"
            letters(x).Font = New Font("League Gothic", 24, FontStyle.Regular)
            letters(x).Size = New Size(25, 50)
            mypoint.X = mypoint.X + 400 / Len(word)

            Me.Controls.Add(letters(x))
        Next
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        bodyparts(0) = ovlHead
        bodyparts(1) = lnBody
        bodyparts(2) = lnArmL
        bodyparts(3) = lnArmR
        bodyparts(4) = lnLegL
        bodyparts(5) = lnLegR

        generate()
    End Sub

    Private Sub Clicked(sender As System.Object, e As System.EventArgs)
        guess = False
        win = True

        For x = 0 To Len(word) - 1
            If sender.text = letters(x).AccessibleDescription Then
                letters(x).Text = letters(x).AccessibleDescription
                guess = True
            End If
            If letters(x).Text <> letters(x).AccessibleDescription Then
                win = False
            End If
        Next

        If guess = False Then
            bodyparts(wrong).Visible = True
            wrong += 1
            If wrong > 5 Then
                MsgBox("You lose.")
                Dim nfrm As New Start
                nfrm.Show()
                Me.Hide()
            End If
        End If

        If win = True Then
            MsgBox("You win!")
            Dim nfrm As New Start
            nfrm.Show()
            Me.Hide()
        End If

        sender.Enabled = False
    End Sub
End Class
