Imports System.IO
Imports System.Text
Public Class Certificate

    Dim grades(19) As String
    Private Sub Certificate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Make sure the student's name is in propercase before being displayed on the certificate
        person.name = StrConv(person.name, VbStrConv.ProperCase)

        Dim c = 0, s = 0
        lblGrade1.Text = Grade.cmb1.Text
        lblGrade2.Text = Grade.cmb2.Text
        lblGrade3.Text = Grade.cmb3.Text
        lblGrade6.Text = Grade.cmb6.Text
        lblGrade9.Text = Grade.cmb9.Text
        lblGrade11.Text = Grade.cmb11.Text
        lblGrade14.Text = Grade.cmb14.Text
        lblGrade16.Text = Grade.cmb16.Text
        lblGrade17.Text = Grade.cmb17.Text
        lblGrade18.Text = Grade.cmb18.Text
        lblGrade19.Text = Grade.cmb19.Text
        lblGrade20.Text = Grade.cmb20.Text
        lblGrade21.Text = Grade.cmb21.Text
        lblGrade22.Text = Grade.cmb22.Text
        lblGrade28.Text = Grade.cmb28.Text
        lblGrade30.Text = Grade.cmb30.Text
        lblGrade31.Text = Grade.cmb31.Text
        lblGrade42.Text = Grade.cmb42.Text
        lblGrade105.Text = Grade.cmb105.Text

        grades(0) = lblGrade1.Text
        grades(1) = lblGrade2.Text
        grades(2) = lblGrade3.Text
        grades(3) = lblGrade6.Text
        grades(4) = lblGrade9.Text
        grades(5) = lblGrade11.Text
        grades(6) = lblGrade14.Text
        grades(7) = lblGrade16.Text
        grades(8) = lblGrade17.Text
        grades(9) = lblGrade18.Text
        grades(10) = lblGrade19.Text
        grades(11) = lblGrade20.Text
        grades(12) = lblGrade21.Text
        grades(13) = lblGrade22.Text
        grades(14) = lblGrade28.Text
        grades(15) = lblGrade30.Text
        grades(16) = lblGrade31.Text
        grades(17) = lblGrade42.Text
        grades(18) = lblGrade105.Text


        ' Iterate through each credit label and assign the value 10.
        Dim arrayCreditLabels() As Label = {
            lblCredit1,
            lblCredit2,
            lblCredit3,
            lblCredit6,
            lblCredit9,
            lblCredit11,
            lblCredit14,
            lblCredit16,
            lblCredit17,
            lblCredit18,
            lblCredit19,
            lblCredit20,
            lblCredit21,
            lblCredit22,
            lblCredit28,
            lblCredit30,
            lblCredit31,
            lblCredit42,
            lblCredit105
        }

        For Each creditLables As Label In arrayCreditLabels
            If String.Equals(grades(c), "P") Then
                creditLables.Text = 10
            ElseIf String.Equals(grades(c), "M") Then
                creditLables.Text = 10
            ElseIf String.Equals(grades(c), "D") Then
                creditLables.Text = 10
            Else
                creditLables.Text = ""
            End If
            c += 1
        Next

        ' Iterate through all credit lables. If a grade cannot be found then the sore is given
        ' no value since the user has not enterd in a grade.
        Dim arrayScoreLabels() As Label = {
            lblScore1,
            lblScore2,
            lblScore3,
            lblScore6,
            lblScore9,
            lblScore11,
            lblScore14,
            lblScore16,
            lblScore17,
            lblScore18,
            lblScore19,
            lblScore20,
            lblScore21,
            lblScore22,
            lblScore28,
            lblScore30,
            lblScore31,
            lblScore42,
            lblScore105
        }

        ' Iterate through all score labels and if grade matches then assign score
        ' P -> 70 Points, M -> 80 Points, D -> 90 Points.
        Dim totalScore As Integer = 0
        For Each scoreLabels As Label In arrayScoreLabels
            If String.Equals(grades(s), "P") Then
                scoreLabels.Text = 7 * 10
            ElseIf String.Equals(grades(s), "M") Then
                scoreLabels.Text = 8 * 10
            ElseIf String.Equals(grades(s), "D") Then
                scoreLabels.Text = 9 * 10
            End If

            s += 1

            ' Add up the score each iteration
            If Not String.IsNullOrEmpty(scoreLabels.Text) Then
                totalScore += CInt(scoreLabels.Text)
            End If

        Next

        ' Checks if the student has reached the minimum required score for a specific course
        If person.course.Equals("BTEC Level 3 SD") Then
            If totalScore < 420 Then
                Me.Close()
                MessageBox.Show("Error! Cannot display certifcate due to minium score not being reached for BTEC Level 3 SD")
                GradeCalculator.Show()
            End If
        ElseIf person.course.Equals("BTEC Level 3 90 D") Then
            If totalScore < 630 Then
                Me.Close()
                MessageBox.Show("Error! Cannot display certifcate due to minium score not being reached for BTEC Level 3 90 D")
                GradeCalculator.Show()
            End If
        ElseIf person.course.Equals("BTEC Level 3 D") Then
            If totalScore < 840 Then
                Me.Close()
                MessageBox.Show("Error! Cannot display certifcate due to minium score not being reached for BTEC Level 3 D")
                GradeCalculator.Show()
            End If
        ElseIf person.course.Equals("BTEC Level 3 ED") Then
            If totalScore < 1260 Then
                Me.Close()
                MessageBox.Show("Error! Cannot display certifcate due to minium score not being reached for BTEC Level 3 ED")
                GradeCalculator.Show()
            End If
        End If

        ' Display the student information on the certificate
        lblStudentInformation.Text = person.name & " (" & "KC" & person.id & ") " & person.dob
        lblStudentCourse.Text = person.course

        ' Display the students grade and total score based on grade requirements
        If person.course.Equals("BTEC Level 3 SD") Then
            If totalScore >= 420 AndAlso totalScore <= 459 Then
                lblStudentGrade.Text = "P " & totalScore
            ElseIf totalScore >= 460 AndAlso totalScore <= 499 Then
                lblStudentGrade.Text = "M " & totalScore
            ElseIf totalScore >= 500 AndAlso totalScore <= 519 Then
                lblStudentGrade.Text = "D " & totalScore
            ElseIf totalScore >= 520 Then
                lblStudentGrade.Text = "D* " & totalScore
            End If
        ElseIf person.course.Equals("BTEC Level 3 90 D") Then
            If totalScore >= 630 AndAlso totalScore <= 659 Then
                lblStudentGrade.Text = "PP " & totalScore
            ElseIf totalScore >= 660 AndAlso totalScore <= 689 Then
                lblStudentGrade.Text = "MP " & totalScore
            ElseIf totalScore >= 690 AndAlso totalScore <= 719 Then
                lblStudentGrade.Text = "MM " & totalScore
            ElseIf totalScore >= 720 AndAlso totalScore <= 749 Then
                lblStudentGrade.Text = "DM " & totalScore
            ElseIf totalScore >= 750 AndAlso totalScore <= 769 Then
                lblStudentGrade.Text = "DD " & totalScore
            ElseIf totalScore >= 770 AndAlso totalScore <= 789 Then
                lblStudentGrade.Text = "D*D " & totalScore
            ElseIf totalScore >= 790 Then
                lblStudentGrade.Text = "D*D* " & totalScore
            End If
        ElseIf person.course.Equals("BTEC Level 3 D") Then
            If totalScore >= 840 AndAlso totalScore <= 879 Then
                lblStudentGrade.Text = "PP " & totalScore
            ElseIf totalScore >= 880 AndAlso totalScore <= 919 Then
                lblStudentGrade.Text = "MP " & totalScore
            ElseIf totalScore >= 920 AndAlso totalScore <= 959 Then
                lblStudentGrade.Text = "MM " & totalScore
            ElseIf totalScore >= 960 AndAlso totalScore <= 999 Then
                lblStudentGrade.Text = "DM " & totalScore
            ElseIf totalScore >= 1000 AndAlso totalScore <= 1029 Then
                lblStudentGrade.Text = "DD " & totalScore
            ElseIf totalScore >= 1030 AndAlso totalScore <= 1059 Then
                lblStudentGrade.Text = "D*D " & totalScore
            ElseIf totalScore >= 1060 Then
                lblStudentGrade.Text = "D*D* " & totalScore
            End If
        ElseIf person.course.Equals("BTEC Level 3 ED") Then
            If totalScore >= 1260 AndAlso totalScore <= 1299 Then
                lblStudentGrade.Text = "PPP " & totalScore
            ElseIf totalScore >= 1300 AndAlso totalScore <= 1339 Then
                lblStudentGrade.Text = "MPP " & totalScore
            ElseIf totalScore >= 1340 AndAlso totalScore <= 1379 Then
                lblStudentGrade.Text = "MMP " & totalScore
            ElseIf totalScore >= 1380 AndAlso totalScore <= 1419 Then
                lblStudentGrade.Text = "MMM " & totalScore
            ElseIf totalScore >= 1420 AndAlso totalScore <= 1459 Then
                lblStudentGrade.Text = "DMM " & totalScore
            ElseIf totalScore >= 1460 AndAlso totalScore <= 1499 Then
                lblStudentGrade.Text = "DDM " & totalScore
            ElseIf totalScore >= 1500 AndAlso totalScore <= 1529 Then
                lblStudentGrade.Text = "DDD " & totalScore
            ElseIf totalScore >= 1530 AndAlso totalScore <= 1559 Then
                lblStudentGrade.Text = "D*DD " & totalScore
            ElseIf totalScore >= 1560 AndAlso totalScore <= 1589 Then
                lblStudentGrade.Text = "D*D*D " & totalScore
            ElseIf totalScore >= 1590 Then
                lblStudentGrade.Text = "D*D*D* " & totalScore
            End If
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' When the print button is clicked, a print options dialog will open
        printDialog.ShowDialog()
    End Sub

    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        ' If the export checkbox is ticked then export the students overall grade
        If cbxExportToFile.Checked Then
            Dim filePath As String = "Grade.txt"
            Dim fs As FileStream = File.Create(filePath)
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(lblStudentGrade.Text)
            fs.Write(info, 0, info.Length)
            fs.Close()

            MessageBox.Show("Final grade has been exported to a file named output to the location that the application is running in...")
        End If

        ' When the done button is clicked, simply hide the current window and go back to the main menu.
        Me.Hide()
        GradeCalculator.Show()
    End Sub

End Class