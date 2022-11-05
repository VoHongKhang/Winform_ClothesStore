namespace Finally_project
{
    partial class AddinputOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.panelMaNCC = new System.Windows.Forms.Panel();
            this.lableTenNV = new System.Windows.Forms.Label();
            this.lableTenKH = new System.Windows.Forms.Label();
            this.cbMaNCC = new System.Windows.Forms.ComboBox();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetNCC = new Finally_project.DataSetNCC();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetNhanVien = new Finally_project.DataSetNhanVien();
            this.dateTimeDHN = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDHN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dgvDHN = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa1 = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.lbSP = new System.Windows.Forms.Label();
            this.lbNV = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMaSP = new System.Windows.Forms.ComboBox();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSP = new Finally_project.DataSetSP();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHuy1 = new System.Windows.Forms.Button();
            this.btnLuu1 = new System.Windows.Forms.Button();
            this.btnSua1 = new System.Windows.Forms.Button();
            this.btnThem1 = new System.Windows.Forms.Button();
            this.dgvCTDHN = new System.Windows.Forms.DataGridView();
            this.cbMaDHN = new System.Windows.Forms.ComboBox();
            this.donHangNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDHN = new Finally_project.DataSetDHN();
            this.label7 = new System.Windows.Forms.Label();
            this.nhaCungCapTableAdapter = new Finally_project.DataSetNCCTableAdapters.NhaCungCapTableAdapter();
            this.nhanVienTableAdapter = new Finally_project.DataSetNhanVienTableAdapters.NhanVienTableAdapter();
            this.donHangNhapTableAdapter = new Finally_project.DataSetDHNTableAdapters.DonHangNhapTableAdapter();
            this.sanPhamTableAdapter = new Finally_project.DataSetSPTableAdapters.SanPhamTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelMaNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDHN)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDHN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donHangNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDHN)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 567);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.panelMaNCC);
            this.tabPage1.Controls.Add(this.btnSua);
            this.tabPage1.Controls.Add(this.btnXoa);
            this.tabPage1.Controls.Add(this.btnTroVe);
            this.tabPage1.Controls.Add(this.btnHuy);
            this.tabPage1.Controls.Add(this.dgvDHN);
            this.tabPage1.Controls.Add(this.btnLuu);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(996, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đơn hàng nhập";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(401, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(191, 25);
            this.label14.TabIndex = 89;
            this.label14.Text = "ĐƠN HÀNG NHẬP";
            // 
            // panelMaNCC
            // 
            this.panelMaNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.panelMaNCC.Controls.Add(this.lableTenNV);
            this.panelMaNCC.Controls.Add(this.lableTenKH);
            this.panelMaNCC.Controls.Add(this.cbMaNCC);
            this.panelMaNCC.Controls.Add(this.cbMaNV);
            this.panelMaNCC.Controls.Add(this.dateTimeDHN);
            this.panelMaNCC.Controls.Add(this.label5);
            this.panelMaNCC.Controls.Add(this.label1);
            this.panelMaNCC.Controls.Add(this.txtMaDHN);
            this.panelMaNCC.Controls.Add(this.label4);
            this.panelMaNCC.Controls.Add(this.label3);
            this.panelMaNCC.Controls.Add(this.label2);
            this.panelMaNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMaNCC.ForeColor = System.Drawing.Color.Transparent;
            this.panelMaNCC.Location = new System.Drawing.Point(6, 53);
            this.panelMaNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMaNCC.Name = "panelMaNCC";
            this.panelMaNCC.Size = new System.Drawing.Size(455, 346);
            this.panelMaNCC.TabIndex = 58;
            // 
            // lableTenNV
            // 
            this.lableTenNV.AutoSize = true;
            this.lableTenNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTenNV.ForeColor = System.Drawing.Color.Black;
            this.lableTenNV.Location = new System.Drawing.Point(176, 229);
            this.lableTenNV.Name = "lableTenNV";
            this.lableTenNV.Size = new System.Drawing.Size(64, 19);
            this.lableTenNV.TabIndex = 19;
            this.lableTenNV.Text = "label16";
            // 
            // lableTenKH
            // 
            this.lableTenKH.AutoSize = true;
            this.lableTenKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTenKH.ForeColor = System.Drawing.Color.Black;
            this.lableTenKH.Location = new System.Drawing.Point(176, 146);
            this.lableTenKH.Name = "lableTenKH";
            this.lableTenKH.Size = new System.Drawing.Size(64, 19);
            this.lableTenKH.TabIndex = 18;
            this.lableTenKH.Text = "label15";
            // 
            // cbMaNCC
            // 
            this.cbMaNCC.DataSource = this.nhaCungCapBindingSource;
            this.cbMaNCC.DisplayMember = "MaNCC";
            this.cbMaNCC.FormattingEnabled = true;
            this.cbMaNCC.Location = new System.Drawing.Point(180, 111);
            this.cbMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaNCC.Name = "cbMaNCC";
            this.cbMaNCC.Size = new System.Drawing.Size(265, 31);
            this.cbMaNCC.TabIndex = 17;
            this.cbMaNCC.ValueMember = "MaNCC";
            this.cbMaNCC.SelectedIndexChanged += new System.EventHandler(this.cbMaNCC_SelectedIndexChanged);
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.dataSetNCC;
            // 
            // dataSetNCC
            // 
            this.dataSetNCC.DataSetName = "DataSetNCC";
            this.dataSetNCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbMaNV
            // 
            this.cbMaNV.DataSource = this.nhanVienBindingSource;
            this.cbMaNV.DisplayMember = "MaNV";
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(180, 194);
            this.cbMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(265, 31);
            this.cbMaNV.TabIndex = 16;
            this.cbMaNV.ValueMember = "MaNV";
            this.cbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbMaNV_SelectedIndexChanged);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.dataSetNhanVienBindingSource;
            // 
            // dataSetNhanVienBindingSource
            // 
            this.dataSetNhanVienBindingSource.DataSource = this.dataSetNhanVien;
            this.dataSetNhanVienBindingSource.Position = 0;
            // 
            // dataSetNhanVien
            // 
            this.dataSetNhanVien.DataSetName = "DataSetNhanVien";
            this.dataSetNhanVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimeDHN
            // 
            this.dateTimeDHN.Location = new System.Drawing.Point(180, 276);
            this.dateTimeDHN.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeDHN.Name = "dateTimeDHN";
            this.dateTimeDHN.Size = new System.Drawing.Size(265, 30);
            this.dateTimeDHN.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã đơn hàng nhập";
            // 
            // txtMaDHN
            // 
            this.txtMaDHN.Location = new System.Drawing.Point(180, 32);
            this.txtMaDHN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDHN.Multiline = true;
            this.txtMaDHN.Name = "txtMaDHN";
            this.txtMaDHN.Size = new System.Drawing.Size(265, 28);
            this.txtMaDHN.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhà cung cấp";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(548, 455);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 37);
            this.btnSua.TabIndex = 56;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_2);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(186, 455);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 37);
            this.btnXoa.TabIndex = 57;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.btnTroVe.FlatAppearance.BorderSize = 0;
            this.btnTroVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroVe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(867, 455);
            this.btnTroVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(105, 37);
            this.btnTroVe.TabIndex = 55;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click_1);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHuy.Location = new System.Drawing.Point(709, 455);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 37);
            this.btnHuy.TabIndex = 54;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dgvDHN
            // 
            this.dgvDHN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDHN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDHN.Location = new System.Drawing.Point(470, 53);
            this.dgvDHN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDHN.Name = "dgvDHN";
            this.dgvDHN.RowHeadersWidth = 51;
            this.dgvDHN.RowTemplate.Height = 24;
            this.dgvDHN.Size = new System.Drawing.Size(502, 346);
            this.dgvDHN.TabIndex = 53;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuu.Location = new System.Drawing.Point(356, 455);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 37);
            this.btnLuu.TabIndex = 52;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(23, 455);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 37);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.tabPage2.Controls.Add(this.btnThoat);
            this.tabPage2.Controls.Add(this.btnXoa1);
            this.tabPage2.Controls.Add(this.dateTime);
            this.tabPage2.Controls.Add(this.lbSP);
            this.tabPage2.Controls.Add(this.lbNV);
            this.tabPage2.Controls.Add(this.lbTenKH);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtSoluong);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbMaSP);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnHuy1);
            this.tabPage2.Controls.Add(this.btnLuu1);
            this.tabPage2.Controls.Add(this.btnSua1);
            this.tabPage2.Controls.Add(this.btnThem1);
            this.tabPage2.Controls.Add(this.dgvCTDHN);
            this.tabPage2.Controls.Add(this.cbMaDHN);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(996, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi tiết đơn hàng nhập";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.btnThoat.Location = new System.Drawing.Point(881, 483);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 36);
            this.btnThoat.TabIndex = 109;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa1
            // 
            this.btnXoa1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.btnXoa1.Location = new System.Drawing.Point(470, 485);
            this.btnXoa1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(75, 37);
            this.btnXoa1.TabIndex = 108;
            this.btnXoa1.Text = "Xóa";
            this.btnXoa1.UseVisualStyleBackColor = false;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click_1);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(699, 188);
            this.dateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(188, 22);
            this.dateTime.TabIndex = 107;
            // 
            // lbSP
            // 
            this.lbSP.AutoSize = true;
            this.lbSP.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSP.Location = new System.Drawing.Point(680, 133);
            this.lbSP.Name = "lbSP";
            this.lbSP.Size = new System.Drawing.Size(133, 20);
            this.lbSP.TabIndex = 106;
            this.lbSP.Text = "Tên khách hàng";
            // 
            // lbNV
            // 
            this.lbNV.AutoSize = true;
            this.lbNV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNV.Location = new System.Drawing.Point(313, 199);
            this.lbNV.Name = "lbNV";
            this.lbNV.Size = new System.Drawing.Size(133, 20);
            this.lbNV.TabIndex = 105;
            this.lbNV.Text = "Tên khách hàng";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKH.Location = new System.Drawing.Point(276, 143);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(59, 20);
            this.lbTenKH.TabIndex = 104;
            this.lbTenKH.Text = "      ....";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(560, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 20);
            this.label13.TabIndex = 103;
            this.label13.Text = "Ngày tạo đơn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(127, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 20);
            this.label12.TabIndex = 102;
            this.label12.Text = "Nhân viên nhập";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(109, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 20);
            this.label11.TabIndex = 101;
            this.label11.Text = "Tên nhà cung cấp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(560, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 100;
            this.label9.Text = "Sản phẩm";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(317, 251);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoluong.Multiline = true;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(140, 23);
            this.txtSoluong.TabIndex = 99;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(127, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 98;
            this.label8.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(560, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 97;
            this.label6.Text = "Mã sản phẩm";
            // 
            // cbMaSP
            // 
            this.cbMaSP.DataSource = this.sanPhamBindingSource;
            this.cbMaSP.DisplayMember = "MaSP";
            this.cbMaSP.FormattingEnabled = true;
            this.cbMaSP.Location = new System.Drawing.Point(707, 82);
            this.cbMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(180, 24);
            this.cbMaSP.TabIndex = 96;
            this.cbMaSP.ValueMember = "MaSP";
            this.cbMaSP.SelectedIndexChanged += new System.EventHandler(this.cbMaSP_SelectedIndexChanged);
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.dataSetSPBindingSource;
            // 
            // dataSetSPBindingSource
            // 
            this.dataSetSPBindingSource.DataSource = this.dataSetSP;
            this.dataSetSPBindingSource.Position = 0;
            // 
            // dataSetSP
            // 
            this.dataSetSP.DataSetName = "DataSetSP";
            this.dataSetSP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(127, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 20);
            this.label10.TabIndex = 95;
            this.label10.Text = "Mã đơn hàng nhập";
            // 
            // btnHuy1
            // 
            this.btnHuy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.btnHuy1.Location = new System.Drawing.Point(564, 485);
            this.btnHuy1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy1.Name = "btnHuy1";
            this.btnHuy1.Size = new System.Drawing.Size(75, 37);
            this.btnHuy1.TabIndex = 94;
            this.btnHuy1.Text = "Hủy";
            this.btnHuy1.UseVisualStyleBackColor = false;
            this.btnHuy1.Click += new System.EventHandler(this.btnHuy1_Click_1);
            // 
            // btnLuu1
            // 
            this.btnLuu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.btnLuu1.Location = new System.Drawing.Point(679, 485);
            this.btnLuu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu1.Name = "btnLuu1";
            this.btnLuu1.Size = new System.Drawing.Size(75, 36);
            this.btnLuu1.TabIndex = 93;
            this.btnLuu1.Text = "Lưu";
            this.btnLuu1.UseVisualStyleBackColor = false;
            this.btnLuu1.Click += new System.EventHandler(this.btnLuu1_Click_1);
            // 
            // btnSua1
            // 
            this.btnSua1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.btnSua1.Location = new System.Drawing.Point(364, 483);
            this.btnSua1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua1.Name = "btnSua1";
            this.btnSua1.Size = new System.Drawing.Size(75, 39);
            this.btnSua1.TabIndex = 92;
            this.btnSua1.Text = "Sửa";
            this.btnSua1.UseVisualStyleBackColor = false;
            this.btnSua1.Click += new System.EventHandler(this.btnSua1_Click_1);
            // 
            // btnThem1
            // 
            this.btnThem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.btnThem1.Location = new System.Drawing.Point(269, 483);
            this.btnThem1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(75, 39);
            this.btnThem1.TabIndex = 91;
            this.btnThem1.Text = "Thêm ";
            this.btnThem1.UseVisualStyleBackColor = false;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click_1);
            // 
            // dgvCTDHN
            // 
            this.dgvCTDHN.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTDHN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDHN.Location = new System.Drawing.Point(269, 309);
            this.dgvCTDHN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCTDHN.Name = "dgvCTDHN";
            this.dgvCTDHN.RowHeadersWidth = 51;
            this.dgvCTDHN.Size = new System.Drawing.Size(485, 160);
            this.dgvCTDHN.TabIndex = 90;
            // 
            // cbMaDHN
            // 
            this.cbMaDHN.DataSource = this.donHangNhapBindingSource;
            this.cbMaDHN.DisplayMember = "MaDHN";
            this.cbMaDHN.FormattingEnabled = true;
            this.cbMaDHN.Location = new System.Drawing.Point(317, 82);
            this.cbMaDHN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaDHN.Name = "cbMaDHN";
            this.cbMaDHN.Size = new System.Drawing.Size(140, 24);
            this.cbMaDHN.TabIndex = 89;
            this.cbMaDHN.ValueMember = "MaDHN";
            this.cbMaDHN.SelectedIndexChanged += new System.EventHandler(this.cbMaDHN_SelectedIndexChanged);
            // 
            // donHangNhapBindingSource
            // 
            this.donHangNhapBindingSource.DataMember = "DonHangNhap";
            this.donHangNhapBindingSource.DataSource = this.dataSetDHN;
            // 
            // dataSetDHN
            // 
            this.dataSetDHN.DataSetName = "DataSetDHN";
            this.dataSetDHN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(372, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 25);
            this.label7.TabIndex = 88;
            this.label7.Text = "CHI TIẾT ĐƠN HÀNG NHẬP";
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // donHangNhapTableAdapter
            // 
            this.donHangNhapTableAdapter.ClearBeforeFill = true;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // AddinputOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1038, 591);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddinputOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddinputOrderForm";
            this.Load += new System.EventHandler(this.AddinputOrderForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelMaNCC.ResumeLayout(false);
            this.panelMaNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDHN)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDHN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donHangNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDHN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelMaNCC;
        private System.Windows.Forms.ComboBox cbMaNCC;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.DateTimePicker dateTimeDHN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDHN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDHN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa1;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label lbSP;
        private System.Windows.Forms.Label lbNV;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMaSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnHuy1;
        private System.Windows.Forms.Button btnLuu1;
        private System.Windows.Forms.Button btnSua1;
        private System.Windows.Forms.Button btnThem1;
        private System.Windows.Forms.DataGridView dgvCTDHN;
        private System.Windows.Forms.ComboBox cbMaDHN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private DataSetNCC dataSetNCC;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private DataSetNCCTableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private System.Windows.Forms.Label lableTenNV;
        private System.Windows.Forms.Label lableTenKH;
        private System.Windows.Forms.BindingSource dataSetNhanVienBindingSource;
        private DataSetNhanVien dataSetNhanVien;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DataSetNhanVienTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DataSetDHN dataSetDHN;
        private System.Windows.Forms.BindingSource donHangNhapBindingSource;
        private DataSetDHNTableAdapters.DonHangNhapTableAdapter donHangNhapTableAdapter;
        private System.Windows.Forms.BindingSource dataSetSPBindingSource;
        private DataSetSP dataSetSP;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private DataSetSPTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
    }
}