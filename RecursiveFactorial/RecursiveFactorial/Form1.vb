#Region "Gago"
Public Class FactorialCalculator
    Private Sub calculateBtn_Click(sender As Object, e As EventArgs) Handles calculateBtn.Click
        Dim number As Integer
        If Integer.TryParse(factorialTxtbox.Text, number) AndAlso number >= 0 Then
            Dim result As Long = FactorialRecursive(number)
            answerLbl.Text = $"The factorial of {number} is {result}"
        Else
            answerLbl.Text = "Please enter a valid non-negative integer."
        End If
    End Sub

    Private Function FactorialRecursive(ByVal n As Integer) As Long
        If n <= 1 Then
            Return 1
        Else
            Return n * FactorialRecursive(n - 1)
        End If
    End Function
End Class
#End Region
