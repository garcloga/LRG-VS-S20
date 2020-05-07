
'Logan Garcia
'RCET0265
'Spring 2020
'Stan's Grocery
'https://github.com/garcloga/LRG-VS-S20

Option Strict On
Option Explicit On

Public Class StansGroceryForm
    Dim Myarray(2, 4) As String
    Dim aisle As Integer = 0
    Dim item As Integer = 0

    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim file As String = "C:\Users\garcl\OneDrive\Documents\Visual Studio Class Projects\LRG-VS-S20\StansGrocery\StansGrocery\Grocery Item List.txt" 'File Location
        FileOpen(1, file, OpenMode.Input) 'Open's File
        Do While Not EOF(1)
            Myarray(aisle, item) = LineInput(1)
            SelectedItemBox.Items.Add(Myarray(aisle, item))
            If item < 4 Then
                item = item + 1
            ElseIf item = 4 Then
                item = 0
                aisle = aisle + 1
            End If
        Loop
        FileClose()
    End Sub

    Private Sub AboutTopMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTopMenuItem.Click
        MsgBox("GUI: Tim Rossitor" & vbNewLine & "Program: Logan Garcia" & vbNewLine & "Version 0.1")
    End Sub

    Private Sub SelectedItemBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectedItemBox.SelectedIndexChanged
        Dim find As Boolean
        find = True
        aisle = 0
        item = 0
        DisplayListBox.Items.Clear()
        Do While find = True 'Searches the Array
            If SelectedItemBox.Text = Myarray(aisle, item) Then
                find = False
                DisplayListBox.Items.Add("You will find " & Myarray(aisle, item) & " on aisle #" & (aisle + 1) & ", item #" & (item + 1))
            ElseIf item < 4 Then
                item = item + 1
            ElseIf item = 4 Then
                item = 0
                aisle = aisle + 1
            ElseIf aisle > 4 Then
                find = False
                MsgBox("Item was not found, try agian.")
            End If
        Loop
    End Sub

    Private Sub LookUpItemTextBox_TextChanged(sender As Object, e As EventArgs) Handles LookUpItemTextBox.TextChanged
        'Drop down menu
        If LookUpItemTextBox.Text = "" Then
            SelectedItemBox.Enabled = True
        Else
            SelectedItemBox.Enabled = False
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim find As Boolean
        find = True
        aisle = 0
        item = 0
        DisplayListBox.Items.Clear()
        Do While find = True 'Search the array
            Try
                If LookUpItemTextBox.Text = "" Then
                    find = False
                    MsgBox("Please enter a search or select from the dropdown.")
                ElseIf LCase(LookUpItemTextBox.Text) = "zzz" Then
                    find = False
                    Me.Close()
                ElseIf LCase(LookUpItemTextBox.Text) = LCase(Myarray(aisle, item)) Then
                    find = False
                    DisplayListBox.Items.Add("You will find " & Myarray(aisle, item) & " on aisle #" & (aisle + 1) & ", item #" & (item + 1))
                ElseIf item < 4 Then
                    item = item + 1
                ElseIf item = 4 Then
                    item = 0
                    aisle = aisle + 1
                ElseIf aisle > 4 Then
                    find = False
                    MsgBox("Item not found!")
                End If
            Catch ex As Exception
                find = False
                MsgBox("Item not found!")
                LookUpItemTextBox.Text = ""
            End Try
        Loop
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
