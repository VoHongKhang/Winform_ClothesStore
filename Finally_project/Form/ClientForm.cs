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
    public partial class ClientForm : Form
    {
        // Method
        private void LoadData()
        {
            cbMaKH.Items.Clear();
            try
            {
                ModelQuanLyCuaHangQuanAo context = new ModelQuanLyCuaHangQuanAo();
                List<KhachHang> tk = context.KhachHangs.ToList();
             
                dgvKhachHang.DataSource = null;
                var custlist = from cust in tk
                               select new
                               {
                                   Mã_khách_hàng = cust.MaKH,
                                   Tên_khách_hàng = cust.TenKH,
                                   Địa_chỉ = cust.DiaChi,
                                   Điện_thoại = cust.DienThoai

                               };
                dgvKhachHang.DataSource = custlist.ToList();
                foreach (var i in tk )
                    cbMaKH.Items.Add(i.TenKH.Trim());  
            }
            catch
            {
                MessageBox.Show("Không kết nối được dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            LoadData();
            HandleElm.SetGridViewStyle(dgvKhachHang);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form frm = new AddClientForm();
            frm.ShowDialog();
        }
        int parentIndex = 0;
        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbMaKH.SelectedItem != null)
            {
                
                dgvKhachHang.Rows[parentIndex].Selected = false;
                String searchValue = cbMaKH.SelectedItem.ToString().Trim();
                int rowIndex = -1;
                foreach (DataGridViewRow row in dgvKhachHang.Rows)
                {
                    if (row.Cells[1].Value.ToString().Trim().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }
                dgvKhachHang.Rows[rowIndex].Selected = true;

                parentIndex = rowIndex;
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Export.ExporttoPDF(dgvKhachHang);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
