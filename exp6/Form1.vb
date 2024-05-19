Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim isPrime(100) As Boolean
        Dim primes As New List(Of Integer)

        For i As Integer = 2 To 100
            isPrime(i) = True
        Next

        For i As Integer = 2 To Math.Sqrt(100)
            If isPrime(i) Then
                For j As Integer = i * i To 100 Step i
                    isPrime(j) = False
                Next
            End If
        Next

        For i As Integer = 2 To 100
            If isPrime(i) Then
                primes.Add(i)
            End If
        Next

        For Each prime In primes
            ListBox1.Items.Add(prime)
        Next
    End Sub
End Class
