Public Class Form1

    Public Number1 As Integer
    Public Number2 As Integer
    Public Operation As String
    Public CorrectAnswer As Integer
    Public ChildAnswer As Integer


    'This function is used to find the correct answer set by the teacher
    Function calculator()

        If AddButton.Checked = True Then
            CorrectAnswer = Number1 + Number2
        End If

        If SubtractButton.Checked = True Then
            CorrectAnswer = Number1 - Number2
        End If

        If MultiplyButton.Checked = True Then
            CorrectAnswer = Number1 * Number2
        End If

        If DivideButton.Checked = True Then
            CorrectAnswer = Number1 / Number2
        End If
    End Function

End Class

