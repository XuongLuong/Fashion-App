using FormDangNhap.BH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FormDangNhap
{
   
    public partial class CHATLIEU : Form
    {
        private readonly ShopContextDB context;
        public CHATLIEU()
        {
            context = new ShopContextDB();
            InitializeComponent();
        }

    /*    private int GetSelectedRow(string MaChatLieu) // k can thiet
        {
            for (int i = 0; i < dgvchatlieu.Rows.Count; i++)
            {
                if (dgvchatlieu.Rows[i].Cells[0].Value != null)
                {
                    if (dgvchatlieu.Rows[i].Cells[0].Value.ToString() == MaChatLieu)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }*/

        private bool CheckValidate()
        {
            if (txtmachatlieu.Text == "")
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
                dgvchatlieu.Rows.Clear(); 
                var listMaChatLieu = from x in context.ChatLieus
                                     select new
                                     {
                                         x.MaChatLieu,
                                         x.TenChatLieu
                                     }; 

                foreach (var vatLieu in listMaChatLieu)
                {
                    int i = dgvchatlieu.Rows.Add(); 
                    dgvchatlieu.Rows[i].Cells[0].Value = vatLieu.MaChatLieu;
                    dgvchatlieu.Rows[i].Cells[1].Value = vatLieu.TenChatLieu;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CHATLIEU_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnThem_Click(object sender, EventArgs e) 
        {
                ChatLieu kt = context.ChatLieus.FirstOrDefault(p => p.MaChatLieu == txtmachatlieu.Text);
            if( kt == null)
            {
                ChatLieu cl = new ChatLieu();   
                cl.MaChatLieu = txtmachatlieu.Text; 
                cl.TenChatLieu = txttenchatlieu.Text;
                MessageBox.Show("Chất liệu đã được thêm!", "Thông Báo", MessageBoxButtons.OK);

                context.ChatLieus.Add(cl); 
                context.SaveChanges();
                load();
                Clear();
                
            }
            else
            {
                MessageBox.Show("MÃ CHẤT LIỆU ĐÃ TỒN TẠI", "Thông báo", MessageBoxButtons.OK);
            }
                
         
            
        }

        

        private void txtDong_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void txtXoa_Click(object sender, EventArgs e) 
        {
            ChatLieu xoa = context.ChatLieus.FirstOrDefault(p => p.MaChatLieu == txtmachatlieu.Text);  
            if ( xoa != null) 
            {
                MessageBox.Show("Chất liệu đã được xóa!", "Thông Báo", MessageBoxButtons.OK);
                context.ChatLieus.Remove(xoa); 
                context.SaveChanges();
                load();
                Clear();
            }    
        }

        private void txtSua_Click(object sender, EventArgs e)
        {
            ChatLieu xoa = context.ChatLieus.FirstOrDefault(p => p.MaChatLieu == txtmachatlieu.Text);
            if (xoa != null) 
            {
                context.ChatLieus.Remove(xoa);
            }
            ChatLieu cl = new ChatLieu();   

            cl.MaChatLieu = txtmachatlieu.Text; 
            cl.TenChatLieu = txttenchatlieu.Text;
            MessageBox.Show("Chất liệu đã được sửa!", "Thông Báo", MessageBoxButtons.OK);
            context.ChatLieus.Add(cl);

            context.SaveChanges();
            load();
            Clear();
        }

        private void dgvchatlieu_DoubleClick(object sender, EventArgs e)
        {
            dgvchatlieu.CurrentRow.Selected = true;
            txtmachatlieu.Text = dgvchatlieu.CurrentRow.Cells[0].FormattedValue.ToString();
            txttenchatlieu.Text = dgvchatlieu.CurrentRow.Cells[1].FormattedValue.ToString();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            var listTenChatLieu = from x in context.ChatLieus
                                  where x.TenChatLieu.Contains(txttenchatlieu.Text)
                                  select new
                                  {
                                      x.MaChatLieu,
                                      x.TenChatLieu,
                                     
                                  };
            dgvchatlieu.DataSource = listTenChatLieu.ToList();
        }

        private void Clear()
        {
            txtmachatlieu.Clear();
            txttenchatlieu.Clear();
            txtmachatlieu.Focus();
        }
    }
}
    