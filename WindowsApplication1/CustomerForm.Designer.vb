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
        Me.Forename = New System.Windows.Forms.Label()
        Me.Surname = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.Label()
        Me.Occupation = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.Label()
        Me.HomePhoneNumber = New System.Windows.Forms.Label()
        Me.MobileNo = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.Renewal = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.Label()
        Me.MemberType = New System.Windows.Forms.Label()
        Me.DateJoin = New System.Windows.Forms.Label()
        Me.MemberID = New System.Windows.Forms.Label()
        Me.MemPhoto = New System.Windows.Forms.PictureBox()
        Me.Address1 = New System.Windows.Forms.TextBox()
        Me.Address2 = New System.Windows.Forms.TextBox()
        Me.Address3 = New System.Windows.Forms.TextBox()
        Me.Address4 = New System.Windows.Forms.TextBox()
        Me.MemOccupation = New System.Windows.Forms.TextBox()
        Me.MemGender = New System.Windows.Forms.TextBox()
        Me.MemType = New System.Windows.Forms.TextBox()
        Me.MemDateJoin = New System.Windows.Forms.TextBox()
        Me.MemEmail = New System.Windows.Forms.TextBox()
        Me.MemRenewal = New System.Windows.Forms.TextBox()
        Me.MemHome = New System.Windows.Forms.TextBox()
        Me.MemStatus = New System.Windows.Forms.TextBox()
        Me.MemDOB = New System.Windows.Forms.TextBox()
        Me.MemMobile = New System.Windows.Forms.TextBox()
        Me.Firstname = New System.Windows.Forms.TextBox()
        Me.Lastname = New System.Windows.Forms.TextBox()
        Me.MembersID = New System.Windows.Forms.TextBox()
        Me.Address5 = New System.Windows.Forms.TextBox()
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
        CType(Me.MemPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Forename
        '
        Me.Forename.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Forename.AutoSize = True
        Me.Forename.BackColor = System.Drawing.Color.Transparent
        Me.Forename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Forename.Location = New System.Drawing.Point(24, 214)
        Me.Forename.Name = "Forename"
        Me.Forename.Size = New System.Drawing.Size(82, 20)
        Me.Forename.TabIndex = 1
        Me.Forename.Text = "Forename"
        '
        'Surname
        '
        Me.Surname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Surname.AutoSize = True
        Me.Surname.BackColor = System.Drawing.Color.Transparent
        Me.Surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Surname.Location = New System.Drawing.Point(24, 256)
        Me.Surname.Name = "Surname"
        Me.Surname.Size = New System.Drawing.Size(74, 20)
        Me.Surname.TabIndex = 1
        Me.Surname.Text = "Surname"
        '
        'Address
        '
        Me.Address.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Address.AutoSize = True
        Me.Address.BackColor = System.Drawing.Color.Transparent
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(24, 296)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(68, 20)
        Me.Address.TabIndex = 1
        Me.Address.Text = "Address"
        '
        'Occupation
        '
        Me.Occupation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Occupation.AutoSize = True
        Me.Occupation.BackColor = System.Drawing.Color.Transparent
        Me.Occupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Occupation.Location = New System.Drawing.Point(24, 493)
        Me.Occupation.Name = "Occupation"
        Me.Occupation.Size = New System.Drawing.Size(90, 20)
        Me.Occupation.TabIndex = 1
        Me.Occupation.Text = "Occupation"
        '
        'Gender
        '
        Me.Gender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Gender.AutoSize = True
        Me.Gender.BackColor = System.Drawing.Color.Transparent
        Me.Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.Location = New System.Drawing.Point(338, 174)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(63, 20)
        Me.Gender.TabIndex = 1
        Me.Gender.Text = "Gender"
        '
        'DOB
        '
        Me.DOB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DOB.AutoSize = True
        Me.DOB.BackColor = System.Drawing.Color.Transparent
        Me.DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB.Location = New System.Drawing.Point(338, 216)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(52, 20)
        Me.DOB.TabIndex = 1
        Me.DOB.Text = "D.O.B"
        Me.DOB.UseMnemonic = False
        '
        'HomePhoneNumber
        '
        Me.HomePhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HomePhoneNumber.AutoSize = True
        Me.HomePhoneNumber.BackColor = System.Drawing.Color.Transparent
        Me.HomePhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomePhoneNumber.Location = New System.Drawing.Point(338, 294)
        Me.HomePhoneNumber.Name = "HomePhoneNumber"
        Me.HomePhoneNumber.Size = New System.Drawing.Size(130, 20)
        Me.HomePhoneNumber.TabIndex = 1
        Me.HomePhoneNumber.Text = "Home Phone No."
        '
        'MobileNo
        '
        Me.MobileNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MobileNo.AutoSize = True
        Me.MobileNo.BackColor = System.Drawing.Color.Transparent
        Me.MobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileNo.Location = New System.Drawing.Point(338, 256)
        Me.MobileNo.Name = "MobileNo"
        Me.MobileNo.Size = New System.Drawing.Size(83, 20)
        Me.MobileNo.TabIndex = 1
        Me.MobileNo.Text = "Mobile No."
        '
        'Email
        '
        Me.Email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Email.AutoSize = True
        Me.Email.BackColor = System.Drawing.Color.Transparent
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(338, 374)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(111, 20)
        Me.Email.TabIndex = 1
        Me.Email.Text = "Email Address"
        '
        'Renewal
        '
        Me.Renewal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Renewal.AutoSize = True
        Me.Renewal.BackColor = System.Drawing.Color.Transparent
        Me.Renewal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Renewal.Location = New System.Drawing.Point(338, 414)
        Me.Renewal.Name = "Renewal"
        Me.Renewal.Size = New System.Drawing.Size(110, 20)
        Me.Renewal.TabIndex = 1
        Me.Renewal.Text = "Renewal Date"
        '
        'Status
        '
        Me.Status.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Status.AutoSize = True
        Me.Status.BackColor = System.Drawing.Color.Transparent
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Location = New System.Drawing.Point(338, 334)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(56, 20)
        Me.Status.TabIndex = 1
        Me.Status.Text = "Status"
        '
        'MemberType
        '
        Me.MemberType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemberType.AutoSize = True
        Me.MemberType.BackColor = System.Drawing.Color.Transparent
        Me.MemberType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberType.Location = New System.Drawing.Point(338, 493)
        Me.MemberType.Name = "MemberType"
        Me.MemberType.Size = New System.Drawing.Size(134, 20)
        Me.MemberType.TabIndex = 1
        Me.MemberType.Text = "Membership Type"
        '
        'DateJoin
        '
        Me.DateJoin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateJoin.AutoSize = True
        Me.DateJoin.BackColor = System.Drawing.Color.Transparent
        Me.DateJoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateJoin.Location = New System.Drawing.Point(338, 454)
        Me.DateJoin.Name = "DateJoin"
        Me.DateJoin.Size = New System.Drawing.Size(95, 20)
        Me.DateJoin.TabIndex = 1
        Me.DateJoin.Text = "Date Joined"
        '
        'MemberID
        '
        Me.MemberID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemberID.AutoSize = True
        Me.MemberID.BackColor = System.Drawing.Color.Transparent
        Me.MemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberID.Location = New System.Drawing.Point(24, 174)
        Me.MemberID.Name = "MemberID"
        Me.MemberID.Size = New System.Drawing.Size(88, 20)
        Me.MemberID.TabIndex = 1
        Me.MemberID.Text = "Member ID"
        '
        'MemPhoto
        '
        Me.MemPhoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemPhoto.Location = New System.Drawing.Point(489, 10)
        Me.MemPhoto.Name = "MemPhoto"
        Me.MemPhoto.Size = New System.Drawing.Size(150, 150)
        Me.MemPhoto.TabIndex = 2
        Me.MemPhoto.TabStop = False
        '
        'Address1
        '
        Me.Address1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Address1.Location = New System.Drawing.Point(163, 296)
        Me.Address1.Name = "Address1"
        Me.Address1.Size = New System.Drawing.Size(168, 20)
        Me.Address1.TabIndex = 3
        '
        'Address2
        '
        Me.Address2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Address2.Location = New System.Drawing.Point(162, 336)
        Me.Address2.Name = "Address2"
        Me.Address2.Size = New System.Drawing.Size(168, 20)
        Me.Address2.TabIndex = 3
        '
        'Address3
        '
        Me.Address3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Address3.Location = New System.Drawing.Point(163, 376)
        Me.Address3.Name = "Address3"
        Me.Address3.Size = New System.Drawing.Size(168, 20)
        Me.Address3.TabIndex = 3
        '
        'Address4
        '
        Me.Address4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Address4.Location = New System.Drawing.Point(163, 416)
        Me.Address4.Name = "Address4"
        Me.Address4.Size = New System.Drawing.Size(168, 20)
        Me.Address4.TabIndex = 3
        '
        'MemOccupation
        '
        Me.MemOccupation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemOccupation.Location = New System.Drawing.Point(162, 495)
        Me.MemOccupation.Name = "MemOccupation"
        Me.MemOccupation.Size = New System.Drawing.Size(168, 20)
        Me.MemOccupation.TabIndex = 3
        '
        'MemGender
        '
        Me.MemGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemGender.Location = New System.Drawing.Point(478, 174)
        Me.MemGender.Name = "MemGender"
        Me.MemGender.Size = New System.Drawing.Size(168, 20)
        Me.MemGender.TabIndex = 3
        '
        'MemType
        '
        Me.MemType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemType.Location = New System.Drawing.Point(478, 495)
        Me.MemType.Name = "MemType"
        Me.MemType.Size = New System.Drawing.Size(168, 20)
        Me.MemType.TabIndex = 3
        '
        'MemDateJoin
        '
        Me.MemDateJoin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemDateJoin.Location = New System.Drawing.Point(478, 456)
        Me.MemDateJoin.Name = "MemDateJoin"
        Me.MemDateJoin.Size = New System.Drawing.Size(168, 20)
        Me.MemDateJoin.TabIndex = 3
        '
        'MemEmail
        '
        Me.MemEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemEmail.Location = New System.Drawing.Point(478, 376)
        Me.MemEmail.Name = "MemEmail"
        Me.MemEmail.Size = New System.Drawing.Size(168, 20)
        Me.MemEmail.TabIndex = 3
        '
        'MemRenewal
        '
        Me.MemRenewal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemRenewal.Location = New System.Drawing.Point(478, 416)
        Me.MemRenewal.Name = "MemRenewal"
        Me.MemRenewal.Size = New System.Drawing.Size(168, 20)
        Me.MemRenewal.TabIndex = 3
        '
        'MemHome
        '
        Me.MemHome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemHome.Location = New System.Drawing.Point(478, 296)
        Me.MemHome.Name = "MemHome"
        Me.MemHome.Size = New System.Drawing.Size(168, 20)
        Me.MemHome.TabIndex = 3
        '
        'MemStatus
        '
        Me.MemStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemStatus.Location = New System.Drawing.Point(478, 336)
        Me.MemStatus.Name = "MemStatus"
        Me.MemStatus.Size = New System.Drawing.Size(168, 20)
        Me.MemStatus.TabIndex = 3
        '
        'MemDOB
        '
        Me.MemDOB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemDOB.Location = New System.Drawing.Point(478, 216)
        Me.MemDOB.Name = "MemDOB"
        Me.MemDOB.Size = New System.Drawing.Size(168, 20)
        Me.MemDOB.TabIndex = 3
        '
        'MemMobile
        '
        Me.MemMobile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemMobile.Location = New System.Drawing.Point(478, 254)
        Me.MemMobile.Name = "MemMobile"
        Me.MemMobile.Size = New System.Drawing.Size(168, 20)
        Me.MemMobile.TabIndex = 3
        '
        'Firstname
        '
        Me.Firstname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Firstname.Location = New System.Drawing.Point(163, 216)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(168, 20)
        Me.Firstname.TabIndex = 3
        '
        'Lastname
        '
        Me.Lastname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lastname.Location = New System.Drawing.Point(162, 256)
        Me.Lastname.Name = "Lastname"
        Me.Lastname.Size = New System.Drawing.Size(168, 20)
        Me.Lastname.TabIndex = 3
        '
        'MembersID
        '
        Me.MembersID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MembersID.Location = New System.Drawing.Point(162, 176)
        Me.MembersID.Name = "MembersID"
        Me.MembersID.Size = New System.Drawing.Size(168, 20)
        Me.MembersID.TabIndex = 3
        '
        'Address5
        '
        Me.Address5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Address5.Location = New System.Drawing.Point(162, 454)
        Me.Address5.Name = "Address5"
        Me.Address5.Size = New System.Drawing.Size(168, 20)
        Me.Address5.TabIndex = 3
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
        Me.Controls.Add(Me.MemMobile)
        Me.Controls.Add(Me.MemStatus)
        Me.Controls.Add(Me.MemDOB)
        Me.Controls.Add(Me.MemHome)
        Me.Controls.Add(Me.MemRenewal)
        Me.Controls.Add(Me.MemEmail)
        Me.Controls.Add(Me.MemDateJoin)
        Me.Controls.Add(Me.MemType)
        Me.Controls.Add(Me.MemGender)
        Me.Controls.Add(Me.MemOccupation)
        Me.Controls.Add(Me.Address5)
        Me.Controls.Add(Me.Address4)
        Me.Controls.Add(Me.Address3)
        Me.Controls.Add(Me.Lastname)
        Me.Controls.Add(Me.Address2)
        Me.Controls.Add(Me.MembersID)
        Me.Controls.Add(Me.Firstname)
        Me.Controls.Add(Me.Address1)
        Me.Controls.Add(Me.MemPhoto)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.MemberID)
        Me.Controls.Add(Me.MobileNo)
        Me.Controls.Add(Me.DateJoin)
        Me.Controls.Add(Me.HomePhoneNumber)
        Me.Controls.Add(Me.MemberType)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Renewal)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.Occupation)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Surname)
        Me.Controls.Add(Me.Forename)
        Me.Controls.Add(Me.Logo)
        Me.DoubleBuffered = True
        Me.Name = "CustomerForm"
        Me.Text = "Customer Form Menu"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KingswayFitnessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KingswayFitnessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Logo As PictureBox
    Friend WithEvents Forename As Label
    Friend WithEvents Surname As Label
    Friend WithEvents Address As Label
    Friend WithEvents Occupation As Label
    Friend WithEvents Gender As Label
    Friend WithEvents DOB As Label
    Friend WithEvents HomePhoneNumber As Label
    Friend WithEvents MobileNo As Label
    Friend WithEvents Email As Label
    Friend WithEvents Renewal As Label
    Friend WithEvents Status As Label
    Friend WithEvents MemberType As Label
    Friend WithEvents DateJoin As Label
    Friend WithEvents MemberID As Label
    Friend WithEvents MemPhoto As PictureBox
    Friend WithEvents Address1 As TextBox
    Friend WithEvents Address2 As TextBox
    Friend WithEvents Address3 As TextBox
    Friend WithEvents Address4 As TextBox
    Friend WithEvents MemOccupation As TextBox
    Friend WithEvents MemGender As TextBox
    Friend WithEvents MemType As TextBox
    Friend WithEvents MemDateJoin As TextBox
    Friend WithEvents MemEmail As TextBox
    Friend WithEvents MemRenewal As TextBox
    Friend WithEvents MemHome As TextBox
    Friend WithEvents MemStatus As TextBox
    Friend WithEvents MemDOB As TextBox
    Friend WithEvents MemMobile As TextBox
    Friend WithEvents Firstname As TextBox
    Friend WithEvents Lastname As TextBox
    Friend WithEvents MembersID As TextBox
    Friend WithEvents Address5 As TextBox
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
