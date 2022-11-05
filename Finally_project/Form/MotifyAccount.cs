using Finally_project.Database.CreateData;
using Finally_project.Database.HandleElement;
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
    public partial class MotifyAccount : Form
    {
        ModelQuanLyCuaHangQuanAo context = new ModelQuanLyCuaHangQuanAo();
        // Method
        public MotifyAccount()
        {
            InitializeComponent();
        }
        public void AddData()
        {

            var nhanVien = new NhanVien()
            {
                TenNV = this.txtHoTen.Text.Trim(),
                DiaChi = this.txtDiaChi.Text.Trim(),
                DienThoai = this.txtSDT.Text.Trim(),
                GioiTinh = this.checkNam.Checked == true ? "Nam" : "Nữ",
            };

            if (this.txtHoTen.Text.Trim() != "")
            {
                try
                {
                    context.NhanViens.Add(nhanVien);
                    context.SaveChanges();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ChangeData()
        {
            //Sửa
            //Xác định thanh viên cần sửa
            try
            {
                int r = this.dgvNV.CurrentCell.RowIndex;
                string TenNV = this.dgvNV.Rows[r].Cells[0].Value.ToString().Trim();
                var nhanVien = context.NhanViens.SingleOrDefault(tv => tv.TenNV == TenNV);
                context.NhanViens.Attach(nhanVien);
                nhanVien.TenNV = this.txtHoTen.Text.ToString().Trim();//Gán giá trị 
                nhanVien.DiaChi = this.txtDiaChi.Text.ToString().Trim();//Gán giá trị
                nhanVien.DienThoai = this.txtSDT.Text.ToString().Trim();//Gán giá trị 
                nhanVien.GioiTinh = this.checkNam.Checked == true ? "Nam" : "Nu";
                context.SaveChanges();
                MessageBox.Show("Cập nhật thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageError();
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadData()
        {
            try
            {
                this.dgvNV.DataSource = null;
                var custlist = from cust in context.NhanViens
                               select new
                               {
                                   Tên_nhân_viên = cust.TenNV,
                                   Địa_chỉ = cust.DiaChi,
                                   Số_điện_thoại = cust.DienThoai,
                                   Giới_tính = cust.GioiTinh

                               };
                this.dgvNV.DataSource = custlist.ToList();
                // Xóa trống các đối tượng trong Panel
                this.txtHoTen.ResetText();
                this.txtDiaChi.ResetText();
                this.txtSDT.ResetText();
                this.txtTenDN.ResetText();
                this.txtMatKhau.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.btnLuu1.Enabled = false;
                this.btnHuy1.Enabled = false;
                // Cho thao tác trên các nút Cập nhật
                this.btnCapNhat.Enabled = true;
                this.btnDMK.Enabled = true;
            }
            catch
            {
                MessageError();
            }
        }
        private void LoadData1()
        {
            try
            {
                this.dgvTK.DataSource = null;
                var list = from cust in context.TaiKhoans
                           select new
                           {
                               Tên_đăng_nhập = cust.TenDN,
                               Mật_khẩu = cust.MatKhau,
                               Loại_TK = cust.LoaiTK
                           };
                this.dgvTK.DataSource = list.ToList();
                // Xóa trống các đối tượng trong Panel
                this.txtTenDN.ResetText();
                this.txtMatKhau.ResetText();
                this.txtChucVu.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu1.Enabled = false;
                this.btnHuy1.Enabled = false;
                // Cho thao tác trên các nút Cập nhật
                this.btnDMK.Enabled = true;
            }
            catch
            {
                MessageError();
            }
        }
        public void ChangeData1()
        {
            //Sửa
            //Xác định thanh viên cần sửa
            try
            {
                int r = this.dgvTK.CurrentCell.RowIndex;
                string TenDN = this.dgvTK.Rows[r].Cells[0].Value.ToString().Trim();
                var taiKhoan = context.TaiKhoans.SingleOrDefault(tv => tv.TenDN == TenDN);
                context.TaiKhoans.Attach(taiKhoan);
                taiKhoan.TenDN = this.txtTenDN.Text.ToString().Trim();//Gán giá trị 
                taiKhoan.MatKhau = this.txtMatKhau.Text.ToString().Trim();//Gán giá trị
                taiKhoan.LoaiTK =this.txtChucVu.Text.ToString().Trim();
                context.SaveChanges();
                MessageBox.Show("Cập nhật thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageError();
                MessageBox.Show(ex.Message);
            }
        }
        public void MessageError()
        {
            MessageBox.Show("Lỗi", "Có lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void picBoxThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc không?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                this.Hide();
            }
        }

        private void MotifyAccount_Load(object sender, EventArgs e)
        {

            LoadData();
            LoadData1();
            HandleElm.SetGridViewStyle(dgvNV);
            HandleElm.SetGridViewStyle(dgvTK);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
                ChangeData();
                LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtHoTen.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();
            this.checkNam.Refresh();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnCapNhat.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtHoTen.Focus();
            panel2.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            int r = this.dgvNV.CurrentCell.RowIndex;

            // Thứ tự dòng hiện hành
            this.txtHoTen.Text = this.dgvNV.Rows[r].Cells[0].Value.ToString();
            this.txtDiaChi.Text = this.dgvNV.Rows[r].Cells[1].Value.ToString();
            this.txtSDT.Text = this.dgvNV.Rows[r].Cells[2].Value.ToString();
            this.checkNam.Checked = this.dgvNV.Rows[r].Cells[3].Value.ToString() == "Nam";
        }

        private void btnHuy1_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtTenDN.ResetText();
            this.txtMatKhau.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnCapNhat.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu1.Enabled = false;
            this.btnHuy1.Enabled = false;
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
                ChangeData1();
                LoadData1();
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            txtHoTen.Focus();
            panel1.Enabled = true;
            btnLuu1.Enabled = true;
            btnHuy1.Enabled = true;
            int l = this.dgvTK.CurrentCell.RowIndex;
            // Thứ tự dòng hiện hành
            this.txtTenDN.Text = this.dgvTK.Rows[l].Cells[0].Value.ToString();
            this.txtMatKhau.Text = this.dgvTK.Rows[l].Cells[1].Value.ToString();
            this.txtChucVu.Text = this.dgvTK.Rows[l].Cells[2].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc không?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                this.Hide();
            }
        }
    }
}
