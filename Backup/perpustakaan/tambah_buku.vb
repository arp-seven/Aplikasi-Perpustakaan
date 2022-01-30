Imports System.Data.Odbc
Imports System.Data
Imports System.Data.OleDb

Public Class tambah_buku

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        admin.Show()
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim kueri As OleDbCommand
        Dim konek As OleDbConnection
        'Dim str As String = "Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb"

        konek = New OleDbConnection("Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb")
        If (konek.State) <> ConnectionState.Closed Then konek.Close()

        konek.Open()

        kueri = New OleDbCommand("INSERT INTO buku (kode_buku,judul,pengarang,penerbit,sinopsis,stock,jenis) VALUES('" & kode.Text & "', '" & judul.Text & "','" & pengarang.Text & "','" & penerbit.Text & "','" & sinopsis.Text & "','" & Val(stock.Text) & "','" & jenis.SelectedItem & "')", konek)
        kueri.ExecuteNonQuery()

        MessageBox.Show("Data sudah disimpan")

        kode.Text = ""
        judul.Text = ""
        pengarang.Text = ""
        penerbit.Text = ""
        sinopsis.Text = ""
        stock.Text = ""
        jenis.SelectedItem = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        see.Show()
    End Sub
End Class