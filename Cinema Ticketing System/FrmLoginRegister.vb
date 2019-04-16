Public Class FrmLoginRegister
    Private newAccountId As String
    Private Sub ResetForm()
        txtName.Clear()
        txtIC.Clear()
        txtPassword.Clear()
        txtName.Focus()
        Information.Err.Clear()
    End Sub

    Private Sub FrmLoginRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New demoDataContext
        Dim account = (From i In db.Accounts).ToArray().LastOrDefault
        If account IsNot Nothing Then
            newAccountId = "CN" + (Integer.Parse(account.Id.Substring(3)) + 1).ToString("0000")
        Else
            newAccountId = "CN0001"
        End If
        lblID.Text = newAccountId
    End Sub

    Private Sub FrmLoginRegister_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ResetForm()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) _
        Handles txtName.Validating
        If txtName.Text = "" Then
            Err.SetError(txtName, "Please enter valid [Name]")
            e.Cancel = True
        Else
            Err.SetError(txtName, Nothing)
        End If
    End Sub

    Private Sub txtIc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) _
        Handles txtIC.Validating
        If txtIC.Text = "" Then
            Err.SetError(txtIC, "Please enter valid [Ic]")
            e.Cancel = True
        Else
            Err.SetError(txtIC, Nothing)
        End If
    End Sub

    Private Sub txtPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) _
        Handles txtPassword.Validating
        If txtPassword.Text = "" Then
            Err.SetError(txtPassword, "Please enter valid [Password]")
            e.Cancel = True
        Else
            Err.SetError(txtPassword, Nothing)
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim name As String = txtName.Text
        Dim ic As String = txtIC.Text
        Dim password As String = txtPassword.Text

        Dim PassEn = txtPassword.Text
        Dim md5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim bytes() As Byte = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(PassEn))
        Dim s As String
        For Each i As Byte In bytes
            s &= i.ToString("x2")
        Next

        Dim db As New demoDataContext

        Dim account As New Account With {
        .Id = newAccountId,
        .Name = name,
        .Ic = ic,
        .Password = s
        }

        db.Accounts.InsertOnSubmit(account)
        db.SubmitChanges()
        MessageBox.Show("Account [" + newAccountId + "] registered", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ResetForm()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub
End Class