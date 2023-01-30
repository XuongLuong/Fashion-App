using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangNhap
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        List<taikhoan> listTaiKhoan = DanhSachCacTaiKhoan.Instance.ListTaiKhoan;

        bool KiemTraDangNhap(string tentaikhoan,string matkhau)
        {
            for (int i = 0; i < listTaiKhoan.Count;i++ )
            {
                if (tentaikhoan == listTaiKhoan[i].TenTaiKhoan && matkhau == listTaiKhoan[i].MatKhau)
                    return true;
            }

                return false;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
                
            if (KiemTraDangNhap(txtTK.Text,txtMK.Text))
            {
                formMain f = new formMain();
                f.Show();
                this.Hide();
                MessageBox.Show("Xin chào bạn đến với phần mềm của chúng tôi!", "Thông báo");
            }
            else
            {
                
                MessageBox.Show("Sai tài khoản hoặc mật khẩu","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtTK.Clear();
                txtMK.Clear();
                txtTK.Focus();
            }
                
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult Ex = MessageBox.Show("Bạn có muốn thoát không?", " Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(Ex == DialogResult.Yes)
            { Application.Exit(); }

        }

    }
}
