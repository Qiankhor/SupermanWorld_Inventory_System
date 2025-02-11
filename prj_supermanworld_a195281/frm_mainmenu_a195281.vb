Public Class frm_mainmenu_a195281

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        btn_productlist.Show()
        btn_editproduct.Show()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        btn_customerlist.Show()
        btn_editcustomer.Show()
    End Sub

    Private Sub btn_staff_Click_1(sender As Object, e As EventArgs) Handles btn_staff.Click
        btn_stafflist.Show()
        btn_editstaff.Show()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        btn_invoice.Show()
        btn_makeorder.Show()
    End Sub

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_productlist.Click
        frm_productlist_a195281.Show()
        Me.Hide()
    End Sub

    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customerlist.Click
        frm_customerlist_a195281.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_stafflist.Click
        frm_stafflist_a195281.Show()
        Me.Hide()
    End Sub

    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        frm_invoice_a195281.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        MsgBox("Goodbye !")
        Application.Exit()
    End Sub

    Private Sub btn_product_MouseEnter(sender As Object, e As EventArgs) Handles btn_product.MouseEnter
        lbl_instruction.Text = "Click to VIEW or EDIT product information."
        btn_product.BackColor = Color.LemonChiffon
    End Sub

    Private Sub btn_product_MouseLeave(sender As Object, e As EventArgs) Handles btn_product.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_product.BackColor = Color.Khaki
    End Sub

    Private Sub btn_productlist_MouseEnter(sender As Object, e As EventArgs) Handles btn_productlist.MouseEnter
        lbl_instruction.Text = "Click to VIEW product information."
        btn_productlist.BackColor = Color.LemonChiffon
    End Sub

    Private Sub btn_productlist_MouseLeave(sender As Object, e As EventArgs) Handles btn_productlist.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_productlist.BackColor = Color.Khaki
    End Sub

    Private Sub btn_editproduct_MouseEnter(sender As Object, e As EventArgs) Handles btn_editproduct.MouseEnter
        lbl_instruction.Text = "Click to INSERT or UPDATE product information."
        btn_editproduct.BackColor = Color.LemonChiffon
    End Sub

    Private Sub btn_editproduct_MouseLeave(sender As Object, e As EventArgs) Handles btn_editproduct.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_editproduct.BackColor = Color.Khaki
    End Sub

    Private Sub btn_customer_MouseEnter(sender As Object, e As EventArgs) Handles btn_customer.MouseEnter
        lbl_instruction.Text = "Click to VIEW or EDIT customer information."
        btn_customer.BackColor = Color.AliceBlue
    End Sub

    Private Sub btn_customer_MouseLeave(sender As Object, e As EventArgs) Handles btn_customer.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_customer.BackColor = Color.LightBlue
    End Sub
    Private Sub btn_customerlist_MouseEnter(sender As Object, e As EventArgs) Handles btn_customerlist.MouseEnter
        lbl_instruction.Text = "Click to VIEW customer information."
        btn_customerlist.BackColor = Color.AliceBlue
    End Sub

    Private Sub btn_customerlist_MouseLeave(sender As Object, e As EventArgs) Handles btn_customerlist.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_customerlist.BackColor = Color.LightBlue
    End Sub

    Private Sub btn_editcustomer_MouseEnter(sender As Object, e As EventArgs) Handles btn_editcustomer.MouseEnter
        lbl_instruction.Text = "Click to INSERT or UPDATE customer information."
        btn_editcustomer.BackColor = Color.AliceBlue
    End Sub

    Private Sub btn_editcustomer_MouseLeave(sender As Object, e As EventArgs) Handles btn_editcustomer.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_editcustomer.BackColor = Color.LightBlue
    End Sub

    Private Sub btn_staff_MouseEnter(sender As Object, e As EventArgs) Handles btn_staff.MouseEnter
        lbl_instruction.Text = "Click to VIEW or EDIT staff information."
        btn_staff.BackColor = Color.Honeydew
    End Sub

    Private Sub btn_staff_MouseLeave(sender As Object, e As EventArgs) Handles btn_staff.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_staff.BackColor = Color.PaleGreen
    End Sub

    Private Sub btn_stafflist_MouseEnter(sender As Object, e As EventArgs) Handles btn_stafflist.MouseEnter
        lbl_instruction.Text = "Click to VIEW staff information."
        btn_stafflist.BackColor = Color.Honeydew
    End Sub

    Private Sub btn_stafflist_MouseLeave(sender As Object, e As EventArgs) Handles btn_stafflist.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_stafflist.BackColor = Color.PaleGreen
    End Sub

    Private Sub btn_editstaff_MouseEnter(sender As Object, e As EventArgs) Handles btn_editstaff.MouseEnter
        lbl_instruction.Text = "Click to INSERT or UPDATE staff information."
        btn_editstaff.BackColor = Color.Honeydew
    End Sub

    Private Sub btn_editstaff_MouseLeave(sender As Object, e As EventArgs) Handles btn_editstaff.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_editstaff.BackColor = Color.PaleGreen
    End Sub

    Private Sub btn_order_MouseEnter(sender As Object, e As EventArgs) Handles btn_order.MouseEnter
        lbl_instruction.Text = "Click to VIEW INVOICE or MAKE ORDER."
        btn_order.BackColor = Color.LavenderBlush
    End Sub

    Private Sub btn_order_MouseLeave(sender As Object, e As EventArgs) Handles btn_order.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_order.BackColor = Color.Thistle
    End Sub

    Private Sub btn_invoice_MouseEnter(sender As Object, e As EventArgs) Handles btn_invoice.MouseEnter
        lbl_instruction.Text = "Click to VIEW INVOICE."
        btn_invoice.BackColor = Color.LavenderBlush
    End Sub

    Private Sub btn_invoice_MouseLeave(sender As Object, e As EventArgs) Handles btn_invoice.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_invoice.BackColor = Color.Thistle
    End Sub

    Private Sub btn_makeorder_MouseEnter(sender As Object, e As EventArgs) Handles btn_makeorder.MouseEnter
        lbl_instruction.Text = "Click to MAKE ORDER."
        btn_makeorder.BackColor = Color.LavenderBlush
    End Sub

    Private Sub btn_makeorder_MouseLeave(sender As Object, e As EventArgs) Handles btn_makeorder.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_makeorder.BackColor = Color.Thistle
    End Sub

    Private Sub btn_exit_MouseEnter(sender As Object, e As EventArgs) Handles btn_exit.MouseEnter
        lbl_instruction.Text = "Click to EXIT the program."
        btn_exit.BackColor = Color.LightCoral
    End Sub

    Private Sub btn_exit_MouseLeave(sender As Object, e As EventArgs) Handles btn_exit.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_exit.BackColor = Color.Red
    End Sub

    Private Sub btn_editproduct_Click(sender As Object, e As EventArgs) Handles btn_editproduct.Click
        btn_insertproduct.Show()
        btn_updateproduct.Show()
    End Sub

    Private Sub btn_editcustomer_Click(sender As Object, e As EventArgs) Handles btn_editcustomer.Click
        btn_insertcustomer.Show()
        btn_updatecustomer.Show()
    End Sub

    Private Sub btn_editstaff_Click(sender As Object, e As EventArgs) Handles btn_editstaff.Click
        btn_insertstaff.Show()
        btn_updatestaff.Show()
    End Sub

    Private Sub btn_insertproduct_Click(sender As Object, e As EventArgs) Handles btn_insertproduct.Click
        frm_insertproduct_a195281.Show()
        Me.Hide()
    End Sub

    Private Sub btn_updateproduct_Click(sender As Object, e As EventArgs) Handles btn_updateproduct.Click
        frm_updateproduct_a195281.Show()
        Me.Hide()
    End Sub

    Private Sub btn_insertcustomer_Click(sender As Object, e As EventArgs) Handles btn_insertcustomer.Click
        frm_insertcustomer_a195281.Show()
        Me.Hide()
    End Sub

    Private Sub btn_updatecustomer_Click(sender As Object, e As EventArgs) Handles btn_updatecustomer.Click
        frm_updatecustomer_a195281.Show()
        Me.Hide()
    End Sub

    Private Sub btn_insertstaff_Click(sender As Object, e As EventArgs) Handles btn_insertstaff.Click
        frm_insertstaff_a195281.Show()
        Me.Hide()
    End Sub

    Private Sub btn_updatestaff_Click(sender As Object, e As EventArgs) Handles btn_updatestaff.Click
        frm_updatestaff_a195281.Show()
        Me.Hide()
    End Sub

    Private Sub btn_insertproduct_MouseEnter(sender As Object, e As EventArgs) Handles btn_insertproduct.MouseEnter
        lbl_instruction.Text = "Click to INSERT new product information."
        btn_insertproduct.BackColor = Color.LemonChiffon
    End Sub

    Private Sub btn_insertproduct_MouseLeave(sender As Object, e As EventArgs) Handles btn_insertproduct.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_insertproduct.BackColor = Color.Khaki
    End Sub

    Private Sub btn_updateproduct_MouseEnter(sender As Object, e As EventArgs) Handles btn_updateproduct.MouseEnter
        lbl_instruction.Text = "Click to UPDATE product information."
        btn_updateproduct.BackColor = Color.LemonChiffon
    End Sub

    Private Sub btn_updateproduct_MouseLeave(sender As Object, e As EventArgs) Handles btn_updateproduct.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_updateproduct.BackColor = Color.Khaki
    End Sub

    Private Sub btn_insertcustomer_MouseEnter(sender As Object, e As EventArgs) Handles btn_insertcustomer.MouseEnter
        lbl_instruction.Text = "Click to INSERT new customer information."
        btn_insertcustomer.BackColor = Color.AliceBlue
    End Sub

    Private Sub btn_insertcustomer_MouseLeave(sender As Object, e As EventArgs) Handles btn_insertcustomer.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_insertcustomer.BackColor = Color.LightBlue
    End Sub

    Private Sub btn_updatecustomer_MouseEnter(sender As Object, e As EventArgs) Handles btn_updatecustomer.MouseEnter
        lbl_instruction.Text = "Click to UPDATE customer information."
        btn_updatecustomer.BackColor = Color.AliceBlue
    End Sub

    Private Sub btn_updatecustomer_MouseLeave(sender As Object, e As EventArgs) Handles btn_updatecustomer.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_updatecustomer.BackColor = Color.LightBlue
    End Sub

    Private Sub btn_insertstaff_MouseEnter(sender As Object, e As EventArgs) Handles btn_insertstaff.MouseEnter
        lbl_instruction.Text = "Click to INSERT new staff information."
        btn_insertstaff.BackColor = Color.Honeydew
    End Sub

    Private Sub btn_insertstaff_MouseLeave(sender As Object, e As EventArgs) Handles btn_insertstaff.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_insertstaff.BackColor = Color.PaleGreen
    End Sub

    Private Sub btn_updatestaff_MouseEnter(sender As Object, e As EventArgs) Handles btn_updatestaff.MouseEnter
        lbl_instruction.Text = "Click to UPDATE staff information."
        btn_updatestaff.BackColor = Color.Honeydew
    End Sub

    Private Sub btn_updatestaff_MouseLeave(sender As Object, e As EventArgs) Handles btn_updatestaff.MouseLeave
        lbl_instruction.Text = "Select an option below to view the corresponding data."
        btn_updatestaff.BackColor = Color.PaleGreen
    End Sub

    Private Sub btn_makeorder_Click(sender As Object, e As EventArgs) Handles btn_makeorder.Click
        frm_makeorder_a195281.Show()
        Me.Hide()
    End Sub

    Private Sub frm_mainmenu_a195281_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
