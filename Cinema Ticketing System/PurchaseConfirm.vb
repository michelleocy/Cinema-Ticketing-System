Public Class PurchaseConfirm

    Public purchaseId As Integer

    Private Sub PurchaseConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblPurchaseId.Text = purchaseId.ToString()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Me.Hide()
        PrintMovieTicket.ShowDialog()

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