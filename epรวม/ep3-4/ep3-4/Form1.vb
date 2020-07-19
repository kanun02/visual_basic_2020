Public Class Form1
    Dim Price, Num, tel, jai, sudti As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Price = TextBox1.Text
        Num = TextBox2.Text
        tel = Price * Num
        Label4.Text = tel

        jai = TextBox3.Text
        sudti = jai - tel
        Label7.Text = sudti
    End Sub
End Class
