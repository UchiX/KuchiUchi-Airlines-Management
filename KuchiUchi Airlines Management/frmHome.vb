Public Class frmHome

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPassengers_Click(sender As Object, e As EventArgs) Handles btnPassengers.Click
        frmPassengers.Show()
        Me.Hide()
    End Sub

    Private Sub btnFlights_Click(sender As Object, e As EventArgs) Handles btnFlights.Click
        frmFlights.Show()
        Me.Hide()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Gets the answer from the msg box.
        Dim logoutAnswer As MsgBoxResult = MsgBox("Are you sure you want to log out?", MsgBoxStyle.OkCancel)

        ' If the answer is ok, then show the login form.
        If logoutAnswer = MsgBoxResult.Ok Then
            frmLogin.Show()
            Me.Hide()
        End If
    End Sub


End Class