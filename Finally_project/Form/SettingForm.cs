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
    public partial class SettingForm : Form
    {

        ModelQuanLyCuaHangQuanAo context = new ModelQuanLyCuaHangQuanAo();

        NhanVien nhanVien;
        TaiKhoan taiKhoan;
        public SettingForm()
        {
            InitializeComponent();
        }
        private void btnMotify_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form frm = new MotifyAccount();
            frm.ShowDialog();
        }
        private void LoadData()
        {

            try
            {
                List<NhanVien> nv = context.NhanViens.ToList();

                dgvNV.DataSource = null;
                var custlist = from cust in nv
                               select new
                               {
                                   Mã_nhân_viên = cust.MaNV,
                                   Tên_nhân_viên = cust.TenNV,
                                   Giới_tính = cust.GioiTinh,
                                   Địa_chỉ = cust.DiaChi,
                                   Điện_thoại = cust.DienThoai

                               };
                dgvNV.DataSource = custlist.ToList();
                foreach (var i in nv)
                    cbMaNV.Items.Add(i.TenNV.Trim());
            }
            catch
            {
                MessageBox.Show("Không kết nối được dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SettingForm_Load(object sender, EventArgs e)
        {
            LoadData();
            HandleElm.SetGridViewStyle(dgvNV);

        }
        int parentIndex = 0;
        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaNV.SelectedItem != null)
            {

                dgvNV.Rows[parentIndex].Selected = false;
                String searchValue = cbMaNV.SelectedItem.ToString().Trim();

                int rowIndex = -1;

                foreach (DataGridViewRow row in dgvNV.Rows)
                {
                    if (row.Cells[1].Value.ToString().Trim().Equals(searchValue))
                    {
                        rowIndex = row.Index;                      
                        break;
                    }
                }
                dgvNV.Rows[rowIndex].Selected = true;
                nhanVien = context.NhanViens.SingleOrDefault(tv => tv.MaNV == searchValue);
                taiKhoan = context.TaiKhoans.SingleOrDefault(tv => tv.MaNV == searchValue);

                parentIndex = rowIndex;
            }
        }
    }
}
