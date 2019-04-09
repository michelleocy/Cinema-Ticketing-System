Imports System.Data.DataTable

Public Class UpdateBooking

    Private movieTime As String
    Dim index As Integer

    Private Sub UpdateBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub dgvBooking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooking.CellClick

        index = e.RowIndex
        Dim selectedRow As DataGridViewRow = dgvBooking.Rows(index)

        txtNameResult.Text = selectedRow.Cells(1).Value.ToString
        mskIC.Text = selectedRow.Cells(2).Value.ToString
        nudAmount.Text = selectedRow.Cells(4).Value.ToString
        dtpBookingDate.Value = selectedRow.Cells(5).Value.ToString

    End Sub

    Private Sub dtpBookingDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBookingDate.ValueChanged
        Dim db As New demoDataContext
        Dim rs = From o In db.MovieSchedules
                 Where o.Date = dtpBookingDate.Value

        Me.cboMovieName.DisplayMember = "Value"
        Me.cboMovieName.ValueMember = "Key"

        If rs.Count > 0 Then
            For Each item In rs
                cboMovieName.Items.Add(New DictionaryEntry(item.MovieID, item.Movie.MovieName))
            Next
        End If
    End Sub

    Private Sub cboMovieName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMovieName.SelectedIndexChanged
        Dim db As New demoDataContext
        Dim rs = From o In db.MovieSchedules
                 Where o.MovieID = Integer.Parse(CType(cboMovieName.SelectedItem, DictionaryEntry).Key)

        PurchaseSummary.movieName = cboMovieName.Text


        Me.cboTime.DisplayMember = "Value"
        Me.cboTime.ValueMember = "Key"

        If rs.Count > 0 Then
            For Each item In rs
                Dim timeSlot As Integer = item.Time
                Select Case timeSlot
                    Case 1
                        cboTime.Items.Add(New DictionaryEntry(item.Id, "11.00AM"))
                    Case 2
                        cboTime.Items.Add(New DictionaryEntry(item.Id, "1.30PM"))
                    Case 3
                        cboTime.Items.Add(New DictionaryEntry(item.Id, "4.00PM"))
                    Case 4
                        cboTime.Items.Add(New DictionaryEntry(item.Id, "6.30PM"))
                    Case 5
                        cboTime.Items.Add(New DictionaryEntry(item.Id, "9.00PM"))
                End Select
            Next
        End If
    End Sub

    Private Sub cboTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTime.SelectedIndexChanged
        Dim db As New demoDataContext
        Dim rs1 = From o In db.Purchases
                  Where o.MovieScheduleID = Integer.Parse(CType(cboTime.SelectedItem, DictionaryEntry).Key)

        Dim seatAmount As Integer
        Dim count As Integer = 0

        If rs1.Count > 0 Then
            For Each item In rs1
                count += item.PurchasedSeats.Count
            Next
        End If

        Dim rs2 = From o In db.Bookings
                  Where o.MovieScheduleID = Integer.Parse(CType(cboTime.SelectedItem, DictionaryEntry).Key)

        If rs2.Count > 0 Then
            For Each item In rs2
                count += item.AmountOfPeople
            Next
        End If

        Dim rs3 = (From o In db.Halls
                   Where o.Id = Integer.Parse(CType(cboTime.SelectedItem, DictionaryEntry).Key)).FirstOrDefault

        seatAmount = rs3.Seats.Count
        nudAmount.Maximum = seatAmount - count
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtNameResult.Clear()
        mskIC.Clear()
        nudAmount.Value = 0

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim selectedRow As DataGridViewRow = dgvBooking.Rows(index)
        Dim db As New demoDataContext()

        Dim b As Booking = db.Bookings.FirstOrDefault(Function(o) o.BookingID = selectedRow.Cells(0).Value.ToString)
        b.CustomerName = txtNameResult.Text
        b.CustomerIC = mskIC.Text
        '
        b.AmountOfPeople = Integer.Parse(nudAmount.Text)
        b.BookingDate = dtpBookingDate.Value

        db.SubmitChanges()
        UpdateBookingConfirm.selectedBooking = txtNameResult.Text

        Me.Hide()
        UpdateBookingConfirm.ShowDialog()

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

        Me.ShowDialog()

    End Sub

    Private Sub mnuBookingDelete_Click(sender As Object, e As EventArgs) Handles mnuBookingDelete.Click

        Me.Hide()
        DeleteBooking.ShowDialog()

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        End

    End Sub

End Class