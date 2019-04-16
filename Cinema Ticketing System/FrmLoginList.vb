Public Class FrmLoginList

    Private Sub BindData()
        Dim db As New demoDataContext()
        Dim rs = From c In db.Accounts

        dgvAccount.DataSource = rs
    End Sub

    Private Sub FrmLoginMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub dgvAccount_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccount.CellDoubleClick
        Dim id As String = (dgvAccount.SelectedRows(0).Cells(0).Value).ToString
        FrmLoginUpdate.SelectedId = id
        FrmLoginUpdate.ShowDialog(Me)
        BindData()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles txtRegister.Click
        FrmLoginRegister.ShowDialog(Me)
        BindData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MessageBox.Show(" Log Out Successful! ", "LogOut", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim frm = New FrmLoginPage
        frm.Show()
        Me.Close()

    End Sub
End Class