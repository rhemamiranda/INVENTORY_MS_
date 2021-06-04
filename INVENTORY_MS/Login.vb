Imports System.Data.OracleClient
Public Class Login
    <Obsolete>
    Dim Conn As OracleConnection        'Connection Variable
    <Obsolete>
    Dim OrclCommand As OracleCommand    'Oracle SQL Execution
    <Obsolete>
    Dim DataReader As OracleDataReader  'Read Record

    Dim SQL As String

    <Obsolete>
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        'Check username & password if not empty
        If txtbx_username.Text = "" Then
            lbl_error.Text = "      Please enter your username."
            lbl_error.Visible = True

        ElseIf txtbx_password.Text = "" Then
            lbl_error.Text = "      Please enter your password."
            lbl_error.Visible = True

        Else
            'Validate user credentials
            SQL = "SELECT USERNAME, PASSWORD FROM ACCOUNTS WHERE USERNAME = '" & txtbx_username.Text & "' AND PASSWORD = '" & txtbx_password.Text & "' "
            OrclCommand = Conn.CreateCommand
            OrclCommand.CommandText = SQL
            DataReader = OrclCommand.ExecuteReader
            DataReader.Read()
            If DataReader.HasRows = True Then
                Home.lbl_username.Text = DataReader.Item("USERNAME")
                Conn.Close()
                Home.Show()
                Me.Close()
            Else
                lbl_error.Text = "      Invalid username or password!"
                lbl_error.Visible = True
            End If

        End If

    End Sub

    <Obsolete>
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New OracleConnection("Data Source=localhost:1521/orcl;User ID=c##ITE3;Password=elective3;Unicode=True")
        Conn.Open()
    End Sub

    Private Sub txtbx_password_MouseDown(sender As Object, e As MouseEventArgs) Handles txtbx_password.MouseDown
        txtbx_password.PasswordChar = ""
    End Sub

    Private Sub txtbx_password_MouseUp(sender As Object, e As MouseEventArgs) Handles txtbx_password.MouseUp
        txtbx_password.PasswordChar = "●"
    End Sub

End Class
