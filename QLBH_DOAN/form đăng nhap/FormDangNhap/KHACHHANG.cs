using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormDangNhap.BH;

namespace FormDangNhap
{
    public partial class KHACHHANG : Form
    {
        private readonly ShopContextDB context;
        public KHACHHANG()
        {
            context = new ShopContextDB();
            InitializeComponent();
        }
        private bool CheckValidate()
        {
            if (txtmakhach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void load()
        {
            try
            {
                dgvkhachhang.Rows.Clear(); 
                var listMakhach = from x in context.KhachHangs
                                  select new
                                  {
                                      x.MaKhach,
                                      x.TenKhach,
                                      x.DiaChi,
                                      x.DienThoai
                                  };

                foreach (var khach in listMakhach)
                {
                    int i = dgvkhachhang.Rows.Add(); 
                    dgvkhachhang.Rows[i].Cells[0].Value = khach.MaKhach;
                    dgvkhachhang.Rows[i].Cells[1].Value = khach.TenKhach;
                    dgvkhachhang.Rows[i].Cells[2].Value = khach.DiaChi;
                    dgvkhachhang.Rows[i].Cells[3].Value = khach.DienThoai;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txtThem_Click(object sender, EventArgs e)
        {
            KhachHang kt = context.KhachHangs.FirstOrDefault(p => p.MaKhach == txtmakhach.Text);
            if (kt == null)
            {
                KhachHang kh = new KhachHang();  
                kh.MaKhach = txtmakhach.Text; 
                kh.TenKhach = txttenkhach.Text;
                kh.DiaChi = txtdiachi.Text;
                kh.DienThoai = txtdienthoai.Text;
                MessageBox.Show("Khách hàng đã được thêm!", "Thông báo", MessageBoxButtons.OK);
                context.KhachHangs.Add(kh); 
                context.SaveChanges();
                load();
                Clear();
            }
            else
            {
                MessageBox.Show("Mã khách đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void txtDong_Click(object sender, EventArgs e)
        {
            this.Close();
       
        }

        private void txtXoa_Click(object sender, EventArgs e)
        {
            KhachHang xoa = context.KhachHangs.FirstOrDefault(p => p.MaKhach == txtmakhach.Text);           
            if (xoa != null)
            {
                context.KhachHangs.Remove(xoa);
                MessageBox.Show("Khách hàng đã bị xóa!", "Thông báo", MessageBoxButtons.OK);
                context.SaveChanges();
                load();
                Clear();
            }
        }

        private void txtSua_Click(object sender, EventArgs e)
        {
            KhachHang xoa = context.KhachHangs.FirstOrDefault(p => p.MaKhach == txtmakhach.Text); 
            if (xoa != null) 
            {
                context.KhachHangs.Remove(xoa); 
            }
            KhachHang kh = new KhachHang();  

            kh.MaKhach = txtmakhach.Text; 
            kh.TenKhach = txttenkhach.Text;
            kh.DiaChi = txtdiachi.Text;
            kh.DienThoai = txtdienthoai.Text;
            MessageBox.Show("Khách hàng đã sửa thông tin!", "Thông báo", MessageBoxButtons.OK);
            context.KhachHangs.Add(kh);

            context.SaveChanges(); 
            load();
            Clear();
        }

        private void dgvkhachhang_DoubleClick(object sender, EventArgs e)
        {
            dgvkhachhang.CurrentRow.Selected = true;
            txtmakhach.Text = dgvkhachhang.CurrentRow.Cells[0].FormattedValue.ToString();
            txttenkhach.Text = dgvkhachhang.CurrentRow.Cells[1].FormattedValue.ToString();
            txtdiachi.Text = dgvkhachhang.CurrentRow.Cells[2].FormattedValue.ToString();
            txtdienthoai.Text = dgvkhachhang.CurrentRow.Cells[3].FormattedValue.ToString();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            var listTenKhach = from x in context.KhachHangs
                               where x.TenKhach.Contains(txttenkhach.Text)
                               select new
                               {
                                   x.MaKhach,
                                   x.TenKhach,
                                   x.DiaChi,
                                   x.DienThoai,
                                   
                              
                               };
            dgvkhachhang.DataSource = listTenKhach.ToList();
        }

        private void Clear()
        {
            txtmakhach.Clear();
            txttenkhach.Clear();
            txtdiachi.Clear();
            txtdienthoai.Clear();
            txtmakhach.Focus();
        }
    }
}
