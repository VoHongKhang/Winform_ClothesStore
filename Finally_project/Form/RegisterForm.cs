using Finally_project.Database.CreateData;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            ModelQuanLyCuaHangQuanAo Models = new ModelQuanLyCuaHangQuanAo();
            List<TaiKhoan> tk = Models.TaiKhoans.ToList();   
            List<NhanVien> nv = Models.NhanViens.ToList();

            var taiKhoan = new TaiKhoan
            {
                TenDN = this.txtDangNhap.Text,
                MatKhau = this.txtMatKhau.Text,
                MaNV = this.txtMaNV.Text,
                LoaiTK = this.txtChucVu.Text
            };
            var nhanVien = new NhanVien
            {
                MaNV = this.txtMaNV.Text,
                TenNV=this.txtHoTen.Text,
                GioiTinh=this.checkNam.Checked ?  "Nam" : "Nu",
                DiaChi=this.txtDiaChi.Text,
                DienThoai=this.txtSDT.Text
            };
            if (this.txtDangNhap.Text.Trim() != "" && this.txtMaNV.Text.Trim() != "" )
            {
                try
                {
                    Models.NhanViens.Add(nhanVien);
                    Models.SaveChanges();
                    Models.TaiKhoans.Add(taiKhoan);
                    Models.SaveChanges();


                    MessageBox.Show("Xin chúc mừng", "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Có lỗi trong quá trình đăng ký","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin để đăng ký ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {

            DialogResult traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                this.Hide();
                Form frm = new Home();
                frm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
