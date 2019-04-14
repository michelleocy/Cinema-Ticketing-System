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

    Private Sub mnuBookingMakeBooking_Click(sender As Object, e As EventArgs) Handles mnuBookingMakeBooking.Click

        Me.Hide()
        MakeBooking.ShowDialog()

    End Sub

    Private Sub mnuBookingList_Click(sender As Object, e As EventArgs) Handles mnuBookingList.Click

        Me.Hide()
        ViewBookingList.ShowDialog()

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        End

    End Sub

End Class