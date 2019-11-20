using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanTraSua
{
    public class kiemtradn_class
    {
        DBConection cnd;
        public Boolean KiemTraDangNhap(string ten, string pas, string cd)
        {
            cnd = new DBConection();
            DataTable dt = cnd.Getdata("select * from dbo.TaiKhoan tk where tk.TenDangNhap = N'" + ten + "' and tk.MatKhau = N'" + pas + "'" + "and tk.ChucDanh = N'" + cd + "'");
            Boolean check = false;
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    check = true;

                }
                else
                {
                    check = false;
                }
            }
            return check;

        }
        public Boolean KiemTraDangNhap(string ten, string pas)
        {
            cnd = new DBConection();
            DataTable dt = cnd.Getdata("select * from dbo.TaiKhoan tk where tk.TenDangNhap = N'" + ten + "' and tk.MatKhau = N'" + pas + "'" );
            Boolean check = false;
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    check = true;

                }
                else
                {
                    check = false;
                }
            }
            return check;

        }
    }
}
