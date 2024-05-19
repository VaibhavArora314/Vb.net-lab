Imports System.Reflection.Emit

Public Class Form1
    Dim largest As Integer = -1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num = Integer.Parse(TextBox1.Text)
        If (num > largest) Then largest = num

        ListBox1.Items.Add(num.ToString())
        Label1.Text = "Largest no is " + largest.ToString()
    End Sub
End Class
