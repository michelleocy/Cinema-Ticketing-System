<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLoginRegister
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Err = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.Err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblID.Location = New System.Drawing.Point(75, 12)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(131, 20)
        Me.lblID.TabIndex = 19
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(75, 92)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(131, 20)
        Me.txtPassword.TabIndex = 18
        '
        'txtIC
        '
        Me.txtIC.Location = New System.Drawing.Point(75, 66)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(131, 20)
        Me.txtIC.TabIndex = 17
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(75, 40)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(131, 20)
        Me.txtName.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "IC :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ID :"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(13, 127)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 20
        Me.btnRegister.Text = "&Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(171, 158)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(171, 127)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 22
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Err
        '
        Me.Err.ContainerControl = Me
        '
        'FrmLoginRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 193)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtIC)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLoginRegister"
        Me.Text = "FrmLoginRegister"
        CType(Me.Err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtIC As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Err As ErrorProvider
End Class
