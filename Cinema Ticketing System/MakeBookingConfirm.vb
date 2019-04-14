Imports System.Text
Imports System.Data.SqlClient

Public Class MakeBookingConfirm

    Public currentBooking As String

    Private Sub MakeBookingConfirm_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblName.Text = currentBooking

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Hide()
        Homescreen.ShowDialog()

    End Sub

End Class