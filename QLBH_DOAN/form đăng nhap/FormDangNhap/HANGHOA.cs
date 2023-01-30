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
   
    public partial class HANGHOA : Form
    {
        private readonly ShopContextDB context;
        public HANGHOA()
        {
            context = new ShopContextDB();
            InitializeComponent();
        }
        private bool CheckValidate()
        {
            if (txtmahang.Text == "")
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
                dgvhanghoa.Rows.Clear(); // clear ben winform
                var listMaHang = from x in context.HangHoas
                                  select new
                                  {
                                      x.MaHang,
                                      x.TenHang,
                                      x.MaChatLieu,
                                      x.GiaBan
                                  };

                foreach (var hang in listMaHang) //foreach (<kiểu dữ liệu> <tên biến tạm> in <tên mảng hoặc tập hợp>)
                {
                    int i = dgvhanghoa.Rows.Add(); // i = 0;
                    dgvhanghoa.Rows[i].Cells[0].Value = hang.MaHang;
                    dgvhanghoa.Rows[i].Cells[1].Value = hang.TenHang;
                    dgvhanghoa.Rows[i].Cells[2].Value = hang.MaChatLieu;
                    dgvhanghoa.Rows[i].Cells[3].Value = hang.GiaBan;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void HANGHOA_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txtThem_Click(object sender, EventArgs e)
        {
            HangHoa kt = context.HangHoas.FirstOrDefault(p => p.MaHang == txtmahang.Text);
            if (kt == null)
            {
                HangHoa hh = new HangHoa();   // bước 1 : khai báo 1 biến với kiểu có nhiều thành phần yêu cầu

                hh.MaHang = txtmahang.Text; // bước 2 : gán GIÁ TRỊ CHO BIẾN MỚI KHỞI TẠO
                hh.TenHang = txttenhang.Text;
                hh.MaChatLieu = txtmachatlieu.Text;
                hh.GiaBan = float.Parse(txtgiaban.Text);
               

                context.HangHoas.Add(hh); // BƯỚC 3 ADD VÀ LƯU THÔNG CHO CÁI BẢNG SQL CÙNG KIỂU VỚI BIẾN VỪA NHẬP
                context.SaveChanges();
                load();
                Clear();
            }
            else
            {
                MessageBox.Show("MÃ HÀNG ĐÃ TỒN TẠI!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void txtDong_Click(object sender, EventArgs e)
        {
            this.Close();
           
          
        }

        private void txtXoa_Click(object sender, EventArgs e)
        {
            HangHoa xoa = context.HangHoas.FirstOrDefault(p => p.MaHang == txtmahang.Text);// KIỂM TRA TT MÌNH MUỐN XÓA CÓ TRONG DỮ LIỆU K
            if (xoa != null) // kiem tra bien co ton tai k
            {
                context.HangHoas.Remove(xoa); // Xoa thong tin can
                context.SaveChanges();
                load();
                Clear();
            }
        }

        private void txtSua_Click(object sender, EventArgs e)
        {
            HangHoa xoa = context.HangHoas.FirstOrDefault(p => p.MaHang == txtmahang.Text); // KIỂM TRA TT MÌNH MUỐN XÓA CÓ TRONG DỮ LIỆU K
            if (xoa != null) // kiem tra bien co ton tai k
            {
                context.HangHoas.Remove(xoa); // Xoa thong tin can
            }
           HangHoa hh = new HangHoa();   // bước 1 : khai báo 1 biến với kiểu có nhiều thành phần yêu cầu

            hh.MaHang = txtmahang.Text; // bước 2 : gán GIÁ TRỊ CHO BIẾN MỚI KHỞI TẠO
            hh.TenHang = txttenhang.Text;
            hh.MaChatLieu = txtmachatlieu.Text;
            hh.GiaBan = float.Parse(txtgiaban.Text);
            context.HangHoas.Add(hh);

            context.SaveChanges(); // LUU Y: SAVE CHI GOI 1 LAN TRONG 1 HAM
            load();
            Clear();
        }

        private void dgvhanghoa_DoubleClick(object sender, EventArgs e)
        {
            dgvhanghoa.CurrentRow.Selected = true;
            txtmahang.Text = dgvhanghoa.CurrentRow.Cells[0].FormattedValue.ToString();
            txttenhang.Text = dgvhanghoa.CurrentRow.Cells[1].FormattedValue.ToString();
            txtmachatlieu.Text = dgvhanghoa.CurrentRow.Cells[2].FormattedValue.ToString();
            txtgiaban.Text = dgvhanghoa.CurrentRow.Cells[3].FormattedValue.ToString();
           

        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            var listTenHang = from x in context.HangHoas
                                  where x.TenHang.Contains(txttenhang.Text)
                                  select new
                                  {
                                      x.MaHang,
                                      x.TenHang,
                                      x.MaChatLieu,
                                      x.GiaBan
                                     
                                  };
            dgvhanghoa.DataSource = listTenHang.ToList();
        }

        private void Clear()
        {
            txtmahang.Clear();
            txttenhang.Clear();
            txtmachatlieu.Clear();
            txtgiaban.Clear();
            txtmahang.Focus();
        }
    }
}
