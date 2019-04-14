<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerateReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenerateReport))
        Me.cboReportType = New System.Windows.Forms.ComboBox()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboReportType
        '
        Me.cboReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReportType.FormattingEnabled = True
        Me.cboReportType.Items.AddRange(New Object() {"Seat Report"})
        Me.cboReportType.Location = New System.Drawing.Point(12, 25)
        Me.cboReportType.Name = "cboReportType"
        Me.cboReportType.Size = New System.Drawing.Size(121, 21)
        Me.cboReportType.TabIndex = 0
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.Enabled = False
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Location = New System.Drawing.Point(12, 128)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(121, 21)
        Me.cboMonth.TabIndex = 1
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(12, 170)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'doc
        '
        Me.doc.OriginAtMargins = True
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(12, 77)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(121, 21)
        Me.cboYear.TabIndex = 3
        '
        'dlgPreview
        '
        Me.dlgPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreview.Enabled = True
        Me.dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), System.Drawing.Icon)
        Me.dlgPreview.Name = "dlgPreview"
        Me.dlgPreview.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Report Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Choose Year: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Choose Month:"
        '
        'FrmGenerateReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(174, 219)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.cboReportType)
        Me.Name = "FrmGenerateReport"
        Me.Text = "Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboReportType As ComboBox
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents dlgPreview As PrintPreviewDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
