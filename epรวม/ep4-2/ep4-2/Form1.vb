Public Class Form1
    Dim Username As String
    Dim Password As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String
        Username = InputBox("กรุณาป้อนชื่อของคุณ")
        Password = InputBox("กรุณาใส่รหัสผ่านของคุณ")
        If Username = "แกงส้ม" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-15\Desktop\All_Images\All_Images/photo04.jpg")
        ElseIf Username = "กนกพร" And Password = "1111" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-15\Desktop\งาน/25.jpg")
        ElseIf Username = "เต่า" And Password = "2222" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-15\Desktop\งาน/26.jpg")
        ElseIf Username = "ตาล" And Password = "333" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-15\Desktop\งาน/36.jpg")
        Else
            MsgBox("ไม่มีชื่อคุณในระบบ")
        End If
    End Sub
End Class
