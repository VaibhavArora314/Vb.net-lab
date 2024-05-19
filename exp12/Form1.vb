Imports System.IO
Imports System.Runtime.InteropServices.ComTypes

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Specify the file path
            Dim filePath As String = TextBox1.Text

            ' Open the file for writing (if the file does not exist, it will be created)
            Using writer As StreamWriter = New StreamWriter(filePath, True)
                ' Write data to the file
                writer.WriteLine(RichTextBox1.Text)
            End Using

            MessageBox.Show("Data written to file successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error writing to file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
