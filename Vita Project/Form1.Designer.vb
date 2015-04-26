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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.digitInputLabel = New System.Windows.Forms.Label()
        Me.creditCardNumLabel = New System.Windows.Forms.Label()
        Me.creditCardButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.finalCreditCardNumLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(116, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 66)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'digitInputLabel
        '
        Me.digitInputLabel.AutoSize = True
        Me.digitInputLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.digitInputLabel.Location = New System.Drawing.Point(27, 119)
        Me.digitInputLabel.Name = "digitInputLabel"
        Me.digitInputLabel.Size = New System.Drawing.Size(126, 13)
        Me.digitInputLabel.TabIndex = 1
        Me.digitInputLabel.Text = "&Enter first four digits:"
        '
        'creditCardNumLabel
        '
        Me.creditCardNumLabel.AutoSize = True
        Me.creditCardNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creditCardNumLabel.Location = New System.Drawing.Point(27, 160)
        Me.creditCardNumLabel.Name = "creditCardNumLabel"
        Me.creditCardNumLabel.Size = New System.Drawing.Size(118, 13)
        Me.creditCardNumLabel.TabIndex = 2
        Me.creditCardNumLabel.Text = "Credit card number:"
        '
        'creditCardButton
        '
        Me.creditCardButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creditCardButton.Location = New System.Drawing.Point(30, 216)
        Me.creditCardButton.Name = "creditCardButton"
        Me.creditCardButton.Size = New System.Drawing.Size(138, 23)
        Me.creditCardButton.TabIndex = 3
        Me.creditCardButton.Text = "&Credit Card Number "
        Me.creditCardButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(190, 216)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(92, 23)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(160, 119)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.inputTextBox.TabIndex = 5
        '
        'finalCreditCardNumLabel
        '
        Me.finalCreditCardNumLabel.AutoSize = True
        Me.finalCreditCardNumLabel.Location = New System.Drawing.Point(160, 160)
        Me.finalCreditCardNumLabel.Name = "finalCreditCardNumLabel"
        Me.finalCreditCardNumLabel.Size = New System.Drawing.Size(0, 13)
        Me.finalCreditCardNumLabel.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(345, 313)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.finalCreditCardNumLabel)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.creditCardButton)
        Me.Controls.Add(Me.creditCardNumLabel)
        Me.Controls.Add(Me.digitInputLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Vita Credit"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents digitInputLabel As System.Windows.Forms.Label
    Friend WithEvents creditCardNumLabel As System.Windows.Forms.Label
    Friend WithEvents creditCardButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents inputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents finalCreditCardNumLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
