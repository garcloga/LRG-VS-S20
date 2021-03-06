﻿
'Logan Garcia
'RCT0265
'Math Contest

Option Explicit On
Option Strict On

Public Class Form1

    Public Number1 As Integer
    Public Number2 As Integer
    Public Operation As String
    Public CorrectAnswer As Integer
    Public ChildAnswer As Integer
    Public FilledOut As Boolean


    'This function is used to find the correct answer set by the teacher
    Sub OperationSelect()

        If AddButton.Checked = True Then
            CorrectAnswer = CInt(Int(FirstNumberTextbox.Text)) + CInt(Int(SecondNumberTextbox.Text))
            FormFilledOut()
        ElseIf SubtractButton.Checked = True Then
            CorrectAnswer = CInt(Int(FirstNumberTextbox.Text)) - CInt(Int(SecondNumberTextbox.Text))
            FormFilledOut()
        ElseIf MultiplyButton.Checked = True Then
            CorrectAnswer = CInt(Int(FirstNumberTextbox.Text)) * CInt(Int(SecondNumberTextbox.Text))
            FormFilledOut()
        ElseIf DivideButton.Checked = True Then
            CorrectAnswer = CInt(Int(FirstNumberTextbox.Text)) \ CInt(Int(SecondNumberTextbox.Text))
            FormFilledOut()
        Else
            MsgBox("Please Choose An Operator")

        End If

    End Sub

    Sub FormFilledOut()
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
            FilledOut = True
            notice()
        End If
    End Sub



    Sub notice()
        If ChildAnswer = CorrectAnswer Then
            MsgBox("Correct! The answer is " & CorrectAnswer & "!")
        ElseIf ChildAnswer <> CorrectAnswer Then
            MsgBox("Incorrect, the correct answer is " & CorrectAnswer & "!")
        End If
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        OperationSelect()
    End Sub
End Class

