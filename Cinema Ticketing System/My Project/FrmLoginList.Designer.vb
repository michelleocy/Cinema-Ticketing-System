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
        Me.dgvAccount = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtRegister = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.AccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.dgvAccount.Location = New System.Drawing.Point(12, 25)
        Me.dgvAccount.Name = "dgvAccount"
        Me.dgvAccount.ReadOnly = True
        Me.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAccount.Size = New System.Drawing.Size(425, 206)
        Me.dgvAccount.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Staff Account List :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(362, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "&Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtRegister
        '
        Me.txtRegister.Location = New System.Drawing.Point(12, 238)
        Me.txtRegister.Name = "txtRegister"
        Me.txtRegister.Size = New System.Drawing.Size(75, 32)
        Me.txtRegister.TabIndex = 21
        Me.txtRegister.Text = "&Register"
        Me.txtRegister.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(281, 238)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 32)
        Me.btnLogout.TabIndex = 22
        Me.btnLogout.Text = "&Log Out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'AccountBindingSource
        '
        Me.AccountBindingSource.DataMember = "Account"
        '
        'FrmLoginList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 280)
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
    Friend WithEvents AccountBindingSource As BindingSource
    Friend WithEvents dgvAccount As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtRegister As Button
    Friend WithEvents btnLogout As Button
End Class
