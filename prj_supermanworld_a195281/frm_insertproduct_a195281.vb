Public Class frm_insertproduct_a195281

    Dim picturepath As String = Application.StartupPath & "\pictures\noimage.jpg"

    Private Sub frm_insertproduct_a195281_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_products.DataSource = run_sql_query("SELECT * FROM tbl_products_a195281 ORDER BY fld_product_id")

        grd_products.Columns(0).HeaderText = "Product ID"
        grd_products.Columns(1).HeaderText = "Name"
        grd_products.Columns(2).HeaderText = "Price"
        grd_products.Columns(3).HeaderText = "Brand"
        grd_products.Columns(4).HeaderText = "Type"
        grd_products.Columns(5).HeaderText = "Release Date"
        grd_products.Columns(6).HeaderText = "Stock"
        grd_products.Columns(7).HeaderText = "Description"

        pic_product.BackgroundImage = Image.FromFile(Application.StartupPath & "\pictures\noimage.jpg")

        txt_id.Text = generate_id()



    End Sub

    Private Function generate_id() As String

        Dim lastid As String = run_sql_query("SELECT MAX(fld_product_id) AS LASTID FROM tbl_products_a195281").Rows(0).Item("LASTID")

        Dim newid As String = "P" & Mid(lastid, 2) + 1

        Return newid

    End Function

    Private Sub clear_fields()

        txt_id.Text = generate_id()
        txt_name.Text = ""
        txt_price.Text = ""
        txt_brand.Text = ""
        txt_type.Text = ""
        txt_releasedate.Text = ""
        txt_quantity.Text = ""
        txt_description.Text = ""
        pic_product.BackgroundImage = Image.FromFile(Application.StartupPath & "\pictures\noimage.jpg")

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO tbl_products_a195281 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_price.Text & "', '" & txt_brand.Text & "', '" & txt_type.Text & "', '" & txt_releasedate.Text & "', '" & txt_quantity.Text & "', '" & txt_description.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            Beep()
            MsgBox("You have successfully inserted the product with ID """ & txt_id.Text & """.")

            My.Computer.FileSystem.CopyFile(picturepath, "pictures\" & txt_id.Text & ".jpg")

            grd_products.DataSource = run_sql_query("SELECT * FROM tbl_products_a195281 ORDER BY fld_product_id")

            clear_fields()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            clear_fields()

            mywriter.Connection.Close()

        End Try



    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        Try
            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            picturepath = OpenFileDialog1.FileName

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a195281.Show()
        Me.Close()
    End Sub

End Class