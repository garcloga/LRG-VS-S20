Public Class ListBoxForm
    Private Sub ListBoxForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'DataListBox
        FirstNameTextbox.Text = "Elmer"
        LastNameTextbox.Text = "Fudd"

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        DataListBox.Items.Add(FirstNameTextbox.Text & " " & LastNameTextbox.Text)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DataListBox.Items.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DataListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataListBox.SelectedIndexChanged
        Dim index As Integer

        Me.Text = DataListBox.SelectedIndex.ToString
        'TODO add selected to first name and last name text box
        index = InStr(DataListBox.SelectedItem.ToString, " ")

        'FirstNameTextbox.Text = Strings.Left(DataListBox.SelectedItem.ToString, index)
        'TODO Right() don't work
        LastNameTextbox.Text = Strings.Right(DataListBox.SelectedItem.ToString, index)

    End Sub

End Class
