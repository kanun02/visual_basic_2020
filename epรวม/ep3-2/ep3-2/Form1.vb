Public Class Form1
    Dim bird As Short
    Dim insects As Integer
    Dim worldpop As Long
    Dim price As String
    Dim FullName As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Short")
        ListBox1.Items.Add("Integer")
        ListBox1.Items.Add("Long")
        ListBox1.Items.Add("String")
        ListBox1.Items.Add("FullName")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                bird = 12500
                Label3.Text = bird
            Case 1
                insects = 37500000
                Label3.Text = insects
            Case 2
                worldpop = 899.99
                Label3.Text = worldpop
            Case 3
                price = "kanun"
                Label3.Text = price
            Case 4
                FullName = "กนกพร นิลน้ำคำ"
                Label3.Text = FullName
        End Select
    End Sub
End Class
