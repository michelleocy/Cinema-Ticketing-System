<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintMovieTicket
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
        Me.mnuCinema = New System.Windows.Forms.MenuStrip()
        Me.mnuBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingMakeBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingList = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBookingUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPurchaseId = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.crvMovieTicket = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MovieTicket1 = New Cinema_Ticketing_System.MovieTicket()
        Me.mnuCinema.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuCinema
        '
        Me.mnuCinema.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuCinema.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBooking, Me.mnuExit})
        Me.mnuCinema.Location = New System.Drawing.Point(0, 0)
        Me.mnuCinema.Name = "mnuCinema"
        Me.mnuCinema.Size = New System.Drawing.Size(800, 28)
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
        'lblPurchaseId
        '
        Me.lblPurchaseId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPurchaseId.Location = New System.Drawing.Point(105, 42)
        Me.lblPurchaseId.Name = "lblPurchaseId"
        Me.lblPurchaseId.Size = New System.Drawing.Size(135, 23)
        Me.lblPurchaseId.TabIndex = 14
        Me.lblPurchaseId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 46)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(95, 17)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Purchase Id : "
        '
        'crvMovieTicket
        '
        Me.crvMovieTicket.ActiveViewIndex = 0
        Me.crvMovieTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvMovieTicket.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvMovieTicket.Location = New System.Drawing.Point(13, 82)
        Me.crvMovieTicket.Name = "crvMovieTicket"
        Me.crvMovieTicket.ReportSource = Me.MovieTicket1
        Me.crvMovieTicket.Size = New System.Drawing.Size(775, 356)
        Me.crvMovieTicket.TabIndex = 15
        Me.crvMovieTicket.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'PrintMovieTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.crvMovieTicket)
        Me.Controls.Add(Me.lblPurchaseId)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuCinema)
        Me.Name = "PrintMovieTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrintMovieTicket"
        Me.mnuCinema.ResumeLayout(False)
        Me.mnuCinema.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuCinema As MenuStrip
    Friend WithEvents mnuBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingMakeBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingList As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuBookingUpdate As ToolStripMenuItem
    Friend WithEvents mnuBookingDelete As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblPurchaseId As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents crvMovieTicket As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MovieTicket1 As MovieTicket
End Class
