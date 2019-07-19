<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.GetOrderReport_ResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NoteLabel2 = New System.Windows.Forms.Label()
        Me.NoteLabel1 = New System.Windows.Forms.Label()
        Me.IncludeCheckBox = New System.Windows.Forms.CheckBox()
        Me.DateRangeGroupBox = New System.Windows.Forms.GroupBox()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.ToLabel = New System.Windows.Forms.Label()
        Me.FromLabel = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.GetOrderReport_ResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DateRangeGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GetOrderReport_ResultBindingSource
        '
        Me.GetOrderReport_ResultBindingSource.DataSource = GetType(GRA_Assignment_Question1.GetOrderReport_Result)
        '
        'NoteLabel2
        '
        Me.NoteLabel2.AutoSize = True
        Me.NoteLabel2.Location = New System.Drawing.Point(429, 105)
        Me.NoteLabel2.Name = "NoteLabel2"
        Me.NoteLabel2.Size = New System.Drawing.Size(105, 17)
        Me.NoteLabel2.TabIndex = 8
        Me.NoteLabel2.Text = "amount of time."
        '
        'NoteLabel1
        '
        Me.NoteLabel1.AutoSize = True
        Me.NoteLabel1.Location = New System.Drawing.Point(429, 88)
        Me.NoteLabel1.Name = "NoteLabel1"
        Me.NoteLabel1.Size = New System.Drawing.Size(463, 17)
        Me.NoteLabel1.TabIndex = 7
        Me.NoteLabel1.Text = "NOTE: Checking this option may cause this report to run for a significant"
        '
        'IncludeCheckBox
        '
        Me.IncludeCheckBox.AutoSize = True
        Me.IncludeCheckBox.Location = New System.Drawing.Point(432, 64)
        Me.IncludeCheckBox.Name = "IncludeCheckBox"
        Me.IncludeCheckBox.Size = New System.Drawing.Size(309, 21)
        Me.IncludeCheckBox.TabIndex = 6
        Me.IncludeCheckBox.Text = "Include Operator that performed cancelation"
        Me.IncludeCheckBox.UseVisualStyleBackColor = True
        '
        'DateRangeGroupBox
        '
        Me.DateRangeGroupBox.Controls.Add(Me.DTP2)
        Me.DateRangeGroupBox.Controls.Add(Me.DTP1)
        Me.DateRangeGroupBox.Controls.Add(Me.ToLabel)
        Me.DateRangeGroupBox.Controls.Add(Me.FromLabel)
        Me.DateRangeGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRangeGroupBox.Location = New System.Drawing.Point(20, 21)
        Me.DateRangeGroupBox.Name = "DateRangeGroupBox"
        Me.DateRangeGroupBox.Size = New System.Drawing.Size(327, 140)
        Me.DateRangeGroupBox.TabIndex = 5
        Me.DateRangeGroupBox.TabStop = False
        Me.DateRangeGroupBox.Text = "Date Range"
        '
        'DTP2
        '
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP2.Location = New System.Drawing.Point(118, 94)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(133, 22)
        Me.DTP2.TabIndex = 3
        '
        'DTP1
        '
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP1.Location = New System.Drawing.Point(118, 44)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(133, 22)
        Me.DTP1.TabIndex = 2
        '
        'ToLabel
        '
        Me.ToLabel.AutoSize = True
        Me.ToLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToLabel.Location = New System.Drawing.Point(33, 94)
        Me.ToLabel.Name = "ToLabel"
        Me.ToLabel.Size = New System.Drawing.Size(29, 17)
        Me.ToLabel.TabIndex = 1
        Me.ToLabel.Text = "To:"
        '
        'FromLabel
        '
        Me.FromLabel.AutoSize = True
        Me.FromLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromLabel.Location = New System.Drawing.Point(33, 42)
        Me.FromLabel.Name = "FromLabel"
        Me.FromLabel.Size = New System.Drawing.Size(44, 17)
        Me.FromLabel.TabIndex = 0
        Me.FromLabel.Text = "From:"
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Indigo
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.CloseButton.Location = New System.Drawing.Point(1222, 387)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(132, 70)
        Me.CloseButton.TabIndex = 12
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Purple
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(1246, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Actions"
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.Color.Violet
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.Location = New System.Drawing.Point(1222, 56)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(132, 70)
        Me.RefreshButton.TabIndex = 10
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1202, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 468)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "CanceledOrders"
        ReportDataSource2.Value = Me.GetOrderReport_ResultBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GRA_Assignment_Question1.CanceledOrdersReport1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(5, 173)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1191, 295)
        Me.ReportViewer1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 471)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NoteLabel2)
        Me.Controls.Add(Me.NoteLabel1)
        Me.Controls.Add(Me.IncludeCheckBox)
        Me.Controls.Add(Me.DateRangeGroupBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GetOrderReport_ResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DateRangeGroupBox.ResumeLayout(False)
        Me.DateRangeGroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NoteLabel2 As Label
    Friend WithEvents NoteLabel1 As Label
    Friend WithEvents IncludeCheckBox As CheckBox
    Friend WithEvents DateRangeGroupBox As GroupBox
    Friend WithEvents DTP2 As DateTimePicker
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents ToLabel As Label
    Friend WithEvents FromLabel As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RefreshButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GetOrderReport_ResultBindingSource As BindingSource
End Class
