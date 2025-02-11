Public Class frm_updateproduct_a195281

    Dim picturepath As String

    Dim current_id As String
    Private Sub frm_updateproduct_a195281_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_products.DataSource = run_sql_query("SELECT * FROM tbl_products_a195281 ORDER BY fld_product_id")

        grd_products.Columns(0).HeaderText = "Product ID"
        grd_products.Columns(1).HeaderText = "Name"
        grd_products.Columns(2).HeaderText = "Price"
        grd_products.Columns(3).HeaderText = "Brand"
        grd_products.Columns(4).HeaderText = "Type"
        grd_products.Columns(5).HeaderText = "Release Date"
        grd_products.Columns(6).HeaderText = "Stock"
        grd_products.Columns(7).HeaderText = "Description"

        pic_product.BackgroundImage = Image.FromFile("pictures/noimage.jpg")


    End Sub

    Private Sub get_current_id()

        Dim current_row As Integer = grd_products.CurrentRow.Index

        Try
            current_id = grd_products(0, current_row).Value

            txt_id.Text = current_id
            txt_name.Text = grd_products(1, current_row).Value
            txt_price.Text = grd_products(2, current_row).Value
            txt_brand.Text = grd_products(3, current_row).Value
            txt_type.Text = grd_products(4, current_row).Value
            txt_releasedate.Text = grd_products(5, current_row).Value
            txt_quantity.Text = grd_products(6, current_row).Value
            txt_description.Text = grd_products(7, current_row).Value

            pic_product.BackgroundImage = Image.FromFile("pictures/" & current_id & ".jpg")

            Dim imagePath As String = "pictures\" & current_id & ".jpg"

            If System.IO.File.Exists(imagePath) Then
                Using fs As New System.IO.FileStream(imagePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                    pic_product.BackgroundImage = Image.FromStream(fs)
                End Using
            Else
                pic_product.BackgroundImage = Image.FromFile("pictures\noimage.jpg")
            End If

        Catch ex As Exception

            Beep()
            MsgBox("Something wrong : " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    Private Sub clear_fields()

        txt_id.Clear()
        txt_name.Clear()
        txt_price.Clear()
        txt_brand.Clear()
        txt_type.Clear()
        txt_releasedate.Clear()
        txt_quantity.Clear()
        txt_description.Clear()

    End Sub

    Private Sub grd_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellClick

        get_current_id()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        Try

            run_sql_command("UPDATE tbl_products_a195281 SET fld_product_name = '" & txt_name.Text & "', fld_price = '" & txt_price.Text & "', fld_brand = '" & txt_brand.Text & "', fld_type = '" & txt_type.Text & "', fld_release_date = '" & txt_releasedate.Text & "', fld_quantity = '" & txt_quantity.Text & "', fld_description = '" & txt_description.Text & "' WHERE fld_product_id = '" & current_id & "'")

            Beep()
            MsgBox("You have successfully updated the product with ID """ & current_id & """.")

            grd_products.DataSource = run_sql_query("SELECT * FROM tbl_products_a195281 ORDER BY fld_product_id")
            clear_fields()
            get_current_id()

        Catch ex As Exception

            Beep()
            MsgBox("Problem with updating product data : " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product with ID """ & current_id & """?", MsgBoxStyle.YesNo)

        picturepath = "pictures\" & current_id & ".jpg"

        If delete_confirmation = MsgBoxResult.Yes Then

            Try

                GC.Collect()
                GC.WaitForPendingFinalizers()

                If My.Computer.FileSystem.FileExists(picturepath) Then

                    My.Computer.FileSystem.DeleteFile(picturepath)

                End If

                run_sql_command("DELETE FROM tbl_products_a195281 WHERE fld_product_id = '" & current_id & "'")

                Beep()
                MsgBox("The product with ID """ & current_id & """ has been successfully deleted.")

            Catch ex As Exception

                Beep()
                MsgBox("Something wrong : " & vbCrLf & vbCrLf & ex.Message)

            End Try

            grd_products.DataSource = run_sql_query("SELECT * FROM tbl_products_a195281 ORDER BY fld_product_id")
            clear_fields()
            get_current_id()

        End If

    End Sub

    Private Sub btn_updatePic_Click(sender As Object, e As EventArgs) Handles btn_updatePic.Click

        Dim OpenFileDialog As New OpenFileDialog()

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog.InitialDirectory = mydesktop
        OpenFileDialog.FileName = ""
        OpenFileDialog.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog.ShowDialog()

        GC.Collect()
        GC.WaitForPendingFinalizers()

        Try
            picturepath = OpenFileDialog.FileName
            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog.FileName)
            My.Computer.FileSystem.CopyFile(picturepath, "pictures\" & current_id & ".jpg", overwrite:=True)
            Beep()
            MsgBox("You have successfully updated the picture of product with ID """ & current_id & """.")

        Catch ex As Exception

            Beep()
            MsgBox("Problem with updating picture: " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    Private Sub btn_deletePic_Click(sender As Object, e As EventArgs) Handles btn_deletepic.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the picture of the product with ID """ & txt_id.Text & """?", MsgBoxStyle.YesNo)

        picturepath = "pictures\" & current_id & ".jpg"

        If delete_confirmation = MsgBoxResult.Yes Then

            GC.Collect()
            GC.WaitForPendingFinalizers()

            Try
                If My.Computer.FileSystem.FileExists(picturepath) Then
                    My.Computer.FileSystem.DeleteFile(picturepath)

                    My.Computer.FileSystem.CopyFile("pictures\noimage.jpg", "pictures\" & current_id & ".jpg")
                    pic_product.BackgroundImage = Image.FromFile("pictures\noimage.jpg")

                    Beep()
                    MsgBox("The picture of the product with ID """ & current_id & """ has been successfully deleted.")

                End If
            Catch ex As Exception

                Beep()
                MsgBox("Problem with deleting picture: " & vbCrLf & vbCrLf & ex.Message)

            End Try

        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a195281.Show()
        Me.Close()
    End Sub

End Class