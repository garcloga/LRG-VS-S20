Option Explicit On
Option Strict On

Module Module1
    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer


        firstNumber = 5
        secondNumber = 7

        result = firstNumber + secondNumber
        result = result + 3

        For i = 0 To 25 Step 5
            result = result + 3
            Console.WriteLine(i)
        Next

        Console.WriteLine(result)
        Console.ReadLine()
    End Sub

End Module
