Imports System.IO

Public Class frmFlights
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim Dir As String = "C:\Users\Uchi\Documents\Visual Studio 2012\Projects\KuchiUchi Airlines Management"
        If Not Directory.Exists(Dir) Then
            Directory.CreateDirectory(Dir)
        End If

        Dim file2 As New FileStream("Flight.txt", FileMode.Create, FileAccess.Write)

        Dim flight As New StreamWriter(file2)
        flight.Write(txtFlightName.Text & ", ")
        flight.Write(txtFlightName.Text & ", ")
        flight.Write(txtFlightName.Text & ", ")
        flight.Write(txtFlightName.Text & ", ")

        flight.Close()

    End Sub
    Private Sub btnCancel_Click(sender As Object,
            e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmHome.Show()
    End Sub

    Private Sub frmFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class