Public Class FrmHallLayoutEditor
    Public seatsTemp As New List(Of Seat)
    Private isLayoutEdited As Boolean

    Private Sub FrmHallLayoutEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isLayoutEdited = False
        For Each ctrl In grpSeat.Controls
            If ctrl.GetType = GetType(Button) Then
                Dim btn As Button = CType(ctrl, Button)
                AddHandler btn.Click, AddressOf button_Click
                Dim seat As Seat = seatsTemp.Find(Function(p) p.SeatNo = btn.Name)
                If seat.Status = "A" Then
                    btn.BackColor = Color.LightGreen
                    btn.ForeColor = Color.Black
                ElseIf seat.Status = "R" Then
                    btn.BackColor = Color.Blue
                    btn.ForeColor = Color.Black
                Else
                    btn.BackColor = Color.Gray
                    btn.ForeColor = Color.White
                End If
            End If
        Next
    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        If btn.BackColor = Color.Gray Then
            If seatsTemp.Find(Function(p) p.SeatNo = btn.Name).Status = "A" Then
                btn.ForeColor = Color.Black
                btn.BackColor = Color.LightGreen
            Else
                btn.ForeColor = Color.Black
                btn.BackColor = Color.Blue
            End If
        Else
            btn.ForeColor = Color.White
            btn.BackColor = Color.Gray
        End If
        isLayoutEdited = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        For Each ctrl In grpSeat.Controls
            If ctrl.GetType = GetType(Button) Then
                Dim btn As Button = CType(ctrl, Button)
                Dim seat As Seat = seatsTemp.Find(Function(p) p.SeatNo = btn.Name)
                If btn.BackColor = Color.LightGreen Then
                    seat.Status = "A"
                Else
                    seat.Status = "D"
                End If
            End If
        Next
        Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to set all the seats to available?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.None)
        If result = DialogResult.Yes Then
            For Each ctrl In grpSeat.Controls
                If ctrl.GetType = GetType(Button) Then
                    Dim btn As Button = CType(ctrl, Button)
                    btn.BackColor = Color.LightGreen
                    btn.ForeColor = Color.Black
                End If
            Next
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If isLayoutEdited Then
            Dim result = MessageBox.Show("Are you sure?" + vbNewLine + "Any changes made will not be saved.", "Confirmation",
                            MessageBoxButtons.YesNo, MessageBoxIcon.None)
            If result = DialogResult.Yes Then
                Close()
            End If
        Else
            Close()
        End If
    End Sub

    Private Sub FrmHallLayoutEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        For Each ctrl In grpSeat.Controls
            If ctrl.GetType = GetType(Button) Then
                Dim btn As Button = CType(ctrl, Button)
                RemoveHandler btn.Click, AddressOf button_Click
            End If
        Next
    End Sub
End Class