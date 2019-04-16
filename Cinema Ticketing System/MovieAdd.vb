Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class MovieAdd


    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Dim imgLocation As String = ""
        Dim dialog = New OpenFileDialog()

        dialog.Filter = "png files(.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*"
        If (dialog.ShowDialog() = DialogResult.OK) Then
            imgLocation = dialog.FileName.ToString()
            picPoster.ImageLocation = imgLocation
        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        MovieList.Refresh()
    End Sub
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Text = ""
        RichTxtDesc.Text = ""
        cboDuration.SelectedIndex = -1
        cboRate.SelectedIndex = -1
        picPoster.Refresh()
        txtName.Select()
    End Sub
    Public Sub ResetForm()
        txtName.Text = ""
        RichTxtDesc.Text = ""
        cboDuration.SelectedIndex = -1
        cboRate.SelectedIndex = -1
        picPoster.Image = Nothing
        txtName.Select()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.ValidateChildren() = False Then
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

        Dim s As New Movie
        s.MovieName = txtName.Text
        s.MovieDescription = RichTxtDesc.Text
        s.MovieRate = cboRate.Text
        s.Duration = cboDuration.Text

        Dim ms As New MemoryStream
            picPoster.Image.Save(ms, picPoster.Image.RawFormat)
            s.MoviePoster = ms.ToArray()

        s.Id += 1
        Dim db As New demoDataContext()
        db.Movies.InsertOnSubmit(s)
        db.SubmitChanges()

        Dim str As String = "Movies is inserted"
        MessageBox.Show(str, "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ResetForm()

    End Sub


End Class