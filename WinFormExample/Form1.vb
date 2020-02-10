Public Class WinFormExample
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Hello Form"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UserTextBox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Dim userInput As String
        userInput = UserTextBox.Text
        Me.Text = userInput




    End Sub



End Class
