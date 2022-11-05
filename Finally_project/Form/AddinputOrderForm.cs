using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finally_project.Database.CreateData;
using Finally_project.Database.HandleElement;
using Finally_project.Database.Models;

namespace Finally_project
{
    public partial class AddinputOrderForm : Form
    {
        public AddinputOrderForm()
        {
            InitializeComponent();
        }
        ModelQuanLyCuaHangQuanAo context = new ModelQuanLyCuaHangQuanAo();
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them = false;
        bool Add = false;
        // Method
        public void AddData1()
        {
            var chitietnhap = new ChiTietDonHangNhap()
            {
                MaDHN = this.cbMaDHN.Text.ToString().Trim(),
                MaSP = this.cbMaSP.Text.ToString().Trim(),
                Soluong = Convert.ToInt32(this.txtSoluong.Text.Trim())

            };
            try
            {
                context.ChiTietDonHangNhaps.Add(chitietnhap);
                context.SaveChanges();
                MessageBox.Show("Đã thêm xong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Có lỗi trong quá trình thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddData()
        {

            var donhang = new DonHangNhap()
            {
                MaDHN = this.txtMaDHN.Text.Trim(),
                MaNCC = cbMaNCC.SelectedValue.ToString(),
                MaNV = cbMaNV.SelectedValue.ToString(),
                NgayLap = dateTime.Value.ToString("yyyy-MM-dd").Trim()
            };

            if (this.txtMaDHN.Text.Trim() != "")
            {
                try
                {
                    context.DonHangNhaps.Add(donhang);
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
        public void ChangeData1()
        {
            try
            {
                int r = this.dgvCTDHN.CurrentCell.RowIndex;
                string MaDHX = this.dgvCTDHN.Rows[r].Cells[0].Value.ToString().Trim();
                string MaSP = this.dgvCTDHN.Rows[r].Cells[1].Value.ToString().Trim();
                var chiTietDonHangN = context.ChiTietDonHangNhaps.SingleOrDefault(tv => tv.MaDHN == MaDHX && tv.MaSP == MaSP);
                context.ChiTietDonHangNhaps.Attach(chiTietDonHangN);
                chiTietDonHangN.MaDHN = this.cbMaDHN.SelectedValue.ToString().Trim();//Gán giá trị
                chiTietDonHangN.MaSP = this.cbMaSP.SelectedValue.ToString().Trim();//Gán giá trị
                chiTietDonHangN.Soluong = Convert.ToInt32(this.txtSoluong.Text.Trim());
                context.SaveChanges();
                MessageBox.Show("Đã thêm xong!");
            }
            catch (Exception ex)
            {
                //MessageError();
                MessageBox.Show(ex.Message, "ChangeData1");
            }
        }
        public void ChangeData()
        {

            //Sửa
            //Xác định thanh viên cần sửa
            try
            {
                int r = this.dgvDHN.CurrentCell.RowIndex;
                string MaDHN = this.dgvDHN.Rows[r].Cells[0].Value.ToString().Trim();
                var donhang = context.DonHangNhaps.SingleOrDefault(tv => tv.MaDHN == MaDHN);
                context.DonHangNhaps.Attach(donhang);

                donhang.MaDHN = this.txtMaDHN.Text.ToString().Trim();
                donhang.MaNCC = this.cbMaNCC.SelectedValue.ToString().Trim();
                donhang.MaNV = this.cbMaNV.SelectedValue.ToString().Trim();
                donhang.NgayLap = dateTimeDHN.Value.ToString("yyyy-MM-dd").Trim();

                context.SaveChanges();
                MessageBox.Show("Đã sửa xong!");
            }
            catch (Exception ex)
            {
                //MessageError();
                MessageBox.Show(ex.Message);
            }
        }
        public void ChangeText()
        {
            try
            {
                string MaDHN = this.cbMaDHN.SelectedValue?.ToString().Trim();
                string MaSP = this.cbMaSP.SelectedValue?.ToString().Trim();

                var CTDHX = context.ChiTietDonHangNhaps.SingleOrDefault(tv => tv.MaDHN == MaDHN && tv.MaSP == MaSP);

                var DHX = context.DonHangNhaps.SingleOrDefault(tv => tv.MaDHN == MaDHN);
                var nhacc = context.NhaCungCaps.SingleOrDefault(tv => tv.MaNCC == DHX.MaNCC);
                lbTenKH.Text = nhacc.TenNCC.ToString().Trim();

                var sanpham = context.SanPhams.SingleOrDefault(tv => tv.MaSP == MaSP);
                lbSP.Text = sanpham.TenSP.ToString().Trim();

                var nhanvien = context.NhanViens.SingleOrDefault(tv => tv.MaNV == DHX.MaNV);
                lbNV.Text = nhanvien.TenNV.ToString();
                
                dateTime.Text = DHX.NgayLap.ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadData()
        {
            Add = false;
            Them = false;
            //DataTable dt = t.docdulieu("select * from phieumuon");
            List<DonHangNhap> donHangNhaps = context.DonHangNhaps.ToList();
            if (donHangNhaps != null)
            {
                dgvDHN.DataSource = null;
                var custlist = from cust in donHangNhaps
                               select new
                               {
                                   Mã_đơn_hàng = cust.MaDHN,
                                   Mã_nhà_cung_cấp = cust.MaNCC,
                                   Mã_nhân_viên = cust.MaNV,
                                   Ngày_lập = cust.NgayLap
                               };
                dgvDHN.DataSource = custlist.ToList();
            }
            //DataTable dt = t.docdulieu("select * from phieumuon");
            List<ChiTietDonHangNhap> chiTietDonHangs = context.ChiTietDonHangNhaps.ToList();
            List<SanPham> sanPhams = context.SanPhams.ToList();
            if (chiTietDonHangs != null)
            {
                dgvCTDHN.DataSource = null;
                var custlist = from cust in chiTietDonHangs
                               select new
                               {
                                   Mã_đơn_hàng = cust.MaDHN,
                                   Mã_sản_phẩm = cust.MaSP,
                                   Số_lượng = cust.Soluong,
                               };
                dgvCTDHN.DataSource = custlist.ToList();
            }
            ChangeText();

        }
        public void MessageError()
        {
            MessageBox.Show("Lỗi", "Có lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void AddinputOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSP.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.dataSetSP.SanPham);
            // TODO: This line of code loads data into the 'dataSetDHN.DonHangNhap' table. You can move, or remove it, as needed.
            this.donHangNhapTableAdapter.Fill(this.dataSetDHN.DonHangNhap);
            // TODO: This line of code loads data into the 'dataSetNhanVien.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dataSetNhanVien.NhanVien);
            // TODO: This line of code loads data into the 'dataSetNCC.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.dataSetNCC.NhaCungCap);
            HandleElm.SetGridViewStyle(dgvDHN);
            LoadData();
            string MaNCC = cbMaNCC.SelectedValue.ToString();
            var ncc = context.NhaCungCaps.SingleOrDefault(tv => tv.MaNCC == MaNCC);
            lableTenKH.Text = ncc.TenNCC.ToString();
            string MaNV = cbMaNV.SelectedValue.ToString();
            var nhanvien = context.NhanViens.SingleOrDefault(tv => tv.MaNV == MaNV);
            lableTenNV.Text = nhanvien.TenNV.ToString();
        }




        private void btnThem_Click_1(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtMaDHN.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panelMaNCC.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnTroVe.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMaDHN.Focus();
        }
        private void btnTroVe_Click_1(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc không?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                this.Hide();
                
            }
        }

        private void btnThem1_Click_1(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Add = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu1.Enabled = true;
            this.btnHuy1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnXoa1.Enabled = false;
            this.btnSua1.Enabled=false;
            this.cbMaDHN.Focus();
        }
        public void RenderBtn()
        {
            btnLuu.Enabled = false;
            Them = false;
            btnTroVe.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
        }
        private void btnSua_Click_2(object sender, EventArgs e)
        {
            Them = false;
            txtMaDHN.Focus();
            //txtMadhx.Text = "Không thể sửa thuộc tính này";
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnTroVe.Enabled=false;
            btnHuy.Enabled = true;
            int r = this.dgvDHN.CurrentCell.RowIndex;
            // Thứ tự dòng hiện hành
            this.txtMaDHN.Text = this.dgvDHN.Rows[r].Cells[0].Value.ToString();
            this.cbMaNCC.Text = this.dgvDHN.Rows[r].Cells[1].Value.ToString();
            this.cbMaNV.Text = this.dgvDHN.Rows[r].Cells[2].Value.ToString();
            this.dateTimeDHN.Text = this.dgvDHN.Rows[r].Cells[3].Value.ToString();
        }

        private void btnSua1_Click_1(object sender, EventArgs e)
        {
            Add = false;
            txtSoluong.Focus();
            //txtMadhx.Text = "Không thể sửa thuộc tính này";
            btnLuu1.Enabled = true;
            btnThem1.Enabled = false;
            btnXoa1.Enabled = false;
            btnHuy1.Enabled = true;
            int r = this.dgvCTDHN.CurrentCell.RowIndex;
            // Thứ tự dòng hiện hành
            //this.txtMadhx.Text = 
            this.cbMaDHN.Text = this.dgvCTDHN.Rows[r].Cells[0].Value.ToString();
            this.cbMaSP.Text = this.dgvCTDHN.Rows[r].Cells[1].Value.ToString();
            this.txtSoluong.Text = this.dgvCTDHN.Rows[r].Cells[2].Value.ToString();
        }

        private void btnXoa1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chứ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {
                    int r = this.dgvCTDHN.CurrentCell.RowIndex;
                    string Madhn = this.dgvCTDHN.Rows[r].Cells[0].Value.ToString();
                    string MaSP = this.dgvCTDHN.Rows[r].Cells[1].Value.ToString();
                    ChiTietDonHangNhap chitietdhn = context.ChiTietDonHangNhaps.SingleOrDefault(tv => tv.MaDHN == Madhn && tv.MaSP == MaSP);//Xác định thành viên cần xóa
                    context.ChiTietDonHangNhaps.Remove(chitietdhn);
                    context.SaveChanges();//Xác nhận thay đổi
                    MessageBox.Show("Đã xóa xong!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnHuy1_Click_1(object sender, EventArgs e)
        {
            btnLuu1.Enabled = false;
            Add = false;
            btnXoa1.Enabled = true;
            btnThem1.Enabled = true;
            btnThoat.Enabled = true;
            btnSua1.Enabled = true;
            btnHuy1.Enabled = false;
        }

        private void btnLuu1_Click_1(object sender, EventArgs e)
        {
            if (Add)
            {
                AddData1();
                LoadData();
            }
            else
            {
                ChangeData1();
                LoadData();
            }
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (Them)
            {
                AddData();
                LoadData();
            }
            else
            {
                ChangeData();
                LoadData();
            }
            RenderBtn();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chứ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {

                int r = this.dgvDHN.CurrentCell.RowIndex;
                string Madhx = this.dgvDHN.Rows[r].Cells[0].Value.ToString();
                DonHangNhap donHang = context.DonHangNhaps.SingleOrDefault(tv => tv.MaDHN == Madhx);//Xác định thành viên cần xóa
                context.DonHangNhaps.Remove(donHang);
                context.SaveChanges();//Xác nhận thay đổi
                MessageBox.Show("Đã xóa xong!");
                LoadData();
            }
        }

        private void cbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaKH = cbMaNCC.SelectedValue.ToString();
            var ncc = context.NhaCungCaps.SingleOrDefault(tv => tv.MaNCC == MaKH);
            lableTenKH.Text = ncc.TenNCC.ToString();
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaNV = cbMaNV.SelectedValue.ToString();
            var nhanvien = context.NhanViens.SingleOrDefault(tv => tv.MaNV == MaNV);
            lableTenNV.Text = nhanvien.TenNV.ToString();
        }

        private void cbMaDHN_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeText();
        }

        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            Them = false;
            // Xóa trống các đối tượng trong Panel
            this.txtMaDHN.ResetText();
            this.cbMaNCC.ResetText();
            this.cbMaNV.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnTroVe.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
        }
    }
}
