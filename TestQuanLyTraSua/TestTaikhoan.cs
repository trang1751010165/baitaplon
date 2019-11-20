using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLiQuanTraSua;

namespace TestQuanLyTraSua
{
    [TestClass]
    public class TestTaikhoan
    {
        [TestMethod]
        public void TestThemTaiKhoan()
        {
            DBConection cn = new DBConection();
            fAdmin fa = new fAdmin();

            DataTable dt = fa.GetDataSetTaiKhoan();

            int count = dt.Rows.Count;
            string tendn = "153";
            string tenhienthi = "abc";

            string chucdanh = "Staff";
            string matkhau = "2000";
           
            fa.themtk(tendn, tenhienthi, chucdanh, matkhau);

            dt = fa.GetDataSetTaiKhoan();

            int newCount = dt.Rows.Count;
            Assert.AreEqual(count + 1, newCount);



            foreach (DataRow dr in dt.Rows)
            {
                if (dr["TenDangNhap"].ToString() == tendn)
                {
                    Assert.AreEqual(tenhienthi, dr["TenHienThi"].ToString());
                    Assert.AreEqual(matkhau, dr["MatKhau"].ToString());
                    Assert.AreEqual(chucdanh, dr["ChucDanh"].ToString());
                
                }


            }
        }

        [TestMethod]
        public void TestXoaTaiKhoan()
        {

            DBConection cn = new DBConection();
            fAdmin fa = new fAdmin();

            DataTable dt = fa.GetDataSetTaiKhoan();

            int count = dt.Rows.Count;
            string tendn = "NguyenNi110";



            fa.xoatk(tendn);

            dt = fa.GetDataSetTaiKhoan();

            int newCount = dt.Rows.Count;
            Assert.AreEqual(count -1, newCount);



            foreach (DataRow dr in dt.Rows)
            {
                 
                Assert.AreNotEqual(tendn, dr["TenDangNhap"].ToString());


            }
        }

        [TestMethod]
        public void TestSuaTK()
        {
            DBConection cn = new DBConection();
            fAdmin fa = new fAdmin();

            DataTable dt = fa.GetDataSetTaiKhoan();

            int count = dt.Rows.Count;
            string tendn = "NguyenNi4567";
            string tenhienthi = "NiNguyen";
            string matkhau = "145";
            string chucdanh = "admin";


            fa.suatk(tendn, tenhienthi, matkhau, chucdanh);

            dt = fa.GetDataSetTaiKhoan();

            int newCount = dt.Rows.Count;
            Assert.AreEqual(count , newCount);



            foreach (DataRow dr in dt.Rows)
            {
                if(dr["TenDAngNhap"].ToString() == tendn)
                {
                    Assert.AreEqual(tenhienthi, dr["TenHienTHi"].ToString());
                    Assert.AreEqual(matkhau, dr["MatKhau"].ToString());
                    Assert.AreEqual(chucdanh, dr["ChucDanh"].ToString());
                }

              

            }
        }
    }
}
