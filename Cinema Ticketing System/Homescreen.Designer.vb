﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Homescreen
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.mnuCinema.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuCinema
        '
        Me.mnuCinema.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuCinema.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBooking, Me.mnuHall, Me.mnuStaff, Me.mnuMovie, Me.mnuReport, Me.mnuExit})
        Me.mnuCinema.Location = New System.Drawing.Point(0, 0)
        Me.mnuCinema.Name = "mnuCinema"
        Me.mnuCinema.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnuCinema.Size = New System.Drawing.Size(310, 24)
        Me.mnuCinema.TabIndex = 0
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
        Me.mnuMovieMovieSchedule.Size = New System.Drawing.Size(180, 22)
        Me.mnuMovieMovieSchedule.Text = "Movie Schedule"
        '
        'mnuMovieMovieList
        '
        Me.mnuMovieMovieList.Name = "mnuMovieMovieList"
        Me.mnuMovieMovieList.Size = New System.Drawing.Size(180, 22)
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
        'lblWelcome
        '
        Me.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(41, 70)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(228, 138)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome !"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(41, 211)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(115, 13)
        Me.lblInfo.TabIndex = 2
        Me.lblInfo.Text = "Click to start purchase!"
        '
        'Homescreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 255)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.mnuCinema)
        Me.MainMenuStrip = Me.mnuCinema
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Homescreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Homescreen"
        Me.mnuCinema.ResumeLayout(False)
        Me.mnuCinema.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuCinema As MenuStrip
    Friend WithEvents mnuBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingMakeBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingList As ToolStripMenuItem
    Friend WithEvents lblWelcome As Label
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblInfo As Label
    Friend WithEvents mnuHall As ToolStripMenuItem
    Friend WithEvents mnuReport As ToolStripMenuItem
    Friend WithEvents mnuStaff As ToolStripMenuItem
    Friend WithEvents mnuMovie As ToolStripMenuItem
    Friend WithEvents mnuMovieMovieSchedule As ToolStripMenuItem
    Friend WithEvents mnuMovieMovieList As ToolStripMenuItem
End Class
