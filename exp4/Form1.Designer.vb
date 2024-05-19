<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.areaButton = New System.Windows.Forms.Button()
        Me.volumeButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radiusTextBox = New System.Windows.Forms.TextBox()
        Me.heightTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'areaButton
        '
        Me.areaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.areaButton.Location = New System.Drawing.Point(157, 214)
        Me.areaButton.Name = "areaButton"
        Me.areaButton.Size = New System.Drawing.Size(143, 52)
        Me.areaButton.TabIndex = 0
        Me.areaButton.Text = "Find Area"
        Me.areaButton.UseVisualStyleBackColor = True
        '
        'volumeButton
        '
        Me.volumeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volumeButton.Location = New System.Drawing.Point(378, 214)
        Me.volumeButton.Name = "volumeButton"
        Me.volumeButton.Size = New System.Drawing.Size(143, 52)
        Me.volumeButton.TabIndex = 1
        Me.volumeButton.Text = "Find Volume"
        Me.volumeButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Radius"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Height"
        '
        'radiusTextBox
        '
        Me.radiusTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiusTextBox.Location = New System.Drawing.Point(304, 113)
        Me.radiusTextBox.Name = "radiusTextBox"
        Me.radiusTextBox.Size = New System.Drawing.Size(217, 26)
        Me.radiusTextBox.TabIndex = 4
        '
        'heightTextBox
        '
        Me.heightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heightTextBox.Location = New System.Drawing.Point(304, 157)
        Me.heightTextBox.Name = "heightTextBox"
        Me.heightTextBox.Size = New System.Drawing.Size(217, 26)
        Me.heightTextBox.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.heightTextBox)
        Me.Controls.Add(Me.radiusTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.volumeButton)
        Me.Controls.Add(Me.areaButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents areaButton As Button
    Friend WithEvents volumeButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents radiusTextBox As TextBox
    Friend WithEvents heightTextBox As TextBox
End Class
