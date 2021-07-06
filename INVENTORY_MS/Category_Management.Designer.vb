<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category_Management
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Category_Management))
        Me.pnl_categorymanagement = New System.Windows.Forms.Panel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txtbx_search = New System.Windows.Forms.TextBox()
        Me.txtbx_categname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbx_categid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_srt = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.dgv_category = New System.Windows.Forms.DataGridView()
        Me.pnl_nav = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.pnl_categorymanagement.SuspendLayout()
        CType(Me.dgv_category, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_nav.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_categorymanagement
        '
        Me.pnl_categorymanagement.BackColor = System.Drawing.Color.White
        Me.pnl_categorymanagement.Controls.Add(Me.lbl_username)
        Me.pnl_categorymanagement.Controls.Add(Me.btn_cancel)
        Me.pnl_categorymanagement.Controls.Add(Me.btn_search)
        Me.pnl_categorymanagement.Controls.Add(Me.txtbx_search)
        Me.pnl_categorymanagement.Controls.Add(Me.txtbx_categname)
        Me.pnl_categorymanagement.Controls.Add(Me.Label3)
        Me.pnl_categorymanagement.Controls.Add(Me.txtbx_categid)
        Me.pnl_categorymanagement.Controls.Add(Me.Label1)
        Me.pnl_categorymanagement.Controls.Add(Me.btn_srt)
        Me.pnl_categorymanagement.Controls.Add(Me.btn_clear)
        Me.pnl_categorymanagement.Controls.Add(Me.btn_delete)
        Me.pnl_categorymanagement.Controls.Add(Me.btn_edit)
        Me.pnl_categorymanagement.Controls.Add(Me.dgv_category)
        Me.pnl_categorymanagement.Controls.Add(Me.pnl_nav)
        Me.pnl_categorymanagement.Controls.Add(Me.btn_add)
        Me.pnl_categorymanagement.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.pnl_categorymanagement.Location = New System.Drawing.Point(0, 0)
        Me.pnl_categorymanagement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnl_categorymanagement.Name = "pnl_categorymanagement"
        Me.pnl_categorymanagement.Size = New System.Drawing.Size(1433, 751)
        Me.pnl_categorymanagement.TabIndex = 1
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.LightSlateGray
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_cancel_15
        Me.btn_cancel.Location = New System.Drawing.Point(948, 174)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(111, 36)
        Me.btn_cancel.TabIndex = 4
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.btn_search.Location = New System.Drawing.Point(1173, 246)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(124, 36)
        Me.btn_search.TabIndex = 8
        Me.btn_search.Text = "SEARCH"
        Me.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'txtbx_search
        '
        Me.txtbx_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_search.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_search.Location = New System.Drawing.Point(860, 246)
        Me.txtbx_search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbx_search.Name = "txtbx_search"
        Me.txtbx_search.Size = New System.Drawing.Size(305, 34)
        Me.txtbx_search.TabIndex = 7
        '
        'txtbx_categname
        '
        Me.txtbx_categname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_categname.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_categname.Location = New System.Drawing.Point(845, 107)
        Me.txtbx_categname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbx_categname.MaxLength = 20
        Me.txtbx_categname.Name = "txtbx_categname"
        Me.txtbx_categname.Size = New System.Drawing.Size(454, 34)
        Me.txtbx_categname.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label3.Location = New System.Drawing.Point(639, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 36)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "CATEGORY NAME:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbx_categid
        '
        Me.txtbx_categid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_categid.Enabled = False
        Me.txtbx_categid.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_categid.Location = New System.Drawing.Point(256, 107)
        Me.txtbx_categid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbx_categid.Name = "txtbx_categid"
        Me.txtbx_categid.Size = New System.Drawing.Size(374, 34)
        Me.txtbx_categid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(81, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 36)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "CATEGORY ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_srt
        '
        Me.btn_srt.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_srt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_srt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_srt.ForeColor = System.Drawing.Color.White
        Me.btn_srt.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_sort_15
        Me.btn_srt.Location = New System.Drawing.Point(87, 245)
        Me.btn_srt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_srt.Name = "btn_srt"
        Me.btn_srt.Size = New System.Drawing.Size(111, 36)
        Me.btn_srt.TabIndex = 9
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
        Me.btn_clear.Location = New System.Drawing.Point(1185, 174)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(111, 36)
        Me.btn_clear.TabIndex = 6
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_delete.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_delete_bin_15
        Me.btn_delete.Location = New System.Drawing.Point(1065, 174)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(111, 36)
        Me.btn_delete.TabIndex = 5
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_edit_15__1_
        Me.btn_edit.Location = New System.Drawing.Point(947, 174)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(111, 36)
        Me.btn_edit.TabIndex = 17
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'dgv_category
        '
        Me.dgv_category.AllowUserToAddRows = False
        Me.dgv_category.AllowUserToDeleteRows = False
        Me.dgv_category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_category.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_category.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_category.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_category.GridColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.dgv_category.Location = New System.Drawing.Point(87, 288)
        Me.dgv_category.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_category.Name = "dgv_category"
        Me.dgv_category.ReadOnly = True
        Me.dgv_category.RowHeadersWidth = 62
        Me.dgv_category.RowTemplate.Height = 25
        Me.dgv_category.Size = New System.Drawing.Size(1213, 399)
        Me.dgv_category.TabIndex = 10
        '
        'pnl_nav
        '
        Me.pnl_nav.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnl_nav.Controls.Add(Me.Label7)
        Me.pnl_nav.Controls.Add(Me.btn_back)
        Me.pnl_nav.Controls.Add(Me.PictureBox2)
        Me.pnl_nav.Controls.Add(Me.PictureBox3)
        Me.pnl_nav.Location = New System.Drawing.Point(87, 31)
        Me.pnl_nav.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnl_nav.Name = "pnl_nav"
        Me.pnl_nav.Size = New System.Drawing.Size(1213, 48)
        Me.pnl_nav.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(80, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(487, 48)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "CATEGORY MANAGEMENT"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(1072, 6)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(111, 36)
        Me.btn_back.TabIndex = 12
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_sorting_48__1_
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
        Me.btn_add.Location = New System.Drawing.Point(829, 174)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(111, 36)
        Me.btn_add.TabIndex = 3
        Me.btn_add.Text = "ADD"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'lbl_username
        '
        Me.lbl_username.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_username.ForeColor = System.Drawing.Color.White
        Me.lbl_username.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_username.Location = New System.Drawing.Point(80, 174)
        Me.lbl_username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(716, 30)
        Me.lbl_username.TabIndex = 24
        Me.lbl_username.Text = "Username123456"
        Me.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Category_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1387, 737)
        Me.Controls.Add(Me.pnl_categorymanagement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Category_Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category Management"
        Me.pnl_categorymanagement.ResumeLayout(False)
        Me.pnl_categorymanagement.PerformLayout()
        CType(Me.dgv_category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_nav.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_categorymanagement As Panel
    Friend WithEvents txtbx_categname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbx_categid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_srt As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents dgv_category As DataGridView
    Friend WithEvents btn_add As Button
    Friend WithEvents pnl_nav As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_search As Button
    Friend WithEvents txtbx_search As TextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents lbl_username As Label
End Class
