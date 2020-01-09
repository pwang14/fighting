<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.lblInstructions = New System.Windows.Forms.PictureBox()
        Me.lblStart = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.PictureBox()
        Me.lblMinimize = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.chkSound = New System.Windows.Forms.CheckBox()
        CType(Me.lblInstructions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInstructions.Image = Global.StickFigure.My.Resources.Resources.Instructions
        Me.lblInstructions.Location = New System.Drawing.Point(300, 325)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(150, 75)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.TabStop = False
        '
        'lblStart
        '
        Me.lblStart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStart.Image = Global.StickFigure.My.Resources.Resources.Start
        Me.lblStart.Location = New System.Drawing.Point(300, 229)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(150, 75)
        Me.lblStart.TabIndex = 1
        Me.lblStart.TabStop = False
        '
        'Title
        '
        Me.Title.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Title.BackColor = System.Drawing.Color.White
        Me.Title.Image = Global.StickFigure.My.Resources.Resources.Title
        Me.Title.Location = New System.Drawing.Point(125, 75)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(500, 125)
        Me.Title.TabIndex = 0
        Me.Title.TabStop = False
        '
        'lblMinimize
        '
        Me.lblMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMinimize.AutoSize = True
        Me.lblMinimize.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimize.Location = New System.Drawing.Point(660, 9)
        Me.lblMinimize.Name = "lblMinimize"
        Me.lblMinimize.Size = New System.Drawing.Size(33, 38)
        Me.lblMinimize.TabIndex = 3
        Me.lblMinimize.Text = "-"
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.Location = New System.Drawing.Point(699, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(33, 38)
        Me.lblClose.TabIndex = 4
        Me.lblClose.Text = "x"
        '
        'chkSound
        '
        Me.chkSound.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSound.AutoSize = True
        Me.chkSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSound.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSound.Location = New System.Drawing.Point(661, 459)
        Me.chkSound.Name = "chkSound"
        Me.chkSound.Size = New System.Drawing.Size(68, 27)
        Me.chkSound.TabIndex = 5
        Me.chkSound.Text = "Music"
        Me.chkSound.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(748, 498)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkSound)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblMinimize)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(750, 500)
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.lblInstructions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As System.Windows.Forms.PictureBox
    Friend WithEvents lblStart As System.Windows.Forms.PictureBox
    Friend WithEvents lblInstructions As System.Windows.Forms.PictureBox
    Friend WithEvents lblMinimize As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents chkSound As System.Windows.Forms.CheckBox
End Class
