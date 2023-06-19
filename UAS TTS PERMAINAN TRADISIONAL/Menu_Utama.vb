Public Class Menu_Utama

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Dim keluar As String
        keluar = MessageBox.Show("Apakah anda Ingin Keluar?" + Chr(13) + "Dev by Kamaludin", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If keluar = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnMulai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMulai.Click
        Masukan_Nama.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Mulai_Bermain.Show()
    End Sub
End Class
