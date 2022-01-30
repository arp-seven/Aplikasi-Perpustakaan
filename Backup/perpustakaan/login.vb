Imports System.Data.OleDb

Public Class login
    Public sesi As String
    Public user As String

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim kueri As OleDbCommand
        Dim konek As OleDbConnection
        Dim que As String = "SELECT [level] FROM [user] WHERE [username]='" + username.Text + "' AND [password]='" + password.Text + "'"
        'Dim str As String = "Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb"

        konek = New OleDbConnection("Provider=Microsoft.ace.OLEDB.12.0;Data Source=perpus.accdb")
        If (konek.State) <> ConnectionState.Closed Then konek.Close()

        konek.Open()

        kueri = New OleDbCommand(que, konek)
        Dim hsl As String = kueri.ExecuteScalar()

        If hsl = "admin" Then
            sesi = "admin"
            admin.Show()
            Me.Hide()
        ElseIf hsl = "anggota" Then
            user = username.Text
            sesi = "anggota"
            nav.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username / Password Salah")
            username.Text = ""
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Hide()
        nav.Show()
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        username.TextAlign = HorizontalAlignment.Center
        password.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            password.PasswordChar = ""
        Else
            password.PasswordChar = "*"
        End If
    End Sub
End Class
