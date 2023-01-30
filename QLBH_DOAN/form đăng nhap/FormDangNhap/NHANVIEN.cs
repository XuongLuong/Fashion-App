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
    public partial class NHANVIEN : Form
    {
        private readonly ShopContextDB context;
        public NHANVIEN()
        {
            context = new ShopContextDB();
            InitializeComponent();
        }

        private bool CheckValidate()
        {
            if (txtmanhanvien.Text == "")
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
                dgvnhanvien.Rows.Clear(); 
                var listMaNhanVien = from x in context.NhanViens
                                  select new
                                  {
                                      x.MaNhanVien, 
                                      x.TenNhanVien,
                                      x.DiaChi,
                                      x.DienThoai,
                                      x.GioiTinh,
                                      x.NgaySinh
                                  };

                foreach (var nhanvien in listMaNhanVien)
                {
                    int i = dgvnhanvien.Rows.Add(); 
                    dgvnhanvien.Rows[i].Cells[0].Value = nhanvien.MaNhanVien;
                    dgvnhanvien.Rows[i].Cells[1].Value = nhanvien.TenNhanVien;
                    dgvnhanvien.Rows[i].Cells[2].Value = nhanvien.GioiTinh;
                    dgvnhanvien.Rows[i].Cells[3].Value = nhanvien.DiaChi;
                    dgvnhanvien.Rows[i].Cells[4].Value = nhanvien.DienThoai;
                    dgvnhanvien.Rows[i].Cells[5].Value = nhanvien.NgaySinh;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void NHANVIEN_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txtThem_Click(object sender, EventArgs e)
        {
            NhanVien kt = context.NhanViens.FirstOrDefault(p => p.MaNhanVien == txtmanhanvien.Text);
            if (kt == null)
            {
                NhanVien nv = new NhanVien();   

                nv.MaNhanVien = txtmanhanvien.Text; 
                nv.TenNhanVien = txttennhanvien.Text;
                nv.DiaChi = txtdiachi.Text;
                nv.DienThoai = txtdienthoai.Text;
                if(rbNam.Checked == true )
                {
                    nv.GioiTinh = "Nam";
                }
                else
                {
                    nv.GioiTinh = "Nữ";
                }    
                dTNgaySinh.CustomFormat = "dd/MM/yyyy";
                nv.NgaySinh =DateTime.Parse(dTNgaySinh.Text);
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK);

                context.NhanViens.Add(nv); 
                context.SaveChanges();
                load();
                Clear();
            }
            else
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void txtDong_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txtXoa_Click(object sender, EventArgs e)
        {
            NhanVien xoa = context.NhanViens.FirstOrDefault(p => p.MaNhanVien == txtmanhanvien.Text);  
            if (xoa != null) 
            {
                context.NhanViens.Remove(xoa);
                MessageBox.Show("Nhân viên đã bị xóa!", "Thông báo", MessageBoxButtons.OK);
                context.SaveChanges();
                load();
                Clear();
            }
        }

        private void txtSua_Click(object sender, EventArgs e)
        {
            NhanVien xoa = context.NhanViens.FirstOrDefault(p => p.MaNhanVien == txtmanhanvien.Text); 
            if (xoa != null)
            {
                context.NhanViens.Remove(xoa); 
            }
            NhanVien nv = new NhanVien();   

            nv.MaNhanVien = txtmanhanvien.Text; 
            nv.TenNhanVien = txttennhanvien.Text;
            if (rbNam.Checked == true)
            {
                nv.GioiTinh = "Nam";
            }
            else
                nv.GioiTinh = "Nữ";
         
            nv.DiaChi = txtdiachi.Text;
            nv.DienThoai = txtdienthoai.Text;
            dTNgaySinh.CustomFormat = "dd/MM/yyyy";
            nv.NgaySinh = DateTime.Parse(dTNgaySinh.Text);
            MessageBox.Show("Nhân viên đã sửa thông tin!", "Thông báo", MessageBoxButtons.OK);
            context.NhanViens.Add(nv); 
            context.SaveChanges();
            load();
            Clear();

        }

        private void dgvnhanvien_DoubleClick(object sender, EventArgs e)
        {
            dgvnhanvien.CurrentRow.Selected = true;
            txtmanhanvien.Text = dgvnhanvien.CurrentRow.Cells[0].FormattedValue.ToString();
            txttennhanvien.Text = dgvnhanvien.CurrentRow.Cells[1].FormattedValue.ToString();
            txtdiachi.Text = dgvnhanvien.CurrentRow.Cells[3].FormattedValue.ToString();
            txtdienthoai.Text = dgvnhanvien.CurrentRow.Cells[4].FormattedValue.ToString();
            String Gt = dgvnhanvien.CurrentRow.Cells[2].FormattedValue.ToString(); // vd: nam
            if (Gt == "Nam")
            {
                rbNam.Checked = true;
            }
            else
                rbNu.Checked = true;
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            var listTenNhanVien = from x in context.NhanViens
                                  where x.TenNhanVien.Contains(txttennhanvien.Text)
                                  select new
                                  {
                                      x.MaNhanVien,
                                      x.TenNhanVien,
                                      x.DiaChi,
                                      x.DienThoai,

                                      x.GioiTinh,
                                      x.NgaySinh,
                                  };
            dgvnhanvien.DataSource = listTenNhanVien.ToList();
        }

        private void Clear()
        {
            txtmanhanvien.Clear();
            txttennhanvien.Clear();
            //txtgioitinh.Clear();
            txtdiachi.Clear();
            txtdienthoai.Clear();
            txtmanhanvien.Focus();
        }
            
    }
}
