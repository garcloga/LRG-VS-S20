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
        Me.NameTextbox = New System.Windows.Forms.TextBox()
        Me.GradeTextbox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextbox = New System.Windows.Forms.TextBox()
        Me.AgeTextbox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.SecondNumberTextbox = New System.Windows.Forms.TextBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.StudentAnswerTextbox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.RadioButton()
        Me.SubtractButton = New System.Windows.Forms.RadioButton()
        Me.DivideButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyButton = New System.Windows.Forms.RadioButton()
        Me.Operations = New System.Windows.Forms.GroupBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.Operations.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextbox
        '
        Me.NameTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextbox.Location = New System.Drawing.Point(61, 61)
        Me.NameTextbox.Name = "NameTextbox"
        Me.NameTextbox.Size = New System.Drawing.Size(227, 32)
        Me.NameTextbox.TabIndex = 3
        '
        'GradeTextbox
        '
        Me.GradeTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeTextbox.Location = New System.Drawing.Point(61, 120)
        Me.GradeTextbox.Name = "GradeTextbox"
        Me.GradeTextbox.Size = New System.Drawing.Size(227, 32)
        Me.GradeTextbox.TabIndex = 4
        '
        'FirstNumberTextbox
        '
        Me.FirstNumberTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNumberTextbox.Location = New System.Drawing.Point(61, 251)
        Me.FirstNumberTextbox.Name = "FirstNumberTextbox"
        Me.FirstNumberTextbox.Size = New System.Drawing.Size(227, 32)
        Me.FirstNumberTextbox.TabIndex = 6
        '
        'AgeTextbox
        '
        Me.AgeTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextbox.Location = New System.Drawing.Point(61, 185)
        Me.AgeTextbox.Name = "AgeTextbox"
        Me.AgeTextbox.Size = New System.Drawing.Size(227, 32)
        Me.AgeTextbox.TabIndex = 5
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(57, 38)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(101, 20)
        Me.NameLabel.TabIndex = 7
        Me.NameLabel.Text = "Child's Name"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeLabel.Location = New System.Drawing.Point(57, 97)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(54, 20)
        Me.GradeLabel.TabIndex = 8
        Me.GradeLabel.Text = "Grade"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeLabel.Location = New System.Drawing.Point(57, 162)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(38, 20)
        Me.AgeLabel.TabIndex = 10
        Me.AgeLabel.Text = "Age"
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNumberLabel.Location = New System.Drawing.Point(57, 228)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(100, 20)
        Me.FirstNumberLabel.TabIndex = 9
        Me.FirstNumberLabel.Text = "First Number"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondNumberLabel.Location = New System.Drawing.Point(57, 293)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(124, 20)
        Me.SecondNumberLabel.TabIndex = 12
        Me.SecondNumberLabel.Text = "Second Number"
        '
        'SecondNumberTextbox
        '
        Me.SecondNumberTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondNumberTextbox.Location = New System.Drawing.Point(61, 316)
        Me.SecondNumberTextbox.Name = "SecondNumberTextbox"
        Me.SecondNumberTextbox.Size = New System.Drawing.Size(227, 32)
        Me.SecondNumberTextbox.TabIndex = 11
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(57, 356)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(123, 20)
        Me.StudentAnswerLabel.TabIndex = 14
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'StudentAnswerTextbox
        '
        Me.StudentAnswerTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentAnswerTextbox.Location = New System.Drawing.Point(61, 379)
        Me.StudentAnswerTextbox.Name = "StudentAnswerTextbox"
        Me.StudentAnswerTextbox.Size = New System.Drawing.Size(227, 32)
        Me.StudentAnswerTextbox.TabIndex = 13
        '
        'AddButton
        '
        Me.AddButton.AutoSize = True
        Me.AddButton.Location = New System.Drawing.Point(6, 19)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(44, 17)
        Me.AddButton.TabIndex = 15
        Me.AddButton.TabStop = True
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'SubtractButton
        '
        Me.SubtractButton.AutoSize = True
        Me.SubtractButton.Location = New System.Drawing.Point(6, 43)
        Me.SubtractButton.Name = "SubtractButton"
        Me.SubtractButton.Size = New System.Drawing.Size(65, 17)
        Me.SubtractButton.TabIndex = 16
        Me.SubtractButton.TabStop = True
        Me.SubtractButton.Text = "Subtract"
        Me.SubtractButton.UseVisualStyleBackColor = True
        '
        'DivideButton
        '
        Me.DivideButton.AutoSize = True
        Me.DivideButton.Location = New System.Drawing.Point(6, 91)
        Me.DivideButton.Name = "DivideButton"
        Me.DivideButton.Size = New System.Drawing.Size(55, 17)
        Me.DivideButton.TabIndex = 18
        Me.DivideButton.TabStop = True
        Me.DivideButton.Text = "Divide"
        Me.DivideButton.UseVisualStyleBackColor = True
        '
        'MultiplyButton
        '
        Me.MultiplyButton.AutoSize = True
        Me.MultiplyButton.Location = New System.Drawing.Point(6, 67)
        Me.MultiplyButton.Name = "MultiplyButton"
        Me.MultiplyButton.Size = New System.Drawing.Size(60, 17)
        Me.MultiplyButton.TabIndex = 17
        Me.MultiplyButton.TabStop = True
        Me.MultiplyButton.Text = "Multiply"
        Me.MultiplyButton.UseVisualStyleBackColor = True
        '
        'Operations
        '
        Me.Operations.Controls.Add(Me.DivideButton)
        Me.Operations.Controls.Add(Me.AddButton)
        Me.Operations.Controls.Add(Me.MultiplyButton)
        Me.Operations.Controls.Add(Me.SubtractButton)
        Me.Operations.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Operations.Location = New System.Drawing.Point(348, 296)
        Me.Operations.Name = "Operations"
        Me.Operations.Size = New System.Drawing.Size(97, 115)
        Me.Operations.TabIndex = 19
        Me.Operations.TabStop = False
        Me.Operations.Text = "Operations"
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(522, 185)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 20
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 537)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.Operations)
        Me.Controls.Add(Me.StudentAnswerLabel)
        Me.Controls.Add(Me.StudentAnswerTextbox)
        Me.Controls.Add(Me.SecondNumberLabel)
        Me.Controls.Add(Me.SecondNumberTextbox)
        Me.Controls.Add(Me.AgeLabel)
        Me.Controls.Add(Me.FirstNumberLabel)
        Me.Controls.Add(Me.GradeLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.FirstNumberTextbox)
        Me.Controls.Add(Me.AgeTextbox)
        Me.Controls.Add(Me.GradeTextbox)
        Me.Controls.Add(Me.NameTextbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Operations.ResumeLayout(False)
        Me.Operations.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameTextbox As TextBox
    Friend WithEvents GradeTextbox As TextBox
    Friend WithEvents FirstNumberTextbox As TextBox
    Friend WithEvents AgeTextbox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents SecondNumberTextbox As TextBox
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents StudentAnswerTextbox As TextBox
    Friend WithEvents AddButton As RadioButton
    Friend WithEvents SubtractButton As RadioButton
    Friend WithEvents DivideButton As RadioButton
    Friend WithEvents MultiplyButton As RadioButton
    Friend WithEvents Operations As GroupBox
    Friend WithEvents SubmitButton As Button
End Class
