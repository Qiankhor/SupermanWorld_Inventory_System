<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updatestaff_a195281
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_updatestaff_a195281))
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.DarkRed
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(377, 763)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(187, 55)
        Me.btn_delete.TabIndex = 59
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_update.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(106, 763)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(187, 55)
        Me.btn_update.TabIndex = 58
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'txt_phone
        '
        Me.txt_phone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone.Location = New System.Drawing.Point(213, 680)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(368, 35)
        Me.txt_phone.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(76, 684)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 27)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Phone No. :"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(213, 626)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(368, 35)
        Me.txt_email.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(122, 628)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 27)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Email :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 565)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 27)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Name :"
        Me.Label1.UseWaitCursor = True
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(213, 505)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(368, 35)
        Me.txt_id.TabIndex = 51
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(101, 509)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(101, 27)
        Me.lbl_id.TabIndex = 50
        Me.lbl_id.Text = "Staff ID :"
        '
        'grd_staff
        '
        Me.grd_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(53, 208)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.RowHeadersWidth = 62
        Me.grd_staff.RowTemplate.Height = 28
        Me.grd_staff.Size = New System.Drawing.Size(595, 246)
        Me.grd_staff.TabIndex = 49
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(185, 104)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(331, 63)
        Me.lbl_title.TabIndex = 48
        Me.lbl_title.Text = "Update Staff"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(26, 22)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(129, 44)
        Me.btn_back.TabIndex = 60
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(213, 564)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(368, 35)
        Me.txt_name.TabIndex = 62
        '
        'frm_updatestaff_a195281
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(717, 864)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.grd_staff)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_updatestaff_a195281"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Staff"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents txt_name As TextBox
End Class
