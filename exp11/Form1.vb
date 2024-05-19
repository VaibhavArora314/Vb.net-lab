Imports System
Imports System.IO
Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows.Forms

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Specify the file path
            Dim filePath As String = TextBox1.Text

            ' Read all text from the text file
            Dim text As String = File.ReadAllText(filePath)

            ' Display the text in a label
            RichTextBox1.Text = text
        Catch ex As Exception
            MessageBox.Show("Error reading from file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
