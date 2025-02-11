<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_makeorder_a195281
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeorder_a195281))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_orderID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_releasedate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lst_id = New System.Windows.Forms.ListBox()
        Me.cmb_customerID = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_staffID = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grd_neworder = New System.Windows.Forms.DataGridView()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.btn_addorder = New System.Windows.Forms.Button()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_productID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_checkout = New System.Windows.Forms.Button()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.txt_orderquantity = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lbl_ordertotal = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.grd_neworder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_orderquantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order ID : "
        '
        'txt_orderID
        '
        Me.txt_orderID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orderID.Location = New System.Drawing.Point(153, 118)
        Me.txt_orderID.Name = "txt_orderID"
        Me.txt_orderID.ReadOnly = True
        Me.txt_orderID.Size = New System.Drawing.Size(256, 35)
        Me.txt_orderID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 581)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 27)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Product ID : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 640)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 27)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Quantity : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 711)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 27)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Subtotal : "
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.Location = New System.Drawing.Point(227, 708)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(32, 32)
        Me.lbl_subtotal.TabIndex = 32
        Me.lbl_subtotal.Text = "0"
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(596, 306)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(738, 35)
        Me.txt_name.TabIndex = 15
        '
        'txt_description
        '
        Me.txt_description.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_description.Location = New System.Drawing.Point(596, 448)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.ReadOnly = True
        Me.txt_description.Size = New System.Drawing.Size(738, 35)
        Me.txt_description.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(455, 451)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 27)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Description :"
        '
        'txt_quantity
        '
        Me.txt_quantity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(1054, 400)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.ReadOnly = True
        Me.txt_quantity.Size = New System.Drawing.Size(280, 35)
        Me.txt_quantity.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(968, 405)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 27)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Stock :"
        '
        'txt_releasedate
        '
        Me.txt_releasedate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_releasedate.Location = New System.Drawing.Point(596, 400)
        Me.txt_releasedate.Name = "txt_releasedate"
        Me.txt_releasedate.ReadOnly = True
        Me.txt_releasedate.Size = New System.Drawing.Size(267, 35)
        Me.txt_releasedate.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(439, 405)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 27)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Release Date :"
        '
        'txt_type
        '
        Me.txt_type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type.Location = New System.Drawing.Point(1054, 353)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.ReadOnly = True
        Me.txt_type.Size = New System.Drawing.Size(280, 35)
        Me.txt_type.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(977, 358)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 27)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Type :"
        '
        'txt_brand
        '
        Me.txt_brand.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(596, 353)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.ReadOnly = True
        Me.txt_brand.Size = New System.Drawing.Size(267, 35)
        Me.txt_brand.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(507, 358)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 27)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Brand :"
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(1054, 262)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(280, 35)
        Me.txt_price.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(915, 265)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 27)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Price (RM) :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(427, 309)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 27)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Product Name :"
        Me.Label11.UseWaitCursor = True
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(596, 262)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(267, 35)
        Me.txt_id.TabIndex = 11
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(459, 265)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(131, 27)
        Me.lbl_id.TabIndex = 10
        Me.lbl_id.Text = "Product ID :"
        '
        'lst_id
        '
        Me.lst_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_id.FormattingEnabled = True
        Me.lst_id.ItemHeight = 27
        Me.lst_id.Location = New System.Drawing.Point(26, 263)
        Me.lst_id.Name = "lst_id"
        Me.lst_id.Size = New System.Drawing.Size(376, 220)
        Me.lst_id.TabIndex = 9
        '
        'cmb_customerID
        '
        Me.cmb_customerID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_customerID.FormattingEnabled = True
        Me.cmb_customerID.Location = New System.Drawing.Point(595, 166)
        Me.cmb_customerID.Name = "cmb_customerID"
        Me.cmb_customerID.Size = New System.Drawing.Size(268, 35)
        Me.cmb_customerID.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(439, 170)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 27)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Customer ID : "
        '
        'cmb_staffID
        '
        Me.cmb_staffID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_staffID.FormattingEnabled = True
        Me.cmb_staffID.Location = New System.Drawing.Point(1054, 168)
        Me.cmb_staffID.Name = "cmb_staffID"
        Me.cmb_staffID.Size = New System.Drawing.Size(280, 35)
        Me.cmb_staffID.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(941, 171)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 27)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Staff ID : "
        '
        'txt_date
        '
        Me.txt_date.CalendarFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.Location = New System.Drawing.Point(146, 171)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(256, 26)
        Me.txt_date.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 170)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(138, 27)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Order Date : "
        '
        'grd_neworder
        '
        Me.grd_neworder.AllowUserToAddRows = False
        Me.grd_neworder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_neworder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_neworder.Location = New System.Drawing.Point(460, 570)
        Me.grd_neworder.Name = "grd_neworder"
        Me.grd_neworder.ReadOnly = True
        Me.grd_neworder.RowHeadersWidth = 62
        Me.grd_neworder.RowTemplate.Height = 28
        Me.grd_neworder.Size = New System.Drawing.Size(874, 190)
        Me.grd_neworder.TabIndex = 34
        '
        'btn_invoice
        '
        Me.btn_invoice.BackgroundImage = CType(resources.GetObject("btn_invoice.BackgroundImage"), System.Drawing.Image)
        Me.btn_invoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_invoice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_invoice.Location = New System.Drawing.Point(1442, 915)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(108, 91)
        Me.btn_invoice.TabIndex = 36
        Me.btn_invoice.UseVisualStyleBackColor = True
        '
        'btn_addorder
        '
        Me.btn_addorder.BackgroundImage = CType(resources.GetObject("btn_addorder.BackgroundImage"), System.Drawing.Image)
        Me.btn_addorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_addorder.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addorder.Location = New System.Drawing.Point(300, 695)
        Me.btn_addorder.Name = "btn_addorder"
        Me.btn_addorder.Size = New System.Drawing.Size(121, 62)
        Me.btn_addorder.TabIndex = 33
        Me.btn_addorder.UseVisualStyleBackColor = True
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(1378, 262)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(236, 221)
        Me.pic_product.TabIndex = 52
        Me.pic_product.TabStop = False
        '
        'txt_productID
        '
        Me.txt_productID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productID.Location = New System.Drawing.Point(179, 578)
        Me.txt_productID.Name = "txt_productID"
        Me.txt_productID.ReadOnly = True
        Me.txt_productID.Size = New System.Drawing.Size(242, 35)
        Me.txt_productID.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(173, 708)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 32)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "RM"
        '
        'btn_start
        '
        Me.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_start.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.Location = New System.Drawing.Point(1378, 158)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(247, 53)
        Me.btn_start.TabIndex = 8
        Me.btn_start.Text = "START ORDERING"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'btn_checkout
        '
        Me.btn_checkout.BackgroundImage = CType(resources.GetObject("btn_checkout.BackgroundImage"), System.Drawing.Image)
        Me.btn_checkout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_checkout.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_checkout.Location = New System.Drawing.Point(1442, 666)
        Me.btn_checkout.Name = "btn_checkout"
        Me.btn_checkout.Size = New System.Drawing.Size(108, 91)
        Me.btn_checkout.TabIndex = 35
        Me.btn_checkout.UseVisualStyleBackColor = True
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AllowUserToDeleteRows = False
        Me.grd_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(26, 806)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.RowHeadersWidth = 62
        Me.grd_order.RowTemplate.Height = 28
        Me.grd_order.Size = New System.Drawing.Size(1308, 200)
        Me.grd_order.TabIndex = 37
        '
        'txt_orderquantity
        '
        Me.txt_orderquantity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orderquantity.Location = New System.Drawing.Point(179, 638)
        Me.txt_orderquantity.Name = "txt_orderquantity"
        Me.txt_orderquantity.Size = New System.Drawing.Size(242, 35)
        Me.txt_orderquantity.TabIndex = 29
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkRed
        Me.Label16.Location = New System.Drawing.Point(35, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(367, 25)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "STEP 1 : Fill in the order information."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkRed
        Me.Label17.Location = New System.Drawing.Point(26, 229)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(498, 25)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "STEP 2 : Select the product you want to purchase."
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkRed
        Me.Label18.Location = New System.Drawing.Point(30, 508)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(404, 67)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "STEP 3 : Enter the product quantity you want to buy and add to order."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkRed
        Me.Label19.Location = New System.Drawing.Point(1350, 629)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(210, 25)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "STEP 4 : Check out."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Indigo
        Me.Label20.Location = New System.Drawing.Point(460, 534)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(234, 24)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "NEW ORDERED PRODUCTS"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Indigo
        Me.Label21.Location = New System.Drawing.Point(26, 776)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(230, 24)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "CHECKED-OUT PRODUCTS"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DarkRed
        Me.Label22.Location = New System.Drawing.Point(1350, 866)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(275, 25)
        Me.Label22.TabIndex = 59
        Me.Label22.Text = "STEP 5 : Generate invoice."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(1433, 816)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(60, 32)
        Me.Label23.TabIndex = 61
        Me.Label23.Text = "RM"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(1487, 816)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(32, 32)
        Me.lbl_total.TabIndex = 62
        Me.lbl_total.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(1360, 818)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 26)
        Me.Label25.TabIndex = 60
        Me.Label25.Text = "Total : "
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(685, 12)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(329, 63)
        Me.Label24.TabIndex = 63
        Me.Label24.Text = "Make Order"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(1423, 583)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(60, 32)
        Me.Label26.TabIndex = 65
        Me.Label26.Text = "RM"
        '
        'lbl_ordertotal
        '
        Me.lbl_ordertotal.AutoSize = True
        Me.lbl_ordertotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ordertotal.Location = New System.Drawing.Point(1477, 583)
        Me.lbl_ordertotal.Name = "lbl_ordertotal"
        Me.lbl_ordertotal.Size = New System.Drawing.Size(32, 32)
        Me.lbl_ordertotal.TabIndex = 66
        Me.lbl_ordertotal.Text = "0"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(1350, 585)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(84, 26)
        Me.Label28.TabIndex = 64
        Me.Label28.Text = "Total : "
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Thistle
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(35, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(129, 44)
        Me.btn_back.TabIndex = 67
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'frm_makeorder_a195281
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1674, 1034)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.lbl_ordertotal)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_orderquantity)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.btn_checkout)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_productID)
        Me.Controls.Add(Me.btn_invoice)
        Me.Controls.Add(Me.grd_neworder)
        Me.Controls.Add(Me.btn_addorder)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.cmb_staffID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmb_customerID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lst_id)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_releasedate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_subtotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_orderID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_makeorder_a195281"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make Order"
        CType(Me.grd_neworder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_orderquantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_orderID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_description As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_releasedate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_type As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents lst_id As ListBox
    Friend WithEvents cmb_customerID As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmb_staffID As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_date As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_addorder As Button
    Friend WithEvents grd_neworder As DataGridView
    Friend WithEvents btn_invoice As Button
    Friend WithEvents txt_productID As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_start As Button
    Friend WithEvents btn_checkout As Button
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents txt_orderquantity As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lbl_ordertotal As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents btn_back As Button
End Class
