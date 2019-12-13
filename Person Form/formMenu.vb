Public Class formMenu
    Private Sub btnAddUsers_Click(sender As Object, e As EventArgs) Handles btnAddUsers.Click
        formAdd.Show()
        Hide()
    End Sub

    Private Sub btnViewUsers_Click(sender As Object, e As EventArgs) Handles btnViewUsers.Click
        formView.Show()
        Hide()
    End Sub
End Class