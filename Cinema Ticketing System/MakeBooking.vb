Imports System.Text

Public Class MakeBooking

    Private movieTime As String
    Private bookingDate As DateTime

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim ic As String = If(mskIC.MaskCompleted, mskIC.Text, "")

        If txtName.Text = "" Then
            err.AppendLine("- Name is required !")
            ctr = If(ctr, txtName)
        End If

        If ic = "" Then
            err.AppendLine("- IC is required !")
            ctr = If(ctr, mskIC)
        End If

        If cboMovieName.SelectedIndex = -1 Then
            err.AppendLine("- Movie Name is required !")
            ctr = If(ctr, cboMovieName)
        End If

        If nudAmount.Text = 0 Then
            err.AppendLine("- Amount is required !")
            ctr = If(ctr, nudAmount)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim b As New Booking()
            b.CustomerName = txtName.Text
            b.CustomerIC = mskIC.Text
            b.MovieScheduleID = Integer.Parse(CType(cboTime.SelectedItem, DictionaryEntry).Key)
            b.AmountOfPeople = Integer.Parse(nudAmount.Text)
            b.BookingDate = dtpBookingDate.Value

            Dim db As New demoDataContext()

            db.Bookings.InsertOnSubmit(b)
            db.SubmitChanges()

            MakeBookingConfirm.currentBooking = txtName.Text
            Me.Hide()
            MakeBookingConfirm.ShowDialog()
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

        Dim rs3 = (From o In db.MovieSchedules
                   Where o.Id = Integer.Parse(CType(cboTime.SelectedItem, DictionaryEntry).Key)).FirstOrDefault

        seatAmount = rs3.Hall.Seats.Count
        nudAmount.Maximum = seatAmount - count

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

End Class