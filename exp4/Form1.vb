Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub areaButton_Click(sender As Object, e As EventArgs) Handles areaButton.Click
        Try
            Dim radius As Double = Double.Parse(radiusTextBox.Text)
            Dim area As Double = 3.14 * radius * radius

            MessageBox.Show("Area of the circle with radius " + radius.ToString() + " is " + area.ToString())
        Catch ex As Exception
            MessageBox.Show("Please enter a valid number for the radius.")
        End Try
    End Sub

    Private Sub volumeButton_Click(sender As Object, e As EventArgs) Handles volumeButton.Click
        Try
            Dim radius As Double = Double.Parse(radiusTextBox.Text)
            Dim height As Double = Double.Parse(heightTextBox.Text)

            Dim baseArea As Double = 3.14 * radius * radius
            Dim volume As Double = baseArea * height

            MessageBox.Show("Volume of the cylinder with radius " + radius.ToString() + " and height " + height.ToString() + " is " + volume.ToString())
        Catch ex As Exception
            MessageBox.Show("Please enter a valid number for the radius and height.")
        End Try
    End Sub
End Class
