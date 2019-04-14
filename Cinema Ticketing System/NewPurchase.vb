Imports System.Text

Public Class NewPurchase

    Private Sub dtpDateAvailable_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateAvailable.ValueChanged

        Dim db As New demoDataContext
        Dim rs = From o In db.MovieSchedules
                 Where o.Date = dtpDateAvailable.Value

        PurchaseConfirm.movieShowDate = dtpDateAvailable.Value.ToShortDateString

        Me.cboMovie.DisplayMember = "Value"
        Me.cboMovie.ValueMember = "Key"

        If rs.Count > 0 Then
            For Each item In rs
                Dim existed As Boolean = False
                For Each i In cboMovie.Items
                    If i.value.ToString = item.Movie.MovieName Then
                        existed = True
                        Exit For
                    End If
                Next
                If existed = False Then
                    cboMovie.Items.Add(New DictionaryEntry(item.MovieID, item.Movie.MovieName))
                End If
            Next
        End If
    End Sub

    Private Sub cboMovie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMovie.SelectedIndexChanged

        Dim db As New demoDataContext
        Dim rs = From o In db.MovieSchedules
                 Where o.MovieID = Integer.Parse(CType(cboMovie.SelectedItem, DictionaryEntry).Key)

        PurchaseSummary.movieName = cboMovie.Text
        PurchaseConfirm.movieTitle = cboMovie.Text

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

        PurchaseConfirm.movieShowTime = cboTime.Text

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

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        If cboMovie.SelectedIndex = -1 Then
            err.AppendLine("- Movie Name is required !")
            ctr = If(ctr, cboMovie)
        End If

        If nudAmount.Text = 0 Then
            err.AppendLine("- Amount is required !")
            ctr = If(ctr, nudAmount)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            SeatSelection.movieScheduleId = Integer.Parse(CType(cboTime.SelectedItem, DictionaryEntry).Key)
            PurchaseSummary.movieScheduleId = Integer.Parse(CType(cboTime.SelectedItem, DictionaryEntry).Key)
            SeatSelection.amountSeatRequired = Integer.Parse(nudAmount.Text)
            Me.Hide()
            SeatSelection.ShowDialog()
        End If

    End Sub

End Class