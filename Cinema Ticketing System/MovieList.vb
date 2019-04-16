Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class MovieList
    Public selectedId As String

    Private Sub BindData()
        Dim name As String = txtMovieName.Text
        Dim rating As String = cboRating.Text

        Dim db As New demoDataContext()
        Dim rs = From o In db.Movies
                 Where o.MovieName.Contains(txtMovieName.Text)
        If (cboRating.Text <> "All") Then
            rs = From o In db.Movies
                 Where o.MovieName.Contains(txtMovieName.Text) And
                 o.MovieRate = cboRating.Text
        End If

        dgvMovie.DataSource = rs

    End Sub
    Private Sub Onclick_show(sender As Object, e As EventArgs) Handles dgvMovie.CellClick, MyBase.Shown
        Dim DB As New demoDataContext()
        Dim c As Movie = DB.Movies.FirstOrDefault(Function(o) o.Id = Integer.Parse(dgvMovie.SelectedRows(0).Cells(0).Value))

        If c Is Nothing Then
            MessageBox.Show("Movies not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        lblDesc.Text = c.MovieDescription

        Dim ImgByte As Byte() = Nothing
        Dim img As Image
        Dim stream As MemoryStream
        ImgByte = c.MoviePoster.ToArray
        stream = New MemoryStream(ImgByte, 0, ImgByte.Length)
        img = Image.FromStream(stream)
        picDesc.Image = img

        lblMovDuration.Text = c.Duration
    End Sub

    Private Sub Double_click(sender As Object, e As EventArgs) Handles dgvMovie.CellDoubleClick
        MovieUpdate.Show()

    End Sub
    Private Sub MovieList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboRating.Text = "All"
        BindData()
    End Sub
    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtMovieName.TextChanged
        BindData()
    End Sub
    Private Sub cboRating_SelectedChanged(sender As Object, e As EventArgs) Handles cboRating.SelectedIndexChanged
        BindData()
    End Sub
    Private Sub BtnAdd_click(sender As Object, e As EventArgs) Handles btnAddMov.Click
        MovieAdd.Show()
        BindData()
    End Sub
    Private Sub BtnExitMov_Click(sender As Object, e As EventArgs) Handles btnExitMov.Click
        Me.Close()
    End Sub

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) 

    End Sub

End Class
