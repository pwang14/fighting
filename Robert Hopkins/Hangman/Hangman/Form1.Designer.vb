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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lnP4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lnP3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lnP2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lnP1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lnArmL = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lnArmR = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lnLegL = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lnLegR = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ovlHead = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.lnBody = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.lnP4, Me.lnP3, Me.lnP2, Me.lnP1, Me.lnArmL, Me.lnArmR, Me.lnLegL, Me.lnLegR, Me.ovlHead, Me.lnBody})
        Me.ShapeContainer1.Size = New System.Drawing.Size(734, 461)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'lnP4
        '
        Me.lnP4.BorderWidth = 10
        Me.lnP4.Name = "lnP4"
        Me.lnP4.X1 = 175
        Me.lnP4.X2 = 175
        Me.lnP4.Y1 = 45
        Me.lnP4.Y2 = 75
        '
        'lnP3
        '
        Me.lnP3.BorderWidth = 10
        Me.lnP3.Name = "lnP3"
        Me.lnP3.X1 = 75
        Me.lnP3.X2 = 180
        Me.lnP3.Y1 = 45
        Me.lnP3.Y2 = 45
        '
        'lnP2
        '
        Me.lnP2.BorderWidth = 10
        Me.lnP2.Name = "lnP2"
        Me.lnP2.X1 = 80
        Me.lnP2.X2 = 80
        Me.lnP2.Y1 = 40
        Me.lnP2.Y2 = 240
        '
        'lnP1
        '
        Me.lnP1.BorderWidth = 10
        Me.lnP1.Name = "lnP1"
        Me.lnP1.X1 = 50
        Me.lnP1.X2 = 110
        Me.lnP1.Y1 = 240
        Me.lnP1.Y2 = 240
        '
        'lnArmL
        '
        Me.lnArmL.BorderWidth = 10
        Me.lnArmL.Name = "lnArmL"
        Me.lnArmL.Visible = False
        Me.lnArmL.X1 = 175
        Me.lnArmL.X2 = 150
        Me.lnArmL.Y1 = 140
        Me.lnArmL.Y2 = 160
        '
        'lnArmR
        '
        Me.lnArmR.BorderWidth = 10
        Me.lnArmR.Name = "lnArmR"
        Me.lnArmR.Visible = False
        Me.lnArmR.X1 = 175
        Me.lnArmR.X2 = 200
        Me.lnArmR.Y1 = 140
        Me.lnArmR.Y2 = 160
        '
        'lnLegL
        '
        Me.lnLegL.BorderWidth = 10
        Me.lnLegL.Name = "lnLegL"
        Me.lnLegL.Visible = False
        Me.lnLegL.X1 = 175
        Me.lnLegL.X2 = 150
        Me.lnLegL.Y1 = 175
        Me.lnLegL.Y2 = 200
        '
        'lnLegR
        '
        Me.lnLegR.BorderWidth = 10
        Me.lnLegR.Name = "lnLegR"
        Me.lnLegR.Visible = False
        Me.lnLegR.X1 = 175
        Me.lnLegR.X2 = 200
        Me.lnLegR.Y1 = 175
        Me.lnLegR.Y2 = 200
        '
        'ovlHead
        '
        Me.ovlHead.BorderWidth = 10
        Me.ovlHead.Location = New System.Drawing.Point(150, 75)
        Me.ovlHead.Name = "ovlHead"
        Me.ovlHead.Size = New System.Drawing.Size(50, 50)
        Me.ovlHead.Visible = False
        '
        'lnBody
        '
        Me.lnBody.BorderWidth = 10
        Me.lnBody.Name = "lnBody"
        Me.lnBody.Visible = False
        Me.lnBody.X1 = 175
        Me.lnBody.X2 = 175
        Me.lnBody.Y1 = 125
        Me.lnBody.Y2 = 180
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Game"
        Me.Text = "Hangman"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lnLegL As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lnLegR As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ovlHead As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents lnBody As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lnArmL As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lnArmR As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lnP2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lnP1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lnP4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lnP3 As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
