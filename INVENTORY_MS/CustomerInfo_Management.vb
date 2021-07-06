Imports System.ComponentModel
Imports System.Data.OracleClient
Public Class CustomerInfo_Management
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
        Me.Close()
    End Sub

    <Obsolete>
    Private Sub CustomerInfo_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New OracleConnection("Data Source=localhost:1521/orcl;User ID=c##ITE3;Password=elective3;Unicode=True")
        Conn.Open()
        SQL = "SELECT CUSTOMER_ID, CUSTOMER_NAME, CUSTOMER_PHONE FROM CUSTOMERS ORDER BY CUSTOMER_ID"
        Load_Data(SQL)
        btn_cancel.Visible = False

        Get_Cust("SELECT COUNT(CUSTOMER_ID) FROM CUSTOMERS")
        Get_Orders("SELECT COUNT(ORDER_ID) FROM ORDERS")
        Get_Max("SELECT SUM (TOTAL_AMOUNT) FROM ORDERS")
    End Sub


    <Obsolete>
    Private Function Get_Cust(query As String)
        OrclCommand = New OracleCommand(query, Conn)
        Dim cust As Integer = OrclCommand.ExecuteScalar()
        lbl_customercnt.Text = cust
    End Function

    <Obsolete>
    Private Function Get_Orders(query As String)
        OrclCommand = New OracleCommand(query, Conn)
        Dim order As Integer = OrclCommand.ExecuteScalar()
        lbl_orderscnt.Text = order
    End Function

    <Obsolete>
    Private Function Get_Max(query As String)
        OrclCommand = New OracleCommand(query, Conn)
        Dim max As Decimal = OrclCommand.ExecuteScalar()
        lbl_maxordercnt.Text = max
    End Function

    <Obsolete>
    Private Sub Load_Data(query As String)
        DataAdapter = New OracleDataAdapter(query, Conn)
        DataTable = New DataTable
        DataAdapter.Fill(DataTable)
        dgv_customerinfo.DataSource = DataTable

    End Sub


    <Obsolete>
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If btn_add.Text = "ADD" Then
            txtbx_customerid.Text = Get_LastID("SELECT CUSTOMER_ID FROM CUSTOMERS ORDER BY CUSTOMER_ID", "CUSTOMER_ID")
            txtbx_name.Text = ""
            txtbx_phonenum.Text = ""
            btn_add.Text = "SAVE"
            btn_cancel.Visible = True
            btn_edit.Visible = False
        Else
            'Check if all fields are not empty
            If txtbx_name.Text = "" Then
                MsgBox("The Name field must not be blank.", vbExclamation, "Last Name")
            Else
                SQL = "INSERT INTO CUSTOMERS (CUSTOMER_ID, CUSTOMER_NAME, CUSTOMER_PHONE) VALUES('" & txtbx_customerid.Text & "','" & txtbx_name.Text & "', '" & txtbx_phonenum.Text & "')"

                Add_Records(SQL)
                SQL = "SELECT CUSTOMER_ID, CUSTOMER_NAME, CUSTOMER_PHONE FROM CUSTOMERS ORDER BY CUSTOMER_ID"
                Load_Data(SQL)

                MsgBox("Customer is successfully added!", vbInformation, "Customer")
                btn_add.Text = "ADD"
                btn_edit.Visible = True
                btn_cancel.Visible = False
                Get_Cust("SELECT COUNT(CUSTOMER_ID) FROM CUSTOMERS")
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

    Private Sub dgv_customerinfo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_customerinfo.CellClick
        If btn_add.Text = "SAVE" Then
            btn_edit.Visible = True
            btn_cancel.Visible = False
            btn_add.Text = "ADD"
        End If

        Try
            txtbx_customerid.Text = dgv_customerinfo.Rows(e.RowIndex).Cells(0).Value
            txtbx_name.Text = dgv_customerinfo.Rows(e.RowIndex).Cells(1).Value
            txtbx_phonenum.Text = dgv_customerinfo.Rows(e.RowIndex).Cells(2).Value
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
            txtbx_name.Text = ""
            txtbx_phonenum.Text = ""
        Else
            txtbx_customerid.Text = ""
            txtbx_name.Text = ""
            txtbx_phonenum.Text = ""
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Clear()
    End Sub

    Private Sub btn_srt_Click(sender As Object, e As EventArgs) Handles btn_srt.Click
        If btn_srt.Text = "A - Z" Then
            dgv_customerinfo.Sort(dgv_customerinfo.Columns(1), ListSortDirection.Ascending)
            btn_srt.Text = "Z - A"
        Else
            dgv_customerinfo.Sort(dgv_customerinfo.Columns(1), ListSortDirection.Descending)
            btn_srt.Text = "A - Z"
        End If
    End Sub

    <Obsolete>
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        'check if there is selected customer
        If txtbx_customerid.Text = "" And txtbx_name.Text = "" And txtbx_phonenum.Text = "" Then
            MsgBox("Please select customer first", vbExclamation, "Edit Customer Info")
            Exit Sub
        End If

        'check if all fields are not empty
        If txtbx_name.Text = "" Then
            MsgBox("The Name field must not be blank.", vbExclamation, "Last Name")
        Else

            SQL = "UPDATE CUSTOMERS SET CUSTOMER_NAME = '" & txtbx_name.Text & "',  CUSTOMER_PHONE = '" & txtbx_phonenum.Text & "' WHERE CUSTOMER_ID = '" & txtbx_customerid.Text & "'"
            Edit_Record(SQL)
            SQL = "SELECT CUSTOMER_ID, CUSTOMER_NAME, CUSTOMER_PHONE FROM CUSTOMERS ORDER BY CUSTOMER_ID"
            Load_Data(SQL)
            MsgBox("Customer Info is successfully edited!", vbInformation, "Customer Info")
        End If
    End Sub

    <Obsolete>
    Private Sub txtbx_search_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbx_search.KeyUp
        SQL = "SELECT CUSTOMER_ID, CUSTOMER_NAME, CUSTOMER_PHONE FROM CUSTOMERS WHERE LOWER(CUSTOMER_NAME) LIKE LOWER('%" & txtbx_search.Text & "%')"
        Load_Data(SQL)
    End Sub

    <Obsolete>
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If txtbx_search.Text <> "" Then
            SQL = "SELECT CUSTOMER_ID, CUSTOMER_NAME, CUSTOMER_PHONE FROM CUSTOMERS ORDER BY CUSTOMER_ID"
            Load_Data(SQL)
        End If
    End Sub

    Public Sub Cancel_AddCustomer()
        btn_edit.Visible = True
        btn_cancel.Visible = False
        btn_add.Text = ""
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
