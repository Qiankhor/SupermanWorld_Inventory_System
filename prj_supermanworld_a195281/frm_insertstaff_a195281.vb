Public Class frm_insertstaff_a195281
    Private Sub frm_insertstaff_a195281_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_staff.DataSource = run_sql_query("SELECT * FROM tbl_staff_a195281 ORDER BY fld_staff_id")

        grd_staff.Columns(0).HeaderText = "Satfff ID"
        grd_staff.Columns(1).HeaderText = "Name"
        grd_staff.Columns(2).HeaderText = "Email"
        grd_staff.Columns(3).HeaderText = "Phone No."

        txt_id.Text = generate_id()

    End Sub

    Private Function generate_id() As String

        Dim lastid As String = run_sql_query("SELECT MAX(fld_staff_id) AS LASTID FROM tbl_staff_a195281").Rows(0).Item("LASTID")

        Dim newid As String = "S" & Mid(lastid, 2) + 1

        Return newid

    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO tbl_staff_a195281 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_email.Text & "', '" & txt_phone.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Beep()
        MsgBox("You have successfully inserted the staff with ID """ & txt_id.Text & """.")

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            txt_id.Text = generate_id()
            txt_name.Text = ""
            txt_email.Text = ""
            txt_phone.Text = ""

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

        grd_staff.DataSource = run_sql_query("SELECT * FROM tbl_staff_a195281 ORDER BY fld_staff_id")

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a195281.Show()
        Me.Close()
    End Sub

End Class