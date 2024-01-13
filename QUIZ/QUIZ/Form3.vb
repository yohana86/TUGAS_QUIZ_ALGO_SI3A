Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Mendapatkan input dari pengguna
        Dim nim As String = TextBoxNIM.Text
        Dim nama As String = TextBoxNama.Text
        Dim kelas As String = TextBoxKelas.Text

        Dim nilaiUTS, nilaiUAS, nilaiTugas As Double

        ' Validasi input numerik
        If Not Double.TryParse(TextBoxUTS.Text, nilaiUTS) Or
           Not Double.TryParse(TextBoxUAS.Text, nilaiUAS) Or
           Not Double.TryParse(TextBoxTugas.Text, nilaiTugas) Then
            MessageBox.Show("Masukkan nilai UTS, UAS, dan Tugas dalam format numerik.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Menghitung nilai akhir
        Dim nilaiAkhir As Double = (nilaiUTS * 0.3) + (nilaiUAS * 0.5) + (nilaiTugas * 0.2)

        ' Menentukan status kelulusan
        Dim status As String
        If nilaiAkhir >= 60 Then
            status = "Lulus"
        Else
            status = "Tidak Lulus"
        End If

        ' Menambahkan data ke ListView
        Dim item As New ListViewItem({nim, nama, kelas, nilaiUTS.ToString(), nilaiUAS.ToString(), nilaiTugas.ToString(), nilaiAkhir.ToString(), status})
        ListView1.Items.Add(item)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        ' Inisialisasi ListView
        ListView1.View = View.Details
        ListView1.Columns.Add("NIM", 100)
        ListView1.Columns.Add("Nama", 150)
        ListView1.Columns.Add("Kelas", 80)
        ListView1.Columns.Add("Nilai UTS", 80)
        ListView1.Columns.Add("Nilai UAS", 80)
        ListView1.Columns.Add("Nilai Tugas", 80)
        ListView1.Columns.Add("Nilai Akhir", 80)
        ListView1.Columns.Add("Status", 80)
        ListView1.FullRowSelect = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class