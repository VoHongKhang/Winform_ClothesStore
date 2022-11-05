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
using Finally_project.Database.HandleElement;

namespace Finally_project
{
    public partial class ProductForm : Form
    {   
        private void LoadData()
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
                          group sx by sx.NgayLap into g
                          select new { Ngaylap = g.Key, a = g };
                if (cbChoose.Text.Trim() == "Hóa đơn theo ngày")
                {
                    dgvStatic.Rows.Clear();
                    cbNgaylap.Show();
                    label2.Show();
                    cbNgaylap.Items.Clear();

                    foreach (var i in cok)
                    {
                        cbNgaylap.Items.Add(i.Ngaylap);
                        cbNgaylap.Text = i.Ngaylap;
                    }
                }
                else if (cbChoose.Text.Trim() == "Tất cả hóa đơn")
                {
                    dgvStatic.Rows.Clear();
                    cbNgaylap.Hide();
                    label2.Hide();
                    foreach (var c in j)
                    {
                        int index = dgvStatic.Rows.Add();
                        dgvStatic.Rows[index].Cells[0].Value = c.MaHDX;
                        dgvStatic.Rows[index].Cells[1].Value = c.TenKH;
                        dgvStatic.Rows[index].Cells[2].Value = c.TenNV;
                        dgvStatic.Rows[index].Cells[3].Value = c.TenSP;
                        dgvStatic.Rows[index].Cells[4].Value = c.DonGia * c.SoLuong;
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                      
        }
        private void LoadData1()
        {
            try
            {
                ModelQuanLyCuaHangQuanAo context = new ModelQuanLyCuaHangQuanAo();
                List<DonHangNhap> donHangNhaps = context.DonHangNhaps.ToList();
                List<NhanVien> nhanViens = context.NhanViens.ToList();
                List<ChiTietDonHangNhap> chiTietDonHangNhaps = context.ChiTietDonHangNhaps.ToList();
                List<SanPham> sanPhams = context.SanPhams.ToList();
                List<NhaCungCap> nhaCungCaps = context.NhaCungCaps.ToList();
                var q =

                    from c in nhaCungCaps

                    join p in donHangNhaps on c.MaNCC equals p.MaNCC into ps

                    from p in ps
                    select new
                    {
                        TenNCC = c.TenNCC,
                        MaHDN = p.MaDHN,
                        NgayLHD = p.NgayLap,
                        MaNV = p.MaNV,

                    };
                var s =
                    from sa in q

                    join z in chiTietDonHangNhaps on sa.MaHDN equals z.MaDHN into ps
                    from a in ps
                    select new
                    {
                        TenNCC = sa.TenNCC,
                        MaHDN = a.MaDHN,
                        MaNV = sa.MaNV,
                        SoLuong = a.Soluong,
                        MaSp = a.MaSP,
                        Ngaylap = sa.NgayLHD
                    };

                var k =
                    from sb in s
                    join x in sanPhams on sb.MaSp equals x.MaSP into pz

                    from aw in pz
                    select new
                    {
                        TenNCC = sb.TenNCC,
                        MaHDN = sb.MaHDN,
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
                        TenNCC = sc.TenNCC,
                        MaHDN = sc.MaHDN,
                        TenNV = gh.TenNV,
                        SoLuong = sc.SoLuong,
                        TenSP = sc.TenSP,
                        DonGia = sc.DonGia,
                        NgayLap = sc.NgayLap
                    };

                var cok = from sx in j
                          group sx by sx.NgayLap into g
                          select new { Ngaylap = g.Key, a = g };
                if (cbChoose1.Text.Trim() == "Hóa đơn theo ngày")
                {
                    dgvStatic1.Rows.Clear();
                    cbNgayLap1.Show();
                    lbNgayLap.Show();
                    cbNgayLap1.Items.Clear();

                    foreach (var i in cok)
                    {
                        cbNgayLap1.Items.Add(i.Ngaylap);
                        cbNgayLap1.Text = i.Ngaylap;

                    }
                }
                else if (cbChoose1.Text.Trim() == "Tất cả hóa đơn")
                {
                    dgvStatic1.Rows.Clear();
                    cbNgayLap1.Hide();
                    lbNgayLap.Hide();
                    foreach (var c in j)
                    {
                        int index = dgvStatic1.Rows.Add();
                        dgvStatic1.Rows[index].Cells[0].Value = c.MaHDN;
                        dgvStatic1.Rows[index].Cells[1].Value = c.TenNCC;
                        dgvStatic1.Rows[index].Cells[2].Value = c.TenNV;
                        dgvStatic1.Rows[index].Cells[3].Value = c.TenSP;
                        dgvStatic1.Rows[index].Cells[4].Value = c.DonGia * c.SoLuong;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public ProductForm()
        {
            InitializeComponent();
        }
      
        private void ProductForm_Load_1(object sender, EventArgs e)
        {
            HandleElm.SetGridViewStyle(dgvStatic);
            HandleElm.SetGridViewStyle(dgvStatic1);
            cbChoose.Text = "Tất cả hóa đơn";
            cbChoose1.Text = "Tất cả hóa đơn";
        }

        private void cbNgaylap_SelectedIndexChanged_1(object sender, EventArgs e)
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
                          group sx by sx.NgayLap into g
                          select new { Ngaylap = g.Key, a = g };
                dgvStatic.Rows.Clear();
                foreach (var i in cok)
                {
                    foreach (var c in i.a)
                    {
                        if (c.NgayLap == cbNgaylap.Text.ToString())
                        {
                            int index = dgvStatic.Rows.Add();
                            dgvStatic.Rows[index].Cells[0].Value = c.MaHDX;
                            dgvStatic.Rows[index].Cells[1].Value = c.TenKH;
                            dgvStatic.Rows[index].Cells[2].Value = c.TenNV;
                            dgvStatic.Rows[index].Cells[3].Value = c.TenSP;
                            dgvStatic.Rows[index].Cells[4].Value = c.DonGia * c.SoLuong;
                        }
                    }
                }

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

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Export.ExporttoPDF(dgvStatic);
        }

        private void cbChoose_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData1();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Export.ExporttoPDF(dgvStatic1);
        }

        private void cbNgayLap1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ModelQuanLyCuaHangQuanAo context = new ModelQuanLyCuaHangQuanAo();
                List<DonHangNhap> donHangNhaps = context.DonHangNhaps.ToList();
                List<NhanVien> nhanViens = context.NhanViens.ToList();
                List<ChiTietDonHangNhap> chiTietDonHangNhaps = context.ChiTietDonHangNhaps.ToList();
                List<SanPham> sanPhams = context.SanPhams.ToList();
                List<NhaCungCap> nhaCungCaps = context.NhaCungCaps.ToList();
                var q =

                    from c in nhaCungCaps

                    join p in donHangNhaps on c.MaNCC equals p.MaNCC into ps

                    from p in ps
                    select new
                    {
                        TenNCC = c.TenNCC,
                        MaHDN = p.MaDHN,
                        NgayLHD = p.NgayLap,
                        MaNV = p.MaNV,

                    };
                var s =
                    from sa in q

                    join z in chiTietDonHangNhaps on sa.MaHDN equals z.MaDHN into ps
                    from a in ps
                    select new
                    {
                        TenNCC = sa.TenNCC,
                        MaHDN = a.MaDHN,
                        MaNV = sa.MaNV,
                        SoLuong = a.Soluong,
                        MaSp = a.MaSP,
                        Ngaylap = sa.NgayLHD
                    };

                var k =
                    from sb in s
                    join x in sanPhams on sb.MaSp equals x.MaSP into pz

                    from aw in pz
                    select new
                    {
                        TenNCC = sb.TenNCC,
                        MaHDN = sb.MaHDN,
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
                        TenNCC = sc.TenNCC,
                        MaHDN = sc.MaHDN,
                        TenNV = gh.TenNV,
                        SoLuong = sc.SoLuong,
                        TenSP = sc.TenSP,
                        DonGia = sc.DonGia,
                        NgayLap = sc.NgayLap
                    };

                var cok = from sx in j
                          group sx by sx.NgayLap into g
                          select new { Ngaylap = g.Key, a = g };
                dgvStatic1.Rows.Clear();
                foreach (var i in cok)
                {
                    foreach (var c in i.a)
                    {
                        if (c.NgayLap == cbNgayLap1.Text.ToString())
                        {
                            int index = dgvStatic1.Rows.Add();
                            dgvStatic1.Rows[index].Cells[0].Value = c.MaHDN;
                            dgvStatic1.Rows[index].Cells[1].Value = c.TenNCC;
                            dgvStatic1.Rows[index].Cells[2].Value = c.TenNV;
                            dgvStatic1.Rows[index].Cells[3].Value = c.TenSP;
                            dgvStatic1.Rows[index].Cells[4].Value = c.DonGia * c.SoLuong;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvStatic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
