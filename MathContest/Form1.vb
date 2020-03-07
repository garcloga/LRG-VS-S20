Public Class Form1

    Public Number1 As Integer
    Public Number2 As Integer
    Public Operation As String
    Public CorrectAnswer As Integer
    Public ChildAnswer As Integer
    Public FilledOut As Boolean


    'This function is used to find the correct answer set by the teacher


    Sub OperationSelect()
        Number1 = Int(FirstNumberTextbox.Text)
        Number2 = Int(SecondNumberTextbox.Text)
        If AddButton.Checked = True Then
            CorrectAnswer = Number1 + Number2
            CompleteForm()
        ElseIf SubtractButton.Checked = True Then
            CorrectAnswer = Number1 - Number2
            CompleteForm()
        ElseIf MultiplyButton.Checked = True Then
            CorrectAnswer = Number1 * Number2
            CompleteForm()
        ElseIf DivideButton.Checked = True Then
            CorrectAnswer = Number1 \ Number2
            CompleteForm()
        Else
            MsgBox("Please Choose An Operator")

        End If


    End Sub

    Sub CompleteForm()
        If NameTextbox.Text = "" Then
            MsgBox("Please Fill In The Info")
            FilledOut = False
        ElseIf GradeTextbox.Text = "" Then
            MsgBox("Please Fill In The Info")
            FilledOut = False
        ElseIf AgeTextbox.Text = "" Then
            MsgBox("Please Fill In The Info")
            FilledOut = False
        ElseIf StudentAnswerTextbox.Text = "" Then
            MsgBox("Please Fill In The Info")
            FilledOut = False
        ElseIf FirstNumberTextbox.Text = "" Then
            MsgBox("Please Fill In The Info")
            FilledOut = False
        ElseIf SecondNumberTextbox.Text = "" Then
            MsgBox("Please Fill In The Info")
            FilledOut = False
        Else
            MsgBox(CorrectAnswer)
        End If
    End Sub


    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        OperationSelect()
    End Sub
End Class

