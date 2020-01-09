Public Class Game

    'PLAYER 1 VARIABLES

    Dim playable As Boolean = True
    Dim actionable As Boolean = True

    Dim direction As Integer = -1
    Dim speed As Integer

    Dim damage As Integer
    Dim health As Integer = 400
    Dim mana As Integer = 400

    Dim count As Integer
    Dim counthit As Integer
    Dim countbreak As Integer
    Dim pressedkey As Integer = -1

    Dim moving As Boolean = False
    Dim is_hit As Boolean = False
    Dim in_range As Boolean = False

    'PLAYER 2 VARIABLES

    Dim playable2 As Boolean = True
    Dim actionable2 As Boolean = True

    Dim direction2 As Integer = 1
    Dim speed2 As Integer

    Dim damage2 As Integer
    Dim health2 As Integer = 400
    Dim mana2 As Integer = 400

    Dim count2 As Integer
    Dim counthit2 As Integer
    Dim countbreak2 As Integer
    Dim pressedkey2 As Integer = -1

    Dim moving2 As Boolean = False
    Dim is_hit2 As Boolean = False
    Dim in_range2 As Boolean = False

    'HIT ACTION

    Sub hit(ByVal player As Integer)
        If player = 1 And is_hit = False And Not ((picPlayer2.AccessibleDescription = "punching" And picPlayer1.AccessibleDescription = "ducking") Or (picPlayer2.AccessibleDescription = "kicking" And picPlayer1.AccessibleDescription = "blocking")) Then
            tmrHit.Enabled = True
        ElseIf player = 2 And is_hit2 = False And Not ((picPlayer1.AccessibleDescription = "punching" And picPlayer2.AccessibleDescription = "ducking") Or (picPlayer1.AccessibleDescription = "kicking" And picPlayer2.AccessibleDescription = "blocking")) Then
            tmrHit2.Enabled = True
        End If
    End Sub

    'PLAYER 1 ACTIONS

    Sub still()
        picPlayer1.AccessibleDescription = "still"
        moving = False
        tmrActions.Enabled = False
        count = 0
        If direction = 1 Then
            picPlayer1.Image = My.Resources.Still_SR
            picPlayer1P.Image = My.Resources.Still_SR
        Else
            picPlayer1.Image = My.Resources.Still_SL
            picPlayer1P.Image = My.Resources.Still_SL
        End If
    End Sub

    Sub run()
        speed = 3
        picPlayer1.AccessibleDescription = "running"
        If direction = 1 Then
            picPlayer1.Image = My.Resources.Running_SSR
            picPlayer1P.Image = My.Resources.Running_SSR
        Else
            picPlayer1.Image = My.Resources.Running_SSL
            picPlayer1P.Image = My.Resources.Running_SSL
        End If
    End Sub

    Sub jump()
        speed = 3
        picPlayer1.AccessibleDescription = "jumping"
        tmrActions.Enabled = True
        If direction = 1 Then
            picPlayer1.Image = My.Resources.Jumping_SSR
            picPlayer1P.Image = My.Resources.Jumping_SSR
        Else
            picPlayer1.Image = My.Resources.Jumping_SSL
            picPlayer1P.Image = My.Resources.Jumping_SSL
        End If
    End Sub

    Sub duck()
        moving = False
        picPlayer1.AccessibleDescription = "ducking"
        tmrActions.Enabled = True
        If direction = 1 Then
            picPlayer1.Image = My.Resources.Ducking_SSR
            picPlayer1P.Image = My.Resources.Ducking_SSR
        Else
            picPlayer1.Image = My.Resources.Ducking_SSL
            picPlayer1P.Image = My.Resources.Ducking_SSL
        End If
    End Sub

    Sub punch(ByVal type As Integer)
        If type <> 0 Then
            picPlayer1.AccessibleDescription = "punching_fast"
            mana = mana - 60
        Else
            picPlayer1.AccessibleDescription = "punching"
            speed = 0
        End If
        damage = 15
        tmrActions.Enabled = True
        If direction = 1 Then
            picPlayer1.Image = My.Resources.Punching_SSR
            picPlayer1P.Image = My.Resources.Punching_SSR
        Else
            picPlayer1.Image = My.Resources.Punching_SSL
            picPlayer1P.Image = My.Resources.Punching_SSL
        End If
        hit(2)
    End Sub

    Sub kick(ByVal type As Integer)
        If type <> 0 Then
            picPlayer1.AccessibleDescription = "kicking_fast"
            mana = mana - 100
            If direction = 1 Then
                picPlayer1.Image = My.Resources.Low_Kicking_SSR
                picPlayer1P.Image = My.Resources.Low_Kicking_SSR
            Else
                picPlayer1.Image = My.Resources.Low_Kicking_SSL
                picPlayer1P.Image = My.Resources.Low_Kicking_SSL
            End If
        Else
            picPlayer1.AccessibleDescription = "kicking"
            mana = mana - 15
            If direction = 1 Then
                picPlayer1.Image = My.Resources.Kicking_SSR
                picPlayer1P.Image = My.Resources.Kicking_SSR
            Else
                picPlayer1.Image = My.Resources.Kicking_SSL
                picPlayer1P.Image = My.Resources.Kicking_SSL
            End If
            speed = 0
        End If
        damage = 20
        tmrActions.Enabled = True
        hit(2)
    End Sub

    Sub block()
        moving = False
        picPlayer1.AccessibleDescription = "blocking"
        tmrActions.Enabled = True
        If direction = 1 Then
            picPlayer1.Image = My.Resources.Blocking_SSR
            picPlayer1P.Image = My.Resources.Blocking_SSR
        Else
            picPlayer1.Image = My.Resources.Blocking_SSL
            picPlayer1P.Image = My.Resources.Blocking_SSL
        End If
    End Sub

    Sub lowkick()
        damage = 15
        moving = False
        picPlayer1.AccessibleDescription = "lowkicking"
        tmrActions.Enabled = True
        If direction = 1 Then
            picPlayer1.Image = My.Resources.Low_Kicking_SSR
            picPlayer1P.Image = My.Resources.Low_Kicking_SSR
        Else
            picPlayer1.Image = My.Resources.Low_Kicking_SSL
            picPlayer1P.Image = My.Resources.Low_Kicking_SSL
        End If
        hit(2)
    End Sub

    'PLAYER 2 ACTIONS

    Sub still2()
        picPlayer2.AccessibleDescription = "still"
        moving2 = False
        tmrActions2.Enabled = False
        count2 = 0
        If direction2 = 1 Then
            picPlayer2.Image = My.Resources.Still_SR
        Else
            picPlayer2.Image = My.Resources.Still_SL
        End If
    End Sub

    Sub run2()
        speed2 = 3
        picPlayer2.AccessibleDescription = "running"
        If direction2 = 1 Then
            picPlayer2.Image = My.Resources.Running_SSR
        Else
            picPlayer2.Image = My.Resources.Running_SSL
        End If
    End Sub

    Sub jump2()
        speed2 = 3
        picPlayer2.AccessibleDescription = "jumping"
        tmrActions2.Enabled = True
        If direction2 = 1 Then
            picPlayer2.Image = My.Resources.Jumping_SSR
        Else
            picPlayer2.Image = My.Resources.Jumping_SSL
        End If
    End Sub

    Sub duck2()
        moving2 = False
        picPlayer2.AccessibleDescription = "ducking"
        tmrActions2.Enabled = True
        If direction2 = 1 Then
            picPlayer2.Image = My.Resources.Ducking_SSR
        Else
            picPlayer2.Image = My.Resources.Ducking_SSL
        End If
    End Sub

    Sub punch2(ByVal type As Integer)
        If type <> 0 Then
            picPlayer2.AccessibleDescription = "punching_fast"
            mana2 = mana2 - 60
        Else
            picPlayer2.AccessibleDescription = "punching"
            speed2 = 0
        End If
        damage2 = 10
        tmrActions2.Enabled = True
        If direction2 = 1 Then
            picPlayer2.Image = My.Resources.Punching_SSR
        Else
            picPlayer2.Image = My.Resources.Punching_SSL
        End If
        hit(1)
    End Sub

    Sub kick2(ByVal type As Integer)
        If type <> 0 Then
            picPlayer2.AccessibleDescription = "kicking_fast"
            mana2 = mana2 - 100
            If direction2 = 1 Then
                picPlayer2.Image = My.Resources.Low_Kicking_SSR
            Else
                picPlayer2.Image = My.Resources.Low_Kicking_SSL
            End If
        Else
            picPlayer2.AccessibleDescription = "kicking"
            mana2 = mana2 - 15
            If direction2 = 1 Then
                picPlayer2.Image = My.Resources.Kicking_SSR
            Else
                picPlayer2.Image = My.Resources.Kicking_SSL
            End If
            speed2 = 0
        End If
        damage2 = 20
        tmrActions2.Enabled = True
        hit(1)
    End Sub

    Sub block2()
        moving2 = False
        picPlayer2.AccessibleDescription = "blocking"
        tmrActions2.Enabled = True
        If direction2 = 1 Then
            picPlayer2.Image = My.Resources.Blocking_SSR
        Else
            picPlayer2.Image = My.Resources.Blocking_SSL
        End If
    End Sub

    Sub lowkick2()
        damage2 = 15
        moving2 = False
        picPlayer2.AccessibleDescription = "lowkicking"
        tmrActions2.Enabled = True
        If direction2 = 1 Then
            picPlayer2.Image = My.Resources.Low_Kicking_SSR
        Else
            picPlayer2.Image = My.Resources.Low_Kicking_SSL
        End If
        hit(1)
    End Sub

    'PLAYER 1 KEY EVENTS

    Sub Game_KeyDown1(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If playable = True Then
            If is_hit = False And (pressedkey = -1 Or pressedkey = 39 Or pressedkey = 37) Then
                If e.KeyCode = Keys.Right Then
                    pressedkey = e.KeyCode
                    If picPlayer1.AccessibleDescription = "still" Then
                        direction = 1
                        run()
                    End If
                    If (picPlayer1.AccessibleDescription = "running" And direction = 1) Or picPlayer1.AccessibleDescription = "jumping" Then
                        direction = 1
                        moving = True
                    End If
                ElseIf e.KeyCode = Keys.Left Then
                    pressedkey = e.KeyCode
                    If picPlayer1.AccessibleDescription = "still" Then
                        direction = -1
                        run()
                    End If
                    If (picPlayer1.AccessibleDescription = "running" And direction = -1) Or picPlayer1.AccessibleDescription = "jumping" Then
                        direction = -1
                        moving = True
                    End If
                End If
                If e.KeyCode = Keys.Up Then
                    pressedkey = e.KeyCode
                    If picPlayer1.AccessibleDescription = "still" Or picPlayer1.AccessibleDescription = "running" Then
                        jump()
                    End If
                ElseIf e.KeyCode = Keys.Down Then
                    pressedkey = -1
                    If picPlayer1.AccessibleDescription = "still" Or picPlayer1.AccessibleDescription = "running" Then
                        duck()
                    End If
                ElseIf e.KeyCode = Keys.L Then
                    If (picPlayer1.AccessibleDescription = "running" Or picPlayer1.AccessibleDescription = "still" Or picPlayer1.AccessibleDescription = "ducking") And actionable = True Then
                        If picPlayer1.AccessibleDescription = "ducking" And (pressedkey = 39 Or pressedkey = 37) And mana > 60 Then
                            If pressedkey = 39 Then
                                direction = 1
                            Else
                                direction = -1
                            End If
                            picPlayer1.AccessibleDescription = "fast_punching"
                            punch(1)
                        ElseIf picPlayer1.AccessibleDescription <> "ducking" Then
                            punch(0)
                        End If
                        tmrBreak.Enabled = True
                    End If
                    pressedkey = e.KeyCode
                ElseIf e.KeyCode = Keys.K Then
                    If (picPlayer1.AccessibleDescription = "running" Or picPlayer1.AccessibleDescription = "still" Or picPlayer1.AccessibleDescription = "ducking") And actionable = True Then
                        If picPlayer1.AccessibleDescription = "ducking" And (pressedkey = 39 Or pressedkey = 37) And mana > 100 Then
                            If pressedkey = 39 Then
                                direction = 1
                            Else
                                direction = -1
                            End If
                            picPlayer1.AccessibleDescription = "fast_kicking"
                            kick(1)
                        ElseIf picPlayer1.AccessibleDescription <> "ducking" And mana > 15 Then
                            kick(0)
                        ElseIf picPlayer1.AccessibleDescription = "ducking" Then
                            tmrActions.Enabled = False
                            lowkick()
                        End If
                        tmrBreak.Enabled = True
                    End If
                    pressedkey = e.KeyCode
                ElseIf e.KeyCode = Keys.J Then
                    pressedkey = e.KeyCode
                    If picPlayer1.AccessibleDescription = "still" Or picPlayer1.AccessibleDescription = "running" Then
                        block()
                    End If
                End If
            End If
        End If
    End Sub

    Sub Game_Null(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If playable = True Then
            If e.KeyCode = Keys.Right Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.L Or e.KeyCode = Keys.K Or e.KeyCode = Keys.J Then
                If e.KeyCode = pressedkey Then
                    pressedkey = -1
                End If
                If picPlayer1.AccessibleDescription <> "punching_fast" And picPlayer1.AccessibleDescription <> "kicking_fast" And picPlayer1.AccessibleDescription <> "jumping" And picPlayer1.AccessibleDescription <> "punching" And picPlayer1.AccessibleDescription <> "kicking" Then
                    If e.KeyCode = Keys.Down And picPlayer1.AccessibleDescription <> "lowkicking" Then
                        picPlayer1.AccessibleDescription = "still"
                    ElseIf e.KeyCode = Keys.Down And picPlayer1.AccessibleDescription = "lowkicking" Then
                        picPlayer1.AccessibleDescription = "lowkicking_still"
                    ElseIf e.KeyCode = Keys.J And picPlayer1.AccessibleDescription <> "lowkicking" Then
                        picPlayer1.AccessibleDescription = "still"
                    End If
                End If
                If picPlayer1.AccessibleDescription = "still" And is_hit = False Then
                    still()
                End If
                If e.KeyCode = Keys.Right Or e.KeyCode = Keys.Left Then
                    If tmrActions.Enabled = False And in_range = False Then
                        still()
                    End If
                    moving = False
                End If
            End If
        End If
    End Sub

    'PLAYER 2 KEY EVENTS

    Sub Game_KeyDown2(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If playable2 = True Then
            If is_hit2 = False And (pressedkey2 = -1 Or pressedkey2 = 71 Or pressedkey2 = 68) Then
                If e.KeyCode = Keys.G Then
                    pressedkey2 = e.KeyCode
                    If picPlayer2.AccessibleDescription = "still" Then
                        direction2 = 1
                        run2()
                    End If
                    If (picPlayer2.AccessibleDescription = "running" And direction2 = 1) Or picPlayer2.AccessibleDescription = "jumping" Then
                        direction2 = 1
                        moving2 = True
                    End If
                ElseIf e.KeyCode = Keys.D Then
                    pressedkey2 = e.KeyCode
                    If picPlayer2.AccessibleDescription = "still" Then
                        direction2 = -1
                        run2()
                    End If
                    If (picPlayer2.AccessibleDescription = "running" And direction2 = -1) Or picPlayer2.AccessibleDescription = "jumping" Then
                        direction2 = -1
                        moving2 = True
                    End If
                ElseIf e.KeyCode = Keys.R Then
                    pressedkey2 = e.KeyCode
                    If picPlayer2.AccessibleDescription = "still" Or picPlayer2.AccessibleDescription = "running" Then
                        jump2()
                    End If
                ElseIf e.KeyCode = Keys.F Then
                    pressedkey2 = -1
                    If picPlayer2.AccessibleDescription = "still" Or picPlayer2.AccessibleDescription = "running" Then
                        duck2()
                    End If
                    If picPlayer2.AccessibleDescription = "kicking" Then
                        picPlayer2.AccessibleDescription = "ducking"
                    End If
                ElseIf e.KeyCode = Keys.D3 Then
                    If (picPlayer2.AccessibleDescription = "running" Or picPlayer2.AccessibleDescription = "still" Or picPlayer2.AccessibleDescription = "ducking") And actionable2 = True Then
                        If picPlayer2.AccessibleDescription = "ducking" And (pressedkey2 = 71 Or pressedkey2 = 68) And mana2 > 60 Then
                            If pressedkey2 = 71 Then
                                direction2 = 1
                            Else
                                direction2 = -1
                            End If
                            picPlayer2.AccessibleDescription = "punching_fast"
                            punch2(1)
                        ElseIf picPlayer2.AccessibleDescription <> "ducking" Then
                            punch2(0)
                        End If
                        tmrBreak2.Enabled = True
                    End If
                    pressedkey2 = e.KeyCode
                ElseIf e.KeyCode = Keys.D2 Then
                    If (picPlayer2.AccessibleDescription = "running" Or picPlayer2.AccessibleDescription = "still" Or picPlayer2.AccessibleDescription = "ducking") And actionable2 = True Then
                        If picPlayer2.AccessibleDescription = "ducking" And (pressedkey2 = 71 Or pressedkey2 = 68) And mana2 > 100 Then
                            If pressedkey2 = 71 Then
                                direction2 = 1
                            Else
                                direction2 = -1
                            End If
                            picPlayer2.AccessibleDescription = "kicking_fast"
                            kick2(1)
                        ElseIf picPlayer2.AccessibleDescription <> "ducking" And mana2 > 15 Then
                            kick2(0)
                        ElseIf picPlayer2.AccessibleDescription = "ducking" Then
                            tmrActions2.Enabled = False
                            lowkick2()
                        End If
                        tmrBreak2.Enabled = True
                    End If
                    pressedkey2 = e.KeyCode
                ElseIf e.KeyCode = Keys.D1 Then
                    pressedkey2 = e.KeyCode
                    If picPlayer2.AccessibleDescription = "still" Or picPlayer2.AccessibleDescription = "running" Then
                        block2()
                    End If
                End If
            End If
        End If
    End Sub

    Sub Game_Null2(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If playable2 = True Then
            If e.KeyCode = Keys.G Or e.KeyCode = Keys.D Or e.KeyCode = Keys.R Or e.KeyCode = Keys.F Or e.KeyCode = Keys.D3 Or e.KeyCode = Keys.D2 Or e.KeyCode = Keys.D1 Then
                If pressedkey2 = e.KeyCode Then
                    pressedkey2 = -1
                End If
                If picPlayer2.AccessibleDescription <> "punching_fast" And picPlayer2.AccessibleDescription <> "kicking_fast" And picPlayer2.AccessibleDescription <> "jumping" And picPlayer2.AccessibleDescription <> "punching" And picPlayer2.AccessibleDescription <> "kicking" Then
                    If e.KeyCode = Keys.F And picPlayer2.AccessibleDescription <> "lowkicking" Then
                        picPlayer2.AccessibleDescription = "still"
                    ElseIf e.KeyCode = Keys.F And picPlayer2.AccessibleDescription = "lowkicking" Then
                        picPlayer2.AccessibleDescription = "lowkicking_still"
                    ElseIf e.KeyCode = Keys.D1 And picPlayer2.AccessibleDescription <> "lowkicking" Then
                        picPlayer2.AccessibleDescription = "still"
                    End If
                End If
                If picPlayer2.AccessibleDescription = "still" And is_hit2 = False Then
                    still2()
                End If
                If e.KeyCode = Keys.G Or e.KeyCode = Keys.D Then
                    If tmrActions2.Enabled = False And in_range2 = False Then
                        still2()
                    End If
                    moving2 = False
                End If
            End If
        End If
    End Sub

    'HIT TIMERS

    Private Sub tmrHit_Tick(sender As Object, e As EventArgs) Handles tmrHit.Tick
        is_hit = True
        counthit += 1
        If (picPlayer2.AccessibleDescription = "punching_fast" Or picPlayer2.AccessibleDescription = "kicking_fast") And ((direction2 = 1 And picPlayer1.Location.X - picPlayer2.Location.X < 100 And picPlayer1.Location.X - picPlayer2.Location.X > 10) Or (direction2 = -1 And picPlayer2.Location.X - picPlayer1.Location.X < 85 And picPlayer2.Location.X - picPlayer1.Location.X > 5)) And picPlayer1.Location.Y >= 300 Then
            picPlayer1.Location = New Point(picPlayer1.Location.X, 300)
            tmrActions.Enabled = False
            in_range = True
        End If
        If counthit = 19 And ((direction2 = 1 And picPlayer1.Location.X - picPlayer2.Location.X < 100 And picPlayer1.Location.X - picPlayer2.Location.X > 10) Or (direction2 = -1 And picPlayer2.Location.X - picPlayer1.Location.X < 85 And picPlayer2.Location.X - picPlayer1.Location.X > 5)) And picPlayer1.Location.Y >= 300 Then
            picPlayer1.Location = New Point(picPlayer1.Location.X, 300)
            tmrActions.Enabled = False
            in_range = True
        ElseIf counthit = 19 And in_range = False Then
            tmrHit.Enabled = False
            counthit = 0
            is_hit = False
        End If
        If in_range = True Then
            moving = False
            If counthit = 20 Then
                If direction = 1 Then
                    picPlayer1.Image = My.Resources.Hit_Still_SR
                    picPlayer1P.Image = My.Resources.Hit_Still_SR
                Else
                    picPlayer1.Image = My.Resources.Hit_Still_SL
                    picPlayer1P.Image = My.Resources.Hit_Still_SL
                End If
                health = health - damage2
            End If
            If counthit > 20 Then
                If counthit Mod 3 = 0 Then
                    picPlayer1.Location = New Point(picPlayer1.Location.X + 2 * direction2, 300)
                    picPlayer1P.Location = New Point(picPlayer1P.Location.X + 2 * direction2, 0)
                End If
            End If
            If counthit >= 30 Then
                tmrHit.Enabled = False
                counthit = 0
                is_hit = False
                still()
                in_range = False
            End If
        End If
    End Sub

    Private Sub tmrHit2_Tick(sender As Object, e As EventArgs) Handles tmrHit2.Tick
        is_hit2 = True
        counthit2 += 1
        If (picPlayer1.AccessibleDescription = "punching_fast" Or picPlayer1.AccessibleDescription = "kicking_fast") And ((direction = 1 And picPlayer2.Location.X - picPlayer1.Location.X < 100 And picPlayer2.Location.X - picPlayer1.Location.X > 10) Or (direction = -1 And picPlayer1.Location.X - picPlayer2.Location.X < 85 And picPlayer1.Location.X - picPlayer2.Location.X > 5)) And picPlayer2.Location.Y >= 300 Then
            picPlayer2.Location = New Point(picPlayer2.Location.X, 300)
            tmrActions2.Enabled = False
            in_range2 = True
        End If
        If counthit2 = 19 And ((direction = 1 And picPlayer2.Location.X - picPlayer1.Location.X < 100 And picPlayer2.Location.X - picPlayer1.Location.X > 10) Or (direction = -1 And picPlayer1.Location.X - picPlayer2.Location.X < 85 And picPlayer1.Location.X - picPlayer2.Location.X > 5)) And picPlayer2.Location.Y >= 300 Then
            picPlayer2.Location = New Point(picPlayer2.Location.X, 300)
            tmrActions2.Enabled = False
            in_range2 = True
        ElseIf counthit2 = 19 And in_range2 = False Then
            tmrHit2.Enabled = False
            counthit2 = 0
            is_hit2 = False
        End If

        If in_range2 = True Then
            moving2 = False
            If counthit2 = 20 Then
                If direction2 = 1 Then
                    picPlayer2.Image = My.Resources.Hit_Still_SR
                Else
                    picPlayer2.Image = My.Resources.Hit_Still_SL
                End If
                health2 = health2 - damage
            End If
            If counthit2 > 20 Then
                If counthit2 Mod 3 = 0 Then
                    picPlayer2.Location = New Point(picPlayer2.Location.X + 2 * direction, picPlayer2.Location.Y)
                End If
            End If
            If counthit2 >= 30 Then
                tmrHit2.Enabled = False
                counthit2 = 0
                is_hit2 = False
                still2()
                in_range2 = False
            End If
        End If
    End Sub

    'PLAYER 1 TIMERS

    Private Sub tmrMove_Tick(sender As Object, e As EventArgs) Handles tmrMove.Tick
        If moving = True Then
            picPlayer1.Location = New Point(picPlayer1.Location.X + direction * speed, picPlayer1.Location.Y)
        End If
    End Sub

    Private Sub tmrActions_Tick(sender As Object, e As EventArgs) Handles tmrActions.Tick
        If picPlayer1.AccessibleDescription = "jumping" Then
            count += 1
            If count > 10 Then
                picPlayer1.Location = New Point(picPlayer1.Location.X, 300 - 45 * (count - 10) / 5 + 5 * ((count - 10) / 5) ^ 2)
                If picPlayer1.Location.Y >= 301 Then
                    picPlayer1.Location = New Point(picPlayer1.Location.X, 300)
                    tmrActions.Enabled = False
                    count = 0
                    If moving = False Then
                        still()
                    Else
                        run()
                        moving = True
                    End If
                End If
            End If
        ElseIf picPlayer1.AccessibleDescription = "ducking" Then
            count += 1
            If count >= 8 Then
                If direction = 1 Then
                    picPlayer1.Image = My.Resources.Duck_Still_SR
                    picPlayer1P.Image = My.Resources.Duck_Still_SR
                Else
                    picPlayer1.Image = My.Resources.Duck_Still_SL
                    picPlayer1P.Image = My.Resources.Duck_Still_SL
                End If
                tmrActions.Enabled = False
                count = 0
            End If
        ElseIf picPlayer1.AccessibleDescription = "punching" Then
            count += 1
            If count >= 30 Then
                tmrActions.Enabled = False
                count = 0
                If moving = False Then
                    still()
                Else
                    run()
                    moving = True
                End If
            End If
        ElseIf picPlayer1.AccessibleDescription = "kicking" Then
            count += 1
            If count >= 30 Then
                tmrActions.Enabled = False
                count = 0
                If moving = False Then
                    still()
                Else
                    run()
                    moving = True
                End If
            End If
        ElseIf picPlayer1.AccessibleDescription = "blocking" Then
            count += 1
            If count >= 8 Then
                If direction = 1 Then
                    picPlayer1.Image = My.Resources.Block_Still_SR
                    picPlayer1P.Image = My.Resources.Block_Still_SR
                Else
                    picPlayer1.Image = My.Resources.Block_Still_SL
                    picPlayer1P.Image = My.Resources.Block_Still_SL
                End If
                tmrActions.Enabled = False
                count = 0
            End If
        ElseIf picPlayer1.AccessibleDescription = "lowkicking" Or picPlayer1.AccessibleDescription = "lowkicking_still" Then
            count += 1
            If count >= 30 Then
                tmrActions.Enabled = False
                count = 0
                If picPlayer1.AccessibleDescription = "lowkicking" Then
                    duck()
                ElseIf picPlayer1.AccessibleDescription = "lowkicking_still" Then
                    still()
                End If
            End If
        ElseIf picPlayer1.AccessibleDescription = "punching_fast" Then
            count += 1
            If count >= 10 Then
                moving = True
                speed = 8
            End If
            If count >= 30 Then
                tmrActions.Enabled = False
                count = 0
                still()
            End If
        ElseIf picPlayer1.AccessibleDescription = "kicking_fast" Then
            count += 1
            If count >= 10 Then
                moving = True
                speed = 8
            End If
            If count >= 30 Then
                tmrActions.Enabled = False
                count = 0
                still()
            End If
        End If
    End Sub

    'PLAYER 2 TIMERS

    Private Sub tmrMove_Tick2(sender As Object, e As EventArgs) Handles tmrMove2.Tick
        If moving2 = True Then
            picPlayer2.Location = New Point(picPlayer2.Location.X + direction2 * speed2, picPlayer2.Location.Y)
        End If
    End Sub

    Private Sub tmrActions_Tick2(sender As Object, e As EventArgs) Handles tmrActions2.Tick
        If picPlayer2.AccessibleDescription = "jumping" Then
            count2 += 1
            If count2 > 10 Then
                picPlayer2.Location = New Point(picPlayer2.Location.X, 300 - 45 * (count2 - 10) / 5 + 5 * ((count2 - 10) / 5) ^ 2)
                If picPlayer2.Location.Y >= 301 Then
                    picPlayer2.Location = New Point(picPlayer2.Location.X, 300)
                    tmrActions2.Enabled = False
                    count2 = 0
                    If moving2 = False Then
                        still2()
                    Else
                        run2()
                        moving2 = True
                    End If
                End If
            End If
        ElseIf picPlayer2.AccessibleDescription = "ducking" Then
            count2 += 1
            If count2 >= 8 Then
                If direction2 = 1 Then
                    picPlayer2.Image = My.Resources.Duck_Still_SR
                Else
                    picPlayer2.Image = My.Resources.Duck_Still_SL
                End If
                tmrActions2.Enabled = False
                count2 = 0
            End If
        ElseIf picPlayer2.AccessibleDescription = "punching" Then
            count2 += 1
            If count2 >= 30 Then
                tmrActions2.Enabled = False
                count2 = 0
                If moving2 = False Then
                    still2()
                Else
                    run2()
                    moving2 = True
                End If
            End If
        ElseIf picPlayer2.AccessibleDescription = "kicking" Then
            count2 += 1
            If count2 >= 30 Then
                tmrActions2.Enabled = False
                count2 = 0
                If moving2 = False Then
                    still2()
                Else
                    run2()
                    moving2 = True
                End If
            End If
        ElseIf picPlayer2.AccessibleDescription = "blocking" Then
            count2 += 1
            If count2 >= 8 Then
                If direction2 = 1 Then
                    picPlayer2.Image = My.Resources.Block_Still_SR
                Else
                    picPlayer2.Image = My.Resources.Block_Still_SL
                End If
                tmrActions2.Enabled = False
                count2 = 0
            End If
        ElseIf picPlayer2.AccessibleDescription = "lowkicking" Or picPlayer2.AccessibleDescription = "lowkicking_still" Then
            count2 += 1
            If count2 >= 30 Then
                tmrActions2.Enabled = False
                count2 = 0
                If picPlayer2.AccessibleDescription = "lowkicking" Then
                    duck2()
                ElseIf picPlayer2.AccessibleDescription = "lowkicking_still" Then
                    still2()
                End If
            End If
        ElseIf picPlayer2.AccessibleDescription = "punching_fast" Then
            count2 += 1
            If count2 >= 10 Then
                moving2 = True
                speed2 = 8
            End If
            If count2 >= 30 Then
                tmrActions2.Enabled = False
                count2 = 0
                still2()
            End If
        ElseIf picPlayer2.AccessibleDescription = "kicking_fast" Then
            count2 += 1
            If count2 >= 10 Then
                moving2 = True
                speed2 = 8
            End If
            If count2 >= 30 Then
                tmrActions2.Enabled = False
                count2 = 0
                still2()
            End If
        End If
    End Sub

    'PARENTING

    Sub tmrParent_Tick(sender As Object, e As EventArgs) Handles tmrParent.Tick
        picPlayer1P.Location = New Point(picPlayer1.Location.X - picPlayer2.Location.X, picPlayer1.Location.Y - picPlayer2.Location.Y)
    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picPlayer1P.Parent = picPlayer2
    End Sub

    'HEALTH + MANA + BOUNDARIES, LOSS

    Private Sub tmrHealth_Tick(sender As Object, e As EventArgs) Handles tmrHealth.Tick
        If health2 > 0 Then
            healthPlayer2.Size = New Size(health2, 35)
        Else
            tmrHealth.Enabled = False
            healthPlayer2.Size = New Size(0, 35)
            picPlayer2.Size = New Size(210, 200)
            tmrLoss.Enabled = True
            still()
            still2()
        End If
        If health > 0 Then
            healthPlayer1.Size = New Size(health, 35)
            healthPlayer1.Location = New Point(1005 - health, 75)
        Else
            tmrHealth.Enabled = False
            healthPlayer1.Size = New Size(0, 35)
            picPlayer1.Size = New Size(210, 200)
            picPlayer1P.Size = New Size(210, 200)
            tmrLoss.Enabled = True
            still()
            still2()
        End If

        manaPlayer2.Size = New Size(mana2, 15)
        manaPlayer1.Size = New Size(mana, 15)
        manaPlayer1.Location = New Point(1005 - mana, 130)
    End Sub

    Private Sub tmrMana_Tick(sender As Object, e As EventArgs) Handles tmrMana.Tick
        If mana < 400 Then
            mana += 1
        End If
        If mana2 < 400 Then
            mana2 += 1
        End If
    End Sub

    Private Sub tmrBoundary_Tick(sender As Object, e As EventArgs) Handles tmrBoundary.Tick
        If Me.WindowState <> FormWindowState.Minimized Then
            If picPlayer1.Location.X <= 55 Or picPlayer1.Location.X >= 900 Then
                playable = False
                If picPlayer1.Location.Y > 300 Then
                    health = health - 10
                End If
                If picPlayer1.Location.X <= 55 Then
                    picPlayer1.Location = New Point(45, picPlayer1.Location.Y + 15)
                ElseIf picPlayer1.Location.X >= 900 Then
                    picPlayer1.Location = New Point(910, picPlayer1.Location.Y + 15)
                End If
            End If
            If picPlayer2.Location.X <= 55 Or picPlayer2.Location.X >= 900 Then
                playable2 = False
                If picPlayer2.Location.Y > 300 Then
                    health2 = health2 - 10
                End If
                If picPlayer2.Location.X <= 55 Then
                    picPlayer2.Location = New Point(45, picPlayer2.Location.Y + 15)
                ElseIf picPlayer2.Location.X >= 900 Then
                    picPlayer2.Location = New Point(910, picPlayer2.Location.Y + 15)
                End If
            End If
        End If
    End Sub

    Private Sub tmrLoss_Tick(sender As Object, e As EventArgs) Handles tmrLoss.Tick
        playable = False
        playable2 = False
        If health <= 0 Then
            count += 1
            If direction = 1 Then
                picPlayer1.Image = My.Resources.Falling_Still_SR
                picPlayer1P.Image = My.Resources.Falling_Still_SR
            Else
                picPlayer1.Image = My.Resources.Falling_Still_SL
                picPlayer1P.Image = My.Resources.Falling_Still_SL
            End If
            If count > 75 Then
                If direction2 = 1 Then
                    picPlayer2.Image = My.Resources.Winning_Still_SR
                Else
                    picPlayer2.Image = My.Resources.Winning_Still_SL
                End If
            End If
            If count > 100 Then
                Winner.Visible = True
                Winner.Image = My.Resources.Payer2_wins
            End If
            If count > 175 Then
                count = 0
                tmrLoss.Enabled = False
                Dim nfrm = New Start
                nfrm.Show()
                Me.Hide()
            End If
        Else
            count2 += 1
            If direction2 = 1 Then
                picPlayer2.Image = My.Resources.Falling_Still_SR
            Else
                picPlayer2.Image = My.Resources.Falling_Still_SL
            End If
            If count2 > 75 Then
                If direction = 1 Then
                    picPlayer1.Image = My.Resources.Winning_Still_SR
                    picPlayer1P.Image = My.Resources.Winning_Still_SR
                Else
                    picPlayer1.Image = My.Resources.Winning_Still_SL
                    picPlayer1P.Image = My.Resources.Winning_Still_SL
                End If
            End If
            If count2 > 100 Then
                Winner.Visible = True
                Winner.Image = My.Resources.Payer1_wins
            End If
            If count2 > 175 Then
                count2 = 0
                tmrLoss.Enabled = False
                Dim nfrm = New Start
                nfrm.Show()
                Me.Hide()
            End If
        End If
    End Sub

    'BREAK BETWEEN ACTIONS

    Private Sub tmrBreak_Tick(sender As Object, e As EventArgs) Handles tmrBreak.Tick
        countbreak += 1
        actionable = False
        If countbreak >= 60 Then
            actionable = True
            tmrBreak.Enabled = False
            countbreak = 0
        End If
    End Sub

    Private Sub tmrBreak2_Tick(sender As Object, e As EventArgs) Handles tmrBreak2.Tick
        countbreak2 += 1
        actionable2 = False
        If countbreak2 >= 60 Then
            actionable2 = True
            tmrBreak2.Enabled = False
            countbreak2 = 0
        End If
    End Sub

    'EXTRA COMMANDS

    Sub Pause_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.P Then
            still()
            still2()
            Dim nfrm = New Pause
            nfrm.Show()
            GlobalGame.game.Hide()
        End If
    End Sub

    Private Sub lblMinimize_Click(sender As Object, e As EventArgs) Handles lblMinimize.Click
        still()
        still2()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        End
    End Sub
End Class
