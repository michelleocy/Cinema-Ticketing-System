Public Class FrmLoginUpdate
    Public SelectedId As String
    Private account As Account
    Private Sub ResetForm()
        lblID.Text = account.Id
        txtName.Text = account.Name
        txtIC.Text = account.Ic
        txtName.Focus()
        Err.Clear()
    End Sub

    Private Sub FrmLoginUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New demoDataContext


        account = (From i In db.Accounts
                   Where i.Id = SelectedId).First

        If account Is Nothing Then
            MessageBox.Show("Account not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        Else
            ResetForm()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Me.ValidateChildren = False Then
            Return
        End If

        Dim db As New demoDataContext

        Dim account = (From i In db.Accounts
                       Where i.Id = SelectedId).First
        account.Name = txtName.Text
        account.Ic = txtIC.Text
        If txtPassword.Text <> "" Then
            Dim md5 As New System.Security.Cryptography.MD5CryptoServiceProvider
            Dim bytes() As Byte = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(txtPassword.Text))
            Dim s As String
            For Each i As Byte In bytes
                s &= i.ToString("x2")
            Next
            account.Password = s
        End If

        db.SubmitChanges()

        MessageBox.Show("Account [" + SelectedId + "] updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim db As New demoDataContext
        Dim a As Account = db.Accounts.FirstOrDefault(Function(o) o.Id = SelectedId)

        If a Is Nothing Then
            MessageBox.Show("Account not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        db.Accounts.DeleteOnSubmit(a)
        db.SubmitChanges()
        MessageBox.Show("Account [" + SelectedId + "] deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class