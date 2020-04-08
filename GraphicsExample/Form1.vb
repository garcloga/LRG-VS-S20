Public Class GraphicsForm
    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub drawLine()
        '    'create graphics object 
        '    Dim graph As Graphics
        '    graph = Me.CreateGraphics

        '    'constructor for pen object
        '    Dim myPen As New Pen(Color.Black)
        '    'choosing start and end coordinates for the line
        '    graph.DrawLine(myPen, 10, 10, 200, 200)
        '    'freeing up resources
        '    myPen.Dispose()
        '    graph.Dispose()

    End Sub

    Private Sub GraphicsForm_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        ' drawLine()
    End Sub

    Private Sub GraphicsForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = "x:" & e.X & "y:" & e.Y & "Mouse Button:" & e.Button.ToString
        'create graphics object 
        Dim graph As Graphics
        graph = Me.CreateGraphics

        'constructor for pen object
        Dim myPen As New Pen(Color.Black)

        Static Dim oldX As Integer
        Static Dim oldY As Integer


        If e.Button.ToString = "Left" Then
            graph.DrawLine(myPen, oldX, oldY, e.X, e.Y)
        ElseIf e.Button.ToString = "Right" Then
            graph.Clear(Color.Gray)
        End If


        oldX = e.X
        oldY = e.Y

        'freeing up resources
        myPen.Dispose()
        graph.Dispose()

    End Sub

End Class
