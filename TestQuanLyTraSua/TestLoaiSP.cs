using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using QuanLiQuanTraSua;
using System.Data.SqlClient;
using System.Data;
using System.Text;


namespace TestQuanLyTraSua
{
    [TestClass]
    public class TestLoaiSP
    {
        [TestMethod]
        public void TestThemLSP()
        {
            DBConection cn = new DBConection();
            fAdmin fa = new fAdmin();

            DataTable dt = fa.GetDataSetLoaiSP();

            int count = dt.Rows.Count;

            string Mamoi = "new11";
            string Tenmoi = "newname";

            fa.themlsp(Mamoi, Tenmoi);

            dt = fa.GetDataSetLoaiSP();

            int newCount = dt.Rows.Count;
            Assert.AreEqual(count + 1, newCount);
            int index = 0;
            

            foreach(DataRow dr in dt.Rows)
            {
                if (dr["MaLoaiSP"].ToString() == Mamoi)
                {
                    Assert.AreEqual(Mamoi, dr["MaLoaiSP"].ToString());
                    Assert.AreEqual(Tenmoi, dr["TenLoaiSP"].ToString());
                }

                    
               
            }

            

            

           

        }

        [TestMethod]
        public void TestXoaLSP()
        {
            DBConection cn = new DBConection();
            fAdmin fa = new fAdmin();

            DataTable dt = fa.GetDataSetLoaiSP();

            int count = dt.Rows.Count;
            string malsp = "new";



            fa.xoalsp(malsp);

            dt = fa.GetDataSetLoaiSP();

            int newCount = dt.Rows.Count;
            Assert.AreEqual(count - 1, newCount);



            foreach (DataRow dr in dt.Rows)
            {

                Assert.AreNotEqual(malsp, dr["MALoaiSP"].ToString());


            }
        }

        [TestMethod]
        public void TestSuaLSP()
        {

            DBConection cn = new DBConection();
            fAdmin fa = new fAdmin();

            DataTable dt = fa.GetDataSetLoaiSP();

            int count = dt.Rows.Count;
            string malsp = "newco";
            string tenlsp = "nuocmia12";
           


            fa.sualsp(malsp, tenlsp);

            dt = fa.GetDataSetLoaiSP();

            int newCount = dt.Rows.Count;
            Assert.AreEqual(count, newCount);



            foreach (DataRow dr in dt.Rows)
            {
                if (dr["MALoaiSP"].ToString() == malsp)
                {
                    Assert.AreEqual(tenlsp, dr["TEnLoaiSP"].ToString());
                   
                }





            }
        }
    }
    }

