Public Class Form1
    Public counter As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        counter = counter + 1
        If counter <= 3 Then
            TextBox1.Text = "Hello Label!"
        ElseIf counter <= 6 Then
            TextBox1.Text = "Okay thats enough label."
        ElseIf counter = 7 Then
            TextBox1.Text = "Okay thats enough label.."
        ElseIf counter = 8 Then
            TextBox1.Text = "Okay thats enough label..."
        Else
            TextBox1.Text = "Take that!"
            Label1.Text = "Ughhhh. I got stabbed"
        End If
    End Sub
End Class
