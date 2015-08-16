Public Class frmLogin

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Dim user As String = StrConv(txtID.Text, VbStrConv.Lowercase)
        Dim pass As String = StrConv(txtPassword.Text, VbStrConv.Lowercase)

        If user = "admin" And pass = "password" Then

            Me.Hide()
            frmHome.Show()
        Else
            txtID.Clear()
            txtPassword.Clear()

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Exits the application
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub


End Class