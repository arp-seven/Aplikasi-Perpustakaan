<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class login
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.username = New System.Windows.Forms.TextBox
        Me.password = New System.Windows.Forms.TextBox
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("MV Boli", 14.0!)
        Me.UsernameLabel.Location = New System.Drawing.Point(101, 20)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(117, 28)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("MV Boli", 14.0!)
        Me.PasswordLabel.Location = New System.Drawing.Point(101, 103)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(99, 28)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("MV Boli", 12.0!)
        Me.username.Location = New System.Drawing.Point(24, 57)
        Me.username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(256, 33)
        Me.username.TabIndex = 1
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("MV Boli", 12.0!)
        Me.password.Location = New System.Drawing.Point(24, 140)
        Me.password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(256, 33)
        Me.password.TabIndex = 2
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("MV Boli", 10.0!)
        Me.OK.Location = New System.Drawing.Point(24, 219)
        Me.OK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(122, 35)
        Me.OK.TabIndex = 3
        Me.OK.Text = "Login"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("MV Boli", 10.0!)
        Me.Cancel.Location = New System.Drawing.Point(158, 219)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(122, 35)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "Kembali"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("MV Boli", 10.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(24, 177)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(159, 22)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Tampilkan Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(304, 277)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Font = New System.Drawing.Font("MV Boli", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
