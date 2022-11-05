namespace Finally_project
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.panelNhanvien = new System.Windows.Forms.Panel();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnNV = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.lbChucvu = new System.Windows.Forms.Label();
            this.linkAdminHK = new System.Windows.Forms.LinkLabel();
            this.linkAdminQH = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.NavbarR = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.main = new System.Windows.Forms.Panel();
            this.panelNhanvien.SuspendLayout();
            this.header.SuspendLayout();
            this.NavbarR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "HK_BRAND";
            // 
            // panelNhanvien
            // 
            this.panelNhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.panelNhanvien.Controls.Add(this.btnSanPham);
            this.panelNhanvien.Controls.Add(this.btnRegister);
            this.panelNhanvien.Controls.Add(this.label1);
            this.panelNhanvien.Controls.Add(this.btnNV);
            this.panelNhanvien.Controls.Add(this.btnDangXuat);
            this.panelNhanvien.Controls.Add(this.btnKhachHang);
            this.panelNhanvien.Controls.Add(this.btnStatistical);
            this.panelNhanvien.Controls.Add(this.btnDonHang);
            this.panelNhanvien.Controls.Add(this.btnNhapHang);
            this.panelNhanvien.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNhanvien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelNhanvien.Location = new System.Drawing.Point(0, 37);
            this.panelNhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.panelNhanvien.Name = "panelNhanvien";
            this.panelNhanvien.Size = new System.Drawing.Size(267, 674);
            this.panelNhanvien.TabIndex = 3;
            // 
            // btnSanPham
            // 
            this.btnSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSanPham.Image = global::Finally_project.Properties.Resources.icons8_used_product_35;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(36, 428);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(200, 43);
            this.btnSanPham.TabIndex = 15;
            this.btnSanPham.Text = "  Sản phẩm";
            this.btnSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegister.Image = global::Finally_project.Properties.Resources.add_user_male_30px;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(35, 494);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 43);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "    Đăng Ký";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnNV
            // 
            this.btnNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNV.FlatAppearance.BorderSize = 0;
            this.btnNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNV.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNV.Image = global::Finally_project.Properties.Resources.settings_26px;
            this.btnNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNV.Location = new System.Drawing.Point(36, 85);
            this.btnNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(200, 43);
            this.btnNV.TabIndex = 12;
            this.btnNV.Text = "Nhân viên";
            this.btnNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNV.UseVisualStyleBackColor = false;
            this.btnNV.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.btnDangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDangXuat.Image = global::Finally_project.Properties.Resources.shutdown_26px;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(36, 575);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(200, 43);
            this.btnDangXuat.TabIndex = 13;
            this.btnDangXuat.Text = "    Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKhachHang.Image = global::Finally_project.Properties.Resources.management_30px;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(36, 287);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(200, 43);
            this.btnKhachHang.TabIndex = 11;
            this.btnKhachHang.Text = "    Khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnStatistical
            // 
            this.btnStatistical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatistical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnStatistical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStatistical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistical.FlatAppearance.BorderSize = 0;
            this.btnStatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistical.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistical.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStatistical.Image = global::Finally_project.Properties.Resources.icons8_used_product_35;
            this.btnStatistical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistical.Location = new System.Drawing.Point(36, 363);
            this.btnStatistical.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(200, 43);
            this.btnStatistical.TabIndex = 10;
            this.btnStatistical.Text = "  Thống kê";
            this.btnStatistical.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStatistical.UseVisualStyleBackColor = false;
            this.btnStatistical.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnDonHang
            // 
            this.btnDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnDonHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDonHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonHang.FlatAppearance.BorderSize = 0;
            this.btnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDonHang.Image = global::Finally_project.Properties.Resources.icons8_order_35;
            this.btnDonHang.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDonHang.Location = new System.Drawing.Point(35, 149);
            this.btnDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(200, 43);
            this.btnDonHang.TabIndex = 9;
            this.btnDonHang.Text = "    Đơn hàng";
            this.btnDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDonHang.UseVisualStyleBackColor = false;
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnNhapHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNhapHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNhapHang.Image = global::Finally_project.Properties.Resources.icons8_home_32;
            this.btnNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.Location = new System.Drawing.Point(35, 215);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(200, 43);
            this.btnNhapHang.TabIndex = 8;
            this.btnNhapHang.Text = "Nguồn hàng";
            this.btnNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click_1);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.header.Controls.Add(this.button1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1320, 37);
            this.header.TabIndex = 4;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1269, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName.Location = new System.Drawing.Point(60, 149);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 25);
            this.txtName.TabIndex = 8;
            this.txtName.Text = "QUANG HUY";
            // 
            // lbChucvu
            // 
            this.lbChucvu.AutoSize = true;
            this.lbChucvu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.lbChucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucvu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbChucvu.Location = new System.Drawing.Point(100, 206);
            this.lbChucvu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChucvu.Name = "lbChucvu";
            this.lbChucvu.Size = new System.Drawing.Size(82, 20);
            this.lbChucvu.TabIndex = 9;
            this.lbChucvu.Text = "QUẢN LÝ";
            // 
            // linkAdminHK
            // 
            this.linkAdminHK.AutoSize = true;
            this.linkAdminHK.Location = new System.Drawing.Point(129, 594);
            this.linkAdminHK.Name = "linkAdminHK";
            this.linkAdminHK.Size = new System.Drawing.Size(81, 16);
            this.linkAdminHK.TabIndex = 12;
            this.linkAdminHK.TabStop = true;
            this.linkAdminHK.Text = "Hồng Khang";
            this.linkAdminHK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdminHK_LinkClicked);
            // 
            // linkAdminQH
            // 
            this.linkAdminQH.AutoSize = true;
            this.linkAdminQH.Location = new System.Drawing.Point(129, 624);
            this.linkAdminQH.Name = "linkAdminQH";
            this.linkAdminQH.Size = new System.Drawing.Size(74, 16);
            this.linkAdminQH.TabIndex = 13;
            this.linkAdminQH.TabStop = true;
            this.linkAdminQH.Text = "Quang Huy";
            this.linkAdminQH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdminQH_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(99, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Copyright";
            // 
            // NavbarR
            // 
            this.NavbarR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.NavbarR.Controls.Add(this.pictureBox2);
            this.NavbarR.Controls.Add(this.pictureBox1);
            this.NavbarR.Controls.Add(this.label3);
            this.NavbarR.Controls.Add(this.Logo);
            this.NavbarR.Controls.Add(this.linkAdminQH);
            this.NavbarR.Controls.Add(this.linkAdminHK);
            this.NavbarR.Controls.Add(this.lbChucvu);
            this.NavbarR.Controls.Add(this.txtName);
            this.NavbarR.Dock = System.Windows.Forms.DockStyle.Right;
            this.NavbarR.Location = new System.Drawing.Point(1051, 37);
            this.NavbarR.Margin = new System.Windows.Forms.Padding(4);
            this.NavbarR.Name = "NavbarR";
            this.NavbarR.Size = new System.Drawing.Size(269, 674);
            this.NavbarR.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::Finally_project.Properties.Resources.facebook_48px1;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 592);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Finally_project.Properties.Resources.staff_96px;
            this.pictureBox1.Location = new System.Drawing.Point(75, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 100);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Image = global::Finally_project.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(32, 267);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(207, 139);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 10;
            this.Logo.TabStop = false;
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.main.BackgroundImage = global::Finally_project.Properties.Resources.background;
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.main.Location = new System.Drawing.Point(267, 37);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(784, 674);
            this.main.TabIndex = 6;
            this.main.Paint += new System.Windows.Forms.PaintEventHandler(this.main_Paint);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1320, 711);
            this.Controls.Add(this.main);
            this.Controls.Add(this.panelNhanvien);
            this.Controls.Add(this.NavbarR);
            this.Controls.Add(this.header);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công ty bán lẻ quần áo HK_BRAND";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelNhanvien.ResumeLayout(false);
            this.panelNhanvien.PerformLayout();
            this.header.ResumeLayout(false);
            this.NavbarR.ResumeLayout(false);
            this.NavbarR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNhanvien;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label lbChucvu;
        private System.Windows.Forms.LinkLabel linkAdminHK;
        private System.Windows.Forms.LinkLabel linkAdminQH;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel NavbarR;
        private System.Windows.Forms.Panel main;
    }
}

