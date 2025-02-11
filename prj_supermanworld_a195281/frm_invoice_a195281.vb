Public Class frm_invoice_a195281

    Private Sub frm_invoice_a195281_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_order_id.DataSource = run_sql_query("SELECT fld_order_id FROM tbl_orders_a195281 ORDER BY fld_order_id")
        cmb_order_id.DisplayMember = "fld_order_id"
        If PassedOrderId IsNot Nothing Then
            cmb_order_id.SelectedValue = PassedOrderId
        End If

    End Sub

    Private Sub ChangeLabel()
        lbl_order_date.Text = run_sql_query("SELECT fld_order_date FROM tbl_orders_a195281 WHERE fld_order_id = '" & cmb_order_id.Text & "'").Rows(0).Item("fld_order_date")
        Dim mysql As String = "SELECT c.* FROM tbl_customers_a195281 c INNER JOIN tbl_orders_a195281 o ON c.fld_customer_id = o.fld_customer_id WHERE o.fld_order_id = '" & cmb_order_id.Text & "'"
        Dim mysql2 As String = "SELECT s.* FROM tbl_staff_a195281 s INNER JOIN tbl_orders_a195281 o ON s.fld_staff_id = o.fld_staff_id WHERE o.fld_order_id = '" & cmb_order_id.Text & "'"

        Dim mydatatable As New DataTable
        Dim mydatatable2 As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)

        myreader.Fill(mydatatable)
        myreader2.Fill(mydatatable2)

        lbl_customer_name.Text = mydatatable.Rows(0).Item("fld_customer_name")
        lbl_customer_email.Text = mydatatable.Rows(0).Item("fld_customer_email")
        lbl_customer_phone.Text = mydatatable.Rows(0).Item("fld_customer_phone_no")
        lbl_customer_address.Text = mydatatable.Rows(0).Item("fld_customer_address")

        lbl_staff_name.Text = mydatatable2.Rows(0).Item("fld_staff_name")
        lbl_staff_email.Text = mydatatable2.Rows(0).Item("fld_staff_email")
        lbl_staff_phone.Text = mydatatable2.Rows(0).Item("fld_staff_phone_no")
    End Sub

    Private Sub ChangeTable()
        Dim total As Integer = 0
        Dim subtotal As Integer = 0
        Dim mysql As String = "SELECT fld_product_id, fld_product_name, fld_unit_price, fld_quantity FROM tbl_order_details_a195281 WHERE fld_order_id ='" & cmb_order_id.Text & "'"
        Dim dataTable As DataTable = run_sql_query(mysql)
        dataTable.Columns.Add(New DataColumn("Subtotal", GetType(Integer)))

        grd_orders.DataSource = dataTable
        grd_orders.Columns(0).HeaderText = "Product ID"
        grd_orders.Columns(1).HeaderText = "Product Name"
        grd_orders.Columns(2).HeaderText = "Unit Price(RM)"
        grd_orders.Columns(3).HeaderText = "Quantity"
        grd_orders.Columns(4).HeaderText = "Subtotal(RM)"

        Dim current_row As Integer = grd_orders.RowCount - 1
        For i As Integer = 0 To current_row
            Dim unit_price As Integer = grd_orders(2, i).Value
            Dim quantity As Integer = grd_orders(3, i).Value
            subtotal = unit_price * quantity
            total += unit_price * quantity
            grd_orders(4, i).Value = subtotal
        Next

        lbl_total.Text = total.ToString()

    End Sub

    Private Sub cmb_order_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_order_id.SelectedIndexChanged

        Try
            ChangeLabel()
            ChangeTable()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a195281.Show()
        Me.Close()
    End Sub
End Class