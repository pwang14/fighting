<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.tmrMove = New System.Windows.Forms.Timer(Me.components)
        Me.tmrActions = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMove2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrActions2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrParent = New System.Windows.Forms.Timer(Me.components)
        Me.tmrHit = New System.Windows.Forms.Timer(Me.components)
        Me.tmrHit2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrHealth = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBreak = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBreak2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMana = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLoss = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBoundary = New System.Windows.Forms.Timer(Me.components)
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblVS = New System.Windows.Forms.Label()
        Me.Winner = New System.Windows.Forms.PictureBox()
        Me.Floor = New System.Windows.Forms.PictureBox()
        Me.manaPlayer1 = New System.Windows.Forms.PictureBox()
        Me.manaPlayer2 = New System.Windows.Forms.PictureBox()
        Me.healthPlayer1 = New System.Windows.Forms.PictureBox()
        Me.healthPlayer2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer1P = New System.Windows.Forms.PictureBox()
        Me.picPlayer2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.picBlack2 = New System.Windows.Forms.PictureBox()
        Me.picBlack1 = New System.Windows.Forms.PictureBox()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblMinimize = New System.Windows.Forms.Label()
        CType(Me.Winner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.manaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.manaPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.healthPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.healthPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1P, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlack2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlack1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrMove
        '
        Me.tmrMove.Enabled = True
        Me.tmrMove.Interval = 1
        '
        'tmrActions
        '
        Me.tmrActions.Interval = 1
        '
        'tmrMove2
        '
        Me.tmrMove2.Enabled = True
        Me.tmrMove2.Interval = 1
        '
        'tmrActions2
        '
        Me.tmrActions2.Interval = 1
        '
        'tmrParent
        '
        Me.tmrParent.Enabled = True
        Me.tmrParent.Interval = 1
        '
        'tmrHit
        '
        Me.tmrHit.Interval = 1
        '
        'tmrHit2
        '
        Me.tmrHit2.Interval = 1
        '
        'tmrHealth
        '
        Me.tmrHealth.Enabled = True
        Me.tmrHealth.Interval = 1
        '
        'tmrBreak
        '
        Me.tmrBreak.Interval = 1
        '
        'tmrBreak2
        '
        Me.tmrBreak2.Interval = 1
        '
        'tmrMana
        '
        Me.tmrMana.Enabled = True
        '
        'tmrLoss
        '
        Me.tmrLoss.Interval = 1
        '
        'tmrBoundary
        '
        Me.tmrBoundary.Enabled = True
        Me.tmrBoundary.Interval = 1
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2.Location = New System.Drawing.Point(43, 162)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(124, 38)
        Me.lblPlayer2.TabIndex = 13
        Me.lblPlayer2.Text = "Player 2"
        '
        'lblPlayer1
        '
        Me.lblPlayer1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1.Location = New System.Drawing.Point(881, 162)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(124, 38)
        Me.lblPlayer1.TabIndex = 14
        Me.lblPlayer1.Text = "Player 1"
        '
        'lblVS
        '
        Me.lblVS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblVS.AutoSize = True
        Me.lblVS.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVS.Location = New System.Drawing.Point(501, 75)
        Me.lblVS.Name = "lblVS"
        Me.lblVS.Size = New System.Drawing.Size(70, 49)
        Me.lblVS.TabIndex = 15
        Me.lblVS.Text = "VS"
        '
        'Winner
        '
        Me.Winner.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Winner.Location = New System.Drawing.Point(430, 175)
        Me.Winner.Name = "Winner"
        Me.Winner.Size = New System.Drawing.Size(200, 75)
        Me.Winner.TabIndex = 16
        Me.Winner.TabStop = False
        Me.Winner.Visible = False
        '
        'Floor
        '
        Me.Floor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Floor.BackColor = System.Drawing.Color.DarkGray
        Me.Floor.BackgroundImage = Global.StickFigure.My.Resources.Resources.Floor
        Me.Floor.Location = New System.Drawing.Point(140, 490)
        Me.Floor.Name = "Floor"
        Me.Floor.Size = New System.Drawing.Size(800, 200)
        Me.Floor.TabIndex = 12
        Me.Floor.TabStop = False
        '
        'manaPlayer1
        '
        Me.manaPlayer1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.manaPlayer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.manaPlayer1.Location = New System.Drawing.Point(605, 130)
        Me.manaPlayer1.Name = "manaPlayer1"
        Me.manaPlayer1.Size = New System.Drawing.Size(400, 15)
        Me.manaPlayer1.TabIndex = 11
        Me.manaPlayer1.TabStop = False
        '
        'manaPlayer2
        '
        Me.manaPlayer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.manaPlayer2.Location = New System.Drawing.Point(50, 130)
        Me.manaPlayer2.Name = "manaPlayer2"
        Me.manaPlayer2.Size = New System.Drawing.Size(400, 15)
        Me.manaPlayer2.TabIndex = 10
        Me.manaPlayer2.TabStop = False
        '
        'healthPlayer1
        '
        Me.healthPlayer1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.healthPlayer1.BackColor = System.Drawing.Color.Red
        Me.healthPlayer1.Location = New System.Drawing.Point(605, 75)
        Me.healthPlayer1.Name = "healthPlayer1"
        Me.healthPlayer1.Size = New System.Drawing.Size(400, 35)
        Me.healthPlayer1.TabIndex = 5
        Me.healthPlayer1.TabStop = False
        '
        'healthPlayer2
        '
        Me.healthPlayer2.BackColor = System.Drawing.Color.Red
        Me.healthPlayer2.Location = New System.Drawing.Point(50, 75)
        Me.healthPlayer2.Name = "healthPlayer2"
        Me.healthPlayer2.Size = New System.Drawing.Size(400, 35)
        Me.healthPlayer2.TabIndex = 4
        Me.healthPlayer2.TabStop = False
        '
        'picPlayer1P
        '
        Me.picPlayer1P.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer1P.Image = Global.StickFigure.My.Resources.Resources.Still_SL
        Me.picPlayer1P.Location = New System.Drawing.Point(260, 0)
        Me.picPlayer1P.Name = "picPlayer1P"
        Me.picPlayer1P.Size = New System.Drawing.Size(120, 200)
        Me.picPlayer1P.TabIndex = 2
        Me.picPlayer1P.TabStop = False
        '
        'picPlayer2
        '
        Me.picPlayer2.AccessibleDescription = "still"
        Me.picPlayer2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picPlayer2.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer2.Image = Global.StickFigure.My.Resources.Resources.Still_SR
        Me.picPlayer2.Location = New System.Drawing.Point(260, 300)
        Me.picPlayer2.Name = "picPlayer2"
        Me.picPlayer2.Size = New System.Drawing.Size(120, 200)
        Me.picPlayer2.TabIndex = 1
        Me.picPlayer2.TabStop = False
        '
        'picPlayer1
        '
        Me.picPlayer1.AccessibleDescription = "still"
        Me.picPlayer1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picPlayer1.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer1.Image = Global.StickFigure.My.Resources.Resources.Still_SL
        Me.picPlayer1.Location = New System.Drawing.Point(675, 300)
        Me.picPlayer1.Name = "picPlayer1"
        Me.picPlayer1.Size = New System.Drawing.Size(120, 200)
        Me.picPlayer1.TabIndex = 0
        Me.picPlayer1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(50, 75)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(400, 35)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(605, 75)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(400, 35)
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'picBlack2
        '
        Me.picBlack2.BackColor = System.Drawing.Color.Black
        Me.picBlack2.Location = New System.Drawing.Point(41, 66)
        Me.picBlack2.Name = "picBlack2"
        Me.picBlack2.Size = New System.Drawing.Size(418, 53)
        Me.picBlack2.TabIndex = 6
        Me.picBlack2.TabStop = False
        '
        'picBlack1
        '
        Me.picBlack1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBlack1.BackColor = System.Drawing.Color.Black
        Me.picBlack1.Location = New System.Drawing.Point(596, 66)
        Me.picBlack1.Name = "picBlack1"
        Me.picBlack1.Size = New System.Drawing.Size(418, 53)
        Me.picBlack1.TabIndex = 7
        Me.picBlack1.TabStop = False
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.Location = New System.Drawing.Point(1033, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(33, 38)
        Me.lblClose.TabIndex = 18
        Me.lblClose.Text = "x"
        '
        'lblMinimize
        '
        Me.lblMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMinimize.AutoSize = True
        Me.lblMinimize.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimize.Location = New System.Drawing.Point(994, 9)
        Me.lblMinimize.Name = "lblMinimize"
        Me.lblMinimize.Size = New System.Drawing.Size(33, 38)
        Me.lblMinimize.TabIndex = 17
        Me.lblMinimize.Text = "-"
        '
        'Game
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1078, 698)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblMinimize)
        Me.Controls.Add(Me.Winner)
        Me.Controls.Add(Me.lblVS)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.Floor)
        Me.Controls.Add(Me.manaPlayer1)
        Me.Controls.Add(Me.manaPlayer2)
        Me.Controls.Add(Me.healthPlayer1)
        Me.Controls.Add(Me.healthPlayer2)
        Me.Controls.Add(Me.picPlayer1P)
        Me.Controls.Add(Me.picPlayer2)
        Me.Controls.Add(Me.picPlayer1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.picBlack2)
        Me.Controls.Add(Me.picBlack1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1080, 700)
        Me.MinimizeBox = False
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Winner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.manaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.manaPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.healthPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.healthPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1P, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlack2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlack1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPlayer1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMove As System.Windows.Forms.Timer
    Friend WithEvents tmrActions As System.Windows.Forms.Timer
    Friend WithEvents tmrMove2 As System.Windows.Forms.Timer
    Friend WithEvents tmrActions2 As System.Windows.Forms.Timer
    Friend WithEvents picPlayer2 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrParent As System.Windows.Forms.Timer
    Friend WithEvents tmrHit As System.Windows.Forms.Timer
    Friend WithEvents tmrHit2 As System.Windows.Forms.Timer
    Friend WithEvents picPlayer1P As System.Windows.Forms.PictureBox
    Friend WithEvents healthPlayer2 As System.Windows.Forms.PictureBox
    Friend WithEvents healthPlayer1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrHealth As System.Windows.Forms.Timer
    Friend WithEvents picBlack2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBlack1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrBreak As System.Windows.Forms.Timer
    Friend WithEvents tmrBreak2 As System.Windows.Forms.Timer
    Friend WithEvents tmrMana As System.Windows.Forms.Timer
    Friend WithEvents manaPlayer2 As System.Windows.Forms.PictureBox
    Friend WithEvents manaPlayer1 As System.Windows.Forms.PictureBox
    Friend WithEvents Floor As System.Windows.Forms.PictureBox
    Friend WithEvents tmrLoss As System.Windows.Forms.Timer
    Friend WithEvents tmrBoundary As System.Windows.Forms.Timer
    Friend WithEvents lblPlayer2 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer1 As System.Windows.Forms.Label
    Friend WithEvents lblVS As System.Windows.Forms.Label
    Friend WithEvents Winner As System.Windows.Forms.PictureBox
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblMinimize As System.Windows.Forms.Label

End Class
