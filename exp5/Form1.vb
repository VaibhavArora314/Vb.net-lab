Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim num As Integer = Integer.Parse(TextBox1.Text)
            If (num <= 1) Then
                MessageBox.Show(num.ToString() + " is not a prime number.")
            Else
                For i As Integer = 2 To num - 1
                    If num Mod i = 0 Then
                        MessageBox.Show(num.ToString() + " is not a prime number.")
                        Return
                    End If
                Next
                MessageBox.Show(num.ToString() + " is a prime number.")
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Number")
        End Try
    End Sub
End Class
