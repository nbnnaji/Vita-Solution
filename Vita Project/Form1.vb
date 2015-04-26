'Nkechi B. Nnaji
'Final Project
'Chapter 10: Vita Credit (Determining the fifth digit of a credit card)
'Date: April 26, 2015

Public Class Form1

    Dim userInput As String
    Dim firstDigit As Integer
    Dim secondDigit As Integer
    Dim thirdDigit As Integer
    Dim fourthDigit As Integer
    Dim sumOfDigits As Integer

    Dim lastDigit As Integer

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub creditCardButton_Click(sender As Object, e As EventArgs) Handles creditCardButton.Click

        'Assigning credit card number user enters in inputTextBox to userInput variable
        userInput = inputTextBox.Text

        If userInput.Length > 4 Then
            MessageBox.Show("Enter Only 4 Digits.", "Invalid Credit Card Number", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf userInput.Length < 4 Then
            MessageBox.Show("Enter Only 4 Digits.", "Invalid Credit Card Number", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf userInput.Length = 4 Then

            Integer.TryParse(userInput.Substring(0, 1), firstDigit)
            Integer.TryParse(userInput.Substring(1, 1), secondDigit)
            Integer.TryParse(userInput.Substring(2, 1), thirdDigit)
            Integer.TryParse(userInput.Substring(3, 1), fourthDigit)

            sumOfDigits = (secondDigit * 2) + (fourthDigit * 2) + firstDigit + thirdDigit

            lastDigit = sumOfDigits Mod 10

            finalCreditCardNumLabel.Text = userInput + lastDigit.ToString

        End If



    End Sub
End Class
