<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieList
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
        Me.btnAddMov = New System.Windows.Forms.Button()
        Me.btnExitMov = New System.Windows.Forms.Button()
        Me.txtMovieName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboRating = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvMovie = New System.Windows.Forms.DataGridView()
        Me.picDesc = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMovDuration = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.docu = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgvMovie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddMov
        '
        Me.btnAddMov.Location = New System.Drawing.Point(737, 386)
        Me.btnAddMov.Name = "btnAddMov"
        Me.btnAddMov.Size = New System.Drawing.Size(75, 23)
        Me.btnAddMov.TabIndex = 2
        Me.btnAddMov.Text = "&Add"
        Me.btnAddMov.UseVisualStyleBackColor = True
        '
        'btnExitMov
        '
        Me.btnExitMov.Location = New System.Drawing.Point(737, 415)
        Me.btnExitMov.Name = "btnExitMov"
        Me.btnExitMov.Size = New System.Drawing.Size(75, 23)
        Me.btnExitMov.TabIndex = 4
        Me.btnExitMov.Text = "E&xit"
        Me.btnExitMov.UseVisualStyleBackColor = True
        '
        'txtMovieName
        '
        Me.txtMovieName.Location = New System.Drawing.Point(113, 6)
        Me.txtMovieName.Name = "txtMovieName"
        Me.txtMovieName.Size = New System.Drawing.Size(160, 20)
        Me.txtMovieName.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Movie Name :"
        '
        'cboRating
        '
        Me.cboRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRating.FormattingEnabled = True
        Me.cboRating.Items.AddRange(New Object() {"All", "U", "PG13", "PG18"})
        Me.cboRating.Location = New System.Drawing.Point(113, 42)
        Me.cboRating.Name = "cboRating"
        Me.cboRating.Size = New System.Drawing.Size(160, 21)
        Me.cboRating.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Movie Age Rating:"
        '
        'dgvMovie
        '
        Me.dgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovie.Location = New System.Drawing.Point(15, 83)
        Me.dgvMovie.Name = "dgvMovie"
        Me.dgvMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovie.Size = New System.Drawing.Size(341, 355)
        Me.dgvMovie.TabIndex = 10
        '
        'picDesc
        '
        Me.picDesc.Location = New System.Drawing.Point(0, 19)
        Me.picDesc.Name = "picDesc"
        Me.picDesc.Size = New System.Drawing.Size(183, 159)
        Me.picDesc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDesc.TabIndex = 10
        Me.picDesc.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblMovDuration)
        Me.GroupBox1.Controls.Add(Me.lblDesc)
        Me.GroupBox1.Controls.Add(Me.picDesc)
        Me.GroupBox1.Location = New System.Drawing.Point(384, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 355)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Movie Duration :"
        '
        'lblMovDuration
        '
        Me.lblMovDuration.Location = New System.Drawing.Point(189, 32)
        Me.lblMovDuration.Name = "lblMovDuration"
        Me.lblMovDuration.Size = New System.Drawing.Size(100, 23)
        Me.lblMovDuration.TabIndex = 12
        '
        'lblDesc
        '
        Me.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesc.Location = New System.Drawing.Point(0, 181)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(332, 171)
        Me.lblDesc.TabIndex = 11
        '
        'MovieList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvMovie)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboRating)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMovieName)
        Me.Controls.Add(Me.btnExitMov)
        Me.Controls.Add(Me.btnAddMov)
        Me.Name = "MovieList"
        Me.Text = "MovieList"
        CType(Me.dgvMovie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDesc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddMov As Button
    Friend WithEvents btnExitMov As Button
    Friend WithEvents txtMovieName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboRating As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvMovie As DataGridView
    Friend WithEvents picDesc As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblMovDuration As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents docu As Printing.PrintDocument
End Class
