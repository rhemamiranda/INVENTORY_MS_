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
        Me.txtbx_username = New System.Windows.Forms.TextBox()
        Me.txtbx_password = New System.Windows.Forms.TextBox()
        Me.pnl_login = New System.Windows.Forms.Panel()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnl_login.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbx_username
        '
        Me.txtbx_username.BackColor = System.Drawing.Color.Gainsboro
        Me.txtbx_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbx_username.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtbx_username.Location = New System.Drawing.Point(79, 305)
        Me.txtbx_username.Name = "txtbx_username"
        Me.txtbx_username.Size = New System.Drawing.Size(321, 25)
        Me.txtbx_username.TabIndex = 2
        '
        'txtbx_password
        '
        Me.txtbx_password.BackColor = System.Drawing.Color.Gainsboro
        Me.txtbx_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbx_password.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtbx_password.Location = New System.Drawing.Point(79, 367)
        Me.txtbx_password.Name = "txtbx_password"
        Me.txtbx_password.Size = New System.Drawing.Size(321, 25)
        Me.txtbx_password.TabIndex = 3
        '
        'pnl_login
        '
        Me.pnl_login.AutoSize = True
        Me.pnl_login.BackColor = System.Drawing.Color.White
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
        Me.pnl_login.Size = New System.Drawing.Size(1085, 604)
        Me.pnl_login.TabIndex = 0
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_login.Location = New System.Drawing.Point(79, 415)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(321, 37)
        Me.btn_login.TabIndex = 9
        Me.btn_login.Text = "LOG IN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(76, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(78, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.INVENTORY_MS.My.Resources.Resources._185867624_214557283812006_7854139124549150250_n1
        Me.PictureBox1.InitialImage = Global.INVENTORY_MS.My.Resources.Resources._185867624_214557283812006_7854139124549150250_n
        Me.PictureBox1.Location = New System.Drawing.Point(481, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(460, 445)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 33.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(65, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(593, 52)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "INVENTORY"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 33.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(65, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(593, 56)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MANAGEMENT"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 33.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(65, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(593, 56)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "SYSTEM"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(988, 604)
        Me.Controls.Add(Me.pnl_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.pnl_login.ResumeLayout(False)
        Me.pnl_login.PerformLayout()
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
End Class
