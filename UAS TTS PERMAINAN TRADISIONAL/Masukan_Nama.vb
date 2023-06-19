Public Class Masukan_Nama

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim simpan As String
        simpan = MessageBox.Show("Hallo, Selamat Datang " + tbMasukanNama.Text, "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If simpan = vbYes Then
            Me.Close()
            Mulai_Bermain.Show()
        End If
    End Sub

    Private Sub btnKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKembali.Click
        Me.Close()
        Menu_Utama.Show()
    End Sub
End Class