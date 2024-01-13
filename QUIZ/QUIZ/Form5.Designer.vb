<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonHitungBiaya = New System.Windows.Forms.Button()
        Me.ListViewPenyewaan = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ComboBoxTipeLayanan = New System.Windows.Forms.ComboBox()
        Me.ComboBoxJenisMobil = New System.Windows.Forms.ComboBox()
        Me.TextBoxNoHp = New System.Windows.Forms.TextBox()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.TextBoxNoIdentitas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxLamaSewa = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(469, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 38)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonHitungBiaya
        '
        Me.ButtonHitungBiaya.Location = New System.Drawing.Point(310, 266)
        Me.ButtonHitungBiaya.Name = "ButtonHitungBiaya"
        Me.ButtonHitungBiaya.Size = New System.Drawing.Size(130, 38)
        Me.ButtonHitungBiaya.TabIndex = 51
        Me.ButtonHitungBiaya.Text = "Hitung Biaya"
        Me.ButtonHitungBiaya.UseVisualStyleBackColor = True
        '
        'ListViewPenyewaan
        '
        Me.ListViewPenyewaan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader4})
        Me.ListViewPenyewaan.HideSelection = False
        Me.ListViewPenyewaan.Location = New System.Drawing.Point(25, 327)
        Me.ListViewPenyewaan.Name = "ListViewPenyewaan"
        Me.ListViewPenyewaan.Size = New System.Drawing.Size(574, 200)
        Me.ListViewPenyewaan.TabIndex = 50
        Me.ListViewPenyewaan.UseCompatibleStateImageBehavior = False
        Me.ListViewPenyewaan.View = System.Windows.Forms.View.Details
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
        Me.ColumnHeader5.Text = "Jenis Mobil"
        Me.ColumnHeader5.Width = 110
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tipe Layanan"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Lama Sewa"
        Me.ColumnHeader7.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Biaya Sewa"
        Me.ColumnHeader4.Width = 100
        '
        'ComboBoxTipeLayanan
        '
        Me.ComboBoxTipeLayanan.FormattingEnabled = True
        Me.ComboBoxTipeLayanan.Items.AddRange(New Object() {"Lepas Kunci", "Dengan Sopir"})
        Me.ComboBoxTipeLayanan.Location = New System.Drawing.Point(159, 168)
        Me.ComboBoxTipeLayanan.Name = "ComboBoxTipeLayanan"
        Me.ComboBoxTipeLayanan.Size = New System.Drawing.Size(146, 21)
        Me.ComboBoxTipeLayanan.TabIndex = 49
        '
        'ComboBoxJenisMobil
        '
        Me.ComboBoxJenisMobil.FormattingEnabled = True
        Me.ComboBoxJenisMobil.Items.AddRange(New Object() {"Toyota Avanza", "Toyota Calya", "Toyota Inova", "Daihatsu Xenia", "Daihatsu Sigra", "Honda Brio", "Honda Mobilio", "Mitsubishi Xpander"})
        Me.ComboBoxJenisMobil.Location = New System.Drawing.Point(159, 133)
        Me.ComboBoxJenisMobil.Name = "ComboBoxJenisMobil"
        Me.ComboBoxJenisMobil.Size = New System.Drawing.Size(146, 21)
        Me.ComboBoxJenisMobil.TabIndex = 48
        '
        'TextBoxNoHp
        '
        Me.TextBoxNoHp.Location = New System.Drawing.Point(159, 97)
        Me.TextBoxNoHp.Name = "TextBoxNoHp"
        Me.TextBoxNoHp.Size = New System.Drawing.Size(146, 20)
        Me.TextBoxNoHp.TabIndex = 46
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(159, 61)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(440, 20)
        Me.TextBoxNama.TabIndex = 45
        '
        'TextBoxNoIdentitas
        '
        Me.TextBoxNoIdentitas.Location = New System.Drawing.Point(159, 25)
        Me.TextBoxNoIdentitas.Name = "TextBoxNoIdentitas"
        Me.TextBoxNoIdentitas.Size = New System.Drawing.Size(440, 20)
        Me.TextBoxNoIdentitas.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "No. Hp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Lama Sewa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Tipe Layanan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "No. Identitas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Jenis Mobil"
        '
        'TextBoxLamaSewa
        '
        Me.TextBoxLamaSewa.Location = New System.Drawing.Point(159, 203)
        Me.TextBoxLamaSewa.Name = "TextBoxLamaSewa"
        Me.TextBoxLamaSewa.Size = New System.Drawing.Size(146, 20)
        Me.TextBoxLamaSewa.TabIndex = 53
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 555)
        Me.Controls.Add(Me.TextBoxLamaSewa)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonHitungBiaya)
        Me.Controls.Add(Me.ListViewPenyewaan)
        Me.Controls.Add(Me.ComboBoxTipeLayanan)
        Me.Controls.Add(Me.ComboBoxJenisMobil)
        Me.Controls.Add(Me.TextBoxNoHp)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.TextBoxNoIdentitas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form5"
        Me.Text = "Program Rental Mobil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents ButtonHitungBiaya As Button
    Friend WithEvents ListViewPenyewaan As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ComboBoxTipeLayanan As ComboBox
    Friend WithEvents ComboBoxJenisMobil As ComboBox
    Friend WithEvents TextBoxNoHp As TextBox
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents TextBoxNoIdentitas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxLamaSewa As TextBox
End Class
