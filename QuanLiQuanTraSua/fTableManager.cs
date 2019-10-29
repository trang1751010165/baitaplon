using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanTraSua
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            //loadTable();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAcountProfile f = new fAcountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }
        //private void loadTable()
        //{
        //    Button btn = new Button();
        //    btn.Text = "bàn";
        //    btn.AutoSize = true;
        //    flowLayoutPanel1.Controls.Add(btn);
        //}
    }
}
