<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MovieAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picPoster = New System.Windows.Forms.PictureBox()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cboRate = New System.Windows.Forms.ComboBox()
        Me.RichTxtDesc = New System.Windows.Forms.RichTextBox()
        Me.cboDuration = New System.Windows.Forms.ComboBox()
        CType(Me.picPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPoster
        '
        Me.picPoster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPoster.Location = New System.Drawing.Point(129, 77)
        Me.picPoster.Name = "picPoster"
        Me.picPoster.Size = New System.Drawing.Size(217, 207)
        Me.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPoster.TabIndex = 0
        Me.picPoster.TabStop = False
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(256, 292)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(90, 23)
        Me.BtnBrowse.TabIndex = 1
        Me.BtnBrowse.Text = "Browse Image"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Movie Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Movie Rate :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 474)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Movie Duration :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Movie Poster :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Movie Description :"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(53, 544)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(148, 544)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(246, 544)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(129, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(217, 20)
        Me.txtName.TabIndex = 10
        '
        'cboRate
        '
        Me.cboRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRate.FormattingEnabled = True
        Me.cboRate.Items.AddRange(New Object() {"U", "PG13", "PG18"})
        Me.cboRate.Location = New System.Drawing.Point(129, 41)
        Me.cboRate.Name = "cboRate"
        Me.cboRate.Size = New System.Drawing.Size(217, 21)
        Me.cboRate.TabIndex = 11
        '
        'RichTxtDesc
        '
        Me.RichTxtDesc.Location = New System.Drawing.Point(129, 321)
        Me.RichTxtDesc.Name = "RichTxtDesc"
        Me.RichTxtDesc.Size = New System.Drawing.Size(217, 121)
        Me.RichTxtDesc.TabIndex = 13
        Me.RichTxtDesc.Text = ""
        '
        'cboDuration
        '
        Me.cboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDuration.FormattingEnabled = True
        Me.cboDuration.Items.AddRange(New Object() {"1:20:00", "1:30:00", "1:45:00", "2:00:00", "2:30:00", "3:10:00"})
        Me.cboDuration.Location = New System.Drawing.Point(129, 471)
        Me.cboDuration.Name = "cboDuration"
        Me.cboDuration.Size = New System.Drawing.Size(217, 21)
        Me.cboDuration.TabIndex = 14
        '
        'MovieAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 579)
        Me.Controls.Add(Me.cboDuration)
        Me.Controls.Add(Me.RichTxtDesc)
        Me.Controls.Add(Me.cboRate)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.picPoster)
        Me.Name = "MovieAdd"
        Me.Text = "MovieAdd"
        CType(Me.picPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPoster As PictureBox
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents cboRate As ComboBox
    Friend WithEvents RichTxtDesc As RichTextBox
    Friend WithEvents cboDuration As ComboBox
End Class
