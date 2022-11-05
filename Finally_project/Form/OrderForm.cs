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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
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
                        MaSp = a.MaSP
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
                        DonGia = aw.Gia
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
                        DonGia = sc.DonGia
                    };
                dgvDonHangXuat.DataSource = null;
                cbMaDHX.Items.Clear();
                var custlist = from cust in j
                               select new
                               {
                                   Mã_đơn_hàng = cust.MaHDX,
                                   Tên_khách_hàng = cust.TenKH,
                                   Tên_nhân_viên = cust.TenNV,
                                   Sản_phẩm = cust.TenSP,
                                   Trị_giá = cust.DonGia * cust.SoLuong,
                               };
                dgvDonHangXuat.DataSource = custlist.ToList();
                foreach (var i in donHangXuats)
                    cbMaDHX.Items.Add(i.MaDHX.Trim());
            }
            catch
            {
                MessageBox.Show("Không kết nối được dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form frm = new AddOrderForm();
            frm.ShowDialog();
            LoadData();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadData();
            HandleElm.SetGridViewStyle(dgvDonHangXuat);
        }
        int parentIndex = 0;
        private void cbMaDHX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaDHX.SelectedItem != null)
            {

                dgvDonHangXuat.Rows[parentIndex].Selected = false;
                String searchValue = cbMaDHX.SelectedItem.ToString().Trim();
                int rowIndex = -1;
                foreach (DataGridViewRow row in dgvDonHangXuat.Rows)
                {
                    if (row.Cells[0].Value.ToString().Trim().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }
                dgvDonHangXuat.Rows[rowIndex].Selected = true;

                parentIndex = rowIndex;
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Export.ExporttoPDF(dgvDonHangXuat);
        }

        private void dgvDonHangXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
