Imports System.IO

Public Class formView

    Dim Lines() As String

    Private Sub formView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lines = File.ReadAllLines(Dir$("Users.txt"))
        For Each Line In Lines
            If (Line.Length = 139) Then
                cmboUserID.Items.Add(Mid(Line, 1, 9).Trim())
            End If
        Next

        If cmboUserID.Items.Count > 0 Then
            cmboUserID.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim userCount As Integer = 0

        For Each Line In Lines
            If Line.Length = 139 Then
                userCount += 1
            End If
        Next
        MsgBox("You have: " & userCount & " record" & If(userCount = 1, "", "s"))
    End Sub

    Private Sub formView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        formMenu.Show()
        Hide()
    End Sub

    Private Sub cmboUserID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmboUserID.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmboUserID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboUserID.SelectedIndexChanged
        Dim sLine = Lines(cmboUserID.SelectedIndex)

        txtForename.Text = Mid(sLine, 10, 30).Trim()
        txtSurname.Text = Mid(sLine, 40, 30).Trim()
        txtStreetName.Text = Mid(sLine, 70, 60).Trim()
        pnlHairColour.BackColor = Color.FromArgb(Mid(sLine, 130, 10).Trim())
    End Sub
End Class