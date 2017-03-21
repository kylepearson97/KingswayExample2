<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CurrentClientList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WelcomeMessage = New System.Windows.Forms.Label()
        Me.NumberofCustomers = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CurrentClient = New System.Windows.Forms.DataGridView()
        Me.MembersID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Forename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Surname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeLoggedIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Logout = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ActivityLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KingswayFitnessDataSet1 = New WindowsApplication1.KingswayFitnessDataSet1()
        Me.KingswayFitnessDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Activity_LogTableAdapter = New WindowsApplication1.KingswayFitnessDataSet1TableAdapters.Activity_LogTableAdapter()
        Me.Member_Activity_LogTableAdapter1 = New WindowsApplication1.KingswayFitnessDataSet1TableAdapters.Member_Activity_LogTableAdapter()
        Me.MembersTableAdapter1 = New WindowsApplication1.KingswayFitnessDataSet1TableAdapters.MembersTableAdapter()
        Me.TempdataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TempdataTableAdapter = New WindowsApplication1.KingswayFitnessDataSet1TableAdapters.tempdataTableAdapter()
        Me.TempdataTableAdapter1 = New WindowsApplication1.KingswayFitnessDataSet1TableAdapters.tempdataTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivityLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KingswayFitnessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KingswayFitnessDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TempdataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(-15, -9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 129)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'WelcomeMessage
        '
        Me.WelcomeMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WelcomeMessage.AutoSize = True
        Me.WelcomeMessage.BackColor = System.Drawing.Color.Transparent
        Me.WelcomeMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeMessage.Location = New System.Drawing.Point(260, 9)
        Me.WelcomeMessage.Name = "WelcomeMessage"
        Me.WelcomeMessage.Size = New System.Drawing.Size(355, 29)
        Me.WelcomeMessage.TabIndex = 6
        Me.WelcomeMessage.Text = "Current Customers Logged In"
        '
        'NumberofCustomers
        '
        Me.NumberofCustomers.AutoSize = True
        Me.NumberofCustomers.BackColor = System.Drawing.Color.Transparent
        Me.NumberofCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberofCustomers.Location = New System.Drawing.Point(280, 48)
        Me.NumberofCustomers.Name = "NumberofCustomers"
        Me.NumberofCustomers.Size = New System.Drawing.Size(57, 63)
        Me.NumberofCustomers.TabIndex = 7
        Me.NumberofCustomers.Text = "0"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(507, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 40)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(363, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(126, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(351, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Input MemberID Below"
        '
        'CurrentClient
        '
        Me.CurrentClient.AllowUserToAddRows = False
        Me.CurrentClient.AllowUserToDeleteRows = False
        Me.CurrentClient.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.CurrentClient.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CurrentClient.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CurrentClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CurrentClient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MembersID, Me.Forename, Me.Surname, Me.TimeLoggedIn, Me.Logout})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CurrentClient.DefaultCellStyle = DataGridViewCellStyle2
        Me.CurrentClient.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.CurrentClient.Location = New System.Drawing.Point(2, 150)
        Me.CurrentClient.Name = "CurrentClient"
        Me.CurrentClient.ReadOnly = True
        Me.CurrentClient.Size = New System.Drawing.Size(674, 514)
        Me.CurrentClient.TabIndex = 17
        '
        'MembersID
        '
        Me.MembersID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MembersID.HeaderText = "Members ID"
        Me.MembersID.Name = "MembersID"
        Me.MembersID.ReadOnly = True
        '
        'Forename
        '
        Me.Forename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Forename.HeaderText = "Forename"
        Me.Forename.Name = "Forename"
        Me.Forename.ReadOnly = True
        '
        'Surname
        '
        Me.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Surname.HeaderText = "Surname"
        Me.Surname.Name = "Surname"
        Me.Surname.ReadOnly = True
        '
        'TimeLoggedIn
        '
        Me.TimeLoggedIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TimeLoggedIn.HeaderText = "Time Logged In"
        Me.TimeLoggedIn.Name = "TimeLoggedIn"
        Me.TimeLoggedIn.ReadOnly = True
        '
        'Logout
        '
        Me.Logout.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Logout.HeaderText = "Logout"
        Me.Logout.Name = "Logout"
        Me.Logout.ReadOnly = True
        Me.Logout.UseColumnTextForButtonValue = True
        '
        'ActivityLogBindingSource
        '
        Me.ActivityLogBindingSource.DataMember = "Activity Log"
        Me.ActivityLogBindingSource.DataSource = Me.KingswayFitnessDataSet1
        '
        'KingswayFitnessDataSet1
        '
        Me.KingswayFitnessDataSet1.DataSetName = "KingswayFitnessDataSet1"
        Me.KingswayFitnessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KingswayFitnessDataSet1BindingSource
        '
        Me.KingswayFitnessDataSet1BindingSource.DataSource = Me.KingswayFitnessDataSet1
        Me.KingswayFitnessDataSet1BindingSource.Position = 0
        '
        'Activity_LogTableAdapter
        '
        Me.Activity_LogTableAdapter.ClearBeforeFill = True
        '
        'Member_Activity_LogTableAdapter1
        '
        Me.Member_Activity_LogTableAdapter1.ClearBeforeFill = True
        '
        'MembersTableAdapter1
        '
        Me.MembersTableAdapter1.ClearBeforeFill = True
        '
        'TempdataBindingSource
        '
        Me.TempdataBindingSource.DataMember = "tempdata"
        Me.TempdataBindingSource.DataSource = Me.KingswayFitnessDataSet1BindingSource
        '
        'TempdataTableAdapter
        '
        Me.TempdataTableAdapter.ClearBeforeFill = True
        '
        'TempdataTableAdapter1
        '
        Me.TempdataTableAdapter1.ClearBeforeFill = True
        '
        'CurrentClientList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(678, 667)
        Me.Controls.Add(Me.CurrentClient)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NumberofCustomers)
        Me.Controls.Add(Me.WelcomeMessage)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "CurrentClientList"
        Me.Text = "CurrentClientList"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivityLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KingswayFitnessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KingswayFitnessDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TempdataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WelcomeMessage As Label
    Friend WithEvents NumberofCustomers As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CurrentClient As DataGridView
    Friend WithEvents KingswayFitnessDataSet1BindingSource As BindingSource
    Friend WithEvents KingswayFitnessDataSet1 As KingswayFitnessDataSet1
    Friend WithEvents ActivityLogBindingSource As BindingSource
    Friend WithEvents Activity_LogTableAdapter As KingswayFitnessDataSet1TableAdapters.Activity_LogTableAdapter
    Friend WithEvents Member_Activity_LogTableAdapter1 As KingswayFitnessDataSet1TableAdapters.Member_Activity_LogTableAdapter
    Friend WithEvents MembersID As DataGridViewTextBoxColumn
    Friend WithEvents Forename As DataGridViewTextBoxColumn
    Friend WithEvents Surname As DataGridViewTextBoxColumn
    Friend WithEvents TimeLoggedIn As DataGridViewTextBoxColumn
    Friend WithEvents Logout As DataGridViewButtonColumn
    Friend WithEvents MembersTableAdapter1 As KingswayFitnessDataSet1TableAdapters.MembersTableAdapter
    Friend WithEvents TempdataBindingSource As BindingSource
    Friend WithEvents TempdataTableAdapter As KingswayFitnessDataSet1TableAdapters.tempdataTableAdapter
    Friend WithEvents TempdataTableAdapter1 As KingswayFitnessDataSet1TableAdapters.tempdataTableAdapter
End Class
