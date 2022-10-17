<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profile_page
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.profile_namebox = New System.Windows.Forms.TextBox()
        Me.profile_emailbox = New System.Windows.Forms.TextBox()
        Me.profile_contribuintebox = New System.Windows.Forms.TextBox()
        Me.profile_datebox = New System.Windows.Forms.TextBox()
        Me.profile_list = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.profile_returnbutton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.profile_pointsbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Coupons", "History"})
        Me.ComboBox1.Location = New System.Drawing.Point(655, 280)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(343, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Profile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(484, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Born Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(427, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Contribuinte:"
        '
        'profile_namebox
        '
        Me.profile_namebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile_namebox.Location = New System.Drawing.Point(155, 94)
        Me.profile_namebox.Name = "profile_namebox"
        Me.profile_namebox.Size = New System.Drawing.Size(130, 30)
        Me.profile_namebox.TabIndex = 6
        '
        'profile_emailbox
        '
        Me.profile_emailbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile_emailbox.Location = New System.Drawing.Point(556, 103)
        Me.profile_emailbox.Name = "profile_emailbox"
        Me.profile_emailbox.Size = New System.Drawing.Size(154, 24)
        Me.profile_emailbox.TabIndex = 7
        '
        'profile_contribuintebox
        '
        Me.profile_contribuintebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile_contribuintebox.Location = New System.Drawing.Point(556, 164)
        Me.profile_contribuintebox.Name = "profile_contribuintebox"
        Me.profile_contribuintebox.Size = New System.Drawing.Size(154, 30)
        Me.profile_contribuintebox.TabIndex = 8
        '
        'profile_datebox
        '
        Me.profile_datebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile_datebox.Location = New System.Drawing.Point(155, 163)
        Me.profile_datebox.Name = "profile_datebox"
        Me.profile_datebox.Size = New System.Drawing.Size(130, 34)
        Me.profile_datebox.TabIndex = 9
        '
        'profile_list
        '
        Me.profile_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile_list.FormattingEnabled = True
        Me.profile_list.ItemHeight = 31
        Me.profile_list.Location = New System.Drawing.Point(17, 323)
        Me.profile_list.Name = "profile_list"
        Me.profile_list.Size = New System.Drawing.Size(759, 97)
        Me.profile_list.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(551, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Pick One:"
        '
        'profile_returnbutton
        '
        Me.profile_returnbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile_returnbutton.Location = New System.Drawing.Point(-1, -2)
        Me.profile_returnbutton.Name = "profile_returnbutton"
        Me.profile_returnbutton.Size = New System.Drawing.Size(105, 47)
        Me.profile_returnbutton.TabIndex = 12
        Me.profile_returnbutton.Text = "<- Return"
        Me.profile_returnbutton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 29)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Points: "
        '
        'profile_pointsbox
        '
        Me.profile_pointsbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile_pointsbox.Location = New System.Drawing.Point(110, 284)
        Me.profile_pointsbox.Name = "profile_pointsbox"
        Me.profile_pointsbox.Size = New System.Drawing.Size(135, 27)
        Me.profile_pointsbox.TabIndex = 14
        '
        'profile_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.profile_pointsbox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.profile_returnbutton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.profile_list)
        Me.Controls.Add(Me.profile_datebox)
        Me.Controls.Add(Me.profile_contribuintebox)
        Me.Controls.Add(Me.profile_emailbox)
        Me.Controls.Add(Me.profile_namebox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "profile_page"
        Me.Text = "Profile Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents profile_namebox As TextBox
    Friend WithEvents profile_emailbox As TextBox
    Friend WithEvents profile_contribuintebox As TextBox
    Friend WithEvents profile_datebox As TextBox
    Friend WithEvents profile_list As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents profile_returnbutton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents profile_pointsbox As TextBox
End Class
