'Logan Garcia
'RCET0625
'Spring  2020

Option Explicit On
Option Strict On


Module Module1

    Sub Main()
        Dim name As String
        Dim Emily As String
        Dim Joe As String
        Dim Logan As String

        Emily = "Emily"
        Joe = "Joe"
        Logan = "Logan"

        Dim Other As Boolean
        Dim E As Boolean
        Dim J As Boolean
        Dim L As Boolean
        Other = True

        Console.WriteLine(" Hello fellow nerd! What is your name? ")

        name = Console.ReadLine


        If name = Emily Then
            E = True
            Other = False
            Console.WriteLine(" Welcome " & Emily & ",enjoy your stay!")
        End If

        If name = Joe Then
            J = True
            Other = False
            Console.WriteLine(" Welcome " & Joe & ",enjoy your stay!")
        End If

        If name = Logan Then
            L = True
            Other = False
            Console.WriteLine("Oh, the chosen one has finally arrived!")
        End If

        If Other = True Then
            Console.WriteLine(" You shouldnt be here! How did you find this place?")
        End If

        Console.ReadLine()
    End Sub

End Module
