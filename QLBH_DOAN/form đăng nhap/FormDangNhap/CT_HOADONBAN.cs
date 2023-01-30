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
    public partial class CT_HOADONBAN : Form
    {
        public CT_HOADONBAN()
        {
            InitializeComponent();
        }

        private ShopContextDB context = new ShopContextDB();
        private void NapDataChoCbChatLieu()
        {
            cbChatLieu.DataSource = context.ChatLieus.ToList();
            cbChatLieu.DisplayMember = "TenChatLieu";
            cbChatLieu.ValueMember = "MaChatLieu";
        }

        private void NapDuLieuDgv()
        {
            dgvchitiethdban.DataSource = (from c in context.ChiTietHDBans
                                          select new
                                          {
                                              c.MaCT,
                                              c.MaHoaDonBan,
                                              c.HangHoa.TenHang,
                                              c.SoLuong,
                                              c.ThanhTien
                                          }).ToList();
        }
        private void NapDataCBHoaDon()
        {
            cbMaHd.DataSource = context.HoaDonBans.ToList();
            cbMaHd.DisplayMember = "MaHoaDonBan";
        }
        private void CT_HOADONBAN_Load(object sender, EventArgs e)
        {
            NapDataChoCbChatLieu();
            NapDuLieuDgv();
            NapDataCBHoaDon();
        }

        private void cbChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChatLieu cl = cbChatLieu.SelectedItem as ChatLieu;
            List<HangHoa> list = new List<HangHoa>();
            list.Clear();
            list = context.HangHoas.Where(p => p.MaChatLieu == cl.MaChatLieu).ToList();

            cbHangHoa.DataSource = list;
            cbHangHoa.DisplayMember = "TenHang";
            cbHangHoa.ValueMember = "MaHang";                     
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            HangHoa sp = cbHangHoa.SelectedItem as HangHoa;

            ChiTietHDBan x = new ChiTietHDBan();
            if (numSlg.Value > 0)
            {
                x.MaCT = int.Parse(txtmact.Text);
                x.MaHoaDonBan = cbMaHd.Text;
                x.MaHang = sp.MaHang;
                x.SoLuong = float.Parse(numSlg.Value.ToString());
                x.ThanhTien = sp.GiaBan * float.Parse(numSlg.Value.ToString());
                MessageBox.Show("Mặt hàng đã được thêm!", "Thông Báo", MessageBoxButtons.OK);
                context.ChiTietHDBans.Add(x);
                context.SaveChanges();
                NapDuLieuDgv();
            }
            else
                MessageBox.Show("Vui lòng chọn số lượng hàng", "Thông báo", MessageBoxButtons.OK);

            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int NUM = int.Parse(txtmact.Text);
            ChiTietHDBan xoa = context.ChiTietHDBans.FirstOrDefault(p => p.MaCT == NUM); 
            if (xoa != null) 
            {
                context.ChiTietHDBans.Remove(xoa);
                MessageBox.Show("Mặt hàng đã được xóa!", "Thông Báo", MessageBoxButtons.OK);
                context.SaveChanges();

                NapDuLieuDgv();
                Clear();
            }
        }

        private void Clear()
        {
            txtmact.Clear();
         }

        private void dgvchitiethdban_DoubleClick(object sender, EventArgs e)
        {
            dgvchitiethdban.CurrentRow.Selected = true;
            txtmact.Text = dgvchitiethdban.CurrentRow.Cells[0].FormattedValue.ToString(); 
            cbMaHd.Text = dgvchitiethdban.CurrentRow.Cells[1].FormattedValue.ToString();
            cbHangHoa.Text = dgvchitiethdban.CurrentRow.Cells[2].FormattedValue.ToString();
            numSlg.Value =int.Parse(dgvchitiethdban.CurrentRow.Cells[3].FormattedValue.ToString());


        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int NUM = int.Parse(txtmact.Text);
            ChiTietHDBan xoa = context.ChiTietHDBans.FirstOrDefault(p => p.MaCT == NUM);
            if (xoa != null)
            {
                context.ChiTietHDBans.Remove(xoa);
            }
            HangHoa sp = cbHangHoa.SelectedItem as HangHoa;
            ChiTietHDBan x = new ChiTietHDBan();
            if (numSlg.Value > 0)
            {
                x.MaCT = int.Parse(txtmact.Text);
                x.MaHoaDonBan = cbMaHd.Text;
                x.MaHang = sp.MaHang;
                x.SoLuong = float.Parse(numSlg.Value.ToString());
                x.ThanhTien = sp.GiaBan * float.Parse(numSlg.Value.ToString());
                MessageBox.Show("Mặt hàng đã được sửa!", "Thông Báo", MessageBoxButtons.OK);
                context.ChiTietHDBans.Add(x);
                context.SaveChanges();
                NapDuLieuDgv();
                Clear();
            }
            else
                MessageBox.Show("Vui lòng chọn số lượng hàng", "Thông báo", MessageBoxButtons.OK);

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            var listTenHang = from x in context.ChiTietHDBans
                              where x.HangHoa.TenHang.Contains(cbHangHoa.Text)
                              select new
                              {
                                  x.MaCT,
                                  x.MaHoaDonBan,
                                  x.HangHoa.TenHang,
                                  x.SoLuong,
                                  x.ThanhTien
                              };
            dgvchitiethdban.DataSource = listTenHang.ToList();
        }
    }
}
