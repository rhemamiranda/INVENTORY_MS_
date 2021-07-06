Imports System.ComponentModel
Imports System.Data.OracleClient

Public Class UserInfo_Management
    <Obsolete>
    Dim Conn As OracleConnection            'Connection Variable
    <Obsolete>
    Dim OrclCommand As OracleCommand        'Oracle SQL Execution
    <Obsolete>
    Dim DataAdapter As OracleDataAdapter    'Adapter for GridView
    <Obsolete>
    Dim DataTable As DataTable              'Record Set
    <Obsolete>
    Dim DataReader As OracleDataReader      'Read RecordS

    Dim SQL As String
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Home.lbl_username.Text = lbl_username.Text
        Home.Show()
        Conn.Close()
        Me.Close()
    End Sub

    <Obsolete>
    Private Sub UserInfo_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New OracleConnection("Data Source=localhost:1521/orcl;User ID=c##ITE3;Password=elective3;Unicode=True")
        Conn.Open()
        SQL = "SELECT USER_ID, LAST_NAME, FIRST_NAME, A.USERNAME, A.PASSWORD, USER_PHONE FROM EMPLOYEES E JOIN ACCOUNTS A ON E.USER_ID = A.ACC_ID ORDER BY USER_ID"
        Load_Data(SQL)
        btn_cancel.Visible = False
    End Sub

    <Obsolete>
    Private Sub Load_Data(query As String)
        DataAdapter = New OracleDataAdapter(query, Conn)
        DataTable = New DataTable
        DataAdapter.Fill(DataTable)
        dgv_userinfo.DataSource = DataTable
        dgv_userinfo.Columns(4).Visible = False
    End Sub

    <Obsolete>
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        If btn_add.Text = "ADD" Then
            txtbx_userid.Text = Get_LastID("SELECT USER_ID FROM EMPLOYEES ORDER BY USER_ID", "USER_ID")
            txtbx_lastname.Text = ""
            txtbx_firstname.Text = ""
            txtbx_username.Text = ""
            txtbx_password.Text = ""
            txtbx_phonenum.Text = ""
            btn_add.Text = "SAVE"
            btn_cancel.Visible = True
            btn_edit.Visible = False
        Else
            'Check if all fields are not empty
            If txtbx_lastname.Text = "" Then
                MsgBox("The Last Name field must not be blank.", vbExclamation, "Last Name")
            ElseIf txtbx_firstname.Text = "" Then
                MsgBox("The First Name field must not be blank.", vbExclamation, "First Name")
            ElseIf txtbx_username.Text = "" Then
                MsgBox("The Username field must not be blank.", vbExclamation, "Username")
            ElseIf txtbx_password.Text = "" Then
                MsgBox("The Password field must not be blank.", vbExclamation, "Password")
            ElseIf txtbx_phonenum.Text = "" Then
                MsgBox("The Phone Number field must not be blank.", vbExclamation, "Phone Number")
            Else
                SQL = "INSERT INTO EMPLOYEES (USER_ID, LAST_NAME, FIRST_NAME, USER_PHONE) VALUES('" & txtbx_userid.Text & "','" & txtbx_lastname.Text & "', '" & txtbx_firstname.Text & "', '" & txtbx_phonenum.Text & "')"
                Add_Records(SQL)
                SQL = "INSERT INTO ACCOUNTS(ACC_ID, USERNAME, PASSWORD) VALUES ('" & txtbx_userid.Text & "','" & txtbx_username.Text & "', '" & txtbx_password.Text & "')"
                Add_Records(SQL)
                SQL = "SELECT USER_ID, LAST_NAME, FIRST_NAME, A.USERNAME, A.PASSWORD, USER_PHONE FROM EMPLOYEES E JOIN ACCOUNTS A ON E.USER_ID = A.ACC_ID ORDER BY USER_ID"
                Load_Data(SQL)

                MsgBox("User is successfully added!", vbInformation, "User")
                btn_add.Text = "ADD"
                btn_edit.Visible = True
                btn_cancel.Visible = False
            End If
        End If



    End Sub

    <Obsolete>
    Private Sub Add_Records(query As String)
        OrclCommand = New OracleCommand(query, Conn)
        OrclCommand.ExecuteNonQuery()

    End Sub

    <Obsolete>
    Public Sub Edit_Record(query As String)
        OrclCommand = New OracleCommand(query, Conn)
        OrclCommand.ExecuteNonQuery()
    End Sub

    <Obsolete>
    Private Function Get_LastID(query As String, var As String)
        OrclCommand = Conn.CreateCommand
        OrclCommand.CommandText = query
        DataReader = OrclCommand.ExecuteReader
        Dim lastID As Integer
        While DataReader.Read
            lastID = DataReader.Item(var)
        End While
        lastID = lastID + 1
        Return lastID
    End Function

    <Obsolete>
    Private Sub dgv_userinfo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_userinfo.CellClick
        If btn_add.Text = "SAVE" Then
            btn_edit.Visible = True
            btn_cancel.Visible = False
            btn_add.Text = "ADD"
        End If

        Try

            txtbx_userid.Text = dgv_userinfo.Rows(e.RowIndex).Cells(0).Value
            txtbx_lastname.Text = dgv_userinfo.Rows(e.RowIndex).Cells(1).Value
            txtbx_firstname.Text = dgv_userinfo.Rows(e.RowIndex).Cells(2).Value
            txtbx_username.Text = dgv_userinfo.Rows(e.RowIndex).Cells(3).Value
            txtbx_password.Text = dgv_userinfo.Rows(e.RowIndex).Cells(4).Value
            txtbx_phonenum.Text = dgv_userinfo.Rows(e.RowIndex).Cells(5).Value


        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        btn_edit.Visible = True
        btn_cancel.Visible = False
        btn_add.Text = "ADD"
        Clear()
    End Sub

    Public Sub Clear()
        If btn_add.Text = "SAVE" Then
            txtbx_lastname.Text = ""
            txtbx_firstname.Text = ""
            txtbx_username.Text = ""
            txtbx_password.Text = ""
            txtbx_phonenum.Text = ""
        Else
            txtbx_userid.Text = ""
            txtbx_lastname.Text = ""
            txtbx_firstname.Text = ""
            txtbx_username.Text = ""
            txtbx_password.Text = ""
            txtbx_phonenum.Text = ""
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Clear()
    End Sub

    Private Sub btn_srt_Click(sender As Object, e As EventArgs) Handles btn_srt.Click
        If btn_srt.Text = "A - Z" Then
            dgv_userinfo.Sort(dgv_userinfo.Columns(1), ListSortDirection.Ascending)
            btn_srt.Text = "Z - A"
        Else
            dgv_userinfo.Sort(dgv_userinfo.Columns(1), ListSortDirection.Descending)
            btn_srt.Text = "A - Z"
        End If
    End Sub

    <Obsolete>
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        'check if there is selected user
        If txtbx_userid.Text = "" And txtbx_lastname.Text = "" And txtbx_firstname.Text = "" And txtbx_username.Text = "" And txtbx_password.Text = "" And txtbx_phonenum.Text = "" Then
            MsgBox("Please select user first", vbExclamation, "Edit User Info")
            Exit Sub
        End If

        'check if all fields are not empty
        If txtbx_lastname.Text = "" Then
            MsgBox("The Last Name field must not be blank.", vbExclamation, "Last Name")
        ElseIf txtbx_firstname.Text = "" Then
            MsgBox("The First Name field must not be blank.", vbExclamation, "First Name")
        ElseIf txtbx_username.Text = "" Then
            MsgBox("The Username field must not be blank.", vbExclamation, "Username")
        ElseIf txtbx_password.Text = "" Then
            MsgBox("The Password field must not be blank.", vbExclamation, "Password")
        ElseIf txtbx_phonenum.Text = "" Then
            MsgBox("The Phone Number field must not be blank.", vbExclamation, "Phone Number")
        Else

            SQL = "UPDATE EMPLOYEES SET LAST_NAME = '" & txtbx_lastname.Text & "', FIRST_NAME = '" & txtbx_firstname.Text & "',  USER_PHONE = '" & txtbx_phonenum.Text & "' WHERE USER_ID = '" & txtbx_userid.Text & "'"
            Edit_Record(SQL)
            SQL = "UPDATE ACCOUNTS SET USERNAME = '" & txtbx_username.Text & "', PASSWORD = '" & txtbx_password.Text & "' WHERE ACC_ID = '" & txtbx_userid.Text & "'"
            Edit_Record(SQL)
            SQL = "SELECT USER_ID, LAST_NAME, FIRST_NAME, A.USERNAME, A.PASSWORD, USER_PHONE FROM EMPLOYEES E JOIN ACCOUNTS A ON E.USER_ID = A.ACC_ID ORDER BY USER_ID"
            Load_Data(SQL)
            MsgBox("User Info is successfully edited!", vbInformation, "User Info")
        End If
    End Sub

    <Obsolete>
    Private Sub txtbx_search_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbx_search.KeyUp
        SQL = "SELECT USER_ID, LAST_NAME, FIRST_NAME, A.USERNAME, A.PASSWORD, USER_PHONE FROM EMPLOYEES E JOIN ACCOUNTS A ON E.USER_ID = A.ACC_ID WHERE LOWER(LAST_NAME) Like LOWER('%" & txtbx_search.Text & "%') OR LOWER(FIRST_NAME) LIKE LOWER('%" & txtbx_search.Text & "%') OR LOWER(A.USERNAME) LIKE LOWER('%" & txtbx_search.Text & "%')"
        Load_Data(SQL)
    End Sub

    <Obsolete>
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If txtbx_search.Text <> "" Then
            SQL = "SELECT USER_ID, LAST_NAME, FIRST_NAME, A.USERNAME, A.PASSWORD, USER_PHONE FROM EMPLOYEES E JOIN ACCOUNTS A ON E.USER_ID = A.ACC_ID ORDER BY USER_ID"
            Load_Data(SQL)
        End If
    End Sub

    Public Sub Cancel_AddUser()
        btn_edit.Visible = True
        btn_cancel.Visible = False
        btn_add.Text = ""
    End Sub
End Class