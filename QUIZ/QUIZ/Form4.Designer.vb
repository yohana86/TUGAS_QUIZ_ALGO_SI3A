<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.TextBoxLamaMenginap = New System.Windows.Forms.TextBox()
        Me.TextBoxNoHp = New System.Windows.Forms.TextBox()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.TextBoxNoIdentitas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxJenisKamar = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTipeLayanan = New System.Windows.Forms.ComboBox()
        Me.ListViewReservasi = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonHitungBiaya = New System.Windows.Forms.Button()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'TextBoxLamaMenginap
        '
        Me.TextBoxLamaMenginap.Location = New System.Drawing.Point(162, 203)
        Me.TextBoxLamaMenginap.Name = "TextBoxLamaMenginap"
        Me.TextBoxLamaMenginap.Size = New System.Drawing.Size(146, 20)
        Me.TextBoxLamaMenginap.TabIndex = 32
        '
        'TextBoxNoHp
        '
        Me.TextBoxNoHp.Location = New System.Drawing.Point(162, 95)
        Me.TextBoxNoHp.Name = "TextBoxNoHp"
        Me.TextBoxNoHp.Size = New System.Drawing.Size(146, 20)
        Me.TextBoxNoHp.TabIndex = 29
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(162, 59)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(440, 20)
        Me.TextBoxNama.TabIndex = 28
        '
        'TextBoxNoIdentitas
        '
        Me.TextBoxNoIdentitas.Location = New System.Drawing.Point(162, 23)
        Me.TextBoxNoIdentitas.Name = "TextBoxNoIdentitas"
        Me.TextBoxNoIdentitas.Size = New System.Drawing.Size(440, 20)
        Me.TextBoxNoIdentitas.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "No. Hp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Lama Menginap"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Tipe Layanan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "No. Identitas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Jenis Kamar"
        '
        'ComboBoxJenisKamar
        '
        Me.ComboBoxJenisKamar.FormattingEnabled = True
        Me.ComboBoxJenisKamar.Items.AddRange(New Object() {"Standard Room", "Superior Room", "Deluxe Room", "Suite Room"})
        Me.ComboBoxJenisKamar.Location = New System.Drawing.Point(162, 131)
        Me.ComboBoxJenisKamar.Name = "ComboBoxJenisKamar"
        Me.ComboBoxJenisKamar.Size = New System.Drawing.Size(146, 21)
        Me.ComboBoxJenisKamar.TabIndex = 33
        '
        'ComboBoxTipeLayanan
        '
        Me.ComboBoxTipeLayanan.FormattingEnabled = True
        Me.ComboBoxTipeLayanan.Items.AddRange(New Object() {"Dengan Breakfast", "Tanpa Breakfast"})
        Me.ComboBoxTipeLayanan.Location = New System.Drawing.Point(162, 166)
        Me.ComboBoxTipeLayanan.Name = "ComboBoxTipeLayanan"
        Me.ComboBoxTipeLayanan.Size = New System.Drawing.Size(146, 21)
        Me.ComboBoxTipeLayanan.TabIndex = 34
        '
        'ListViewReservasi
        '
        Me.ListViewReservasi.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader4})
        Me.ListViewReservasi.HideSelection = False
        Me.ListViewReservasi.Location = New System.Drawing.Point(28, 325)
        Me.ListViewReservasi.Name = "ListViewReservasi"
        Me.ListViewReservasi.Size = New System.Drawing.Size(574, 200)
        Me.ListViewReservasi.TabIndex = 35
        Me.ListViewReservasi.UseCompatibleStateImageBehavior = False
        Me.ListViewReservasi.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No. Indentitas"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "No. Hp"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Jenis Kamar"
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tipe Layanan"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Lama Menginap"
        Me.ColumnHeader7.Width = 90
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(472, 264)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 38)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonHitungBiaya
        '
        Me.ButtonHitungBiaya.Location = New System.Drawing.Point(313, 264)
        Me.ButtonHitungBiaya.Name = "ButtonHitungBiaya"
        Me.ButtonHitungBiaya.Size = New System.Drawing.Size(130, 38)
        Me.ButtonHitungBiaya.TabIndex = 36
        Me.ButtonHitungBiaya.Text = "Hitung Biaya"
        Me.ButtonHitungBiaya.UseVisualStyleBackColor = True
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Biaya Sewa"
        Me.ColumnHeader4.Width = 100
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 559)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonHitungBiaya)
        Me.Controls.Add(Me.ListViewReservasi)
        Me.Controls.Add(Me.ComboBoxTipeLayanan)
        Me.Controls.Add(Me.ComboBoxJenisKamar)
        Me.Controls.Add(Me.TextBoxLamaMenginap)
        Me.Controls.Add(Me.TextBoxNoHp)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.TextBoxNoIdentitas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form4"
        Me.Text = "Program Reservasi Kamar Hotel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxLamaMenginap As TextBox
    Friend WithEvents TextBoxNoHp As TextBox
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents TextBoxNoIdentitas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxJenisKamar As ComboBox
    Friend WithEvents ComboBoxTipeLayanan As ComboBox
    Friend WithEvents ListViewReservasi As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Button2 As Button
    Friend WithEvents ButtonHitungBiaya As Button
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
