Imports System.Text
Public Class MovieUpdate
    Public selectedId As String
    Private Sub MovieUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Shown

        Dim db As New demoDataContext()
        Dim m As Movie = db.Movies.FirstOrDefault(Function(o) o.Id = Integer.Parse(MovieList.dgvMovie.SelectedRows(0).Cells(0).Value))

        If m Is Nothing Then
            MessageBox.Show("Movies not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        lblID.Text = m.Id.ToString("")
        txtName.Text = m.MovieName
        cboRate.Text = m.MovieRate
        RichTxtDesc.Text = m.MovieDescription
        cboDuration.Text = m.Duration

    End Sub
    Private Sub txtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating

        Dim name As String = txtName.Text

        If name = "" Then
            err.SetError(txtName, "Please enter valid [Name]")
            e.Cancel = True
        Else
            err.SetError(txtName, Nothing)
        End If

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Me.ValidateChildren() = False Then
            Return
        End If
        Dim db As New demoDataContext()
        Dim m As Movie = db.Movies.FirstOrDefault(Function(o) o.Id = Integer.Parse(MovieList.dgvMovie.SelectedRows(0).Cells(0).Value))
        If m Is Nothing Then
            MessageBox.Show("Movie not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing


        If txtName.Text = "" Then
            err.AppendLine("----Movie name empty!----")
            ctr = If(ctr, txtName)
        End If
        If cboRate.Text = "" Then
            err.AppendLine("-----Age Rate empty!-----")
            ctr = If(ctr, cboRate)
        End If
        If RichTxtDesc.Text = "" Then
            err.AppendLine("---Description empty!----")
            ctr = If(ctr, RichTxtDesc)
        End If
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr.Focus()
            Return
        End If

        Dim name As String = txtName.Text
        Dim rate As String = cboRate.Text
        Dim desc As String = RichTxtDesc.Text
        Dim duration As String = cboDuration.Text
        m.MovieName = name
        m.MovieRate = rate
        m.MovieDescription = desc
        m.Duration = duration


        db.SubmitChanges()
        Dim str As String = "Movie is updated"
        Me.Close()
        MessageBox.Show(str, "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Me.ValidateChildren() = False Then
            Return
        End If
        Dim db As New demoDataContext()
        Dim s As Movie = db.Movies.FirstOrDefault(Function(o) o.Id = Integer.Parse(MovieList.dgvMovie.SelectedRows(0).Cells(0).Value))
        If s Is Nothing Then
            MessageBox.Show("Movie not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        db.Movies.DeleteOnSubmit(s)
        db.SubmitChanges()
        Dim str As String = "Movie is deleted from lists"
        Me.Close()
        MessageBox.Show(str, "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class