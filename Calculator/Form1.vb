Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Dim num1, num2 As Integer
    Dim operation As String
    Dim total As String
    Dim result As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button0.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub Button_Plus_Click(sender As Object, e As EventArgs) Handles Button_Plus.Click
        operation = "+"
        num1 = Integer.Parse(TextBox1.Text)
        TextBox1.Clear()
    End Sub

    Private Sub Button_Minus_Click(sender As Object, e As EventArgs) Handles Button_Minus.Click
        operation = "-"
        num1 = Integer.Parse(TextBox1.Text)
        TextBox1.Clear()
    End Sub

    Private Sub Button_Multiply_Click(sender As Object, e As EventArgs) Handles Button_Multiply.Click
        operation = "*"
        num1 = Integer.Parse(TextBox1.Text)
        TextBox1.Clear()
    End Sub

    Private Sub Button_Divide_Click(sender As Object, e As EventArgs) Handles Button_Divide.Click
        operation = "/"
        num1 = Integer.Parse(TextBox1.Text)
        TextBox1.Clear()
    End Sub

    Private Sub Button_Equal_Click(sender As Object, e As EventArgs) Handles Button_Equal.Click
        num2 = Integer.Parse(TextBox1.Text)

        If operation = "+" Then
            result = num1 + num2
        End If
        If operation = "-" Then
            result = num1 - num2
        End If
        If operation = "*" Then
            result = num1 * num2
        End If

        If operation = "/" Then
            If num2 <> 0 Then
                result = num1 / num2
            Else
                TextBox1.Text = "division by zero not possible, click clr button to restart"
                Return
            End If
        End If
        If operation = "^" Then
            result = Math.Pow(num1, num2)
        End If
        total = result.ToString()
        TextBox1.Text = total + ""
    End Sub

    Private Sub Button_Clr_Click(sender As Object, e As EventArgs) Handles Button_Clr.Click
        TextBox1.Clear()
    End Sub

    Private Sub ButtonPlusMinus_Click(sender As Object, e As EventArgs) Handles ButtonPlusMinus.Click
        operation = "+/-"
        num1 = Integer.Parse(TextBox1.Text)
        result = -num1
        total = result.ToString()
        TextBox1.Text = total + ""
    End Sub

    Private Sub ButtonSqrt_Click(sender As Object, e As EventArgs) Handles ButtonSqrt.Click
        operation = "sqrt"
        num1 = Integer.Parse(TextBox1.Text)
        If num1 < 0 Then
            TextBox1.Text = "sqrt of negetive numbers not allowed, click clr button to restart"
        Else
            result = Math.Sqrt(num1)
            total = result.ToString()
            TextBox1.Text = total + ""
        End If
    End Sub

    Private Sub ButtonExponent_Click(sender As Object, e As EventArgs) Handles ButtonExponent.Click
        operation = "^"
        num1 = Integer.Parse(TextBox1.Text)
        TextBox1.Clear()
    End Sub

    Private Sub ButtonAbs_Click(sender As Object, e As EventArgs) Handles ButtonAbs.Click
        operation = "abs"
        num1 = Integer.Parse(TextBox1.Text)
        If num1 < 0 Then
            result = -num1
        Else
            result = num1
        End If
        total = result.ToString()
        TextBox1.Text = total + ""
    End Sub
End Class