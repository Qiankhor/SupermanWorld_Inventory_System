Public Class frm_stafflist_a195281
    Private Sub frm_stafflist_a195281_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_staff.DataSource = run_sql_query("SELECT * FROM tbl_staff_a195281")

        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Name"
        grd_staff.Columns(2).HeaderText = "Email"
        grd_staff.Columns(3).HeaderText = "Phone No."

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a195281.Show()
        Me.Close()
    End Sub

End Class