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
    public partial class formMain : Form
    {
       
        bool isThoat = true;
        public formMain()
        {
            InitializeComponent();
        }

        private void cHẤTLIỆUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CHATLIEU"] == null)
            {
                CHATLIEU fcl = new CHATLIEU();
                fcl.MdiParent = this;
                fcl.Show();
            }
            else
                Application.OpenForms["CHATLIEU"].Activate();

        }


        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NHANVIEN"] == null)
            {
                NHANVIEN fnv = new NHANVIEN();
                fnv.MdiParent = this;
                fnv.Show();
            }
            else
                Application.OpenForms["NHANVIEN"].Activate();

        }

        private void formMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void kHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["KHACHHANG"] == null)
            {
                KHACHHANG fkh = new KHACHHANG();
                fkh.MdiParent = this;
                fkh.Show();
            }
            else
                Application.OpenForms["KHACHHANG"].Activate();

        }

        private void hÀNGHÓAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["HANGHOA"] == null)
            {
                HANGHOA fhh = new HANGHOA();
                fhh.MdiParent = this;
                fhh.Show();
            }
            else
                Application.OpenForms["HANGHOA"].Activate();

        }

        private void đĂNGNHẬPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            this.Close();
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tHỐNGKÊHÓAĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["HOADONBAN"] == null)
            {
                HOADONBAN hdb = new HOADONBAN();
                hdb.MdiParent = this;
                hdb.Show();
            }
            else
                Application.OpenForms["HOADONBAN"].Activate();
        }

        private void bÁNHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CT_HOADONBAN"] == null)
            {
                CT_HOADONBAN cthdb = new CT_HOADONBAN();
                cthdb.MdiParent = this;
                cthdb.Show();
            }
            else
                Application.OpenForms["CT_HOADONBAN"].Activate();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["LIENHE"] == null)
            {
                LIENHE lh = new LIENHE();
                lh.MdiParent = this;
                lh.Show();
            }
            else
                Application.OpenForms["LIENHE"].Activate();
        }
    
    }
}
