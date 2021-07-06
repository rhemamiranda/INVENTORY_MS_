<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.pnl_home = New System.Windows.Forms.Panel()
        Me.pnl_nav = New System.Windows.Forms.Panel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_custominfo = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_userinfo = New System.Windows.Forms.Button()
        Me.btn_product = New System.Windows.Forms.Button()
        Me.btn_category = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pnl_home.SuspendLayout()
        Me.pnl_nav.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_home
        '
        Me.pnl_home.BackColor = System.Drawing.Color.White
        Me.pnl_home.Controls.Add(Me.pnl_nav)
        Me.pnl_home.Controls.Add(Me.btn_custominfo)
        Me.pnl_home.Controls.Add(Me.btn_order)
        Me.pnl_home.Controls.Add(Me.btn_userinfo)
        Me.pnl_home.Controls.Add(Me.btn_product)
        Me.pnl_home.Controls.Add(Me.btn_category)
        Me.pnl_home.Controls.Add(Me.PictureBox4)
        Me.pnl_home.Controls.Add(Me.PictureBox5)
        Me.pnl_home.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.pnl_home.Location = New System.Drawing.Point(0, 0)
        Me.pnl_home.Name = "pnl_home"
        Me.pnl_home.Size = New System.Drawing.Size(1051, 610)
        Me.pnl_home.TabIndex = 8
        '
        'pnl_nav
        '
        Me.pnl_nav.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.pnl_nav.Controls.Add(Me.btn_logout)
        Me.pnl_nav.Controls.Add(Me.lbl_username)
        Me.pnl_nav.Controls.Add(Me.PictureBox2)
        Me.pnl_nav.Controls.Add(Me.PictureBox3)
        Me.pnl_nav.Location = New System.Drawing.Point(67, 60)
        Me.pnl_nav.Name = "pnl_nav"
        Me.pnl_nav.Size = New System.Drawing.Size(905, 39)
        Me.pnl_nav.TabIndex = 6
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.Location = New System.Drawing.Point(796, 5)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(83, 29)
        Me.btn_logout.TabIndex = 7
        Me.btn_logout.Text = "LOGOUT"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'lbl_username
        '
        Me.lbl_username.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_username.ForeColor = System.Drawing.Color.White
        Me.lbl_username.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_username.Location = New System.Drawing.Point(60, 6)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(537, 24)
        Me.lbl_username.TabIndex = 7
        Me.lbl_username.Text = "Username123456"
        Me.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PictureBox2.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_home_96
        Me.PictureBox2.Location = New System.Drawing.Point(9, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_vertical_line_96
        Me.PictureBox3.Location = New System.Drawing.Point(27, -26)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 96)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'btn_custominfo
        '
        Me.btn_custominfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btn_custominfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_custominfo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_custominfo.ForeColor = System.Drawing.Color.White
        Me.btn_custominfo.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_user_male_70
        Me.btn_custominfo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_custominfo.Location = New System.Drawing.Point(670, 341)
        Me.btn_custominfo.Name = "btn_custominfo"
        Me.btn_custominfo.Size = New System.Drawing.Size(217, 209)
        Me.btn_custominfo.TabIndex = 5
        Me.btn_custominfo.Text = "Customers Information Management"
        Me.btn_custominfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_custominfo.UseVisualStyleBackColor = False
        '
        'btn_order
        '
        Me.btn_order.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_order.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.btn_order.ForeColor = System.Drawing.Color.White
        Me.btn_order.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_purchase_order_70
        Me.btn_order.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_order.Location = New System.Drawing.Point(670, 126)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(217, 209)
        Me.btn_order.TabIndex = 3
        Me.btn_order.Text = "Order Management"
        Me.btn_order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'btn_userinfo
        '
        Me.btn_userinfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btn_userinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_userinfo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_userinfo.ForeColor = System.Drawing.Color.White
        Me.btn_userinfo.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_manager_70__1_
        Me.btn_userinfo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_userinfo.Location = New System.Drawing.Point(427, 341)
        Me.btn_userinfo.Name = "btn_userinfo"
        Me.btn_userinfo.Size = New System.Drawing.Size(217, 209)
        Me.btn_userinfo.TabIndex = 4
        Me.btn_userinfo.Text = "      User Information Management"
        Me.btn_userinfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_userinfo.UseVisualStyleBackColor = False
        '
        'btn_product
        '
        Me.btn_product.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_product.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.btn_product.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_product.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_product_management_80
        Me.btn_product.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_product.Location = New System.Drawing.Point(124, 126)
        Me.btn_product.Name = "btn_product"
        Me.btn_product.Size = New System.Drawing.Size(282, 424)
        Me.btn_product.TabIndex = 1
        Me.btn_product.Text = "Product Management"
        Me.btn_product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_product.UseVisualStyleBackColor = False
        '
        'btn_category
        '
        Me.btn_category.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_category.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
        Me.btn_category.ForeColor = System.Drawing.Color.White
        Me.btn_category.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_sorting_70
        Me.btn_category.Location = New System.Drawing.Point(427, 126)
        Me.btn_category.Name = "btn_category"
        Me.btn_category.Size = New System.Drawing.Size(217, 209)
        Me.btn_category.TabIndex = 2
        Me.btn_category.Text = "Category Management"
        Me.btn_category.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_category.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_category.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.INVENTORY_MS.My.Resources.Resources.image__3_
        Me.PictureBox4.Location = New System.Drawing.Point(803, 240)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(468, 385)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.INVENTORY_MS.My.Resources.Resources.image__3_
        Me.PictureBox5.Location = New System.Drawing.Point(-131, 30)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(468, 385)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 599)
        Me.Controls.Add(Me.pnl_home)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Management System"
        Me.pnl_home.ResumeLayout(False)
        Me.pnl_nav.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_home As Panel
    Friend WithEvents pnl_nav As Panel
    Friend WithEvents btn_logout As Button
    Friend WithEvents lbl_username As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_custominfo As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents btn_userinfo As Button
    Friend WithEvents btn_product As Button
    Friend WithEvents btn_category As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
