<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproduct_a195281
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertproduct_a195281))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_releasedate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(600, 56)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(378, 63)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Insert Product"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(495, 608)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(131, 27)
        Me.lbl_id.TabIndex = 3
        Me.lbl_id.Text = "Product ID :"
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(632, 604)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(267, 35)
        Me.txt_id.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(463, 669)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 27)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Product Name :"
        Me.Label1.UseWaitCursor = True
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(1090, 604)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(280, 35)
        Me.txt_price.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(951, 608)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 27)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Price (RM) :"
        '
        'txt_brand
        '
        Me.txt_brand.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(632, 735)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(267, 35)
        Me.txt_brand.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(543, 739)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 27)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Brand :"
        '
        'txt_type
        '
        Me.txt_type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type.Location = New System.Drawing.Point(1090, 735)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(280, 35)
        Me.txt_type.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1013, 739)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 27)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Type :"
        '
        'txt_releasedate
        '
        Me.txt_releasedate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_releasedate.Location = New System.Drawing.Point(632, 808)
        Me.txt_releasedate.Name = "txt_releasedate"
        Me.txt_releasedate.Size = New System.Drawing.Size(267, 35)
        Me.txt_releasedate.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(475, 812)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 27)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Release Date :"
        '
        'txt_quantity
        '
        Me.txt_quantity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(1090, 808)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(280, 35)
        Me.txt_quantity.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1004, 812)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 27)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Stock :"
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(106, 604)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(299, 309)
        Me.pic_product.TabIndex = 17
        Me.pic_product.TabStop = False
        '
        'txt_description
        '
        Me.txt_description.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_description.Location = New System.Drawing.Point(632, 878)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(738, 35)
        Me.txt_description.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(491, 881)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 27)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Description :"
        '
        'btn_picture
        '
        Me.btn_picture.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_picture.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_picture.ForeColor = System.Drawing.Color.White
        Me.btn_picture.Location = New System.Drawing.Point(120, 956)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(265, 55)
        Me.btn_picture.TabIndex = 20
        Me.btn_picture.Text = "SELECT PICTURE"
        Me.btn_picture.UseVisualStyleBackColor = False
        '
        'grd_products
        '
        Me.grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(64, 147)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.RowHeadersWidth = 62
        Me.grd_products.RowTemplate.Height = 28
        Me.grd_products.Size = New System.Drawing.Size(1382, 399)
        Me.grd_products.TabIndex = 21
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.DarkBlue
        Me.btn_insert.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.Color.White
        Me.btn_insert.Location = New System.Drawing.Point(787, 956)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(297, 55)
        Me.btn_insert.TabIndex = 22
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Khaki
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(23, 21)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(129, 44)
        Me.btn_back.TabIndex = 23
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(632, 666)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(738, 35)
        Me.txt_name.TabIndex = 38
        '
        'frm_insertproduct_a195281
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1531, 1084)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_releasedate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_insertproduct_a195281"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Product"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_type As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_releasedate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_description As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_picture As Button
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents btn_insert As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_back As Button
    Friend WithEvents txt_name As TextBox
End Class
