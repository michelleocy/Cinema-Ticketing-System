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
        Me.mnuCinema = New System.Windows.Forms.MenuStrip()
        Me.mnuBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingMakeBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingList = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBookingUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.nudAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuCinema.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(145, 49)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(46, 17)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "&Date :"
        '
        'dtpDateAvailable
        '
        Me.dtpDateAvailable.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateAvailable.Location = New System.Drawing.Point(197, 49)
        Me.dtpDateAvailable.Name = "dtpDateAvailable"
        Me.dtpDateAvailable.Size = New System.Drawing.Size(133, 22)
        Me.dtpDateAvailable.TabIndex = 11
        '
        'lblMovie
        '
        Me.lblMovie.AutoSize = True
        Me.lblMovie.Location = New System.Drawing.Point(138, 101)
        Me.lblMovie.Name = "lblMovie"
        Me.lblMovie.Size = New System.Drawing.Size(53, 17)
        Me.lblMovie.TabIndex = 12
        Me.lblMovie.Text = "&Movie :"
        '
        'cboMovie
        '
        Me.cboMovie.FormattingEnabled = True
        Me.cboMovie.Location = New System.Drawing.Point(197, 94)
        Me.cboMovie.Name = "cboMovie"
        Me.cboMovie.Size = New System.Drawing.Size(121, 24)
        Me.cboMovie.TabIndex = 13
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(144, 149)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(47, 17)
        Me.lblTime.TabIndex = 14
        Me.lblTime.Text = "&Time :"
        '
        'cboTime
        '
        Me.cboTime.FormattingEnabled = True
        Me.cboTime.Location = New System.Drawing.Point(197, 146)
        Me.cboTime.Name = "cboTime"
        Me.cboTime.Size = New System.Drawing.Size(121, 24)
        Me.cboTime.TabIndex = 15
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(206, 239)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 36)
        Me.btnNext.TabIndex = 16
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(127, 194)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(64, 17)
        Me.lblAmount.TabIndex = 17
        Me.lblAmount.Text = "&Amount :"
        '
        'nudAmount
        '
        Me.nudAmount.Location = New System.Drawing.Point(197, 192)
        Me.nudAmount.Name = "nudAmount"
        Me.nudAmount.Size = New System.Drawing.Size(121, 22)
        Me.nudAmount.TabIndex = 19
        '
        'mnuCinema
        '
        Me.mnuCinema.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuCinema.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBooking, Me.mnuExit})
        Me.mnuCinema.Location = New System.Drawing.Point(0, 0)
        Me.mnuCinema.Name = "mnuCinema"
        Me.mnuCinema.Size = New System.Drawing.Size(482, 28)
        Me.mnuCinema.TabIndex = 20
        Me.mnuCinema.Text = "MenuStrip1"
        '
        'mnuBooking
        '
        Me.mnuBooking.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBookingMakeBooking, Me.mnuBookingList, Me.ToolStripSeparator2, Me.mnuBookingUpdate, Me.mnuBookingDelete})
        Me.mnuBooking.Name = "mnuBooking"
        Me.mnuBooking.Size = New System.Drawing.Size(76, 24)
        Me.mnuBooking.Text = "&Booking"
        '
        'mnuBookingMakeBooking
        '
        Me.mnuBookingMakeBooking.Name = "mnuBookingMakeBooking"
        Me.mnuBookingMakeBooking.Size = New System.Drawing.Size(184, 26)
        Me.mnuBookingMakeBooking.Text = "&Make Booking"
        '
        'mnuBookingList
        '
        Me.mnuBookingList.Name = "mnuBookingList"
        Me.mnuBookingList.Size = New System.Drawing.Size(184, 26)
        Me.mnuBookingList.Text = "Booking &List"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(181, 6)
        '
        'mnuBookingUpdate
        '
        Me.mnuBookingUpdate.Name = "mnuBookingUpdate"
        Me.mnuBookingUpdate.Size = New System.Drawing.Size(184, 26)
        Me.mnuBookingUpdate.Text = "&Update Record"
        '
        'mnuBookingDelete
        '
        Me.mnuBookingDelete.Name = "mnuBookingDelete"
        Me.mnuBookingDelete.Size = New System.Drawing.Size(184, 26)
        Me.mnuBookingDelete.Text = "&Delete Record"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(45, 24)
        Me.mnuExit.Text = "E&xit"
        '
        'NewPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 292)
        Me.Controls.Add(Me.mnuCinema)
        Me.Controls.Add(Me.nudAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.cboTime)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.cboMovie)
        Me.Controls.Add(Me.lblMovie)
        Me.Controls.Add(Me.dtpDateAvailable)
        Me.Controls.Add(Me.lblDate)
        Me.Name = "NewPurchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Purchase"
        CType(Me.nudAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuCinema.ResumeLayout(False)
        Me.mnuCinema.PerformLayout()
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
    Friend WithEvents mnuCinema As MenuStrip
    Friend WithEvents mnuBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingMakeBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingList As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuBookingUpdate As ToolStripMenuItem
    Friend WithEvents mnuBookingDelete As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
