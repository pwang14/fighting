<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Instructions))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbPlayer = New System.Windows.Forms.ComboBox()
        Me.lblExtra1 = New System.Windows.Forms.Label()
        Me.lblExtra2 = New System.Windows.Forms.Label()
        Me.lblGameplay = New System.Windows.Forms.Label()
        Me.lblActions1 = New System.Windows.Forms.Label()
        Me.lblActions2 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(24, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(175, 38)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Instructions"
        '
        'cmbPlayer
        '
        Me.cmbPlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPlayer.BackColor = System.Drawing.SystemColors.Control
        Me.cmbPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlayer.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlayer.FormattingEnabled = True
        Me.cmbPlayer.Items.AddRange(New Object() {"Player 1", "Player 2"})
        Me.cmbPlayer.Location = New System.Drawing.Point(31, 121)
        Me.cmbPlayer.Name = "cmbPlayer"
        Me.cmbPlayer.Size = New System.Drawing.Size(168, 29)
        Me.cmbPlayer.TabIndex = 1
        Me.cmbPlayer.TabStop = False
        '
        'lblExtra1
        '
        Me.lblExtra1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExtra1.AutoSize = True
        Me.lblExtra1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtra1.Location = New System.Drawing.Point(26, 83)
        Me.lblExtra1.Name = "lblExtra1"
        Me.lblExtra1.Size = New System.Drawing.Size(79, 27)
        Me.lblExtra1.TabIndex = 2
        Me.lblExtra1.Text = "Actions"
        '
        'lblExtra2
        '
        Me.lblExtra2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExtra2.AutoSize = True
        Me.lblExtra2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtra2.Location = New System.Drawing.Point(362, 83)
        Me.lblExtra2.Name = "lblExtra2"
        Me.lblExtra2.Size = New System.Drawing.Size(99, 27)
        Me.lblExtra2.TabIndex = 3
        Me.lblExtra2.Text = "Gameplay"
        '
        'lblGameplay
        '
        Me.lblGameplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGameplay.AutoSize = True
        Me.lblGameplay.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameplay.Location = New System.Drawing.Point(363, 121)
        Me.lblGameplay.Name = "lblGameplay"
        Me.lblGameplay.Size = New System.Drawing.Size(327, 240)
        Me.lblGameplay.TabIndex = 4
        Me.lblGameplay.Text = resources.GetString("lblGameplay.Text")
        '
        'lblActions1
        '
        Me.lblActions1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblActions1.AutoSize = True
        Me.lblActions1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActions1.Location = New System.Drawing.Point(27, 166)
        Me.lblActions1.Name = "lblActions1"
        Me.lblActions1.Size = New System.Drawing.Size(268, 180)
        Me.lblActions1.TabIndex = 5
        Me.lblActions1.Text = "RUN : Right, Left" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "JUMP : Up" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DUCK : Down" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BLOCK : J" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PUNCH : L" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "KICK : K" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LOWKIC" & _
    "K : Down + K" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FAST PUNCH : Down + Right, Left + L" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FAST KICK : Down + Right, Lef" & _
    "t + K"
        Me.lblActions1.Visible = False
        '
        'lblActions2
        '
        Me.lblActions2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblActions2.AutoSize = True
        Me.lblActions2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActions2.Location = New System.Drawing.Point(27, 166)
        Me.lblActions2.Name = "lblActions2"
        Me.lblActions2.Size = New System.Drawing.Size(205, 180)
        Me.lblActions2.TabIndex = 6
        Me.lblActions2.Text = "RUN : D, G" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "JUMP : R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DUCK : F" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BLOCK : D1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PUNCH : D3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "KICK : D2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LOWKICK : F + " & _
    "D2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FAST PUNCH : F + D, G + D3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FAST KICK : F + D, G + D2"
        Me.lblActions2.Visible = False
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(300, 400)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(150, 50)
        Me.btnStart.TabIndex = 7
        Me.btnStart.Text = "Back to Menu"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Instructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(748, 498)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblActions2)
        Me.Controls.Add(Me.lblActions1)
        Me.Controls.Add(Me.lblGameplay)
        Me.Controls.Add(Me.lblExtra2)
        Me.Controls.Add(Me.lblExtra1)
        Me.Controls.Add(Me.cmbPlayer)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(750, 500)
        Me.MinimumSize = New System.Drawing.Size(750, 500)
        Me.Name = "Instructions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmbPlayer As System.Windows.Forms.ComboBox
    Friend WithEvents lblExtra1 As System.Windows.Forms.Label
    Friend WithEvents lblExtra2 As System.Windows.Forms.Label
    Friend WithEvents lblGameplay As System.Windows.Forms.Label
    Friend WithEvents lblActions1 As System.Windows.Forms.Label
    Friend WithEvents lblActions2 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
End Class
