'Logan Garcia
'Spring 2020
'RCET0265
'BetterCalculator
'https://github.com/garcloga/LRG-VS-S20


Option Strict On
Option Explicit On


Module Module1

    'Naming Variables
    Public entryOne As String
    Public entryTwo As String
    Public numberOne As Double
    Public numberTwo As Double
    Public operation As Double
    Public OperationEntry As String


    'Intro sub
    Sub Main()

        Console.WriteLine("Please enter two numbers. Enter " & """Q""" & " at any time to quit.")
        ChooseNumberOne()

    End Sub

    Sub ChooseNumberOne()

        Console.WriteLine("Choose a number")
        entryOne = Console.ReadLine()
        'Checking if a valid number was entered

        If entryOne = "Q" Then
            Console.WriteLine("You entered " & entryOne)
            Console.WriteLine("Have a nice day")
            Console.WriteLine("Press enter to close this window")
            Console.ReadLine()
            End

        ElseIf entryOne = "q" Then
            Console.WriteLine("You entered " & entryOne)
            Console.WriteLine("Have a nice day")
            Console.WriteLine("Press enter to close this window")
            Console.ReadLine()
            End

        End If


        Try

            numberOne = CInt(entryOne)

        Catch ex As Exception

            Console.WriteLine("You entered " & entryOne & " please enter a whole number")
            ChooseNumberOne()

        End Try

        'Returning the value the user entered
        Console.WriteLine("You entered " & numberOne)
        ChooseNumberTwo()

    End Sub

    Sub ChooseNumberTwo()

        Console.WriteLine("Choose a number")
        entryTwo = Console.ReadLine()

        If entryTwo = "Q" Then
            Console.WriteLine("You entered " & entryTwo)
            Console.WriteLine("Have a nice day")
            Console.WriteLine("Press enter to close this window")
            Console.ReadLine()
            End
        ElseIf entryTwo = "q" Then
            Console.WriteLine("You entered " & entryTwo)
            Console.WriteLine("Have a nice day")
            Console.WriteLine("Press enter to close this window")
            Console.ReadLine()
            End
        End If

        'Checking if a valid number was entered
        Try
            numberTwo = CInt(entryTwo)
        Catch ex As Exception
            Console.WriteLine("You entered " & entryTwo & " please enter a whole number")
            ChooseNumberTwo()
        End Try

        'Returning the value the user entered
        Console.WriteLine("You entered " & numberTwo)

        'Calling the Operations sub
        Operations()


    End Sub

    Sub Operations()

        'Writing the menu options to the user
        Console.WriteLine("Choose one of the following options:")
        Console.WriteLine("1. Add")
        Console.WriteLine("2. Subtract")
        Console.WriteLine("3. Multiply")
        Console.WriteLine("4. Divide")

        OperationEntry = Console.ReadLine()

        If OperationEntry = "Q" Then
            Console.WriteLine("You entered " & OperationEntry)
            Console.WriteLine("Have a nice day")
            Console.WriteLine("Press enter to close this window")
            Console.ReadLine()
            End
        ElseIf OperationEntry = "q" Then
            Console.WriteLine("You entered " & OperationEntry)
            Console.WriteLine("Have a nice day")
            Console.WriteLine("Press enter to close this window")
            Console.ReadLine()
            End
        End If

        Try
            operation = CInt(OperationEntry)
        Catch Q As Exception

            ChooseNumberOne()
        End Try

        'setting the operations to their assigned number values
        If operation = 1 Then
            Console.WriteLine("You Entered " & OperationEntry)
            Console.WriteLine(entryOne & " + " & entryTwo & " = " & numberOne + numberTwo)

        ElseIf operation = 2 Then
            Console.WriteLine("You Entered " & OperationEntry)
            Console.WriteLine(entryOne & " - " & entryTwo & " = " & numberOne - numberTwo)

        ElseIf operation = 3 Then
            Console.WriteLine("You Entered " & OperationEntry)
            Console.WriteLine(entryOne & " * " & entryTwo & " = " & numberOne * numberTwo)

        ElseIf operation = 4 Then
            Console.WriteLine("You Entered " & OperationEntry)
            Console.WriteLine(entryOne & " / " & entryTwo & " = " & numberOne / numberTwo)

        ElseIf operation > 4 Then
            Operations()
        End If

        'restarting the program
        Main()

    End Sub

End Module
