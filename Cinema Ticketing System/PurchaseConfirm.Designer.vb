﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseConfirm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseConfirm))
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblPurchaseId = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.mnuCinema = New System.Windows.Forms.MenuStrip()
        Me.mnuBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingMakeBooking = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBookingList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.mnuCinema.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(136, 167)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(56, 28)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblPurchaseId
        '
        Me.lblPurchaseId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPurchaseId.Location = New System.Drawing.Point(182, 127)
        Me.lblPurchaseId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPurchaseId.Name = "lblPurchaseId"
        Me.lblPurchaseId.Size = New System.Drawing.Size(40, 19)
        Me.lblPurchaseId.TabIndex = 13
        Me.lblPurchaseId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(106, 129)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(73, 13)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "Purchase Id : "
        '
        'lblInfo
        '
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInfo.Location = New System.Drawing.Point(101, 39)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(127, 69)
        Me.lblInfo.TabIndex = 11
        Me.lblInfo.Text = "Purchase completed !"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnuCinema
        '
        Me.mnuCinema.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuCinema.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBooking, Me.mnuExit})
        Me.mnuCinema.Location = New System.Drawing.Point(0, 0)
        Me.mnuCinema.Name = "mnuCinema"
        Me.mnuCinema.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnuCinema.Size = New System.Drawing.Size(326, 24)
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
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "E&xit"
        '
        'doc
        '
        Me.doc.OriginAtMargins = True
        '
        'dlgPreview
        '
        Me.dlgPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreview.Enabled = True
        Me.dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), System.Drawing.Icon)
        Me.dlgPreview.Name = "dlgPreview"
        Me.dlgPreview.UseAntiAlias = True
        Me.dlgPreview.Visible = False
        '
        'PurchaseConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 210)
        Me.Controls.Add(Me.mnuCinema)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblPurchaseId)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblInfo)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "PurchaseConfirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PurchaseConfirm"
        Me.mnuCinema.ResumeLayout(False)
        Me.mnuCinema.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblPurchaseId As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents mnuCinema As MenuStrip
    Friend WithEvents mnuBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingMakeBooking As ToolStripMenuItem
    Friend WithEvents mnuBookingList As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents dlgPreview As PrintPreviewDialog
End Class
