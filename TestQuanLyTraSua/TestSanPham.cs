using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLiQuanTraSua;

namespace TestQuanLyTraSua
{
    [TestClass]
    public class TestSanPham
    {
        [TestMethod]
        public void TestTThemSP()
        {

            DBConection cn = new DBConection();
            fAdmin fa = new fAdmin();

            DataTable dt = fa.GetDataSetSP();

            int count = dt.Rows.Count;
            string masp = "153";
            string tensp = "abc";

            string maloaisp = "DA2";
            string dongia = "2000";
            string soluong = "1";
            fa.themsp(masp, tensp, maloaisp, dongia, soluong);

            dt = fa.GetDataSetSP();

            int newCount = dt.Rows.Count;
            Assert.AreEqual(count + 1, newCount);



            foreach (DataRow dr in dt.Rows)
            {
                if (dr["MaSP"].ToString() == masp)
                {
                    Assert.AreEqual(masp, dr["MaSP"].ToString());
                    Assert.AreEqual(tensp, dr["TenSP"].ToString());
                    Assert.AreEqual(maloaisp, dr["MaLoaiSP"].ToString());
                    Assert.AreEqual(dongia, dr["Dongia"].ToString());
                    Assert.AreEqual(soluong, dr["SoLuong"].ToString());
                }


            }
        }

        [TestMethod]
        public void TestXoaSP()
        {
            DBConection cn = new DBConection();
            fAdmin fa = new fAdmin();

            DataTable dt = fa.GetDataSetSP();

            int count = dt.Rows.Count;
            string masp = "112";



            fa.xoasp(masp);

            dt = fa.GetDataSetSP();

            int newCount = dt.Rows.Count;
            Assert.AreEqual(count - 1, newCount);



            foreach (DataRow dr in dt.Rows)
            {

                Assert.AreNotEqual(masp, dr["MaSP"].ToString());


            }
        }

        [TestMethod]
        public void TestSuaSP()
        {
            DBConection cn = new DBConection();
            fAdmin fa = new fAdmin();

            DataTable dt = fa.GetDataSetSP();

            int count = dt.Rows.Count;
            string masp = "153";
            string tensp = "TRa";
            string dongia = "145";
            string soluong = "12";
            string malsp = "DA2";


            fa.suasp(masp, tensp, malsp, dongia, soluong);

            dt = fa.GetDataSetSP();

            int newCount = dt.Rows.Count;
            Assert.AreEqual(count, newCount);



            foreach (DataRow dr in dt.Rows)
            {
                if (dr["MASP"].ToString() == masp)
                {
                    Assert.AreEqual(tensp, dr["TEnSP"].ToString());
                    Assert.AreEqual(malsp, dr["MaLoaiSP"].ToString());
                    Assert.AreEqual(dongia, dr["DonGia"].ToString());
                    Assert.AreEqual(soluong, dr["SoLuong"].ToString());
                }





            }
        }

    }
}