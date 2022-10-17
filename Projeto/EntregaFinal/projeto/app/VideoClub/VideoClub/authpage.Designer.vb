<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class auth_page
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.regis_button = New System.Windows.Forms.Button()
        Me.auth_username = New System.Windows.Forms.TextBox()
        Me.auth_password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.auth_log_button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'regis_button
        '
        Me.regis_button.Location = New System.Drawing.Point(238, 308)
        Me.regis_button.Name = "regis_button"
        Me.regis_button.Size = New System.Drawing.Size(78, 42)
        Me.regis_button.TabIndex = 0
        Me.regis_button.Text = "Register"
        Me.regis_button.UseVisualStyleBackColor = True
        '
        'auth_username
        '
        Me.auth_username.Location = New System.Drawing.Point(238, 141)
        Me.auth_username.Name = "auth_username"
        Me.auth_username.Size = New System.Drawing.Size(317, 22)
        Me.auth_username.TabIndex = 1
        '
        'auth_password
        '
        Me.auth_password.Location = New System.Drawing.Point(238, 241)
        Me.auth_password.Name = "auth_password"
        Me.auth_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.auth_password.Size = New System.Drawing.Size(317, 22)
        Me.auth_password.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(235, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password:"
        '
        'auth_log_button
        '
        Me.auth_log_button.Location = New System.Drawing.Point(477, 308)
        Me.auth_log_button.Name = "auth_log_button"
        Me.auth_log_button.Size = New System.Drawing.Size(78, 42)
        Me.auth_log_button.TabIndex = 5
        Me.auth_log_button.Text = "Login"
        Me.auth_log_button.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(298, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Authentication"
        '
        'auth_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 470)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.auth_log_button)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.auth_password)
        Me.Controls.Add(Me.auth_username)
        Me.Controls.Add(Me.regis_button)
        Me.Name = "auth_page"
        Me.Text = "Authentication Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents regis_button As Button
    Friend WithEvents auth_password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents auth_log_button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents auth_username As TextBox
End Class
