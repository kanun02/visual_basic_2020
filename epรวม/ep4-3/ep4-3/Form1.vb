Public Class Form1
    Dim price, num, total As String
    Dim steam As Byte
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        price = TextBox1.Text
        num = TextBox2.Text
        total = price * num
        Label5.Text = total
        steam = total / 50
        Label6.Text = steam
    End Sub
End Class
