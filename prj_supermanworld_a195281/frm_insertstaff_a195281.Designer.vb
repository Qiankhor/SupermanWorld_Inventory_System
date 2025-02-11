<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertstaff_a195281
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertstaff_a195281))
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_phone
        '
        Me.txt_phone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone.Location = New System.Drawing.Point(202, 653)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(399, 35)
        Me.txt_phone.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 657)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 27)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Phone No. :"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(202, 597)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(399, 35)
        Me.txt_email.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 601)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 27)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Email :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 544)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 27)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Name :"
        Me.Label1.UseWaitCursor = True
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(209, 484)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(392, 35)
        Me.txt_id.TabIndex = 35
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(98, 488)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(101, 27)
        Me.lbl_id.TabIndex = 34
        Me.lbl_id.Text = "Staff ID :"
        '
        'grd_staff
        '
        Me.grd_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(45, 197)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.RowHeadersWidth = 62
        Me.grd_staff.RowTemplate.Height = 28
        Me.grd_staff.Size = New System.Drawing.Size(609, 246)
        Me.grd_staff.TabIndex = 33
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(199, 88)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(301, 63)
        Me.lbl_title.TabIndex = 32
        Me.lbl_title.Text = "Insert Staff"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.DarkBlue
        Me.btn_insert.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.Color.White
        Me.btn_insert.Location = New System.Drawing.Point(190, 735)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(297, 55)
        Me.btn_insert.TabIndex = 42
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(25, 21)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(129, 44)
        Me.btn_back.TabIndex = 43
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(209, 544)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(392, 35)
        Me.txt_name.TabIndex = 45
        '
        'frm_insertstaff_a195281
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(709, 837)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.grd_staff)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_insertstaff_a195281"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Staff"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_phone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents txt_name As TextBox
End Class
