Imports System.ComponentModel
Imports System.Data.OracleClient
Public Class Order_Management
    <Obsolete>
    Dim Conn As OracleConnection            'Connection Variable
    <Obsolete>
    Dim DataAdapter As OracleDataAdapter    'Adapter for GridView
    <Obsolete>
    Dim DataTable As DataTable              'Record Set

    Dim SQL As String

    <Obsolete>
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Home.lbl_username.Text = lbl_username.Text
        Home.Show()
        Conn.Close()
        Me.Close()
    End Sub

    <Obsolete>
    Private Sub btn_createnew_Click(sender As Object, e As EventArgs) Handles btn_createnew.Click
        CreateNewOrder.lbl_username.Text = lbl_username.Text
        CreateNewOrder.Show()
        Conn.Close()
        Me.Close()
    End Sub

    <Obsolete>
    Private Sub Order_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = New OracleConnection("Data Source=localhost:1521/orcl;User ID=c##ITE3;Password=elective3;Unicode=True")
        Conn.Open()
        SQL = "SELECT O.ORDER_ID, O.CUSTOMER_ID, C.CUSTOMER_NAME, O.TOTAL_AMOUNT, O.ORDER_DATE FROM ORDERS O JOIN CUSTOMERS C ON O.CUSTOMER_ID = C.CUSTOMER_ID ORDER BY ORDER_DATE DESC"
        Load_Data(SQL)
    End Sub

    <Obsolete>
    Private Sub Load_Data(query As String)
        DataAdapter = New OracleDataAdapter(query, Conn)
        DataTable = New DataTable
        DataAdapter.Fill(DataTable)
        dgv_order.DataSource = DataTable
        dgv_order.Columns(1).Visible = False
    End Sub

    Private Sub btn_srt_Click(sender As Object, e As EventArgs) Handles btn_srt.Click
        ' OLD = ASC
        ' RECENT = DESC
        If btn_srt.Text = "OLD" Then
            dgv_order.Sort(dgv_order.Columns(4), ListSortDirection.Ascending)
            btn_srt.Text = "RECENT"
        Else
            dgv_order.Sort(dgv_order.Columns(4), ListSortDirection.Descending)
            btn_srt.Text = "OLD"
        End If
    End Sub

    <Obsolete>
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If txtbx_search.Text <> "" Then
            SQL = "SELECT O.ORDER_ID, O.CUSTOMER_ID, C.CUSTOMER_NAME, O.TOTAL_AMOUNT, O.ORDER_DATE FROM ORDERS O JOIN CUSTOMERS C ON O.CUSTOMER_ID = C.CUSTOMER_ID WHERE ORDER_ID LIKE '%" & txtbx_search.Text & "%' OR LOWER(C.CUSTOMER_NAME) LIKE LOWER('%" & txtbx_search.Text & "%') OR TOTAL_AMOUNT LIKE '%" & txtbx_search.Text & "%' OR ORDER_DATE LIKE '%" & txtbx_search.Text & "%' ORDER BY ORDER_DATE DESC"
            Load_Data(SQL)
        End If
    End Sub

    <Obsolete>
    Private Sub txtbx_search_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbx_search.KeyUp
        SQL = "SELECT O.ORDER_ID, O.CUSTOMER_ID, C.CUSTOMER_NAME, O.TOTAL_AMOUNT, O.ORDER_DATE FROM ORDERS O JOIN CUSTOMERS C ON O.CUSTOMER_ID = C.CUSTOMER_ID WHERE ORDER_ID LIKE '%" & txtbx_search.Text & "%' OR LOWER(C.CUSTOMER_NAME) LIKE LOWER('%" & txtbx_search.Text & "%') OR TOTAL_AMOUNT LIKE '%" & txtbx_search.Text & "%' OR TO_CHAR(ORDER_DATE, 'DD/MM/yyyy') LIKE '%" & txtbx_search.Text & "%' ORDER BY ORDER_DATE DESC"
        Load_Data(SQL)
    End Sub

End Class