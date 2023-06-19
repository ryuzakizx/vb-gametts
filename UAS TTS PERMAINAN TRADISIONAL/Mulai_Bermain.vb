Public Class Mulai_Bermain

    Private TargetDT1 As DateTime
    Private CountDownFrom1 As TimeSpan = TimeSpan.FromSeconds(5)

    Private Sub Menu_TTS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PBGambar1.Image = My.Resources.cara_bermain

        TargetDT1 = DateTime.Now.Add(CountDownFrom1)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim ts As TimeSpan = TargetDT1.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            LblWaktu.Text = ts.ToString("mm\:ss")
        Else
            LblWaktu.Text = "00:00"
            Timer1.Stop()
            TampilTTS()
        End If
    End Sub

    Public Sub TampilTTS()
        Me.Close()
        Menu_TTS.Show()
    End Sub
End Class