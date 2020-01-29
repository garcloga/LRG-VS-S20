'Logan Garcia
'RCET0265
'Spring2020

Option Strict On
Option Explicit On

Module Module1
    Dim number1 As String
    Dim number2 As String
    Dim operation As String
    Dim quitProgram As String

    Sub Main()
        Do While True

            Console.WriteLine("Welcome, pick a first number ")
            number1 = Console.ReadLine()

            Console.WriteLine("please pick a second number")
            number2 = Console.ReadLine()

            Console.WriteLine("Would you like to add or multiply?")
            operation = Console.ReadLine()

            If operation = "multiply" Then
                Console.WriteLine(CInt(number1) * CInt(number2))
                Console.ReadLine()
                Try
                    Console.WriteLine(CInt(number1) * CInt(number2))
                Catch ex As Exception
                    Console.WriteLine("Please enter a whole number")

                End Try


            ElseIf operation = "add" Then
                Console.WriteLine(CInt(number1) + CInt(number2))
                Console.ReadLine()
                Try
                    Console.WriteLine(CInt(number1) + CInt(number2))
                Catch ex As Exception
                    Console.WriteLine("Please enter a whole number")

                End Try

            End If

            Console.Clear()
        Loop



    End Sub

End Module
