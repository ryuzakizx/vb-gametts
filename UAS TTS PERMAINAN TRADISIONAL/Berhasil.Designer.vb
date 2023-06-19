<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Berhasil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Berhasil))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PBKembali = New System.Windows.Forms.PictureBox()
        Me.PBSukses = New System.Windows.Forms.PictureBox()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSukses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(-2, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(1152, 698)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'Timer1
        '
        '
        'PBKembali
        '
        Me.PBKembali.Image = Global.UAS_TTS_PERMAINAN_TRADISIONAL.My.Resources.Resources.selamat_sukses__2_
        Me.PBKembali.Location = New System.Drawing.Point(602, 536)
        Me.PBKembali.Name = "PBKembali"
        Me.PBKembali.Size = New System.Drawing.Size(147, 142)
        Me.PBKembali.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBKembali.TabIndex = 2
        Me.PBKembali.TabStop = False
        Me.PBKembali.Visible = False
        '
        'PBSukses
        '
        Me.PBSukses.Image = Global.UAS_TTS_PERMAINAN_TRADISIONAL.My.Resources.Resources.selamat_sukses
        Me.PBSukses.Location = New System.Drawing.Point(-2, 0)
        Me.PBSukses.Name = "PBSukses"
        Me.PBSukses.Size = New System.Drawing.Size(1537, 827)
        Me.PBSukses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBSukses.TabIndex = 1
        Me.PBSukses.TabStop = False
        Me.PBSukses.Visible = False
        '
        'Berhasil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1547, 839)
        Me.Controls.Add(Me.PBKembali)
        Me.Controls.Add(Me.PBSukses)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Name = "Berhasil"
        Me.Text = "Berhasil"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBKembali, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSukses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PBSukses As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PBKembali As System.Windows.Forms.PictureBox
End Class
