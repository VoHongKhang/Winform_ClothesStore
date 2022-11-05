using Finally_project.Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finally_project
{

    public partial class Home : Form
    {
        
        public void ChangeColor()
        {

            btnNV.BackColor = System.Drawing.Color.FromArgb(82, 82, 82);
            btnStatistical.BackColor = System.Drawing.Color.FromArgb(82, 82, 82);
            btnRegister.BackColor = System.Drawing.Color.FromArgb(82, 82, 82);
            btnDonHang.BackColor = System.Drawing.Color.FromArgb(82, 82, 82);
            btnKhachHang.BackColor = System.Drawing.Color.FromArgb(82, 82, 82);
            btnNhapHang.BackColor = System.Drawing.Color.FromArgb(82, 82, 82);
            btnSanPham.BackColor = System.Drawing.Color.FromArgb(82, 82, 82);

            btnStatistical.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnRegister.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnNV.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnDonHang.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnKhachHang.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnSanPham.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btnNhapHang.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        }
        public Home()
        {
            InitializeComponent();
        }
        public Home(Form form)
        {
            InitializeComponent();
            loadform(form);
        }
        public Home(TaiKhoan tk)
        {
            InitializeComponent();

            txtName.Text = tk.TenDN.Trim();
            lbChucvu.Text = tk.LoaiTK.Trim();
            if (tk.LoaiTK.Trim() =="Nhan Vien")
            {
                btnSanPham.Hide();
                btnNhapHang.Hide();
                btnRegister.Hide();
                btnNV.Hide();
            }
            else
            {
                btnSanPham.Show();
                btnNhapHang.Show();
                btnRegister.Show();
                btnNV.Show();
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void loadform(object Form)
        {
            if (this.main.Controls.Count > 0)
            {
                this.main.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.main.Controls.Add(f);
            this.main.Tag = f;
            f.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new LoginForm();
            frm.ShowDialog();
        }
        private void btnNhapHang_Click_1(object sender, EventArgs e)
        {
            loadform(new InputOrderForm());
            ChangeColor();
            btnNhapHang.BackColor = System.Drawing.Color.FromArgb(240, 240, 150);
            btnNhapHang.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
        }
        private void btnDonHang_Click(object sender, EventArgs e)
        {
            loadform(new OrderForm());
            ChangeColor();
            btnDonHang.BackColor = System.Drawing.Color.FromArgb(240, 240, 150);
            btnDonHang.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            loadform(new ProductForm());
            ChangeColor();
            btnStatistical.BackColor = System.Drawing.Color.FromArgb(240, 240, 150);
            btnStatistical.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            loadform(new ClientForm());
            ChangeColor();
            btnKhachHang.BackColor = System.Drawing.Color.FromArgb(240, 240, 150);
            btnKhachHang.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
        }

        private void linkAdminHK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkAdminHK.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100007879276932");
        }

        private void linkAdminQH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkAdminQH.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.facebook.com/huyvff111");
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            loadform(new SettingForm());
            ChangeColor();
            btnNV.BackColor = System.Drawing.Color.FromArgb(240, 240, 150);
            btnNV.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            loadform(new RegisterForm());
            ChangeColor();
            btnRegister.BackColor = System.Drawing.Color.FromArgb(240, 240, 150);
            btnRegister.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new ProductsForm());
            ChangeColor();
            btnSanPham.BackColor = System.Drawing.Color.FromArgb(240, 240, 150);
            btnSanPham.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
