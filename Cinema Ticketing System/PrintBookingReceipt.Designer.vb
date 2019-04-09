<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrintBookingReceipt
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.crvBookingReceipt = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BookingReceipt1 = New Cinema_Ticketing_System.BookingReceipt()
        Me.mnuCinema = New System.Windows.Forms.MenuStrip()
        Me.mnuBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingMakeBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingList = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBookingUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCinema.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Location = New System.Drawing.Point(111, 35)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(135, 23)
        Me.lblName.TabIndex = 9
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(18, 39)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(87, 17)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Booked by : "
        '
        'crvBookingReceipt
        '
        Me.crvBookingReceipt.ActiveViewIndex = 0
        Me.crvBookingReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvBookingReceipt.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvBookingReceipt.Location = New System.Drawing.Point(13, 71)
        Me.crvBookingReceipt.Name = "crvBookingReceipt"
        Me.crvBookingReceipt.ReportSource = Me.BookingReceipt1
        Me.crvBookingReceipt.Size = New System.Drawing.Size(775, 367)
        Me.crvBookingReceipt.TabIndex = 10
        Me.crvBookingReceipt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'mnuCinema
        '
        Me.mnuCinema.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuCinema.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBooking, Me.mnuExit})
        Me.mnuCinema.Location = New System.Drawing.Point(0, 0)
        Me.mnuCinema.Name = "mnuCinema"
        Me.mnuCinema.Size = New System.Drawing.Size(800, 28)
        Me.mnuCinema.TabIndex = 11
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
        'PrintBookingReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mnuCinema)
        Me.Controls.Add(Me.crvBookingReceipt)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "PrintBookingReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "z"
        Me.mnuCinema.ResumeLayout(False)
        Me.mnuCinema.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents crvBookingReceipt As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BookingReceipt1 As BookingReceipt
    Friend WithEvents mnuCinema As MenuStrip
    Friend WithEvents mnuBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingMakeBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingList As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuBookingUpdate As ToolStripMenuItem
    Friend WithEvents mnuBookingDelete As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
