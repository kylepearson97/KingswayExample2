<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OldCustomer
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
        Me.OldMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KingswayFitnessDataSet1 = New WindowsApplication1.KingswayFitnessDataSet1()
        Me.Old_MembersTableAdapter = New WindowsApplication1.KingswayFitnessDataSet1TableAdapters.Old_MembersTableAdapter()
        Me.TodayActive1 = New WindowsApplication1.TodayActive()
        Me.OldCustom1 = New WindowsApplication1.OldCustom()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.OldCustom2 = New WindowsApplication1.OldCustom()
        CType(Me.OldMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KingswayFitnessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OldMembersBindingSource
        '
        Me.OldMembersBindingSource.DataMember = "Old Members"
        Me.OldMembersBindingSource.DataSource = Me.KingswayFitnessDataSet1
        '
        'KingswayFitnessDataSet1
        '
        Me.KingswayFitnessDataSet1.DataSetName = "KingswayFitnessDataSet1"
        Me.KingswayFitnessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Old_MembersTableAdapter
        '
        Me.Old_MembersTableAdapter.ClearBeforeFill = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.OldCustom2
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1113, 616)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'OldCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 616)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "OldCustomer"
        Me.Text = "OldCustomer"
        CType(Me.OldMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KingswayFitnessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KingswayFitnessDataSet1 As KingswayFitnessDataSet1
    Friend WithEvents OldMembersBindingSource As BindingSource
    Friend WithEvents Old_MembersTableAdapter As KingswayFitnessDataSet1TableAdapters.Old_MembersTableAdapter
    Friend WithEvents TodayActive1 As TodayActive
    Friend WithEvents OldCustom1 As OldCustom
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents OldCustom2 As OldCustom
End Class
