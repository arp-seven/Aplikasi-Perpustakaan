<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambah_buku
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.jenis = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.stock = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.sinopsis = New System.Windows.Forms.TextBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.penerbit = New System.Windows.Forms.TextBox
        Me.pengarang = New System.Windows.Forms.TextBox
        Me.judul = New System.Windows.Forms.TextBox
        Me.kode = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.jenis)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.stock)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.sinopsis)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.penerbit)
        Me.GroupBox2.Controls.Add(Me.pengarang)
        Me.GroupBox2.Controls.Add(Me.judul)
        Me.GroupBox2.Controls.Add(Me.kode)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox2.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(577, 488)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tambah Buku"
        '
        'jenis
        '
        Me.jenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.jenis.FormattingEnabled = True
        Me.jenis.Items.AddRange(New Object() {"Buku Pelajaran", "Komik", "Novel", "Majalah", "Ensiklopedi", "Kamus", "Tutorial"})
        Me.jenis.Location = New System.Drawing.Point(157, 238)
        Me.jenis.Name = "jenis"
        Me.jenis.Size = New System.Drawing.Size(368, 29)
        Me.jenis.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Jenis"
        '
        'stock
        '
        Me.stock.Location = New System.Drawing.Point(157, 196)
        Me.stock.MaxLength = 5
        Me.stock.Name = "stock"
        Me.stock.Size = New System.Drawing.Size(372, 33)
        Me.stock.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 21)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Stock"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(411, 440)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 31)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Lihat Data Buku"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(10, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 31)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(49, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 21)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Sinopsis"
        '
        'sinopsis
        '
        Me.sinopsis.Location = New System.Drawing.Point(156, 276)
        Me.sinopsis.Multiline = True
        Me.sinopsis.Name = "sinopsis"
        Me.sinopsis.Size = New System.Drawing.Size(372, 109)
        Me.sinopsis.TabIndex = 10
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(201, 416)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(150, 55)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Tambah Buku"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'penerbit
        '
        Me.penerbit.Location = New System.Drawing.Point(156, 157)
        Me.penerbit.MaxLength = 50
        Me.penerbit.Name = "penerbit"
        Me.penerbit.Size = New System.Drawing.Size(372, 33)
        Me.penerbit.TabIndex = 7
        '
        'pengarang
        '
        Me.pengarang.Location = New System.Drawing.Point(156, 119)
        Me.pengarang.MaxLength = 50
        Me.pengarang.Name = "pengarang"
        Me.pengarang.Size = New System.Drawing.Size(372, 33)
        Me.pengarang.TabIndex = 6
        '
        'judul
        '
        Me.judul.Location = New System.Drawing.Point(156, 81)
        Me.judul.MaxLength = 100
        Me.judul.Name = "judul"
        Me.judul.Size = New System.Drawing.Size(372, 33)
        Me.judul.TabIndex = 5
        '
        'kode
        '
        Me.kode.Location = New System.Drawing.Point(156, 43)
        Me.kode.MaxLength = 4
        Me.kode.Name = "kode"
        Me.kode.Size = New System.Drawing.Size(101, 33)
        Me.kode.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(47, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 21)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Penerbit"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 21)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Pengarang"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(45, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 21)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Judul Buku"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(46, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 21)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Kode Buku"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MV Boli", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(103, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(386, 34)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "PERPUSTAKAAN AGIT TM"
        '
        'tambah_buku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(599, 566)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "tambah_buku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Buku"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents sinopsis As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents penerbit As System.Windows.Forms.TextBox
    Friend WithEvents pengarang As System.Windows.Forms.TextBox
    Friend WithEvents judul As System.Windows.Forms.TextBox
    Friend WithEvents kode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents stock As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents jenis As System.Windows.Forms.ComboBox
End Class
