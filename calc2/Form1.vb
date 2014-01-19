Public Class Form1
    Dim calculatrice As New Engine
    Private Function Add(ByRef input As String)
        Dim str As String
        str = calculatrice.Add(input)
        If str Is Nothing Then
            Return False
        End If
        TextBox1.Text = str
        Return True
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add("1")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Add("7")
    End Sub

    Private Sub button0(sender As Object, e As EventArgs) Handles Button10.Click
        Add("0")
    End Sub

    Private Sub dotbutton(sender As Object, e As EventArgs) Handles Button11.Click
        Add(".")
    End Sub

    Private Sub button_equal(sender As Object, e As EventArgs) Handles Button18.Click
        Add("=")
    End Sub

    Private Sub clear_all(sender As Object, e As EventArgs) Handles Button17.Click

    End Sub

    Private Sub square(sender As Object, e As EventArgs) Handles Button16.Click
        Add("S")
    End Sub

    Private Sub divide(sender As Object, e As EventArgs) Handles Button15.Click
        Add("/")
    End Sub

    Private Sub multiply(sender As Object, e As EventArgs) Handles Button14.Click
        Add("*")
    End Sub

    Private Sub minus(sender As Object, e As EventArgs) Handles Button13.Click
        Add("-")
    End Sub

    Private Sub plus(sender As Object, e As EventArgs) Handles Button12.Click
        Add("+")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Add("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Add("3")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Add("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Add("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Add("6")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Add("8")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Add("9")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
