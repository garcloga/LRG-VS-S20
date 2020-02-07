
Option Strict On
Option Explicit On


Module Module1

    Sub Main()

        Dim myNumber As Integer
        myNumber = 7
        Console.WriteLine("In Sub Main")
        Console.WriteLine(myNumber)
        Console.ReadLine()

        MySub(myNumber)
        Console.WriteLine("In Sub Main")
        Console.WriteLine(myNumber)

        myNumber = MyFunc(myNumber)
        Console.WriteLine("In Sub Main")
        Console.WriteLine(myNumber)


        Console.ReadLine()
        doMath(7, 5, "add")
        'ShowPattern(5)
        Console.ReadLine()
    End Sub

    Sub MySub(myNumber As Integer)
        'Dim myNumber As Integer
        'myNumber = myNumber + 2
        myNumber += 2
        Console.WriteLine("In Sub MySub")
        Console.WriteLine(myNumber)
        Console.ReadLine()
    End Sub

    Function MyFunc(myNumber As Integer) As Integer
        'Dim myNumber As Integer
        myNumber -= 3
        Console.WriteLine("In Function MyFunc")
        Console.WriteLine(myNumber)
        Console.ReadLine()
        Return myNumber
    End Function

    Sub doMath(firstNumber As Integer, secondNumber As Integer, operatorChoice As String)
        Dim result As Double

        If operatorChoice = "add" Then
            result = firstNumber + secondNumber
            Console.WriteLine(result)
        ElseIf operatorChoice = "subtract" Then
            result = firstNumber - secondNumber
            Console.WriteLine(result)
        ElseIf operatorChoice = "multiply" Then
            result = firstNumber * secondNumber
            Console.WriteLine(result)
        ElseIf operatorChoice = "divide" Then
            result = firstNumber / secondNumber
            Console.WriteLine(result)
        End If


    End Sub


    'Sub ShowPattern(length As Integer)
    '    Dim character As String
    '    Dim pattern As String

    '    character = "*"
    '    For index = 0 To length
    '        pattern &= character
    '        Console.WriteLine(pattern)
    '    Next
    '    Console.WriteLine()

    'End Sub

End Module
