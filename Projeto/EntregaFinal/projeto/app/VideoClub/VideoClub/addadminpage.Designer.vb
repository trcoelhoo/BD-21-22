<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addadminpage
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.addadmin_emailbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.addadmin_namebox = New System.Windows.Forms.TextBox()
        Me.addadmin_passbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addadmin_addbutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(307, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD ADMIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(241, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email:"
        '
        'addadmin_emailbox
        '
        Me.addadmin_emailbox.Location = New System.Drawing.Point(313, 91)
        Me.addadmin_emailbox.Name = "addadmin_emailbox"
        Me.addadmin_emailbox.Size = New System.Drawing.Size(165, 22)
        Me.addadmin_emailbox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(237, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name:"
        '
        'addadmin_namebox
        '
        Me.addadmin_namebox.Location = New System.Drawing.Point(313, 155)
        Me.addadmin_namebox.Name = "addadmin_namebox"
        Me.addadmin_namebox.Size = New System.Drawing.Size(165, 22)
        Me.addadmin_namebox.TabIndex = 4
        '
        'addadmin_passbox
        '
        Me.addadmin_passbox.Location = New System.Drawing.Point(313, 223)
        Me.addadmin_passbox.Name = "addadmin_passbox"
        Me.addadmin_passbox.Size = New System.Drawing.Size(164, 22)
        Me.addadmin_passbox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(203, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password:"
        '
        'addadmin_addbutton
        '
        Me.addadmin_addbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addadmin_addbutton.Location = New System.Drawing.Point(313, 295)
        Me.addadmin_addbutton.Name = "addadmin_addbutton"
        Me.addadmin_addbutton.Size = New System.Drawing.Size(165, 51)
        Me.addadmin_addbutton.TabIndex = 7
        Me.addadmin_addbutton.Text = "ADD"
        Me.addadmin_addbutton.UseVisualStyleBackColor = True
        '
        'addadminpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.addadmin_addbutton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.addadmin_passbox)
        Me.Controls.Add(Me.addadmin_namebox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.addadmin_emailbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addadminpage"
        Me.Text = "Add Admin Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents addadmin_emailbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents addadmin_namebox As TextBox
    Friend WithEvents addadmin_passbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents addadmin_addbutton As Button
End Class
