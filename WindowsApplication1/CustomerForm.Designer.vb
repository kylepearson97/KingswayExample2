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
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource()
        Me.KingswayFitnessDataSet = New WindowsApplication1.KingswayFitnessDataSet()
        Me.MembersTableAdapter = New WindowsApplication1.KingswayFitnessDataSetTableAdapters.MembersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.KingswayFitnessDataSetTableAdapters.TableAdapterManager()
        Me.KingswayFitnessDataSet1 = New WindowsApplication1.KingswayFitnessDataSet1()
        Me.MembersBindingSource1 = New System.Windows.Forms.BindingSource()
        Me.MembersTableAdapter1 = New WindowsApplication1.KingswayFitnessDataSet1TableAdapters.MembersTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.KingswayFitnessDataSet1TableAdapters.TableAdapterManager()
        Me.Members_Address_TableAdapter1 = New WindowsApplication1.KingswayFitnessDataSet1TableAdapters.Members_Address_TableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Personal = New System.Windows.Forms.TabPage()
        Me.MemberID = New System.Windows.Forms.Label()
        Me.MemPhoto = New System.Windows.Forms.PictureBox()
        Me.MemType = New System.Windows.Forms.TextBox()
        Me.MemDateJoin = New System.Windows.Forms.TextBox()
        Me.MemRenewal = New System.Windows.Forms.TextBox()
        Me.MemStatus = New System.Windows.Forms.TextBox()
        Me.MemEmail = New System.Windows.Forms.TextBox()
        Me.MemMobile = New System.Windows.Forms.TextBox()
        Me.MemHome = New System.Windows.Forms.TextBox()
        Me.MembersID = New System.Windows.Forms.TextBox()
        Me.Forename = New System.Windows.Forms.Label()
        Me.MemberType = New System.Windows.Forms.Label()
        Me.DateJoin = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.MemDOB = New System.Windows.Forms.TextBox()
        Me.Renewal = New System.Windows.Forms.Label()
        Me.Firstname = New System.Windows.Forms.TextBox()
        Me.Surname = New System.Windows.Forms.Label()
        Me.Lastname = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.Label()
        Me.Address1 = New System.Windows.Forms.TextBox()
        Me.HomePhoneNumber = New System.Windows.Forms.Label()
        Me.Address2 = New System.Windows.Forms.TextBox()
        Me.MobileNo = New System.Windows.Forms.Label()
        Me.MemGender = New System.Windows.Forms.TextBox()
        Me.Address3 = New System.Windows.Forms.TextBox()
        Me.Address5 = New System.Windows.Forms.TextBox()
        Me.Address4 = New System.Windows.Forms.TextBox()
        Me.Gender = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.Label()
        Me.Medical = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OtherGMCB = New System.Windows.Forms.CheckBox()
        Me.OperCB = New System.Windows.Forms.CheckBox()
        Me.PregCB = New System.Windows.Forms.CheckBox()
        Me.BackCB = New System.Windows.Forms.CheckBox()
        Me.JointCB = New System.Windows.Forms.CheckBox()
        Me.SmokeCB = New System.Windows.Forms.CheckBox()
        Me.InjuryACB = New System.Windows.Forms.CheckBox()
        Me.BloodPCB = New System.Windows.Forms.CheckBox()
        Me.DiaCB = New System.Windows.Forms.CheckBox()
        Me.OtherGFACB = New System.Windows.Forms.CheckBox()
        Me.EpiCB = New System.Windows.Forms.CheckBox()
        Me.AstCB = New System.Windows.Forms.CheckBox()
        Me.FitterCB = New System.Windows.Forms.CheckBox()
        Me.ChestCB = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.WeightRCB = New System.Windows.Forms.CheckBox()
        Me.FaintCB = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BodyBCB = New System.Windows.Forms.CheckBox()
        Me.HeartCB = New System.Windows.Forms.CheckBox()
        Me.OtherDescGFA = New System.Windows.Forms.TextBox()
        Me.OtherDescGM = New System.Windows.Forms.TextBox()
        Me.OtherGM = New System.Windows.Forms.Label()
        Me.Dia = New System.Windows.Forms.Label()
        Me.Oper = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Label()
        Me.Ast = New System.Windows.Forms.Label()
        Me.DocNotePres = New System.Windows.Forms.Label()
        Me.InjuryA = New System.Windows.Forms.Label()
        Me.BloodP = New System.Windows.Forms.Label()
        Me.Preg = New System.Windows.Forms.Label()
        Me.DocNoteReq = New System.Windows.Forms.Label()
        Me.Joint = New System.Windows.Forms.Label()
        Me.Fitter = New System.Windows.Forms.Label()
        Me.Chest = New System.Windows.Forms.Label()
        Me.Smoke = New System.Windows.Forms.Label()
        Me.OtherGFA = New System.Windows.Forms.Label()
        Me.InducterName = New System.Windows.Forms.Label()
        Me.Epi = New System.Windows.Forms.Label()
        Me.WeightR = New System.Windows.Forms.Label()
        Me.Faint = New System.Windows.Forms.Label()
        Me.GFA = New System.Windows.Forms.Label()
        Me.Induct = New System.Windows.Forms.Label()
        Me.GM = New System.Windows.Forms.Label()
        Me.BodyB = New System.Windows.Forms.Label()
        Me.Heart = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KingswayFitnessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KingswayFitnessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Personal.SuspendLayout()
        CType(Me.MemPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Medical.SuspendLayout()
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Personal)
        Me.TabControl1.Controls.Add(Me.Medical)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 126)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(718, 442)
        Me.TabControl1.TabIndex = 5
        '
        'Personal
        '
        Me.Personal.BackColor = System.Drawing.Color.Transparent
        Me.Personal.Controls.Add(Me.MemberID)
        Me.Personal.Controls.Add(Me.MemPhoto)
        Me.Personal.Controls.Add(Me.MemType)
        Me.Personal.Controls.Add(Me.MemDateJoin)
        Me.Personal.Controls.Add(Me.MemRenewal)
        Me.Personal.Controls.Add(Me.MemStatus)
        Me.Personal.Controls.Add(Me.MemEmail)
        Me.Personal.Controls.Add(Me.MemMobile)
        Me.Personal.Controls.Add(Me.MemHome)
        Me.Personal.Controls.Add(Me.MembersID)
        Me.Personal.Controls.Add(Me.Forename)
        Me.Personal.Controls.Add(Me.MemberType)
        Me.Personal.Controls.Add(Me.DateJoin)
        Me.Personal.Controls.Add(Me.Email)
        Me.Personal.Controls.Add(Me.MemDOB)
        Me.Personal.Controls.Add(Me.Renewal)
        Me.Personal.Controls.Add(Me.Firstname)
        Me.Personal.Controls.Add(Me.Surname)
        Me.Personal.Controls.Add(Me.Lastname)
        Me.Personal.Controls.Add(Me.Address)
        Me.Personal.Controls.Add(Me.Status)
        Me.Personal.Controls.Add(Me.Address1)
        Me.Personal.Controls.Add(Me.HomePhoneNumber)
        Me.Personal.Controls.Add(Me.Address2)
        Me.Personal.Controls.Add(Me.MobileNo)
        Me.Personal.Controls.Add(Me.MemGender)
        Me.Personal.Controls.Add(Me.Address3)
        Me.Personal.Controls.Add(Me.Address5)
        Me.Personal.Controls.Add(Me.Address4)
        Me.Personal.Controls.Add(Me.Gender)
        Me.Personal.Controls.Add(Me.DOB)
        Me.Personal.Location = New System.Drawing.Point(4, 29)
        Me.Personal.Name = "Personal"
        Me.Personal.Padding = New System.Windows.Forms.Padding(3)
        Me.Personal.Size = New System.Drawing.Size(710, 409)
        Me.Personal.TabIndex = 0
        Me.Personal.Text = "Personal Details"
        '
        'MemberID
        '
        Me.MemberID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemberID.AutoSize = True
        Me.MemberID.BackColor = System.Drawing.Color.Transparent
        Me.MemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberID.Location = New System.Drawing.Point(21, 11)
        Me.MemberID.Name = "MemberID"
        Me.MemberID.Size = New System.Drawing.Size(88, 20)
        Me.MemberID.TabIndex = 1
        Me.MemberID.Text = "Member ID"
        '
        'MemPhoto
        '
        Me.MemPhoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MemPhoto.Location = New System.Drawing.Point(535, 11)
        Me.MemPhoto.Name = "MemPhoto"
        Me.MemPhoto.Size = New System.Drawing.Size(150, 150)
        Me.MemPhoto.TabIndex = 2
        Me.MemPhoto.TabStop = False
        '
        'MemType
        '
        Me.MemType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemType.Location = New System.Drawing.Point(535, 292)
        Me.MemType.Name = "MemType"
        Me.MemType.Size = New System.Drawing.Size(168, 26)
        Me.MemType.TabIndex = 3
        '
        'MemDateJoin
        '
        Me.MemDateJoin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemDateJoin.Location = New System.Drawing.Point(536, 261)
        Me.MemDateJoin.Name = "MemDateJoin"
        Me.MemDateJoin.Size = New System.Drawing.Size(168, 26)
        Me.MemDateJoin.TabIndex = 3
        '
        'MemRenewal
        '
        Me.MemRenewal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemRenewal.Location = New System.Drawing.Point(535, 230)
        Me.MemRenewal.Name = "MemRenewal"
        Me.MemRenewal.Size = New System.Drawing.Size(168, 26)
        Me.MemRenewal.TabIndex = 3
        '
        'MemStatus
        '
        Me.MemStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemStatus.Location = New System.Drawing.Point(535, 321)
        Me.MemStatus.Name = "MemStatus"
        Me.MemStatus.Size = New System.Drawing.Size(168, 26)
        Me.MemStatus.TabIndex = 3
        '
        'MemEmail
        '
        Me.MemEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemEmail.Location = New System.Drawing.Point(535, 197)
        Me.MemEmail.Name = "MemEmail"
        Me.MemEmail.Size = New System.Drawing.Size(168, 26)
        Me.MemEmail.TabIndex = 3
        '
        'MemMobile
        '
        Me.MemMobile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemMobile.Location = New System.Drawing.Point(157, 321)
        Me.MemMobile.Name = "MemMobile"
        Me.MemMobile.Size = New System.Drawing.Size(168, 26)
        Me.MemMobile.TabIndex = 3
        '
        'MemHome
        '
        Me.MemHome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemHome.Location = New System.Drawing.Point(157, 352)
        Me.MemHome.Name = "MemHome"
        Me.MemHome.Size = New System.Drawing.Size(168, 26)
        Me.MemHome.TabIndex = 3
        '
        'MembersID
        '
        Me.MembersID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MembersID.Location = New System.Drawing.Point(157, 11)
        Me.MembersID.Name = "MembersID"
        Me.MembersID.Size = New System.Drawing.Size(168, 26)
        Me.MembersID.TabIndex = 3
        '
        'Forename
        '
        Me.Forename.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Forename.AutoSize = True
        Me.Forename.BackColor = System.Drawing.Color.Transparent
        Me.Forename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Forename.Location = New System.Drawing.Point(21, 42)
        Me.Forename.Name = "Forename"
        Me.Forename.Size = New System.Drawing.Size(82, 20)
        Me.Forename.TabIndex = 1
        Me.Forename.Text = "Forename"
        '
        'MemberType
        '
        Me.MemberType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemberType.AutoSize = True
        Me.MemberType.BackColor = System.Drawing.Color.Transparent
        Me.MemberType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberType.Location = New System.Drawing.Point(356, 290)
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
        Me.DateJoin.Location = New System.Drawing.Point(355, 259)
        Me.DateJoin.Name = "DateJoin"
        Me.DateJoin.Size = New System.Drawing.Size(95, 20)
        Me.DateJoin.TabIndex = 1
        Me.DateJoin.Text = "Date Joined"
        '
        'Email
        '
        Me.Email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Email.AutoSize = True
        Me.Email.BackColor = System.Drawing.Color.Transparent
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(355, 197)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(111, 20)
        Me.Email.TabIndex = 1
        Me.Email.Text = "Email Address"
        '
        'MemDOB
        '
        Me.MemDOB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemDOB.Location = New System.Drawing.Point(157, 290)
        Me.MemDOB.Name = "MemDOB"
        Me.MemDOB.Size = New System.Drawing.Size(168, 26)
        Me.MemDOB.TabIndex = 3
        '
        'Renewal
        '
        Me.Renewal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Renewal.AutoSize = True
        Me.Renewal.BackColor = System.Drawing.Color.Transparent
        Me.Renewal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Renewal.Location = New System.Drawing.Point(355, 228)
        Me.Renewal.Name = "Renewal"
        Me.Renewal.Size = New System.Drawing.Size(110, 20)
        Me.Renewal.TabIndex = 1
        Me.Renewal.Text = "Renewal Date"
        '
        'Firstname
        '
        Me.Firstname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Firstname.Location = New System.Drawing.Point(157, 42)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(168, 26)
        Me.Firstname.TabIndex = 3
        '
        'Surname
        '
        Me.Surname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Surname.AutoSize = True
        Me.Surname.BackColor = System.Drawing.Color.Transparent
        Me.Surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Surname.Location = New System.Drawing.Point(21, 73)
        Me.Surname.Name = "Surname"
        Me.Surname.Size = New System.Drawing.Size(74, 20)
        Me.Surname.TabIndex = 1
        Me.Surname.Text = "Surname"
        '
        'Lastname
        '
        Me.Lastname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lastname.Location = New System.Drawing.Point(157, 73)
        Me.Lastname.Name = "Lastname"
        Me.Lastname.Size = New System.Drawing.Size(168, 26)
        Me.Lastname.TabIndex = 3
        '
        'Address
        '
        Me.Address.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Address.AutoSize = True
        Me.Address.BackColor = System.Drawing.Color.Transparent
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(21, 104)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(68, 20)
        Me.Address.TabIndex = 1
        Me.Address.Text = "Address"
        '
        'Status
        '
        Me.Status.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Status.AutoSize = True
        Me.Status.BackColor = System.Drawing.Color.Transparent
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Location = New System.Drawing.Point(356, 321)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(56, 20)
        Me.Status.TabIndex = 1
        Me.Status.Text = "Status"
        '
        'Address1
        '
        Me.Address1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Address1.Location = New System.Drawing.Point(157, 104)
        Me.Address1.Name = "Address1"
        Me.Address1.Size = New System.Drawing.Size(168, 26)
        Me.Address1.TabIndex = 3
        '
        'HomePhoneNumber
        '
        Me.HomePhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HomePhoneNumber.AutoSize = True
        Me.HomePhoneNumber.BackColor = System.Drawing.Color.Transparent
        Me.HomePhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomePhoneNumber.Location = New System.Drawing.Point(21, 352)
        Me.HomePhoneNumber.Name = "HomePhoneNumber"
        Me.HomePhoneNumber.Size = New System.Drawing.Size(130, 20)
        Me.HomePhoneNumber.TabIndex = 1
        Me.HomePhoneNumber.Text = "Home Phone No."
        '
        'Address2
        '
        Me.Address2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Address2.Location = New System.Drawing.Point(157, 135)
        Me.Address2.Name = "Address2"
        Me.Address2.Size = New System.Drawing.Size(168, 26)
        Me.Address2.TabIndex = 3
        '
        'MobileNo
        '
        Me.MobileNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MobileNo.AutoSize = True
        Me.MobileNo.BackColor = System.Drawing.Color.Transparent
        Me.MobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileNo.Location = New System.Drawing.Point(21, 321)
        Me.MobileNo.Name = "MobileNo"
        Me.MobileNo.Size = New System.Drawing.Size(83, 20)
        Me.MobileNo.TabIndex = 1
        Me.MobileNo.Text = "Mobile No."
        '
        'MemGender
        '
        Me.MemGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MemGender.Location = New System.Drawing.Point(157, 259)
        Me.MemGender.Name = "MemGender"
        Me.MemGender.Size = New System.Drawing.Size(168, 26)
        Me.MemGender.TabIndex = 3
        '
        'Address3
        '
        Me.Address3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Address3.Location = New System.Drawing.Point(157, 166)
        Me.Address3.Name = "Address3"
        Me.Address3.Size = New System.Drawing.Size(168, 26)
        Me.Address3.TabIndex = 3
        '
        'Address5
        '
        Me.Address5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Address5.Location = New System.Drawing.Point(157, 228)
        Me.Address5.Name = "Address5"
        Me.Address5.Size = New System.Drawing.Size(168, 26)
        Me.Address5.TabIndex = 3
        '
        'Address4
        '
        Me.Address4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Address4.Location = New System.Drawing.Point(157, 197)
        Me.Address4.Name = "Address4"
        Me.Address4.Size = New System.Drawing.Size(168, 26)
        Me.Address4.TabIndex = 3
        '
        'Gender
        '
        Me.Gender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Gender.AutoSize = True
        Me.Gender.BackColor = System.Drawing.Color.Transparent
        Me.Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.Location = New System.Drawing.Point(21, 259)
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
        Me.DOB.Location = New System.Drawing.Point(21, 290)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(52, 20)
        Me.DOB.TabIndex = 1
        Me.DOB.Text = "D.O.B"
        Me.DOB.UseMnemonic = False
        '
        'Medical
        '
        Me.Medical.BackColor = System.Drawing.Color.Transparent
        Me.Medical.Controls.Add(Me.TextBox2)
        Me.Medical.Controls.Add(Me.TextBox1)
        Me.Medical.Controls.Add(Me.Label1)
        Me.Medical.Controls.Add(Me.OtherGMCB)
        Me.Medical.Controls.Add(Me.OperCB)
        Me.Medical.Controls.Add(Me.PregCB)
        Me.Medical.Controls.Add(Me.BackCB)
        Me.Medical.Controls.Add(Me.JointCB)
        Me.Medical.Controls.Add(Me.SmokeCB)
        Me.Medical.Controls.Add(Me.InjuryACB)
        Me.Medical.Controls.Add(Me.BloodPCB)
        Me.Medical.Controls.Add(Me.DiaCB)
        Me.Medical.Controls.Add(Me.OtherGFACB)
        Me.Medical.Controls.Add(Me.EpiCB)
        Me.Medical.Controls.Add(Me.AstCB)
        Me.Medical.Controls.Add(Me.FitterCB)
        Me.Medical.Controls.Add(Me.ChestCB)
        Me.Medical.Controls.Add(Me.CheckBox2)
        Me.Medical.Controls.Add(Me.WeightRCB)
        Me.Medical.Controls.Add(Me.FaintCB)
        Me.Medical.Controls.Add(Me.CheckBox1)
        Me.Medical.Controls.Add(Me.BodyBCB)
        Me.Medical.Controls.Add(Me.HeartCB)
        Me.Medical.Controls.Add(Me.OtherDescGFA)
        Me.Medical.Controls.Add(Me.OtherDescGM)
        Me.Medical.Controls.Add(Me.OtherGM)
        Me.Medical.Controls.Add(Me.Dia)
        Me.Medical.Controls.Add(Me.Oper)
        Me.Medical.Controls.Add(Me.Back)
        Me.Medical.Controls.Add(Me.Ast)
        Me.Medical.Controls.Add(Me.DocNotePres)
        Me.Medical.Controls.Add(Me.InjuryA)
        Me.Medical.Controls.Add(Me.BloodP)
        Me.Medical.Controls.Add(Me.Preg)
        Me.Medical.Controls.Add(Me.DocNoteReq)
        Me.Medical.Controls.Add(Me.Joint)
        Me.Medical.Controls.Add(Me.Fitter)
        Me.Medical.Controls.Add(Me.Chest)
        Me.Medical.Controls.Add(Me.Smoke)
        Me.Medical.Controls.Add(Me.OtherGFA)
        Me.Medical.Controls.Add(Me.InducterName)
        Me.Medical.Controls.Add(Me.Epi)
        Me.Medical.Controls.Add(Me.WeightR)
        Me.Medical.Controls.Add(Me.Faint)
        Me.Medical.Controls.Add(Me.GFA)
        Me.Medical.Controls.Add(Me.Induct)
        Me.Medical.Controls.Add(Me.GM)
        Me.Medical.Controls.Add(Me.BodyB)
        Me.Medical.Controls.Add(Me.Heart)
        Me.Medical.Location = New System.Drawing.Point(4, 29)
        Me.Medical.Name = "Medical"
        Me.Medical.Padding = New System.Windows.Forms.Padding(3)
        Me.Medical.Size = New System.Drawing.Size(710, 409)
        Me.Medical.TabIndex = 1
        Me.Medical.Text = "Medical History"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(565, 68)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(122, 26)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(565, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 26)
        Me.TextBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(476, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "General Fitness Aims"
        '
        'OtherGMCB
        '
        Me.OtherGMCB.AutoSize = True
        Me.OtherGMCB.Location = New System.Drawing.Point(307, 15)
        Me.OtherGMCB.Name = "OtherGMCB"
        Me.OtherGMCB.Size = New System.Drawing.Size(15, 14)
        Me.OtherGMCB.TabIndex = 4
        Me.OtherGMCB.UseVisualStyleBackColor = True
        '
        'OperCB
        '
        Me.OperCB.AutoSize = True
        Me.OperCB.Location = New System.Drawing.Point(168, 381)
        Me.OperCB.Name = "OperCB"
        Me.OperCB.Size = New System.Drawing.Size(15, 14)
        Me.OperCB.TabIndex = 4
        Me.OperCB.UseVisualStyleBackColor = True
        '
        'PregCB
        '
        Me.PregCB.AutoSize = True
        Me.PregCB.Location = New System.Drawing.Point(168, 350)
        Me.PregCB.Name = "PregCB"
        Me.PregCB.Size = New System.Drawing.Size(15, 14)
        Me.PregCB.TabIndex = 4
        Me.PregCB.UseVisualStyleBackColor = True
        '
        'BackCB
        '
        Me.BackCB.AutoSize = True
        Me.BackCB.Location = New System.Drawing.Point(168, 226)
        Me.BackCB.Name = "BackCB"
        Me.BackCB.Size = New System.Drawing.Size(15, 14)
        Me.BackCB.TabIndex = 4
        Me.BackCB.UseVisualStyleBackColor = True
        '
        'JointCB
        '
        Me.JointCB.AutoSize = True
        Me.JointCB.Location = New System.Drawing.Point(168, 195)
        Me.JointCB.Name = "JointCB"
        Me.JointCB.Size = New System.Drawing.Size(15, 14)
        Me.JointCB.TabIndex = 4
        Me.JointCB.UseVisualStyleBackColor = True
        '
        'SmokeCB
        '
        Me.SmokeCB.AutoSize = True
        Me.SmokeCB.Location = New System.Drawing.Point(168, 319)
        Me.SmokeCB.Name = "SmokeCB"
        Me.SmokeCB.Size = New System.Drawing.Size(15, 14)
        Me.SmokeCB.TabIndex = 4
        Me.SmokeCB.UseVisualStyleBackColor = True
        '
        'InjuryACB
        '
        Me.InjuryACB.AutoSize = True
        Me.InjuryACB.Location = New System.Drawing.Point(390, 236)
        Me.InjuryACB.Name = "InjuryACB"
        Me.InjuryACB.Size = New System.Drawing.Size(15, 14)
        Me.InjuryACB.TabIndex = 4
        Me.InjuryACB.UseVisualStyleBackColor = True
        '
        'BloodPCB
        '
        Me.BloodPCB.AutoSize = True
        Me.BloodPCB.Location = New System.Drawing.Point(168, 133)
        Me.BloodPCB.Name = "BloodPCB"
        Me.BloodPCB.Size = New System.Drawing.Size(15, 14)
        Me.BloodPCB.TabIndex = 4
        Me.BloodPCB.UseVisualStyleBackColor = True
        '
        'DiaCB
        '
        Me.DiaCB.AutoSize = True
        Me.DiaCB.Location = New System.Drawing.Point(168, 257)
        Me.DiaCB.Name = "DiaCB"
        Me.DiaCB.Size = New System.Drawing.Size(15, 14)
        Me.DiaCB.TabIndex = 4
        Me.DiaCB.UseVisualStyleBackColor = True
        '
        'OtherGFACB
        '
        Me.OtherGFACB.AutoSize = True
        Me.OtherGFACB.Location = New System.Drawing.Point(390, 267)
        Me.OtherGFACB.Name = "OtherGFACB"
        Me.OtherGFACB.Size = New System.Drawing.Size(15, 14)
        Me.OtherGFACB.TabIndex = 4
        Me.OtherGFACB.UseVisualStyleBackColor = True
        '
        'EpiCB
        '
        Me.EpiCB.AutoSize = True
        Me.EpiCB.Location = New System.Drawing.Point(168, 164)
        Me.EpiCB.Name = "EpiCB"
        Me.EpiCB.Size = New System.Drawing.Size(15, 14)
        Me.EpiCB.TabIndex = 4
        Me.EpiCB.UseVisualStyleBackColor = True
        '
        'AstCB
        '
        Me.AstCB.AutoSize = True
        Me.AstCB.Location = New System.Drawing.Point(168, 288)
        Me.AstCB.Name = "AstCB"
        Me.AstCB.Size = New System.Drawing.Size(15, 14)
        Me.AstCB.TabIndex = 4
        Me.AstCB.UseVisualStyleBackColor = True
        '
        'FitterCB
        '
        Me.FitterCB.AutoSize = True
        Me.FitterCB.Location = New System.Drawing.Point(390, 205)
        Me.FitterCB.Name = "FitterCB"
        Me.FitterCB.Size = New System.Drawing.Size(15, 14)
        Me.FitterCB.TabIndex = 4
        Me.FitterCB.UseVisualStyleBackColor = True
        '
        'ChestCB
        '
        Me.ChestCB.AutoSize = True
        Me.ChestCB.Location = New System.Drawing.Point(168, 102)
        Me.ChestCB.Name = "ChestCB"
        Me.ChestCB.Size = New System.Drawing.Size(15, 14)
        Me.ChestCB.TabIndex = 4
        Me.ChestCB.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(673, 137)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'WeightRCB
        '
        Me.WeightRCB.AutoSize = True
        Me.WeightRCB.Location = New System.Drawing.Point(390, 174)
        Me.WeightRCB.Name = "WeightRCB"
        Me.WeightRCB.Size = New System.Drawing.Size(15, 14)
        Me.WeightRCB.TabIndex = 4
        Me.WeightRCB.UseVisualStyleBackColor = True
        '
        'FaintCB
        '
        Me.FaintCB.AutoSize = True
        Me.FaintCB.Location = New System.Drawing.Point(168, 71)
        Me.FaintCB.Name = "FaintCB"
        Me.FaintCB.Size = New System.Drawing.Size(15, 14)
        Me.FaintCB.TabIndex = 4
        Me.FaintCB.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(673, 106)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'BodyBCB
        '
        Me.BodyBCB.AutoSize = True
        Me.BodyBCB.Location = New System.Drawing.Point(390, 143)
        Me.BodyBCB.Name = "BodyBCB"
        Me.BodyBCB.Size = New System.Drawing.Size(15, 14)
        Me.BodyBCB.TabIndex = 4
        Me.BodyBCB.UseVisualStyleBackColor = True
        '
        'HeartCB
        '
        Me.HeartCB.AutoSize = True
        Me.HeartCB.Location = New System.Drawing.Point(168, 40)
        Me.HeartCB.Name = "HeartCB"
        Me.HeartCB.Size = New System.Drawing.Size(15, 14)
        Me.HeartCB.TabIndex = 4
        Me.HeartCB.UseVisualStyleBackColor = True
        '
        'OtherDescGFA
        '
        Me.OtherDescGFA.Location = New System.Drawing.Point(247, 293)
        Me.OtherDescGFA.Multiline = True
        Me.OtherDescGFA.Name = "OtherDescGFA"
        Me.OtherDescGFA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OtherDescGFA.Size = New System.Drawing.Size(195, 56)
        Me.OtherDescGFA.TabIndex = 3
        '
        'OtherDescGM
        '
        Me.OtherDescGM.Location = New System.Drawing.Point(247, 41)
        Me.OtherDescGM.Multiline = True
        Me.OtherDescGM.Name = "OtherDescGM"
        Me.OtherDescGM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OtherDescGM.Size = New System.Drawing.Size(195, 56)
        Me.OtherDescGM.TabIndex = 3
        '
        'OtherGM
        '
        Me.OtherGM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OtherGM.AutoSize = True
        Me.OtherGM.BackColor = System.Drawing.Color.Transparent
        Me.OtherGM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherGM.Location = New System.Drawing.Point(243, 11)
        Me.OtherGM.Name = "OtherGM"
        Me.OtherGM.Size = New System.Drawing.Size(49, 20)
        Me.OtherGM.TabIndex = 2
        Me.OtherGM.Text = "Other"
        '
        'Dia
        '
        Me.Dia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Dia.AutoSize = True
        Me.Dia.BackColor = System.Drawing.Color.Transparent
        Me.Dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dia.Location = New System.Drawing.Point(21, 253)
        Me.Dia.Name = "Dia"
        Me.Dia.Size = New System.Drawing.Size(73, 20)
        Me.Dia.TabIndex = 2
        Me.Dia.Text = "Diabetes"
        '
        'Oper
        '
        Me.Oper.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Oper.AutoSize = True
        Me.Oper.BackColor = System.Drawing.Color.Transparent
        Me.Oper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Oper.Location = New System.Drawing.Point(21, 377)
        Me.Oper.Name = "Oper"
        Me.Oper.Size = New System.Drawing.Size(135, 20)
        Me.Oper.TabIndex = 2
        Me.Oper.Text = "Recent Operation"
        '
        'Back
        '
        Me.Back.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Back.AutoSize = True
        Me.Back.BackColor = System.Drawing.Color.Transparent
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(21, 222)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(115, 20)
        Me.Back.TabIndex = 2
        Me.Back.Text = "Back Problems"
        '
        'Ast
        '
        Me.Ast.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Ast.AutoSize = True
        Me.Ast.BackColor = System.Drawing.Color.Transparent
        Me.Ast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ast.Location = New System.Drawing.Point(21, 284)
        Me.Ast.Name = "Ast"
        Me.Ast.Size = New System.Drawing.Size(64, 20)
        Me.Ast.TabIndex = 2
        Me.Ast.Text = "Asthma"
        '
        'DocNotePres
        '
        Me.DocNotePres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DocNotePres.AutoSize = True
        Me.DocNotePres.BackColor = System.Drawing.Color.Transparent
        Me.DocNotePres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocNotePres.Location = New System.Drawing.Point(476, 133)
        Me.DocNotePres.Name = "DocNotePres"
        Me.DocNotePres.Size = New System.Drawing.Size(180, 20)
        Me.DocNotePres.TabIndex = 2
        Me.DocNotePres.Text = "Doctors Note Presented"
        '
        'InjuryA
        '
        Me.InjuryA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.InjuryA.AutoSize = True
        Me.InjuryA.BackColor = System.Drawing.Color.Transparent
        Me.InjuryA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InjuryA.Location = New System.Drawing.Point(243, 232)
        Me.InjuryA.Name = "InjuryA"
        Me.InjuryA.Size = New System.Drawing.Size(125, 20)
        Me.InjuryA.TabIndex = 2
        Me.InjuryA.Text = "Injury Avoidance"
        '
        'BloodP
        '
        Me.BloodP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BloodP.AutoSize = True
        Me.BloodP.BackColor = System.Drawing.Color.Transparent
        Me.BloodP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodP.Location = New System.Drawing.Point(21, 129)
        Me.BloodP.Name = "BloodP"
        Me.BloodP.Size = New System.Drawing.Size(100, 20)
        Me.BloodP.TabIndex = 2
        Me.BloodP.Text = "High/Low BP"
        '
        'Preg
        '
        Me.Preg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Preg.AutoSize = True
        Me.Preg.BackColor = System.Drawing.Color.Transparent
        Me.Preg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Preg.Location = New System.Drawing.Point(21, 346)
        Me.Preg.Name = "Preg"
        Me.Preg.Size = New System.Drawing.Size(75, 20)
        Me.Preg.TabIndex = 2
        Me.Preg.Text = "Pregnacy"
        '
        'DocNoteReq
        '
        Me.DocNoteReq.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DocNoteReq.AutoSize = True
        Me.DocNoteReq.BackColor = System.Drawing.Color.Transparent
        Me.DocNoteReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocNoteReq.Location = New System.Drawing.Point(476, 102)
        Me.DocNoteReq.Name = "DocNoteReq"
        Me.DocNoteReq.Size = New System.Drawing.Size(172, 20)
        Me.DocNoteReq.TabIndex = 2
        Me.DocNoteReq.Text = "Doctors Note Required"
        '
        'Joint
        '
        Me.Joint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Joint.AutoSize = True
        Me.Joint.BackColor = System.Drawing.Color.Transparent
        Me.Joint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Joint.Location = New System.Drawing.Point(21, 191)
        Me.Joint.Name = "Joint"
        Me.Joint.Size = New System.Drawing.Size(113, 20)
        Me.Joint.TabIndex = 2
        Me.Joint.Text = "Joint Problems"
        '
        'Fitter
        '
        Me.Fitter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Fitter.AutoSize = True
        Me.Fitter.BackColor = System.Drawing.Color.Transparent
        Me.Fitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fitter.Location = New System.Drawing.Point(243, 201)
        Me.Fitter.Name = "Fitter"
        Me.Fitter.Size = New System.Drawing.Size(77, 20)
        Me.Fitter.TabIndex = 2
        Me.Fitter.Text = "Get Fitter"
        '
        'Chest
        '
        Me.Chest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Chest.AutoSize = True
        Me.Chest.BackColor = System.Drawing.Color.Transparent
        Me.Chest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chest.Location = New System.Drawing.Point(21, 98)
        Me.Chest.Name = "Chest"
        Me.Chest.Size = New System.Drawing.Size(121, 20)
        Me.Chest.TabIndex = 2
        Me.Chest.Text = "Chest Problems"
        '
        'Smoke
        '
        Me.Smoke.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Smoke.AutoSize = True
        Me.Smoke.BackColor = System.Drawing.Color.Transparent
        Me.Smoke.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Smoke.Location = New System.Drawing.Point(21, 315)
        Me.Smoke.Name = "Smoke"
        Me.Smoke.Size = New System.Drawing.Size(64, 20)
        Me.Smoke.TabIndex = 2
        Me.Smoke.Text = "Smoker"
        '
        'OtherGFA
        '
        Me.OtherGFA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OtherGFA.AutoSize = True
        Me.OtherGFA.BackColor = System.Drawing.Color.Transparent
        Me.OtherGFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherGFA.Location = New System.Drawing.Point(243, 263)
        Me.OtherGFA.Name = "OtherGFA"
        Me.OtherGFA.Size = New System.Drawing.Size(49, 20)
        Me.OtherGFA.TabIndex = 2
        Me.OtherGFA.Text = "Other"
        '
        'InducterName
        '
        Me.InducterName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.InducterName.AutoSize = True
        Me.InducterName.BackColor = System.Drawing.Color.Transparent
        Me.InducterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InducterName.Location = New System.Drawing.Point(476, 71)
        Me.InducterName.Name = "InducterName"
        Me.InducterName.Size = New System.Drawing.Size(68, 20)
        Me.InducterName.TabIndex = 2
        Me.InducterName.Text = "Inducter"
        '
        'Epi
        '
        Me.Epi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Epi.AutoSize = True
        Me.Epi.BackColor = System.Drawing.Color.Transparent
        Me.Epi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Epi.Location = New System.Drawing.Point(21, 160)
        Me.Epi.Name = "Epi"
        Me.Epi.Size = New System.Drawing.Size(68, 20)
        Me.Epi.TabIndex = 2
        Me.Epi.Text = "Epilepsy"
        '
        'WeightR
        '
        Me.WeightR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.WeightR.AutoSize = True
        Me.WeightR.BackColor = System.Drawing.Color.Transparent
        Me.WeightR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightR.Location = New System.Drawing.Point(243, 170)
        Me.WeightR.Name = "WeightR"
        Me.WeightR.Size = New System.Drawing.Size(136, 20)
        Me.WeightR.TabIndex = 2
        Me.WeightR.Text = "Weight Reduction"
        '
        'Faint
        '
        Me.Faint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Faint.AutoSize = True
        Me.Faint.BackColor = System.Drawing.Color.Transparent
        Me.Faint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Faint.Location = New System.Drawing.Point(21, 67)
        Me.Faint.Name = "Faint"
        Me.Faint.Size = New System.Drawing.Size(66, 20)
        Me.Faint.TabIndex = 2
        Me.Faint.Text = "Fainting"
        '
        'GFA
        '
        Me.GFA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GFA.AutoSize = True
        Me.GFA.BackColor = System.Drawing.Color.Transparent
        Me.GFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GFA.Location = New System.Drawing.Point(243, 108)
        Me.GFA.Name = "GFA"
        Me.GFA.Size = New System.Drawing.Size(181, 20)
        Me.GFA.TabIndex = 2
        Me.GFA.Text = "General Fitness Aims"
        '
        'Induct
        '
        Me.Induct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Induct.AutoSize = True
        Me.Induct.BackColor = System.Drawing.Color.Transparent
        Me.Induct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Induct.Location = New System.Drawing.Point(476, 40)
        Me.Induct.Name = "Induct"
        Me.Induct.Size = New System.Drawing.Size(75, 20)
        Me.Induct.TabIndex = 2
        Me.Induct.Text = "Induction"
        '
        'GM
        '
        Me.GM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GM.AutoSize = True
        Me.GM.BackColor = System.Drawing.Color.Transparent
        Me.GM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GM.Location = New System.Drawing.Point(21, 6)
        Me.GM.Name = "GM"
        Me.GM.Size = New System.Drawing.Size(139, 20)
        Me.GM.TabIndex = 2
        Me.GM.Text = "General Medical"
        '
        'BodyB
        '
        Me.BodyB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BodyB.AutoSize = True
        Me.BodyB.BackColor = System.Drawing.Color.Transparent
        Me.BodyB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BodyB.Location = New System.Drawing.Point(243, 139)
        Me.BodyB.Name = "BodyB"
        Me.BodyB.Size = New System.Drawing.Size(105, 20)
        Me.BodyB.TabIndex = 2
        Me.BodyB.Text = "Body Building"
        '
        'Heart
        '
        Me.Heart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Heart.AutoSize = True
        Me.Heart.BackColor = System.Drawing.Color.Transparent
        Me.Heart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Heart.Location = New System.Drawing.Point(21, 36)
        Me.Heart.Name = "Heart"
        Me.Heart.Size = New System.Drawing.Size(119, 20)
        Me.Heart.TabIndex = 2
        Me.Heart.Text = "Heart Problems"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(710, 409)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "TabPage1"
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 567)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Logo)
        Me.DoubleBuffered = True
        Me.Name = "CustomerForm"
        Me.Text = "Customer Form Menu"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KingswayFitnessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KingswayFitnessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Personal.ResumeLayout(False)
        Me.Personal.PerformLayout()
        CType(Me.MemPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Medical.ResumeLayout(False)
        Me.Medical.PerformLayout()
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Personal As TabPage
    Friend WithEvents MemberID As Label
    Friend WithEvents MemPhoto As PictureBox
    Friend WithEvents MemType As TextBox
    Friend WithEvents MemDateJoin As TextBox
    Friend WithEvents MemRenewal As TextBox
    Friend WithEvents MemStatus As TextBox
    Friend WithEvents MemEmail As TextBox
    Friend WithEvents MemMobile As TextBox
    Friend WithEvents MemHome As TextBox
    Friend WithEvents MembersID As TextBox
    Friend WithEvents Forename As Label
    Friend WithEvents MemberType As Label
    Friend WithEvents DateJoin As Label
    Friend WithEvents Email As Label
    Friend WithEvents MemDOB As TextBox
    Friend WithEvents Renewal As Label
    Friend WithEvents Firstname As TextBox
    Friend WithEvents Surname As Label
    Friend WithEvents Lastname As TextBox
    Friend WithEvents Address As Label
    Friend WithEvents Status As Label
    Friend WithEvents Address1 As TextBox
    Friend WithEvents HomePhoneNumber As Label
    Friend WithEvents Address2 As TextBox
    Friend WithEvents MobileNo As Label
    Friend WithEvents MemGender As TextBox
    Friend WithEvents Address3 As TextBox
    Friend WithEvents Address5 As TextBox
    Friend WithEvents Address4 As TextBox
    Friend WithEvents Gender As Label
    Friend WithEvents DOB As Label
    Friend WithEvents Medical As TabPage
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OtherGMCB As CheckBox
    Friend WithEvents OperCB As CheckBox
    Friend WithEvents PregCB As CheckBox
    Friend WithEvents BackCB As CheckBox
    Friend WithEvents JointCB As CheckBox
    Friend WithEvents SmokeCB As CheckBox
    Friend WithEvents InjuryACB As CheckBox
    Friend WithEvents BloodPCB As CheckBox
    Friend WithEvents DiaCB As CheckBox
    Friend WithEvents OtherGFACB As CheckBox
    Friend WithEvents EpiCB As CheckBox
    Friend WithEvents AstCB As CheckBox
    Friend WithEvents FitterCB As CheckBox
    Friend WithEvents ChestCB As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents WeightRCB As CheckBox
    Friend WithEvents FaintCB As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BodyBCB As CheckBox
    Friend WithEvents HeartCB As CheckBox
    Friend WithEvents OtherDescGFA As TextBox
    Friend WithEvents OtherDescGM As TextBox
    Friend WithEvents OtherGM As Label
    Friend WithEvents Dia As Label
    Friend WithEvents Oper As Label
    Friend WithEvents Back As Label
    Friend WithEvents Ast As Label
    Friend WithEvents DocNotePres As Label
    Friend WithEvents InjuryA As Label
    Friend WithEvents BloodP As Label
    Friend WithEvents Preg As Label
    Friend WithEvents DocNoteReq As Label
    Friend WithEvents Joint As Label
    Friend WithEvents Fitter As Label
    Friend WithEvents Chest As Label
    Friend WithEvents Smoke As Label
    Friend WithEvents OtherGFA As Label
    Friend WithEvents InducterName As Label
    Friend WithEvents Epi As Label
    Friend WithEvents WeightR As Label
    Friend WithEvents Faint As Label
    Friend WithEvents GFA As Label
    Friend WithEvents Induct As Label
    Friend WithEvents GM As Label
    Friend WithEvents BodyB As Label
    Friend WithEvents Heart As Label
    Friend WithEvents TabPage1 As TabPage
End Class
