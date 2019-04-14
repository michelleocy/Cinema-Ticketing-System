<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintBookingReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintBookingReceipt))
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.control = New System.Windows.Forms.PrintPreviewControl()
        Me.dialog = New System.Windows.Forms.PrintDialog()
        Me.tsBooking = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnZoomIn = New System.Windows.Forms.ToolStripButton()
        Me.btnZoomOut = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.tsBooking.SuspendLayout()
        Me.SuspendLayout()
        '
        'doc
        '
        '
        'control
        '
        Me.control.AutoZoom = False
        Me.control.Dock = System.Windows.Forms.DockStyle.Fill
        Me.control.Document = Me.doc
        Me.control.Location = New System.Drawing.Point(0, 0)
        Me.control.Name = "control"
        Me.control.Size = New System.Drawing.Size(800, 450)
        Me.control.TabIndex = 0
        Me.control.Zoom = 0.32272727272727275R
        '
        'dialog
        '
        Me.dialog.UseEXDialog = True
        '
        'tsBooking
        '
        Me.tsBooking.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsBooking.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnZoomIn, Me.btnZoomOut, Me.btnClose})
        Me.tsBooking.Location = New System.Drawing.Point(0, 0)
        Me.tsBooking.Name = "tsBooking"
        Me.tsBooking.Size = New System.Drawing.Size(800, 25)
        Me.tsBooking.TabIndex = 2
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImage = CType(resources.GetObject("btnPrint.BackgroundImage"), System.Drawing.Image)
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "&Print"
        '
        'btnZoomIn
        '
        Me.btnZoomIn.BackgroundImage = CType(resources.GetObject("btnZoomIn.BackgroundImage"), System.Drawing.Image)
        Me.btnZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(23, 22)
        Me.btnZoomIn.Text = "Zoom &In"
        '
        'btnZoomOut
        '
        Me.btnZoomOut.BackgroundImage = CType(resources.GetObject("btnZoomOut.BackgroundImage"), System.Drawing.Image)
        Me.btnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(23, 22)
        Me.btnZoomOut.Text = "Zoom &Out"
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(23, 22)
        Me.btnClose.Text = "&Close"
        '
        'PrintBookingReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tsBooking)
        Me.Controls.Add(Me.control)
        Me.Name = "PrintBookingReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking Receipt"
        Me.tsBooking.ResumeLayout(False)
        Me.tsBooking.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents control As PrintPreviewControl
    Friend WithEvents dialog As PrintDialog
    Friend WithEvents tsBooking As ToolStrip
    Friend WithEvents btnZoomIn As ToolStripButton
    Friend WithEvents btnZoomOut As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnClose As ToolStripButton
End Class
