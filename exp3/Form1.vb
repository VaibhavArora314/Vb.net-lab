Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim number As Integer = Integer.Parse(TextBox1.Text)
            Dim factorial As Double = 1

            ' Calculate factorial
            For i As Integer = 1 To number
                factorial *= i
            Next

            Label1.Text = "Factorial of " & number.ToString() & " is " & factorial.ToString()
        Catch
            Label1.Text = ("Please enter a valid number.")
        End Try

    End Sub
End Class
