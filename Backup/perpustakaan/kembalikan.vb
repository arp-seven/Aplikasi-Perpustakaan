Imports System.Data.OleDb

Public Class kembalikan

    Private Sub kembalikan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Refresh()

        'TODO: This line of code loads data into the 'PerpusDataSet2.peminjaman' table. You can move, or remove it, as needed.
        Me.PeminjamanTableAdapter.Fill(Me.PerpusDataSet2.peminjaman)
        PeminjamanBindingSource.Filter = "[username] = '" + login.user + "' AND [kembali] Is Null"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        nav.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim konek As OleDbConnection
        Dim stri As String = "UPDATE [peminjaman] SET kembali='" + Now.Date + "' WHERE username='" + login.user + "' AND kode_buku='" + kode.Text + "'"
        Dim stri2 As String = "UPDATE [buku] SET stock=stock+" & jml.Text & " WHERE [kode_buku]='" + kode.Text + "'"

        'Dim str As String = "Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb"

        konek = New OleDbConnection("Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb")
        If (konek.State) <> ConnectionState.Closed Then konek.Close()

        konek.Open()

        Dim kueri As OleDbCommand = New OleDbCommand(stri, konek)
        kueri.ExecuteNonQuery()
        Dim kueri2 As OleDbCommand = New OleDbCommand(stri2, konek)
        kueri2.ExecuteNonQuery()

        MessageBox.Show("Buku telah dikembalikan. Terima kasih!", "Peringatan")
    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        Dim value As Object = DataGridView2.Rows(e.RowIndex).Cells(2).Value.ToString

        If IsDBNull(value) Then

        Else
            kode.Text = CType(value, String)
        End If
    End Sub
End Class