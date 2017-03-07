<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KingswayFitnessDataSet = New WindowsApplication1.KingswayFitnessDataSet()
        Me.MembersTableAdapter = New WindowsApplication1.KingswayFitnessDataSetTableAdapters.MembersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.KingswayFitnessDataSetTableAdapters.TableAdapterManager()
        Me.KingswayFitnessDataSet1 = New WindowsApplication1.KingswayFitnessDataSet1()
        Me.MembersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersTableAdapter1 = New WindowsApplication1.KingswayFitnessDataSet1TableAdapters.MembersTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.KingswayFitnessDataSet1TableAdapters.TableAdapterManager()
        Me.Members_Address_TableAdapter1 = New WindowsApplication1.KingswayFitnessDataSet1TableAdapters.Members_Address_TableAdapter()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KingswayFitnessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KingswayFitnessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.Image = Global.WindowsApplication1.My.Resources.Resources.Logo
        Me.Logo.Location = New System.Drawing.Point(-15, -9)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(262, 129)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.KingswayFitnessDataSet
        '
        'KingswayFitnessDataSet
        '
        Me.KingswayFitnessDataSet.DataSetName = "KingswayFitnessDataSet"
        Me.KingswayFitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Emergency_ContactTableAdapter = Nothing
        Me.TableAdapterManager.InductionsTableAdapter = Nothing
        Me.TableAdapterManager.Medical_TableTableAdapter = Nothing
        Me.TableAdapterManager.Members_Address_TableTableAdapter = Nothing
        Me.TableAdapterManager.Members_ReasonsTableAdapter = Nothing
        Me.TableAdapterManager.Membership_TypeTableAdapter = Nothing
        Me.TableAdapterManager.MembersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.KingswayFitnessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KingswayFitnessDataSet1
        '
        Me.KingswayFitnessDataSet1.DataSetName = "KingswayFitnessDataSet1"
        Me.KingswayFitnessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersBindingSource1
        '
        Me.MembersBindingSource1.DataMember = "Members"
        Me.MembersBindingSource1.DataSource = Me.KingswayFitnessDataSet1
        '
        'MembersTableAdapter1
        '
        Me.MembersTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Emergency_ContactTableAdapter = Nothing
        Me.TableAdapterManager1.InductionsTableAdapter = Nothing
        Me.TableAdapterManager1.Medical_TableTableAdapter = Nothing
        Me.TableAdapterManager1.Members_Address_TableAdapter = Nothing
        Me.TableAdapterManager1.Members_ReasonsTableAdapter = Nothing
        Me.TableAdapterManager1.Membership_TypeTableAdapter = Nothing
        Me.TableAdapterManager1.MembersTableAdapter = Me.MembersTableAdapter1
        Me.TableAdapterManager1.StaffTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.KingswayFitnessDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Members_Address_TableAdapter1
        '
        Me.Members_Address_TableAdapter1.ClearBeforeFill = True
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(678, 567)
        Me.Controls.Add(Me.Logo)
        Me.DoubleBuffered = True
        Me.Name = "CustomerForm"
        Me.Text = "Customer Form Menu"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KingswayFitnessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KingswayFitnessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Logo As PictureBox
    Friend WithEvents KingswayFitnessDataSet As KingswayFitnessDataSet
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As KingswayFitnessDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents TableAdapterManager As KingswayFitnessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KingswayFitnessDataSet1 As KingswayFitnessDataSet1
    Friend WithEvents MembersBindingSource1 As BindingSource
    Friend WithEvents MembersTableAdapter1 As KingswayFitnessDataSet1TableAdapters.MembersTableAdapter
    Friend WithEvents TableAdapterManager1 As KingswayFitnessDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Members_Address_TableAdapter1 As KingswayFitnessDataSet1TableAdapters.Members_Address_TableAdapter
End Class
