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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl_ordermanagement = New System.Windows.Forms.Panel()
        Me.btn_deleteorder = New System.Windows.Forms.Button()
        Me.btn_createnew = New System.Windows.Forms.Button()
        Me.btn_srt = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView_order = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_nav = New System.Windows.Forms.Panel()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pnl_ordermanagement.SuspendLayout()
        CType(Me.DataGridView_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_nav.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_ordermanagement
        '
        Me.pnl_ordermanagement.AutoScroll = True
        Me.pnl_ordermanagement.BackColor = System.Drawing.Color.White
        Me.pnl_ordermanagement.Controls.Add(Me.btn_deleteorder)
        Me.pnl_ordermanagement.Controls.Add(Me.btn_createnew)
        Me.pnl_ordermanagement.Controls.Add(Me.btn_srt)
        Me.pnl_ordermanagement.Controls.Add(Me.Label9)
        Me.pnl_ordermanagement.Controls.Add(Me.DataGridView_order)
        Me.pnl_ordermanagement.Controls.Add(Me.pnl_nav)
        Me.pnl_ordermanagement.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.pnl_ordermanagement.Location = New System.Drawing.Point(0, 0)
        Me.pnl_ordermanagement.Name = "pnl_ordermanagement"
        Me.pnl_ordermanagement.Size = New System.Drawing.Size(996, 649)
        Me.pnl_ordermanagement.TabIndex = 4
        '
        'btn_deleteorder
        '
        Me.btn_deleteorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btn_deleteorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deleteorder.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_deleteorder.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_deleteorder.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_delete_bin_15
        Me.btn_deleteorder.Location = New System.Drawing.Point(758, 528)
        Me.btn_deleteorder.Name = "btn_deleteorder"
        Me.btn_deleteorder.Size = New System.Drawing.Size(183, 33)
        Me.btn_deleteorder.TabIndex = 42
        Me.btn_deleteorder.Text = "DELETE ORDER"
        Me.btn_deleteorder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_deleteorder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_deleteorder.UseVisualStyleBackColor = False
        '
        'btn_createnew
        '
        Me.btn_createnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_createnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_createnew.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_createnew.ForeColor = System.Drawing.Color.White
        Me.btn_createnew.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_plus_15
        Me.btn_createnew.Location = New System.Drawing.Point(777, 72)
        Me.btn_createnew.Name = "btn_createnew"
        Me.btn_createnew.Size = New System.Drawing.Size(164, 33)
        Me.btn_createnew.TabIndex = 41
        Me.btn_createnew.Text = "CREATE NEW ORDER"
        Me.btn_createnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_createnew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_createnew.UseVisualStyleBackColor = False
        '
        'btn_srt
        '
        Me.btn_srt.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_srt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_srt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_srt.ForeColor = System.Drawing.Color.White
        Me.btn_srt.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_sort_15
        Me.btn_srt.Location = New System.Drawing.Point(54, 104)
        Me.btn_srt.Name = "btn_srt"
        Me.btn_srt.Size = New System.Drawing.Size(97, 33)
        Me.btn_srt.TabIndex = 40
        Me.btn_srt.Text = "SORT"
        Me.btn_srt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_srt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_srt.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(54, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(356, 29)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "ORDER LIST SUMMARY"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView_order
        '
        Me.DataGridView_order.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView_order.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView_order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_order.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column7, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView_order.GridColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.DataGridView_order.Location = New System.Drawing.Point(54, 143)
        Me.DataGridView_order.Name = "DataGridView_order"
        Me.DataGridView_order.RowTemplate.Height = 25
        Me.DataGridView_order.Size = New System.Drawing.Size(887, 379)
        Me.DataGridView_order.TabIndex = 15
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column2.HeaderText = "ORDER ID"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 101
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "CUSTOMER ID"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 117
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "PRODUCTID"
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
        Me.Column6.HeaderText = "TOTAL"
        Me.Column6.Name = "Column6"
        '
        'pnl_nav
        '
        Me.pnl_nav.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnl_nav.Controls.Add(Me.btn_back)
        Me.pnl_nav.Controls.Add(Me.Label7)
        Me.pnl_nav.Controls.Add(Me.PictureBox2)
        Me.pnl_nav.Controls.Add(Me.PictureBox3)
        Me.pnl_nav.Location = New System.Drawing.Point(54, 12)
        Me.pnl_nav.Name = "pnl_nav"
        Me.pnl_nav.Size = New System.Drawing.Size(887, 45)
        Me.pnl_nav.TabIndex = 8
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(781, 5)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(97, 33)
        Me.btn_back.TabIndex = 34
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(70, -3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(356, 48)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "ORDER MANAGEMENT"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Order_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 604)
        Me.Controls.Add(Me.pnl_ordermanagement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Order_Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order_Management"
        Me.pnl_ordermanagement.ResumeLayout(False)
        CType(Me.DataGridView_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_nav.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_ordermanagement As Panel
    Friend WithEvents DataGridView_order As DataGridView
    Friend WithEvents pnl_nav As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents btn_srt As Button
    Friend WithEvents btn_createnew As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_deleteorder As Button
End Class
