Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.PasswordChar = "*"c
        If TextBox1.Text = "kennetharvin" And TextBox2.Text = "123" Then
            Form2.Show()
        Else
            MsgBox("your Password is incorrect or your username", MsgBoxStyle.Exclamation, "login Error")
            Me.Close()
        End If
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub


End Class
