'Logan Garcia
'RCET0265   
'AddressLabel
'Spring2020
'https://github.com/garcloga/LRG-VS-S20


Public Class Form1

    Private Sub DisplayLabelButton_Click(sender As Object, e As EventArgs) Handles DisplayLabelButton.Click
        'lines 5 through 19 are breaking things into variables
        Dim x As String
        x = vbNewLine
        Dim firstName As String
        firstName = FirstNameTextbox.Text
        Dim lastName As String
        lastName = LastNameTextbox.Text
        Name = firstName & " " & lastName
        Dim streetAddress As String
        streetAddress = StreetAddressTextbox.Text
        Dim city As String
        city = CityTextbox.Text
        Dim state As String
        state = StateTextbox.Text
        Dim zip As String
        zip = ZipCodeTextbox.Text


        AddressLabelTextbox.Text = Name & x & streetAddress & x & city & ", " & state & " " & zip

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        AddressLabelTextbox.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
