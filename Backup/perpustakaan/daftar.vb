Imports System.Data.Odbc
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbException

Public Class daftar

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        nav.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim kueri As OleDbCommand
        Dim konek As OleDbConnection
        'Dim str As String = "Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb"

        konek = New OleDbConnection("Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb")
        If (konek.State) <> ConnectionState.Closed Then konek.Close()

        konek.Open()

        kueri = New OleDbCommand("INSERT INTO [user] ([username],[password],[nama],[tl],[alamat],[level]) VALUES('" & u.Text & "', '" & p.Text & "','" & nl.Text & "'," & Val(tl.Value) & ",'" & a.Text & "', 'anggota')", konek)
        kueri.ExecuteNonQuery()
        MessageBox.Show("Data sudah disimpan")

        u.Text = ""
        p.Text = ""
        nl.Text = ""
        a.Text = ""
    End Sub


    Private Sub Button4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseDown
        p.PasswordChar = ""
    End Sub

    Private Sub Button4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseUp
        p.PasswordChar = "*"
    End Sub
End Class