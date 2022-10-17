<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homepage
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
        Me.operations_button = New System.Windows.Forms.Button()
        Me.filme_button = New System.Windows.Forms.Button()
        Me.serie_button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Conteudo_list = New System.Windows.Forms.ListBox()
        Me.search_box = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clear_filter_button = New System.Windows.Forms.Button()
        Me.order_box = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.category_box = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.promocouppage_button = New System.Windows.Forms.Button()
        Me.homepage_profile_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'operations_button
        '
        Me.operations_button.Location = New System.Drawing.Point(677, 404)
        Me.operations_button.Name = "operations_button"
        Me.operations_button.Size = New System.Drawing.Size(124, 46)
        Me.operations_button.TabIndex = 0
        Me.operations_button.Text = "Operations"
        Me.operations_button.UseVisualStyleBackColor = True
        '
        'filme_button
        '
        Me.filme_button.Location = New System.Drawing.Point(497, 242)
        Me.filme_button.Name = "filme_button"
        Me.filme_button.Size = New System.Drawing.Size(122, 46)
        Me.filme_button.TabIndex = 1
        Me.filme_button.Text = "Films"
        Me.filme_button.UseVisualStyleBackColor = True
        '
        'serie_button
        '
        Me.serie_button.Location = New System.Drawing.Point(497, 294)
        Me.serie_button.Name = "serie_button"
        Me.serie_button.Size = New System.Drawing.Size(122, 46)
        Me.serie_button.TabIndex = 2
        Me.serie_button.Text = "Series"
        Me.serie_button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(313, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "VideoClub"
        '
        'Conteudo_list
        '
        Me.Conteudo_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Conteudo_list.FormattingEnabled = True
        Me.Conteudo_list.ItemHeight = 29
        Me.Conteudo_list.Location = New System.Drawing.Point(54, 99)
        Me.Conteudo_list.Name = "Conteudo_list"
        Me.Conteudo_list.Size = New System.Drawing.Size(366, 323)
        Me.Conteudo_list.TabIndex = 4
        '
        'search_box
        '
        Me.search_box.Location = New System.Drawing.Point(159, 70)
        Me.search_box.Name = "search_box"
        Me.search_box.Size = New System.Drawing.Size(261, 22)
        Me.search_box.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Search:"
        '
        'clear_filter_button
        '
        Me.clear_filter_button.Location = New System.Drawing.Point(497, 375)
        Me.clear_filter_button.Name = "clear_filter_button"
        Me.clear_filter_button.Size = New System.Drawing.Size(122, 44)
        Me.clear_filter_button.TabIndex = 9
        Me.clear_filter_button.Text = "Clear Filter"
        Me.clear_filter_button.UseVisualStyleBackColor = True
        '
        'order_box
        '
        Me.order_box.FormattingEnabled = True
        Me.order_box.Items.AddRange(New Object() {"", "Título", "Categoria", "Preço", "Ano"})
        Me.order_box.Location = New System.Drawing.Point(497, 96)
        Me.order_box.Name = "order_box"
        Me.order_box.Size = New System.Drawing.Size(122, 24)
        Me.order_box.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(494, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Order By:"
        '
        'category_box
        '
        Me.category_box.FormattingEnabled = True
        Me.category_box.Items.AddRange(New Object() {"", "Comedia", "Terror", "Drama", "Romance", "Thriller", "Fantasia", "Ficcao Cientifica", "Acao", "Aventura", "Danca", "Documentario"})
        Me.category_box.Location = New System.Drawing.Point(497, 178)
        Me.category_box.Name = "category_box"
        Me.category_box.Size = New System.Drawing.Size(122, 24)
        Me.category_box.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(494, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Category:"
        '
        'promocouppage_button
        '
        Me.promocouppage_button.Location = New System.Drawing.Point(0, 0)
        Me.promocouppage_button.Name = "promocouppage_button"
        Me.promocouppage_button.Size = New System.Drawing.Size(153, 46)
        Me.promocouppage_button.TabIndex = 15
        Me.promocouppage_button.Text = "Promotions/Coupons"
        Me.promocouppage_button.UseVisualStyleBackColor = True
        '
        'homepage_profile_button
        '
        Me.homepage_profile_button.Location = New System.Drawing.Point(648, 0)
        Me.homepage_profile_button.Name = "homepage_profile_button"
        Me.homepage_profile_button.Size = New System.Drawing.Size(153, 46)
        Me.homepage_profile_button.TabIndex = 16
        Me.homepage_profile_button.Text = "Profile"
        Me.homepage_profile_button.UseVisualStyleBackColor = True
        '
        'homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 450)
        Me.Controls.Add(Me.homepage_profile_button)
        Me.Controls.Add(Me.promocouppage_button)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.category_box)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.order_box)
        Me.Controls.Add(Me.clear_filter_button)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.search_box)
        Me.Controls.Add(Me.Conteudo_list)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.serie_button)
        Me.Controls.Add(Me.filme_button)
        Me.Controls.Add(Me.operations_button)
        Me.Name = "homepage"
        Me.Text = "HomePage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents operations_button As Button
    Friend WithEvents filme_button As Button
    Friend WithEvents serie_button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Conteudo_list As ListBox
    Friend WithEvents search_box As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents clear_filter_button As Button
    Friend WithEvents order_box As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents category_box As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents promocouppage_button As Button
    Friend WithEvents homepage_profile_button As Button
End Class
