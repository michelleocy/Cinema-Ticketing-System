<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewPurchase
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
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDateAvailable = New System.Windows.Forms.DateTimePicker()
        Me.lblMovie = New System.Windows.Forms.Label()
        Me.cboMovie = New System.Windows.Forms.ComboBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.cboTime = New System.Windows.Forms.ComboBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.nudAmount = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(109, 40)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(36, 13)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "&Date :"
        '
        'dtpDateAvailable
        '
        Me.dtpDateAvailable.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateAvailable.Location = New System.Drawing.Point(148, 40)
        Me.dtpDateAvailable.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpDateAvailable.Name = "dtpDateAvailable"
        Me.dtpDateAvailable.Size = New System.Drawing.Size(101, 20)
        Me.dtpDateAvailable.TabIndex = 11
        '
        'lblMovie
        '
        Me.lblMovie.AutoSize = True
        Me.lblMovie.Location = New System.Drawing.Point(104, 82)
        Me.lblMovie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMovie.Name = "lblMovie"
        Me.lblMovie.Size = New System.Drawing.Size(42, 13)
        Me.lblMovie.TabIndex = 12
        Me.lblMovie.Text = "&Movie :"
        '
        'cboMovie
        '
        Me.cboMovie.FormattingEnabled = True
        Me.cboMovie.Location = New System.Drawing.Point(148, 76)
        Me.cboMovie.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMovie.Name = "cboMovie"
        Me.cboMovie.Size = New System.Drawing.Size(92, 21)
        Me.cboMovie.TabIndex = 13
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(108, 121)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(36, 13)
        Me.lblTime.TabIndex = 14
        Me.lblTime.Text = "&Time :"
        '
        'cboTime
        '
        Me.cboTime.FormattingEnabled = True
        Me.cboTime.Location = New System.Drawing.Point(148, 119)
        Me.cboTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTime.Name = "cboTime"
        Me.cboTime.Size = New System.Drawing.Size(92, 21)
        Me.cboTime.TabIndex = 15
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(154, 194)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(56, 29)
        Me.btnNext.TabIndex = 16
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(95, 158)
        Me.lblAmount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(49, 13)
        Me.lblAmount.TabIndex = 17
        Me.lblAmount.Text = "&Amount :"
        '
        'nudAmount
        '
        Me.nudAmount.Location = New System.Drawing.Point(148, 156)
        Me.nudAmount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nudAmount.Name = "nudAmount"
        Me.nudAmount.Size = New System.Drawing.Size(91, 20)
        Me.nudAmount.TabIndex = 19
        '
        'NewPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 237)
        Me.Controls.Add(Me.nudAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.cboTime)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.cboMovie)
        Me.Controls.Add(Me.lblMovie)
        Me.Controls.Add(Me.dtpDateAvailable)
        Me.Controls.Add(Me.lblDate)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "NewPurchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Purchase"
        CType(Me.nudAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents dtpDateAvailable As DateTimePicker
    Friend WithEvents lblMovie As Label
    Friend WithEvents cboMovie As ComboBox
    Friend WithEvents lblTime As Label
    Friend WithEvents cboTime As ComboBox
    Friend WithEvents btnNext As Button
    Friend WithEvents lblAmount As Label
    Friend WithEvents nudAmount As NumericUpDown
End Class
