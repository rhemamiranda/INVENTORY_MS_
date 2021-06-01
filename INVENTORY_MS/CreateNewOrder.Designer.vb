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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_createneworder = New System.Windows.Forms.Panel()
        Me.txtbx_prodname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView_bill = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtbx_quantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbbx_prodid = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbx_customername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbx_customerid = New System.Windows.Forms.TextBox()
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
        CType(Me.DataGridView_bill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_nav.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_createneworder
        '
        Me.pnl_createneworder.BackColor = System.Drawing.Color.White
        Me.pnl_createneworder.Controls.Add(Me.txtbx_prodname)
        Me.pnl_createneworder.Controls.Add(Me.Label8)
        Me.pnl_createneworder.Controls.Add(Me.DataGridView_bill)
        Me.pnl_createneworder.Controls.Add(Me.txtbx_quantity)
        Me.pnl_createneworder.Controls.Add(Me.Label6)
        Me.pnl_createneworder.Controls.Add(Me.Label4)
        Me.pnl_createneworder.Controls.Add(Me.cmbbx_prodid)
        Me.pnl_createneworder.Controls.Add(Me.Label3)
        Me.pnl_createneworder.Controls.Add(Me.txtbx_customername)
        Me.pnl_createneworder.Controls.Add(Me.Label5)
        Me.pnl_createneworder.Controls.Add(Me.txtbx_customerid)
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
        Me.pnl_createneworder.Name = "pnl_createneworder"
        Me.pnl_createneworder.Size = New System.Drawing.Size(996, 604)
        Me.pnl_createneworder.TabIndex = 5
        '
        'txtbx_prodname
        '
        Me.txtbx_prodname.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtbx_prodname.Location = New System.Drawing.Point(489, 119)
        Me.txtbx_prodname.Name = "txtbx_prodname"
        Me.txtbx_prodname.Size = New System.Drawing.Size(224, 29)
        Me.txtbx_prodname.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(54, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(356, 29)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "BILL"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView_bill
        '
        Me.DataGridView_bill.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView_bill.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView_bill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_bill.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_bill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6})
        Me.DataGridView_bill.GridColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.DataGridView_bill.Location = New System.Drawing.Point(54, 230)
        Me.DataGridView_bill.Name = "DataGridView_bill"
        Me.DataGridView_bill.RowTemplate.Height = 25
        Me.DataGridView_bill.Size = New System.Drawing.Size(887, 304)
        Me.DataGridView_bill.TabIndex = 37
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 49
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "PRODUCT"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "QUANTITY"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "PRICE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 72
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'txtbx_quantity
        '
        Me.txtbx_quantity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtbx_quantity.Location = New System.Drawing.Point(817, 121)
        Me.txtbx_quantity.Name = "txtbx_quantity"
        Me.txtbx_quantity.Size = New System.Drawing.Size(124, 29)
        Me.txtbx_quantity.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(719, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(222, 29)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "QUANTITY:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(337, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 29)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "PRODUCTY NAME:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbbx_prodid
        '
        Me.cmbbx_prodid.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbbx_prodid.FormattingEnabled = True
        Me.cmbbx_prodid.Location = New System.Drawing.Point(175, 120)
        Me.cmbbx_prodid.Name = "cmbbx_prodid"
        Me.cmbbx_prodid.Size = New System.Drawing.Size(156, 28)
        Me.cmbbx_prodid.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(54, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 29)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "PRODUCT ID:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbx_customername
        '
        Me.txtbx_customername.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtbx_customername.Location = New System.Drawing.Point(749, 85)
        Me.txtbx_customername.Name = "txtbx_customername"
        Me.txtbx_customername.Size = New System.Drawing.Size(192, 29)
        Me.txtbx_customername.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(603, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 29)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "CUSTOMER NAME:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbx_customerid
        '
        Me.txtbx_customerid.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtbx_customerid.Location = New System.Drawing.Point(427, 84)
        Me.txtbx_customerid.Name = "txtbx_customerid"
        Me.txtbx_customerid.Size = New System.Drawing.Size(170, 29)
        Me.txtbx_customerid.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(297, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 29)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "CUSTOMER ID:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbx_orderid
        '
        Me.txtbx_orderid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_orderid.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtbx_orderid.Location = New System.Drawing.Point(143, 83)
        Me.txtbx_orderid.Name = "txtbx_orderid"
        Me.txtbx_orderid.Size = New System.Drawing.Size(148, 29)
        Me.txtbx_orderid.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(54, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 29)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ORDER ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_clrorder
        '
        Me.btn_clrorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_clrorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clrorder.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_clrorder.ForeColor = System.Drawing.Color.White
        Me.btn_clrorder.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_erase_15
        Me.btn_clrorder.Location = New System.Drawing.Point(583, 540)
        Me.btn_clrorder.Name = "btn_clrorder"
        Me.btn_clrorder.Size = New System.Drawing.Size(167, 33)
        Me.btn_clrorder.TabIndex = 19
        Me.btn_clrorder.Text = "CLEAR ORDER LIST"
        Me.btn_clrorder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clrorder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_clrorder.UseVisualStyleBackColor = False
        '
        'btn_removebill
        '
        Me.btn_removebill.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btn_removebill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_removebill.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_removebill.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_removebill.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_delete_bin_15
        Me.btn_removebill.Location = New System.Drawing.Point(567, 165)
        Me.btn_removebill.Name = "btn_removebill"
        Me.btn_removebill.Size = New System.Drawing.Size(183, 33)
        Me.btn_removebill.TabIndex = 18
        Me.btn_removebill.Text = "REMOVE TO BILL"
        Me.btn_removebill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_removebill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_removebill.UseVisualStyleBackColor = False
        '
        'btn_confirmorder
        '
        Me.btn_confirmorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btn_confirmorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmorder.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_confirmorder.ForeColor = System.Drawing.Color.White
        Me.btn_confirmorder.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_receipt_approved_15
        Me.btn_confirmorder.Location = New System.Drawing.Point(756, 540)
        Me.btn_confirmorder.Name = "btn_confirmorder"
        Me.btn_confirmorder.Size = New System.Drawing.Size(185, 33)
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
        Me.btn_addbill.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_addbill.ForeColor = System.Drawing.Color.White
        Me.btn_addbill.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_plus_15
        Me.btn_addbill.Location = New System.Drawing.Point(756, 165)
        Me.btn_addbill.Name = "btn_addbill"
        Me.btn_addbill.Size = New System.Drawing.Size(185, 33)
        Me.btn_addbill.TabIndex = 11
        Me.btn_addbill.Text = "ADD TO BILL"
        Me.btn_addbill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_addbill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_addbill.UseVisualStyleBackColor = False
        '
        'pnl_nav
        '
        Me.pnl_nav.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnl_nav.Controls.Add(Me.btn_home)
        Me.pnl_nav.Controls.Add(Me.Label7)
        Me.pnl_nav.Controls.Add(Me.btn_back)
        Me.pnl_nav.Controls.Add(Me.PictureBox2)
        Me.pnl_nav.Controls.Add(Me.PictureBox3)
        Me.pnl_nav.Location = New System.Drawing.Point(54, 12)
        Me.pnl_nav.Name = "pnl_nav"
        Me.pnl_nav.Size = New System.Drawing.Size(887, 45)
        Me.pnl_nav.TabIndex = 8
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.White
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_home.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_home.Location = New System.Drawing.Point(676, 6)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(97, 33)
        Me.btn_home.TabIndex = 33
        Me.btn_home.Text = "HOME"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(70, -3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(356, 48)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "CREATE NEW ORDER"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(779, 6)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(97, 33)
        Me.btn_back.TabIndex = 10
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PictureBox2.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_purchase_order_48
        Me.PictureBox2.Location = New System.Drawing.Point(11, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_vertical_line_96
        Me.PictureBox3.Location = New System.Drawing.Point(32, -30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(47, 111)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'CreateNewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 604)
        Me.Controls.Add(Me.pnl_createneworder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CreateNewOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateNewOrder"
        Me.pnl_createneworder.ResumeLayout(False)
        Me.pnl_createneworder.PerformLayout()
        CType(Me.DataGridView_bill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_nav.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_createneworder As Panel
    Friend WithEvents txtbx_prodname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView_bill As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents txtbx_quantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbbx_prodid As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbx_customername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbx_customerid As TextBox
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
End Class
