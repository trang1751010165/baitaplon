using QuanLiQuanTraSua.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanTraSua
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }
        void LoadAccountList()
        {
            string query = "Exec dbo.usp_GetAcountByUserName @userName";
            DataProvider provider = new DataProvider();
            dataGridView2.DataSource = provider.ExecuteQuery(query,new object[] { "nguyentrang" });
        }
    }
}
