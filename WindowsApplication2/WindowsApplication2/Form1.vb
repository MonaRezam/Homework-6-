Public Class Form1
    Dim name, middle, M, A As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        name = " Mona Mohammed Rezam"
        middle = name.Substring(5, 8)
        TextBox4.Text = middle
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        M = TextBox1.Text
        Dim Cleanstr As String
        Cleanstr = name.Remove(14, 5)
        TextBox4.Text = Cleanstr
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        A = TextBox2.Text
        Dim newstr As String
        newstr = name.Insert(0, "Toto ")
        TextBox4.Text = newstr
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Text = "Mona"
        TextBox2.Text = " Mohammed "
        TextBox1.Text = "Rezam"
    End Sub
End Class
