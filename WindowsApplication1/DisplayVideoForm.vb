Public Class DisplayVideoForm
    'Hides Diables Display Studio on menu strip
    Private Sub DisplayVideoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayVideoToolStripMenuItem.Enabled = False

    End Sub
    'Displays "Display Studio" From Menustrip
    Private Sub DisplayStudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayStudioToolStripMenuItem.Click
        DisplayStudioForm.ShowDialog()
    End Sub
    'exits program
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Displays "About" From Menustrip
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub
End Class