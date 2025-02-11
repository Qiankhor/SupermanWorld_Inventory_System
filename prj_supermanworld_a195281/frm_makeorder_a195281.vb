Public Class frm_makeorder_a195281

    Dim picturepath As String = Application.StartupPath & "\pictures\noimage.jpg"

    Dim quantity As Integer
    Dim price As Integer
    Dim subtotal As Integer

    Dim current_row As Integer

    Dim orderingStarted As Boolean = False
    Dim addorderStarted As Boolean = False
    Dim checkoutStarted As Boolean = False

    Private Sub frm_makeorder_a195281_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        grd_neworder.ColumnCount = grd_order.ColumnCount

        For i = 0 To (grd_neworder.ColumnCount - 1)
            grd_neworder.Columns(i).HeaderText = grd_order.Columns(i).HeaderText
        Next

        cmb_customerID.DataSource = run_sql_query("SELECT fld_customer_id FROM tbl_customers_a195281 ORDER BY fld_customer_id")
        cmb_customerID.DisplayMember = "fld_customer_id"

        cmb_staffID.DataSource = run_sql_query("SELECT fld_staff_id FROM tbl_staff_a195281 ORDER BY fld_staff_id")
        cmb_staffID.DisplayMember = "fld_staff_id"

        If txt_orderquantity.Value = 0 Then
            txt_orderquantity.Value = 1
        End If

    End Sub

    Private Sub refresh_grid()

        txt_orderID.Text = generate_id()

        lst_id.DataSource = run_sql_query("SELECT fld_product_id FROM tbl_products_a195281 ORDER BY fld_product_id")
        lst_id.DisplayMember = "fld_product_id"

        refresh_text(lst_id.Text)

        Dim mysql As String = "SELECT fld_product_id, fld_product_name, fld_unit_price, fld_quantity FROM tbl_order_details_a195281 WHERE fld_order_id ='" & txt_orderID.Text & "'"
        Dim dataTable As DataTable = run_sql_query(mysql)
        dataTable.Columns.Add(New DataColumn("Subtotal", GetType(Integer)))

        grd_order.DataSource = dataTable
        grd_order.Columns(0).HeaderText = "Product ID"
        grd_order.Columns(1).HeaderText = "Product Name"
        grd_order.Columns(2).HeaderText = "Unit Price"
        grd_order.Columns(3).HeaderText = "Quantity"
        grd_order.Columns(4).HeaderText = "Subtotal(RM)"

    End Sub

    Private Sub refresh_text(id As String)

        Dim mysql As String = "SELECT * FROM tbl_products_a195281 WHERE fld_product_id='" & id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_id.Text = mydatatable.Rows(0).Item("fld_product_id")
        txt_productID.Text = mydatatable.Rows(0).Item("fld_product_id")
        txt_name.Text = mydatatable.Rows(0).Item("fld_product_name")
        txt_price.Text = mydatatable.Rows(0).Item("fld_price")
        txt_brand.Text = mydatatable.Rows(0).Item("fld_brand")
        txt_type.Text = mydatatable.Rows(0).Item("fld_type")
        txt_releasedate.Text = mydatatable.Rows(0).Item("fld_release_date")
        txt_quantity.Text = mydatatable.Rows(0).Item("fld_quantity")
        txt_description.Text = mydatatable.Rows(0).Item("fld_description")
        picturepath = Application.StartupPath & "\pictures\" & id & ".jpg"

        pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")

        CalculateSubtotal()

        txt_orderquantity.Value = 1

    End Sub

    Private Function generate_id() As String

        Dim lastid As String

        lastid = run_sql_query("SELECT MAX(fld_order_id) AS LASTID FROM tbl_orders_a195281").Rows(0).Item("LASTID")
        Dim numericPart As Integer = Convert.ToInt32(Mid(lastid, 3)) + 1
        Dim newid As String = "PO" & numericPart.ToString("00000")
        Return newid

    End Function

    Private Sub lst_id_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_id.MouseClick

        refresh_text(lst_id.Text)

    End Sub

    Private Sub btn_addorder_Click(sender As Object, e As EventArgs) Handles btn_addorder.Click

        If orderingStarted Then
            Try

                grd_neworder.RowCount = grd_neworder.RowCount + 1

                current_row = grd_neworder.RowCount - 1

                'grd_neworder(0, current_row).Value = txt_orderID.Text
                grd_neworder(0, current_row).Value = txt_productID.Text
                grd_neworder(1, current_row).Value = txt_name.Text
                grd_neworder(2, current_row).Value = txt_price.Text
                grd_neworder(3, current_row).Value = txt_orderquantity.Value.ToString()
                grd_neworder(4, current_row).Value = lbl_subtotal.Text

                txt_orderquantity.Value = 1
                CalculateOrderTotal()

            Catch ex As Exception

                Beep()
                MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            End Try
        Else
            MsgBox("Please fill in the order information and click the 'Start Ordering' button before adding items to the order.")
        End If

        addorderStarted = True

    End Sub

    Private Sub txt_orderquantity_ValueChanged(sender As Object, e As EventArgs) Handles txt_orderquantity.ValueChanged

        If txt_orderquantity.Value = 0 Then
            txt_orderquantity.Value = 1
        End If

        CalculateSubtotal()
    End Sub

    Private Sub CalculateSubtotal()

        Integer.TryParse(txt_price.Text, price)
        Integer.TryParse(txt_orderquantity.Value.ToString(), quantity)

        subtotal = quantity * price

        lbl_subtotal.Text = subtotal.ToString()

    End Sub

    Private Sub CalculateOrderTotal()
        Dim total As Integer = 0
        current_row = grd_neworder.RowCount - 1

        For i As Integer = 0 To current_row
            Dim unit_price As Integer = grd_neworder(2, i).Value
            Dim quantity As Integer = grd_neworder(3, i).Value
            total += quantity * unit_price
        Next

        lbl_ordertotal.Text = total.ToString()

    End Sub

    Private Sub CalculateTotal()

        Dim total As Integer = 0
        current_row = grd_order.RowCount - 1

        For i As Integer = 0 To current_row
            Dim unit_price As Integer = grd_order(2, i).Value
            Dim quantity As Integer = grd_order(3, i).Value
            total += quantity * unit_price
        Next

        lbl_total.Text = total.ToString()

    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click

        Dim mysql As String = "INSERT INTO tbl_orders_a195281 VALUES ('" & txt_orderID.Text & "', '" & cmb_customerID.Text & "', '" & txt_date.Value.ToString("dd/MM/yyyy") & "', '" & cmb_staffID.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            Beep()
            MsgBox("Your Order ID is """ & txt_orderID.Text & """. You can start ordering now.")

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

        orderingStarted = True

    End Sub

    Private Sub btn_checkout_Click(sender As Object, e As EventArgs) Handles btn_checkout.Click

        If orderingStarted Then

            If addorderStarted Then
                Dim mytransaction As OleDb.OleDbTransaction

                current_row = grd_neworder.RowCount - 1

                Try

                    myconnection2.Open()
                    mytransaction = myconnection2.BeginTransaction

                    For i As Integer = 0 To current_row

                        Dim product_id As String = grd_neworder(0, i).Value
                        Dim product_name As String = grd_neworder(1, i).Value
                        Dim unit_price As String = grd_neworder(2, i).Value
                        Dim quantity As String = grd_neworder(3, i).Value

                        Dim mysql As String = "INSERT INTO tbl_order_details_a195281 VALUES ('" & txt_orderID.Text & "','" & product_id & "', '" & product_name & "', '" & unit_price & "', '" & quantity & "')"

                        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)

                        mywriter.ExecuteNonQuery()

                    Next

                    mytransaction.Commit()
                    myconnection2.Close()

                    Beep()
                    MsgBox("Transaction Successful")

                    Dim mysql2 As String = "SELECT fld_product_id, fld_product_name, fld_unit_price, fld_quantity FROM tbl_order_details_a195281 WHERE fld_order_id ='" & txt_orderID.Text & "'"
                    Dim dataTable As DataTable = run_sql_query(mysql2)
                    dataTable.Columns.Add(New DataColumn("Subtotal", GetType(Integer)))

                    grd_order.DataSource = dataTable
                    grd_order.Columns(0).HeaderText = "Product ID"
                    grd_order.Columns(1).HeaderText = "Product Name"
                    grd_order.Columns(2).HeaderText = "Unit Price"
                    grd_order.Columns(3).HeaderText = "Quantity"
                    grd_order.Columns(4).HeaderText = "Subtotal(RM)"

                    Dim current_row2 As Integer = grd_order.RowCount - 1
                    For i As Integer = 0 To current_row2
                        Dim unit_price As Integer = grd_order(2, i).Value
                        Dim quantity As Integer = grd_order(3, i).Value
                        Dim sub_total As Integer = unit_price * quantity
                        grd_order(4, i).Value = sub_total
                    Next
                    grd_neworder.Rows.Clear()

                    CalculateTotal()

                Catch ex As Exception

                    Beep()
                    MsgBox("Problem with transaction: " & vbCrLf & vbCrLf & ex.Message)

                    mytransaction.Rollback()
                    myconnection2.Close()

                End Try
            Else
                MsgBox("Please make order before check out.")
            End If
        Else
            MsgBox("Please fill in the order information and click the 'Start Ordering' button before check out.")
        End If

        checkoutStarted = True

    End Sub


    Private Sub grd_neworder_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles grd_neworder.RowsRemoved
        CalculateOrderTotal()
    End Sub


    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        If orderingStarted Then
            If addorderStarted Then
                If checkoutStarted Then
                    Dim delete_confirmation = MsgBox("Are you sure you would like to generate invoice for order with ID """ & txt_orderID.Text & """?", MsgBoxStyle.YesNo)
                    If delete_confirmation = MsgBoxResult.Yes Then
                        PassedOrderId = txt_orderID.Text
                        frm_invoice_a195281.Show()
                        Me.Close()
                    End If

                Else
                    MsgBox("Please check out order before generating invoice. ")
                End If

            Else
                MsgBox("Please make order before generating invoice.")
            End If

        Else
            MsgBox("Please fill in the order information and click the 'Start Ordering' button before generating invoice.")
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a195281.Show()
        Me.Close()
    End Sub
End Class