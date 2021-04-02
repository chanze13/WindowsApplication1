Public Class RentalsForm
    'Displays "Display Studio" From Menustrip
    Private Sub DisplayStudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayStudioToolStripMenuItem.Click
        DisplayStudioForm.ShowDialog()
    End Sub
    'Displays "Display Video" From Menustrip
    Private Sub DisplayVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayVideoToolStripMenuItem.Click
        DisplayVideoForm.ShowDialog()
    End Sub
    'Exits Program
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub
    'Displays "About" From Menustrip
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub
End Class