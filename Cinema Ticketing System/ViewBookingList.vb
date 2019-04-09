Public Class ViewBookingList

    Private Sub ViewBookingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BookingTableAdapter.Fill(Me.DatabaseDataSet.Booking)

        BindData()

    End Sub

    Private Sub BindData()

        Dim db As New demoDataContext()
        Dim rs = From o In db.Bookings
                 Where o.CustomerName.Contains(txtName.Text)

        dgvBooking.DataSource = rs

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

        BindData()

    End Sub

    Private Sub mnuBookingMakeBooking_Click(sender As Object, e As EventArgs) Handles mnuBookingMakeBooking.Click

        Me.Hide()
        MakeBooking.ShowDialog()

    End Sub

    Private Sub mnuBookingList_Click(sender As Object, e As EventArgs) Handles mnuBookingList.Click

        Me.ShowDialog()

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
End Class