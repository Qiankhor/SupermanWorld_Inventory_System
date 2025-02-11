Public Class frm_productlist_a195281

    Dim picturepath As String = Application.StartupPath & "\pictures\noimage.jpg"

    Private Sub frm_productlist_a195281_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        lst_id.DataSource = run_sql_query("SELECT fld_product_id FROM tbl_products_a195281 ORDER BY fld_product_id")
        lst_id.DisplayMember = "fld_product_id"

        refresh_text(lst_id.Text)

        grd_products.DataSource = run_sql_query("SELECT * FROM tbl_products_a195281 ORDER BY fld_product_id")

        grd_products.Columns(0).HeaderText = "Product ID"
        grd_products.Columns(1).HeaderText = "Name"
        grd_products.Columns(2).HeaderText = "Price"
        grd_products.Columns(3).HeaderText = "Brand"
        grd_products.Columns(4).HeaderText = "Type"
        grd_products.Columns(5).HeaderText = "Release Date"
        grd_products.Columns(6).HeaderText = "Stock"
        grd_products.Columns(7).HeaderText = "Description"

    End Sub

    Private Sub refresh_text(id As String)

        Dim mysql As String = "SELECT * FROM tbl_products_a195281 WHERE fld_product_id='" & id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        Try

            txt_id.Text = mydatatable.Rows(0).Item("fld_product_id")
            txt_name.Text = mydatatable.Rows(0).Item("fld_product_name")
            txt_price.Text = mydatatable.Rows(0).Item("fld_price")
            txt_brand.Text = mydatatable.Rows(0).Item("fld_brand")
            txt_type.Text = mydatatable.Rows(0).Item("fld_type")
            txt_releasedate.Text = mydatatable.Rows(0).Item("fld_release_date")
            txt_quantity.Text = mydatatable.Rows(0).Item("fld_quantity")
            txt_description.Text = mydatatable.Rows(0).Item("fld_description")
            picturepath = Application.StartupPath & "\pictures\" & id & ".jpg"

            pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")

        Catch ex As Exception

            Beep()
            MsgBox("Something wrong: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    Private Sub lst_id_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_id.MouseClick

        refresh_text(lst_id.Text)

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a195281.Show()
        Me.Close()
    End Sub

End Class