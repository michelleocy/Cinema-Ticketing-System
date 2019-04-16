Public Class ViewBookingList

    Private originalSeat As Integer

    Private Sub ViewBookingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.DatabaseDataSet.Booking)

        BindData()

    End Sub

    Private Sub BindData()

        Dim db As New demoDataContext()
        Dim rs = From o In db.Bookings
                 Where o.CustomerName.Contains(txtName.Text)


        dgvBooking.Columns.Add(New DataGridViewColumn() With {
                               .HeaderText = "Time",
                               .CellTemplate = New DataGridViewTextBoxCell
                               })
        dgvBooking.Columns.Add(New DataGridViewColumn() With {
                               .HeaderText = "Movie",
                               .CellTemplate = New DataGridViewTextBoxCell
                               })

        For Each row In dgvBooking.Rows
            Dim bookingid As Integer = Integer.Parse(row.cells(0).value)
            Dim rs2 = (From o In db.Bookings
                       Where o.BookingID = bookingid).FirstOrDefault

            row.cells(6).value = rs2.MovieSchedule.Time
            row.cells(7).value = rs2.MovieSchedule.Movie.MovieName
        Next

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

        BindData()

    End Sub

    Private Sub dgvBooking_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvBooking.CellFormatting

        If e.ColumnIndex = 6 Then
            Select Case e.Value
                Case 1
                    e.Value = "11.00AM"
                Case 2
                    e.Value = "1.30PM"
                Case 3
                    e.Value = "4.00PM"
                Case 4
                    e.Value = "6.30PM"
                Case 5
                    e.Value = "9.00PM"
            End Select
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPreview.Click

        Me.Hide()
        PrintBookingReceipt.ShowDialog()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim index As Integer = dgvBooking.CurrentCell.RowIndex

        Dim db As New demoDataContext()
        Dim b As Booking = db.Bookings.FirstOrDefault(Function(o) o.BookingID = dgvBooking.CurrentRow.Cells(0).Value.ToString)

        Dim str As String = "Are you sure to delete ?"
        Dim resultDlg As Integer = MessageBox.Show(str, "Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If resultDlg = DialogResult.Cancel Then
            Exit Sub
        ElseIf resultDlg = DialogResult.OK Then
            dgvBooking.Rows.RemoveAt(index)
            db.Bookings.DeleteOnSubmit(b)
            db.SubmitChanges()
        End If

    End Sub

    Private Sub dgvBooking_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooking.CellEndEdit

        Dim db As New demoDataContext
        Dim movieScheduleId As Integer = Integer.Parse(dgvBooking.Rows(e.RowIndex).Cells(3).Value)
        Dim rs = (From o In db.Bookings
                  Where o.BookingID = Integer.Parse(dgvBooking.Rows(e.RowIndex).Cells(0).Value)).FirstOrDefault

        Dim rs1 = From o In db.Purchases
                  Where o.MovieScheduleID = movieScheduleId

        Dim seatAmount As Integer
        Dim count As Integer = 0

        If rs1.Count > 0 Then
            For Each item In rs1
                count += item.PurchasedSeats.Count
            Next
        End If

        Dim rs2 = From o In db.Bookings
                  Where o.MovieScheduleID = movieScheduleId

        If rs2.Count > 0 Then
            For Each item In rs2
                count += item.AmountOfPeople
            Next
        End If

        Dim rs3 = (From o In db.MovieSchedules
                   Where o.Id = movieScheduleId).FirstOrDefault

        seatAmount = rs3.Hall.Seats.Count

        If (seatAmount - count + originalSeat) < Integer.Parse(dgvBooking.Rows(e.RowIndex).Cells(4).Value) Then
            MessageBox.Show("Not enough seats!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgvBooking.Rows(e.RowIndex).Cells(4).Value = originalSeat
        Else
            rs.AmountOfPeople = Integer.Parse(dgvBooking.Rows(e.RowIndex).Cells(4).Value)

            db.SubmitChanges()
        End If

    End Sub

    Private Sub dgvBooking_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvBooking.CellBeginEdit

        originalSeat = Integer.Parse(dgvBooking.Rows(e.RowIndex).Cells(4).Value)

    End Sub

    Private Sub mnuBookingMakeBooking_Click(sender As Object, e As EventArgs)

        Me.Hide()
        MakeBooking.ShowDialog()
        Me.Show()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mnuHall_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmViewHall.ShowDialog()
        Me.Show()
    End Sub

    Private Sub mnuReport_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmGenerateReport.ShowDialog()
        Me.Show()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuStaff.Click
        Me.Hide()
        FrmLoginList.ShowDialog()
        Me.Show()
    End Sub

    Private Sub MnuMovieMovieSchedule_Click(sender As Object, e As EventArgs) Handles mnuMovieMovieSchedule.Click
        Me.Hide()
        MovieScheduleList.ShowDialog()
        Me.Show()
    End Sub

    Private Sub MnuMovieMovieList_Click(sender As Object, e As EventArgs) Handles mnuMovieMovieList.Click
        Me.Hide()
        MovieList.ShowDialog()
        Me.Show()
    End Sub
End Class