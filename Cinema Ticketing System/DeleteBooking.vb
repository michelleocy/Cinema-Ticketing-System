Imports System.Data.DataTable

Public Class DeleteBooking

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtName.Clear()
        txtName.Select()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim index As Integer = dgvBooking.CurrentCell.RowIndex

        Dim db As New demoDataContext()
        Dim b As Booking = db.Bookings.FirstOrDefault(Function(o) o.BookingID = dgvBooking.CurrentRow.Cells(0).Value.ToString)

        Dim str As String = "Are you sure to delete ?"
        Dim resultDlg As Integer = MessageBox.Show(str, "Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If resultDlg = DialogResult.Cancel Then
            Exit Sub
        ElseIf resultDlg = DialogResult.OK Then
            dgvBooking.Rows.RemoveAt(index)
            db.Bookings.DeleteOnSubmit(b)
            db.SubmitChanges()
        End If

    End Sub

    Private Sub DeleteBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Booking' table. You can move, or remove it, as needed.
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

    Private Sub mnuBookingMakeBooking_Click(sender As Object, e As EventArgs) Handles mnuBookingMakeBooking.Click

        Me.Hide()
        MakeBooking.ShowDialog()

    End Sub

    Private Sub mnuBookingList_Click(sender As Object, e As EventArgs) Handles mnuBookingList.Click

        Me.Hide()
        ViewBookingList.ShowDialog()

    End Sub

    Private Sub mnuBookingUpdate_Click(sender As Object, e As EventArgs) Handles mnuBookingUpdate.Click

        Me.Hide()
        UpdateBooking.ShowDialog()

    End Sub

    Private Sub mnuBookingDelete_Click(sender As Object, e As EventArgs) Handles mnuBookingDelete.Click

        Me.ShowDialog()

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        End

    End Sub
End Class