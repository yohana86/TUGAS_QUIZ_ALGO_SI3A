Public Class Form5
    Private Sub ButtonHitungBiaya_Click(sender As Object, e As EventArgs) Handles ButtonHitungBiaya.Click
        ' Mendapatkan input dari pengguna
        Dim noIdentitas As String = TextBoxNoIdentitas.Text
        Dim nama As String = TextBoxNama.Text
        Dim noHp As String = TextBoxNoHp.Text
        Dim jenisMobil As String = ComboBoxJenisMobil.SelectedItem.ToString()
        Dim tipeLayanan As String = ComboBoxTipeLayanan.SelectedItem.ToString()
        Dim lamaSewa As Integer

        ' Validasi input numerik
        If Not Integer.TryParse(TextBoxLamaSewa.Text, lamaSewa) Then
            MessageBox.Show("Masukkan lama sewa dalam format numerik.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Menghitung biaya sewa
        Dim hargaSewa As Integer
        Select Case jenisMobil
            Case "Toyota Avanza"
                hargaSewa = 240000
            Case "Toyota Calya"
                hargaSewa = 210000
            Case "Toyota Inova"
                hargaSewa = 340000
            Case "Daihatsu Xenia"
                hargaSewa = 230000
            Case "Daihatsu Sigra"
                hargaSewa = 200000
            Case "Honda Brio"
                hargaSewa = 230000
            Case "Honda Mobilio"
                hargaSewa = 240000
            Case "Mitsubishi Xpander"
                hargaSewa = 300000
        End Select

        ' Menambahkan biaya tambahan jika tipe layanan dengan sopir
        If tipeLayanan = "Dengan Sopir" Then
            hargaSewa += 150000
        End If

        ' Menghitung total biaya sewa
        Dim totalBiayaSewa As Integer = hargaSewa * lamaSewa

        ' Menampilkan data penyewaan mobil dan biaya sewa di ListView
        Dim item As New ListViewItem({noIdentitas, nama, noHp, jenisMobil, tipeLayanan, lamaSewa.ToString(), "Rp " & totalBiayaSewa.ToString("#,##0")})
        ListViewPenyewaan.Items.Add(item)
    End Sub

    Private Sub ListViewReservasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewPenyewaan.SelectedIndexChanged
        ' Inisialisasi ListView
        ListViewPenyewaan.View = View.Details
        ListViewPenyewaan.Columns.Add("No Identitas", 100)
        ListViewPenyewaan.Columns.Add("Nama", 150)
        ListViewPenyewaan.Columns.Add("No Hp", 100)
        ListViewPenyewaan.Columns.Add("Jenis Mobil", 120)
        ListViewPenyewaan.Columns.Add("Tipe Layanan", 120)
        ListViewPenyewaan.Columns.Add("Lama Sewa", 80)
        ListViewPenyewaan.Columns.Add("Biaya Sewa", 120)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class