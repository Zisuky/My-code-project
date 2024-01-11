<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Qlsv
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHoten = New System.Windows.Forms.TextBox()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.txtMSV = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnFix = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.BHTTTSV = New System.Windows.Forms.DataGridView()
        Me.gbTTSV = New System.Windows.Forms.GroupBox()
        Me.txtGioiTinh = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtMaKhoa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnTIMKIEM = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.QLSVDataSet = New do_an.QLSVDataSet()
        Me.SINHVIENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SINHVIENTableAdapter = New do_an.QLSVDataSetTableAdapters.SINHVIENTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BHTTTSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTTSV.SuspendLayout()
        CType(Me.QLSVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SINHVIENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Họ tên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ngày sinh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mã sinh viên"
        '
        'txtHoten
        '
        Me.txtHoten.BackColor = System.Drawing.Color.White
        Me.txtHoten.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SINHVIENBindingSource, "HOSV", True))
        Me.txtHoten.Location = New System.Drawing.Point(182, 13)
        Me.txtHoten.Multiline = True
        Me.txtHoten.Name = "txtHoten"
        Me.txtHoten.Size = New System.Drawing.Size(237, 42)
        Me.txtHoten.TabIndex = 1
        '
        'txtTen
        '
        Me.txtTen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SINHVIENBindingSource, "TENSV", True))
        Me.txtTen.Location = New System.Drawing.Point(182, 61)
        Me.txtTen.Multiline = True
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(237, 42)
        Me.txtTen.TabIndex = 1
        '
        'txtMSV
        '
        Me.txtMSV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SINHVIENBindingSource, "MASV", True))
        Me.txtMSV.Location = New System.Drawing.Point(182, 241)
        Me.txtMSV.Multiline = True
        Me.txtMSV.Name = "txtMSV"
        Me.txtMSV.Size = New System.Drawing.Size(237, 42)
        Me.txtMSV.TabIndex = 1
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(559, 343)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(91, 23)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "THÊM "
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnFix
        '
        Me.btnFix.Location = New System.Drawing.Point(691, 343)
        Me.btnFix.Name = "btnFix"
        Me.btnFix.Size = New System.Drawing.Size(112, 23)
        Me.btnFix.TabIndex = 2
        Me.btnFix.Text = "CHỈNH SỬA"
        Me.btnFix.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(859, 343)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(93, 23)
        Me.btnXoa.TabIndex = 2
        Me.btnXoa.Text = "XÓA"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'BHTTTSV
        '
        Me.BHTTTSV.AllowUserToOrderColumns = True
        Me.BHTTTSV.AutoGenerateColumns = False
        Me.BHTTTSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BHTTTSV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.HOSVDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.BHTTTSV.DataSource = Me.SINHVIENBindingSource
        Me.BHTTTSV.Location = New System.Drawing.Point(492, 45)
        Me.BHTTTSV.Name = "BHTTTSV"
        Me.BHTTTSV.RowTemplate.Height = 24
        Me.BHTTTSV.Size = New System.Drawing.Size(766, 269)
        Me.BHTTTSV.TabIndex = 3
        '
        'gbTTSV
        '
        Me.gbTTSV.Controls.Add(Me.txtGioiTinh)
        Me.gbTTSV.Controls.Add(Me.Label6)
        Me.gbTTSV.Controls.Add(Me.DateTimePicker1)
        Me.gbTTSV.Controls.Add(Me.txtTen)
        Me.gbTTSV.Controls.Add(Me.txtMaKhoa)
        Me.gbTTSV.Controls.Add(Me.txtHoten)
        Me.gbTTSV.Controls.Add(Me.txtMSV)
        Me.gbTTSV.Controls.Add(Me.Label3)
        Me.gbTTSV.Controls.Add(Me.Label7)
        Me.gbTTSV.Controls.Add(Me.Label2)
        Me.gbTTSV.Controls.Add(Me.Label4)
        Me.gbTTSV.Controls.Add(Me.Label1)
        Me.gbTTSV.Location = New System.Drawing.Point(12, 34)
        Me.gbTTSV.Name = "gbTTSV"
        Me.gbTTSV.Size = New System.Drawing.Size(474, 420)
        Me.gbTTSV.TabIndex = 4
        Me.gbTTSV.TabStop = False
        Me.gbTTSV.Text = "Thông tin sinh viên"
        '
        'txtGioiTinh
        '
        Me.txtGioiTinh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SINHVIENBindingSource, "PHAI", True))
        Me.txtGioiTinh.Location = New System.Drawing.Point(180, 165)
        Me.txtGioiTinh.Multiline = True
        Me.txtGioiTinh.Name = "txtGioiTinh"
        Me.txtGioiTinh.Size = New System.Drawing.Size(238, 40)
        Me.txtGioiTinh.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Giới Tính"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SINHVIENBindingSource, "NS", True))
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SINHVIENBindingSource, "NS", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(182, 123)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(237, 22)
        Me.DateTimePicker1.TabIndex = 2
        '
        'txtMaKhoa
        '
        Me.txtMaKhoa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SINHVIENBindingSource, "MAKHOA", True))
        Me.txtMaKhoa.Location = New System.Drawing.Point(180, 309)
        Me.txtMaKhoa.Multiline = True
        Me.txtMaKhoa.Name = "txtMaKhoa"
        Me.txtMaKhoa.Size = New System.Drawing.Size(237, 42)
        Me.txtMaKhoa.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Mã Khoa"
        '
        'btnTIMKIEM
        '
        Me.btnTIMKIEM.Location = New System.Drawing.Point(989, 341)
        Me.btnTIMKIEM.Name = "btnTIMKIEM"
        Me.btnTIMKIEM.Size = New System.Drawing.Size(112, 27)
        Me.btnTIMKIEM.TabIndex = 5
        Me.btnTIMKIEM.Text = "TÌM KIẾM"
        Me.btnTIMKIEM.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(812, 402)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'QLSVDataSet
        '
        Me.QLSVDataSet.DataSetName = "QLSVDataSet"
        Me.QLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SINHVIENBindingSource
        '
        Me.SINHVIENBindingSource.DataMember = "SINHVIEN"
        Me.SINHVIENBindingSource.DataSource = Me.QLSVDataSet
        '
        'SINHVIENTableAdapter
        '
        Me.SINHVIENTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MASV"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MASV"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'HOSVDataGridViewTextBoxColumn
        '
        Me.HOSVDataGridViewTextBoxColumn.DataPropertyName = "HOSV"
        Me.HOSVDataGridViewTextBoxColumn.HeaderText = "HOSV"
        Me.HOSVDataGridViewTextBoxColumn.Name = "HOSVDataGridViewTextBoxColumn"
        Me.HOSVDataGridViewTextBoxColumn.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TENSV"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TENSV"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PHAI"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PHAI"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NS"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NS"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MAKHOA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MAKHOA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Qlsv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 456)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnTIMKIEM)
        Me.Controls.Add(Me.gbTTSV)
        Me.Controls.Add(Me.BHTTTSV)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnFix)
        Me.Controls.Add(Me.btnThem)
        Me.Name = "Qlsv"
        Me.Text = "Quản Lý Sinh Viên"
        CType(Me.BHTTTSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTTSV.ResumeLayout(False)
        Me.gbTTSV.PerformLayout()
        CType(Me.QLSVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SINHVIENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHoten As TextBox
    Friend WithEvents txtTen As TextBox
    Friend WithEvents txtMSV As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnFix As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents BHTTTSV As DataGridView
    Friend WithEvents gbTTSV As GroupBox
    Friend WithEvents btnTIMKIEM As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtGioiTinh As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMaKhoa As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents MASVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TENSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PHAIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MAKHOADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QLSVDataSet As QLSVDataSet
    Friend WithEvents SINHVIENBindingSource As BindingSource
    Friend WithEvents SINHVIENTableAdapter As QLSVDataSetTableAdapters.SINHVIENTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents HOSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
