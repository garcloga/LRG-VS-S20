Module Module1

    Sub Main()
        For j = 1 To 2
            Console.WriteLine(Timer)
            For i = 1 To 10
                Randomize()
                Console.WriteLine(Str(Rnd()) & "            " & Str(Timer))
            Next
        Next
        Console.ReadLine()

    End Sub

End Module
