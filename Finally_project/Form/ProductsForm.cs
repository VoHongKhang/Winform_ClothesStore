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
using Finally_project.Database.HandleElement;

namespace Finally_project
{
    public partial class ProductsForm : Form
    {

        ModelQuanLyCuaHangQuanAo context = new ModelQuanLyCuaHangQuanAo();
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them = false;
        public ProductsForm()
        {
            InitializeComponent();
        }


        public void AddData()
        {

            var sanPham = new SanPham()
            {
                MaSP = this.txtMaSp.Text.Trim(),
                TenSP = this.txtTenSP.Text.Trim(),
                TenLoaiSP = this.txtLoaiSP.Text.Trim(),
                Gia =Convert.ToInt32(this.txtGiaThanh.Text.Trim())
            };

            if (this.txtMaSp.Text.Trim() != "")
            {
                try
                {
                    context.SanPhams.Add(sanPham);
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
                int r = this.dgvSP.CurrentCell.RowIndex;
                string MaSP = this.dgvSP.Rows[r].Cells[0].Value.ToString().Trim();
                var sanPham = context.SanPhams.SingleOrDefault(tv => tv.MaSP == MaSP);
                context.SanPhams.Attach(sanPham);
                sanPham.TenSP= this.txtTenSP.Text.ToString().Trim();//Gán giá trị 
                sanPham.TenLoaiSP = this.txtLoaiSP.Text.ToString().Trim();//Gán giá trị
                sanPham.Gia =Convert.ToInt32(this.txtGiaThanh.Text.ToString().Trim());//Gán giá trị 

                context.SaveChanges();
                MessageBox.Show("Đã thêm xong!");
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
        private void LoadData()
        {
            try
            {
                this.dgvSP.DataSource = null;
                var custlist = from cust in context.SanPhams
                               select new
                               {
                                   Mã_sản_phẩm = cust.MaSP,
                                   Tên_sản_phẩm = cust.TenSP,
                                   Tên_loại_SP = cust.TenLoaiSP,
                                   Giá = cust.Gia

                               };
                this.dgvSP.DataSource = custlist.ToList();
                foreach (var i in custlist)
                    cbxTuyChon.Items.Add(i.Tên_sản_phẩm.Trim());
                // Xóa trống các đối tượng trong Panel
                this.txtMaSp.ResetText();
                this.txtTenSP.ResetText();
                this.txtLoaiSP.ResetText();
                this.txtGiaThanh.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.panelMaNCC.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSua.Enabled = true;
                Them = false;
            }
            catch
            {
                MessageError();
            }
        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            HandleElm.SetGridViewStyle(dgvSP);
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtMaSp.ResetText();
            this.txtTenSP.ResetText();
            this.txtLoaiSP.ResetText();
            this.txtGiaThanh.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panelMaNCC.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.txtMaSp.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            txtMaSp.Focus();
            panelMaNCC.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            int r = this.dgvSP.CurrentCell.RowIndex;
            // Thứ tự dòng hiện hành
            this.txtMaSp.Text = "Không được sửa ";
            this.txtTenSP.Text = this.dgvSP.Rows[r].Cells[1].Value.ToString();
            this.txtLoaiSP.Text = this.dgvSP.Rows[r].Cells[2].Value.ToString();
            this.txtGiaThanh.Text = this.dgvSP.Rows[r].Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chứ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {

                int r = this.dgvSP.CurrentCell.RowIndex;
                string MaSP = this.dgvSP.Rows[r].Cells[0].Value.ToString();
                SanPham sanPham = context.SanPhams.SingleOrDefault(tv => tv.MaSP == MaSP);//Xác định thành viên cần xóa
                context.SanPhams.Remove(sanPham);
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
            Them = false;
            // Xóa trống các đối tượng trong Panel
            this.txtMaSp.ResetText();
            this.txtTenSP.ResetText();
            this.txtLoaiSP.ResetText();
            this.txtGiaThanh.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.panelMaNCC.Enabled = false;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc không?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                this.Hide();
            }
        }

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int parentIndex = 0;
        private void cbxTuyChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTuyChon.SelectedItem != null)
            {

                dgvSP.Rows[parentIndex].Selected = false;
                String searchValue = cbxTuyChon.SelectedItem.ToString().Trim();
                int rowIndex = -1;
                foreach (DataGridViewRow row in dgvSP.Rows)
                {
                    if (row.Cells[1].Value.ToString().Trim().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }
                dgvSP.Rows[rowIndex].Selected = true;

                parentIndex = rowIndex;
            }
        }
    }
}
