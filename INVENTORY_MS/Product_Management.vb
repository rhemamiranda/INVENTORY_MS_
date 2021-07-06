Imports System.ComponentModel
Imports System.Data.OracleClient
Public Class Product_Management
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
    Private Sub Product_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New OracleConnection("Data Source=localhost:1521/orcl;User ID=c##ITE3;Password=elective3;Unicode=True")
        Conn.Open()
        SQL = "SELECT PRODUCT_ID, PRODUCT_NAME, PRODUCT_DESCRIPTION, C.CATEGORY_NAME, QUANTITY, PRICE FROM PRODUCTS P JOIN CATEGORIES C ON P.CATEGORY_ID = C.CATEGORY_ID ORDER BY PRODUCT_ID"
        Load_Data(SQL)
        SQL = "SELECT CATEGORY_NAME FROM CATEGORIES"
        Load_Categories(SQL)
    End Sub

    <Obsolete>
    Private Sub Load_Data(query As String)
        DataAdapter = New OracleDataAdapter(query, Conn)
        DataTable = New DataTable
        DataAdapter.Fill(DataTable)
        dgv_product.DataSource = DataTable
        'dgv_product.Columns(0).Visible = False
    End Sub

    <Obsolete>
    Private Sub Load_Categories(query As String)
        OrclCommand = Conn.CreateCommand
        OrclCommand.CommandText = query
        DataReader = OrclCommand.ExecuteReader
        While DataReader.Read
            cmbbx_category.Items.Add(DataReader.Item("CATEGORY_NAME"))
        End While
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
    Private Function Get_ProdCategory(query As String, cat As String)
        OrclCommand = Conn.CreateCommand
        OrclCommand.CommandText = query
        DataReader = OrclCommand.ExecuteReader
        Dim catID As Integer
        Dim count As Integer
        While DataReader.Read
            If String.Compare(DataReader.Item("CATEGORY_NAME"), cat) = 0 Then
                catID = DataReader.Item("CATEGORY_ID")
                Exit While
            End If
            count = count + 1
        End While
        If catID = 0 Then
            catID = count + 1
            SQL = "INSERT INTO CATEGORIES (CATEGORY_ID, CATEGORY_NAME) VALUES('" & catID & "', '" & cat & "')"
            Edit_Record(SQL)
            SQL = "SELECT CATEGORY_NAME FROM CATEGORIES"
            Load_Categories(SQL)
        End If
        Return catID
    End Function

    Public Sub Cancel_AddProduct()
        btn_edit.Visible = True
        btn_cancel.Visible = False
        btn_add.Text = "NEW"
    End Sub

    Public Sub Clear()
        If btn_add.Text = "SAVE" Then
            txtbx_prodname.Text = ""
            txtbx_description.Text = ""
            cmbbx_category.Text = ""
            txtbx_quantity.Text = ""
            txtbx_price.Text = ""
        Else
            txtbx_productid.Text = ""
            txtbx_prodname.Text = ""
            txtbx_description.Text = ""
            cmbbx_category.Text = ""
            txtbx_quantity.Text = ""
            txtbx_price.Text = ""
        End If
    End Sub

    Private Sub dgv_product_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_product.CellClick
        If btn_add.Text = "SAVE" Then
            btn_edit.Visible = True
            btn_cancel.Visible = False
            btn_add.Text = "NEW"
        End If
        Try
            txtbx_productid.Text = dgv_product.Rows(e.RowIndex).Cells(0).Value
            txtbx_prodname.Text = dgv_product.Rows(e.RowIndex).Cells(1).Value
            txtbx_description.Text = dgv_product.Rows(e.RowIndex).Cells(2).Value
            cmbbx_category.Text = dgv_product.Rows(e.RowIndex).Cells(3).Value
            txtbx_quantity.Text = dgv_product.Rows(e.RowIndex).Cells(4).Value
            txtbx_price.Text = dgv_product.Rows(e.RowIndex).Cells(5).Value
        Catch ex As Exception
        End Try
    End Sub

    <Obsolete>
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If btn_add.Text = "ADD" Then
            txtbx_productid.Text = Get_LastID("SELECT PRODUCT_ID FROM PRODUCTS ORDER BY PRODUCT_ID", "PRODUCT_ID")
            txtbx_prodname.Text = ""
            txtbx_description.Text = ""
            cmbbx_category.Text = ""
            txtbx_quantity.Text = ""
            txtbx_price.Text = ""
            btn_add.Text = "SAVE"
            btn_cancel.Visible = True
            btn_edit.Visible = False
        Else
            'Check if all fields are not empty
            If txtbx_prodname.Text = "" Then
                MsgBox("The Product Name field must not be blank.", vbExclamation, "Product Name")
            ElseIf txtbx_description.Text = "" Then
                MsgBox("The Product Description field must not be blank.", vbExclamation, "Product Description")
            ElseIf cmbbx_category.Text = "" Then
                MsgBox("The Product Category field must not be blank.", vbExclamation, "Product Category")
            ElseIf txtbx_quantity.Text = "" Then
                MsgBox("The Quantity field must not be blank.", vbExclamation, "Quantity")
            ElseIf txtbx_price.Text = "" Then
                MsgBox("The Price field must not be blank.", vbExclamation, "Price")
            Else
                Dim cat As Integer = Get_ProdCategory("SELECT * FROM CATEGORIES", cmbbx_category.Text)
                SQL = "INSERT INTO PRODUCTS (PRODUCT_ID, PRODUCT_NAME, PRODUCT_DESCRIPTION, CATEGORY_ID, QUANTITY, PRICE) VALUES('" & txtbx_productid.Text & "', '" & txtbx_prodname.Text & "', '" & txtbx_description.Text & "', '" & cat & "', '" & txtbx_quantity.Text & "', '" & txtbx_price.Text & "')"
                Edit_Record(SQL)
                SQL = "SELECT PRODUCT_ID, PRODUCT_NAME, PRODUCT_DESCRIPTION, C.CATEGORY_NAME, QUANTITY, PRICE FROM PRODUCTS P JOIN CATEGORIES C ON P.CATEGORY_ID = C.CATEGORY_ID ORDER BY PRODUCT_ID"
                Load_Data(SQL)
                MsgBox("Product is successfully added!", vbInformation, "Product")
                btn_add.Text = "NEW"
                btn_edit.Visible = True
                btn_cancel.Visible = False
            End If
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        btn_edit.Visible = True
        btn_cancel.Visible = False
        btn_add.Text = "NEW"
        Clear()
    End Sub

    <Obsolete>
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        'check if there is selected product
        If txtbx_productid.Text = "" And txtbx_prodname.Text = "" And txtbx_description.Text = "" And txtbx_quantity.Text = "" And txtbx_price.Text = "" And cmbbx_category.Text = "" Then
            MsgBox("Please select product first", vbExclamation, "Edit Product")
            Exit Sub
        End If

        'check if all fields are not empty
        If txtbx_prodname.Text = "" Then
            MsgBox("The Product Name field must not be blank.", vbExclamation, "Product Name")
        ElseIf txtbx_description.Text = "" Then
            MsgBox("The Product Description field must not be blank.", vbExclamation, "Product Description")
        ElseIf cmbbx_category.Text = "" Then
            MsgBox("The Product Category field must not be blank.", vbExclamation, "Product Category")
        ElseIf txtbx_quantity.Text = "" Then
            MsgBox("The Quantity field must not be blank.", vbExclamation, "Quantity")
        ElseIf txtbx_price.Text = "" Then
            MsgBox("The Price field must not be blank.", vbExclamation, "Price")
        Else
            Dim cat As Integer = Get_ProdCategory("SELECT * FROM CATEGORIES", cmbbx_category.Text)
            SQL = "UPDATE PRODUCTS SET PRODUCT_NAME = '" & txtbx_prodname.Text & "', PRODUCT_DESCRIPTION = '" & txtbx_description.Text & "', CATEGORY_ID = '" & cat & "', QUANTITY = '" & txtbx_quantity.Text & "', PRICE = '" & txtbx_price.Text & "' WHERE PRODUCT_ID = '" & txtbx_productid.Text & "'"
            Edit_Record(SQL)
            SQL = "SELECT PRODUCT_ID, PRODUCT_NAME, PRODUCT_DESCRIPTION, C.CATEGORY_NAME, QUANTITY, PRICE FROM PRODUCTS P JOIN CATEGORIES C ON P.CATEGORY_ID = C.CATEGORY_ID ORDER BY PRODUCT_ID"
            Load_Data(SQL)
            MsgBox("Product is successfully edited!", vbInformation, "Product")
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Clear()
    End Sub

    Private Sub btn_srt_Click(sender As Object, e As EventArgs) Handles btn_srt.Click
        If btn_srt.Text = "A - Z" Then
            dgv_product.Sort(dgv_product.Columns(1), ListSortDirection.Ascending)
            btn_srt.Text = "Z - A"
        Else
            dgv_product.Sort(dgv_product.Columns(1), ListSortDirection.Descending)
            btn_srt.Text = "A - Z"
        End If
    End Sub

    <Obsolete>
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        'for product name only
        'SQL = "SELECT PRODUCT_ID, PRODUCT_NAME, PRODUCT_DESCRIPTION, C.CATEGORY_NAME As CATEGORY, QUANTITY, PRICE FROM PRODUCTS P JOIN CATEGORIES C ON P.CATEGORY_ID = C.CATEGORY_ID WHERE LOWER(PRODUCT_NAME) LIKE LOWER('%" & txtbx_search.Text & "%')"

        'for all fields
        If txtbx_search.Text <> "" Then
            SQL = "SELECT PRODUCT_ID, PRODUCT_NAME, PRODUCT_DESCRIPTION, C.CATEGORY_NAME, QUANTITY, PRICE FROM PRODUCTS P JOIN CATEGORIES C ON P.CATEGORY_ID = C.CATEGORY_ID ORDER BY PRODUCT_ID"
            Load_Data(SQL)
        End If

    End Sub

    <Obsolete>
    Private Sub txtbx_search_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbx_search.KeyUp
        SQL = "SELECT PRODUCT_ID, PRODUCT_NAME, PRODUCT_DESCRIPTION, C.CATEGORY_NAME AS CATEGORY, QUANTITY, PRICE FROM PRODUCTS P JOIN CATEGORIES C ON P.CATEGORY_ID = C.CATEGORY_ID WHERE LOWER(PRODUCT_NAME) LIKE LOWER('%" & txtbx_search.Text & "%') OR LOWER(PRODUCT_DESCRIPTION) LIKE LOWER('%" & txtbx_search.Text & "%') OR LOWER(C.CATEGORY_NAME) LIKE LOWER('%" & txtbx_search.Text & "%') OR QUANTITY LIKE '%" & txtbx_search.Text & "%' OR PRICE LIKE '%" & txtbx_search.Text & "%'"
        Load_Data(SQL)
    End Sub

End Class