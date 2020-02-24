Public Class DinerMenuForm

    'Declaring what happens when the soup button is clicked
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = "Rootleaf Stew"
        DescriptionLabel.Text = "This custom soup is made from mushroom spores, Yarum seeds, Galla seeds, and Sohli bark"
        DescriptionLabel.Visible = True
        DisplaySpecialLabel.Visible = True
    End Sub

    'Declaring what happens when the salad button is clicked
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = "Yobshrimp Noodle Salad"
        DescriptionLabel.Text = "This salad consists of Shrimp with arrowroot noodles and a Thai chili paste vinaigrette"
        DescriptionLabel.Visible = True
        DisplaySpecialLabel.Visible = True
    End Sub

    'Declaring what happens when the Fish button is clicked
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = "Colo Claw Fish"
        DescriptionLabel.Text = "A special dish prepared using century old fish eggs, similar to caviar"
        DescriptionLabel.Visible = True
        DisplaySpecialLabel.Visible = True
    End Sub

    'Declaring what happens when the Exit button is clicked
    Private Sub ExitButton_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

End Class
