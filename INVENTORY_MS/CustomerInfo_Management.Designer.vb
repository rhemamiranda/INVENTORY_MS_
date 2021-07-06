<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerInfo_Management
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerInfo_Management))
        Me.pnl_customerinfo = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_customercnt = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_maxordercnt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_orderscnt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.txtbx_customerid = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txtbx_search = New System.Windows.Forms.TextBox()
        Me.txtbx_name = New System.Windows.Forms.TextBox()
        Me.txtbx_phonenum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_srt = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.dgv_customerinfo = New System.Windows.Forms.DataGridView()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.pnl_nav = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.pnl_customerinfo.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_customerinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_nav.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_customerinfo
        '
        Me.pnl_customerinfo.BackColor = System.Drawing.Color.White
        Me.pnl_customerinfo.Controls.Add(Me.lbl_username)
        Me.pnl_customerinfo.Controls.Add(Me.Panel3)
        Me.pnl_customerinfo.Controls.Add(Me.Panel1)
        Me.pnl_customerinfo.Controls.Add(Me.Panel2)
        Me.pnl_customerinfo.Controls.Add(Me.btn_cancel)
        Me.pnl_customerinfo.Controls.Add(Me.txtbx_customerid)
        Me.pnl_customerinfo.Controls.Add(Me.btn_search)
        Me.pnl_customerinfo.Controls.Add(Me.txtbx_search)
        Me.pnl_customerinfo.Controls.Add(Me.txtbx_name)
        Me.pnl_customerinfo.Controls.Add(Me.txtbx_phonenum)
        Me.pnl_customerinfo.Controls.Add(Me.Label6)
        Me.pnl_customerinfo.Controls.Add(Me.Label5)
        Me.pnl_customerinfo.Controls.Add(Me.Label4)
        Me.pnl_customerinfo.Controls.Add(Me.btn_srt)
        Me.pnl_customerinfo.Controls.Add(Me.btn_clear)
        Me.pnl_customerinfo.Controls.Add(Me.btn_edit)
        Me.pnl_customerinfo.Controls.Add(Me.dgv_customerinfo)
        Me.pnl_customerinfo.Controls.Add(Me.btn_add)
        Me.pnl_customerinfo.Controls.Add(Me.pnl_nav)
        Me.pnl_customerinfo.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.pnl_customerinfo.Location = New System.Drawing.Point(0, 0)
        Me.pnl_customerinfo.Margin = New System.Windows.Forms.Padding(4)
        Me.pnl_customerinfo.Name = "pnl_customerinfo"
        Me.pnl_customerinfo.Size = New System.Drawing.Size(1408, 786)
        Me.pnl_customerinfo.TabIndex = 29
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lbl_customercnt)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(909, 620)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(390, 97)
        Me.Panel3.TabIndex = 21
        '
        'lbl_customercnt
        '
        Me.lbl_customercnt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customercnt.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_customercnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbl_customercnt.Location = New System.Drawing.Point(-1, 39)
        Me.lbl_customercnt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_customercnt.Name = "lbl_customercnt"
        Me.lbl_customercnt.Size = New System.Drawing.Size(391, 55)
        Me.lbl_customercnt.TabIndex = 27
        Me.lbl_customercnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(392, 39)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "CUSTOMER COUNT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_maxordercnt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(499, 620)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(390, 97)
        Me.Panel1.TabIndex = 20
        '
        'lbl_maxordercnt
        '
        Me.lbl_maxordercnt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_maxordercnt.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_maxordercnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbl_maxordercnt.Location = New System.Drawing.Point(-1, 39)
        Me.lbl_maxordercnt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_maxordercnt.Name = "lbl_maxordercnt"
        Me.lbl_maxordercnt.Size = New System.Drawing.Size(392, 55)
        Me.lbl_maxordercnt.TabIndex = 26
        Me.lbl_maxordercnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(391, 39)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "MAXIMUM ORDER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lbl_orderscnt)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(89, 620)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(390, 97)
        Me.Panel2.TabIndex = 19
        '
        'lbl_orderscnt
        '
        Me.lbl_orderscnt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderscnt.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_orderscnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbl_orderscnt.Location = New System.Drawing.Point(-1, 39)
        Me.lbl_orderscnt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_orderscnt.Name = "lbl_orderscnt"
        Me.lbl_orderscnt.Size = New System.Drawing.Size(391, 55)
        Me.lbl_orderscnt.TabIndex = 25
        Me.lbl_orderscnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 39)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "ORDERS COUNT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_cancel.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_cancel_15
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.Location = New System.Drawing.Point(1073, 149)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(109, 36)
        Me.btn_cancel.TabIndex = 8
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'txtbx_customerid
        '
        Me.txtbx_customerid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_customerid.Enabled = False
        Me.txtbx_customerid.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_customerid.Location = New System.Drawing.Point(245, 106)
        Me.txtbx_customerid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbx_customerid.Name = "txtbx_customerid"
        Me.txtbx_customerid.Size = New System.Drawing.Size(170, 34)
        Me.txtbx_customerid.TabIndex = 2
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.LightSlateGray
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_search_15
        Me.btn_search.Location = New System.Drawing.Point(1172, 196)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(124, 36)
        Me.btn_search.TabIndex = 11
        Me.btn_search.Text = "SEARCH"
        Me.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'txtbx_search
        '
        Me.txtbx_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_search.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_search.Location = New System.Drawing.Point(859, 196)
        Me.txtbx_search.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbx_search.Name = "txtbx_search"
        Me.txtbx_search.Size = New System.Drawing.Size(303, 34)
        Me.txtbx_search.TabIndex = 10
        '
        'txtbx_name
        '
        Me.txtbx_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_name.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_name.Location = New System.Drawing.Point(503, 106)
        Me.txtbx_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbx_name.Name = "txtbx_name"
        Me.txtbx_name.Size = New System.Drawing.Size(371, 34)
        Me.txtbx_name.TabIndex = 4
        '
        'txtbx_phonenum
        '
        Me.txtbx_phonenum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_phonenum.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_phonenum.Location = New System.Drawing.Point(1071, 106)
        Me.txtbx_phonenum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbx_phonenum.Name = "txtbx_phonenum"
        Me.txtbx_phonenum.Size = New System.Drawing.Size(230, 34)
        Me.txtbx_phonenum.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(883, 106)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(280, 36)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "PHONE NUMBER:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(84, 103)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 36)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "CUSTOMER ID:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(424, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 36)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NAME:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_srt
        '
        Me.btn_srt.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_srt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_srt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_srt.ForeColor = System.Drawing.Color.White
        Me.btn_srt.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_sort_15
        Me.btn_srt.Location = New System.Drawing.Point(88, 196)
        Me.btn_srt.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_srt.Name = "btn_srt"
        Me.btn_srt.Size = New System.Drawing.Size(109, 36)
        Me.btn_srt.TabIndex = 12
        Me.btn_srt.Text = "A - Z"
        Me.btn_srt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_srt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_srt.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_clear.ForeColor = System.Drawing.Color.White
        Me.btn_clear.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_erase_15
        Me.btn_clear.Location = New System.Drawing.Point(1192, 149)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(109, 36)
        Me.btn_clear.TabIndex = 9
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_edit_15__1_
        Me.btn_edit.Location = New System.Drawing.Point(1073, 149)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(109, 36)
        Me.btn_edit.TabIndex = 17
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'dgv_customerinfo
        '
        Me.dgv_customerinfo.AllowUserToAddRows = False
        Me.dgv_customerinfo.AllowUserToDeleteRows = False
        Me.dgv_customerinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_customerinfo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_customerinfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_customerinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_customerinfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_customerinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_customerinfo.GridColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.dgv_customerinfo.Location = New System.Drawing.Point(89, 241)
        Me.dgv_customerinfo.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_customerinfo.Name = "dgv_customerinfo"
        Me.dgv_customerinfo.RowHeadersWidth = 62
        Me.dgv_customerinfo.RowTemplate.Height = 25
        Me.dgv_customerinfo.Size = New System.Drawing.Size(1211, 366)
        Me.dgv_customerinfo.TabIndex = 13
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_plus_15
        Me.btn_add.Location = New System.Drawing.Point(956, 149)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(109, 36)
        Me.btn_add.TabIndex = 7
        Me.btn_add.Text = "ADD"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'pnl_nav
        '
        Me.pnl_nav.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnl_nav.Controls.Add(Me.Label7)
        Me.pnl_nav.Controls.Add(Me.btn_back)
        Me.pnl_nav.Controls.Add(Me.PictureBox2)
        Me.pnl_nav.Controls.Add(Me.PictureBox3)
        Me.pnl_nav.Location = New System.Drawing.Point(89, 30)
        Me.pnl_nav.Margin = New System.Windows.Forms.Padding(4)
        Me.pnl_nav.Name = "pnl_nav"
        Me.pnl_nav.Size = New System.Drawing.Size(1212, 48)
        Me.pnl_nav.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(71, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(768, 48)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "CUSTOMER INFORMATION MANAGEMENT"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(1068, 6)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(109, 36)
        Me.btn_back.TabIndex = 28
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_manager_50
        Me.PictureBox2.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
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
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(53, 118)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'lbl_username
        '
        Me.lbl_username.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_username.ForeColor = System.Drawing.Color.White
        Me.lbl_username.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_username.Location = New System.Drawing.Point(118, 148)
        Me.lbl_username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(716, 30)
        Me.lbl_username.TabIndex = 25
        Me.lbl_username.Text = "Username123456"
        Me.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CustomerInfo_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1365, 754)
        Me.Controls.Add(Me.pnl_customerinfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "CustomerInfo_Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Information Management"
        Me.pnl_customerinfo.ResumeLayout(False)
        Me.pnl_customerinfo.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_customerinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_nav.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_customerinfo As Panel
    Friend WithEvents txtbx_name As TextBox
    Friend WithEvents txtbx_phonenum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbx_customerid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_srt As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents dgv_customerinfo As DataGridView
    Friend WithEvents btn_add As Button
    Friend WithEvents pnl_nav As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtbx_search As TextBox
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_customercnt As Label
    Friend WithEvents lbl_maxordercnt As Label
    Friend WithEvents lbl_orderscnt As Label
    Friend WithEvents lbl_username As Label
End Class
