Imports System.Data.Odbc
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbException

Public Class data_buku

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BukuBindingSource.Filter = "jenis = '" + Button1.Text + "' AND stock > 1"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BukuBindingSource.Filter = "jenis = '" + Button2.Text + "' AND stock > 0"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BukuBindingSource.Filter = "jenis = '" + Button3.Text + "' AND stock > 0"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        BukuBindingSource.Filter = "jenis = '" + Button4.Text + "' AND stock > 0"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        BukuBindingSource.Filter = "jenis = '" + Button6.Text + "' AND stock > 0"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        BukuBindingSource.Filter = "jenis = '" + Button8.Text + "' AND stock > 0"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        BukuBindingSource.Filter = "jenis = '" + Button5.Text + "' AND stock > 0"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        nav.Show()
    End Sub

    Private Sub qq_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles qq.TextChanged
        BukuBindingSource.Filter = "judul like '%" + qq.Text + "%' AND stock > 0"
    End Sub

    Private Sub data_buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BukuTableAdapter.Fill(Me.PerpusDataSet.buku)
        BukuBindingSource.Filter = "stock > 0"

    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        Dim value As Object = DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString()

        If IsDBNull(value) Then
            pinjam.Enabled = False
        Else
            Dim queJudul As String = "SELECT [judul] FROM [buku] WHERE [kode_buku] ='" + CType(value, String) + "'"
            Dim quePengarang As String = "SELECT [pengarang] FROM [buku] WHERE [kode_buku]='" + CType(value, String) + "'"
            Dim quePenerbit As String = "SELECT [penerbit] FROM [buku] WHERE [kode_buku]='" + CType(value, String) + "'"
            Dim queJenis As String = "SELECT [jenis] FROM [buku] WHERE [kode_buku]='" + CType(value, String) + "'"
            Dim queStock As String = "SELECT [stock] FROM [buku] WHERE [kode_buku]='" + CType(value, String) + "'"

            Dim konek As OleDbConnection
            'Dim str As String = "Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb"

            konek = New OleDbConnection("Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb")
            If (konek.State) <> ConnectionState.Closed Then konek.Close()

            konek.Open()
            Dim perintah0 As OleDbCommand = New OleDbCommand(queJudul, konek)
            Dim perintah1 As OleDbCommand = New OleDbCommand(quePengarang, konek)
            Dim perintah2 As OleDbCommand = New OleDbCommand(quePenerbit, konek)
            Dim perintah3 As OleDbCommand = New OleDbCommand(queJenis, konek)
            Dim perintah4 As OleDbCommand = New OleDbCommand(queStock, konek)

            zz.Text = perintah0.ExecuteScalar()
            xx.Text = perintah1.ExecuteScalar()
            cc.Text = perintah2.ExecuteScalar()
            vv.Text = perintah3.ExecuteScalar()
            bb.Text = perintah4.ExecuteScalar()

            If login.sesi = "anggota" Then
                pinjam.Enabled = True
                jum.ReadOnly = False
            Else
                pinjam.Enabled = False
                jum.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub pinjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pinjam.Click
        Dim kueri As OleDbCommand
        Dim konek As OleDbConnection
        Dim quePinjam As String = "UPDATE [buku] SET [stock]=[stock]-" + jum.Text + " WHERE [judul]='" + zz.Text + "'"
        Dim queKodeBuku As String = "SELECT [kode_buku] FROM buku WHERE [judul]='" + zz.Text + "'"

        'Dim str As String = "Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb"

        konek = New OleDbConnection("Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb")
        If (konek.State) <> ConnectionState.Closed Then konek.Close()

        If Val(bb.Text) >= Val(jum.Text) Then
            konek.Open()
            Dim kueri1 As OleDbCommand = New OleDbCommand(queKodeBuku, konek)
            Dim hsl1 As String = kueri1.ExecuteScalar()

            Dim queSave As String = "INSERT INTO [peminjaman] (username,kode_buku,pinjam,jumlah) VALUES ('" & login.user & "','" & hsl1 & "','" & Now.Date & "'," + jum.Text + " )"
            Dim kuerisave As OleDbCommand = New OleDbCommand(queSave, konek)
            kuerisave.ExecuteNonQuery()

            kueri = New OleDbCommand(quePinjam, konek)
            kueri.ExecuteNonQuery()

            MessageBox.Show("Anda meminjam buku berjudul" + Environment.NewLine + zz.Text + Environment.NewLine + "Sebanyak " + jum.Text + " buah.", "Pemberitahuan")

            BukuTableAdapter.Fill(Me.PerpusDataSet.buku)
            BukuBindingSource.Filter = "stock > 0"

        Else
            MessageBox.Show("Mohon maaf, stock buku dengan judul" + Environment.NewLine + zz.Text + Environment.NewLine + " tidak memenuhi kuota yang Anda inginkan.", "Pemberitahuan")
        End If
        
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim value As Object = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()

        If IsDBNull(value) Then
            pinjam2.Enabled = False
        Else
            pp.Text = CType(value, String)

            Dim quePengarang As String = "SELECT [pengarang] FROM [buku] WHERE [judul]='" + CType(value, String) + "'"
            Dim quePenerbit As String = "SELECT [penerbit] FROM [buku] WHERE [judul]='" + CType(value, String) + "'"
            Dim queJenis As String = "SELECT [jenis] FROM [buku] WHERE [judul]='" + CType(value, String) + "'"
            Dim queStock As String = "SELECT [stock] FROM [buku] WHERE [judul]='" + CType(value, String) + "'"

            Dim konek As OleDbConnection
            'Dim str As String = "Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb"

            konek = New OleDbConnection("Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb")
            If (konek.State) <> ConnectionState.Closed Then konek.Close()

            konek.Open()
            Dim perintah1 As OleDbCommand = New OleDbCommand(quePengarang, konek)
            Dim perintah2 As OleDbCommand = New OleDbCommand(quePenerbit, konek)
            Dim perintah3 As OleDbCommand = New OleDbCommand(queJenis, konek)
            Dim perintah4 As OleDbCommand = New OleDbCommand(queStock, konek)

            oo.Text = perintah1.ExecuteScalar()
            ii.Text = perintah2.ExecuteScalar()
            uu.Text = perintah3.ExecuteScalar()
            yy.Text = perintah4.ExecuteScalar()

            If login.sesi = "anggota" Then
                pinjam2.Enabled = True
                jum2.ReadOnly = False
            Else
                pinjam2.Enabled = False
                jum2.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub pinjam2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pinjam2.Click
        Dim kueri As OleDbCommand
        Dim konek As OleDbConnection
        Dim quePinjam As String = "UPDATE [buku] SET [stock]=[stock]-" + jum2.Text + " WHERE [judul]='" + pp.Text + "'"
        Dim queKodeBuku As String = "SELECT [kode_buku] FROM buku WHERE [judul]='" + pp.Text + "'"

        'Dim str As String = "Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb"

        konek = New OleDbConnection("Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb")
        If (konek.State) <> ConnectionState.Closed Then konek.Close()

        If Val(bb.Text) >= Val(jum.Text) Then
            konek.Open()
            Dim kueri1 As OleDbCommand = New OleDbCommand(queKodeBuku, konek)
            Dim hsl1 As String = kueri1.ExecuteScalar()

            Dim queSave As String = "INSERT INTO [peminjaman] (username,kode_buku,pinjam,jumlah) VALUES ('" & login.user & "','" & hsl1 & "','" & Now.Date & "'," + jum2.Text + " )"
            Dim kuerisave As OleDbCommand = New OleDbCommand(queSave, konek)
            kuerisave.ExecuteNonQuery()

            kueri = New OleDbCommand(quePinjam, konek)
            kueri.ExecuteNonQuery()

            MessageBox.Show("Anda meminjam buku berjudul" + Environment.NewLine + pp.Text + Environment.NewLine + "Sebanyak " + jum2.Text + " buah.", "Pemberitahuan")

            BukuTableAdapter.Fill(Me.PerpusDataSet.buku)
            BukuBindingSource.Filter = "stock > 0"

        Else
            MessageBox.Show("Mohon maaf, stock buku dengan judul" + Environment.NewLine + pp.Text + Environment.NewLine + " tidak memenuhi kuota yang Anda inginkan.", "Pemberitahuan")
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        BukuTableAdapter.Fill(Me.PerpusDataSet.buku)
        BukuBindingSource.Filter = "stock > 0"
    End Sub
End Class
