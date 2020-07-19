Public Class Form1
    Dim FirstNum, SeconNum, Result As Double

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FirstNum = TextBox1.Text
        SeconNum = TextBox2.Text
        If RadioButton1.Checked = True Then
            Result = FirstNum + SeconNum
        ElseIf RadioButton2.Checked = True Then
            Result = FirstNum - SeconNum
        ElseIf RadioButton3.Checked = True Then
            Result = FirstNum * SeconNum
        ElseIf RadioButton4.Checked = True Then
            Result = FirstNum / SeconNum
        ElseIf RadioButton5.Checked = True Then
            Result = FirstNum ^ SeconNum
        End If
        TextBox3.Text = Result
    End Sub
End Class
