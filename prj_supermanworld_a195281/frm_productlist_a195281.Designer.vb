<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productlist_a195281
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productlist_a195281))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lst_id = New System.Windows.Forms.ListBox()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_releasedate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(714, 101)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(406, 55)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Product Catalogue"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Khaki
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(31, 24)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(129, 44)
        Me.btn_back.TabIndex = 5
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lst_id
        '
        Me.lst_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_id.FormattingEnabled = True
        Me.lst_id.ItemHeight = 27
        Me.lst_id.Location = New System.Drawing.Point(46, 215)
        Me.lst_id.Name = "lst_id"
        Me.lst_id.Size = New System.Drawing.Size(167, 328)
        Me.lst_id.TabIndex = 62
        '
        'txt_description
        '
        Me.txt_description.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_description.Location = New System.Drawing.Point(421, 489)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(1008, 35)
        Me.txt_description.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(280, 492)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 27)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Description :"
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(1485, 215)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(299, 309)
        Me.pic_product.TabIndex = 59
        Me.pic_product.TabStop = False
        '
        'txt_quantity
        '
        Me.txt_quantity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantity.Location = New System.Drawing.Point(1035, 419)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(394, 35)
        Me.txt_quantity.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(950, 423)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 27)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Stock :"
        '
        'txt_releasedate
        '
        Me.txt_releasedate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_releasedate.Location = New System.Drawing.Point(421, 419)
        Me.txt_releasedate.Name = "txt_releasedate"
        Me.txt_releasedate.Size = New System.Drawing.Size(381, 35)
        Me.txt_releasedate.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(264, 423)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 27)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Release Date :"
        '
        'txt_type
        '
        Me.txt_type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type.Location = New System.Drawing.Point(1035, 346)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(394, 35)
        Me.txt_type.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(956, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 27)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Type :"
        '
        'txt_brand
        '
        Me.txt_brand.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(421, 346)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(381, 35)
        Me.txt_brand.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(332, 350)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 27)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Brand :"
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(1035, 215)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(394, 35)
        Me.txt_price.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(894, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 27)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Price (RM) :"
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(421, 272)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(1008, 35)
        Me.txt_name.TabIndex = 48
        Me.txt_name.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 27)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Product Name :"
        Me.Label1.UseWaitCursor = True
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(421, 215)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(381, 35)
        Me.txt_id.TabIndex = 46
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(284, 219)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(131, 27)
        Me.lbl_id.TabIndex = 45
        Me.lbl_id.Text = "Product ID :"
        '
        'grd_products
        '
        Me.grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(46, 590)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.RowHeadersWidth = 62
        Me.grd_products.RowTemplate.Height = 28
        Me.grd_products.Size = New System.Drawing.Size(1738, 281)
        Me.grd_products.TabIndex = 64
        '
        'frm_productlist_a195281
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1895, 930)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.lst_id)
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
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_productlist_a195281"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Catalogue"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents lst_id As ListBox
    Friend WithEvents txt_description As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_releasedate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_type As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents grd_products As DataGridView
End Class
