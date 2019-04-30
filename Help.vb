Public Class Help
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        ' When the 'Main Menu' button is clicked we will first hide the help window
        ' and then show the main form once again.
        Me.Close()
        GradeCalculator.Show()
    End Sub
End Class