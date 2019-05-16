Public Class Grade
    Dim btecLevel3SD As Integer = 6, btecLevel390D = 9, btecLevel3D = 12, btecLevel3ED = 19
    Dim grades(19) As ComboBox

    ' The purpose of the Validate function is to check what course the user has selected
    ' Depending on the course, a certain number of combo boxes will be enabled.
    Private Sub Validate()
        If person.course.Equals("BTEC Level 3 SD") Then
            For i = 0 To btecLevel3SD - 1
                If grades(i).Enabled And Not String.IsNullOrEmpty(grades(i).Text) Then
                    btnDone.Enabled = True
                Else
                    btnDone.Enabled = False
                End If
            Next
        ElseIf person.course.Equals("BTEC Level 3 90 D") Then
            For i = 0 To btecLevel390D - 1
                If grades(i).Enabled And Not String.IsNullOrEmpty(grades(i).Text) Then
                    btnDone.Enabled = True
                Else
                    btnDone.Enabled = False
                End If
            Next
        ElseIf person.course.Equals("BTEC Level 3 D") Then
            For i = 0 To btecLevel3D - 1
                If grades(i).Enabled And Not String.IsNullOrEmpty(grades(i).Text) Then
                    btnDone.Enabled = True
                Else
                    btnDone.Enabled = False
                End If
            Next
        ElseIf person.course.Equals("BTEC Level 3 ED") Then
            For i = 0 To btecLevel3ED - 1
                If grades(i).Enabled And Not String.IsNullOrEmpty(grades(i).Text) Then
                    btnDone.Enabled = True
                Else
                    btnDone.Enabled = False
                End If
            Next
        End If

    End Sub
    Private Sub Grade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDone.Enabled = False

        grades(0) = cmb1
        grades(1) = cmb2
        grades(2) = cmb3
        grades(3) = cmb6
        grades(4) = cmb9
        grades(5) = cmb11
        grades(6) = cmb14
        grades(7) = cmb16
        grades(8) = cmb17
        grades(9) = cmb18
        grades(10) = cmb19
        grades(11) = cmb20
        grades(12) = cmb21
        grades(13) = cmb22
        grades(14) = cmb28
        grades(15) = cmb30
        grades(16) = cmb31
        grades(17) = cmb42
        grades(18) = cmb105

        ' Depending on the details course input, enable the courses
        If person.course.Equals("BTEC Level 3 SD") Then
            For i = 0 To btecLevel3SD - 1
                grades(i).Enabled = True
            Next
        ElseIf person.course.Equals("BTEC Level 3 90 D") Then
            For i = 0 To btecLevel390D - 1
                grades(i).Enabled = True
            Next
        ElseIf person.course.Equals("BTEC Level 3 D") Then
            For i = 0 To btecLevel3D - 1
                grades(i).Enabled = True
            Next
        ElseIf person.course.Equals("BTEC Level 3 ED") Then
            For i = 0 To btecLevel3ED - 1
                grades(i).Enabled = True
            Next
        End If
    End Sub

    ' If any of the combo boxes value changes then run the validate function
    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged,
        cmb2.SelectedIndexChanged,
        cmb3.SelectedIndexChanged,
        cmb6.SelectedIndexChanged,
        cmb9.SelectedIndexChanged,
        cmb11.SelectedIndexChanged,
        cmb14.SelectedIndexChanged,
        cmb16.SelectedIndexChanged,
        cmb17.SelectedIndexChanged,
        cmb18.SelectedIndexChanged,
        cmb19.SelectedIndexChanged,
        cmb20.SelectedIndexChanged,
        cmb21.SelectedIndexChanged,
        cmb22.SelectedIndexChanged,
        cmb28.SelectedIndexChanged,
        cmb30.SelectedIndexChanged,
        cmb31.SelectedIndexChanged,
        cmb42.SelectedIndexChanged,
        cmb105.SelectedIndexChanged

        Validate()

    End Sub
    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        GradeCalculator.btnCertificate.Enabled = True
        ' When the done button is clicked then hide the current window and show
        ' the main menu.
        Me.Hide()
        GradeCalculator.Show()
    End Sub


End Class
