using Finally_project.Database.CreateData;
using Finally_project.Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finally_project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new RegisterForm();
            frm.ShowDialog();
        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            ModelQuanLyCuaHangQuanAo Models = new ModelQuanLyCuaHangQuanAo();
            List<TaiKhoan> tk = Models.TaiKhoans.ToList();
            foreach (var item in tk )
            {
                if ((txtUser.Text==item.TenDN.Trim()) &&(txtPassWord.Text==item.MatKhau.Trim()))
                {
                    this.Hide();
                    Form frm = new Home(item);
                    frm.ShowDialog();
                    break;
                }
                
            }
                     
           MessageBox.Show("Không đúng tên người dùng / mật khẩu!!!", "Thông báo");
           this.txtUser.Focus();
                     
        }


        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == 13)
            {
                txtUser.Text.ToString().Remove(txtUser.Text.ToString().Length-1);
                txtPassWord.Focus();
            } 
        }

        private void txtPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtPassWord.Text.ToString().Remove(txtPassWord.Text.ToString().Length - 1);
                btnDangNhap_Click(sender, e);
            }    
        }

        private void picBoxThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
