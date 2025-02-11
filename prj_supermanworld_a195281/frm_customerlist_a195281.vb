Public Class frm_customerlist_a195281
    Private Sub frm_customerlist_a195281_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_customers.DataSource = run_sql_query("SELECT * FROM tbl_customers_a195281 ORDER BY fld_customer_id")

        grd_customers.Columns(0).HeaderText = "Customer ID"
        grd_customers.Columns(1).HeaderText = "Name"
        grd_customers.Columns(2).HeaderText = "Email"
        grd_customers.Columns(3).HeaderText = "Phone No."
        grd_customers.Columns(4).HeaderText = "Address"


    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a195281.Show()
        Me.Close()
    End Sub

End Class