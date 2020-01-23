'Logan Garcia
'RCET0265
'Spring2020

Option Strict On
Option Explicit On

Module IfThen

    Sub Main()

        Dim firstNumber As Integer
        Dim secondNumber As Integer

        firstNumber = 5
        secondNumber = 3

        If firstNumber < secondNumber Then

            Console.WriteLine("Second Number Is Bigger")

        ElseIf firstNumber > secondNumber Then

            Console.WriteLine("First Number Is Bigger")

        ElseIf firstNumber = secondNumber Then

            Console.WriteLine("First Number Is Equal to Second Number")

        End If

        If firstNumber >= secondNumber Then

            Console.WriteLine("First Number Is Bigger or Equal")

        ElseIf firstNumber <= secondNumber Then

            Console.WriteLine("Second Number Is Bigger or Equal")

        ElseIf firstNumber <> secondNumber Then

            Console.WriteLine("The Numbers are Not Equal")

        Else

            Console.WriteLine("Some Other Thing???")

        End If

        Console.ReadLine()

    End Sub

End Module
