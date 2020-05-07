<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ChangeColorButton = New System.Windows.Forms.Button()
        Me.DrawButton = New System.Windows.Forms.Button()
        Me.EraseButton = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(776, 362)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ChangeColorButton
        '
        Me.ChangeColorButton.Location = New System.Drawing.Point(13, 381)
        Me.ChangeColorButton.Name = "ChangeColorButton"
        Me.ChangeColorButton.Size = New System.Drawing.Size(179, 57)
        Me.ChangeColorButton.TabIndex = 1
        Me.ChangeColorButton.Text = "Change Color"
        Me.ChangeColorButton.UseVisualStyleBackColor = True
        '
        'DrawButton
        '
        Me.DrawButton.Location = New System.Drawing.Point(227, 380)
        Me.DrawButton.Name = "DrawButton"
        Me.DrawButton.Size = New System.Drawing.Size(179, 57)
        Me.DrawButton.TabIndex = 2
        Me.DrawButton.Text = "Draw"
        Me.DrawButton.UseVisualStyleBackColor = True
        '
        'EraseButton
        '
        Me.EraseButton.Location = New System.Drawing.Point(440, 380)
        Me.EraseButton.Name = "EraseButton"
        Me.EraseButton.Size = New System.Drawing.Size(179, 57)
        Me.EraseButton.TabIndex = 3
        Me.EraseButton.Text = "Erase"
        Me.EraseButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EraseButton)
        Me.Controls.Add(Me.DrawButton)
        Me.Controls.Add(Me.ChangeColorButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ChangeColorButton As Button
    Friend WithEvents DrawButton As Button
    Friend WithEvents EraseButton As Button
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
