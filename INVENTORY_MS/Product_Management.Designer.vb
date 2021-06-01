<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_Management
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_productmanagement = New System.Windows.Forms.Panel()
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
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.DataGridView_product = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.pnl_nav = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_productmanagement.SuspendLayout()
        CType(Me.DataGridView_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_nav.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_productmanagement
        '
        Me.pnl_productmanagement.BackColor = System.Drawing.Color.White
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
        Me.pnl_productmanagement.Controls.Add(Me.btn_delete)
        Me.pnl_productmanagement.Controls.Add(Me.btn_edit)
        Me.pnl_productmanagement.Controls.Add(Me.DataGridView_product)
        Me.pnl_productmanagement.Controls.Add(Me.btn_add)
        Me.pnl_productmanagement.Controls.Add(Me.pnl_nav)
        Me.pnl_productmanagement.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.pnl_productmanagement.Location = New System.Drawing.Point(0, 0)
        Me.pnl_productmanagement.Name = "pnl_productmanagement"
        Me.pnl_productmanagement.Size = New System.Drawing.Size(988, 604)
        Me.pnl_productmanagement.TabIndex = 3
        '
        'cmbbx_category
        '
        Me.cmbbx_category.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbbx_category.FormattingEnabled = True
        Me.cmbbx_category.Location = New System.Drawing.Point(600, 113)
        Me.cmbbx_category.Name = "cmbbx_category"
        Me.cmbbx_category.Size = New System.Drawing.Size(341, 28)
        Me.cmbbx_category.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(462, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 29)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "CATEGORY:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbx_description
        '
        Me.txtbx_description.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtbx_description.Location = New System.Drawing.Point(174, 148)
        Me.txtbx_description.Name = "txtbx_description"
        Me.txtbx_description.Size = New System.Drawing.Size(767, 29)
        Me.txtbx_description.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(54, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 29)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "DESCRIPTION:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbx_price
        '
        Me.txtbx_price.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtbx_price.Location = New System.Drawing.Point(338, 113)
        Me.txtbx_price.Name = "txtbx_price"
        Me.txtbx_price.Size = New System.Drawing.Size(112, 29)
        Me.txtbx_price.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(276, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 29)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "PRICE:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbx_prodname
        '
        Me.txtbx_prodname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_prodname.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtbx_prodname.Location = New System.Drawing.Point(600, 78)
        Me.txtbx_prodname.Name = "txtbx_prodname"
        Me.txtbx_prodname.Size = New System.Drawing.Size(341, 29)
        Me.txtbx_prodname.TabIndex = 24
        '
        'txtbx_quantity
        '
        Me.txtbx_quantity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtbx_quantity.Location = New System.Drawing.Point(174, 113)
        Me.txtbx_quantity.Name = "txtbx_quantity"
        Me.txtbx_quantity.Size = New System.Drawing.Size(96, 29)
        Me.txtbx_quantity.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(462, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 29)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "PROCUCT NAME:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(54, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 29)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "QUANTITY:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbx_productid
        '
        Me.txtbx_productid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_productid.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtbx_productid.Location = New System.Drawing.Point(174, 78)
        Me.txtbx_productid.Name = "txtbx_productid"
        Me.txtbx_productid.Size = New System.Drawing.Size(276, 29)
        Me.txtbx_productid.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(54, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 29)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "PROCUCT ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_srt
        '
        Me.btn_srt.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_srt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_srt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_srt.ForeColor = System.Drawing.Color.White
        Me.btn_srt.Image = Global.IMS_ELECTIVE3.My.Resources.Resources.icons8_sort_15
        Me.btn_srt.Location = New System.Drawing.Point(54, 186)
        Me.btn_srt.Name = "btn_srt"
        Me.btn_srt.Size = New System.Drawing.Size(97, 33)
        Me.btn_srt.TabIndex = 20
        Me.btn_srt.Text = "SORT"
        Me.btn_srt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_srt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_srt.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_clear.ForeColor = System.Drawing.Color.White
        Me.btn_clear.Image = Global.IMS_ELECTIVE3.My.Resources.Resources.icons8_erase_15
        Me.btn_clear.Location = New System.Drawing.Point(844, 186)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(97, 33)
        Me.btn_clear.TabIndex = 19
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_delete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_delete.Image = Global.IMS_ELECTIVE3.My.Resources.Resources.icons8_delete_bin_15
        Me.btn_delete.Location = New System.Drawing.Point(739, 186)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(97, 33)
        Me.btn_delete.TabIndex = 18
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.Image = Global.IMS_ELECTIVE3.My.Resources.Resources.icons8_edit_15__1_
        Me.btn_edit.Location = New System.Drawing.Point(636, 186)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(97, 33)
        Me.btn_edit.TabIndex = 17
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'DataGridView_product
        '
        Me.DataGridView_product.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView_product.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_product.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_product.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView_product.GridColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.DataGridView_product.Location = New System.Drawing.Point(54, 225)
        Me.DataGridView_product.Name = "DataGridView_product"
        Me.DataGridView_product.RowTemplate.Height = 25
        Me.DataGridView_product.Size = New System.Drawing.Size(887, 350)
        Me.DataGridView_product.TabIndex = 15
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column2.HeaderText = "PRODUCT ID"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 109
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "PRODUCT NAME"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "QUANTITY"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 104
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "PRICE"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 72
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "DESCRIPTION"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "CATEGORY"
        Me.Column7.Name = "Column7"
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Image = Global.IMS_ELECTIVE3.My.Resources.Resources.icons8_plus_15
        Me.btn_add.Location = New System.Drawing.Point(533, 186)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(97, 33)
        Me.btn_add.TabIndex = 11
        Me.btn_add.Text = "ADD"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'pnl_nav
        '
        Me.pnl_nav.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnl_nav.Controls.Add(Me.Label7)
        Me.pnl_nav.Controls.Add(Me.btn_back)
        Me.pnl_nav.Controls.Add(Me.PictureBox2)
        Me.pnl_nav.Controls.Add(Me.PictureBox3)
        Me.pnl_nav.Location = New System.Drawing.Point(54, 12)
        Me.pnl_nav.Name = "pnl_nav"
        Me.pnl_nav.Size = New System.Drawing.Size(887, 45)
        Me.pnl_nav.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(70, -3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(356, 48)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "PRODUCT MANAGEMENT"
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
        Me.PictureBox2.Image = Global.IMS_ELECTIVE3.My.Resources.Resources.icons8_product_management_48
        Me.PictureBox2.Location = New System.Drawing.Point(11, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.IMS_ELECTIVE3.My.Resources.Resources.icons8_vertical_line_96
        Me.PictureBox3.Location = New System.Drawing.Point(32, -30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(47, 111)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 604)
        Me.Controls.Add(Me.pnl_productmanagement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Product_Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.pnl_productmanagement.ResumeLayout(False)
        Me.pnl_productmanagement.PerformLayout()
        CType(Me.DataGridView_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_nav.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_productmanagement As Panel
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents DataGridView_product As DataGridView
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
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents cmbbx_category As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbx_description As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbx_price As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
End Class
