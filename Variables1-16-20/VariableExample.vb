'Logan Garcia
'RCET0265
'Spring2020
'Variable Example

Option Strict Off

'Module names are PascalCase (Upper camelCase)

Module VariableExample

    'Methods (SubRoutines and Functions) are PascalCase

    Sub Main()

        'name variables in camelCase
        Dim appleCount As Integer
        Dim fruitName As String

        fruitName = "Apples" & "Banana"
        Console.WriteLine(fruitName)

        appleCount = 4
        Console.WriteLine("you have " & appleCount & " " & fruitName & "!")

    End Sub

End Module
