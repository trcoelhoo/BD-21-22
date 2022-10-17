<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editcontent
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
        Me.editcont_list = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.editcont_idbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.editcont_titulobox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.editcont_categoriabox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.editcont_precobox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.editcont_anobox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.editcont_idadebox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.editcont_duracaobox = New System.Windows.Forms.TextBox()
        Me.editcont_editbutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edit Content: "
        '
        'editcont_list
        '
        Me.editcont_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editcont_list.FormattingEnabled = True
        Me.editcont_list.ItemHeight = 25
        Me.editcont_list.Location = New System.Drawing.Point(40, 64)
        Me.editcont_list.Name = "editcont_list"
        Me.editcont_list.Size = New System.Drawing.Size(222, 354)
        Me.editcont_list.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(475, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID:"
        '
        'editcont_idbox
        '
        Me.editcont_idbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editcont_idbox.Location = New System.Drawing.Point(519, 64)
        Me.editcont_idbox.Name = "editcont_idbox"
        Me.editcont_idbox.Size = New System.Drawing.Size(146, 27)
        Me.editcont_idbox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(446, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Titulo:"
        '
        'editcont_titulobox
        '
        Me.editcont_titulobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editcont_titulobox.Location = New System.Drawing.Point(519, 105)
        Me.editcont_titulobox.Name = "editcont_titulobox"
        Me.editcont_titulobox.Size = New System.Drawing.Size(146, 27)
        Me.editcont_titulobox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(410, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Categoria:"
        '
        'editcont_categoriabox
        '
        Me.editcont_categoriabox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editcont_categoriabox.Location = New System.Drawing.Point(519, 147)
        Me.editcont_categoriabox.Name = "editcont_categoriabox"
        Me.editcont_categoriabox.Size = New System.Drawing.Size(146, 27)
        Me.editcont_categoriabox.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(444, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Preço:"
        '
        'editcont_precobox
        '
        Me.editcont_precobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editcont_precobox.Location = New System.Drawing.Point(519, 192)
        Me.editcont_precobox.Name = "editcont_precobox"
        Me.editcont_precobox.Size = New System.Drawing.Size(146, 27)
        Me.editcont_precobox.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(458, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Ano:"
        '
        'editcont_anobox
        '
        Me.editcont_anobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editcont_anobox.Location = New System.Drawing.Point(519, 236)
        Me.editcont_anobox.Name = "editcont_anobox"
        Me.editcont_anobox.Size = New System.Drawing.Size(146, 27)
        Me.editcont_anobox.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(445, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Idade:"
        '
        'editcont_idadebox
        '
        Me.editcont_idadebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editcont_idadebox.Location = New System.Drawing.Point(519, 283)
        Me.editcont_idadebox.Name = "editcont_idadebox"
        Me.editcont_idadebox.Size = New System.Drawing.Size(146, 27)
        Me.editcont_idadebox.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(420, 325)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Duração:"
        '
        'editcont_duracaobox
        '
        Me.editcont_duracaobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editcont_duracaobox.Location = New System.Drawing.Point(519, 326)
        Me.editcont_duracaobox.Name = "editcont_duracaobox"
        Me.editcont_duracaobox.Size = New System.Drawing.Size(146, 27)
        Me.editcont_duracaobox.TabIndex = 15
        '
        'editcont_editbutton
        '
        Me.editcont_editbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editcont_editbutton.Location = New System.Drawing.Point(429, 384)
        Me.editcont_editbutton.Name = "editcont_editbutton"
        Me.editcont_editbutton.Size = New System.Drawing.Size(236, 54)
        Me.editcont_editbutton.TabIndex = 16
        Me.editcont_editbutton.Text = "Edit"
        Me.editcont_editbutton.UseVisualStyleBackColor = True
        '
        'editcontent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.editcont_editbutton)
        Me.Controls.Add(Me.editcont_duracaobox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.editcont_idadebox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.editcont_anobox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.editcont_precobox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.editcont_categoriabox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.editcont_titulobox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.editcont_idbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.editcont_list)
        Me.Controls.Add(Me.Label1)
        Me.Name = "editcontent"
        Me.Text = "Edit Content"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents editcont_list As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents editcont_idbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents editcont_titulobox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents editcont_categoriabox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents editcont_precobox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents editcont_anobox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents editcont_idadebox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents editcont_duracaobox As TextBox
    Friend WithEvents editcont_editbutton As Button
End Class
