Public Class Form1

    Public Dice1 As Integer
    Public Dice2 As Integer
    Public Sum As Integer

    Public One As Integer
    Public Two As Integer
    Public Three As Integer
    Public Four As Integer
    Public Five As Integer
    Public Six As Integer
    Public Seven As Integer
    Public Eight As Integer
    Public Nine As Integer
    Public Ten As Integer
    Public Eleven As Integer
    Public Twelve As Integer
    Public Total As Integer
    Public x As String
    Sub Main()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Creating an array
        Dim StoredValues = New Integer(1, 13) {{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13}, {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13}}

        'Rolling the dice
        For i = 1 To 1000
            Randomize()
            Dim Dice1 As Integer = CInt(Int((6 * Rnd()) + 1))
            Randomize()
            Dim Dice2 As Integer = CInt(Int((6 * Rnd()) + 1))
            Sum = Dice1 + Dice2

            'Assigning the number totals

            If Sum = 2 Then
                Two = Two + 1
            ElseIf Sum = 3 Then
                Three = Three + 1
            ElseIf Sum = 4 Then
                Four = Four + 1
            ElseIf Sum = 5 Then
                Five = Five + 1
            ElseIf Sum = 6 Then
                Six = Six + 1
            ElseIf Sum = 7 Then
                Seven = Seven + 1
            ElseIf Sum = 8 Then
                Eight = Eight + 1
            ElseIf Sum = 9 Then
                Nine = Nine + 1
            ElseIf Sum = 10 Then
                Ten = Ten + 1
            ElseIf Sum = 11 Then
                Eleven = Eleven + 1
            ElseIf Sum = 12 Then
                Twelve = Twelve + 1
            End If

            Total = Two + Three + Four + Five + Six + Seven + Eight + Nine + Ten + Eleven + Twelve
        Next
        'Indexing the Array
        Static Dim v As Integer = StoredValues(1, 13)


        StoredValues(1, 2) = Two
        StoredValues(1, 3) = Three
        StoredValues(1, 3) = Four
        StoredValues(1, 5) = Five
        StoredValues(1, 6) = Six
        StoredValues(1, 7) = Seven
        StoredValues(1, 8) = Eight
        StoredValues(1, 9) = Nine
        StoredValues(1, 10) = Ten
        StoredValues(1, 11) = Eleven
        StoredValues(1, 12) = Twelve


        For F = 2 To 13
            ListBox1.Items.Add(StoredValues(1, F))
        Next



    End Sub
End Class
