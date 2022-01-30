<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update_buku
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
        Me.BukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PerpusDataSet = New perpustakaan.perpusDataSet
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.KodebukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JudulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PengarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PenerbitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SinopsisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JenisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BukuTableAdapter = New perpustakaan.perpusDataSetTableAdapters.bukuTableAdapter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.bb = New System.Windows.Forms.TextBox
        Me.cc = New System.Windows.Forms.TextBox
        Me.xx = New System.Windows.Forms.TextBox
        Me.zz = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.updatebuku = New System.Windows.Forms.Button
        Me.kodebuku = New System.Windows.Forms.TextBox
        Me.jenis = New System.Windows.Forms.ComboBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.del = New System.Windows.Forms.Button
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerpusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BukuBindingSource
        '
        Me.BukuBindingSource.DataMember = "buku"
        Me.BukuBindingSource.DataSource = Me.PerpusDataSet
        '
        'PerpusDataSet
        '
        Me.PerpusDataSet.DataSetName = "perpusDataSet"
        Me.PerpusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodebukuDataGridViewTextBoxColumn, Me.JudulDataGridViewTextBoxColumn, Me.PengarangDataGridViewTextBoxColumn, Me.PenerbitDataGridViewTextBoxColumn, Me.SinopsisDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.JenisDataGridViewTextBoxColumn})
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DataGridView2.DataSource = Me.BukuBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(13, 61)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(758, 195)
        Me.DataGridView2.TabIndex = 19
        '
        'KodebukuDataGridViewTextBoxColumn
        '
        Me.KodebukuDataGridViewTextBoxColumn.DataPropertyName = "kode_buku"
        Me.KodebukuDataGridViewTextBoxColumn.HeaderText = "kode_buku"
        Me.KodebukuDataGridViewTextBoxColumn.Name = "KodebukuDataGridViewTextBoxColumn"
        Me.KodebukuDataGridViewTextBoxColumn.ReadOnly = True
        Me.KodebukuDataGridViewTextBoxColumn.Width = 90
        '
        'JudulDataGridViewTextBoxColumn
        '
        Me.JudulDataGridViewTextBoxColumn.DataPropertyName = "judul"
        Me.JudulDataGridViewTextBoxColumn.HeaderText = "judul"
        Me.JudulDataGridViewTextBoxColumn.Name = "JudulDataGridViewTextBoxColumn"
        Me.JudulDataGridViewTextBoxColumn.ReadOnly = True
        Me.JudulDataGridViewTextBoxColumn.Width = 210
        '
        'PengarangDataGridViewTextBoxColumn
        '
        Me.PengarangDataGridViewTextBoxColumn.DataPropertyName = "pengarang"
        Me.PengarangDataGridViewTextBoxColumn.HeaderText = "pengarang"
        Me.PengarangDataGridViewTextBoxColumn.Name = "PengarangDataGridViewTextBoxColumn"
        Me.PengarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.PengarangDataGridViewTextBoxColumn.Width = 120
        '
        'PenerbitDataGridViewTextBoxColumn
        '
        Me.PenerbitDataGridViewTextBoxColumn.DataPropertyName = "penerbit"
        Me.PenerbitDataGridViewTextBoxColumn.HeaderText = "penerbit"
        Me.PenerbitDataGridViewTextBoxColumn.Name = "PenerbitDataGridViewTextBoxColumn"
        Me.PenerbitDataGridViewTextBoxColumn.ReadOnly = True
        Me.PenerbitDataGridViewTextBoxColumn.Width = 120
        '
        'SinopsisDataGridViewTextBoxColumn
        '
        Me.SinopsisDataGridViewTextBoxColumn.DataPropertyName = "sinopsis"
        Me.SinopsisDataGridViewTextBoxColumn.HeaderText = "sinopsis"
        Me.SinopsisDataGridViewTextBoxColumn.Name = "SinopsisDataGridViewTextBoxColumn"
        Me.SinopsisDataGridViewTextBoxColumn.ReadOnly = True
        Me.SinopsisDataGridViewTextBoxColumn.Width = 190
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockDataGridViewTextBoxColumn.Visible = False
        '
        'JenisDataGridViewTextBoxColumn
        '
        Me.JenisDataGridViewTextBoxColumn.DataPropertyName = "jenis"
        Me.JenisDataGridViewTextBoxColumn.HeaderText = "jenis"
        Me.JenisDataGridViewTextBoxColumn.Name = "JenisDataGridViewTextBoxColumn"
        Me.JenisDataGridViewTextBoxColumn.ReadOnly = True
        Me.JenisDataGridViewTextBoxColumn.Visible = False
        '
        'BukuTableAdapter
        '
        Me.BukuTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 49)
        Me.Panel1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(192, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ubah / Hapus Data Buku"
        '
        'bb
        '
        Me.bb.Location = New System.Drawing.Point(516, 327)
        Me.bb.Name = "bb"
        Me.bb.Size = New System.Drawing.Size(255, 29)
        Me.bb.TabIndex = 42
        '
        'cc
        '
        Me.cc.Location = New System.Drawing.Point(125, 368)
        Me.cc.Name = "cc"
        Me.cc.Size = New System.Drawing.Size(255, 29)
        Me.cc.TabIndex = 40
        '
        'xx
        '
        Me.xx.Location = New System.Drawing.Point(125, 333)
        Me.xx.Name = "xx"
        Me.xx.Size = New System.Drawing.Size(255, 29)
        Me.xx.TabIndex = 39
        '
        'zz
        '
        Me.zz.Location = New System.Drawing.Point(125, 298)
        Me.zz.Name = "zz"
        Me.zz.Size = New System.Drawing.Size(255, 29)
        Me.zz.TabIndex = 38
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(425, 330)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 20)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Stock    :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 370)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 20)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Penerbit    :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 336)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 20)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Pengarang   :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(430, 295)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 20)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Jenis    :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MV Boli", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 20)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Judul Buku  :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 21)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Buku yang dipilih :"
        '
        'updatebuku
        '
        Me.updatebuku.Enabled = False
        Me.updatebuku.Location = New System.Drawing.Point(660, 368)
        Me.updatebuku.Name = "updatebuku"
        Me.updatebuku.Size = New System.Drawing.Size(111, 46)
        Me.updatebuku.TabIndex = 1
        Me.updatebuku.Text = "Update"
        Me.updatebuku.UseVisualStyleBackColor = True
        '
        'kodebuku
        '
        Me.kodebuku.Location = New System.Drawing.Point(671, 260)
        Me.kodebuku.Name = "kodebuku"
        Me.kodebuku.ReadOnly = True
        Me.kodebuku.Size = New System.Drawing.Size(100, 29)
        Me.kodebuku.TabIndex = 44
        Me.kodebuku.Visible = False
        '
        'jenis
        '
        Me.jenis.FormattingEnabled = True
        Me.jenis.Items.AddRange(New Object() {"Buku Pelajaran", "Komik", "Novel", "Majalah", "Ensiklopedi", "Kamus", "Tutorial"})
        Me.jenis.Location = New System.Drawing.Point(516, 295)
        Me.jenis.Name = "jenis"
        Me.jenis.Size = New System.Drawing.Size(255, 25)
        Me.jenis.TabIndex = 45
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(427, 381)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 33)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "<< Kembali"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'del
        '
        Me.del.Enabled = False
        Me.del.Location = New System.Drawing.Point(542, 368)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(111, 46)
        Me.del.TabIndex = 2
        Me.del.Text = "Hapus"
        Me.del.UseVisualStyleBackColor = True
        '
        'update_buku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(784, 429)
        Me.Controls.Add(Me.del)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.jenis)
        Me.Controls.Add(Me.kodebuku)
        Me.Controls.Add(Me.updatebuku)
        Me.Controls.Add(Me.bb)
        Me.Controls.Add(Me.cc)
        Me.Controls.Add(Me.xx)
        Me.Controls.Add(Me.zz)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Font = New System.Drawing.Font("MV Boli", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "update_buku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel Admin"
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerpusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BukuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PerpusDataSet As perpustakaan.perpusDataSet
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents BukuTableAdapter As perpustakaan.perpusDataSetTableAdapters.bukuTableAdapter
    Friend WithEvents KodebukuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JudulDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PengarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PenerbitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SinopsisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bb As System.Windows.Forms.TextBox
    Friend WithEvents cc As System.Windows.Forms.TextBox
    Friend WithEvents xx As System.Windows.Forms.TextBox
    Friend WithEvents zz As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents updatebuku As System.Windows.Forms.Button
    Friend WithEvents kodebuku As System.Windows.Forms.TextBox
    Friend WithEvents jenis As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents del As System.Windows.Forms.Button
End Class
