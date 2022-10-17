<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rent_cont_page
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
        Me.content_name_label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rent_usepointsbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totalprice_label = New System.Windows.Forms.Label()
        Me.rent_button = New System.Windows.Forms.Button()
        Me.payment_box = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rent Content"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(211, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Content:"
        '
        'content_name_label
        '
        Me.content_name_label.AutoSize = True
        Me.content_name_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.content_name_label.Location = New System.Drawing.Point(319, 115)
        Me.content_name_label.Name = "content_name_label"
        Me.content_name_label.Size = New System.Drawing.Size(178, 29)
        Me.content_name_label.TabIndex = 2
        Me.content_name_label.Text = "xxxxxxxxxxxxxxx"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(140, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Payment Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(178, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Use Points:"
        '
        'rent_usepointsbox
        '
        Me.rent_usepointsbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rent_usepointsbox.Location = New System.Drawing.Point(319, 217)
        Me.rent_usepointsbox.Name = "rent_usepointsbox"
        Me.rent_usepointsbox.Size = New System.Drawing.Size(161, 30)
        Me.rent_usepointsbox.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(178, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 29)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total Price: "
        '
        'totalprice_label
        '
        Me.totalprice_label.AutoSize = True
        Me.totalprice_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalprice_label.Location = New System.Drawing.Point(316, 272)
        Me.totalprice_label.Name = "totalprice_label"
        Me.totalprice_label.Size = New System.Drawing.Size(42, 25)
        Me.totalprice_label.TabIndex = 8
        Me.totalprice_label.Text = "xxx"
        '
        'rent_button
        '
        Me.rent_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rent_button.Location = New System.Drawing.Point(315, 357)
        Me.rent_button.Name = "rent_button"
        Me.rent_button.Size = New System.Drawing.Size(165, 60)
        Me.rent_button.TabIndex = 9
        Me.rent_button.Text = "Rent"
        Me.rent_button.UseVisualStyleBackColor = True
        '
        'payment_box
        '
        Me.payment_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payment_box.FormattingEnabled = True
        Me.payment_box.Items.AddRange(New Object() {"MBWAY", "VISA", "PAYPAL"})
        Me.payment_box.Location = New System.Drawing.Point(319, 164)
        Me.payment_box.Name = "payment_box"
        Me.payment_box.Size = New System.Drawing.Size(161, 33)
        Me.payment_box.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(364, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "$"
        '
        'rent_cont_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.payment_box)
        Me.Controls.Add(Me.rent_button)
        Me.Controls.Add(Me.totalprice_label)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rent_usepointsbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.content_name_label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "rent_cont_page"
        Me.Text = "Rent Content"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents content_name_label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rent_usepointsbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents totalprice_label As Label
    Friend WithEvents rent_button As Button
    Friend WithEvents payment_box As ComboBox
    Friend WithEvents Label6 As Label
End Class
