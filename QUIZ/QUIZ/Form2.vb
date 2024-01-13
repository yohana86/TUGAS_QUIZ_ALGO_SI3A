Imports System.Net.Mime.MediaTypeNames

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input_bilangan As Integer

        If Integer.TryParse(TextBox1.Text, input_bilangan) Then
            If input_bilangan Mod 2 = 0 Then
                Label3.Text = input_bilangan.ToString() & " Adalah Bilangan Genap"
            Else
                Label3.Text = input_bilangan.ToString() & " Adalah Bilangan Ganjil"
            End If
        Else
            MsgBox("Masukkan bilangan yang valid")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


End Class