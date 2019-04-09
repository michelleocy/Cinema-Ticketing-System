Public Class SeatSelection

    Public movieScheduleId As Integer
    Private seats As New List(Of Seat)

    Private Sub SeatSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim db As New demoDataContext
        Dim rs1 = (From o In db.MovieSchedules
                   Where o.Id = movieScheduleId).FirstOrDefault
        Dim rs2 = From o In db.Purchases
                  Where o.MovieScheduleID = movieScheduleId

        seats = rs1.Hall.Seats.ToList

        For Each ctrl In grpSeat.Controls
            If ctrl.GetType = GetType(Button) Then
                Dim btn As Button = CType(ctrl, Button)
                AddHandler btn.Click, AddressOf button_Click
                Dim seat As Seat = seats.Find(Function(p) p.SeatNo = btn.Name)
                If seat.Status = "A" Then
                    btn.Visible = True
                Else
                    btn.Visible = False
                End If
            End If
        Next

        If rs2.Count > 0 Then
            For Each item In rs2
                For Each seat In item.PurchasedSeats
                    Dim btnSeat As Button = CType(Me.Controls.Find(seat.SeatNum, True)(0), Button)
                    btnSeat.BackColor = Color.Red
                Next
            Next
        End If

    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        If btn.BackColor = Color.LightGreen Then
            btn.BackColor = Color.White
        ElseIf btn.BackColor = Color.White Then
            btn.BackColor = Color.LightGreen
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Dim purchase As New Purchase
        Dim purchasedSeat As New List(Of PurchasedSeat)

        For Each ctrl In grpSeat.Controls
            If ctrl.GetType = GetType(Button) Then
                Dim btn As Button = CType(ctrl, Button)
                If btn.BackColor = Color.White Then
                    Dim purchaseSeat As New PurchasedSeat
                    purchaseSeat.SeatNum = btn.Name
                    purchasedSeat.Add(purchaseSeat)
                End If
            End If
        Next

        purchase.VisitDate = Date.Now
        purchase.PurchasedSeats.AddRange(purchasedSeat)
        purchase.MovieScheduleID = movieScheduleId
        PurchaseSummary.purchase = purchase
        Me.Close()
        PurchaseSummary.ShowDialog()

    End Sub

End Class