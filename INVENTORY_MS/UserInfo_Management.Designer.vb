<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInfo_Management
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserInfo_Management))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnl_nav = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.dgv_userinfo = New System.Windows.Forms.DataGridView()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_srt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbx_userid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbx_phonenum = New System.Windows.Forms.TextBox()
        Me.txtbx_firstname = New System.Windows.Forms.TextBox()
        Me.txtbx_lastname = New System.Windows.Forms.TextBox()
        Me.txtbx_username = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtbx_password = New System.Windows.Forms.TextBox()
        Me.txtbx_search = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.pnl_userinfomanagement = New System.Windows.Forms.Panel()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.pnl_nav.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_userinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_userinfomanagement.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(897, 132)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(340, 25)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "FIRST NAME"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(247, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(340, 30)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "LAST NAME"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_nav
        '
        Me.pnl_nav.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnl_nav.Controls.Add(Me.Label7)
        Me.pnl_nav.Controls.Add(Me.btn_back)
        Me.pnl_nav.Controls.Add(Me.PictureBox2)
        Me.pnl_nav.Controls.Add(Me.PictureBox3)
        Me.pnl_nav.Location = New System.Drawing.Point(85, 32)
        Me.pnl_nav.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnl_nav.Name = "pnl_nav"
        Me.pnl_nav.Size = New System.Drawing.Size(1212, 48)
        Me.pnl_nav.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(80, -4)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(588, 52)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "USER INFORMATION MANAGEMENT"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(1067, 6)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(109, 36)
        Me.btn_back.TabIndex = 20
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_manager_50
        Me.PictureBox2.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_vertical_line_96
        Me.PictureBox3.Location = New System.Drawing.Point(36, -32)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(53, 118)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_plus_15
        Me.btn_add.Location = New System.Drawing.Point(948, 247)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(109, 36)
        Me.btn_add.TabIndex = 12
        Me.btn_add.Text = "ADD"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'dgv_userinfo
        '
        Me.dgv_userinfo.AllowUserToAddRows = False
        Me.dgv_userinfo.AllowUserToDeleteRows = False
        Me.dgv_userinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_userinfo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_userinfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_userinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_userinfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_userinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_userinfo.GridColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.dgv_userinfo.Location = New System.Drawing.Point(84, 342)
        Me.dgv_userinfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_userinfo.Name = "dgv_userinfo"
        Me.dgv_userinfo.RowHeadersWidth = 62
        Me.dgv_userinfo.RowTemplate.Height = 25
        Me.dgv_userinfo.Size = New System.Drawing.Size(1213, 357)
        Me.dgv_userinfo.TabIndex = 18
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_edit_15__1_
        Me.btn_edit.Location = New System.Drawing.Point(1067, 247)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(109, 36)
        Me.btn_edit.TabIndex = 13
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_cancel.Location = New System.Drawing.Point(1065, 247)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(109, 36)
        Me.btn_cancel.TabIndex = 13
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_clear.ForeColor = System.Drawing.Color.White
        Me.btn_clear.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_erase_15
        Me.btn_clear.Location = New System.Drawing.Point(1187, 247)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(109, 36)
        Me.btn_clear.TabIndex = 14
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_srt
        '
        Me.btn_srt.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_srt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_srt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_srt.ForeColor = System.Drawing.Color.White
        Me.btn_srt.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_sort_15
        Me.btn_srt.Location = New System.Drawing.Point(84, 299)
        Me.btn_srt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_srt.Name = "btn_srt"
        Me.btn_srt.Size = New System.Drawing.Size(109, 36)
        Me.btn_srt.TabIndex = 15
        Me.btn_srt.Text = "A - Z"
        Me.btn_srt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_srt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_srt.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(84, 206)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 28)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "USERNAME:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbx_userid
        '
        Me.txtbx_userid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_userid.Enabled = False
        Me.txtbx_userid.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_userid.Location = New System.Drawing.Point(212, 158)
        Me.txtbx_userid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbx_userid.Name = "txtbx_userid"
        Me.txtbx_userid.Size = New System.Drawing.Size(439, 34)
        Me.txtbx_userid.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(84, 100)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 30)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "NAME:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(84, 158)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 30)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "USER ID:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(660, 158)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(311, 38)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "PHONE NUMBER:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbx_phonenum
        '
        Me.txtbx_phonenum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_phonenum.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_phonenum.Location = New System.Drawing.Point(835, 161)
        Me.txtbx_phonenum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbx_phonenum.Name = "txtbx_phonenum"
        Me.txtbx_phonenum.Size = New System.Drawing.Size(439, 34)
        Me.txtbx_phonenum.TabIndex = 7
        '
        'txtbx_firstname
        '
        Me.txtbx_firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_firstname.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_firstname.Location = New System.Drawing.Point(835, 100)
        Me.txtbx_firstname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbx_firstname.Name = "txtbx_firstname"
        Me.txtbx_firstname.Size = New System.Drawing.Size(439, 34)
        Me.txtbx_firstname.TabIndex = 3
        '
        'txtbx_lastname
        '
        Me.txtbx_lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_lastname.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_lastname.Location = New System.Drawing.Point(212, 100)
        Me.txtbx_lastname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbx_lastname.Name = "txtbx_lastname"
        Me.txtbx_lastname.Size = New System.Drawing.Size(439, 34)
        Me.txtbx_lastname.TabIndex = 2
        '
        'txtbx_username
        '
        Me.txtbx_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_username.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_username.Location = New System.Drawing.Point(212, 199)
        Me.txtbx_username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbx_username.Name = "txtbx_username"
        Me.txtbx_username.Size = New System.Drawing.Size(439, 34)
        Me.txtbx_username.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(660, 203)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 30)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "PASSWORD:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbx_password
        '
        Me.txtbx_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_password.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_password.Location = New System.Drawing.Point(833, 203)
        Me.txtbx_password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbx_password.Name = "txtbx_password"
        Me.txtbx_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtbx_password.Size = New System.Drawing.Size(439, 34)
        Me.txtbx_password.TabIndex = 11
        '
        'txtbx_search
        '
        Me.txtbx_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_search.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_search.Location = New System.Drawing.Point(859, 299)
        Me.txtbx_search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbx_search.Name = "txtbx_search"
        Me.txtbx_search.Size = New System.Drawing.Size(303, 34)
        Me.txtbx_search.TabIndex = 16
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.LightSlateGray
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_search_15
        Me.btn_search.Location = New System.Drawing.Point(1172, 299)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(124, 36)
        Me.btn_search.TabIndex = 17
        Me.btn_search.Text = "SEARCH"
        Me.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'pnl_userinfomanagement
        '
        Me.pnl_userinfomanagement.BackColor = System.Drawing.Color.White
        Me.pnl_userinfomanagement.Controls.Add(Me.lbl_username)
        Me.pnl_userinfomanagement.Controls.Add(Me.btn_search)
        Me.pnl_userinfomanagement.Controls.Add(Me.txtbx_search)
        Me.pnl_userinfomanagement.Controls.Add(Me.txtbx_password)
        Me.pnl_userinfomanagement.Controls.Add(Me.Label10)
        Me.pnl_userinfomanagement.Controls.Add(Me.txtbx_username)
        Me.pnl_userinfomanagement.Controls.Add(Me.txtbx_lastname)
        Me.pnl_userinfomanagement.Controls.Add(Me.txtbx_firstname)
        Me.pnl_userinfomanagement.Controls.Add(Me.txtbx_phonenum)
        Me.pnl_userinfomanagement.Controls.Add(Me.Label6)
        Me.pnl_userinfomanagement.Controls.Add(Me.Label5)
        Me.pnl_userinfomanagement.Controls.Add(Me.Label4)
        Me.pnl_userinfomanagement.Controls.Add(Me.txtbx_userid)
        Me.pnl_userinfomanagement.Controls.Add(Me.Label1)
        Me.pnl_userinfomanagement.Controls.Add(Me.btn_srt)
        Me.pnl_userinfomanagement.Controls.Add(Me.btn_clear)
        Me.pnl_userinfomanagement.Controls.Add(Me.btn_cancel)
        Me.pnl_userinfomanagement.Controls.Add(Me.btn_edit)
        Me.pnl_userinfomanagement.Controls.Add(Me.dgv_userinfo)
        Me.pnl_userinfomanagement.Controls.Add(Me.btn_add)
        Me.pnl_userinfomanagement.Controls.Add(Me.pnl_nav)
        Me.pnl_userinfomanagement.Controls.Add(Me.Label2)
        Me.pnl_userinfomanagement.Controls.Add(Me.Label8)
        Me.pnl_userinfomanagement.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.pnl_userinfomanagement.Location = New System.Drawing.Point(0, 0)
        Me.pnl_userinfomanagement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnl_userinfomanagement.Name = "pnl_userinfomanagement"
        Me.pnl_userinfomanagement.Size = New System.Drawing.Size(1443, 796)
        Me.pnl_userinfomanagement.TabIndex = 21
        '
        'lbl_username
        '
        Me.lbl_username.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_username.ForeColor = System.Drawing.Color.White
        Me.lbl_username.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_username.Location = New System.Drawing.Point(90, 253)
        Me.lbl_username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(716, 30)
        Me.lbl_username.TabIndex = 39
        Me.lbl_username.Text = "Username123456"
        Me.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserInfo_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1387, 738)
        Me.Controls.Add(Me.pnl_userinfomanagement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "UserInfo_Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Information Management"
        Me.pnl_nav.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_userinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_userinfomanagement.ResumeLayout(False)
        Me.pnl_userinfomanagement.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnl_nav As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_add As Button
    Friend WithEvents dgv_userinfo As DataGridView
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_srt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbx_userid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbx_phonenum As TextBox
    Friend WithEvents txtbx_firstname As TextBox
    Friend WithEvents txtbx_lastname As TextBox
    Friend WithEvents txtbx_username As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtbx_password As TextBox
    Friend WithEvents txtbx_search As TextBox
    Friend WithEvents btn_search As Button
    Friend WithEvents pnl_userinfomanagement As Panel
    Friend WithEvents lbl_username As Label
End Class
