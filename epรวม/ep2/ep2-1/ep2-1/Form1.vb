Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FirstName As String
        FirstName = "kanokporn"
        Label1.Text = FirstName
        FirstName = "Nilnumkham"
        Label2.Text = FirstName
        FirstName = "kanun"
        Label3.Text = FirstName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim prompt, FullName As String
        prompt = "กรุณาป้อนชื่อและนามสกุล"
        FullName = InputBox(prompt)
        Label1.Text = FullName

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim prompt, FullName As String
        prompt = "กรุณาป้อนชื่อและนามสกุล"
        FullName = InputBox(prompt)
        MsgBox(FullName, , "ชื่อและนามสกุล")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class
