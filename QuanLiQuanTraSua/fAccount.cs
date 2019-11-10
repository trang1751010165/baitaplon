using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanTraSua
{
    public partial class fAccount : Form
    {
        string cnstr;
        SqlConnection cnn;
        public fAccount()
        {
            InitializeComponent();
            cnstr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLiQuanTraSua;Integrated Security=True";
            cnn = new SqlConnection(cnstr);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
            {
                MessageBox.Show("Mật khẩu mới không được để trống.\nVui lòng nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNewPass.Focus();
                return;
            }
            else if (txtNewPass.Text != txtAgainPass.Text)
            {
                MessageBox.Show("Vui lòng xác nhận lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAgainPass.Focus();
                return;
            }
            //

            kiemtradn_class kt = new kiemtradn_class();
            if (kt.KiemTraDangNhap(txtUser.Text, txtPass.Text))
            {
                try
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("ChangePass", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@UserName"].Value = txtUser.Text;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@Password"].Value = txtPass.Text;
                    cmd.Parameters.Add("@NewPassword", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@NewPassword"].Value = txtNewPass.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cnn.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không hợp lệ. Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
