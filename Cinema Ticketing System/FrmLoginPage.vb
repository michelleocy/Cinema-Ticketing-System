Public Class FrmLoginPage
    Private Sub FrmLoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim db As New demoDataContext()

        Dim id As String = txtID.Text
        Dim password As String = txtPassword.Text

        Try

            If id = "" Or password = "" Then
                MessageBox.Show("[ Text field cannot be null ]", "Login Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim account As Account = db.Accounts.FirstOrDefault(Function(o) o.Id = id)
                If account IsNot Nothing Then
                    Dim md5 As New Security.Cryptography.MD5CryptoServiceProvider
                    Dim bytes() As Byte = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(password))
                    Dim s As String
                    For Each i As Byte In bytes
                        s &= i.ToString("x2")
                    Next
                    If s <> account.Password Then
                        MessageBox.Show("--- [ Admin password wrong, Try again ]", "Login Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtPassword.Text = ""
                        Return
                    End If
                    MessageBox.Show(" Login Successful! ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FrmLoginList.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Wrong id ", "Login Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("--- [ Staff not found, Try again ]", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtID.Text = ""
            txtPassword.Text = ""
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtID.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class