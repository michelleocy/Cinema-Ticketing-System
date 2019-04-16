Imports System.Text
Public Class MovieScheduleAdd


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim db As New demoDataContext
        Dim s As New MovieSchedule
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        If cboName.Text = "" Then
            err.AppendLine("----Movie name empty!----")
            ctr = If(ctr, cboName)
        End If
        If cboTime.Text = "" Then
            err.AppendLine("-----Movie Time empty!-----")
            ctr = If(ctr, cboTime)
        End If
        If cbohall.Text = "" Then
            err.AppendLine("---Movie Hall empty!----")
            ctr = If(ctr, cbohall)
        End If
        If nudPrice.Text = "" Then
            err.AppendLine("---Ticket Price empty!----")
            ctr = If(ctr, nudPrice)
        End If
        If Err.Length > 0 Then
            MessageBox.Show(Err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        s.Time = cboTime.SelectedIndex + 1
        s.MovieID = Integer.Parse(CType(cboName.SelectedItem, DictionaryEntry).Key)

        s.HallId = Integer.Parse(CType(cbohall.SelectedItem, DictionaryEntry).Key)
        s.TicketPrice = nudPrice.Text
        s.Date = dtpDate.Value

        db.MovieSchedules.InsertOnSubmit(s)
        db.SubmitChanges()
        Dim str As String = "Movies is inserted"
        MessageBox.Show(str, "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

        Dim rs1 = From o In db.MovieSchedules
        MovieScheduleList.dgvSchedule.DataSource = rs1

    End Sub

    Private Sub MovieScheduleAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New demoDataContext
        Dim rs = From movie In db.Movies

        cboName.DisplayMember = "Value"
        cboName.ValueMember = "Key"

        For Each movie In rs
            cboName.Items.Add(New DictionaryEntry(movie.Id, movie.MovieName))
        Next

        Dim halls = From h In db.Halls
                    Where h.Status = "A"
        cbohall.DisplayMember = "Value"
        cbohall.ValueMember = "Key"
        For Each hall In halls
            cbohall.Items.Add(New DictionaryEntry(hall.Id, "Hall " + hall.Number.ToString))
        Next

    End Sub
End Class