using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDangNhap
{
    public class DanhSachCacTaiKhoan
    {
        private static DanhSachCacTaiKhoan instance;

        public static DanhSachCacTaiKhoan Instance
        {
            get { 
                if(instance == null)
                {
                    instance = new DanhSachCacTaiKhoan();
                }
                 return DanhSachCacTaiKhoan.instance; 
                }
            set { 
                     DanhSachCacTaiKhoan.instance = value;
                }
        }

        List<taikhoan> listTaiKhoan;

        public List<taikhoan> ListTaiKhoan
        {
            get { return listTaiKhoan; }
            set { listTaiKhoan = value; }
        }

        DanhSachCacTaiKhoan()
        { 
            listTaiKhoan = new List<taikhoan>();
           // listTaiKhoan.Add(new taikhoan("",""));
            listTaiKhoan.Add(new taikhoan("admin", "admin"));
            listTaiKhoan.Add(new taikhoan("123", "123"));
        }
    }
}
