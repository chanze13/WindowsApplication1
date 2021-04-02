Public Class DisplayStudioForm
    'Hides Diables Display Studio on menu strip
    Private Sub DisplayStudioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayStudioToolStripMenuItem.Enabled = False
    End Sub
    'exit program
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Displays "Display video" From Menustrip
    Private Sub DisplayVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayVideoToolStripMenuItem.Click
        DisplayVideoForm.ShowDialog()
    End Sub
    'Displays "About" From Menustrip
    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutForm.ShowDialog()
    End Sub
End Class