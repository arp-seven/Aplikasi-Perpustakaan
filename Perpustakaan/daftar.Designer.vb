<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daftar
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
        Me.u = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.p = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.nl = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.a = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.tl = New System.Windows.Forms.DateTimePicker
        Me.Button4 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'u
        '
        Me.u.Location = New System.Drawing.Point(159, 41)
        Me.u.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.u.Name = "u"
        Me.u.Size = New System.Drawing.Size(222, 31)
        Me.u.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 20)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Username      :"
        '
        'p
        '
        Me.p.Location = New System.Drawing.Point(159, 82)
        Me.p.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.p.Name = "p"
        Me.p.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.p.Size = New System.Drawing.Size(181, 31)
        Me.p.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Password      :"
        '
        'nl
        '
        Me.nl.Location = New System.Drawing.Point(159, 123)
        Me.nl.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.nl.Name = "nl"
        Me.nl.Size = New System.Drawing.Size(222, 31)
        Me.nl.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama Lengkap :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tanggal Lahir  :"
        '
        'a
        '
        Me.a.Location = New System.Drawing.Point(159, 205)
        Me.a.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(222, 31)
        Me.a.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Alamat        :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MV Boli", 13.0!)
        Me.Button1.Location = New System.Drawing.Point(149, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 53)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Daftar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(35, 286)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 30)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(289, 286)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 30)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Login"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tl
        '
        Me.tl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tl.Location = New System.Drawing.Point(160, 164)
        Me.tl.Name = "tl"
        Me.tl.Size = New System.Drawing.Size(220, 31)
        Me.tl.TabIndex = 16
        Me.tl.Value = New Date(1999, 1, 1, 9, 57, 0, 0)
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("MV Boli", 9.0!)
        Me.Button4.Location = New System.Drawing.Point(346, 82)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 31)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "See"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'daftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(420, 334)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.tl)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.p)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.u)
        Me.Controls.Add(Me.Label12)
        Me.Font = New System.Drawing.Font("MV Boli", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "daftar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pendaftaran"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents u As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents p As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nl As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents a As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents tl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
