<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order_Management
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Order_Management))
        Me.pnl_ordermanagement = New System.Windows.Forms.Panel()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txtbx_search = New System.Windows.Forms.TextBox()
        Me.btn_createnew = New System.Windows.Forms.Button()
        Me.btn_srt = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgv_order = New System.Windows.Forms.DataGridView()
        Me.pnl_nav = New System.Windows.Forms.Panel()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.pnl_ordermanagement.SuspendLayout()
        CType(Me.dgv_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_nav.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_ordermanagement
        '
        Me.pnl_ordermanagement.AutoScroll = True
        Me.pnl_ordermanagement.BackColor = System.Drawing.Color.White
        Me.pnl_ordermanagement.Controls.Add(Me.lbl_username)
        Me.pnl_ordermanagement.Controls.Add(Me.btn_search)
        Me.pnl_ordermanagement.Controls.Add(Me.txtbx_search)
        Me.pnl_ordermanagement.Controls.Add(Me.btn_createnew)
        Me.pnl_ordermanagement.Controls.Add(Me.btn_srt)
        Me.pnl_ordermanagement.Controls.Add(Me.Label9)
        Me.pnl_ordermanagement.Controls.Add(Me.dgv_order)
        Me.pnl_ordermanagement.Controls.Add(Me.pnl_nav)
        Me.pnl_ordermanagement.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.pnl_ordermanagement.Location = New System.Drawing.Point(0, 0)
        Me.pnl_ordermanagement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnl_ordermanagement.Name = "pnl_ordermanagement"
        Me.pnl_ordermanagement.Size = New System.Drawing.Size(1408, 763)
        Me.pnl_ordermanagement.TabIndex = 9
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.LightSlateGray
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_search_15
        Me.btn_search.Location = New System.Drawing.Point(1175, 176)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(124, 36)
        Me.btn_search.TabIndex = 4
        Me.btn_search.Text = "SEARCH"
        Me.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'txtbx_search
        '
        Me.txtbx_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbx_search.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbx_search.Location = New System.Drawing.Point(861, 176)
        Me.txtbx_search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbx_search.Name = "txtbx_search"
        Me.txtbx_search.Size = New System.Drawing.Size(305, 34)
        Me.txtbx_search.TabIndex = 3
        '
        'btn_createnew
        '
        Me.btn_createnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_createnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_createnew.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_createnew.ForeColor = System.Drawing.Color.White
        Me.btn_createnew.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_plus_15
        Me.btn_createnew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_createnew.Location = New System.Drawing.Point(1111, 95)
        Me.btn_createnew.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_createnew.Name = "btn_createnew"
        Me.btn_createnew.Size = New System.Drawing.Size(188, 36)
        Me.btn_createnew.TabIndex = 2
        Me.btn_createnew.Text = "CREATE NEW ORDER"
        Me.btn_createnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_createnew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_createnew.UseVisualStyleBackColor = False
        '
        'btn_srt
        '
        Me.btn_srt.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_srt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_srt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_srt.ForeColor = System.Drawing.Color.White
        Me.btn_srt.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_sort_15
        Me.btn_srt.Location = New System.Drawing.Point(92, 177)
        Me.btn_srt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_srt.Name = "btn_srt"
        Me.btn_srt.Size = New System.Drawing.Size(111, 36)
        Me.btn_srt.TabIndex = 5
        Me.btn_srt.Text = "OLD"
        Me.btn_srt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_srt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_srt.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(85, 95)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(407, 31)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "ORDER LIST SUMMARY"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgv_order
        '
        Me.dgv_order.AllowUserToAddRows = False
        Me.dgv_order.AllowUserToDeleteRows = False
        Me.dgv_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_order.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_order.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_order.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_order.GridColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.dgv_order.Location = New System.Drawing.Point(92, 219)
        Me.dgv_order.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_order.Name = "dgv_order"
        Me.dgv_order.ReadOnly = True
        Me.dgv_order.RowHeadersWidth = 62
        Me.dgv_order.RowTemplate.Height = 25
        Me.dgv_order.Size = New System.Drawing.Size(1207, 470)
        Me.dgv_order.TabIndex = 6
        '
        'pnl_nav
        '
        Me.pnl_nav.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnl_nav.Controls.Add(Me.btn_back)
        Me.pnl_nav.Controls.Add(Me.Label7)
        Me.pnl_nav.Controls.Add(Me.PictureBox2)
        Me.pnl_nav.Controls.Add(Me.PictureBox3)
        Me.pnl_nav.Location = New System.Drawing.Point(92, 31)
        Me.pnl_nav.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnl_nav.Name = "pnl_nav"
        Me.pnl_nav.Size = New System.Drawing.Size(1207, 48)
        Me.pnl_nav.TabIndex = 7
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(1065, 6)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(111, 36)
        Me.btn_back.TabIndex = 8
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(80, -4)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(459, 52)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "ORDER MANAGEMENT"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_purchase_order_48
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
        'lbl_username
        '
        Me.lbl_username.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_username.ForeColor = System.Drawing.Color.White
        Me.lbl_username.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_username.Location = New System.Drawing.Point(85, 126)
        Me.lbl_username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(716, 30)
        Me.lbl_username.TabIndex = 25
        Me.lbl_username.Text = "Username123456"
        Me.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Order_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1387, 737)
        Me.Controls.Add(Me.pnl_ordermanagement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Order_Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Management"
        Me.pnl_ordermanagement.ResumeLayout(False)
        Me.pnl_ordermanagement.PerformLayout()
        CType(Me.dgv_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_nav.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_ordermanagement As Panel
    Friend WithEvents dgv_order As DataGridView
    Friend WithEvents pnl_nav As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_srt As Button
    Friend WithEvents btn_createnew As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents txtbx_search As TextBox
    Friend WithEvents lbl_username As Label
End Class
