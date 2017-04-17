<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TodayActivity
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ForenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeLoggedInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeLoggedOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TodayActiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KingswayFitnessDataSet1 = New WindowsApplication1.KingswayFitnessDataSet1()
        Me.TodayActiveTableAdapter = New WindowsApplication1.KingswayFitnessDataSet1TableAdapters.TodayActiveTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TodayActiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KingswayFitnessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TitleDataGridViewTextBoxColumn, Me.ForenameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.TimeLoggedInDataGridViewTextBoxColumn, Me.TimeLoggedOutDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TodayActiveBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(532, 399)
        Me.DataGridView1.TabIndex = 0
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn.Width = 60
        '
        'ForenameDataGridViewTextBoxColumn
        '
        Me.ForenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ForenameDataGridViewTextBoxColumn.DataPropertyName = "Forename"
        Me.ForenameDataGridViewTextBoxColumn.HeaderText = "Forename"
        Me.ForenameDataGridViewTextBoxColumn.Name = "ForenameDataGridViewTextBoxColumn"
        Me.ForenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeLoggedInDataGridViewTextBoxColumn
        '
        Me.TimeLoggedInDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TimeLoggedInDataGridViewTextBoxColumn.DataPropertyName = "Time Logged in"
        Me.TimeLoggedInDataGridViewTextBoxColumn.HeaderText = "Time Logged in"
        Me.TimeLoggedInDataGridViewTextBoxColumn.Name = "TimeLoggedInDataGridViewTextBoxColumn"
        Me.TimeLoggedInDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeLoggedOutDataGridViewTextBoxColumn
        '
        Me.TimeLoggedOutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TimeLoggedOutDataGridViewTextBoxColumn.DataPropertyName = "Time Logged out"
        Me.TimeLoggedOutDataGridViewTextBoxColumn.HeaderText = "Time Logged out"
        Me.TimeLoggedOutDataGridViewTextBoxColumn.Name = "TimeLoggedOutDataGridViewTextBoxColumn"
        Me.TimeLoggedOutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TodayActiveBindingSource
        '
        Me.TodayActiveBindingSource.DataMember = "TodayActive"
        Me.TodayActiveBindingSource.DataSource = Me.KingswayFitnessDataSet1
        '
        'KingswayFitnessDataSet1
        '
        Me.KingswayFitnessDataSet1.DataSetName = "KingswayFitnessDataSet1"
        Me.KingswayFitnessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TodayActiveTableAdapter
        '
        Me.TodayActiveTableAdapter.ClearBeforeFill = True
        '
        'TodayActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 400)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TodayActivity"
        Me.Text = "TodayActivity"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TodayActiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KingswayFitnessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KingswayFitnessDataSet1 As KingswayFitnessDataSet1
    Friend WithEvents TodayActiveBindingSource As BindingSource
    Friend WithEvents TodayActiveTableAdapter As KingswayFitnessDataSet1TableAdapters.TodayActiveTableAdapter
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ForenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeLoggedInDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeLoggedOutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
