<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mulai_Bermain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mulai_Bermain))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LblWaktu = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PBGambar1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PBGambar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gold
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(-2, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1576, 148)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(421, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1041, 84)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TTS PERMAINAN TRADISIONAL"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.OvalShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1576, 148)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.Maroon
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Maroon
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.Location = New System.Drawing.Point(143, 15)
        Me.RectangleShape2.Name = "RectangleShape1"
        Me.RectangleShape2.Size = New System.Drawing.Size(92, 87)
        '
        'OvalShape2
        '
        Me.OvalShape2.BackColor = System.Drawing.Color.Maroon
        Me.OvalShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape2.BorderColor = System.Drawing.Color.Maroon
        Me.OvalShape2.BorderWidth = 2
        Me.OvalShape2.Location = New System.Drawing.Point(20, 14)
        Me.OvalShape2.Name = "OvalShape1"
        Me.OvalShape2.Size = New System.Drawing.Size(92, 87)
        '
        'LblWaktu
        '
        Me.LblWaktu.AutoSize = True
        Me.LblWaktu.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWaktu.ForeColor = System.Drawing.Color.White
        Me.LblWaktu.Location = New System.Drawing.Point(247, 274)
        Me.LblWaktu.Name = "LblWaktu"
        Me.LblWaktu.Size = New System.Drawing.Size(97, 39)
        Me.LblWaktu.TabIndex = 4
        Me.LblWaktu.Text = "00:00"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 810)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "v.1.0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 39)
        Me.Label4.TabIndex = 7
        '
        'PBGambar1
        '
        Me.PBGambar1.Image = Global.UAS_TTS_PERMAINAN_TRADISIONAL.My.Resources.Resources.cara_bermain
        Me.PBGambar1.InitialImage = Global.UAS_TTS_PERMAINAN_TRADISIONAL.My.Resources.Resources.cara_bermain
        Me.PBGambar1.Location = New System.Drawing.Point(157, 195)
        Me.PBGambar1.Name = "PBGambar1"
        Me.PBGambar1.Size = New System.Drawing.Size(1184, 589)
        Me.PBGambar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBGambar1.TabIndex = 3
        Me.PBGambar1.TabStop = False
        '
        'Mulai_Bermain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1528, 855)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBGambar1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LblWaktu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Mulai_Bermain"
        Me.Text = "Mari Mulai Bermain"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PBGambar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents OvalShape2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents PBGambar1 As System.Windows.Forms.PictureBox
    Friend WithEvents LblWaktu As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
