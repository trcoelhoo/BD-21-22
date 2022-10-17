<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class operation_page
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.return_button = New System.Windows.Forms.Button()
        Me.add_conteudo_button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.add_coupon_button = New System.Windows.Forms.Button()
        Me.add_promotion_button = New System.Windows.Forms.Button()
        Me.add_admin_button = New System.Windows.Forms.Button()
        Me.operation_editcont_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'return_button
        '
        Me.return_button.Location = New System.Drawing.Point(-1, 0)
        Me.return_button.Name = "return_button"
        Me.return_button.Size = New System.Drawing.Size(85, 48)
        Me.return_button.TabIndex = 0
        Me.return_button.Text = "<- Return"
        Me.return_button.UseVisualStyleBackColor = True
        '
        'add_conteudo_button
        '
        Me.add_conteudo_button.Location = New System.Drawing.Point(250, 105)
        Me.add_conteudo_button.Name = "add_conteudo_button"
        Me.add_conteudo_button.Size = New System.Drawing.Size(141, 83)
        Me.add_conteudo_button.TabIndex = 1
        Me.add_conteudo_button.Text = "Add Content"
        Me.add_conteudo_button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(324, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Operations"
        '
        'add_coupon_button
        '
        Me.add_coupon_button.Location = New System.Drawing.Point(397, 161)
        Me.add_coupon_button.Name = "add_coupon_button"
        Me.add_coupon_button.Size = New System.Drawing.Size(141, 83)
        Me.add_coupon_button.TabIndex = 3
        Me.add_coupon_button.Text = "Add Coupon"
        Me.add_coupon_button.UseVisualStyleBackColor = True
        '
        'add_promotion_button
        '
        Me.add_promotion_button.Location = New System.Drawing.Point(397, 250)
        Me.add_promotion_button.Name = "add_promotion_button"
        Me.add_promotion_button.Size = New System.Drawing.Size(141, 83)
        Me.add_promotion_button.TabIndex = 4
        Me.add_promotion_button.Text = "Add Promotion"
        Me.add_promotion_button.UseVisualStyleBackColor = True
        '
        'add_admin_button
        '
        Me.add_admin_button.Location = New System.Drawing.Point(250, 283)
        Me.add_admin_button.Name = "add_admin_button"
        Me.add_admin_button.Size = New System.Drawing.Size(141, 83)
        Me.add_admin_button.TabIndex = 5
        Me.add_admin_button.Text = "Add Admin"
        Me.add_admin_button.UseVisualStyleBackColor = True
        '
        'operation_editcont_button
        '
        Me.operation_editcont_button.Location = New System.Drawing.Point(250, 194)
        Me.operation_editcont_button.Name = "operation_editcont_button"
        Me.operation_editcont_button.Size = New System.Drawing.Size(141, 83)
        Me.operation_editcont_button.TabIndex = 6
        Me.operation_editcont_button.Text = "Edit Content"
        Me.operation_editcont_button.UseVisualStyleBackColor = True
        '
        'operation_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.operation_editcont_button)
        Me.Controls.Add(Me.add_admin_button)
        Me.Controls.Add(Me.add_promotion_button)
        Me.Controls.Add(Me.add_coupon_button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.add_conteudo_button)
        Me.Controls.Add(Me.return_button)
        Me.Name = "operation_page"
        Me.Text = "OperationPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents return_button As Button
    Friend WithEvents add_conteudo_button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents add_coupon_button As Button
    Friend WithEvents add_promotion_button As Button
    Friend WithEvents add_admin_button As Button
    Friend WithEvents operation_editcont_button As Button
End Class
