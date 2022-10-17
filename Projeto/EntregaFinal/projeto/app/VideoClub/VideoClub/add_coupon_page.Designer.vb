<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_coupon_page
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
        Me.addcoupon_idname_box = New System.Windows.Forms.TextBox()
        Me.addcoupon_startdate_box = New System.Windows.Forms.TextBox()
        Me.addcoupon_finaldate_box = New System.Windows.Forms.TextBox()
        Me.addcoupon_points_box = New System.Windows.Forms.TextBox()
        Me.addcoupon_add_button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(293, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD COUPON"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(223, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'addcoupon_idname_box
        '
        Me.addcoupon_idname_box.Location = New System.Drawing.Point(299, 111)
        Me.addcoupon_idname_box.Name = "addcoupon_idname_box"
        Me.addcoupon_idname_box.Size = New System.Drawing.Size(188, 22)
        Me.addcoupon_idname_box.TabIndex = 2
        '
        'addcoupon_startdate_box
        '
        Me.addcoupon_startdate_box.Location = New System.Drawing.Point(299, 175)
        Me.addcoupon_startdate_box.Name = "addcoupon_startdate_box"
        Me.addcoupon_startdate_box.Size = New System.Drawing.Size(188, 22)
        Me.addcoupon_startdate_box.TabIndex = 3
        '
        'addcoupon_finaldate_box
        '
        Me.addcoupon_finaldate_box.Location = New System.Drawing.Point(299, 238)
        Me.addcoupon_finaldate_box.Name = "addcoupon_finaldate_box"
        Me.addcoupon_finaldate_box.Size = New System.Drawing.Size(188, 22)
        Me.addcoupon_finaldate_box.TabIndex = 4
        '
        'addcoupon_points_box
        '
        Me.addcoupon_points_box.Location = New System.Drawing.Point(299, 300)
        Me.addcoupon_points_box.Name = "addcoupon_points_box"
        Me.addcoupon_points_box.Size = New System.Drawing.Size(188, 22)
        Me.addcoupon_points_box.TabIndex = 5
        '
        'addcoupon_add_button
        '
        Me.addcoupon_add_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addcoupon_add_button.Location = New System.Drawing.Point(299, 371)
        Me.addcoupon_add_button.Name = "addcoupon_add_button"
        Me.addcoupon_add_button.Size = New System.Drawing.Size(188, 48)
        Me.addcoupon_add_button.TabIndex = 6
        Me.addcoupon_add_button.Text = "ADD"
        Me.addcoupon_add_button.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Start Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(186, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Final Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(220, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Points:"
        '
        'add_coupon_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.addcoupon_points_box)
        Me.Controls.Add(Me.addcoupon_finaldate_box)
        Me.Controls.Add(Me.addcoupon_startdate_box)
        Me.Controls.Add(Me.addcoupon_idname_box)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.addcoupon_add_button)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "add_coupon_page"
        Me.Text = "Add Coupon Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents addcoupon_idname_box As TextBox
    Friend WithEvents addcoupon_startdate_box As TextBox
    Friend WithEvents addcoupon_finaldate_box As TextBox
    Friend WithEvents addcoupon_points_box As TextBox
    Friend WithEvents addcoupon_add_button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
