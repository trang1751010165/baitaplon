
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
using System.Configuration;


namespace QuanLiQuanTraSua
{
    public partial class fLogin : Form
    {

        
     
       
        public fLogin()
        {           
            InitializeComponent();
        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;

            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
           
            
            cbChucDanh.Items.Add("admin");
            cbChucDanh.Items.Add("staff");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            string ten = txtUserName.Text;
            string pas = txtPassWord.Text;
            string chu = cbChucDanh.Text;
            
            try
            {
                kiemtradn_class kt = new kiemtradn_class();

                if (kt.KiemTraDangNhap(ten, pas, chu) == true)
                {
                    fManage f = new fManage();                   
                    fManage.quyen = chu;
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }
    }
}
