Public Class StDB106
    ' Set up a class for a student
    Class STUDENT
        Public studID As Short
        Public firstname As String
        Public lastname As String
        Public DOB As Date
        Public gender As Char
        Public avMk As Single
        Public phoneNo As String
        Public paid As Boolean
    End Class

    Dim students(9) As STUDENT
    Dim studentCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Allocate memory
        For i = 0 To 9
            students(i) = New STUDENT
        Next

        ' Load 4 test records
        students(0).studID = 1
        students(0).firstname = "Johnny"
        students(0).lastname = "Depp"
        students(0).DOB = "9/6/63"
        students(0).gender = "M"
        students(0).avMk = 78.2
        students(0).phoneNo = "04318857923"
        students(0).paid = False

        students(1).studID = 2
        students(1).firstname = "Jennifer"
        students(1).lastname = "Lawrence"
        students(1).DOB = "15/8/90"
        students(1).gender = "F"
        students(1).avMk = 88.2
        students(1).phoneNo = "0472884728"
        students(1).paid = True

        students(2).studID = 3
        students(2).firstname = "George"
        students(2).lastname = "Clooney"
        students(2).DOB = "6/5/61"
        students(2).gender = "M"
        students(2).avMk = 68.2
        students(2).phoneNo = "0492847004"
        students(2).paid = True

        students(3).studID = 4
        students(3).firstname = "Scarlett"
        students(3).lastname = "Johansson"
        students(3).DOB = "22/11/84"
        students(3).gender = "F"
        students(3).avMk = 72.2
        students(3).phoneNo = "0482992768"
        students(3).paid = False

        ' Set the student count to the number of students which have been entered
        studentCount = 4
        displayList()
    End Sub

    Private Sub btnAddStud_Click(sender As Object, e As EventArgs) Handles btnAddStud.Click
        students(studentCount).studID = studentCount + 1 'allocate the new student ID to an incremented value

        ' Place text from text boxes into the array - first students(0), then students(1), students(2) etc
        students(studentCount).firstname = txtFirstName.Text
        students(studentCount).lastname = txtLastName.Text
        students(studentCount).DOB = txtDOB.Text
        students(studentCount).gender = txtGender.Text
        students(studentCount).avMk = txtAvMk.Text
        studentCount += 1

        ' Clear old records
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtDOB.Text = ""
        txtGender.Text = ""
        txtAvMk.Text = ""
        txtPhone.Text = ""
        chkPaid.Checked = False

        ' Load new records
        displayList()
    End Sub

    Private Sub displayList()
        txtStList.Items.Clear()

        ' Loop through the array to add new rows
        For i = 0 To studentCount - 1
            txtStList.Items.Add(students(i).studID & " • " & students(i).firstname & " • " &
                                students(i).lastname & " • " & students(i).DOB & " • " &
                                students(i).gender & " • " & students(i).avMk & " • " &
                                students(i).phoneNo & " • " & students(i).paid)
        Next
    End Sub
End Class
