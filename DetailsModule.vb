Module DetailsModule

    Structure Student
        Dim name As String ' Stores the student's name
        Dim id As String ' Stores the student's id number
        Dim course As String ' Stores the student's current course
        Dim dob As Date ' Stores the student's date of birth
        Dim grades() As String ' Stores the student's grades
    End Structure

    ' Create an instance of the Student structure in a variable called person
    Public person As Student

End Module
