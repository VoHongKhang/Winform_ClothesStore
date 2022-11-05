using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Finally_project.Database.CreateData;
using Finally_project.Database.Models;
using System.Reflection;
using System.Globalization;
using Finally_project.Database.HandleElement;

namespace Finally_project
{
    public partial class AddOrderForm : Form
    {
        ModelQuanLyCuaHangQuanAo context = new ModelQuanLyCuaHangQuanAo();

        bool Them = false;
        bool Add = false;
        public AddOrderForm()
        {
            InitializeComponent();
        }
        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSP.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.dataSetSP.SanPham);
            // TODO: This line of code loads data into the 'dataSetDHX.DonHangXuat' table. You can move, or remove it, as needed.
            this.donHangXuatTableAdapter.Fill(this.dataSetDHX.DonHangXuat);
            // TODO: This line of code loads data into the 'datasetCTDHX.ChiTietDonHangXuat' table. You can move, or remove it, as needed.
            this.chiTietDonHangXuatTableAdapter.Fill(this.datasetCTDHX.ChiTietDonHangXuat);
            // TODO: This line of code loads data into the 'dataSetNhanVien.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dataSetNhanVien.NhanVien);
            // TODO: This line of code loads data into the 'datasetKhachHang.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.datasetKhachHang.KhachHang);
            LoadData();
            HandleElm.SetGridViewStyle(dvgDHX);
            HandleElm.SetGridViewStyle(dgvCTDHX);
            HandleElm.SetGridViewStyle(dgvDHX);
            string MaNV = cbMaNV.SelectedValue.ToString();
            var nhanvien = context.NhanViens.SingleOrDefault(tv => tv.MaNV == MaNV);
            lableTenNV.Text = nhanvien.TenNV.ToString();
            string MaKH = cbMaKH.SelectedValue.ToString();
            var khachhang = context.KhachHangs.SingleOrDefault(tv => tv.MaKH == MaKH);
            lableTenKH.Text = khachhang.TenKH.ToString();
            cbTenKH.Text = khachhang.TenKH;
        }
        // Method
        public void AddData1()
        {
            try
            {
                var chitietdhx = new ChiTietDonHangXuat()
                {
                    MaDHX = this.cbMaDHX.Text.ToString().Trim(),
                    MaSP = this.cbMaSP.Text.ToString().Trim(),
                    SoLuong = Convert.ToInt32(this.txtSoluong.Text.Trim())
                };
                context.ChiTietDonHangXuats.Add(chitietdhx);
                context.SaveChanges();
                MessageBox.Show("Đã thêm xong!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Có lỗi trong quá trình thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AddData()
        {
            var DonHangXuat = new DonHangXuat()
            {
                MaDHX = this.txtMadhx.Text.Trim(),
                MaKH = this.cbMaKH.SelectedValue?.ToString().Trim(),
                MaNV = this.cbMaNV.SelectedValue?.ToString().Trim(),
                NgayLap = date?.Value.ToString("yyyy-MM-dd").Trim()

            };


            if (this.txtMadhx.Text.Trim() != "")
            {
                try
                {
                    context.DonHangXuats.Add(DonHangXuat);
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
        public void RenderBtn1()
        {
            btnLuu1.Enabled = false;
            Add = false;
            btnXoa1.Enabled = true;
            btnThem1.Enabled = true;
            btnSua1.Enabled = true;
            button1.Enabled = true;
        }
        public void RenderBtn()
        {
            btnLuu.Enabled = false;
            Them = false;
            btnThoat.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
        }
        public void ChangeData1()
        {
            try
            {
                int r = this.dgvCTDHX.CurrentCell.RowIndex;
                string MaDHX = this.dgvCTDHX.Rows[r].Cells[0].Value.ToString().Trim();
                string MaSP = this.dgvCTDHX.Rows[r].Cells[1].Value.ToString().Trim();
                var chiTietDonHangXuat = context.ChiTietDonHangXuats.SingleOrDefault(tv => tv.MaDHX == MaDHX && tv.MaSP ==MaSP);
                context.ChiTietDonHangXuats.Attach(chiTietDonHangXuat);
                chiTietDonHangXuat.MaDHX = this.cbMaDHX.SelectedValue.ToString().Trim();//Gán giá trị
                chiTietDonHangXuat.MaSP = this.cbMaSP.SelectedValue.ToString().Trim();//Gán giá trị
                chiTietDonHangXuat.SoLuong = Convert.ToInt32(this.txtSoluong.Text.Trim());
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
                int r = this.dvgDHX.CurrentCell.RowIndex;
                string MaDHX = this.dvgDHX.Rows[r].Cells[0].Value.ToString().Trim();
                var donhang = context.DonHangXuats.SingleOrDefault(tv => tv.MaDHX == MaDHX);
                context.DonHangXuats.Attach(donhang);

                donhang.MaDHX = this.txtMadhx.Text.ToString().Trim();
                donhang.MaKH = this.cbMaKH.SelectedValue.ToString().Trim();
                donhang.MaNV = this.cbMaNV.SelectedValue.ToString().Trim();
                donhang.NgayLap = date.Value.ToString("yyyy-MM-dd").Trim();

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
                string MaDHX = this.cbMaDHX.SelectedValue?.ToString().Trim();
                string MaSP = this.cbMaSP.SelectedValue?.ToString().Trim();

                var CTDHX = context.ChiTietDonHangXuats.SingleOrDefault(tv => tv.MaDHX == MaDHX && tv.MaSP == MaSP);
                var DHX = context.DonHangXuats.SingleOrDefault(tv => tv.MaDHX == MaDHX);
                var KhachHang = context.KhachHangs.SingleOrDefault(tv => tv.MaKH == DHX.MaKH);
                lbTenKH.Text = KhachHang.TenKH.ToString().Trim();

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
            List<DonHangXuat> donHangXuats = context.DonHangXuats.ToList();
            List<ChiTietDonHangXuat> chitiet = context.ChiTietDonHangXuats.ToList();
            List<KhachHang> khachHangs =context.KhachHangs.ToList();
            List<NhanVien> nhanViens = context.NhanViens.ToList();
            if (donHangXuats != null)
            {
                dvgDHX.DataSource = null;
                var custlist = from cust in donHangXuats
                               select new
                               {
                                   Mã_đơn_hàng = cust.MaDHX,
                                   Mã_khách_hàng = cust.MaKH,
                                   Mã_nhân_viên = cust.MaNV,
                                   Ngày_lập = cust.NgayLap
                               };
                dvgDHX.DataSource = custlist.ToList();
            }
            //DataTable dt = t.docdulieu("select * from phieumuon");
            List<ChiTietDonHangXuat> chiTietDonHangs = context.ChiTietDonHangXuats.ToList();
            List<SanPham> sanPhams = context.SanPhams.ToList();
            if (chiTietDonHangs != null)
            {
                dgvCTDHX.DataSource = null;
                var custlist = from cust in chiTietDonHangs
                               select new
                               {
                                   Mã_đơn_hàng = cust.MaDHX,
                                   Mã_sản_phẩm = cust.MaSP,
                                   Số_lượng = cust.SoLuong,
                               };
                dgvCTDHX.DataSource = custlist.ToList();
            }
            ChangeText();
            try
            {
                var q =

                    from c in khachHangs

                    join p in donHangXuats on c.MaKH equals p.MaKH into ps

                    from p in ps
                    select new
                    {
                        TenKH = c.TenKH,
                        MaHDX = p.MaDHX,
                        NgayLHD = p.NgayLap,
                        MaNV = p.MaNV,

                    };
                var s =
                    from sa in q

                    join z in chitiet on sa.MaHDX equals z.MaDHX into ps
                    from a in ps
                    select new
                    {
                        TenKH = sa.TenKH,
                        MaHDX = a.MaDHX,
                        MaNV = sa.MaNV,
                        SoLuong = a.SoLuong,
                        MaSp = a.MaSP,
                        Ngaylap = sa.NgayLHD
                    };

                var k =
                    from sb in s
                    join x in sanPhams on sb.MaSp equals x.MaSP into pz

                    from aw in pz
                    select new
                    {
                        TenKH = sb.TenKH,
                        MaHDX = sb.MaHDX,
                        MaNV = sb.MaNV,
                        SoLuong = sb.SoLuong,
                        TenSP = aw.TenSP,
                        DonGia = aw.Gia,
                        NgayLap = sb.Ngaylap
                    };
                var j =
                    from sc in k
                    join h in nhanViens on sc.MaNV equals h.MaNV into hh
                    from gh in hh
                    select new
                    {
                        TenKH = sc.TenKH,
                        MaHDX = sc.MaHDX,
                        TenNV = gh.TenNV,
                        SoLuong = sc.SoLuong,
                        TenSP = sc.TenSP,
                        DonGia = sc.DonGia,
                        NgayLap = sc.NgayLap
                    };

                var cok = from sx in j
                          group sx by sx.TenKH into g
                          select new { TenKH = g.Key, a = g };
                cbTenKH.Items.Clear();
                foreach (var i in cok)
                    {
                        cbTenKH.Items.Add(i.TenKH);
                        cbTenKH.Text = i.TenKH;
                    }
                RenderBtn();
                RenderBtn1();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            RenderBtn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtMadhx.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThoat.Enabled = false;
            this.txtMadhx.Focus();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            Them = false;
            txtMadhx.Focus();
            //txtMadhx.Text = "Không thể sửa thuộc tính này";
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnHuy.Enabled = true;
            int r = this.dvgDHX.CurrentCell.RowIndex;
            // Thứ tự dòng hiện hành
            //this.txtMadhx.Text = 
            this.txtMadhx.Text= this.dvgDHX.Rows[r].Cells[0].Value.ToString();
            this.cbMaKH.Text = this.dvgDHX.Rows[r].Cells[1].Value.ToString();
            this.cbMaNV.Text = this.dvgDHX.Rows[r].Cells[2].Value.ToString();
            this.date.Text =  this.dvgDHX.Rows[r].Cells[3].Value.ToString();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chứ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {

                int r = this.dvgDHX.CurrentCell.RowIndex;
                string Madhx = this.dvgDHX.Rows[r].Cells[0].Value.ToString();
                DonHangXuat donHang = context.DonHangXuats.SingleOrDefault(tv => tv.MaDHX == Madhx);//Xác định thành viên cần xóa
                context.DonHangXuats.Remove(donHang);
                context.SaveChanges();//Xác nhận thay đổi
                MessageBox.Show("Đã xóa xong!");
                LoadData();
            }
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }     
        private void dvgDHX_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Them = false;
            txtMadhx.Focus();
            //txtMadhx.Text = "Không thể sửa thuộc tính này";
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnHuy.Enabled = true;
            int r = this.dvgDHX.CurrentCell.RowIndex;
            // Thứ tự dòng hiện hành
            //this.txtMadhx.Text = 
            this.txtMadhx.Text = this.dvgDHX.Rows[r].Cells[0].Value.ToString();
            this.cbMaKH.Text = this.dvgDHX.Rows[r].Cells[1].Value.ToString();
            this.cbMaNV.Text = this.dvgDHX.Rows[r].Cells[2].Value.ToString();
            this.date.Text = this.dvgDHX.Rows[r].Cells[3].Value.ToString();
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Add = true;
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu1.Enabled = true;
            this.btnHuy1.Enabled = true;
            btnLuu1.Enabled    =true;
            this.btnSua1.Enabled = false;
            this.btnXoa1.Enabled = false;    

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.cbMaDHX.Focus();
        }

        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeText();
        }

        private void cbMaDHX_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeText();
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            Add = false;
            txtSoluong.Focus();
            //txtMadhx.Text = "Không thể sửa thuộc tính này";
            btnLuu1.Enabled = true;
            btnThem1.Enabled = false;
            btnXoa1.Enabled = false;
            btnHuy1.Enabled = true;
            int r = this.dgvCTDHX.CurrentCell.RowIndex;
            // Thứ tự dòng hiện hành
            this.cbMaDHX.Text = this.dgvCTDHX.Rows[r].Cells[0].Value.ToString();
            this.cbMaSP.Text = this.dgvCTDHX.Rows[r].Cells[1].Value.ToString();
            this.txtSoluong.Text = this.dgvCTDHX.Rows[r].Cells[2].Value.ToString();

        }

        private void btnHuy1_Click(object sender, EventArgs e)
        {
            RenderBtn1();
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn chắc chứ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {
                    int r = this.dgvCTDHX.CurrentCell.RowIndex;
                    string Madhx = this.dgvCTDHX.Rows[r].Cells[0].Value.ToString();
                    string MaSP = this.dgvCTDHX.Rows[r].Cells[1].Value.ToString();
                    ChiTietDonHangXuat chitietdhx = context.ChiTietDonHangXuats.SingleOrDefault(tv => tv.MaDHX == Madhx && tv.MaSP == MaSP);//Xác định thành viên cần xóa
                    context.ChiTietDonHangXuats.Remove(chitietdhx);
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

        private void btnLuu1_Click(object sender, EventArgs e)
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

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaKH = cbMaKH.SelectedValue.ToString();
            var khachhang = context.KhachHangs.SingleOrDefault(tv => tv.MaKH == MaKH);
            lableTenKH.Text = khachhang.TenKH.ToString();
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaNV = cbMaNV.SelectedValue.ToString();
            var nhanvien = context.NhanViens.SingleOrDefault(tv => tv.MaNV == MaNV);
            lableTenNV.Text = nhanvien.TenNV.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvCTDHX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXuatDN_Click(object sender, EventArgs e)
        {

        }

        private void cbNgaylap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ModelQuanLyCuaHangQuanAo context = new ModelQuanLyCuaHangQuanAo();
                List<DonHangXuat> donHangXuats = context.DonHangXuats.ToList();
                List<NhanVien> nhanViens = context.NhanViens.ToList();
                List<ChiTietDonHangXuat> chiTietDonHangXuats = context.ChiTietDonHangXuats.ToList();
                List<SanPham> sanPhams = context.SanPhams.ToList();
                List<KhachHang> khachHangs = context.KhachHangs.ToList();
                var q =

                    from c in khachHangs

                    join p in donHangXuats on c.MaKH equals p.MaKH into ps

                    from p in ps
                    select new
                    {
                        TenKH = c.TenKH,
                        MaHDX = p.MaDHX,
                        NgayLHD = p.NgayLap,
                        MaNV = p.MaNV,

                    };
                var s =
                    from sa in q

                    join z in chiTietDonHangXuats on sa.MaHDX equals z.MaDHX into ps
                    from a in ps
                    select new
                    {
                        TenKH = sa.TenKH,
                        MaHDX = a.MaDHX,
                        MaNV = sa.MaNV,
                        SoLuong = a.SoLuong,
                        MaSp = a.MaSP,
                        Ngaylap = sa.NgayLHD
                    };

                var k =
                    from sb in s
                    join x in sanPhams on sb.MaSp equals x.MaSP into pz

                    from aw in pz
                    select new
                    {
                        TenKH = sb.TenKH,
                        MaHDX = sb.MaHDX,
                        MaNV = sb.MaNV,
                        SoLuong = sb.SoLuong,
                        TenSP = aw.TenSP,
                        DonGia = aw.Gia,
                        NgayLap = sb.Ngaylap
                    };
                var j =
                    from sc in k
                    join h in nhanViens on sc.MaNV equals h.MaNV into hh
                    from gh in hh
                    select new
                    {
                        TenKH = sc.TenKH,
                        MaHDX = sc.MaHDX,
                        TenNV = gh.TenNV,
                        SoLuong = sc.SoLuong,
                        TenSP = sc.TenSP,
                        DonGia = sc.DonGia,
                        NgayLap = sc.NgayLap
                    };

                var cok = from sx in j
                          group sx by sx.TenKH into g
                          select new { TenKH = g.Key, a = g };

                dgvDHX.Rows.Clear();
                foreach (var i in cok)
                {
                    foreach (var c in i.a)
                    {
                        if (c.TenKH == cbTenKH.Text.ToString().Trim())
                        {
                            int index = dgvDHX.Rows.Add();
                            dgvDHX.Rows[index].Cells[0].Value = c.MaHDX;
                            dgvDHX.Rows[index].Cells[1].Value = c.TenSP;
                            dgvDHX.Rows[index].Cells[2].Value = c.SoLuong;
                            dgvDHX.Rows[index].Cells[3].Value = c.DonGia;
                            dgvDHX.Rows[index].Cells[4].Value = c.DonGia * c.SoLuong;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvStatic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Export.ExporttoPDF(dgvDHX);
        }
    }
}
