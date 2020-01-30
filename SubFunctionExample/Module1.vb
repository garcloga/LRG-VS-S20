
Option Strict On
Option Explicit On


Module Module1

    Sub Main()
        Dim mynumber As Integer
        mynumber = 7
        Console.WriteLine("In sub MainSub")
        Console.WriteLine(mynumber)
        MySub()
    End Sub

    Sub MySub()
        Dim mynumber As Integer
        mynumber = 8
        Console.WriteLine("In sub MySub")
        Console.WriteLine(mynumber)
        Console.ReadLine()
        Main()
    End Sub

    Function MyFunc() As Integer
        Console.WriteLine("In Function MyFunc")
        Return 0
        Console.ReadLine()
    End Function

End Module
