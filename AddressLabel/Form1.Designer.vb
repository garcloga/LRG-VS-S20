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
        Me.FirstNameTextbox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.LastNameTextbox = New System.Windows.Forms.TextBox()
        Me.CityTextbox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StreetAddressLabel = New System.Windows.Forms.Label()
        Me.StreetAddressTextbox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextbox = New System.Windows.Forms.TextBox()
        Me.ZipCodeLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.StateTextbox = New System.Windows.Forms.TextBox()
        Me.DisplayLabelButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.AddressLabelTextbox = New System.Windows.Forms.RichTextBox()
        Me.InputGroupbox = New System.Windows.Forms.GroupBox()
        Me.OutputGroupbox = New System.Windows.Forms.GroupBox()
        Me.InputGroupbox.SuspendLayout()
        Me.OutputGroupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirstNameTextbox
        '
        Me.FirstNameTextbox.Location = New System.Drawing.Point(40, 38)
        Me.FirstNameTextbox.Name = "FirstNameTextbox"
        Me.FirstNameTextbox.Size = New System.Drawing.Size(193, 20)
        Me.FirstNameTextbox.TabIndex = 1
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(22, 22)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.FirstNameLabel.TabIndex = 100
        Me.FirstNameLabel.Text = "First Name"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(22, 61)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(58, 13)
        Me.LastNameLabel.TabIndex = 100
        Me.LastNameLabel.Text = "Last Name"
        '
        'LastNameTextbox
        '
        Me.LastNameTextbox.Location = New System.Drawing.Point(40, 77)
        Me.LastNameTextbox.Name = "LastNameTextbox"
        Me.LastNameTextbox.Size = New System.Drawing.Size(193, 20)
        Me.LastNameTextbox.TabIndex = 2
        '
        'CityTextbox
        '
        Me.CityTextbox.Location = New System.Drawing.Point(40, 157)
        Me.CityTextbox.Name = "CityTextbox"
        Me.CityTextbox.Size = New System.Drawing.Size(193, 20)
        Me.CityTextbox.TabIndex = 4
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(22, 141)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(24, 13)
        Me.CityLabel.TabIndex = 100
        Me.CityLabel.Text = "City"
        '
        'StreetAddressLabel
        '
        Me.StreetAddressLabel.AutoSize = True
        Me.StreetAddressLabel.Location = New System.Drawing.Point(22, 102)
        Me.StreetAddressLabel.Name = "StreetAddressLabel"
        Me.StreetAddressLabel.Size = New System.Drawing.Size(76, 13)
        Me.StreetAddressLabel.TabIndex = 100
        Me.StreetAddressLabel.Text = "Street Address"
        '
        'StreetAddressTextbox
        '
        Me.StreetAddressTextbox.Location = New System.Drawing.Point(40, 118)
        Me.StreetAddressTextbox.Name = "StreetAddressTextbox"
        Me.StreetAddressTextbox.Size = New System.Drawing.Size(193, 20)
        Me.StreetAddressTextbox.TabIndex = 3
        '
        'ZipCodeTextbox
        '
        Me.ZipCodeTextbox.Location = New System.Drawing.Point(40, 236)
        Me.ZipCodeTextbox.Name = "ZipCodeTextbox"
        Me.ZipCodeTextbox.Size = New System.Drawing.Size(88, 20)
        Me.ZipCodeTextbox.TabIndex = 6
        '
        'ZipCodeLabel
        '
        Me.ZipCodeLabel.AutoSize = True
        Me.ZipCodeLabel.Location = New System.Drawing.Point(22, 220)
        Me.ZipCodeLabel.Name = "ZipCodeLabel"
        Me.ZipCodeLabel.Size = New System.Drawing.Size(50, 13)
        Me.ZipCodeLabel.TabIndex = 100
        Me.ZipCodeLabel.Text = "Zip Code"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(22, 181)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(32, 13)
        Me.StateLabel.TabIndex = 100
        Me.StateLabel.Text = "State"
        '
        'StateTextbox
        '
        Me.StateTextbox.Location = New System.Drawing.Point(40, 197)
        Me.StateTextbox.Name = "StateTextbox"
        Me.StateTextbox.Size = New System.Drawing.Size(88, 20)
        Me.StateTextbox.TabIndex = 5
        '
        'DisplayLabelButton
        '
        Me.DisplayLabelButton.Location = New System.Drawing.Point(132, 295)
        Me.DisplayLabelButton.Name = "DisplayLabelButton"
        Me.DisplayLabelButton.Size = New System.Drawing.Size(87, 50)
        Me.DisplayLabelButton.TabIndex = 101
        Me.DisplayLabelButton.Text = "Display &Label"
        Me.DisplayLabelButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(225, 295)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(87, 50)
        Me.ClearButton.TabIndex = 102
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(318, 295)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(87, 50)
        Me.ExitButton.TabIndex = 103
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AddressLabelTextbox
        '
        Me.AddressLabelTextbox.Location = New System.Drawing.Point(22, 25)
        Me.AddressLabelTextbox.Name = "AddressLabelTextbox"
        Me.AddressLabelTextbox.Size = New System.Drawing.Size(245, 215)
        Me.AddressLabelTextbox.TabIndex = 105
        Me.AddressLabelTextbox.TabStop = False
        Me.AddressLabelTextbox.Text = ""
        '
        'InputGroupbox
        '
        Me.InputGroupbox.Controls.Add(Me.FirstNameTextbox)
        Me.InputGroupbox.Controls.Add(Me.FirstNameLabel)
        Me.InputGroupbox.Controls.Add(Me.LastNameLabel)
        Me.InputGroupbox.Controls.Add(Me.LastNameTextbox)
        Me.InputGroupbox.Controls.Add(Me.StreetAddressTextbox)
        Me.InputGroupbox.Controls.Add(Me.StreetAddressLabel)
        Me.InputGroupbox.Controls.Add(Me.ZipCodeTextbox)
        Me.InputGroupbox.Controls.Add(Me.CityLabel)
        Me.InputGroupbox.Controls.Add(Me.ZipCodeLabel)
        Me.InputGroupbox.Controls.Add(Me.CityTextbox)
        Me.InputGroupbox.Controls.Add(Me.StateLabel)
        Me.InputGroupbox.Controls.Add(Me.StateTextbox)
        Me.InputGroupbox.Location = New System.Drawing.Point(7, 25)
        Me.InputGroupbox.Name = "InputGroupbox"
        Me.InputGroupbox.Size = New System.Drawing.Size(280, 264)
        Me.InputGroupbox.TabIndex = 106
        Me.InputGroupbox.TabStop = False
        Me.InputGroupbox.Text = "Mailing Address"
        '
        'OutputGroupbox
        '
        Me.OutputGroupbox.Controls.Add(Me.AddressLabelTextbox)
        Me.OutputGroupbox.Location = New System.Drawing.Point(318, 25)
        Me.OutputGroupbox.Name = "OutputGroupbox"
        Me.OutputGroupbox.Size = New System.Drawing.Size(277, 256)
        Me.OutputGroupbox.TabIndex = 101
        Me.OutputGroupbox.TabStop = False
        Me.OutputGroupbox.Text = "Address Label"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 371)
        Me.Controls.Add(Me.OutputGroupbox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DisplayLabelButton)
        Me.Controls.Add(Me.InputGroupbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.InputGroupbox.ResumeLayout(False)
        Me.InputGroupbox.PerformLayout()
        Me.OutputGroupbox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FirstNameTextbox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents LastNameTextbox As TextBox
    Friend WithEvents CityTextbox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents StreetAddressLabel As Label
    Friend WithEvents StreetAddressTextbox As TextBox
    Friend WithEvents ZipCodeTextbox As TextBox
    Friend WithEvents ZipCodeLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents StateTextbox As TextBox
    Friend WithEvents DisplayLabelButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents AddressLabelTextbox As RichTextBox
    Friend WithEvents InputGroupbox As GroupBox
    Friend WithEvents OutputGroupbox As GroupBox
End Class
