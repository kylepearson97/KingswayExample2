<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityLogForm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ActivityLog = New System.Windows.Forms.DataGridView()
        Me.KingswayFitnessDataSet1 = New WindowsApplication1.KingswayFitnessDataSet1()
        Me.MemberActivityLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Member_Activity_LogTableAdapter = New WindowsApplication1.KingswayFitnessDataSet1TableAdapters.Member_Activity_LogTableAdapter()
        Me.LogIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeLoggedOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeLoggedInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembershipTypeLab = New System.Windows.Forms.Label()
        Me.Logo = New System.Windows.Forms.PictureBox()
        CType(Me.ActivityLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KingswayFitnessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberActivityLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActivityLog
        '
        Me.ActivityLog.AllowUserToAddRows = False
        Me.ActivityLog.AllowUserToDeleteRows = False
        Me.ActivityLog.AutoGenerateColumns = False
        Me.ActivityLog.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.ActivityLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ActivityLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ActivityLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActivityLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LogIDDataGridViewTextBoxColumn, Me.MemberIDDataGridViewTextBoxColumn, Me.TimeLoggedOutDataGridViewTextBoxColumn, Me.TimeLoggedInDataGridViewTextBoxColumn})
        Me.ActivityLog.DataSource = Me.MemberActivityLogBindingSource
        Me.ActivityLog.Location = New System.Drawing.Point(2, 126)
        Me.ActivityLog.Name = "ActivityLog"
        Me.ActivityLog.ReadOnly = True
        Me.ActivityLog.Size = New System.Drawing.Size(626, 521)
        Me.ActivityLog.TabIndex = 0
        '
        'KingswayFitnessDataSet1
        '
        Me.KingswayFitnessDataSet1.DataSetName = "KingswayFitnessDataSet1"
        Me.KingswayFitnessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemberActivityLogBindingSource
        '
        Me.MemberActivityLogBindingSource.DataMember = "Member Activity Log"
        Me.MemberActivityLogBindingSource.DataSource = Me.KingswayFitnessDataSet1
        '
        'Member_Activity_LogTableAdapter
        '
        Me.Member_Activity_LogTableAdapter.ClearBeforeFill = True
        '
        'LogIDDataGridViewTextBoxColumn
        '
        Me.LogIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LogIDDataGridViewTextBoxColumn.DataPropertyName = "Log ID"
        Me.LogIDDataGridViewTextBoxColumn.HeaderText = "Log ID"
        Me.LogIDDataGridViewTextBoxColumn.Name = "LogIDDataGridViewTextBoxColumn"
        Me.LogIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MemberIDDataGridViewTextBoxColumn
        '
        Me.MemberIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MemberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID"
        Me.MemberIDDataGridViewTextBoxColumn.HeaderText = "MemberID"
        Me.MemberIDDataGridViewTextBoxColumn.Name = "MemberIDDataGridViewTextBoxColumn"
        Me.MemberIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeLoggedOutDataGridViewTextBoxColumn
        '
        Me.TimeLoggedOutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TimeLoggedOutDataGridViewTextBoxColumn.DataPropertyName = "Time Logged out"
        Me.TimeLoggedOutDataGridViewTextBoxColumn.HeaderText = "Time Logged out"
        Me.TimeLoggedOutDataGridViewTextBoxColumn.Name = "TimeLoggedOutDataGridViewTextBoxColumn"
        Me.TimeLoggedOutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeLoggedInDataGridViewTextBoxColumn
        '
        Me.TimeLoggedInDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TimeLoggedInDataGridViewTextBoxColumn.DataPropertyName = "Time Logged in"
        Me.TimeLoggedInDataGridViewTextBoxColumn.HeaderText = "Time Logged in"
        Me.TimeLoggedInDataGridViewTextBoxColumn.Name = "TimeLoggedInDataGridViewTextBoxColumn"
        Me.TimeLoggedInDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MembershipTypeLab
        '
        Me.MembershipTypeLab.AutoSize = True
        Me.MembershipTypeLab.BackColor = System.Drawing.Color.Transparent
        Me.MembershipTypeLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MembershipTypeLab.Location = New System.Drawing.Point(253, 9)
        Me.MembershipTypeLab.Name = "MembershipTypeLab"
        Me.MembershipTypeLab.Size = New System.Drawing.Size(264, 29)
        Me.MembershipTypeLab.TabIndex = 5
        Me.MembershipTypeLab.Text = "Customer Activity Log"
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.Image = Global.WindowsApplication1.My.Resources.Resources.Logo
        Me.Logo.Location = New System.Drawing.Point(-15, -9)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(262, 129)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 6
        Me.Logo.TabStop = False
        '
        'ActivityLogForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(631, 648)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.MembershipTypeLab)
        Me.Controls.Add(Me.ActivityLog)
        Me.DoubleBuffered = True
        Me.Name = "ActivityLogForm"
        Me.Text = "Activity"
        CType(Me.ActivityLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KingswayFitnessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberActivityLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ActivityLog As DataGridView
    Friend WithEvents KingswayFitnessDataSet1 As KingswayFitnessDataSet1
    Friend WithEvents MemberActivityLogBindingSource As BindingSource
    Friend WithEvents Member_Activity_LogTableAdapter As KingswayFitnessDataSet1TableAdapters.Member_Activity_LogTableAdapter
    Friend WithEvents LogIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeLoggedOutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeLoggedInDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MembershipTypeLab As Label
    Friend WithEvents Logo As PictureBox
End Class
