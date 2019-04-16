<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLoginList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.txtRegister = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvAccount = New System.Windows.Forms.DataGridView()
        Me.AccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(372, 291)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 39)
        Me.btnLogout.TabIndex = 27
        Me.btnLogout.Text = "&Log Out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'txtRegister
        '
        Me.txtRegister.Location = New System.Drawing.Point(13, 291)
        Me.txtRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegister.Name = "txtRegister"
        Me.txtRegister.Size = New System.Drawing.Size(100, 39)
        Me.txtRegister.TabIndex = 26
        Me.txtRegister.Text = "&Register"
        Me.txtRegister.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(480, 291)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 39)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "&Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Staff Account List :"
        '
        'dgvAccount
        '
        Me.dgvAccount.AllowUserToAddRows = False
        Me.dgvAccount.AllowUserToDeleteRows = False
        Me.dgvAccount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccount.Location = New System.Drawing.Point(13, 29)
        Me.dgvAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvAccount.Name = "dgvAccount"
        Me.dgvAccount.ReadOnly = True
        Me.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAccount.Size = New System.Drawing.Size(567, 254)
        Me.dgvAccount.TabIndex = 23
        '
        'AccountBindingSource
        '
        Me.AccountBindingSource.DataMember = "Account"
        '
        'FrmLoginList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 345)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.txtRegister)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvAccount)
        Me.Name = "FrmLoginList"
        Me.Text = "FrmLoginList"
        CType(Me.dgvAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents txtRegister As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvAccount As DataGridView
    Friend WithEvents AccountBindingSource As BindingSource
End Class
