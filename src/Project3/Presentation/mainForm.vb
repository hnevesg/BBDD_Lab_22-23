Public Class mainForm
    Private manage As manageForm
    Private concert As concertForm
    Private navigation As navigationForm

    Private Sub manageBtn_Click(sender As Object, e As EventArgs) Handles manageBtn.Click
        manage = New manageForm
        Me.Hide()
        manage.Show()
    End Sub

    Private Sub concertBtn_Click(sender As Object, e As EventArgs) Handles concertBtn.Click
        concert = New concertForm
        Me.Hide()
        concert.Show()
    End Sub

    Private Sub navigationButton_Click(sender As Object, e As EventArgs) Handles navigationButton.Click
        navigation = New navigationForm
        Me.Hide()
        navigation.Show()
    End Sub

End Class