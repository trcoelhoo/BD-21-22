<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addpromotionpage
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
        Me.addpromo_namebox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.addpromo_descontobox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addpromo_startbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addpromo_finalbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(267, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD PROMOTION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(197, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'addpromo_namebox
        '
        Me.addpromo_namebox.Location = New System.Drawing.Point(273, 118)
        Me.addpromo_namebox.Name = "addpromo_namebox"
        Me.addpromo_namebox.Size = New System.Drawing.Size(249, 22)
        Me.addpromo_namebox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(166, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Discount:"
        '
        'addpromo_descontobox
        '
        Me.addpromo_descontobox.Location = New System.Drawing.Point(273, 161)
        Me.addpromo_descontobox.Name = "addpromo_descontobox"
        Me.addpromo_descontobox.Size = New System.Drawing.Size(249, 22)
        Me.addpromo_descontobox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(162, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Start Date:"
        '
        'addpromo_startbox
        '
        Me.addpromo_startbox.Location = New System.Drawing.Point(273, 230)
        Me.addpromo_startbox.Name = "addpromo_startbox"
        Me.addpromo_startbox.Size = New System.Drawing.Size(249, 22)
        Me.addpromo_startbox.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(161, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Final Date:"
        '
        'addpromo_finalbox
        '
        Me.addpromo_finalbox.Location = New System.Drawing.Point(273, 280)
        Me.addpromo_finalbox.Name = "addpromo_finalbox"
        Me.addpromo_finalbox.Size = New System.Drawing.Size(249, 22)
        Me.addpromo_finalbox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(273, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(249, 61)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'addpromotionpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.addpromo_finalbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.addpromo_startbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.addpromo_descontobox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.addpromo_namebox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addpromotionpage"
        Me.Text = "Add Promotion Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents addpromo_namebox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents addpromo_descontobox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents addpromo_startbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents addpromo_finalbox As TextBox
    Friend WithEvents Button1 As Button
End Class
