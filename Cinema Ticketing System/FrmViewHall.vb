Public Class FrmViewHall


    Private Sub BindData()
        Dim db As New demoDataContext
        dgvHallList.Rows.Clear()
        Dim halls = From h In db.Halls
        dgvHallList.DataSource = halls

        dgvHallList.Columns(0).Visible = False
        dgvHallList.Columns(1).HeaderText = "Hall Name"
        dgvHallList.Columns(2).HeaderText = "Hall Number"

        dgvHallList.AutoGenerateColumns = False
        dgvHallList.Columns(2).DisplayIndex = 1
        dgvHallList.Columns(1).DisplayIndex = 2

        dgvHallList.Columns(1).Width = 250
        dgvHallList.Columns(2).Width = 90
        dgvHallList.Columns(3).Width = 100
    End Sub

    Private Sub FrmViewHall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
        dgvHallList.Sort(dgvHallList.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub dgvHallList_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvHallList.CellFormatting

        If e.ColumnIndex = 1 Then
            If e.Value Is Nothing OrElse e.Value.ToString = "" Then
                e.Value = "No Name"
                e.CellStyle.ForeColor = Color.Gray
                e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Italic)
            End If
        End If

        If e.ColumnIndex = 3 Then
            If e.Value.ToString = "A" Then
                e.Value = "Active"
                e.CellStyle.ForeColor = Color.Green
            ElseIf e.Value.ToString = "D" Then
                e.Value = "Disabled"
                e.CellStyle.ForeColor = Color.Red
            End If
        End If
    End Sub


    Private Sub updateHall()
        FrmUpdateHall.hallId = Integer.Parse(dgvHallList.SelectedRows(0).Cells(0).Value.ToString)
        FrmUpdateHall.ShowDialog()
        BindData()
    End Sub

    Private Sub dgvHallList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHallList.CellDoubleClick
        updateHall()
    End Sub

    Private Sub btnAddHall_Click(sender As Object, e As EventArgs) Handles btnAddHall.Click
        FrmAddHall.ShowDialog()
        BindData()
    End Sub

    Private Sub btnEditHall_Click(sender As Object, e As EventArgs) Handles btnEditHall.Click
        updateHall()
    End Sub

    Private Sub btnDeleteHall_Click(sender As Object, e As EventArgs) Handles btnDeleteHall.Click
        Dim db As New demoDataContext

        If btnDeleteHall.Text = "Enable Hall" Then
            Dim result As Integer = MessageBox.Show("Are you sure you want to enable the hall?",
                                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.None)
            If result = DialogResult.Yes Then
                Dim hall = (From h In db.Halls
                            Where h.Id = Integer.Parse(dgvHallList.SelectedRows(0).Cells(0).Value.ToString)).FirstOrDefault
                hall.Status = "A"
            Else
                Return
            End If
        Else
            Dim rs = From h In db.MovieSchedules
                     Where h.HallId = Integer.Parse(dgvHallList.SelectedRows(0).Cells(0).Value.ToString)

            If rs.Count > 0 Then
                Dim result As Integer = MessageBox.Show("The hall was used, to prevent data loss the hall cannot be deleted." + vbNewLine + "Do you want to disable the hall instead?",
                                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.None)
                If result = DialogResult.Yes Then
                    Dim hall = (From h In db.Halls
                                Where h.Id = Integer.Parse(dgvHallList.SelectedRows(0).Cells(0).Value.ToString)).FirstOrDefault
                    hall.Status = "D"
                Else
                    Return
                End If
            Else
                Dim result As Integer = MessageBox.Show("Are you sure you want to delete the hall?",
                                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.None)
                If result = DialogResult.Yes Then
                    Dim hall = (From h In db.Halls
                                Where h.Id = Integer.Parse(dgvHallList.SelectedRows(0).Cells(0).Value)).FirstOrDefault
                    db.Seats.DeleteAllOnSubmit(hall.Seats)
                    db.Halls.DeleteOnSubmit(hall)
                Else
                    Return
                End If
            End If

        End If
        db.SubmitChanges()
        BindData()
    End Sub

    Private Sub dgvHallList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHallList.CellClick
        If dgvHallList.SelectedRows(0).Cells(3).Value.ToString = "D" Then
            btnDeleteHall.Text = "Enable Hall"
            btnDeleteHall.BackColor = Color.CadetBlue
        Else
            btnDeleteHall.Text = "Delete Hall"
        End If
    End Sub
End Class