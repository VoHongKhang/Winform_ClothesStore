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
using Finally_project.Database.Models;
using Finally_project.Database;
using Finally_project.Database.HandleElement;

namespace Finally_project
{
    public partial class InputOrderForm : Form
    {
        bool Them = true;
        ModelQuanLyCuaHangQuanAo context = new ModelQuanLyCuaHangQuanAo();
        public InputOrderForm()
        {
            InitializeComponent();
        }
        public void AddData()
        {
            var nhacc = new NhaCungCap()
            {
                MaNCC = this.txtMaNCC.Text.Trim(),
                TenNCC = this.txtTenNCC.Text.Trim(),
                DiaChi = this.txtDiaChi.Text.Trim(),
                DienThoai = txtDienthoai.Text.Trim(),
            };

            if (this.txtMaNCC.Text.Trim() != "")
            {
                try
                {
                    context.NhaCungCaps.Add(nhacc);
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
                int r = this.dgvNCC.CurrentCell.RowIndex;
                string Mancc = this.dgvNCC.Rows[r].Cells[0].Value.ToString().Trim();
                var nhacc = context.NhaCungCaps.SingleOrDefault(tv => tv.MaNCC == Mancc);
                context.NhaCungCaps.Attach(nhacc);
                nhacc.TenNCC = this.txtTenNCC.Text.ToString().Trim();//Gán giá trị 
                nhacc.DiaChi = this.txtDiaChi.Text.ToString().Trim();//Gán giá trị
                nhacc.DienThoai = this.txtDienthoai.Text.ToString().Trim();//Gán giá trị

                context.SaveChanges();
                MessageBox.Show("Đã thêm xong!");
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
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                panelMaNCC.Enabled = false;
                
                List<NhaCungCap> tk = context.NhaCungCaps.ToList();

                dgvNCC.DataSource = null;
                var custlist = from cust in tk
                               select new
                               {
                                   Mã_nhà_cung_cấp = cust.MaNCC,
                                   Tên_nhà_cung_cấp = cust.TenNCC,
                                   Địa_chỉ = cust.DiaChi,
                                   Điện_thoại = cust.DienThoai
                               };
                dgvNCC.DataSource = custlist.ToList();
                cbTenNCC.Items.Clear();
                foreach (var i in tk)
                    cbTenNCC.Items.Add(i.TenNCC.Trim());
            }
            catch
            {
                MessageBox.Show("Không kết nối được dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int parentIndex = 0;
        private void cbTenNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenNCC.SelectedItem != null)
            {

                dgvNCC.Rows[parentIndex].Selected = false;
                String searchValue = cbTenNCC.SelectedItem.ToString().Trim();
                int rowIndex = -1;
                foreach (DataGridViewRow row in dgvNCC.Rows)
                {
                    if (row.Cells[1].Value.ToString().Trim().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }
                dgvNCC.Rows[rowIndex].Selected = true;

                parentIndex = rowIndex;
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Export.ExporttoPDF(dgvNCC);
        }

        private void InputOrderForm_Load(object sender, EventArgs e)
        {
            LoadData();
            HandleElm.SetGridViewStyle(dgvNCC);
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            Form frm = new AddinputOrderForm();
            frm.ShowDialog();
        }

        private void dgvNhapHang_SelectionChanged(object sender, EventArgs e)
        {
            //cbTenNCC.Text = dgvNhapHang.CurrentRow.Cells[1].Value?.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtMaNCC.ResetText();
            this.txtTenNCC.ResetText();
            this.txtDiaChi.ResetText();
            this.txtDienthoai.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            this.panelMaNCC.Enabled = true;
            this.txtMaNCC.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            txtMaNCC.Focus();
            panelMaNCC.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            int r = this.dgvNCC.CurrentCell.RowIndex;
            // Thứ tự dòng hiện hành
            this.txtMaNCC.Text = this.dgvNCC.Rows[r].Cells[0].Value.ToString();
            this.txtTenNCC.Text = this.dgvNCC.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text = this.dgvNCC.Rows[r].Cells[2].Value.ToString();
            this.txtDienthoai.Text = this.dgvNCC.Rows[r].Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chứ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {

                int r = this.dgvNCC.CurrentCell.RowIndex;
                string MaNCC = this.dgvNCC.Rows[r].Cells[0].Value.ToString();
                NhaCungCap ncc = context.NhaCungCaps.SingleOrDefault(tv => tv.MaNCC == MaNCC);//Xác định thành viên cần xóa
                context.NhaCungCaps.Remove(ncc);
                context.SaveChanges();//Xác nhận thay đổi
                MessageBox.Show("Đã xóa xong!");
                LoadData();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
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
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
