Public Class GradeCalculator
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        ' When the help button is clicked show the 'Help' form.
        Me.Hide()
        Help.Show()
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        ' When the details button is clicked then hide the main menu and show the details
        ' form.
        Me.Hide()
        Details.Show()
    End Sub

    Private Sub BtnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        ' When the grade button is clicked then hide the current window and show the
        ' grade window form.
        Me.Hide()
        Grade.Show()
    End Sub

    Private Sub BtnCertificate_Click(sender As Object, e As EventArgs) Handles btnCertificate.Click
        ' When the certificate button is clicked then hide the current window and show the
        ' certificate window form.
        Me.Hide()
        Certificate.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' When the exit button is clicked, close the application.
        ' This will release data from memory and terminate the application instance.
        Application.Exit()
    End Sub

    Private Sub GradeCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnGrade.Enabled = False
        btnCertificate.Enabled = False
    End Sub
End Class
