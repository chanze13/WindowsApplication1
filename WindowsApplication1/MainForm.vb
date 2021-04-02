Public Class MainForm
    ' Program Name: Zesto Movie Store
    ' Author:       Chanze Pearson
    ' Date:         April 1, 2021
    ' Purpose       This Apllication Serves As A Online Website For Renting and Selling Videos.
    'exit the program
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Displays "Display Studio" From Menustrip
    Private Sub DisplayStudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayStudioToolStripMenuItem.Click
        DisplayStudioForm.ShowDialog()
    End Sub
    'Displays "Display video" From Menustrip
    Private Sub DisplayVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayVideoToolStripMenuItem.Click
        DisplayVideoForm.ShowDialog()
    End Sub
    'Displays Rental Page 
    Private Sub btnRentals_Click(sender As Object, e As EventArgs) Handles btnRentals.Click
        RentalsForm.ShowDialog()
    End Sub
    'Displays CheckOut Page
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        CheckOutForm.ShowDialog()
    End Sub
    'Displays "About" From Menustrip
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub


End Class
