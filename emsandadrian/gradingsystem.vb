Public Class gradingsystem
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox13.Text)
        TextBox1.Text = Val(TextBox1.Text) / 8
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox13.Text = Val(TextBox9.Text) + Val(TextBox10.Text) + Val(TextBox11.Text) + Val(TextBox12.Text)
        TextBox13.Text = Val(TextBox13.Text) / 4
    End Sub
End Class