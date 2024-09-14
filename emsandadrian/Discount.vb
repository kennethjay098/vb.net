Public Class Discount
    Private Sub ButtonSubTotal_Click(sender As Object, e As EventArgs) Handles ButtonSubTotal.Click
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        TextBox3.Text = Val(TextBox3.Text) - (0.2 * Val(TextBox3.Text))
    End Sub

    Private Sub ButtonChange_Click(sender As Object, e As EventArgs) Handles ButtonChange.Click
        TextBox5.Text = Val(TextBox4.Text) - Val(TextBox3.Text)
    End Sub
End Class