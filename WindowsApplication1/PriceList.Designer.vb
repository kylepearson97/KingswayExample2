<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PriceList
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
        Me.PriceTable = New System.Windows.Forms.TableLayoutPanel()
        Me.LogoPicBox = New System.Windows.Forms.PictureBox()
        Me.MemberTyLab = New System.Windows.Forms.Label()
        Me.DiscountLab = New System.Windows.Forms.Label()
        Me.PriceLab = New System.Windows.Forms.Label()
        Me.PriceWelLab = New System.Windows.Forms.Label()
        Me.PriceTable.SuspendLayout()
        CType(Me.LogoPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PriceTable
        '
        Me.PriceTable.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PriceTable.ColumnCount = 3
        Me.PriceTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.PriceTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.PriceTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.PriceTable.Controls.Add(Me.PriceLab, 0, 0)
        Me.PriceTable.Controls.Add(Me.DiscountLab, 1, 0)
        Me.PriceTable.Controls.Add(Me.MemberTyLab, 2, 0)
        Me.PriceTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTable.Location = New System.Drawing.Point(12, 126)
        Me.PriceTable.Name = "PriceTable"
        Me.PriceTable.RowCount = 2
        Me.PriceTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.PriceTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PriceTable.Size = New System.Drawing.Size(496, 52)
        Me.PriceTable.TabIndex = 0
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
        'MemberTyLab
        '
        Me.MemberTyLab.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemberTyLab.AutoSize = True
        Me.MemberTyLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberTyLab.Location = New System.Drawing.Point(265, 3)
        Me.MemberTyLab.Name = "MemberTyLab"
        Me.MemberTyLab.Size = New System.Drawing.Size(164, 24)
        Me.MemberTyLab.TabIndex = 0
        Me.MemberTyLab.Text = "Membership Type"
        '
        'DiscountLab
        '
        Me.DiscountLab.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DiscountLab.AutoSize = True
        Me.DiscountLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountLab.Location = New System.Drawing.Point(107, 3)
        Me.DiscountLab.Name = "DiscountLab"
        Me.DiscountLab.Size = New System.Drawing.Size(83, 24)
        Me.DiscountLab.TabIndex = 2
        Me.DiscountLab.Text = "Discount"
        '
        'PriceLab
        '
        Me.PriceLab.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PriceLab.AutoSize = True
        Me.PriceLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLab.Location = New System.Drawing.Point(23, 3)
        Me.PriceLab.Name = "PriceLab"
        Me.PriceLab.Size = New System.Drawing.Size(53, 24)
        Me.PriceLab.TabIndex = 3
        Me.PriceLab.Text = "Price"
        '
        'PriceWelLab
        '
        Me.PriceWelLab.AutoSize = True
        Me.PriceWelLab.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceWelLab.Location = New System.Drawing.Point(253, 9)
        Me.PriceWelLab.Name = "PriceWelLab"
        Me.PriceWelLab.Size = New System.Drawing.Size(122, 29)
        Me.PriceWelLab.TabIndex = 4
        Me.PriceWelLab.Text = "Price List"
        '
        'PriceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 691)
        Me.Controls.Add(Me.PriceWelLab)
        Me.Controls.Add(Me.LogoPicBox)
        Me.Controls.Add(Me.PriceTable)
        Me.Name = "PriceList"
        Me.Text = "PriceList"
        Me.PriceTable.ResumeLayout(False)
        Me.PriceTable.PerformLayout()
        CType(Me.LogoPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PriceTable As TableLayoutPanel
    Friend WithEvents LogoPicBox As PictureBox
    Friend WithEvents MemberTyLab As Label
    Friend WithEvents DiscountLab As Label
    Friend WithEvents PriceLab As Label
    Friend WithEvents PriceWelLab As Label
End Class
