Public Class Form1
    Dim root1, root2, a, b, c As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        b = TextBox1.Text
        a = TextBox1.Text
        c = TextBox3.Text

        root1 = (b * b) - (4 * (a * c))
        root2 = Math.Sqrt(root1)

        Label4.Text = root1
        Label5.Text = root2

    End Sub
End Class
