﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewBookingList
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvBooking = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New Cinema_Ticketing_System.DatabaseDataSet()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.BookingTableAdapter = New Cinema_Ticketing_System.DatabaseDataSetTableAdapters.BookingTableAdapter()
        Me.mnuCinema = New System.Windows.Forms.MenuStrip()
        Me.mnuBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingMakeBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHall = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMovie = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMovieMovieSchedule = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMovieMovieList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuCinema.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBooking
        '
        Me.dgvBooking.AllowUserToAddRows = False
        Me.dgvBooking.AllowUserToDeleteRows = False
        Me.dgvBooking.AutoGenerateColumns = False
        Me.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooking.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgvBooking.DataSource = Me.BookingBindingSource
        Me.dgvBooking.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvBooking.Location = New System.Drawing.Point(9, 70)
        Me.dgvBooking.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvBooking.Name = "dgvBooking"
        Me.dgvBooking.RowTemplate.Height = 24
        Me.dgvBooking.Size = New System.Drawing.Size(561, 176)
        Me.dgvBooking.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BookingID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CustomerName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CustomerIC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MovieScheduleID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Schedule ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "AmountOfPeople"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "BookingDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Booking Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
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
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(9, 36)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name : "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(57, 33)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(123, 20)
        Me.txtName.TabIndex = 2
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(284, 25)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(78, 34)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(194, 25)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(78, 34)
        Me.btnPreview.TabIndex = 14
        Me.btnPreview.Text = "&Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'mnuCinema
        '
        Me.mnuCinema.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuCinema.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBooking, Me.mnuHall, Me.mnuStaff, Me.mnuMovie, Me.mnuReport, Me.mnuExit})
        Me.mnuCinema.Location = New System.Drawing.Point(0, 0)
        Me.mnuCinema.Name = "mnuCinema"
        Me.mnuCinema.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnuCinema.Size = New System.Drawing.Size(579, 24)
        Me.mnuCinema.TabIndex = 15
        Me.mnuCinema.Text = "MenuStrip1"
        '
        'mnuBooking
        '
        Me.mnuBooking.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBookingMakeBooking, Me.mnuBookingList})
        Me.mnuBooking.Name = "mnuBooking"
        Me.mnuBooking.Size = New System.Drawing.Size(63, 20)
        Me.mnuBooking.Text = "&Booking"
        '
        'mnuBookingMakeBooking
        '
        Me.mnuBookingMakeBooking.Name = "mnuBookingMakeBooking"
        Me.mnuBookingMakeBooking.Size = New System.Drawing.Size(150, 22)
        Me.mnuBookingMakeBooking.Text = "&Make Booking"
        '
        'mnuBookingList
        '
        Me.mnuBookingList.Name = "mnuBookingList"
        Me.mnuBookingList.Size = New System.Drawing.Size(150, 22)
        Me.mnuBookingList.Text = "Booking &List"
        '
        'mnuHall
        '
        Me.mnuHall.Name = "mnuHall"
        Me.mnuHall.Size = New System.Drawing.Size(40, 20)
        Me.mnuHall.Text = "H&all"
        '
        'mnuStaff
        '
        Me.mnuStaff.Name = "mnuStaff"
        Me.mnuStaff.Size = New System.Drawing.Size(43, 20)
        Me.mnuStaff.Text = "Staff"
        '
        'mnuMovie
        '
        Me.mnuMovie.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMovieMovieSchedule, Me.mnuMovieMovieList})
        Me.mnuMovie.Name = "mnuMovie"
        Me.mnuMovie.Size = New System.Drawing.Size(52, 20)
        Me.mnuMovie.Text = "Movie"
        '
        'mnuMovieMovieSchedule
        '
        Me.mnuMovieMovieSchedule.Name = "mnuMovieMovieSchedule"
        Me.mnuMovieMovieSchedule.Size = New System.Drawing.Size(158, 22)
        Me.mnuMovieMovieSchedule.Text = "Movie Schedule"
        '
        'mnuMovieMovieList
        '
        Me.mnuMovieMovieList.Name = "mnuMovieMovieList"
        Me.mnuMovieMovieList.Size = New System.Drawing.Size(158, 22)
        Me.mnuMovieMovieList.Text = "Movie List"
        '
        'mnuReport
        '
        Me.mnuReport.Name = "mnuReport"
        Me.mnuReport.Size = New System.Drawing.Size(54, 20)
        Me.mnuReport.Text = "R&eport"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "E&xit"
        '
        'ViewBookingList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 266)
        Me.Controls.Add(Me.mnuCinema)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.dgvBooking)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ViewBookingList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking List"
        CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuCinema.ResumeLayout(False)
        Me.mnuCinema.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBooking As DataGridView
    Friend WithEvents BookingIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerICDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieScheduleIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountOfPeopleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BookingTableAdapter As DatabaseDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents mnuCinema As MenuStrip
    Friend WithEvents mnuBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingMakeBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingList As ToolStripMenuItem
    Friend WithEvents mnuHall As ToolStripMenuItem
    Friend WithEvents mnuStaff As ToolStripMenuItem
    Friend WithEvents mnuMovie As ToolStripMenuItem
    Friend WithEvents mnuMovieMovieSchedule As ToolStripMenuItem
    Friend WithEvents mnuMovieMovieList As ToolStripMenuItem
    Friend WithEvents mnuReport As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
