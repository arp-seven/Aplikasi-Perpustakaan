<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kembalikan
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
        Me.components = New System.ComponentModel.Container
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.judul = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.kode_buku = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PinjamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PeminjamanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PerpusDataSet2 = New perpustakaan.perpusDataSet2
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.PeminjamanTableAdapter = New perpustakaan.perpusDataSet2TableAdapters.peminjamanTableAdapter
        Me.kode = New System.Windows.Forms.TextBox
        Me.jml = New System.Windows.Forms.TextBox
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeminjamanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpusDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.judul, Me.username, Me.kode_buku, Me.JumlahDataGridViewTextBoxColumn, Me.PinjamDataGridViewTextBoxColumn})
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DataGridView2.DataSource = Me.PeminjamanBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(15, 71)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(437, 247)
        Me.DataGridView2.TabIndex = 19
        '
        'judul
        '
        Me.judul.DataPropertyName = "judul"
        Me.judul.HeaderText = "judul"
        Me.judul.Name = "judul"
        Me.judul.ReadOnly = True
        Me.judul.Width = 250
        '
        'username
        '
        Me.username.DataPropertyName = "username"
        Me.username.HeaderText = "username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        Me.username.Visible = False
        '
        'kode_buku
        '
        Me.kode_buku.DataPropertyName = "kode_buku"
        Me.kode_buku.HeaderText = "kode_buku"
        Me.kode_buku.Name = "kode_buku"
        Me.kode_buku.ReadOnly = True
        Me.kode_buku.Visible = False
        '
        'JumlahDataGridViewTextBoxColumn
        '
        Me.JumlahDataGridViewTextBoxColumn.DataPropertyName = "jumlah"
        Me.JumlahDataGridViewTextBoxColumn.HeaderText = "jumlah"
        Me.JumlahDataGridViewTextBoxColumn.Name = "JumlahDataGridViewTextBoxColumn"
        Me.JumlahDataGridViewTextBoxColumn.ReadOnly = True
        Me.JumlahDataGridViewTextBoxColumn.Width = 60
        '
        'PinjamDataGridViewTextBoxColumn
        '
        Me.PinjamDataGridViewTextBoxColumn.DataPropertyName = "pinjam"
        Me.PinjamDataGridViewTextBoxColumn.HeaderText = "pinjam"
        Me.PinjamDataGridViewTextBoxColumn.Name = "PinjamDataGridViewTextBoxColumn"
        Me.PinjamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeminjamanBindingSource
        '
        Me.PeminjamanBindingSource.DataMember = "peminjaman"
        Me.PeminjamanBindingSource.DataSource = Me.PerpusDataSet2
        '
        'PerpusDataSet2
        '
        Me.PerpusDataSet2.DataSetName = "perpusDataSet2"
        Me.PerpusDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(79, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 34)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Buku yang dipinjam :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(327, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Kembalikan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(15, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 29)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PeminjamanTableAdapter
        '
        Me.PeminjamanTableAdapter.ClearBeforeFill = True
        '
        'kode
        '
        Me.kode.Location = New System.Drawing.Point(221, 362)
        Me.kode.Name = "kode"
        Me.kode.Size = New System.Drawing.Size(100, 20)
        Me.kode.TabIndex = 22
        Me.kode.Visible = False
        '
        'jml
        '
        Me.jml.Location = New System.Drawing.Point(221, 336)
        Me.jml.Name = "jml"
        Me.jml.Size = New System.Drawing.Size(100, 20)
        Me.jml.TabIndex = 23
        Me.jml.Visible = False
        '
        'kembalikan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(468, 407)
        Me.Controls.Add(Me.jml)
        Me.Controls.Add(Me.kode)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "kembalikan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengembalian Buku"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeminjamanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpusDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents PerpusDataSet2 As perpustakaan.perpusDataSet2
    Friend WithEvents PeminjamanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeminjamanTableAdapter As perpustakaan.perpusDataSet2TableAdapters.peminjamanTableAdapter
    Friend WithEvents IdpeminjamanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodebukuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KembaliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents judul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kode_buku As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PinjamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kode As System.Windows.Forms.TextBox
    Friend WithEvents jml As System.Windows.Forms.TextBox
End Class
