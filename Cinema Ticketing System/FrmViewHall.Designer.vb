<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewHall
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
        Me.dgvHallList = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddHall = New System.Windows.Forms.Button()
        Me.btnDeleteHall = New System.Windows.Forms.Button()
        Me.btnEditHall = New System.Windows.Forms.Button()
        CType(Me.dgvHallList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHallList
        '
        Me.dgvHallList.AllowUserToAddRows = False
        Me.dgvHallList.AllowUserToDeleteRows = False
        Me.dgvHallList.AllowUserToOrderColumns = True
        Me.dgvHallList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHallList.Location = New System.Drawing.Point(12, 32)
        Me.dgvHallList.MultiSelect = False
        Me.dgvHallList.Name = "dgvHallList"
        Me.dgvHallList.ReadOnly = True
        Me.dgvHallList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHallList.Size = New System.Drawing.Size(484, 497)
        Me.dgvHallList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hall List :"
        '
        'btnAddHall
        '
        Me.btnAddHall.BackColor = System.Drawing.Color.Green
        Me.btnAddHall.Location = New System.Drawing.Point(12, 535)
        Me.btnAddHall.Name = "btnAddHall"
        Me.btnAddHall.Size = New System.Drawing.Size(75, 23)
        Me.btnAddHall.TabIndex = 2
        Me.btnAddHall.Text = "Add Hall"
        Me.btnAddHall.UseVisualStyleBackColor = False
        '
        'btnDeleteHall
        '
        Me.btnDeleteHall.BackColor = System.Drawing.Color.Red
        Me.btnDeleteHall.Location = New System.Drawing.Point(421, 535)
        Me.btnDeleteHall.Name = "btnDeleteHall"
        Me.btnDeleteHall.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteHall.TabIndex = 2
        Me.btnDeleteHall.Text = "Delete Hall"
        Me.btnDeleteHall.UseVisualStyleBackColor = False
        '
        'btnEditHall
        '
        Me.btnEditHall.Location = New System.Drawing.Point(340, 535)
        Me.btnEditHall.Name = "btnEditHall"
        Me.btnEditHall.Size = New System.Drawing.Size(75, 23)
        Me.btnEditHall.TabIndex = 2
        Me.btnEditHall.Text = "Edit Hall"
        Me.btnEditHall.UseVisualStyleBackColor = True
        '
        'FrmViewHall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 568)
        Me.Controls.Add(Me.btnEditHall)
        Me.Controls.Add(Me.btnDeleteHall)
        Me.Controls.Add(Me.btnAddHall)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvHallList)
        Me.Name = "FrmViewHall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmViewHall"
        CType(Me.dgvHallList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvHallList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddHall As Button
    Friend WithEvents btnDeleteHall As Button
    Friend WithEvents btnEditHall As Button
End Class
