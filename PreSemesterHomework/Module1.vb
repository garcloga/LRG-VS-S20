Module Module1
    Public factor As Int32
    Sub Main()
        factor = 1
        For i = 1 To 10
            factor = factor * i
            Console.WriteLine(factor)
        Next

        Console.ReadLine()
    End Sub

End Module
