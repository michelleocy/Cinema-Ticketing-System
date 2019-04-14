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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintMovieTicket))
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.dialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'doc
        '
        Me.doc.OriginAtMargins = True
        '
        'dialog
        '
        Me.dialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.dialog.Enabled = True
        Me.dialog.Icon = CType(resources.GetObject("dialog.Icon"), System.Drawing.Icon)
        Me.dialog.Name = "dialog"
        Me.dialog.UseAntiAlias = True
        Me.dialog.Visible = False
        '
        'PrintMovieTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Name = "PrintMovieTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movie Ticket"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents dialog As PrintPreviewDialog
End Class
