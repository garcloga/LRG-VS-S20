<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenuForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.DisplaySpecialLabel = New System.Windows.Forms.Label()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.DescriptionLabel = New System.Windows.Forms.RichTextBox()
        Me.DinerNameLabel = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'SoupButton
        '
        Me.SoupButton.Location = New System.Drawing.Point(153, 337)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(114, 65)
        Me.SoupButton.TabIndex = 0
        Me.SoupButton.Text = "Soup"
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'SaladButton
        '
        Me.SaladButton.Location = New System.Drawing.Point(297, 337)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(114, 65)
        Me.SaladButton.TabIndex = 1
        Me.SaladButton.Text = "Salad"
        Me.SaladButton.UseVisualStyleBackColor = True
        '
        'FishButton
        '
        Me.FishButton.Location = New System.Drawing.Point(441, 337)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(114, 65)
        Me.FishButton.TabIndex = 2
        Me.FishButton.Text = "Fish"
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(297, 107)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(422, 46)
        Me.DisplaySpecialLabel.TabIndex = 5
        Me.DisplaySpecialLabel.Text = "Diner Special"
        Me.DisplaySpecialLabel.Visible = False
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(686, 390)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(102, 48)
        Me.ButtonExit.TabIndex = 3
        Me.ButtonExit.Text = "E&xit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.BackColor = System.Drawing.SystemColors.Info
        Me.DescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(181, 156)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(480, 96)
        Me.DescriptionLabel.TabIndex = 8
        Me.DescriptionLabel.TabStop = False
        Me.DescriptionLabel.Text = "This custom soup is made from mushroom spores, Yarum seeds, Galla seeds, and Sohl" &
    "i bark"
        '
        'DinerNameLabel
        '
        Me.DinerNameLabel.BackColor = System.Drawing.SystemColors.Info
        Me.DinerNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DinerNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinerNameLabel.Location = New System.Drawing.Point(209, 8)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(480, 96)
        Me.DinerNameLabel.TabIndex = 9
        Me.DinerNameLabel.TabStop = False
        Me.DinerNameLabel.Text = "Dex's Diner"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(303, 66)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(326, 38)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.TabStop = False
        Me.RichTextBox1.Text = "Eat Where No Man Has Eaten Before"
        '
        'DinerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.DisplaySpecialLabel)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Name = "DinerMenuForm"
        Me.Text = "Dex's Diner Special Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SoupButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents DisplaySpecialLabel As Label
    Friend WithEvents ButtonExit As Button
    Friend WithEvents DescriptionLabel As RichTextBox
    Friend WithEvents DinerNameLabel As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
