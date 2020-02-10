<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WinFormExample
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Update = New System.Windows.Forms.Button()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Update
        '
        Me.Update.Location = New System.Drawing.Point(401, 128)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(110, 83)
        Me.Update.TabIndex = 0
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(401, 93)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(241, 20)
        Me.UserTextBox.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(532, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 83)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'WinFormExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.Update)
        Me.Name = "WinFormExample"
        Me.Text = "Form Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Update As Button
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents Button2 As Button
End Class
