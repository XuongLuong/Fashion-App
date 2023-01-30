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
    public partial class HOADONBAN : Form
    {
        private readonly ShopContextDB context;
        public HOADONBAN()
        {
            context = new ShopContextDB();
            InitializeComponent();
        }

        private bool CheckValidate()
        {
            if (txtmahoadonban.Text == "")
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
                dgvhoadonban.Rows.Clear();
                var listMaHoaDonBan = from x in context.HoaDonBans
                                  select new
                                  {
                                      x.MaHoaDonBan,
                                      x.MaNhanVien,
                                      x.NgayBan,
                                      x.MaKhach
                                     
                                  };

                foreach (var khach in listMaHoaDonBan) 
                {
                    int i = dgvhoadonban.Rows.Add(); 
                    dgvhoadonban.Rows[i].Cells[0].Value = khach.MaHoaDonBan;
                    dgvhoadonban.Rows[i].Cells[1].Value = khach.MaNhanVien;
                    dgvhoadonban.Rows[i].Cells[2].Value = khach.NgayBan;
                    dgvhoadonban.Rows[i].Cells[3].Value = khach.MaKhach;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void HOADONBAN_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txtThem_Click(object sender, EventArgs e)
        {
            HoaDonBan kt = context.HoaDonBans.FirstOrDefault(p => p.MaHoaDonBan == txtmahoadonban.Text);
            if (kt == null)
            {
                HoaDonBan hdb = new HoaDonBan();   

                hdb.MaHoaDonBan = txtmahoadonban.Text; 
                hdb.MaNhanVien = txtmanhanvien.Text;
                hdb.MaKhach = txtmakhach.Text;
                dTNgayBan.CustomFormat = "dd/MM/yyyy";
                hdb.NgayBan = DateTime.Parse(dTNgayBan.Text);
                MessageBox.Show("Hóa đơn đã được thêm!", "Thông báo", MessageBoxButtons.OK);

                context.HoaDonBans.Add(hdb); 
                context.SaveChanges();
                load();
                Clear();
            }
            else
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại", "Thông báo", MessageBoxButtons.OK);
            }
        }


        private void Clear()
        {
            txtmahoadonban.Clear();
            txtmanhanvien.Clear();
            txtmakhach.Clear();
           
            txtmahoadonban.Focus();
        }

        private void txtXoa_Click(object sender, EventArgs e)
        {
            HoaDonBan xoa = context.HoaDonBans.FirstOrDefault(p => p.MaHoaDonBan == txtmahoadonban.Text);  // KIỂM TRA TT MÌNH MUỐN XÓA CÓ TRONG DỮ LIỆU K
            if (xoa != null) 
            {
                context.HoaDonBans.Remove(xoa);
                MessageBox.Show("Hóa đơn đã được xóa!", "Thông báo", MessageBoxButtons.OK);
                context.SaveChanges();
                load();
                Clear();
            }
        }

        private void txtSua_Click(object sender, EventArgs e)
        {
            HoaDonBan xoa = context.HoaDonBans.FirstOrDefault(p => p.MaHoaDonBan == txtmahoadonban.Text);
            if (xoa != null)
            {
                context.HoaDonBans.Remove(xoa);
            }
            HoaDonBan hdb = new HoaDonBan();

            hdb.MaHoaDonBan = txtmahoadonban.Text;
            hdb.MaNhanVien = txtmanhanvien.Text;
            hdb.MaKhach = txtmakhach.Text;
            dTNgayBan.CustomFormat = "dd/MM/yyyy";
            hdb.NgayBan = DateTime.Parse(dTNgayBan.Text);

            MessageBox.Show("Hóa đơn đã được sửa!", "Thông báo", MessageBoxButtons.OK);

            context.HoaDonBans.Add(hdb);
            context.SaveChanges();
            load();
            Clear();
        }

        private void dgvhoadonban_DoubleClick(object sender, EventArgs e)
        {
            dgvhoadonban.CurrentRow.Selected = true;
            txtmahoadonban.Text = dgvhoadonban.CurrentRow.Cells[0].FormattedValue.ToString();
            txtmanhanvien.Text = dgvhoadonban.CurrentRow.Cells[1].FormattedValue.ToString();
            txtmakhach.Text = dgvhoadonban.CurrentRow.Cells[3].FormattedValue.ToString();
           
        }

        private void txtDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            var listMaNhanVien = from x in context.HoaDonBans
                                 where x.MaNhanVien.Contains(txtmanhanvien.Text)
                                 select new
                                 {
                                     x.MaHoaDonBan,
                                     x.MaNhanVien,
                                     x.NgayBan,
                                     x.MaKhach
                                 };
            dgvhoadonban.DataSource = listMaNhanVien.ToList();
        }
    }
   
    
}
