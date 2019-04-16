Public Class MovieScheduleList


    Private Sub MovieSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim db As New demoDataContext
        Dim rs = From o In db.MovieSchedules


        dgvSchedule.DataSource = rs
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        MovieScheduleAdd.Show()

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim index As Integer = dgvSchedule.CurrentCell.RowIndex

        Dim db As New demoDataContext()
        Dim b As MovieSchedule = db.MovieSchedules.FirstOrDefault(Function(o) o.Id = dgvSchedule.CurrentRow.Cells(0).Value.ToString)

        Dim str As String = "Are you sure to delete ?"
        Dim resultDlg As Integer = MessageBox.Show(str, "Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If resultDlg = DialogResult.Cancel Then
            Exit Sub
        ElseIf resultDlg = DialogResult.OK Then
            dgvSchedule.Rows.RemoveAt(index)
            db.MovieSchedules.DeleteOnSubmit(b)
            db.SubmitChanges()
        End If

    End Sub
End Class