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
using Finally_project.Database.Models;
using Finally_project.Database.CreateData;
using Finally_project.Database.HandleElement;

namespace Finally_project
{
    public partial class AddClientForm : Form
    {
        ModelQuanLyCuaHangQuanAo context = new ModelQuanLyCuaHangQuanAo();
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them=false;
        // Method

        public void AddData()
        {

            var khachHang = new KhachHang()
            {
                MaKH = this.txtMaKH.Text.Trim(),
                TenKH = this.txtTenKH.Text.Trim(),
                DiaChi = this.txtDiaChi.Text.Trim(),
                DienThoai = this.txtSDT.Text.Trim()
            };

            if (this.txtMaKH.Text.Trim() != "")
            {
                try
                {
                    context.KhachHangs.Add(khachHang);
                    context.SaveChanges();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void ChangeData()
        {
            //Sửa
            //Xác định thanh viên cần sửa
            try
            {               
                int r = this.dgvKH.CurrentCell.RowIndex;
                string MaKH = this.dgvKH.Rows[r].Cells[0].Value.ToString().Trim();
                var khachHang = context.KhachHangs.SingleOrDefault(tv => tv.MaKH == MaKH);
                context.KhachHangs.Attach(khachHang);
                khachHang.TenKH = this.txtTenKH.Text.ToString().Trim();//Gán giá trị 
                khachHang.DiaChi = this.txtDiaChi.Text.ToString().Trim();//Gán giá trị
                khachHang.DienThoai = this.txtSDT.Text.ToString().Trim();//Gán giá trị 

                context.SaveChanges();
                MessageBox.Show("Đã thêm xong!");
            }
            catch
            {
                MessageError();
                
            }
        }
        private void LoadData()
        {
            try
            {
                this.dgvKH.DataSource = null;
                var custlist = from cust in context.KhachHangs
                               select new
                               {
                                   Mã_khách_hàng = cust.MaKH,
                                   Tên_khách_hàng = cust.TenKH,
                                   Địa_chỉ = cust.DiaChi,
                                   Điện_thoại = cust.DienThoai

                               };
                this.dgvKH.DataSource = custlist.ToList();
                foreach (var i in custlist)
                    cbxTuyChon.Items.Add(i.Tên_khách_hàng.Trim());
                // Xóa trống các đối tượng trong Panel
                this.txtMaKH.ResetText();
                this.txtTenKH.ResetText();
                this.txtDiaChi.ResetText();
                this.txtSDT.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.panelMaKH.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnTroVe.Enabled = true;
                Them = false;
            }
            catch
            {
                MessageError();
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Them = false;
            // Xóa trống các đối tượng trong Panel
            this.txtMaKH.ResetText();
            this.txtTenKH.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnTroVe.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled=true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.panelMaKH.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtMaKH.ResetText();
            this.txtTenKH.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panelMaKH.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnTroVe.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMaKH.Focus();
        }

        private void btnTroVe_Click_1(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc không?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                this.Hide();
            }
        }

        public AddClientForm()
        {
            InitializeComponent();
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            HandleElm.SetGridViewStyle(dgvKH);
            LoadData();
        }
        public void MessageError()
        {
            MessageBox.Show("Lỗi", "Có lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chứ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {

                int r = this.dgvKH.CurrentCell.RowIndex;
                string MaKH = this.dgvKH.Rows[r].Cells[0].Value.ToString();
                KhachHang khachHang = context.KhachHangs.SingleOrDefault(tv => tv.MaKH == MaKH);//Xác định thành viên cần xóa
                context.KhachHangs.Remove(khachHang);
                context.SaveChanges();//Xác nhận thay đổi
                MessageBox.Show("Đã xóa xong!");
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            // Cho thao tác
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panelMaKH.Enabled = true;
            // Không cho thao tác
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            txtTenKH.Focus();           
            int r = this.dgvKH.CurrentCell.RowIndex;
            // Thứ tự dòng hiện hành
            this.txtMaKH.Text = this.dgvKH.Rows[r].Cells[0].Value.ToString();
            this.txtTenKH.Text = this.dgvKH.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text = this.dgvKH.Rows[r].Cells[2].Value.ToString();
            this.txtSDT.Text = this.dgvKH.Rows[r].Cells[3].Value.ToString();
        }

        int parentIndex = 0;
        private void cbxTuyChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTuyChon.SelectedItem != null)
            {

                dgvKH.Rows[parentIndex].Selected = false;
                String searchValue = cbxTuyChon.SelectedItem.ToString().Trim();
                int rowIndex = -1;
                foreach (DataGridViewRow row in dgvKH.Rows)
                {
                    if (row.Cells[1].Value.ToString().Trim().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }
                dgvKH.Rows[rowIndex].Selected = true;

                parentIndex = rowIndex;
            }
        }
    }
}
