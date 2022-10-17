<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class promocouppage
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
        Me.Promotion_list = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Coupons_list = New System.Windows.Forms.ListBox()
        Me.promocoup_returnbutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Promotions:"
        '
        'Promotion_list
        '
        Me.Promotion_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Promotion_list.FormattingEnabled = True
        Me.Promotion_list.ItemHeight = 29
        Me.Promotion_list.Location = New System.Drawing.Point(12, 105)
        Me.Promotion_list.Name = "Promotion_list"
        Me.Promotion_list.Size = New System.Drawing.Size(326, 323)
        Me.Promotion_list.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(452, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Coupons:"
        '
        'Coupons_list
        '
        Me.Coupons_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Coupons_list.FormattingEnabled = True
        Me.Coupons_list.ItemHeight = 29
        Me.Coupons_list.Location = New System.Drawing.Point(457, 105)
        Me.Coupons_list.Name = "Coupons_list"
        Me.Coupons_list.Size = New System.Drawing.Size(326, 323)
        Me.Coupons_list.TabIndex = 3
        '
        'promocoup_returnbutton
        '
        Me.promocoup_returnbutton.Location = New System.Drawing.Point(2, 2)
        Me.promocoup_returnbutton.Name = "promocoup_returnbutton"
        Me.promocoup_returnbutton.Size = New System.Drawing.Size(106, 38)
        Me.promocoup_returnbutton.TabIndex = 4
        Me.promocoup_returnbutton.Text = "<- Return"
        Me.promocoup_returnbutton.UseVisualStyleBackColor = True
        '
        'promocouppage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.promocoup_returnbutton)
        Me.Controls.Add(Me.Coupons_list)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Promotion_list)
        Me.Controls.Add(Me.Label1)
        Me.Name = "promocouppage"
        Me.Text = "Promotions/Coupons Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Promotion_list As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Coupons_list As ListBox
    Friend WithEvents promocoup_returnbutton As Button
End Class
