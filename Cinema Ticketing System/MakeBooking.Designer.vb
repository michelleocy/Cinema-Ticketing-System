<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MakeBooking
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.grbDetails = New System.Windows.Forms.GroupBox()
        Me.nudAmount = New System.Windows.Forms.NumericUpDown()
        Me.cboTime = New System.Windows.Forms.ComboBox()
        Me.dtpBookingDate = New System.Windows.Forms.DateTimePicker()
        Me.lblBookingDate = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.cboMovieName = New System.Windows.Forms.ComboBox()
        Me.mskIC = New System.Windows.Forms.MaskedTextBox()
        Me.lblMovieName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblMovieTime = New System.Windows.Forms.Label()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.mnuCinema = New System.Windows.Forms.MenuStrip()
        Me.mnuBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingMakeBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.grbDetails.SuspendLayout()
        CType(Me.nudAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuCinema.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(245, 354)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 33)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "C&ancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(154, 354)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 33)
        Me.btnConfirm.TabIndex = 7
        Me.btnConfirm.Text = "&Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'grbDetails
        '
        Me.grbDetails.Controls.Add(Me.nudAmount)
        Me.grbDetails.Controls.Add(Me.cboTime)
        Me.grbDetails.Controls.Add(Me.dtpBookingDate)
        Me.grbDetails.Controls.Add(Me.lblBookingDate)
        Me.grbDetails.Controls.Add(Me.lblAmount)
        Me.grbDetails.Controls.Add(Me.cboMovieName)
        Me.grbDetails.Controls.Add(Me.mskIC)
        Me.grbDetails.Controls.Add(Me.lblMovieName)
        Me.grbDetails.Controls.Add(Me.txtName)
        Me.grbDetails.Controls.Add(Me.lblMovieTime)
        Me.grbDetails.Controls.Add(Me.lblIC)
        Me.grbDetails.Controls.Add(Me.lblName)
        Me.grbDetails.Location = New System.Drawing.Point(74, 40)
        Me.grbDetails.Name = "grbDetails"
        Me.grbDetails.Size = New System.Drawing.Size(337, 298)
        Me.grbDetails.TabIndex = 6
        Me.grbDetails.TabStop = False
        Me.grbDetails.Text = "Booking details"
        '
        'nudAmount
        '
        Me.nudAmount.Location = New System.Drawing.Point(145, 248)
        Me.nudAmount.Name = "nudAmount"
        Me.nudAmount.Size = New System.Drawing.Size(121, 22)
        Me.nudAmount.TabIndex = 47
        '
        'cboTime
        '
        Me.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTime.FormattingEnabled = True
        Me.cboTime.Location = New System.Drawing.Point(128, 209)
        Me.cboTime.Name = "cboTime"
        Me.cboTime.Size = New System.Drawing.Size(121, 24)
        Me.cboTime.TabIndex = 46
        '
        'dtpBookingDate
        '
        Me.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBookingDate.Location = New System.Drawing.Point(124, 124)
        Me.dtpBookingDate.MaxDate = New Date(2019, 12, 31, 0, 0, 0, 0)
        Me.dtpBookingDate.MinDate = New Date(2019, 4, 9, 0, 0, 0, 0)
        Me.dtpBookingDate.Name = "dtpBookingDate"
        Me.dtpBookingDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpBookingDate.TabIndex = 45
        Me.dtpBookingDate.UseWaitCursor = True
        Me.dtpBookingDate.Value = New Date(2019, 4, 10, 0, 0, 0, 0)
        '
        'lblBookingDate
        '
        Me.lblBookingDate.AutoSize = True
        Me.lblBookingDate.Location = New System.Drawing.Point(8, 127)
        Me.lblBookingDate.Name = "lblBookingDate"
        Me.lblBookingDate.Size = New System.Drawing.Size(105, 17)
        Me.lblBookingDate.TabIndex = 44
        Me.lblBookingDate.Text = "Booking Date : "
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(8, 250)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(131, 17)
        Me.lblAmount.TabIndex = 4
        Me.lblAmount.Text = "Amount of &people : "
        '
        'cboMovieName
        '
        Me.cboMovieName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMovieName.FormattingEnabled = True
        Me.cboMovieName.Location = New System.Drawing.Point(124, 167)
        Me.cboMovieName.Name = "cboMovieName"
        Me.cboMovieName.Size = New System.Drawing.Size(191, 24)
        Me.cboMovieName.TabIndex = 42
        '
        'mskIC
        '
        Me.mskIC.Location = New System.Drawing.Point(124, 76)
        Me.mskIC.Mask = "000000-00-0000"
        Me.mskIC.Name = "mskIC"
        Me.mskIC.Size = New System.Drawing.Size(148, 22)
        Me.mskIC.TabIndex = 6
        '
        'lblMovieName
        '
        Me.lblMovieName.AutoSize = True
        Me.lblMovieName.Location = New System.Drawing.Point(8, 170)
        Me.lblMovieName.Name = "lblMovieName"
        Me.lblMovieName.Size = New System.Drawing.Size(96, 17)
        Me.lblMovieName.TabIndex = 2
        Me.lblMovieName.Text = "&Movie name : "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(124, 38)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(148, 22)
        Me.txtName.TabIndex = 5
        '
        'lblMovieTime
        '
        Me.lblMovieTime.AutoSize = True
        Me.lblMovieTime.Location = New System.Drawing.Point(8, 212)
        Me.lblMovieTime.Name = "lblMovieTime"
        Me.lblMovieTime.Size = New System.Drawing.Size(114, 17)
        Me.lblMovieTime.TabIndex = 3
        Me.lblMovieTime.Text = "&Screening time : "
        '
        'lblIC
        '
        Me.lblIC.AutoSize = True
        Me.lblIC.Location = New System.Drawing.Point(8, 76)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(66, 17)
        Me.lblIC.TabIndex = 1
        Me.lblIC.Text = "User &IC : "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(8, 38)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(89, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "User &name : "
        '
        'mnuCinema
        '
        Me.mnuCinema.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuCinema.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBooking, Me.mnuExit})
        Me.mnuCinema.Location = New System.Drawing.Point(0, 0)
        Me.mnuCinema.Name = "mnuCinema"
        Me.mnuCinema.Size = New System.Drawing.Size(485, 28)
        Me.mnuCinema.TabIndex = 9
        Me.mnuCinema.Text = "MenuStrip1"
        '
        'mnuBooking
        '
        Me.mnuBooking.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBookingMakeBooking, Me.mnuBookingList})
        Me.mnuBooking.Name = "mnuBooking"
        Me.mnuBooking.Size = New System.Drawing.Size(76, 24)
        Me.mnuBooking.Text = "&Booking"
        '
        'mnuBookingMakeBooking
        '
        Me.mnuBookingMakeBooking.Name = "mnuBookingMakeBooking"
        Me.mnuBookingMakeBooking.Size = New System.Drawing.Size(179, 26)
        Me.mnuBookingMakeBooking.Text = "&Make Booking"
        '
        'mnuBookingList
        '
        Me.mnuBookingList.Name = "mnuBookingList"
        Me.mnuBookingList.Size = New System.Drawing.Size(179, 26)
        Me.mnuBookingList.Text = "Booking &List"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(45, 24)
        Me.mnuExit.Text = "E&xit"
        '
        'MakeBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 409)
        Me.Controls.Add(Me.mnuCinema)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.grbDetails)
        Me.Name = "MakeBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make Booking"
        Me.grbDetails.ResumeLayout(False)
        Me.grbDetails.PerformLayout()
        CType(Me.nudAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuCinema.ResumeLayout(False)
        Me.mnuCinema.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents grbDetails As GroupBox
    Friend WithEvents cboMovieName As ComboBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents mskIC As MaskedTextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblMovieTime As Label
    Friend WithEvents lblMovieName As Label
    Friend WithEvents lblIC As Label
    Friend WithEvents lblName As Label
    Friend WithEvents dtpBookingDate As DateTimePicker
    Friend WithEvents lblBookingDate As Label
    Friend WithEvents cboTime As ComboBox
    Friend WithEvents nudAmount As NumericUpDown
    Friend WithEvents mnuCinema As MenuStrip
    Friend WithEvents mnuBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingMakeBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingList As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
