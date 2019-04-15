Public Class FrmAddHall
    Private db As New demoDataContext
    Public seats As New List(Of Seat)
    Private isLayoutEdited As Boolean

    Private Sub AddNewHall(newHall As Hall)
        newHall.Seats.AddRange(seats)
        db.Halls.InsertOnSubmit(newHall)
        db.SubmitChanges()
        MessageBox.Show("Hall successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BindComboBox()
        Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim newHall As New Hall With {
        .Number = Integer.Parse(cboNumber.Text),
        .Name = txtName.Text,
        .Status = "A"
        }
        If Not isLayoutEdited Then
            Dim result1 As Integer = MessageBox.Show("Are you sure you want to proceed without editing the hall's layout?", "Confirmation",
                            MessageBoxButtons.YesNo, MessageBoxIcon.None)
            If result1 = DialogResult.No Then
                Return
            End If
        End If
        If txtName.Text.Equals("") Then
            Dim result2 As Integer = MessageBox.Show("Are you sure you want to proceed without entering a hall's name?", "Confirmation",
                            MessageBoxButtons.YesNo, MessageBoxIcon.None)
            If result2 = DialogResult.Yes Then
                newHall.Name = Nothing
                AddNewHall(newHall)
            End If
        Else
            AddNewHall(newHall)
        End If
    End Sub

    Private Sub FrmAddHall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isLayoutEdited = False

        BindComboBox()

        For Each ctrl In FrmHallLayoutEditor.grpSeat.Controls
            If ctrl.GetType = GetType(Button) Then
                Dim seat As New Seat
                Dim btn As Button = CType(ctrl, Button)
                seat.SeatNo = btn.Name
                seat.Status = "A"
                seats.Add(seat)
            End If
        Next
    End Sub

    Private Sub BindComboBox()
        For index = 1 To 99
            cboNumber.Items.Add(index)
        Next
        Dim halls = From c In db.Halls

        If halls.Count > 0 Then
            For Each hall In halls
                cboNumber.Items.Remove(hall.Number)
            Next
        End If
        cboNumber.SelectedIndex = 0
    End Sub

    Private Sub btnEditLayout_Click(sender As Object, e As EventArgs) Handles btnEditLayout.Click
        FrmHallLayoutEditor.seatsOri = seats
        FrmHallLayoutEditor.ShowDialog()
        seats = FrmHallLayoutEditor.seatsTemp
        isLayoutEdited = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class