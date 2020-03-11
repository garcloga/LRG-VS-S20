'Logan Garcia
'RCET0265
'Spring2020
'Roll Of The Dice
'https://github.com/garcloga/LRG-VS-S20



Module Module1
    'Assigning variables
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

    Sub Main()
        'Creating an array
        Dim StoredValues = New Integer(1, 12) {{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}, {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}}

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
        Static Dim v As Integer = StoredValues(1, 12)
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

        'Displaying the code in the console
        Console.WriteLine("Two" & "             " & StoredValues(1, 2))
        Console.WriteLine("Three" & "            " & StoredValues(1, 3))
        Console.WriteLine("Four" & "            " & StoredValues(1, 4))
        Console.WriteLine("Five" & "            " & StoredValues(1, 5))
        Console.WriteLine("Six" & "             " & StoredValues(1, 6))
        Console.WriteLine("Seven" & "           " & StoredValues(1, 7))
        Console.WriteLine("Eight" & "            " & StoredValues(1, 8))
        Console.WriteLine("Nine" & "            " & StoredValues(1, 9))
        Console.WriteLine("Ten" & "             " & StoredValues(1, 10))
        Console.WriteLine("Eleven" & "          " & StoredValues(1, 11))
        Console.WriteLine("Twelve" & "          " & StoredValues(1, 12))
        Console.WriteLine()
        Console.WriteLine("Total" & "           " & Total)

        Console.ReadLine()
    End Sub

End Module
