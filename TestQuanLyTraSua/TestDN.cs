using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLiQuanTraSua;

namespace TestQuanLyTraSua
{
    [TestClass]
    public class TestDN
    {
        [TestMethod]
        public void TestMethod1()
        {

            DBConection cn = new DBConection();
            fAdmin fa = new fAdmin();
            DataTable dt = fa.GetDataSetTaiKhoan();

            string tendangnhap = "Nguyenn1";
            string matkhau = "145";
            string chucdanh = "ADmin";
            kiemtradn_class kt = new kiemtradn_class();

            bool login_actual = kt.KiemTraDangNhap(tendangnhap, matkhau, chucdanh);
            bool login_expected = false;
            foreach (DataRow dr in dt.Rows)
            {
                string tendn = dr["TenDangNhap"].ToString().Trim();
                int iii = string.Compare(tendn, tendangnhap, true);
                if (iii==0)
                {
                    string pas = dr["MatKhau"].ToString().Trim();
                    string cd = dr["ChucDanh"].ToString().Trim();
                    int jjj = string.Compare(pas, matkhau, true);
                    int lll = string.Compare(cd, chucdanh, true);
                    if( jjj ==0 && lll == 0)
                    {
                        login_expected = true;
                        break;
                    }
                }
            }
            Assert.AreEqual(login_expected, login_actual);

        }
    }
}
