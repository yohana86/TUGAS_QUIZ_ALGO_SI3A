Public Class Form4
    Private Sub ButtonHitungBiaya_Click(sender As Object, e As EventArgs) Handles ButtonHitungBiaya.Click
        ' Mendapatkan input dari pengguna
        Dim noIdentitas As String = TextBoxNoIdentitas.Text
        Dim nama As String = TextBoxNama.Text
        Dim noHp As String = TextBoxNoHp.Text
        Dim jenisKamar As String = ComboBoxJenisKamar.SelectedItem.ToString()
        Dim tipeLayanan As String = ComboBoxTipeLayanan.SelectedItem.ToString()
        Dim lamaMenginap As Integer

        ' Validasi input numerik
        If Not Integer.TryParse(TextBoxLamaMenginap.Text, lamaMenginap) Then
            MessageBox.Show("Masukkan lama menginap dalam format numerik.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Menghitung biaya sewa
        Dim tarifKamar As Integer
        Select Case jenisKamar
            Case "Standard Room"
                tarifKamar = 200000
            Case "Superior Room"
                tarifKamar = 300000
            Case "Deluxe Room"
                tarifKamar = 350000
            Case "Suite Room"
                tarifKamar = 550000
                ' Menambahkan biaya tambahan jika tipe layanan dengan breakfast
                If tipeLayanan = "Dengan Breakfast" Then
                    tarifKamar += 20000
                End If
        End Select

        ' Menghitung total biaya sewa
        Dim totalBiayaSewa As Integer = tarifKamar * lamaMenginap

        ' Menampilkan data reservasi dan biaya sewa di ListView
        Dim item As New ListViewItem({noIdentitas, nama, noHp, jenisKamar, tipeLayanan, lamaMenginap.ToString(), "Rp " & totalBiayaSewa.ToString("#,##0")})
        ListViewReservasi.Items.Add(item)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewReservasi.SelectedIndexChanged
        ' Inisialisasi ListView
        ListViewReservasi.View = View.Details
        ListViewReservasi.Columns.Add("No Identitas", 100)
        ListViewReservasi.Columns.Add("Nama", 150)
        ListViewReservasi.Columns.Add("No Hp", 100)
        ListViewReservasi.Columns.Add("Jenis Kamar", 120)
        ListViewReservasi.Columns.Add("Tipe Layanan", 120)
        ListViewReservasi.Columns.Add("Lama Menginap", 80)
        ListViewReservasi.Columns.Add("Biaya Sewa", 120)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class