<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MakeBookingConfirm
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
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.mnuCinema = New System.Windows.Forms.MenuStrip()
        Me.mnuBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingMakeBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCinema.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInfo.Location = New System.Drawing.Point(133, 45)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(169, 85)
        Me.lblInfo.TabIndex = 3
        Me.lblInfo.Text = "Booking completed !"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(101, 156)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(87, 17)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Booked by : "
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Location = New System.Drawing.Point(194, 156)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(135, 23)
        Me.lblName.TabIndex = 7
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(179, 203)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 34)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'mnuCinema
        '
        Me.mnuCinema.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuCinema.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBooking, Me.mnuExit})
        Me.mnuCinema.Location = New System.Drawing.Point(0, 0)
        Me.mnuCinema.Name = "mnuCinema"
        Me.mnuCinema.Size = New System.Drawing.Size(435, 28)
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
        'MakeBookingConfirm
        '
        Me.AcceptButton = Me.btnPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 259)
        Me.Controls.Add(Me.mnuCinema)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblInfo)
        Me.Name = "MakeBookingConfirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking Confirm"
        Me.mnuCinema.ResumeLayout(False)
        Me.mnuCinema.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents mnuCinema As MenuStrip
    Friend WithEvents mnuBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingMakeBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingList As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
