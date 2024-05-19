Imports System.Security.Cryptography

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim num As Long = Long.Parse(numTextBox.Text)
            Dim den As Long = Long.Parse(denTextBox.Text)

            If den = 0 Then
                Throw New DivideByZeroException()
            End If

            Dim res As Long = num / den
            MessageBox.Show("Result is " + res.ToString())

        Catch ex As DivideByZeroException
            ' Specific handling for divide by zero exception
            MessageBox.Show("Denominator cannot be 0. Please enter a non-zero value.")

        Catch ex As Exception
            ' General exception handling
            MessageBox.Show("An error occurred: " + ex.Message)
        End Try
    End Sub
End Class
