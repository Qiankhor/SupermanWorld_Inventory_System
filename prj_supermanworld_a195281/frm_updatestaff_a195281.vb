Public Class frm_updatestaff_a195281

    Dim current_id As String

    Private Sub frm_updatestaff_a195281_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_staff.DataSource = run_sql_query("SELECT * FROM tbl_staff_a195281 ORDER BY fld_staff_id")

        grd_staff.Columns(0).HeaderText = "Satff ID"
        grd_staff.Columns(1).HeaderText = "Name"
        grd_staff.Columns(2).HeaderText = "Email"
        grd_staff.Columns(3).HeaderText = "Phone No."

    End Sub

    Private Sub get_current_id()

        Dim current_row As Integer = grd_staff.CurrentRow.Index

        current_id = grd_staff(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_staff(1, current_row).Value
        txt_email.Text = grd_staff(2, current_row).Value
        txt_phone.Text = grd_staff(3, current_row).Value

    End Sub

    Private Sub clear_fields()

        txt_id.Clear()
        txt_name.Clear()
        txt_email.Clear()
        txt_phone.Clear()

    End Sub

    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick

        get_current_id()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        Try

            run_sql_command("UPDATE tbl_staff_a195281 SET fld_staff_name = '" & txt_name.Text & "', fld_staff_email = '" & txt_email.Text & "', fld_staff_phone_no = '" & txt_phone.Text & "' WHERE fld_staff_id = '" & current_id & "'")

            Beep()
            MsgBox("You have successfully updated the staff with ID """ & current_id & """.")

            grd_staff.DataSource = run_sql_query("SELECT * FROM tbl_staff_a195281 ORDER BY fld_staff_id")
            clear_fields()
            get_current_id()

        Catch ex As Exception

            Beep()
            MsgBox("Problem with updating staff data : " & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the staff with ID """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM tbl_staff_a195281 WHERE fld_staff_id = '" & current_id & "'")

            Beep()
            MsgBox("The staff with ID """ & current_id & """ has been successfully deleted.")

            grd_staff.DataSource = run_sql_query("SELECT * FROM tbl_staff_a195281 ORDER BY fld_staff_id")
            clear_fields()
            get_current_id()

        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a195281.Show()
        Me.Close()
    End Sub

End Class