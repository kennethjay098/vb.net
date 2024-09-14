Public Class Form2
    Private Sub NewFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFileToolStripMenuItem.Click
        Dim newForm As New Form2()
        newForm.Show()
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog()
        OpenFileDialog.Title = "Open File"
        OpenFileDialog.Filter = "TextFiles(*.+x+)|*.txt|ALL Files(*.*)|*.*"

        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            Dim FilePath As String = OpenFileDialog.FileName

            MessageBox.Show("SelectedFile:" & FilePath)
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog()
        SaveFileDialog.Title = "Save File"
        SaveFileDialog.Filter = "TextFiles(*.+x+)|*.txt|ALL Files(*.*)|*.*"

        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim FilePath As String = SaveFileDialog.FileName

            MessageBox.Show("SelectedFile:" & FilePath)
        End If
    End Sub

    Private Sub DosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DosToolStripMenuItem.Click
        Pos.Show()
    End Sub

    Private Sub DiscoutnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscoutnToolStripMenuItem.Click
        Discount.Show()
    End Sub

    Private Sub ButtonGradingSystem_Click(sender As Object, e As EventArgs) Handles ButtonGradingSystem.Click
        gradingsystem.Show()
    End Sub

    Private Sub KennethJayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KennethJayToolStripMenuItem.Click
        view1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ArvinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArvinToolStripMenuItem.Click
        view2.Show()
    End Sub
End Class