Public Class frm_insertcustomer_a195281
    Private Sub frm_insertcustomer_a195281_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_customers.DataSource = run_sql_query("SELECT * FROM tbl_customers_a195281 ORDER BY fld_customer_id")

        grd_customers.Columns(0).HeaderText = "Customer ID"
        grd_customers.Columns(1).HeaderText = "Name"
        grd_customers.Columns(2).HeaderText = "Email"
        grd_customers.Columns(3).HeaderText = "Phone No."
        grd_customers.Columns(4).HeaderText = "Address"

        txt_id.Text = generate_id()

    End Sub

    Private Function generate_id() As String

        Dim lastid As String = run_sql_query("SELECT MAX(fld_customer_id) AS LASTID FROM tbl_customers_a195281").Rows(0).Item("LASTID")

        Dim newid As String = "C" & Mid(lastid, 2) + 1

        Return newid

    End Function

    Private Sub clear_fields()

        txt_id.Text = generate_id()
        txt_name.Text = ""
        txt_email.Text = ""
        txt_phone.Text = ""
        txt_address.Text = ""

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO tbl_customers_a195281 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_email.Text & "', '" & txt_phone.Text & "', '" & txt_address.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            Beep()
            MsgBox("You have successfully inserted the customer with ID """ & txt_id.Text & """.")

            clear_fields()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            clear_fields()

            mywriter.Connection.Close()

        End Try

        grd_customers.DataSource = run_sql_query("SELECT * FROM tbl_customers_a195281 ORDER BY fld_customer_id")

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a195281.Show()
        Me.Close()
    End Sub

End Class