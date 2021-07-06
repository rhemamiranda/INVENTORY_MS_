Imports System.ComponentModel
Imports System.Data.OracleClient
Imports System.Globalization

Public Class CreateNewOrder
    <Obsolete>
    Dim Conn As OracleConnection            'Connection Variable
    <Obsolete>
    Dim OrclCommand As OracleCommand        'Oracle SQL Execution
    <Obsolete>
    Dim DataReader As OracleDataReader      'Read RecordS

    Dim SQL As String
    Dim Item As Integer = 0
    Dim Total As Decimal = 0
    Dim Amount As Decimal = 0

    <Obsolete>
    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Home.lbl_username.Text = lbl_username.Text
        Home.Show()
        Conn.Close()
        Me.Close()
    End Sub

    <Obsolete>
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Order_Management.lbl_username.Text = lbl_username.Text
        Order_Management.Show()
        Conn.Close()
        Me.Close()
    End Sub

    <Obsolete>
    Private Sub CreateNewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New OracleConnection("Data Source=localhost:1521/orcl;User ID=c##ITE3;Password=elective3;Unicode=True")
        Conn.Open()

        SQL = "SELECT PRODUCT_ID FROM PRODUCTS ORDER BY PRODUCT_ID"
        Load_Items(SQL, "PRODUCT_ID")

        SQL = "SELECT PRODUCT_NAME FROM PRODUCTS ORDER BY PRODUCT_NAME"
        Load_Items(SQL, "PRODUCT_NAME")

        SQL = "SELECT CUSTOMER_ID FROM CUSTOMERS ORDER BY CUSTOMER_ID"
        Load_Items(SQL, "CUSTOMER_ID")

        SQL = "SELECT CUSTOMER_NAME FROM CUSTOMERS ORDER BY CUSTOMER_NAME"
        Load_Items(SQL, "CUSTOMER_NAME")

        txtbx_orderid.Text = Get_LastID("SELECT ORDER_ID FROM ORDERS ORDER BY ORDER_ID", "ORDER_ID")
        num_quantity.Value = 0
    End Sub

    <Obsolete>
    Private Sub cmbbx_customerid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbx_customerid.SelectedIndexChanged
        SQL = "SELECT CUSTOMER_ID, CUSTOMER_NAME FROM CUSTOMERS WHERE CUSTOMER_ID = " & cmbbx_customerid.Text & ""
        Select_Customer(SQL)
    End Sub

    <Obsolete>
    Private Sub cmbbx_customername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbx_customername.SelectedIndexChanged
        SQL = "SELECT CUSTOMER_ID, CUSTOMER_NAME FROM CUSTOMERS WHERE CUSTOMER_NAME = '" & cmbbx_customername.Text & "'"
        Select_Customer(SQL)
    End Sub

    <Obsolete>
    Private Sub cmbbx_prodid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbx_prodid.SelectedIndexChanged
        If cmbbx_prodid.Focused Then
            SQL = "SELECT PRODUCT_ID, PRODUCT_NAME FROM PRODUCTS WHERE PRODUCT_ID = " & cmbbx_prodid.Text & ""
            Select_Product(SQL)
        End If
    End Sub

    <Obsolete>
    Private Sub cmbbx_prodid_Leave(sender As Object, e As EventArgs) Handles cmbbx_prodid.Leave
        If cmbbx_prodname.Focused = False Then
            SQL = "SELECT PRODUCT_ID, PRODUCT_NAME FROM PRODUCTS WHERE PRODUCT_ID = " & cmbbx_prodid.Text & ""
            Select_Product(SQL)
        End If
    End Sub

    <Obsolete>
    Private Sub cmbbx_prodname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbx_prodname.SelectedIndexChanged
        If cmbbx_prodname.Focused Then
            SQL = "SELECT PRODUCT_ID, PRODUCT_NAME FROM PRODUCTS WHERE PRODUCT_NAME = '" & cmbbx_prodname.Text & "'"
            Select_Product(SQL)
        End If

    End Sub

    <Obsolete>
    Private Sub cmbbx_prodname_Leave(sender As Object, e As EventArgs) Handles cmbbx_prodname.Leave
        If cmbbx_prodid.Focused = False Then
            SQL = "SELECT PRODUCT_ID, PRODUCT_NAME FROM PRODUCTS WHERE PRODUCT_NAME = '" & cmbbx_prodname.Text & "'"
            Select_Product(SQL)
        End If
    End Sub

    <Obsolete>
    Private Sub btn_addbill_Click(sender As Object, e As EventArgs) Handles btn_addbill.Click
        Dim rNum As Integer = Scan_Bill()

        'Check if product and quantity is specified
        If cmbbx_prodid.Text = "" Or cmbbx_prodname.Text = "" Then
            MsgBox("The Product fields must not be blank." & vbCrLf & "Please select a product", vbExclamation, "Product")
        ElseIf num_quantity.Value = "0" Then
            MsgBox("The Quantity field must not be 0." & vbCrLf & "Please enter the quantity", vbExclamation, "Quantity")
        ElseIf rNum > -1 Then
            'If Product already exist in Bill Then Update Quantity, Total, and Amount
            Dim qty As Integer = dgv_bill.Rows.Item(rNum).Cells("Column3").Value
            qty = qty + num_quantity.Value
            If qty > num_quantity.Maximum Then
                MsgBox("Sorry!" & vbCrLf & "We only have " & num_quantity.Maximum & " stocks.", vbExclamation, "Maximum Quantity")
                Exit Sub
            End If
            Total = dgv_bill.Rows.Item(rNum).Cells("Column4").Value 'Unit Price
            Total = Total * qty
            dgv_bill.Rows.Item(rNum).Cells("Column3").Value = qty
            dgv_bill.Rows.Item(rNum).Cells("Column5").Value = Total
            Amount = 0
            For rowIndex = 0 To dgv_bill.RowCount - 1
                Amount = Amount + dgv_bill.Rows(rowIndex).Cells("Column5").Value
            Next
            lbl_amount.Text = Amount
        Else
            Dim rowNumber As Integer = dgv_bill.Rows.Add()
            Dim price = Get_Record("SELECT PRICE FROM PRODUCTS WHERE PRODUCT_ID = " & cmbbx_prodid.Text & "", "PRICE")
            Item = Item + 1
            Total = num_quantity.Value * price
            dgv_bill.Rows.Item(rowNumber).Cells("Column1").Value = Item
            dgv_bill.Rows.Item(rowNumber).Cells("Column2").Value = cmbbx_prodname.Text
            dgv_bill.Rows.Item(rowNumber).Cells("Column3").Value = num_quantity.Value
            dgv_bill.Rows.Item(rowNumber).Cells("Column4").Value = price
            dgv_bill.Rows.Item(rowNumber).Cells("Column5").Value = Total
            dgv_bill.Rows.Item(rowNumber).Cells("Column6").Value = cmbbx_prodid.Text

            'Compute for total amount
            Amount = Amount + Total
            lbl_amount.Text = Amount

            'Clear form
            cmbbx_prodid.Text = ""
            cmbbx_prodname.Text = ""
            num_quantity.Value = 0
        End If
    End Sub

    Private Sub btn_removebill_Click(sender As Object, e As EventArgs) Handles btn_removebill.Click
        'Delete Selected rows
        For Each row As DataGridViewRow In dgv_bill.SelectedRows
            dgv_bill.Rows.Remove(row)
        Next

        'Re-number Item No. & Compute Amount
        Item = 0
        Amount = 0
        For rowIndex = 0 To dgv_bill.RowCount - 1
            Item = Item + 1
            dgv_bill.Rows(rowIndex).Cells("Column1").Value = Item
            Amount = Amount + dgv_bill.Rows(rowIndex).Cells("Column5").Value
        Next

        'Update Amount
        lbl_amount.Text = Amount
    End Sub

    Private Sub btn_clrorder_Click(sender As Object, e As EventArgs) Handles btn_clrorder.Click
        dgv_bill.Rows.Clear()
        'Clear form and 'Update Amount
        cmbbx_prodid.Text = ""
        cmbbx_prodname.Text = ""
        num_quantity.Value = 0
        cmbbx_customerid.Text = ""
        cmbbx_customername.Text = ""
        Amount = 0
        lbl_amount.Text = Amount
    End Sub

    <Obsolete>
    Private Sub btn_confirmorder_Click(sender As Object, e As EventArgs) Handles btn_confirmorder.Click
        'Check if customer is specified & Valid & Bill is not empty
        If cmbbx_customerid.Text = "" Or cmbbx_customername.Text = "" Then
            MsgBox("The Customer fields must not be blank." & vbCrLf & "Please select a customer", vbExclamation, "Customer")
            Exit Sub
        ElseIf Validate_Customer() = False Then
            MsgBox("The Customer fields do not match." & vbCrLf & "Please try selecting one customer", vbCritical, "Customer")
            cmbbx_customerid.Text = ""
            cmbbx_customername.Text = ""
            Exit Sub
        ElseIf dgv_bill.Rows.Count = 0 Then
            MsgBox("The Bill must not be empty." & vbCrLf & "Please add product items first", vbExclamation, "Bill")
            Exit Sub
        Else
            Try
                'Add Order
                Dim OrderDate As Date = Date.Now()
                Dim srtOrderDate As String = OrderDate.ToString("MM/dd/yyyy")
                Console.WriteLine(OrderDate)
                SQL = "INSERT INTO ORDERS (ORDER_ID, CUSTOMER_ID, TOTAL_AMOUNT, ORDER_DATE) VALUES(" & txtbx_orderid.Text & ", " & cmbbx_customerid.Text & ", " & Convert.ToDecimal(lbl_amount.Text) & ", TO_DATE('" & srtOrderDate & "', 'MM/dd/yyyy'))"
                Edit_Record(SQL)

                'Insert Order Items
                Dim OrderID As Integer = txtbx_orderid.Text
                Dim ItemID As Integer
                Dim ProdID As Integer
                Dim Qty As Integer
                Dim ItemPrice As Decimal
                Dim Stock As Integer
                Dim NewQty As Integer

                For rowIndex = 0 To dgv_bill.RowCount - 1
                    ItemID = dgv_bill.Rows(rowIndex).Cells(0).Value
                    ProdID = dgv_bill.Rows(rowIndex).Cells(5).Value
                    Qty = dgv_bill.Rows(rowIndex).Cells(2).Value
                    ItemPrice = dgv_bill.Rows(rowIndex).Cells(3).Value

                    'Get available stock then subtract to get newqty
                    SQL = "Select QUANTITY FROM PRODUCTS WHERE PRODUCT_ID = " & ProdID & ""
                    Stock = Get_Record(SQL, "QUANTITY")
                    NewQty = Stock - Qty

                    'Update stock
                    SQL = "UPDATE PRODUCTS SET QUANTITY = " & NewQty & " WHERE PRODUCT_ID = " & ProdID & ""
                    Edit_Record(SQL)

                    'MsgBox(ItemID & ", " & ProdID & ", " & Qty & ", " & ItemPrice)
                    SQL = "INSERT INTO ORDER_ITEMS (ORDER_ID, ITEM_ID, PRODUCT_ID, QUANTITY, PRICE) VALUES(" & OrderID & ", " & ItemID & ", " & ProdID & ", " & Qty & ", " & ItemPrice & ")"
                    Edit_Record(SQL)
                Next

                MsgBox("Order is successfully added!", vbInformation, "Order")

                'Redirect to Order Management
                Order_Management.lbl_username.Text = lbl_username.Text
                Order_Management.Show()
                Conn.Close()
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Order Process")
            End Try
        End If
    End Sub

    <Obsolete>
    Private Sub Load_Items(query As String, key As String)
        OrclCommand = Conn.CreateCommand
        OrclCommand.CommandText = query
        DataReader = OrclCommand.ExecuteReader
        While DataReader.Read
            If (key = "PRODUCT_ID") Then
                cmbbx_prodid.Items.Add(DataReader.Item(key))
            ElseIf (key = "PRODUCT_NAME") Then
                cmbbx_prodname.Items.Add(DataReader.Item(key))
            ElseIf (key = "CUSTOMER_ID") Then
                cmbbx_customerid.Items.Add(DataReader.Item(key))
            Else
                cmbbx_customername.Items.Add(DataReader.Item(key))
            End If
        End While
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
    Private Sub Select_Product(query As String)
        Try
            OrclCommand = Conn.CreateCommand
            OrclCommand.CommandText = query
            DataReader = OrclCommand.ExecuteReader
            DataReader.Read()
            If DataReader.HasRows = True Then
                Dim values(1) As Object
                Dim numColumns As Integer = DataReader.GetValues(values)
                cmbbx_prodid.Text = Convert.ToString(values(0))
                cmbbx_prodname.Text = Convert.ToString(values(1))
                Set_Max(Convert.ToInt32(cmbbx_prodid.Text))
            Else
                MsgBox("Product does not exist. Please select existing product.", vbCritical, "Product")
                cmbbx_prodid.Text = ""
                cmbbx_prodname.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Product does not exist. Please select valid product.", vbCritical, "Product")
            cmbbx_prodid.Text = ""
            cmbbx_prodname.Text = ""
            'MsgBox(ex.Message)
        End Try
    End Sub

    <Obsolete>
    Private Sub Select_Customer(query As String)
        Try
            OrclCommand = Conn.CreateCommand
            OrclCommand.CommandText = query
            DataReader = OrclCommand.ExecuteReader
            DataReader.Read()
            If DataReader.HasRows = True Then
                Dim values(1) As Object
                Dim numColumns As Integer = DataReader.GetValues(values)
                cmbbx_customerid.Text = Convert.ToString(values(0))
                cmbbx_customername.Text = Convert.ToString(values(1))
            Else
                MsgBox("Customer does not exist. Please select existing customer.", vbCritical, "Customer")
                cmbbx_customerid.Text = ""
                cmbbx_customername.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Customer does not exist. Please select valid customer.", vbCritical, "Customer")
            cmbbx_customerid.Text = ""
            cmbbx_customername.Text = ""
        End Try
    End Sub

    <Obsolete>
    Private Function Get_Record(query As String, key As String)
        OrclCommand = Conn.CreateCommand
        OrclCommand.CommandText = query
        DataReader = OrclCommand.ExecuteReader
        DataReader.Read()
        Return DataReader.Item(key)
    End Function

    <Obsolete>
    Public Sub Edit_Record(query As String)
        OrclCommand = New OracleCommand(query, Conn)
        OrclCommand.ExecuteNonQuery()
    End Sub

    <Obsolete>
    Public Sub Set_Max(id As Integer)
        'Get available stock and Then set max value
        SQL = "SELECT QUANTITY FROM PRODUCTS WHERE PRODUCT_ID = " & id & ""
        Dim stock As Integer = Get_Record(SQL, "QUANTITY")
        num_quantity.Maximum = stock
        If stock = 0 Then
            MsgBox("Sorry! The product is out of stock.", vbExclamation, "Out of Stock")
            Exit Sub
        ElseIf stock > 0 And num_quantity.Value = 0 Then
            num_quantity.Value = 1
            Exit Sub
        ElseIf num_quantity.Value > stock Then
            MsgBox("Sorry! We only have " & num_quantity.Value & " stocks.", vbExclamation, "Maximum Quantity")
            num_quantity.Value = stock
            Exit Sub
        End If
    End Sub

    <Obsolete>
    Private Function Validate_Customer()
        Dim passed As Boolean = True
        SQL = "SELECT CUSTOMER_ID, CUSTOMER_NAME FROM CUSTOMERS WHERE CUSTOMER_NAME = '" & cmbbx_customername.Text & "'"
        Dim ID As Integer = Get_Record(SQL, "CUSTOMER_ID")
        If CInt(cmbbx_customerid.Text) <> ID Then
            passed = False
        End If
        Return passed
    End Function

    <Obsolete>
    Private Function Scan_Bill()
        Dim exist As Integer = -1
        For rowIndex = 0 To dgv_bill.RowCount - 1
            If dgv_bill.Rows(rowIndex).Cells("Column6").Value = cmbbx_prodid.Text Then
                exist = rowIndex
                Exit For
            End If
        Next
        Return exist
    End Function

End Class