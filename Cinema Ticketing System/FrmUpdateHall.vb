Public Class FrmUpdateHall
    Private selectedHall As New Hall
    Private db As New demoDataContext
    Public hallId As Integer
    Private seats As List(Of Seat)

    Private Sub FrmUpdateHall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Clear()
        cboNumber.Items.Clear()

        selectedHall = (From h In db.Halls
                        Where h.Id = hallId).FirstOrDefault

        BindComboBox()

        txtName.Text = selectedHall.Name
        seats = selectedHall.Seats.ToList
    End Sub

    Private Sub BindComboBox()
        For index = 1 To 99
            cboNumber.Items.Add(index)
        Next
        Dim halls = From c In db.Halls
                    Where c.Number <> selectedHall.Number
        For Each hall In halls
            cboNumber.Items.Remove(hall.Number)
        Next
        cboNumber.SelectedItem = selectedHall.Number
    End Sub

    Private Sub btnEditLayout_Click(sender As Object, e As EventArgs) Handles btnEditLayout.Click
        FrmHallLayoutEditor.seatsTemp = seats
        FrmHallLayoutEditor.ShowDialog()
        seats = FrmHallLayoutEditor.seatsTemp
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        selectedHall.Seats = Nothing
        selectedHall.Seats.AddRange(seats)
        selectedHall.Name = txtName.Text
        selectedHall.Number = Integer.Parse(cboNumber.Text)
        db.SubmitChanges()
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnManageSeat_Click(sender As Object, e As EventArgs) Handles btnManageSeat.Click
        FrmManageHallSeat.seatsTemp = seats
        FrmManageHallSeat.ShowDialog()
        seats = FrmManageHallSeat.seatsTemp
    End Sub
End Class