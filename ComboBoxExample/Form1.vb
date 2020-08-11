Public Class Form1
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        MainComboBox.Items.Add("Logan")
        Me.Text = MainComboBox.SelectedValue
    End Sub
End Class
