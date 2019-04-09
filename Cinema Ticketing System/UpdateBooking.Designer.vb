<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateBooking
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.dgvBooking = New System.Windows.Forms.DataGridView()
        Me.BookingIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerICDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieScheduleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountOfPeopleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New Cinema_Ticketing_System.DatabaseDataSet()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grbDetails = New System.Windows.Forms.GroupBox()
        Me.nudAmount = New System.Windows.Forms.NumericUpDown()
        Me.cboTime = New System.Windows.Forms.ComboBox()
        Me.dtpBookingDate = New System.Windows.Forms.DateTimePicker()
        Me.lblBookingDate = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.cboMovieName = New System.Windows.Forms.ComboBox()
        Me.mskIC = New System.Windows.Forms.MaskedTextBox()
        Me.lblMovieName = New System.Windows.Forms.Label()
        Me.txtNameResult = New System.Windows.Forms.TextBox()
        Me.lblMovieTime = New System.Windows.Forms.Label()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BookingTableAdapter = New Cinema_Ticketing_System.DatabaseDataSetTableAdapters.BookingTableAdapter()
        Me.mnuCinema = New System.Windows.Forms.MenuStrip()
        Me.mnuBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingMakeBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingList = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBookingUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDetails.SuspendLayout()
        CType(Me.nudAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuCinema.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(75, 41)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(163, 22)
        Me.txtName.TabIndex = 5
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 44)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(57, 17)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name : "
        '
        'dgvBooking
        '
        Me.dgvBooking.AllowUserToAddRows = False
        Me.dgvBooking.AllowUserToDeleteRows = False
        Me.dgvBooking.AutoGenerateColumns = False
        Me.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooking.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingIDDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.CustomerICDataGridViewTextBoxColumn, Me.MovieScheduleIDDataGridViewTextBoxColumn, Me.AmountOfPeopleDataGridViewTextBoxColumn, Me.BookingDateDataGridViewTextBoxColumn})
        Me.dgvBooking.DataSource = Me.BookingBindingSource
        Me.dgvBooking.Location = New System.Drawing.Point(12, 86)
        Me.dgvBooking.Name = "dgvBooking"
        Me.dgvBooking.ReadOnly = True
        Me.dgvBooking.RowTemplate.Height = 24
        Me.dgvBooking.Size = New System.Drawing.Size(748, 217)
        Me.dgvBooking.TabIndex = 3
        '
        'BookingIDDataGridViewTextBoxColumn
        '
        Me.BookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID"
        Me.BookingIDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.BookingIDDataGridViewTextBoxColumn.Name = "BookingIDDataGridViewTextBoxColumn"
        Me.BookingIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        Me.CustomerNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerICDataGridViewTextBoxColumn
        '
        Me.CustomerICDataGridViewTextBoxColumn.DataPropertyName = "CustomerIC"
        Me.CustomerICDataGridViewTextBoxColumn.HeaderText = "IC"
        Me.CustomerICDataGridViewTextBoxColumn.Name = "CustomerICDataGridViewTextBoxColumn"
        Me.CustomerICDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovieScheduleIDDataGridViewTextBoxColumn
        '
        Me.MovieScheduleIDDataGridViewTextBoxColumn.DataPropertyName = "MovieScheduleID"
        Me.MovieScheduleIDDataGridViewTextBoxColumn.HeaderText = "Schedule ID"
        Me.MovieScheduleIDDataGridViewTextBoxColumn.Name = "MovieScheduleIDDataGridViewTextBoxColumn"
        Me.MovieScheduleIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountOfPeopleDataGridViewTextBoxColumn
        '
        Me.AmountOfPeopleDataGridViewTextBoxColumn.DataPropertyName = "AmountOfPeople"
        Me.AmountOfPeopleDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountOfPeopleDataGridViewTextBoxColumn.Name = "AmountOfPeopleDataGridViewTextBoxColumn"
        Me.AmountOfPeopleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookingDateDataGridViewTextBoxColumn
        '
        Me.BookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate"
        Me.BookingDateDataGridViewTextBoxColumn.HeaderText = "Booking Date"
        Me.BookingDateDataGridViewTextBoxColumn.Name = "BookingDateDataGridViewTextBoxColumn"
        Me.BookingDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(380, 514)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 42)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(501, 514)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(104, 42)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
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
        Me.grbDetails.Controls.Add(Me.txtNameResult)
        Me.grbDetails.Controls.Add(Me.lblMovieTime)
        Me.grbDetails.Controls.Add(Me.lblIC)
        Me.grbDetails.Controls.Add(Me.Label1)
        Me.grbDetails.Location = New System.Drawing.Point(15, 329)
        Me.grbDetails.Name = "grbDetails"
        Me.grbDetails.Size = New System.Drawing.Size(337, 298)
        Me.grbDetails.TabIndex = 11
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
        Me.dtpBookingDate.MinDate = New Date(2019, 4, 3, 0, 0, 0, 0)
        Me.dtpBookingDate.Name = "dtpBookingDate"
        Me.dtpBookingDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpBookingDate.TabIndex = 45
        Me.dtpBookingDate.UseWaitCursor = True
        Me.dtpBookingDate.Value = New Date(2019, 4, 3, 0, 0, 0, 0)
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
        'txtNameResult
        '
        Me.txtNameResult.Location = New System.Drawing.Point(124, 38)
        Me.txtNameResult.Name = "txtNameResult"
        Me.txtNameResult.Size = New System.Drawing.Size(148, 22)
        Me.txtNameResult.TabIndex = 5
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User &name : "
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'mnuCinema
        '
        Me.mnuCinema.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuCinema.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBooking, Me.mnuExit})
        Me.mnuCinema.Location = New System.Drawing.Point(0, 0)
        Me.mnuCinema.Name = "mnuCinema"
        Me.mnuCinema.Size = New System.Drawing.Size(772, 28)
        Me.mnuCinema.TabIndex = 12
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
        'UpdateBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 654)
        Me.Controls.Add(Me.mnuCinema)
        Me.Controls.Add(Me.grbDetails)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.dgvBooking)
        Me.Name = "UpdateBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Booking"
        CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDetails.ResumeLayout(False)
        Me.grbDetails.PerformLayout()
        CType(Me.nudAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuCinema.ResumeLayout(False)
        Me.mnuCinema.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents dgvBooking As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents grbDetails As GroupBox
    Friend WithEvents nudAmount As NumericUpDown
    Friend WithEvents cboTime As ComboBox
    Friend WithEvents dtpBookingDate As DateTimePicker
    Friend WithEvents lblBookingDate As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents cboMovieName As ComboBox
    Friend WithEvents mskIC As MaskedTextBox
    Friend WithEvents lblMovieName As Label
    Friend WithEvents txtNameResult As TextBox
    Friend WithEvents lblMovieTime As Label
    Friend WithEvents lblIC As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BookingTableAdapter As DatabaseDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents BookingIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerICDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieScheduleIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountOfPeopleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents mnuCinema As MenuStrip
    Friend WithEvents mnuBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingMakeBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingList As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuBookingUpdate As ToolStripMenuItem
    Friend WithEvents mnuBookingDelete As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
