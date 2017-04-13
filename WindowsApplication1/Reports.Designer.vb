<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Me.CustomerFormLab = New System.Windows.Forms.Label()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.OldCustomer = New System.Windows.Forms.PictureBox()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OldCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerFormLab
        '
        Me.CustomerFormLab.AutoSize = True
        Me.CustomerFormLab.BackColor = System.Drawing.Color.Transparent
        Me.CustomerFormLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerFormLab.Location = New System.Drawing.Point(155, 9)
        Me.CustomerFormLab.Name = "CustomerFormLab"
        Me.CustomerFormLab.Size = New System.Drawing.Size(163, 29)
        Me.CustomerFormLab.TabIndex = 8
        Me.CustomerFormLab.Text = "Report Menu"
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.Image = Global.WindowsApplication1.My.Resources.Resources.Logo
        Me.Logo.Location = New System.Drawing.Point(-15, -9)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(164, 88)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 2
        Me.Logo.TabStop = False
        '
        'OldCustomer
        '
        Me.OldCustomer.Image = Global.WindowsApplication1.My.Resources.Resources.OldCustNoClick
        Me.OldCustomer.Location = New System.Drawing.Point(38, 103)
        Me.OldCustomer.Name = "OldCustomer"
        Me.OldCustomer.Size = New System.Drawing.Size(250, 50)
        Me.OldCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.OldCustomer.TabIndex = 0
        Me.OldCustomer.TabStop = False
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(318, 405)
        Me.Controls.Add(Me.CustomerFormLab)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.OldCustomer)
        Me.DoubleBuffered = True
        Me.Name = "Reports"
        Me.Text = "Reports"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OldCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OldCustomer As PictureBox
    Friend WithEvents Logo As PictureBox
    Friend WithEvents CustomerFormLab As Label
End Class
