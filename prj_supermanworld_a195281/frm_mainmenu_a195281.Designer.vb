<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainmenu_a195281
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainmenu_a195281))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_productlist = New System.Windows.Forms.Button()
        Me.btn_customerlist = New System.Windows.Forms.Button()
        Me.btn_stafflist = New System.Windows.Forms.Button()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_instruction = New System.Windows.Forms.Label()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_product = New System.Windows.Forms.Button()
        Me.btn_editproduct = New System.Windows.Forms.Button()
        Me.btn_editcustomer = New System.Windows.Forms.Button()
        Me.btn_editstaff = New System.Windows.Forms.Button()
        Me.btn_insertproduct = New System.Windows.Forms.Button()
        Me.btn_updateproduct = New System.Windows.Forms.Button()
        Me.btn_updatecustomer = New System.Windows.Forms.Button()
        Me.btn_insertcustomer = New System.Windows.Forms.Button()
        Me.btn_updatestaff = New System.Windows.Forms.Button()
        Me.btn_insertstaff = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_makeorder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(276, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(430, 63)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SupermanWorld"
        '
        'btn_productlist
        '
        Me.btn_productlist.BackColor = System.Drawing.Color.Khaki
        Me.btn_productlist.BackgroundImage = CType(resources.GetObject("btn_productlist.BackgroundImage"), System.Drawing.Image)
        Me.btn_productlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_productlist.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_productlist.Location = New System.Drawing.Point(292, 257)
        Me.btn_productlist.Name = "btn_productlist"
        Me.btn_productlist.Size = New System.Drawing.Size(144, 75)
        Me.btn_productlist.TabIndex = 1
        Me.btn_productlist.UseVisualStyleBackColor = False
        Me.btn_productlist.Visible = False
        '
        'btn_customerlist
        '
        Me.btn_customerlist.BackColor = System.Drawing.Color.LightBlue
        Me.btn_customerlist.BackgroundImage = CType(resources.GetObject("btn_customerlist.BackgroundImage"), System.Drawing.Image)
        Me.btn_customerlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_customerlist.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customerlist.Location = New System.Drawing.Point(706, 257)
        Me.btn_customerlist.Name = "btn_customerlist"
        Me.btn_customerlist.Size = New System.Drawing.Size(144, 75)
        Me.btn_customerlist.TabIndex = 2
        Me.btn_customerlist.UseVisualStyleBackColor = False
        Me.btn_customerlist.Visible = False
        '
        'btn_stafflist
        '
        Me.btn_stafflist.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_stafflist.BackgroundImage = CType(resources.GetObject("btn_stafflist.BackgroundImage"), System.Drawing.Image)
        Me.btn_stafflist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_stafflist.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stafflist.Location = New System.Drawing.Point(294, 538)
        Me.btn_stafflist.Name = "btn_stafflist"
        Me.btn_stafflist.Size = New System.Drawing.Size(144, 75)
        Me.btn_stafflist.TabIndex = 3
        Me.btn_stafflist.UseVisualStyleBackColor = False
        Me.btn_stafflist.Visible = False
        '
        'btn_invoice
        '
        Me.btn_invoice.BackColor = System.Drawing.Color.Thistle
        Me.btn_invoice.BackgroundImage = CType(resources.GetObject("btn_invoice.BackgroundImage"), System.Drawing.Image)
        Me.btn_invoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_invoice.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_invoice.Location = New System.Drawing.Point(706, 541)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(144, 75)
        Me.btn_invoice.TabIndex = 4
        Me.btn_invoice.UseVisualStyleBackColor = False
        Me.btn_invoice.Visible = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Red
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_exit.Location = New System.Drawing.Point(245, 807)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(286, 68)
        Me.btn_exit.TabIndex = 5
        Me.btn_exit.Text = "EXIT PROGRAM"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'lbl_instruction
        '
        Me.lbl_instruction.AutoSize = True
        Me.lbl_instruction.BackColor = System.Drawing.Color.Transparent
        Me.lbl_instruction.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instruction.Location = New System.Drawing.Point(132, 175)
        Me.lbl_instruction.Name = "lbl_instruction"
        Me.lbl_instruction.Size = New System.Drawing.Size(701, 36)
        Me.lbl_instruction.TabIndex = 7
        Me.lbl_instruction.Text = "Select an option below to view the corresponding data"
        '
        'btn_order
        '
        Me.btn_order.BackColor = System.Drawing.Color.Thistle
        Me.btn_order.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.Location = New System.Drawing.Point(492, 541)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(218, 145)
        Me.btn_order.TabIndex = 11
        Me.btn_order.Text = "Order"
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'btn_staff
        '
        Me.btn_staff.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_staff.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.Location = New System.Drawing.Point(79, 539)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(218, 145)
        Me.btn_staff.TabIndex = 10
        Me.btn_staff.Text = "Staff"
        Me.btn_staff.UseVisualStyleBackColor = False
        '
        'btn_customer
        '
        Me.btn_customer.BackColor = System.Drawing.Color.LightBlue
        Me.btn_customer.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.Location = New System.Drawing.Point(488, 258)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(218, 145)
        Me.btn_customer.TabIndex = 9
        Me.btn_customer.Text = "Customer"
        Me.btn_customer.UseVisualStyleBackColor = False
        '
        'btn_product
        '
        Me.btn_product.BackColor = System.Drawing.Color.Khaki
        Me.btn_product.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_product.Location = New System.Drawing.Point(74, 257)
        Me.btn_product.Name = "btn_product"
        Me.btn_product.Size = New System.Drawing.Size(218, 145)
        Me.btn_product.TabIndex = 8
        Me.btn_product.Text = "Product"
        Me.btn_product.UseVisualStyleBackColor = False
        '
        'btn_editproduct
        '
        Me.btn_editproduct.BackColor = System.Drawing.Color.Khaki
        Me.btn_editproduct.BackgroundImage = CType(resources.GetObject("btn_editproduct.BackgroundImage"), System.Drawing.Image)
        Me.btn_editproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editproduct.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editproduct.Location = New System.Drawing.Point(292, 330)
        Me.btn_editproduct.Name = "btn_editproduct"
        Me.btn_editproduct.Size = New System.Drawing.Size(144, 75)
        Me.btn_editproduct.TabIndex = 12
        Me.btn_editproduct.UseVisualStyleBackColor = False
        Me.btn_editproduct.Visible = False
        '
        'btn_editcustomer
        '
        Me.btn_editcustomer.BackColor = System.Drawing.Color.LightBlue
        Me.btn_editcustomer.BackgroundImage = CType(resources.GetObject("btn_editcustomer.BackgroundImage"), System.Drawing.Image)
        Me.btn_editcustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editcustomer.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editcustomer.Location = New System.Drawing.Point(706, 331)
        Me.btn_editcustomer.Name = "btn_editcustomer"
        Me.btn_editcustomer.Size = New System.Drawing.Size(144, 75)
        Me.btn_editcustomer.TabIndex = 13
        Me.btn_editcustomer.UseVisualStyleBackColor = False
        Me.btn_editcustomer.Visible = False
        '
        'btn_editstaff
        '
        Me.btn_editstaff.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_editstaff.BackgroundImage = CType(resources.GetObject("btn_editstaff.BackgroundImage"), System.Drawing.Image)
        Me.btn_editstaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_editstaff.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editstaff.Location = New System.Drawing.Point(295, 611)
        Me.btn_editstaff.Name = "btn_editstaff"
        Me.btn_editstaff.Size = New System.Drawing.Size(144, 75)
        Me.btn_editstaff.TabIndex = 14
        Me.btn_editstaff.UseVisualStyleBackColor = False
        Me.btn_editstaff.Visible = False
        '
        'btn_insertproduct
        '
        Me.btn_insertproduct.BackColor = System.Drawing.Color.Khaki
        Me.btn_insertproduct.BackgroundImage = CType(resources.GetObject("btn_insertproduct.BackgroundImage"), System.Drawing.Image)
        Me.btn_insertproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_insertproduct.Location = New System.Drawing.Point(294, 402)
        Me.btn_insertproduct.Name = "btn_insertproduct"
        Me.btn_insertproduct.Size = New System.Drawing.Size(72, 67)
        Me.btn_insertproduct.TabIndex = 15
        Me.btn_insertproduct.UseVisualStyleBackColor = False
        Me.btn_insertproduct.Visible = False
        '
        'btn_updateproduct
        '
        Me.btn_updateproduct.BackColor = System.Drawing.Color.Khaki
        Me.btn_updateproduct.BackgroundImage = CType(resources.GetObject("btn_updateproduct.BackgroundImage"), System.Drawing.Image)
        Me.btn_updateproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_updateproduct.Location = New System.Drawing.Point(364, 402)
        Me.btn_updateproduct.Name = "btn_updateproduct"
        Me.btn_updateproduct.Size = New System.Drawing.Size(72, 67)
        Me.btn_updateproduct.TabIndex = 16
        Me.btn_updateproduct.UseVisualStyleBackColor = False
        Me.btn_updateproduct.Visible = False
        '
        'btn_updatecustomer
        '
        Me.btn_updatecustomer.BackColor = System.Drawing.Color.LightBlue
        Me.btn_updatecustomer.BackgroundImage = CType(resources.GetObject("btn_updatecustomer.BackgroundImage"), System.Drawing.Image)
        Me.btn_updatecustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_updatecustomer.Location = New System.Drawing.Point(778, 405)
        Me.btn_updatecustomer.Name = "btn_updatecustomer"
        Me.btn_updatecustomer.Size = New System.Drawing.Size(72, 67)
        Me.btn_updatecustomer.TabIndex = 18
        Me.btn_updatecustomer.UseVisualStyleBackColor = False
        Me.btn_updatecustomer.Visible = False
        '
        'btn_insertcustomer
        '
        Me.btn_insertcustomer.BackColor = System.Drawing.Color.LightBlue
        Me.btn_insertcustomer.BackgroundImage = CType(resources.GetObject("btn_insertcustomer.BackgroundImage"), System.Drawing.Image)
        Me.btn_insertcustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_insertcustomer.Location = New System.Drawing.Point(706, 405)
        Me.btn_insertcustomer.Name = "btn_insertcustomer"
        Me.btn_insertcustomer.Size = New System.Drawing.Size(72, 67)
        Me.btn_insertcustomer.TabIndex = 17
        Me.btn_insertcustomer.UseVisualStyleBackColor = False
        Me.btn_insertcustomer.Visible = False
        '
        'btn_updatestaff
        '
        Me.btn_updatestaff.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_updatestaff.BackgroundImage = CType(resources.GetObject("btn_updatestaff.BackgroundImage"), System.Drawing.Image)
        Me.btn_updatestaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_updatestaff.Location = New System.Drawing.Point(365, 685)
        Me.btn_updatestaff.Name = "btn_updatestaff"
        Me.btn_updatestaff.Size = New System.Drawing.Size(72, 67)
        Me.btn_updatestaff.TabIndex = 20
        Me.btn_updatestaff.UseVisualStyleBackColor = False
        Me.btn_updatestaff.Visible = False
        '
        'btn_insertstaff
        '
        Me.btn_insertstaff.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_insertstaff.BackgroundImage = CType(resources.GetObject("btn_insertstaff.BackgroundImage"), System.Drawing.Image)
        Me.btn_insertstaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_insertstaff.Location = New System.Drawing.Point(294, 685)
        Me.btn_insertstaff.Name = "btn_insertstaff"
        Me.btn_insertstaff.Size = New System.Drawing.Size(72, 67)
        Me.btn_insertstaff.TabIndex = 19
        Me.btn_insertstaff.UseVisualStyleBackColor = False
        Me.btn_insertstaff.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(477, 22)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "SUPERMAN COLLECTIBLE AND MEMORABILIA SHOP"
        '
        'btn_makeorder
        '
        Me.btn_makeorder.BackColor = System.Drawing.Color.Thistle
        Me.btn_makeorder.BackgroundImage = CType(resources.GetObject("btn_makeorder.BackgroundImage"), System.Drawing.Image)
        Me.btn_makeorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_makeorder.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_makeorder.Location = New System.Drawing.Point(707, 612)
        Me.btn_makeorder.Name = "btn_makeorder"
        Me.btn_makeorder.Size = New System.Drawing.Size(144, 75)
        Me.btn_makeorder.TabIndex = 22
        Me.btn_makeorder.UseVisualStyleBackColor = False
        Me.btn_makeorder.Visible = False
        '
        'frm_mainmenu_a195281
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackgroundImage = Global.prj_supermanworld_a195281.My.Resources.Resources.superman
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1288, 917)
        Me.Controls.Add(Me.btn_makeorder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_updatestaff)
        Me.Controls.Add(Me.btn_insertstaff)
        Me.Controls.Add(Me.btn_updatecustomer)
        Me.Controls.Add(Me.btn_insertcustomer)
        Me.Controls.Add(Me.btn_updateproduct)
        Me.Controls.Add(Me.btn_insertproduct)
        Me.Controls.Add(Me.btn_editstaff)
        Me.Controls.Add(Me.btn_editcustomer)
        Me.Controls.Add(Me.btn_editproduct)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_product)
        Me.Controls.Add(Me.lbl_instruction)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_invoice)
        Me.Controls.Add(Me.btn_stafflist)
        Me.Controls.Add(Me.btn_customerlist)
        Me.Controls.Add(Me.btn_productlist)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frm_mainmenu_a195281"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SupermanWorld Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_productlist As Button
    Friend WithEvents btn_customerlist As Button
    Friend WithEvents btn_stafflist As Button
    Friend WithEvents btn_invoice As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_instruction As Label
    Friend WithEvents btn_order As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_product As Button
    Friend WithEvents btn_editproduct As Button
    Friend WithEvents btn_editcustomer As Button
    Friend WithEvents btn_editstaff As Button
    Friend WithEvents btn_insertproduct As Button
    Friend WithEvents btn_updateproduct As Button
    Friend WithEvents btn_updatecustomer As Button
    Friend WithEvents btn_insertcustomer As Button
    Friend WithEvents btn_updatestaff As Button
    Friend WithEvents btn_insertstaff As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_makeorder As Button
End Class
