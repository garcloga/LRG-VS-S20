Public Class FormControlForm

    Private Sub FormControlForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Dim displayText As String = NameTextBox.Text & StreetTextBox.Text & StateTextBox.Text
        DisplayLabel.Text = displayText

    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub Go_Click(sender As Object, e As EventArgs) Handles Go.Click
        If CheckBox1.Checked = True Then
            DisplayLabel.Text = NameTextBox.Text
        End If
    End Sub

    Private Sub DisplayLabel_Click(sender As Object, e As EventArgs) Handles DisplayLabel.Click

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            DisplayLabel.Visible = False
        ElseIf CheckBox4.Checked = False Then

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = True Then
            UserPictureBox.BackgroundImage = Nothing
        ElseIf CheckBox3.Checked = False Then
            UserPictureBox.BackgroundImage = My.Resources.Lab_13_PWM_and_H_bridge

        End If
    End Sub
End Class
