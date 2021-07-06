Imports System.Data.OracleClient
Imports System.ComponentModel
Public Class Category_Management

    <Obsolete>
    Dim Conn As OracleConnection            'Connection Variable
    <Obsolete>
    Dim OrclCommand As OracleCommand        'Oracle SQL Execution
    <Obsolete>
    Dim DataAdapter As OracleDataAdapter    'Adapter for GridView
    <Obsolete>
    Dim DataTable As DataTable              'Record Set
    <Obsolete>
    Dim DataReader As OracleDataReader      'Read Record

    Dim SQL As String

    <Obsolete>
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Home.lbl_username.Text = lbl_username.Text
        Home.Show()
        Conn.Close()
        Me.Close()
    End Sub

    <Obsolete>
    Private Sub Category_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New OracleConnection("Data Source=localhost:1521/orcl;User ID=c##ITE3;Password=elective3;Unicode=True")
        Conn.Open()
        SQL = "SELECT * FROM CATEGORIES ORDER BY CATEGORY_ID"
        Load_Data(SQL)
    End Sub

    Private Sub dgv_category_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_category.CellClick
        If btn_add.Text = "SAVE" Then
            btn_edit.Visible = True
            btn_cancel.Visible = False
            btn_add.Text = "ADD"
        End If
        Try
            txtbx_categid.Text = dgv_category.Rows(e.RowIndex).Cells(0).Value
            txtbx_categname.Text = dgv_category.Rows(e.RowIndex).Cells(1).Value
        Catch ex As Exception
        End Try

    End Sub

    <Obsolete>
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If btn_add.Text = "ADD" Then
            txtbx_categid.Text = Get_LastID("SELECT * FROM CATEGORIES ORDER BY CATEGORY_ID", "CATEGORY_ID")
            txtbx_categname.Text = ""
            btn_add.Text = "SAVE"
            btn_cancel.Visible = True
            btn_edit.Visible = False
            btn_delete.Enabled = False
        Else
            'Check if category name is not empty
            If txtbx_categname.Text = "" Then
                MsgBox("The Category Name must not be blank.", vbExclamation, "Category Name")
            Else
                SQL = "INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME) VALUES('" & txtbx_categid.Text & "', '" & txtbx_categname.Text & "')"
                Edit_Record(SQL)
                SQL = "SELECT * FROM CATEGORIES ORDER BY CATEGORY_ID"
                Load_Data(SQL)
                MsgBox("Category is successfully added!", vbInformation, "Category")
                btn_add.Text = "ADD"
                btn_edit.Visible = True
                btn_cancel.Visible = False
                btn_delete.Enabled = True
            End If
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        btn_edit.Visible = True
        btn_cancel.Visible = False
        btn_delete.Enabled = True
        btn_add.Text = "ADD"
        Clear()
    End Sub

    <Obsolete>
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        'check if there is selected category
        If txtbx_categid.Text = "" And txtbx_categname.Text = "" Then
            MsgBox("Please select category first", vbExclamation, "Edit Category")
            Exit Sub
        End If

        'to check if category already exist
        If Get_Categories("SELECT CATEGORY_NAME FROM CATEGORIES ORDER BY CATEGORY_ID", txtbx_categname.Text) = True Then
            MsgBox("Category Name already exist!", vbExclamation, "Category")
            Exit Sub
        End If

        SQL = "UPDATE CATEGORIES SET CATEGORY_NAME = '" & txtbx_categname.Text & "' WHERE CATEGORY_ID = '" & txtbx_categid.Text & "'"
        Edit_Record(SQL)
        SQL = "SELECT * FROM CATEGORIES ORDER BY CATEGORY_ID"
        Load_Data(SQL)
        MsgBox("Category is successfully edited!", vbInformation, "Category")
    End Sub

    <Obsolete>
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        'check if there is selected category
        If txtbx_categid.Text = "" And txtbx_categname.Text = "" Then
            MsgBox("Please select category first", vbExclamation, "Delete Category")
            Exit Sub
        End If

        'check if in use
        SQL = "SELECT P.CATEGORY_ID, P.PRODUCT_NAME FROM PRODUCTS P JOIN CATEGORIES C ON P.CATEGORY_ID = C.CATEGORY_ID WHERE P.CATEGORY_ID = '" & txtbx_categid.Text & "'"
        OrclCommand = Conn.CreateCommand
        OrclCommand.CommandText = SQL
        DataReader = OrclCommand.ExecuteReader
        DataReader.Read()
        If DataReader.HasRows = True Then
            MsgBox("Category can't be deleted. Category is in use on product list.", vbExclamation, "Delete Category")
            Exit Sub
        Else
            Dim message As String = "Are you sure you want to delete " & txtbx_categname.Text & "?"
            If MsgBox(message, vbYesNo + vbQuestion, "Delete Category") = vbYes Then
                SQL = "DELETE FROM CATEGORIES WHERE CATEGORY_ID = '" & txtbx_categid.Text & "'"
                Edit_Record(SQL)
                SQL = "SELECT * FROM CATEGORIES ORDER BY CATEGORY_ID"
                Load_Data(SQL)
                MsgBox("Product is successfully deleted!", vbInformation, "Category")
            End If
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Clear()
    End Sub

    Private Sub btn_srt_Click(sender As Object, e As EventArgs) Handles btn_srt.Click
        If btn_srt.Text = "A - Z" Then
            dgv_category.Sort(dgv_category.Columns(1), ListSortDirection.Ascending)
            btn_srt.Text = "Z - A"
        Else
            dgv_category.Sort(dgv_category.Columns(1), ListSortDirection.Descending)
            btn_srt.Text = "A - Z"
        End If
    End Sub

    <Obsolete>
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        'for category name only
        SQL = "SELECT * FROM CATEGORIES WHERE LOWER(CATEGORY_NAME) LIKE LOWER('%" & txtbx_search.Text & "%')"
        Load_Data(SQL)
    End Sub

    <Obsolete>
    Private Sub txtbx_search_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbx_search.KeyUp
        SQL = "SELECT * FROM CATEGORIES WHERE LOWER(CATEGORY_NAME) LIKE LOWER('%" & txtbx_search.Text & "%')"
        Load_Data(SQL)
    End Sub

    <Obsolete>
    Private Function Load_Data(query As String)
        DataAdapter = New OracleDataAdapter(query, Conn)
        DataTable = New DataTable
        DataAdapter.Fill(DataTable)
        dgv_category.DataSource = DataTable
        dgv_category.Columns(0).Visible = False
    End Function

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
    Private Sub Edit_Record(query As String)
        OrclCommand = New OracleCommand(query, Conn)
        OrclCommand.ExecuteNonQuery()
    End Sub

    <Obsolete>
    Private Function Get_Categories(query As String, category As String)
        OrclCommand = Conn.CreateCommand
        OrclCommand.CommandText = query
        DataReader = OrclCommand.ExecuteReader
        Dim exist As Boolean = False
        While DataReader.Read
            If String.Compare(DataReader.Item("CATEGORY_NAME"), category) = 0 Then
                exist = True
                Exit While
            End If
        End While
        Return exist
    End Function

    Private Sub Clear()
        If btn_add.Text = "SAVE" Then
            txtbx_categname.Text = ""
        Else
            txtbx_categid.Text = ""
            txtbx_categname.Text = ""
        End If
    End Sub



End Class