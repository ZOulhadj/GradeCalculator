Imports System.ComponentModel

Public Class Details

    Private Sub Validate()
        If String.IsNullOrEmpty(txtStudentName.Text) Or
            String.IsNullOrEmpty(txtStudentID.Text) Or
            String.IsNullOrEmpty(cmbStudentCourse.Text) Then
            btnDetailsDone.Enabled = False
        Else
            btnDetailsDone.Enabled = True
        End If
    End Sub

    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' When the details form loads, display the data from within the Student
        ' structure into the text boxes. The reason for this is that if a user
        ' opens the form again after having completed it previously then it will
        ' display all the data that has already been entered.
        txtStudentName.Text = person.name
        txtStudentID.Text = person.id
        cmbStudentCourse.Text = person.course
        txtStudentDOB.Text = Format(person.dob, "dd/MM/yyyy")

        ' Set the maximum id input length
        txtStudentID.MaxLength = 8
        ' Disable 'done' button on load
        btnDetailsDone.Enabled = False
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs)
        ' When the help button is clicked show the 'Help' form.
        Me.Hide()
        Help.Show()
    End Sub

    Private Sub TxtStudentName_TextChanged(sender As Object, e As EventArgs) Handles txtStudentName.TextChanged
        ' Prevents the user from entering a number as their name
        Dim letter As String
        Dim charactersDisallowed As String = "1234567890"
        For x As Integer = 0 To txtStudentName.Text.Length - 1
            letter = txtStudentName.Text.Substring(x, 1)
            If charactersDisallowed.Contains(letter) Then
                txtStudentName.Text = ""
            End If
        Next

        Validate()

    End Sub

    Private Sub TxtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged
        If Not Integer.TryParse(txtStudentID.Text, person.id) Then
            txtStudentID.Text = ""
        End If

        Validate()
    End Sub

    Private Sub CmbStudentCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudentCourse.SelectedIndexChanged
        Validate()
    End Sub

    Private Sub lblDetailsDone_Click(sender As Object, e As EventArgs) Handles btnDetailsDone.Click
        ' When the done button is clicked, store all data within the text boxes
        ' into the variables within the Student structure so that they can be
        ' used at a later date
        person.name = txtStudentName.Text
        person.id = txtStudentID.Text
        person.course = cmbStudentCourse.Text
        person.dob = txtStudentDOB.Text

        ' Once the details form is complete then enable the grade button
        GradeCalculator.btnGrade.Enabled = True

        Me.Hide()
        GradeCalculator.Show()
    End Sub
End Class