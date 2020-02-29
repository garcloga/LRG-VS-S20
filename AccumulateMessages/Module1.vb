'Logan Garcia
'RCET0265
'Accumulate Messages Program
'Spring 2020
'https://github.com/garcloga/LRG-VS-S20 

Module Module1

    Sub Main()

        Console.WriteLine(UserMessages(True, "hello", False))
        Console.WriteLine(UserMessages(True, "hello 2", False))
        Console.WriteLine(UserMessages(True, "hello 3", False))
        MsgBox(UserMessages(True, "", False))

    End Sub

    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean)

        Static formattedMessages As String = ""
        formattedMessages &= message & vbNewLine
        Return formattedMessages

    End Function

End Module
