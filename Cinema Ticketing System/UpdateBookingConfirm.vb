Public Class UpdateBookingConfirm

    Public selectedBooking As String

    Private Sub UpdateBookingConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblName.Text = selectedBooking
        PrintBookingReceipt.selectedBooking = lblName.Text

    End Sub

    Private Sub mnuBookingMakeBooking_Click(sender As Object, e As EventArgs) Handles mnuBookingMakeBooking.Click

        Me.Hide()
        MakeBooking.ShowDialog()

    End Sub

    Private Sub mnuBookingList_Click(sender As Object, e As EventArgs) Handles mnuBookingList.Click

        Me.Hide()
        ViewBookingList.ShowDialog()

    End Sub

    Private Sub mnuBookingUpdate_Click(sender As Object, e As EventArgs) Handles mnuBookingUpdate.Click

        Me.Hide()
        UpdateBooking.ShowDialog()

    End Sub

    Private Sub mnuBookingDelete_Click(sender As Object, e As EventArgs) Handles mnuBookingDelete.Click

        Me.Hide()
        DeleteBooking.ShowDialog()

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        End

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Me.Hide()
        PrintBookingReceipt.ShowDialog()

    End Sub

End Class