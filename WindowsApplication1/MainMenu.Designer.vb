<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.AddCustomer = New System.Windows.Forms.PictureBox()
        Me.ViewEditCustomer = New System.Windows.Forms.PictureBox()
        Me.CurrentClient = New System.Windows.Forms.PictureBox()
        Me.PriceList = New System.Windows.Forms.PictureBox()
        Me.Report = New System.Windows.Forms.PictureBox()
        Me.Admin = New System.Windows.Forms.PictureBox()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.WelcomeMessage = New System.Windows.Forms.Label()
        CType(Me.AddCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewEditCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Report, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Admin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddCustomer
        '
        Me.AddCustomer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddCustomer.Image = Global.WindowsApplication1.My.Resources.Resources.AddCustomerNoClick
        Me.AddCustomer.Location = New System.Drawing.Point(12, 243)
        Me.AddCustomer.Name = "AddCustomer"
        Me.AddCustomer.Size = New System.Drawing.Size(250, 120)
        Me.AddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AddCustomer.TabIndex = 0
        Me.AddCustomer.TabStop = False
        '
        'ViewEditCustomer
        '
        Me.ViewEditCustomer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ViewEditCustomer.Image = Global.WindowsApplication1.My.Resources.Resources.ViewEditNoClick
        Me.ViewEditCustomer.Location = New System.Drawing.Point(268, 243)
        Me.ViewEditCustomer.Name = "ViewEditCustomer"
        Me.ViewEditCustomer.Size = New System.Drawing.Size(250, 120)
        Me.ViewEditCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ViewEditCustomer.TabIndex = 0
        Me.ViewEditCustomer.TabStop = False
        '
        'CurrentClient
        '
        Me.CurrentClient.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CurrentClient.Image = Global.WindowsApplication1.My.Resources.Resources.CurrentClientNoclick
        Me.CurrentClient.Location = New System.Drawing.Point(524, 243)
        Me.CurrentClient.Name = "CurrentClient"
        Me.CurrentClient.Size = New System.Drawing.Size(250, 120)
        Me.CurrentClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CurrentClient.TabIndex = 0
        Me.CurrentClient.TabStop = False
        '
        'PriceList
        '
        Me.PriceList.Image = Global.WindowsApplication1.My.Resources.Resources.PriceListNoClick
        Me.PriceList.Location = New System.Drawing.Point(12, 369)
        Me.PriceList.Name = "PriceList"
        Me.PriceList.Size = New System.Drawing.Size(250, 120)
        Me.PriceList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PriceList.TabIndex = 0
        Me.PriceList.TabStop = False
        '
        'Report
        '
        Me.Report.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Report.Image = Global.WindowsApplication1.My.Resources.Resources.ReportsNoClick
        Me.Report.Location = New System.Drawing.Point(268, 369)
        Me.Report.Name = "Report"
        Me.Report.Size = New System.Drawing.Size(250, 120)
        Me.Report.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Report.TabIndex = 0
        Me.Report.TabStop = False
        '
        'Admin
        '
        Me.Admin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Admin.Image = Global.WindowsApplication1.My.Resources.Resources.AdminNoClick
        Me.Admin.Location = New System.Drawing.Point(524, 369)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(250, 120)
        Me.Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Admin.TabIndex = 0
        Me.Admin.TabStop = False
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(-15, -9)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(262, 129)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 2
        Me.Logo.TabStop = False
        '
        'WelcomeMessage
        '
        Me.WelcomeMessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.WelcomeMessage.AutoSize = True
        Me.WelcomeMessage.BackColor = System.Drawing.Color.Transparent
        Me.WelcomeMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeMessage.Location = New System.Drawing.Point(133, 177)
        Me.WelcomeMessage.Name = "WelcomeMessage"
        Me.WelcomeMessage.Size = New System.Drawing.Size(508, 31)
        Me.WelcomeMessage.TabIndex = 3
        Me.WelcomeMessage.Text = "Welcome to Kingsway Fitness System"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 500)
        Me.Controls.Add(Me.WelcomeMessage)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Admin)
        Me.Controls.Add(Me.Report)
        Me.Controls.Add(Me.CurrentClient)
        Me.Controls.Add(Me.PriceList)
        Me.Controls.Add(Me.ViewEditCustomer)
        Me.Controls.Add(Me.AddCustomer)
        Me.DoubleBuffered = True
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.AddCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewEditCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Report, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Admin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddCustomer As PictureBox
    Friend WithEvents ViewEditCustomer As PictureBox
    Friend WithEvents CurrentClient As PictureBox
    Friend WithEvents PriceList As PictureBox
    Friend WithEvents Report As PictureBox
    Friend WithEvents Admin As PictureBox
    Friend WithEvents Logo As PictureBox
    Friend WithEvents WelcomeMessage As Label
End Class
