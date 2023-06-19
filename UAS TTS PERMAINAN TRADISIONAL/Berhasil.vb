Public Class Berhasil
    Private TargetDT1 As DateTime
    Private CountDownFrom1 As TimeSpan = TimeSpan.FromSeconds(7)

    Private Sub Berhasil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.Show()
        TargetDT1 = DateTime.Now.Add(CountDownFrom1)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim ts As TimeSpan = TargetDT1.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            AxWindowsMediaPlayer1.Show()
        Else
            Timer1.Stop()
            PBSukses.Show()
            PBKembali.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBKembali.Click
        Me.Hide()
        Menu_Utama.Show()
    End Sub
End Class