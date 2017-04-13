<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MembershipType
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
        Me.MembershipTypeLab = New System.Windows.Forms.Label()
        Me.LogoPicBox = New System.Windows.Forms.PictureBox()
        Me.MembershipTypeDataGrid = New System.Windows.Forms.DataGridView()
        Me.KingswayFitnessDataSet1 = New WindowsApplication1.KingswayFitnessDataSet1()
        Me.MembershipTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Membership_TypeTableAdapter = New WindowsApplication1.KingswayFitnessDataSet1TableAdapters.Membership_TypeTableAdapter()
        Me.MembertypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembershipNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LogoPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembershipTypeDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KingswayFitnessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembershipTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MembershipTypeLab
        '
        Me.MembershipTypeLab.AutoSize = True
        Me.MembershipTypeLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MembershipTypeLab.Location = New System.Drawing.Point(253, 9)
        Me.MembershipTypeLab.Name = "MembershipTypeLab"
        Me.MembershipTypeLab.Size = New System.Drawing.Size(224, 29)
        Me.MembershipTypeLab.TabIndex = 4
        Me.MembershipTypeLab.Text = "Membership Type"
        '
        'LogoPicBox
        '
        Me.LogoPicBox.Image = Global.WindowsApplication1.My.Resources.Resources.Logo
        Me.LogoPicBox.Location = New System.Drawing.Point(-15, -9)
        Me.LogoPicBox.Name = "LogoPicBox"
        Me.LogoPicBox.Size = New System.Drawing.Size(262, 129)
        Me.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPicBox.TabIndex = 1
        Me.LogoPicBox.TabStop = False
        '
        'MembershipTypeDataGrid
        '
        Me.MembershipTypeDataGrid.AllowUserToAddRows = False
        Me.MembershipTypeDataGrid.AllowUserToDeleteRows = False
        Me.MembershipTypeDataGrid.AutoGenerateColumns = False
        Me.MembershipTypeDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.MembershipTypeDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MembershipTypeDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MembershipTypeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MembershipTypeDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MembertypeIDDataGridViewTextBoxColumn, Me.MembershipNameDataGridViewTextBoxColumn, Me.FeeDataGridViewTextBoxColumn})
        Me.MembershipTypeDataGrid.DataSource = Me.MembershipTypeBindingSource
        Me.MembershipTypeDataGrid.Location = New System.Drawing.Point(1, 154)
        Me.MembershipTypeDataGrid.Name = "MembershipTypeDataGrid"
        Me.MembershipTypeDataGrid.ReadOnly = True
        Me.MembershipTypeDataGrid.Size = New System.Drawing.Size(565, 204)
        Me.MembershipTypeDataGrid.TabIndex = 5
        '
        'KingswayFitnessDataSet1
        '
        Me.KingswayFitnessDataSet1.DataSetName = "KingswayFitnessDataSet1"
        Me.KingswayFitnessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembershipTypeBindingSource
        '
        Me.MembershipTypeBindingSource.DataMember = "Membership Type"
        Me.MembershipTypeBindingSource.DataSource = Me.KingswayFitnessDataSet1
        '
        'Membership_TypeTableAdapter
        '
        Me.Membership_TypeTableAdapter.ClearBeforeFill = True
        '
        'MembertypeIDDataGridViewTextBoxColumn
        '
        Me.MembertypeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MembertypeIDDataGridViewTextBoxColumn.DataPropertyName = "Membertype-ID"
        Me.MembertypeIDDataGridViewTextBoxColumn.HeaderText = "Membertype-ID"
        Me.MembertypeIDDataGridViewTextBoxColumn.Name = "MembertypeIDDataGridViewTextBoxColumn"
        Me.MembertypeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MembershipNameDataGridViewTextBoxColumn
        '
        Me.MembershipNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MembershipNameDataGridViewTextBoxColumn.DataPropertyName = "Membership Name"
        Me.MembershipNameDataGridViewTextBoxColumn.HeaderText = "Membership Name"
        Me.MembershipNameDataGridViewTextBoxColumn.Name = "MembershipNameDataGridViewTextBoxColumn"
        Me.MembershipNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FeeDataGridViewTextBoxColumn
        '
        Me.FeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FeeDataGridViewTextBoxColumn.DataPropertyName = "Fee"
        Me.FeeDataGridViewTextBoxColumn.HeaderText = "Fee"
        Me.FeeDataGridViewTextBoxColumn.Name = "FeeDataGridViewTextBoxColumn"
        Me.FeeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MembershipType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 370)
        Me.Controls.Add(Me.MembershipTypeDataGrid)
        Me.Controls.Add(Me.MembershipTypeLab)
        Me.Controls.Add(Me.LogoPicBox)
        Me.Name = "MembershipType"
        Me.Text = "Membership Type"
        CType(Me.LogoPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembershipTypeDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KingswayFitnessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembershipTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogoPicBox As PictureBox
    Friend WithEvents MembershipTypeLab As Label
    Friend WithEvents MembershipTypeDataGrid As DataGridView
    Friend WithEvents KingswayFitnessDataSet1 As KingswayFitnessDataSet1
    Friend WithEvents MembershipTypeBindingSource As BindingSource
    Friend WithEvents Membership_TypeTableAdapter As KingswayFitnessDataSet1TableAdapters.Membership_TypeTableAdapter
    Friend WithEvents MembertypeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MembershipNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
