<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_invoice_a195281
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_invoice_a195281))
        Me.grd_orders = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_customer_name = New System.Windows.Forms.Label()
        Me.lbl_customer_address = New System.Windows.Forms.Label()
        Me.lbl_customer_phone = New System.Windows.Forms.Label()
        Me.lbl_customer_email = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_order_id = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_order_date = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_staff_name = New System.Windows.Forms.Label()
        Me.lbl_staff_email = New System.Windows.Forms.Label()
        Me.lbl_staff_phone = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.grd_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_orders
        '
        Me.grd_orders.AllowUserToAddRows = False
        Me.grd_orders.AllowUserToDeleteRows = False
        Me.grd_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_orders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orders.Location = New System.Drawing.Point(34, 543)
        Me.grd_orders.Name = "grd_orders"
        Me.grd_orders.ReadOnly = True
        Me.grd_orders.RowHeadersWidth = 62
        Me.grd_orders.RowTemplate.Height = 28
        Me.grd_orders.Size = New System.Drawing.Size(1482, 312)
        Me.grd_orders.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(673, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 55)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "INVOICE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(683, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 32)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "SupermanWorld"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(721, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 27)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "407, Block A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(680, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 27)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Jalan Ibrahim Yaakub"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(790, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 27)
        Me.Label5.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(676, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 27)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "43600 Bangi, Selangor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(697, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 27)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Tel : 010-3310498"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(606, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(368, 27)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Email : a195281@siswa.ukm.edu.my"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(56, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 27)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "BILL TO :"
        '
        'lbl_customer_name
        '
        Me.lbl_customer_name.AutoSize = True
        Me.lbl_customer_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_name.Location = New System.Drawing.Point(56, 364)
        Me.lbl_customer_name.Name = "lbl_customer_name"
        Me.lbl_customer_name.Size = New System.Drawing.Size(168, 27)
        Me.lbl_customer_name.TabIndex = 75
        Me.lbl_customer_name.Text = "Customer Name"
        '
        'lbl_customer_address
        '
        Me.lbl_customer_address.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_address.Location = New System.Drawing.Point(57, 447)
        Me.lbl_customer_address.Name = "lbl_customer_address"
        Me.lbl_customer_address.Size = New System.Drawing.Size(504, 79)
        Me.lbl_customer_address.TabIndex = 76
        Me.lbl_customer_address.Text = "Customer Address"
        '
        'lbl_customer_phone
        '
        Me.lbl_customer_phone.AutoSize = True
        Me.lbl_customer_phone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_phone.Location = New System.Drawing.Point(57, 392)
        Me.lbl_customer_phone.Name = "lbl_customer_phone"
        Me.lbl_customer_phone.Size = New System.Drawing.Size(172, 27)
        Me.lbl_customer_phone.TabIndex = 77
        Me.lbl_customer_phone.Text = "Customer Phone"
        '
        'lbl_customer_email
        '
        Me.lbl_customer_email.AutoSize = True
        Me.lbl_customer_email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_email.Location = New System.Drawing.Point(57, 419)
        Me.lbl_customer_email.Name = "lbl_customer_email"
        Me.lbl_customer_email.Size = New System.Drawing.Size(167, 27)
        Me.lbl_customer_email.TabIndex = 78
        Me.lbl_customer_email.Text = "Customer Email"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1194, 323)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 27)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "ORDER ID :"
        '
        'cmb_order_id
        '
        Me.cmb_order_id.DisplayMember = "fld_order_id"
        Me.cmb_order_id.FormattingEnabled = True
        Me.cmb_order_id.Location = New System.Drawing.Point(1336, 325)
        Me.cmb_order_id.Name = "cmb_order_id"
        Me.cmb_order_id.Size = New System.Drawing.Size(185, 28)
        Me.cmb_order_id.TabIndex = 80
        Me.cmb_order_id.ValueMember = "fld_order_id"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1159, 364)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(171, 27)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "ORDER DATE :"
        '
        'lbl_order_date
        '
        Me.lbl_order_date.AutoSize = True
        Me.lbl_order_date.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_date.Location = New System.Drawing.Point(1336, 364)
        Me.lbl_order_date.Name = "lbl_order_date"
        Me.lbl_order_date.Size = New System.Drawing.Size(115, 27)
        Me.lbl_order_date.TabIndex = 82
        Me.lbl_order_date.Text = "Order date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1239, 403)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 27)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "STAFF :"
        '
        'lbl_staff_name
        '
        Me.lbl_staff_name.AutoSize = True
        Me.lbl_staff_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_name.Location = New System.Drawing.Point(1336, 404)
        Me.lbl_staff_name.Name = "lbl_staff_name"
        Me.lbl_staff_name.Size = New System.Drawing.Size(121, 27)
        Me.lbl_staff_name.TabIndex = 85
        Me.lbl_staff_name.Text = "Staff Name"
        '
        'lbl_staff_email
        '
        Me.lbl_staff_email.AutoSize = True
        Me.lbl_staff_email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_email.Location = New System.Drawing.Point(1336, 459)
        Me.lbl_staff_email.Name = "lbl_staff_email"
        Me.lbl_staff_email.Size = New System.Drawing.Size(120, 27)
        Me.lbl_staff_email.TabIndex = 86
        Me.lbl_staff_email.Text = "Staff Email"
        '
        'lbl_staff_phone
        '
        Me.lbl_staff_phone.AutoSize = True
        Me.lbl_staff_phone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_phone.Location = New System.Drawing.Point(1336, 432)
        Me.lbl_staff_phone.Name = "lbl_staff_phone"
        Me.lbl_staff_phone.Size = New System.Drawing.Size(125, 27)
        Me.lbl_staff_phone.TabIndex = 87
        Me.lbl_staff_phone.Text = "Staff Phone"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(1371, 883)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(60, 32)
        Me.Label26.TabIndex = 89
        Me.Label26.Text = "RM"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(1425, 883)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(32, 32)
        Me.lbl_total.TabIndex = 90
        Me.lbl_total.Text = "0"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(1282, 883)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(94, 29)
        Me.Label28.TabIndex = 88
        Me.Label28.Text = "Total : "
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Thistle
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(12, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(129, 44)
        Me.btn_back.TabIndex = 91
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(649, 1016)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(293, 27)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "Thank you for your business!"
        '
        'frm_invoice_a195281
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1562, 1090)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.lbl_staff_phone)
        Me.Controls.Add(Me.lbl_staff_email)
        Me.Controls.Add(Me.lbl_staff_name)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbl_order_date)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmb_order_id)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_customer_email)
        Me.Controls.Add(Me.lbl_customer_phone)
        Me.Controls.Add(Me.lbl_customer_address)
        Me.Controls.Add(Me.lbl_customer_name)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_orders)
        Me.Name = "frm_invoice_a195281"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        CType(Me.grd_orders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_orders As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_customer_name As Label
    Friend WithEvents lbl_customer_address As Label
    Friend WithEvents lbl_customer_phone As Label
    Friend WithEvents lbl_customer_email As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmb_order_id As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_order_date As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_staff_name As Label
    Friend WithEvents lbl_staff_email As Label
    Friend WithEvents lbl_staff_phone As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents Label13 As Label
End Class
