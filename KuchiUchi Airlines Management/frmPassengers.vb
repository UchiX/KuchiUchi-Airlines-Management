
Imports System.IO

Public Class frmPassengers


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim Dir As String = "C:\Users\Uchi\Documents\Visual Studio 2012\Projects\KuchiUchi Airlines Management"
        If Not Directory.Exists(Dir) Then
            Directory.CreateDirectory(Dir)
        End If

        Dim file2 As New FileStream("Passengers.txt", FileMode.Create, FileAccess.Write)

        Dim passenger As New StreamWriter(file2)
        passenger.Write(txtName.Text & ", ")
        passenger.Write(txtSurname.Text & ", ")
        passenger.Write(txtID.Text & ", ")
        passenger.Write(DateTimePicker1.Value & ", ")

        passenger.Close()

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmHome.Show()
    End Sub

    Private Sub frmPassengers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class