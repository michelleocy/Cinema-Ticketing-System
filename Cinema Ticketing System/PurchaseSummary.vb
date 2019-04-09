Public Class PurchaseSummary

    Public purchase As New Purchase
    Public movieScheduleId As Integer
    Public movieName As String

    Private Sub PurchaseSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim totalPrice As Decimal = 0D
        Dim db As New demoDataContext
        Dim rs1 = From o In db.MovieSchedules
                  Where o.Id = movieScheduleId

        For Each item In rs1
            totalPrice = purchase.PurchasedSeats.Count * item.TicketPrice
        Next

        purchase.TotalPrice = totalPrice
        lblMovie.Text = movieName
        lblDate.Text = purchase.VisitDate.ToShortDateString

        For Each item In purchase.PurchasedSeats
            lblSeat.Text += item.SeatNum + " "
        Next

        lblPrice.Text = totalPrice.ToString("0.00")

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        purchase.MovieScheduleID = movieScheduleId
        purchase.VisitDate = lblDate.Text
        purchase.TotalPrice = Decimal.Parse(lblPrice.Text)

        Dim db As New demoDataContext()

        db.Purchases.InsertOnSubmit(purchase)
        db.SubmitChanges()

        PurchaseConfirm.purchaseId = purchase.PurchaseID
        PrintMovieTicket.purchaseId = purchase.PurchaseID
        Me.Hide()
        PurchaseConfirm.ShowDialog()

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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Dim str As String = "Are you sure to cancel ?"
        Dim resultDlg As Integer = MessageBox.Show(str, "Cancelation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If resultDlg = DialogResult.Cancel Then
            Exit Sub
        ElseIf resultDlg = DialogResult.OK Then
            Close()
            NewPurchase.Show()
        End If

    End Sub
End Class