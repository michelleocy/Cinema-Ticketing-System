Public Class Homescreen

    Private Sub mnuBookingMakeBooking_Click(sender As Object, e As EventArgs) Handles mnuBookingMakeBooking.Click

        Me.Hide()
        MakeBooking.ShowDialog()
        Me.Show()
    End Sub

    Private Sub mnuBookingList_Click(sender As Object, e As EventArgs) Handles mnuBookingList.Click

        Me.Hide()
        ViewBookingList.ShowDialog()
        Me.Show()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        End

    End Sub

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

        Me.Hide()
        NewPurchase.ShowDialog()
        Me.Show()
    End Sub

    Private Sub mnuHall_Click(sender As Object, e As EventArgs) Handles mnuHall.Click
        Me.Hide()
        FrmViewHall.ShowDialog()
        Me.Show()
    End Sub

    Private Sub mnuReport_Click(sender As Object, e As EventArgs) Handles mnuReport.Click
        Me.Hide()
        FrmGenerateReport.ShowDialog()
        Me.Show()
    End Sub
End Class