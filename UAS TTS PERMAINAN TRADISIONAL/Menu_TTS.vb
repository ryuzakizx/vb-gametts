Public Class Menu_TTS
    Private TargetDT1, TargetDT2, TargetDT3, TargetDT4 As DateTime
    Private CountDownFrom1 As TimeSpan = TimeSpan.FromSeconds(13)
    Private CountDownFrom2 As TimeSpan = TimeSpan.FromSeconds(13)
    Private CountDownFrom3 As TimeSpan = TimeSpan.FromSeconds(13)
    Private CountDownFrom4 As TimeSpan = TimeSpan.FromSeconds(13)
    Dim score As Integer = 0


    Private Sub Menu_TTS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TargetDT1 = DateTime.Now.Add(CountDownFrom1)
        LblScore.Text = score
        TTS1()
    End Sub

    Public Sub TTS1()
        TimerTTS01.Start()
        TbTTS1.Focus()
        BtnKirim1.Visible = True
        BtnKirim2.Visible = False
        BtnKirim2.Visible = False
    End Sub

    Public Sub jawaban1(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String, ByVal txt5 As String, ByVal txt6 As String)
        If (txt1 = "b" Or txt1 = "B") And (txt2 = "a" Or txt1 = "A") And (txt3 = "l" Or txt1 = "L") And (txt4 = "o" Or txt1 = "O") And (txt5 = "g" Or txt1 = "G") And (txt6 = "o" Or txt1 = "O") Then
            score = score + 40
            LblScore.Text = score
            My.Computer.Audio.Play(My.Resources.AUDIOTEST, AudioPlayMode.WaitToComplete)
            TargetDT1 = DateTime.Now.Add(CountDownFrom1)
        Else
            score = score + 0
            LblScore.Text = score
            TargetDT1 = DateTime.Now.Add(CountDownFrom1)
        End If
    End Sub

    Private Sub TimerTTS1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTTS01.Tick
        Dim ts As TimeSpan = TargetDT1.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            LblWaktu1.Text = ts.ToString("mm\:ss")
        Else
            My.Computer.Audio.Play(My.Resources.AUDIOTEST, AudioPlayMode.WaitToComplete)
            LblWaktu1.Text = "00:00"
            TimerTTS01.Stop()
            TTS2()
            TargetDT2 = DateTime.Now.Add(CountDownFrom2)
        End If
    End Sub

    Private Sub BtnKirim1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKirim1.Click
        jawaban1(TbTTS1.Text, TbTTS2.Text, TbTTS3.Text, TbTTS4.Text, TbTTS5.Text, TbTTS6.Text)
        TTS2()
    End Sub

    Public Sub TTS2()
        TimerTTS02.Start()
        TbTTS1.Enabled = False
        TbTTS2.Enabled = False
        TbTTS3.Enabled = False
        TbTTS4.Enabled = False
        TbTTS5.Enabled = False
        TbTTS6.Enabled = False
        TbTTS7.Enabled = True
        TbTTS7.Focus()
        TbTTS8.Enabled = True
        TbTTS9.Enabled = True
        TbTTS10.Enabled = True
        TbTTS11.Enabled = True
        PBGambarTTS2.Visible = True
        PBGambarTTS.Visible = False
        PBGambarTTS3.Visible = False
        BtnKirim1.Visible = False
        BtnKirim2.Visible = True
    End Sub

    Public Sub jawaban2(ByVal txt12 As String, ByVal txt22 As String, ByVal txt32 As String, ByVal txt42 As String, ByVal txt52 As String, ByVal txt62 As String)
        If (txt12 = "g" Or txt12 = "G") And (txt22 = "a" Or txt12 = "A") And (txt32 = "s" Or txt12 = "S") And (txt42 = "i" Or txt12 = "I") And (txt52 = "n" Or txt12 = "N") And (txt62 = "g" Or txt12 = "G") Then
            score = score + 40
            LblScore.Text = score
            My.Computer.Audio.Play(My.Resources.AUDIOTEST, AudioPlayMode.WaitToComplete)
            TargetDT1 = DateTime.Now.Add(CountDownFrom1)
        Else
            score = score + 0
            LblScore.Text = score
            TargetDT1 = DateTime.Now.Add(CountDownFrom1)
        End If
    End Sub

   
    Private Sub TimerTTS2_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTTS02.Tick
        Dim ts As TimeSpan = TargetDT1.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            LblWaktu1.Text = ts.ToString("mm\:ss")
        Else
            LblWaktu1.Text = "00:00"
            TimerTTS02.Stop()
            TTS3()
            TargetDT3 = DateTime.Now.Add(CountDownFrom3)
        End If
    End Sub

    Private Sub BtnKirim2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKirim2.Click
        jawaban2(TbTTS5.Text, TbTTS7.Text, TbTTS8.Text, TbTTS9.Text, TbTTS10.Text, TbTTS11.Text)
        TimerTTS02.Stop()
        TTS3()
        TimerTTS03.Start()
    End Sub

    Public Sub TTS3()
        TimerTTS03.Start()
        TbTTS1.Enabled = False
        TbTTS2.Enabled = False
        TbTTS3.Enabled = False
        TbTTS4.Enabled = False
        TbTTS5.Enabled = False
        TbTTS6.Enabled = False
        TbTTS7.Enabled = False
        TbTTS8.Enabled = False
        TbTTS9.Enabled = False
        TbTTS10.Enabled = False
        TbTTS11.Enabled = False
        TbTTS12.Focus()
        PBGambarTTS.Visible = False
        PBGambarTTS2.Visible = False
        PBGambarTTS3.Visible = True
        TbTTS12.Enabled = True
        TbTTS13.Enabled = True
        TbTTS14.Enabled = True
        TbTTS15.Enabled = True
        BtnKirim1.Visible = False
        BtnKirim2.Visible = False
        btnKirim3.Visible = True
    End Sub

    Public Sub jawaban3(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String, ByVal txt5 As String)
        If (txt1 = "t" Or txt1 = "T") And (txt2 = "u" Or txt1 = "U") And (txt3 = "t" Or txt1 = "T") And (txt4 = "u" Or txt1 = "U") And (txt5 = "s" Or txt1 = "S") Then
            score = score + 20
            LblScore.Text = score
            My.Computer.Audio.Play(My.Resources.AUDIOTEST, AudioPlayMode.WaitToComplete)
            TargetDT1 = DateTime.Now.Add(CountDownFrom1)
        Else
            score = score + 0
            LblScore.Text = score
            TargetDT1 = DateTime.Now.Add(CountDownFrom1)
        End If
    End Sub

    Private Sub TimerTTS3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTTS03.Tick
        Dim ts As TimeSpan = TargetDT1.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            LblWaktu1.Text = ts.ToString("mm\:ss")
        Else
            LblWaktu1.Text = "00:00"
            TimerTTS03.Stop()
            OtotmatisSelesai()
            TargetDT2 = DateTime.Now.Add(CountDownFrom2)
        End If
    End Sub
    
    Private Sub btnKirim3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKirim3.Click
        jawaban3(TbTTS12.Text, TbTTS13.Text, TbTTS14.Text, TbTTS15.Text, TbTTS8.Text)
        TbTTS12.Enabled = False
        TbTTS13.Enabled = False
        TbTTS14.Enabled = False
        TbTTS15.Enabled = False
        BtnKirim1.Visible = False
        BtnKirim2.Visible = False
        btnKirim3.Visible = False
        TimerTTS01.Stop()
        TimerTTS02.Stop()
        TimerTTS03.Stop()
        BtnSelesai.Visible = True
    End Sub

    Public Sub OtotmatisSelesai()
        BtnKirim1.Visible = False
        BtnKirim2.Visible = False
        btnKirim3.Visible = False
        TimerTTS01.Stop()
        TimerTTS02.Stop()
        TimerTTS03.Stop()
        LblWaktu1.Text = "00:00"
        BtnSelesai.Visible = True
    End Sub

    Private Sub BtnSelesai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelesai.Click
        BtnKirim1.Visible = False
        BtnKirim2.Visible = False
        btnKirim3.Visible = False
        TimerTTS01.Stop()
        TimerTTS02.Stop()
        TimerTTS03.Stop()
        LblWaktu1.Text = "00:00"
        BtnSelesai.Visible = True
        If LblScore.Text > 70 Then
            Me.Close()
            Berhasil.Show()
        Else
            Me.Close()
            Gagal.Show()
        End If
    End Sub
End Class