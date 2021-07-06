<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateNewOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateNewOrder))
        Me.pnl_createneworder = New System.Windows.Forms.Panel()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_amount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.num_quantity = New System.Windows.Forms.NumericUpDown()
        Me.cmbbx_customername = New System.Windows.Forms.ComboBox()
        Me.cmbbx_customerid = New System.Windows.Forms.ComboBox()
        Me.cmbbx_prodname = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_bill = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbbx_prodid = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbx_orderid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_clrorder = New System.Windows.Forms.Button()
        Me.btn_removebill = New System.Windows.Forms.Button()
        Me.btn_confirmorder = New System.Windows.Forms.Button()
        Me.btn_addbill = New System.Windows.Forms.Button()
        Me.pnl_nav = New System.Windows.Forms.Panel()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pnl_createneworder.SuspendLayout()
        CType(Me.num_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_bill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_nav.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_createneworder
        '
        Me.pnl_createneworder.BackColor = System.Drawing.Color.White
        Me.pnl_createneworder.Controls.Add(Me.lbl_username)
        Me.pnl_createneworder.Controls.Add(Me.lbl_amount)
        Me.pnl_createneworder.Controls.Add(Me.Label9)
        Me.pnl_createneworder.Controls.Add(Me.num_quantity)
        Me.pnl_createneworder.Controls.Add(Me.cmbbx_customername)
        Me.pnl_createneworder.Controls.Add(Me.cmbbx_customerid)
        Me.pnl_createneworder.Controls.Add(Me.cmbbx_prodname)
        Me.pnl_createneworder.Controls.Add(Me.Label8)
        Me.pnl_createneworder.Controls.Add(Me.dgv_bill)
        Me.pnl_createneworder.Controls.Add(Me.Label6)
        Me.pnl_createneworder.Controls.Add(Me.Label4)
        Me.pnl_createneworder.Controls.Add(Me.cmbbx_prodid)
        Me.pnl_createneworder.Controls.Add(Me.Label3)
        Me.pnl_createneworder.Controls.Add(Me.Label5)
        Me.pnl_createneworder.Controls.Add(Me.Label2)
        Me.pnl_createneworder.Controls.Add(Me.txtbx_orderid)
        Me.pnl_createneworder.Controls.Add(Me.Label1)
        Me.pnl_createneworder.Controls.Add(Me.btn_clrorder)
        Me.pnl_createneworder.Controls.Add(Me.btn_removebill)
        Me.pnl_createneworder.Controls.Add(Me.btn_confirmorder)
        Me.pnl_createneworder.Controls.Add(Me.btn_addbill)
        Me.pnl_createneworder.Controls.Add(Me.pnl_nav)
        Me.pnl_createneworder.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.pnl_createneworder.Location = New System.Drawing.Point(-4, 0)
        Me.pnl_createneworder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnl_createneworder.Name = "pnl_createneworder"
        Me.pnl_createneworder.Size = New System.Drawing.Size(1567, 925)
        Me.pnl_createneworder.TabIndex = 24
        '
        'lbl_username
        '
        Me.lbl_username.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_username.ForeColor = System.Drawing.Color.White
        Me.lbl_username.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_username.Location = New System.Drawing.Point(136, 251)
        Me.lbl_username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(806, 38)
        Me.lbl_username.TabIndex = 25
        Me.lbl_username.Text = "Username123456"
        Me.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_amount
        '
        Me.lbl_amount.AutoSize = True
        Me.lbl_amount.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_amount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lbl_amount.Location = New System.Drawing.Point(332, 825)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(23, 25)
        Me.lbl_amount.TabIndex = 23
        Me.lbl_amount.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(99, 825)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 25)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "TOTAL AMOUNT:"
        '
        'num_quantity
        '
        Me.num_quantity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.num_quantity.Location = New System.Drawing.Point(1187, 191)
        Me.num_quantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.num_quantity.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.num_quantity.Name = "num_quantity"
        Me.num_quantity.Size = New System.Drawing.Size(278, 29)
        Me.num_quantity.TabIndex = 14
        '
        'cmbbx_customername
        '
        Me.cmbbx_customername.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbbx_customername.FormattingEnabled = True
        Me.cmbbx_customername.Location = New System.Drawing.Point(1110, 138)
        Me.cmbbx_customername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbbx_customername.Name = "cmbbx_customername"
        Me.cmbbx_customername.Size = New System.Drawing.Size(355, 29)
        Me.cmbbx_customername.TabIndex = 8
        '
        'cmbbx_customerid
        '
        Me.cmbbx_customerid.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbbx_customerid.FormattingEnabled = True
        Me.cmbbx_customerid.Location = New System.Drawing.Point(652, 138)
        Me.cmbbx_customerid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbbx_customerid.Name = "cmbbx_customerid"
        Me.cmbbx_customerid.Size = New System.Drawing.Size(217, 29)
        Me.cmbbx_customerid.TabIndex = 6
        '
        'cmbbx_prodname
        '
        Me.cmbbx_prodname.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbbx_prodname.FormattingEnabled = True
        Me.cmbbx_prodname.Location = New System.Drawing.Point(685, 192)
        Me.cmbbx_prodname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbbx_prodname.Name = "cmbbx_prodname"
        Me.cmbbx_prodname.Size = New System.Drawing.Size(342, 29)
        Me.cmbbx_prodname.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(107, 289)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(557, 39)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "BILL"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.UseCompatibleTextRendering = True
        '
        'dgv_bill
        '
        Me.dgv_bill.AllowUserToAddRows = False
        Me.dgv_bill.AllowUserToDeleteRows = False
        Me.dgv_bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_bill.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_bill.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_bill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_bill.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_bill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgv_bill.GridColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.dgv_bill.Location = New System.Drawing.Point(104, 332)
        Me.dgv_bill.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_bill.Name = "dgv_bill"
        Me.dgv_bill.ReadOnly = True
        Me.dgv_bill.RowHeadersWidth = 51
        Me.dgv_bill.RowTemplate.Height = 25
        Me.dgv_bill.Size = New System.Drawing.Size(1364, 475)
        Me.dgv_bill.TabIndex = 19
        Me.dgv_bill.TabStop = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "ITEM NO."
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "PRODUCT"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "QUANTITY"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "PRICE"
        Me.Column4.MinimumWidth = 20
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "TOTAL"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "PRODUCT ID"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(1045, 192)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(285, 39)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "QUANTITY:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(476, 192)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(262, 39)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "PRODUCT NAME:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbbx_prodid
        '
        Me.cmbbx_prodid.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbbx_prodid.FormattingEnabled = True
        Me.cmbbx_prodid.ItemHeight = 21
        Me.cmbbx_prodid.Location = New System.Drawing.Point(262, 191)
        Me.cmbbx_prodid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbbx_prodid.Name = "cmbbx_prodid"
        Me.cmbbx_prodid.Size = New System.Drawing.Size(199, 29)
        Me.cmbbx_prodid.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(100, 192)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 39)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "PRODUCT ID:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(881, 139)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(285, 39)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "CUSTOMER NAME:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(476, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 39)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CUSTOMER ID:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbx_orderid
        '
        Me.txtbx_orderid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_orderid.Enabled = False
        Me.txtbx_orderid.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_orderid.Location = New System.Drawing.Point(235, 138)
        Me.txtbx_orderid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbx_orderid.Name = "txtbx_orderid"
        Me.txtbx_orderid.Size = New System.Drawing.Size(227, 29)
        Me.txtbx_orderid.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(98, 138)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 45)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ORDER ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_clrorder
        '
        Me.btn_clrorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_clrorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clrorder.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_clrorder.ForeColor = System.Drawing.Color.White
        Me.btn_clrorder.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_erase_15
        Me.btn_clrorder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_clrorder.Location = New System.Drawing.Point(1007, 818)
        Me.btn_clrorder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_clrorder.Name = "btn_clrorder"
        Me.btn_clrorder.Size = New System.Drawing.Size(215, 45)
        Me.btn_clrorder.TabIndex = 18
        Me.btn_clrorder.Text = "CLEAR ORDER LIST"
        Me.btn_clrorder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clrorder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_clrorder.UseVisualStyleBackColor = False
        '
        'btn_removebill
        '
        Me.btn_removebill.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btn_removebill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_removebill.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_removebill.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_removebill.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_delete_bin_15
        Me.btn_removebill.Location = New System.Drawing.Point(969, 246)
        Me.btn_removebill.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_removebill.Name = "btn_removebill"
        Me.btn_removebill.Size = New System.Drawing.Size(235, 45)
        Me.btn_removebill.TabIndex = 16
        Me.btn_removebill.Text = "REMOVE TO BILL"
        Me.btn_removebill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_removebill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_removebill.UseVisualStyleBackColor = False
        '
        'btn_confirmorder
        '
        Me.btn_confirmorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btn_confirmorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmorder.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_confirmorder.ForeColor = System.Drawing.Color.White
        Me.btn_confirmorder.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_receipt_approved_15
        Me.btn_confirmorder.Location = New System.Drawing.Point(1228, 818)
        Me.btn_confirmorder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_confirmorder.Name = "btn_confirmorder"
        Me.btn_confirmorder.Size = New System.Drawing.Size(238, 45)
        Me.btn_confirmorder.TabIndex = 17
        Me.btn_confirmorder.Text = "CONFIRM ORDER"
        Me.btn_confirmorder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_confirmorder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_confirmorder.UseVisualStyleBackColor = False
        '
        'btn_addbill
        '
        Me.btn_addbill.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btn_addbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addbill.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_addbill.ForeColor = System.Drawing.Color.White
        Me.btn_addbill.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_plus_15
        Me.btn_addbill.Location = New System.Drawing.Point(1227, 246)
        Me.btn_addbill.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_addbill.Name = "btn_addbill"
        Me.btn_addbill.Size = New System.Drawing.Size(238, 45)
        Me.btn_addbill.TabIndex = 15
        Me.btn_addbill.Text = "ADD TO BILL"
        Me.btn_addbill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_addbill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_addbill.UseVisualStyleBackColor = False
        '
        'pnl_nav
        '
        Me.pnl_nav.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnl_nav.Controls.Add(Me.btn_home)
        Me.pnl_nav.Controls.Add(Me.Label7)
        Me.pnl_nav.Controls.Add(Me.btn_back)
        Me.pnl_nav.Controls.Add(Me.PictureBox2)
        Me.pnl_nav.Controls.Add(Me.PictureBox3)
        Me.pnl_nav.Location = New System.Drawing.Point(104, 35)
        Me.pnl_nav.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnl_nav.Name = "pnl_nav"
        Me.pnl_nav.Size = New System.Drawing.Size(1364, 60)
        Me.pnl_nav.TabIndex = 1
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.White
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_home.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_home.Location = New System.Drawing.Point(1068, 8)
        Me.btn_home.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(125, 45)
        Me.btn_home.TabIndex = 19
        Me.btn_home.Text = "HOME"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(90, -5)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(570, 65)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "CREATE NEW ORDER"
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
        Me.btn_back.TabIndex = 20
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_purchase_order_48
        Me.PictureBox2.Location = New System.Drawing.Point(14, 12)
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
        Me.PictureBox3.Location = New System.Drawing.Point(40, -40)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 148)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'CreateNewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1560, 921)
        Me.Controls.Add(Me.pnl_createneworder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "CreateNewOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New Order"
        Me.pnl_createneworder.ResumeLayout(False)
        Me.pnl_createneworder.PerformLayout()
        CType(Me.num_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_bill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_nav.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_createneworder As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv_bill As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbbx_prodid As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbx_orderid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_clrorder As Button
    Friend WithEvents btn_removebill As Button
    Friend WithEvents btn_confirmorder As Button
    Friend WithEvents btn_addbill As Button
    Friend WithEvents pnl_nav As Panel
    Friend WithEvents btn_home As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents cmbbx_prodname As ComboBox
    Friend WithEvents cmbbx_customername As ComboBox
    Friend WithEvents cmbbx_customerid As ComboBox
    Friend WithEvents num_quantity As NumericUpDown
    Friend WithEvents lbl_amount As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_username As Label
End Class
