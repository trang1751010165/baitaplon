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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fTableManager f = new fTableManager();
                    this.Hide();
                   f.ShowDialog();
                  this.Show();
            //    string userName = textBox1.Text;
            //    string passWord = textBox2.Text;
            //    if (Login(userName, passWord))
            //    {
            //        fTableManager f = new fTableManager();
            //        this.Hide();
            //        f.ShowDialog();
            //        this.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            //    }
        }
        //bool Login(String userName, string passWord)
        //{
        //    return false;
        //}


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?","thông báo",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
