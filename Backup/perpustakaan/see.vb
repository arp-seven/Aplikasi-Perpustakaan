Public Class see

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PerpusDataSet1.buku' table. You can move, or remove it, as needed.
        Me.BukuTableAdapter1.Fill(Me.PerpusDataSet1.buku)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BukuTableAdapter1.Fill(Me.PerpusDataSet1.buku)
    End Sub
End Class