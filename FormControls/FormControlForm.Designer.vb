<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormControlForm
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
        Me.Go = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UserInputBox = New System.Windows.Forms.GroupBox()
        Me.UserSelection = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UserInputB = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.UserInputBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Go
        '
        Me.Go.Location = New System.Drawing.Point(129, 336)
        Me.Go.Name = "Go"
        Me.Go.Size = New System.Drawing.Size(155, 102)
        Me.Go.TabIndex = 0
        Me.Go.Text = "Go"
        Me.Go.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Location = New System.Drawing.Point(290, 336)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(155, 102)
        Me.Update.TabIndex = 1
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(451, 336)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(155, 102)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UserInputBox
        '
        Me.UserInputBox.Controls.Add(Me.TextBox3)
        Me.UserInputBox.Controls.Add(Me.TextBox2)
        Me.UserInputBox.Controls.Add(Me.UserInputB)
        Me.UserInputBox.Location = New System.Drawing.Point(12, 12)
        Me.UserInputBox.Name = "UserInputBox"
        Me.UserInputBox.Size = New System.Drawing.Size(272, 232)
        Me.UserInputBox.TabIndex = 3
        Me.UserInputBox.TabStop = False
        '
        'UserSelection
        '
        Me.UserSelection.Location = New System.Drawing.Point(290, 12)
        Me.UserSelection.Name = "UserSelection"
        Me.UserSelection.Size = New System.Drawing.Size(272, 232)
        Me.UserSelection.TabIndex = 4
        Me.UserSelection.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(627, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(282, 232)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'UserInputB
        '
        Me.UserInputB.Location = New System.Drawing.Point(38, 42)
        Me.UserInputB.Name = "UserInputB"
        Me.UserInputB.Size = New System.Drawing.Size(193, 26)
        Me.UserInputB.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(40, 103)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(193, 26)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(40, 160)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(193, 26)
        Me.TextBox3.TabIndex = 2
        '
        'FormControlForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UserSelection)
        Me.Controls.Add(Me.UserInputBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Go)
        Me.Name = "FormControlForm"
        Me.Text = "User Control Interface"
        Me.UserInputBox.ResumeLayout(False)
        Me.UserInputBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Go As Button
    Friend WithEvents Update As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents UserInputBox As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents UserInputB As TextBox
    Friend WithEvents UserSelection As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
