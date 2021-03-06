﻿Public Class FrmManageHallSeat
    Public seatsTemp As New List(Of Seat)
    Public seatsOri As New List(Of Seat)
    Private isLayoutEdited As Boolean

    Private Sub FrmManageHallSeat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seatsTemp = seatsOri
        isLayoutEdited = False
        bindSeats()
        For Each ctrl In grpSeat.Controls
            If ctrl.GetType = GetType(Button) Then
                Dim btn As Button = CType(ctrl, Button)
                AddHandler btn.Click, AddressOf button_Click
            End If
        Next
    End Sub

    Private Sub bindSeats()
        For Each ctrl In grpSeat.Controls
            If ctrl.GetType = GetType(Button) Then
                Dim btn As Button = CType(ctrl, Button)
                Dim seat As Seat = seatsTemp.Find(Function(p) p.SeatNo = btn.Name)
                If seat.Status = "A" Then
                    btn.BackColor = Color.LightGreen
                    btn.ForeColor = Color.Black
                    btn.Visible = True
                ElseIf seat.Status = "R" Then
                    btn.BackColor = Color.Blue
                    btn.ForeColor = Color.Black
                    btn.Visible = True
                Else
                    btn.BackColor = Color.Gray
                    btn.ForeColor = Color.White
                    btn.Visible = False
                End If
            End If
        Next
    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        If btn.BackColor = Color.LightGreen Then
            btn.BackColor = Color.Blue
        Else
            btn.BackColor = Color.LightGreen
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
                ElseIf btn.BackColor = Color.Blue Then
                    seat.Status = "R"
                Else
                    seat.Status = "D"
                End If
            End If
        Next
        Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to reset the seats?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.None)
        If result = DialogResult.Yes Then
            seatsOri = seatsTemp
            bindSeats()
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

    Private Sub FrmManageHallSeat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        For Each ctrl In grpSeat.Controls
            If ctrl.GetType = GetType(Button) Then
                Dim btn As Button = CType(ctrl, Button)
                RemoveHandler btn.Click, AddressOf button_Click
            End If
        Next
    End Sub
End Class