'Logan Garcia
'RCET0265
'Spring2020

Option Strict On
Option Explicit On

Module Module1
    Dim number1 As String
    Dim number2 As String
    Dim operation As String
    Sub Main()


        Console.WriteLine("Welcome, pick a first number ")
        number1 = Console.ReadLine()

        Console.WriteLine("please pick a second number")
        number2 = Console.ReadLine()

        Console.WriteLine("Would you like to add or multiply?")
        operation = Console.ReadLine()

        If operation = "multiply" Then
            Console.WriteLine(CInt(number1) * CInt(number2))
            Console.ReadLine()

        ElseIf operation = "add" Then
            Console.WriteLine(CInt(number1) + CInt(number2))
            Console.ReadLine()

        End If




    End Sub

End Module
