Public Class Form1
    Private Sub txtInteger_TextChanged(sender As Object, e As EventArgs) Handles intNum.TextChanged
        ' Declare variables

        'Extract and turn into integers
        ' aNumber = Convert.ToInt32(intNum.Text)



    End Sub

    Private Sub btnDouble_Click(sender As Object, e As EventArgs) Handles btnDouble.Click
        ' Declare constants
        Const MULTIPLY_BY_TWO As Integer = 2
        'Const DIVIDE_BY_TWO As Double = 0.5

        ' Declare variables
        Dim doubleNumber As Double
        Dim totalNumber As Double

        ' Calculate
        doubleNumber = Val(intNum.Text)
        totalNumber = doubleNumber * MULTIPLY_BY_TWO

        MsgBox("The doubled number is " & totalNumber)

        ' Clear the box
        intNum.Text = ""

    End Sub

    Private Sub btnHalf_Click(sender As Object, e As EventArgs) Handles btnHalf.Click
        ' Declare constants
        Const DIVIDE_BY_TWO As Double = 0.5

        ' Declare variables
        Dim halfNumber As Double
        Dim totalNumber As Double

        ' Calculate
        halfNumber = Val(intNum.Text)
        totalNumber = halfNumber * DIVIDE_BY_TWO

        MsgBox("The halved number is " & totalNumber)

        ' Clear the box
        intNum.Text = ""

    End Sub
End Class
