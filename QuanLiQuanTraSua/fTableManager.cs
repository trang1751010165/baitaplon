using QuanLiQuanTraSua.DAO;
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
            LoadFood();
        }
        #region Method
        void LoadFood()
        {
            List<Food> foodlist = FoodDAO.Instance.LoadFoodList();
            foreach(Food item in foodlist)
            {
                Button btn = new Button() { Width = FoodDAO.FoodWidth, Height = FoodDAO.FoodHeight };
                flowLayoutPanel1.Controls.Add(btn);
                btn.Text = item.Name + Environment.NewLine + Environment.NewLine + item.Price;
                btn.BackColor = Color.DeepSkyBlue;
            }
        }
        #endregion
        #region Events

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
        #endregion
    }
}
