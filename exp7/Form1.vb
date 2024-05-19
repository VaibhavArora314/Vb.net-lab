Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rows As Integer = 4 ' Number of rows in the pyramid
        Dim number As Integer = 1
        Dim output As String = ""

        For i As Integer = 1 To rows
            output += Space((rows - i) * 10)

            For j As Integer = 1 To i
                output += number.ToString().PadRight(20)
                number += 1
            Next j

            output += vbCrLf
        Next i

        Label1.Text = output
    End Sub
End Class
