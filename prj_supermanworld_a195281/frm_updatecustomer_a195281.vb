Public Class frm_updatecustomer_a195281

    Dim current_id As String

    Private Sub frm_updatecustomer_a195281_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_customers.DataSource = run_sql_query("SELECT * FROM tbl_customers_a195281 ORDER BY fld_customer_id")

        grd_customers.Columns(0).HeaderText = "Customer ID"
        grd_customers.Columns(1).HeaderText = "Name"
        grd_customers.Columns(2).HeaderText = "Email"
        grd_customers.Columns(3).HeaderText = "Phone No."
        grd_customers.Columns(4).HeaderText = "Address"

    End Sub

    Private Sub get_current_id()

        Dim current_row As Integer = grd_customers.CurrentRow.Index

        current_id = grd_customers(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_customers(1, current_row).Value
        txt_email.Text = grd_customers(2, current_row).Value
        txt_phone.Text = grd_customers(3, current_row).Value
        txt_address.Text = grd_customers(4, current_row).Value

    End Sub

    Private Sub clear_fields()

        txt_id.Clear()
        txt_name.Clear()
        txt_email.Clear()
        txt_phone.Clear()
        txt_address.Clear()

    End Sub

    Private Sub grd_customers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customers.CellClick

        get_current_id()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        Try
            run_sql_command("UPDATE tbl_customers_a195281 SET fld_customer_name = '" & txt_name.Text & "', fld_customer_email = '" & txt_email.Text & "', fld_customer_phone_no = '" & txt_phone.Text & "', fld_customer_address = '" & txt_address.Text & "' WHERE fld_customer_id = '" & current_id & "'")

            Beep()
            MsgBox("You have successfully updated the customer with ID """ & current_id & """.")

            grd_customers.DataSource = run_sql_query("SELECT * FROM tbl_customers_a195281 ORDER BY fld_customer_id")
            clear_fields()
            get_current_id()

        Catch ex As Exception

            Beep()
            MsgBox("Problem with updating customer data : " & vbCrLf & vbCrLf & ex.Message)

        End Try



    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the customer with ID """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM tbl_customers_a195281 WHERE fld_customer_id = '" & current_id & "'")

            Beep()
            MsgBox("The customer with ID """ & current_id & """ has been successfully deleted.")

            grd_customers.DataSource = run_sql_query("SELECT * FROM tbl_customers_a195281 ORDER BY fld_customer_id")
            clear_fields()
            get_current_id()

        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a195281.Show()
        Me.Close()
    End Sub

End Class