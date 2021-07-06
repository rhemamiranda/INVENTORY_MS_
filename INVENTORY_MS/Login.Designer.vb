<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txtbx_username = New System.Windows.Forms.TextBox()
        Me.txtbx_password = New System.Windows.Forms.TextBox()
        Me.pnl_login = New System.Windows.Forms.Panel()
        Me.pic_eye = New System.Windows.Forms.PictureBox()
        Me.lbl_error = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnl_login.SuspendLayout()
        CType(Me.pic_eye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbx_username
        '
        Me.txtbx_username.BackColor = System.Drawing.Color.Gainsboro
        Me.txtbx_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbx_username.Font = New System.Drawing.Font("Segoe UI", 13.75!)
        Me.txtbx_username.Location = New System.Drawing.Point(159, 296)
        Me.txtbx_username.Name = "txtbx_username"
        Me.txtbx_username.Size = New System.Drawing.Size(275, 25)
        Me.txtbx_username.TabIndex = 2
        '
        'txtbx_password
        '
        Me.txtbx_password.BackColor = System.Drawing.Color.Gainsboro
        Me.txtbx_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbx_password.Font = New System.Drawing.Font("Segoe UI", 13.75!)
        Me.txtbx_password.Location = New System.Drawing.Point(159, 349)
        Me.txtbx_password.Name = "txtbx_password"
        Me.txtbx_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtbx_password.Size = New System.Drawing.Size(275, 25)
        Me.txtbx_password.TabIndex = 4
        '
        'pnl_login
        '
        Me.pnl_login.AutoSize = True
        Me.pnl_login.BackColor = System.Drawing.Color.White
        Me.pnl_login.Controls.Add(Me.pic_eye)
        Me.pnl_login.Controls.Add(Me.lbl_error)
        Me.pnl_login.Controls.Add(Me.btn_login)
        Me.pnl_login.Controls.Add(Me.txtbx_password)
        Me.pnl_login.Controls.Add(Me.Label2)
        Me.pnl_login.Controls.Add(Me.Label1)
        Me.pnl_login.Controls.Add(Me.txtbx_username)
        Me.pnl_login.Controls.Add(Me.PictureBox1)
        Me.pnl_login.Controls.Add(Me.Label3)
        Me.pnl_login.Controls.Add(Me.Label4)
        Me.pnl_login.Controls.Add(Me.Label5)
        Me.pnl_login.Location = New System.Drawing.Point(0, 0)
        Me.pnl_login.Name = "pnl_login"
        Me.pnl_login.Size = New System.Drawing.Size(1070, 650)
        Me.pnl_login.TabIndex = 0
        '
        'pic_eye
        '
        Me.pic_eye.BackColor = System.Drawing.Color.Transparent
        Me.pic_eye.Image = Global.INVENTORY_MS.My.Resources.Resources.icons8_eye_96
        Me.pic_eye.Location = New System.Drawing.Point(409, 348)
        Me.pic_eye.Name = "pic_eye"
        Me.pic_eye.Size = New System.Drawing.Size(25, 26)
        Me.pic_eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_eye.TabIndex = 13
        Me.pic_eye.TabStop = False
        '
        'lbl_error
        '
        Me.lbl_error.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_error.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lbl_error.Image = Global.INVENTORY_MS.My.Resources.Resources._error
        Me.lbl_error.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_error.Location = New System.Drawing.Point(184, 431)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(247, 20)
        Me.lbl_error.TabIndex = 12
        Me.lbl_error.Text = "      Invalid username or password!"
        Me.lbl_error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_error.Visible = False
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_login.Location = New System.Drawing.Point(159, 390)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(275, 32)
        Me.btn_login.TabIndex = 5
        Me.btn_login.Text = "LOG IN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(156, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(158, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.INVENTORY_MS.My.Resources.Resources._185867624_214557283812006_7854139124549150250_n1
        Me.PictureBox1.InitialImage = Global.INVENTORY_MS.My.Resources.Resources._185867624_214557283812006_7854139124549150250_n
        Me.PictureBox1.Location = New System.Drawing.Point(503, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 385)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 33.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(147, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(508, 55)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "INVENTORY"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 33.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(147, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(508, 49)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MANAGEMENT"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 33.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(147, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(508, 49)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "SYSTEM"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(1024, 612)
        Me.Controls.Add(Me.pnl_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pnl_login.ResumeLayout(False)
        Me.pnl_login.PerformLayout()
        CType(Me.pic_eye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbx_username As TextBox
    Friend WithEvents txtbx_password As TextBox
    Friend WithEvents pnl_login As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_login As Button
    Friend WithEvents lbl_error As Label
    Friend WithEvents pic_eye As PictureBox
End Class
