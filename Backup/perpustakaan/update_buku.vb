Imports System.Data.Odbc
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbException

Public Class update_buku

    Private Sub update_buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BukuTableAdapter.Fill(Me.PerpusDataSet.buku)
    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        Dim value As Object = DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString

        If IsDBNull(value) Then
            updatebuku.Enabled = False
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
            jenis.Text = perintah3.ExecuteScalar()
            bb.Text = perintah4.ExecuteScalar()
            kodebuku.Text = CType(value, String)

            updatebuku.Enabled = True
            del.Enabled = True
        End If
    End Sub

    Private Sub updatebuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updatebuku.Click
        Dim kueri As OleDbCommand
        Dim konek As OleDbConnection
        Dim stri As String = "UPDATE [buku] SET [judul]='" + zz.Text + "',[pengarang]='" + xx.Text + "',[penerbit]='" + cc.Text + "',[jenis]='" + jenis.Text + "',[stock]='" + bb.Text + "' WHERE [kode_buku]='" + kodebuku.Text + "'"
        'Dim str As String = "Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb"

        konek = New OleDbConnection("Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb")
        If (konek.State) <> ConnectionState.Closed Then konek.Close()

        konek.Open()

        kueri = New OleDbCommand(stri, konek)
        kueri.ExecuteNonQuery()

        MessageBox.Show("Data berhasil di-update!", "Peringatan")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        admin.Show()
    End Sub

    Private Sub del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles del.Click
        Dim result As Integer = MessageBox.Show("Anda yakin akan menghapus buku ini?", "Peringatan", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim kueri As OleDbCommand
            Dim konek As OleDbConnection
            Dim stri As String = "DELETE FROM [buku] WHERE [kode_buku]='" + kodebuku.Text + "'"
            'Dim str As String = "Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb"

            konek = New OleDbConnection("Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb")
            If (konek.State) <> ConnectionState.Closed Then konek.Close()

            konek.Open()

            kueri = New OleDbCommand(stri, konek)
            kueri.ExecuteNonQuery()

            MessageBox.Show("Data berhasil dihapus!", "Peringatan")
        End If
    End Sub
End Class