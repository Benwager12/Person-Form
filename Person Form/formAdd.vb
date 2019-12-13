Imports System.IO

Public Class formAdd

    Private Structure User
        Public UserID As String
        Public Forename As String
        Public Surname As String
        Public StreetName As String
        Public HairColour As String
    End Structure

    Private Sub pnlHairColour_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles pnlHairColour.MouseDoubleClick
        If clrHairColour.ShowDialog() = DialogResult.OK Then
            pnlHairColour.BackColor = clrHairColour.Color
        End If
    End Sub

    Private Sub userWrite(ByVal write As String)
        Dim db As New System.IO.StreamWriter(Dir$("Users.txt"), True)
        db.WriteLine(write)
        db.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim userData As User

        userData.UserID = LSet(numUserID.Value, 9)
        userData.Forename = LSet(txtForename.Text, txtForename.MaxLength)
        userData.Surname = LSet(txtSurname.Text, txtSurname.MaxLength)
        userData.StreetName = LSet(txtStreetName.Text, txtStreetName.MaxLength)
        userData.HairColour = LSet(clrHairColour.Color.ToArgb(), 10)

        userWrite(userData.UserID & userData.Forename & userData.Surname &
                  userData.StreetName & userData.HairColour)
        MsgBox("Record written to database")
    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim userCount As Integer = 0

        For Each Line In File.ReadAllLines(Dir$("Users.txt"))
            If Line.Length = 139 Then
                userCount += 1
            End If
        Next
        MsgBox("You have: " & userCount & " record" & If(userCount = 1, "", "s"))
    End Sub

    Private Sub formUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        formMenu.Show()
        Hide()
    End Sub
End Class
