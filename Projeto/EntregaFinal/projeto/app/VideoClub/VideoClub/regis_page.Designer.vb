<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class regis_page
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.register_email_box = New System.Windows.Forms.TextBox()
        Me.sign_up_button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.register_nome_box = New System.Windows.Forms.TextBox()
        Me.contribuinte_box = New System.Windows.Forms.Label()
        Me.register_contribuinte_box = New System.Windows.Forms.TextBox()
        Me.pass_box = New System.Windows.Forms.Label()
        Me.register_pass_box = New System.Windows.Forms.TextBox()
        Me.register_data_box = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(323, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Register"
        '
        'register_email_box
        '
        Me.register_email_box.Location = New System.Drawing.Point(251, 109)
        Me.register_email_box.Name = "register_email_box"
        Me.register_email_box.Size = New System.Drawing.Size(263, 22)
        Me.register_email_box.TabIndex = 1
        '
        'sign_up_button
        '
        Me.sign_up_button.Location = New System.Drawing.Point(251, 375)
        Me.sign_up_button.Name = "sign_up_button"
        Me.sign_up_button.Size = New System.Drawing.Size(263, 45)
        Me.sign_up_button.TabIndex = 2
        Me.sign_up_button.Text = "Sign Up"
        Me.sign_up_button.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(248, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nome:"
        '
        'register_nome_box
        '
        Me.register_nome_box.Location = New System.Drawing.Point(251, 163)
        Me.register_nome_box.Name = "register_nome_box"
        Me.register_nome_box.Size = New System.Drawing.Size(263, 22)
        Me.register_nome_box.TabIndex = 5
        '
        'contribuinte_box
        '
        Me.contribuinte_box.AutoSize = True
        Me.contribuinte_box.Location = New System.Drawing.Point(248, 197)
        Me.contribuinte_box.Name = "contribuinte_box"
        Me.contribuinte_box.Size = New System.Drawing.Size(96, 17)
        Me.contribuinte_box.TabIndex = 6
        Me.contribuinte_box.Text = "Contribuiente:"
        '
        'register_contribuinte_box
        '
        Me.register_contribuinte_box.Location = New System.Drawing.Point(251, 217)
        Me.register_contribuinte_box.Name = "register_contribuinte_box"
        Me.register_contribuinte_box.Size = New System.Drawing.Size(263, 22)
        Me.register_contribuinte_box.TabIndex = 7
        '
        'pass_box
        '
        Me.pass_box.AutoSize = True
        Me.pass_box.Location = New System.Drawing.Point(248, 251)
        Me.pass_box.Name = "pass_box"
        Me.pass_box.Size = New System.Drawing.Size(73, 17)
        Me.pass_box.TabIndex = 8
        Me.pass_box.Text = "Password:"
        '
        'register_pass_box
        '
        Me.register_pass_box.Location = New System.Drawing.Point(251, 271)
        Me.register_pass_box.Name = "register_pass_box"
        Me.register_pass_box.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.register_pass_box.Size = New System.Drawing.Size(263, 22)
        Me.register_pass_box.TabIndex = 9
        '
        'register_data_box
        '
        Me.register_data_box.Location = New System.Drawing.Point(251, 327)
        Me.register_data_box.Name = "register_data_box"
        Me.register_data_box.Size = New System.Drawing.Size(263, 22)
        Me.register_data_box.TabIndex = 10
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(251, 304)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(140, 17)
        Me.label4.TabIndex = 11
        Me.label4.Text = "Data de Nascimento:"
        '
        'regis_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 450)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.register_data_box)
        Me.Controls.Add(Me.register_pass_box)
        Me.Controls.Add(Me.pass_box)
        Me.Controls.Add(Me.register_contribuinte_box)
        Me.Controls.Add(Me.contribuinte_box)
        Me.Controls.Add(Me.register_nome_box)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sign_up_button)
        Me.Controls.Add(Me.register_email_box)
        Me.Controls.Add(Me.Label1)
        Me.Name = "regis_page"
        Me.Text = "Register Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents register_email_box As TextBox
    Friend WithEvents sign_up_button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents register_nome_box As TextBox
    Friend WithEvents contribuinte_box As Label
    Friend WithEvents register_contribuinte_box As TextBox
    Friend WithEvents pass_box As Label
    Friend WithEvents register_pass_box As TextBox
    Friend WithEvents register_data_box As TextBox
    Friend WithEvents label4 As Label
End Class
