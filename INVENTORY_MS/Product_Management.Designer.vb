<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product_Management
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product_Management))
        Me.pnl_productmanagement = New System.Windows.Forms.Panel()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txtbx_search = New System.Windows.Forms.TextBox()
        Me.cmbbx_category = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbx_description = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbx_price = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbx_prodname = New System.Windows.Forms.TextBox()
        Me.txtbx_quantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbx_productid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_srt = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.dgv_product = New System.Windows.Forms.DataGridView()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.pnl_nav = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_productmanagement.SuspendLayout()
        CType(Me.dgv_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_nav.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_productmanagement
        '
        Me.pnl_productmanagement.BackColor = System.Drawing.Color.White
        Me.pnl_productmanagement.Controls.Add(Me.lbl_username)
        Me.pnl_productmanagement.Controls.Add(Me.btn_cancel)
        Me.pnl_productmanagement.Controls.Add(Me.btn_search)
        Me.pnl_productmanagement.Controls.Add(Me.txtbx_search)
        Me.pnl_productmanagement.Controls.Add(Me.cmbbx_category)
        Me.pnl_productmanagement.Controls.Add(Me.Label6)
        Me.pnl_productmanagement.Controls.Add(Me.txtbx_description)
        Me.pnl_productmanagement.Controls.Add(Me.Label5)
        Me.pnl_productmanagement.Controls.Add(Me.txtbx_price)
        Me.pnl_productmanagement.Controls.Add(Me.Label4)
        Me.pnl_productmanagement.Controls.Add(Me.txtbx_prodname)
        Me.pnl_productmanagement.Controls.Add(Me.txtbx_quantity)
        Me.pnl_productmanagement.Controls.Add(Me.Label3)
        Me.pnl_productmanagement.Controls.Add(Me.Label2)
        Me.pnl_productmanagement.Controls.Add(Me.txtbx_productid)
        Me.pnl_productmanagement.Controls.Add(Me.Label1)
        Me.pnl_productmanagement.Controls.Add(Me.btn_srt)
        Me.pnl_productmanagement.Controls.Add(Me.btn_clear)
        Me.pnl_productmanagement.Controls.Add(Me.btn_edit)
        Me.pnl_productmanagement.Controls.Add(Me.dgv_product)
        Me.pnl_productmanagement.Controls.Add(Me.btn_add)
        Me.pnl_productmanagement.Controls.Add(Me.pnl_nav)
        Me.pnl_productmanagement.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.pnl_productmanagement.Location = New System.Drawing.Point(0, 1)
        Me.pnl_productmanagement.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnl_productmanagement.Name = "pnl_productmanagement"
        Me.pnl_productmanagement.Size = New System.Drawing.Size(1560, 925)
        Me.pnl_productmanagement.TabIndex = 22
        '
        'lbl_username
        '
        Me.lbl_username.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_username.ForeColor = System.Drawing.Color.White
        Me.lbl_username.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_username.Location = New System.Drawing.Point(119, 309)
        Me.lbl_username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(806, 38)
        Me.lbl_username.TabIndex = 25
        Me.lbl_username.Text = "Username123456"
        Me.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_cancel_15
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.Location = New System.Drawing.Point(1205, 289)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(125, 45)
        Me.btn_cancel.TabIndex = 14
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = False
        Me.btn_cancel.Visible = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.LightSlateGray
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_search_15
        Me.btn_search.Location = New System.Drawing.Point(1323, 362)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(140, 45)
        Me.btn_search.TabIndex = 17
        Me.btn_search.Text = "SEARCH"
        Me.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'txtbx_search
        '
        Me.txtbx_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_search.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_search.Location = New System.Drawing.Point(971, 362)
        Me.txtbx_search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbx_search.Name = "txtbx_search"
        Me.txtbx_search.Size = New System.Drawing.Size(343, 39)
        Me.txtbx_search.TabIndex = 16
        '
        'cmbbx_category
        '
        Me.cmbbx_category.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbbx_category.FormattingEnabled = True
        Me.cmbbx_category.Location = New System.Drawing.Point(837, 179)
        Me.cmbbx_category.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbbx_category.MaxLength = 20
        Me.cmbbx_category.Name = "cmbbx_category"
        Me.cmbbx_category.Size = New System.Drawing.Size(624, 39)
        Me.cmbbx_category.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(692, 180)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 39)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "CATEGORY:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbx_description
        '
        Me.txtbx_description.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_description.Location = New System.Drawing.Point(266, 229)
        Me.txtbx_description.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbx_description.MaxLength = 100
        Me.txtbx_description.Name = "txtbx_description"
        Me.txtbx_description.Size = New System.Drawing.Size(1195, 39)
        Me.txtbx_description.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(98, 229)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 45)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "DESCRIPTION:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbx_price
        '
        Me.txtbx_price.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_price.Location = New System.Drawing.Point(537, 178)
        Me.txtbx_price.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbx_price.MaxLength = 38
        Me.txtbx_price.Name = "txtbx_price"
        Me.txtbx_price.Size = New System.Drawing.Size(144, 39)
        Me.txtbx_price.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(431, 178)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 45)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "PRICE:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbx_prodname
        '
        Me.txtbx_prodname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_prodname.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_prodname.Location = New System.Drawing.Point(904, 126)
        Me.txtbx_prodname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbx_prodname.MaxLength = 30
        Me.txtbx_prodname.Name = "txtbx_prodname"
        Me.txtbx_prodname.Size = New System.Drawing.Size(557, 39)
        Me.txtbx_prodname.TabIndex = 4
        '
        'txtbx_quantity
        '
        Me.txtbx_quantity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_quantity.Location = New System.Drawing.Point(266, 178)
        Me.txtbx_quantity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbx_quantity.MaxLength = 38
        Me.txtbx_quantity.Name = "txtbx_quantity"
        Me.txtbx_quantity.Size = New System.Drawing.Size(140, 39)
        Me.txtbx_quantity.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(692, 128)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 42)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PRODUCT NAME:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(99, 179)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 46)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "QUANTITY:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbx_productid
        '
        Me.txtbx_productid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_productid.Enabled = False
        Me.txtbx_productid.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_productid.Location = New System.Drawing.Point(266, 125)
        Me.txtbx_productid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbx_productid.MaxLength = 38
        Me.txtbx_productid.Name = "txtbx_productid"
        Me.txtbx_productid.Size = New System.Drawing.Size(416, 39)
        Me.txtbx_productid.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(94, 125)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRODUCT ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_srt
        '
        Me.btn_srt.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_srt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_srt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_srt.ForeColor = System.Drawing.Color.White
        Me.btn_srt.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_sort_15
        Me.btn_srt.Location = New System.Drawing.Point(100, 362)
        Me.btn_srt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_srt.Name = "btn_srt"
        Me.btn_srt.Size = New System.Drawing.Size(125, 45)
        Me.btn_srt.TabIndex = 18
        Me.btn_srt.Text = "A - Z"
        Me.btn_srt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_srt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_srt.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_clear.ForeColor = System.Drawing.Color.White
        Me.btn_clear.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_erase_15
        Me.btn_clear.Location = New System.Drawing.Point(1338, 289)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(125, 45)
        Me.btn_clear.TabIndex = 15
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
        Me.btn_edit.Location = New System.Drawing.Point(1206, 289)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(125, 45)
        Me.btn_edit.TabIndex = 14
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'dgv_product
        '
        Me.dgv_product.AllowUserToAddRows = False
        Me.dgv_product.AllowUserToDeleteRows = False
        Me.dgv_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_product.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_product.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_product.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_product.GridColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.dgv_product.Location = New System.Drawing.Point(100, 418)
        Me.dgv_product.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_product.Name = "dgv_product"
        Me.dgv_product.ReadOnly = True
        Me.dgv_product.RowHeadersWidth = 62
        Me.dgv_product.RowTemplate.Height = 25
        Me.dgv_product.Size = New System.Drawing.Size(1362, 459)
        Me.dgv_product.TabIndex = 19
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_plus_15
        Me.btn_add.Location = New System.Drawing.Point(1074, 289)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(125, 45)
        Me.btn_add.TabIndex = 13
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
        Me.pnl_nav.Location = New System.Drawing.Point(100, 39)
        Me.pnl_nav.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnl_nav.Name = "pnl_nav"
        Me.pnl_nav.Size = New System.Drawing.Size(1362, 60)
        Me.pnl_nav.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(90, -2)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(594, 65)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "PRODUCT MANAGEMENT"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(1202, 8)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(125, 45)
        Me.btn_back.TabIndex = 21
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_product_management_48
        Me.PictureBox2.Location = New System.Drawing.Point(14, 14)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_vertical_line_96
        Me.PictureBox3.Location = New System.Drawing.Point(40, -39)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 148)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Product Name"
        Me.Column1.MinimumWidth = 9
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Product_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1560, 921)
        Me.Controls.Add(Me.pnl_productmanagement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Product_Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Management"
        Me.pnl_productmanagement.ResumeLayout(False)
        Me.pnl_productmanagement.PerformLayout()
        CType(Me.dgv_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_nav.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_productmanagement As Panel
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents dgv_product As DataGridView
    Friend WithEvents btn_add As Button
    Friend WithEvents pnl_nav As Panel
    Friend WithEvents btn_back As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtbx_productid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_srt As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents txtbx_prodname As TextBox
    Friend WithEvents txtbx_quantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbbx_category As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbx_description As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbx_price As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents txtbx_search As TextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents lbl_username As Label
End Class