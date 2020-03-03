Module Module1

    Sub Main()

        Dim myArray(3) As Integer

        myArray(1) = 5
        myArray = {1, 2, 3, 4}

        Console.ReadLine()
        Dim infoArray() As String
        infoArray = Split("hello,goodbye,pizza,hungry,ice cream", ",")

        Console.ReadLine()
    End Sub



    Private Sub InitiateArrays()
        Dim numbers(4) As Integer
        numbers = {1, 2, 4, 8, 16}
    End Sub

End Module
