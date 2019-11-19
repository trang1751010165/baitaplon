
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
    public partial class fAdmin : Form
    {
        DBConection _dbConnection = new DBConection();
        
        
       
        DataSet ds;
        
        DataTable Order;       
        public fAdmin()
        {
            InitializeComponent();

            
        }
        
        private void GetDataSetSP()
        {
            try
            {
                
                string sql = @"SELECT * FROM SanPham";
                
                
                DataTable spTable = _dbConnection.Getdata(sql);
                
                dgvsanpham.DataSource = spTable;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void GetDataToComboboxLoaiSP()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT * FROM LoaiSanPham";
                dt = _dbConnection.Getdata(sql);
                cmbLoaiSP.DataSource = dt;
                cmbLoaiSP.DisplayMember = "TenLoaiSP";
                cmbLoaiSP.ValueMember = "MaLoaiSP";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }       
        private void btnthemsp_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                string masp = txtmasp.Text;
                string tensp = txttensp.Text;
                string maloaisp = cmbLoaiSP.SelectedValue.ToString();
                string dongia = txtdongia.Text;
                string soluong = txtsoluong.Text;
                
                string sql = $" INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoaiSP], [DonGia], [SoLuong]) VALUES (N'{masp}   ', N'{tensp}', N'{maloaisp} ', {dongia}, {soluong})";

                bool isSuccess = _dbConnection.execData(sql);
                    if(isSuccess)
                {
                    GetDataSetSP();
                }
                    else
                {
                    MessageBox.Show("Không thể thêm Sản Phẩm vào cơ sở dữ liệu!", "Thông Báo");
                }
                
               

            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể thêm Sản Phẩm vào cơ sở dữ liệu!", "Thông Báo");

            }
            
        }
        private void btnxoasp_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvsanpham.Rows.Count > 0)
                {
                    int index = dgvsanpham.CurrentRow.Index;
                    DataGridViewRow cr = dgvsanpham.Rows[index];
                    string masp = txtmasp.Text;
                    string sql = $"delete from [QuanLiQuanTraSua].[dbo].[SanPham] where MaSP = N'{masp}'";
                    bool isSuccess = _dbConnection.execData(sql);
                    if (isSuccess)
                    {
                        dgvsanpham.Rows.Remove(cr);
                        GetDataSetSP();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoa Sản Phẩm vào cơ sở dữ liệu!", "Thông Báo");
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể xóa dữ liệu!", "Thông Báo");

            }

        }
        private void btnsuasp_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (dgvsanpham.Rows.Count > 0)
            //    {
            //        Order = ds.Tables[0];
            //        int index = dgvsanpham.CurrentRow.Index;
            //        DataRow dr = Order.Rows[index];// du lieu dong  =  gia tri dong hien tai
            //        dr.BeginEdit();// bat dau sua
            //        dr["TenSP"] = txttensp.Text;
            //        dr["MaLoaiSP"] = cmbLoaiSP.SelectedValue;
            //        dr["DonGia"] = txtdongia.Text;
            //        dr["SoLuong"] = txtsoluong.Text;
            //        dr.EndEdit();// ket thuc sua
            //    }
            //}
            //catch (SqlException)
            //{
            //    MessageBox.Show("Không thể sửa dữ liệu!", "Thông Báo");

            //}
            string masp = txtmasp.Text;
            string tensp = txttensp.Text;
            string maloaisp = cmbLoaiSP.SelectedValue.ToString();
            string dongia = txtdongia.Text;
            string soluong = txtsoluong.Text;

            string sql = $" Update [dbo].[SanPham] ([MaSP], [TenSP], [MaLoaiSP], [DonGia], [SoLuong]) VALUES (N'{masp}   ', N'{tensp}', N'{maloaisp} ', {dongia}, {soluong})";

        }
       

        private void dgvsanpham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvsanpham.CurrentRow != null)
            {
                txtmasp.Text = dgvsanpham.CurrentRow.Cells["MaSP"].Value.ToString();
                txttensp.Text = dgvsanpham.CurrentRow.Cells["TenSP"].Value.ToString();
                cmbLoaiSP.SelectedValue = dgvsanpham.CurrentRow.Cells["MaLoaiSP"].Value.ToString();
                txtdongia.Text = dgvsanpham.CurrentRow.Cells["DonGia"].Value.ToString();
                txtsoluong.Text = dgvsanpham.CurrentRow.Cells["SoLuong"].Value.ToString();
            }
        }
        //---------------TÀI KHOẢN--------------
        private void dgvtaikhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvtaikhoan.CurrentRow != null)
            {
                txtusername.Text = dgvtaikhoan.CurrentRow.Cells["TenDangNhap"].Value.ToString();
                txtdisplayName.Text = dgvtaikhoan.CurrentRow.Cells["TenHienthi"].Value.ToString();
                txtChucDanh.Text = dgvtaikhoan.CurrentRow.Cells["ChucDanh"].Value.ToString();
                txtMatKhau.Text = dgvtaikhoan.CurrentRow.Cells["MatKhau"].Value.ToString();
            }
        }
        private void GetDataSetTaiKhoan()
        {
            
            try
            {
                string sql = @"SELECT * FROM TaiKhoan";
                
                dgvtaikhoan.DataSource = ds.Tables[0];

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount();
            this.Hide();
            f.ShowDialog();
        }

        private void dgvtaikhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvtaikhoan.Columns[e.ColumnIndex].Index == 2 && e.Value != null)
            {
                dgvtaikhoan.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
        private void btnluutk_Click(object sender, EventArgs e)
        {
            
        }

        private void btnhuytk_Click(object sender, EventArgs e)
        {
            ds.Tables[0].RejectChanges();
        }
        private void btnsuatk_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgvtaikhoan.Rows.Count > 0)
                {
                    Order = ds.Tables[0];
                    int index = dgvtaikhoan.CurrentRow.Index;
                    DataRow dr = Order.Rows[index];// du lieu dong  =  gia tri dong hien tai
                    dr.BeginEdit();// bat dau sua
                    dr["TenDangNhap"] = txtusername.Text;
                    dr["TenHienThi"] = txtdisplayName.Text;
                    dr["MatKhau"] = txtMatKhau.Text;
                    dr["ChucDanh"] = txtChucDanh.Text;
                    dr.EndEdit();// ket thuc sua
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể sửa dữ liệu!", "Thông Báo");

            }
            
        }
        private void btnthemtk_Click(object sender, EventArgs e)
        {
            
            try
            {
                //string them;
                //them = "INSERT [dbo].[TaiKhoan] VALUES (N'"+txtusername+"', N'"+txtdisplayName+"', N'"+txtMatKhau+"', N'"+txtChucDanh+"')";
                //SqlCommand commandthem = new SqlCommand(them, cnn);
                //commandthem.ExecuteNonQuery();
                //string sql = @"SELECT * FROM SanPham";
                //da = new SqlDataAdapter(sql, cnn);
                //cb = new SqlCommandBuilder(da);
                //ds = new DataSet();
                //DataTable table = new DataTable();
                //da.Fill(table);
                //dgvsanpham.DataSource = table;
                string sql = @"SELECT * FROM TaiKhoan";
                
                dgvtaikhoan.DataSource = ds.Tables[0];
                DataRow tt = ds.Tables[0].NewRow();
                tt["TenDangNhap"] = txtusername.Text;
                tt["TenHienThi"] = txtdisplayName.Text;
                tt["ChucDanh"] = txtChucDanh.Text;
                tt["MatKhau"] = txtMatKhau.Text;
                ds.Tables[0].Rows.Add(tt);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể thêm Tài Khoản vào cơ sở dữ liệu!", "Thông Báo");
            }
            
        }

        private void btnxoatk_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgvtaikhoan.Rows.Count > 0)
                {
                    int index = dgvtaikhoan.CurrentRow.Index;
                    DataGridViewRow dr = dgvtaikhoan.Rows[index];
                    dgvtaikhoan.Rows.Remove(dr);

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể xóa dữ liệu!", "Thông Báo");

            }
            

        }
        //----------------------LOẠI SẢN PHẨM--------------
        private void GetDataSetLoaiSP()
        {
            
            try
            {
                string sql = @"SELECT * FROM LoaiSanPham";
                
                ds = new DataSet();
                
                dgvLoaisp.DataSource = ds.Tables[0];

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void dgvLoaisp_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaisp.CurrentRow != null)
            {
                txtMaloaiSP.Text = dgvLoaisp.CurrentRow.Cells["MaLoaiSP"].Value.ToString();
                txtTenLoaisp.Text = dgvLoaisp.CurrentRow.Cells["TenLoaiSP"].Value.ToString();
            }
        }
        private void btnthemlsp_Click(object sender, EventArgs e)
        {
            
            try
            {
                string sql = @"SELECT * FROM LoaiSanPham";
                
                ds = new DataSet();
               
                dgvLoaisp.DataSource = ds.Tables[0];
                DataRow tt = ds.Tables[0].NewRow();
                tt["MaLoaiSP"] = txtMaloaiSP.Text;
                tt["TenLoaiSP"] = txtTenLoaisp.Text;
                ds.Tables[0].Rows.Add(tt);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể thêm Sản Phẩm vào cơ sở dữ liệu!", "Thông Báo");

            }
            
        }       
        private void btnxoalsp_Click(object sender, EventArgs e)
        {

            
            try
            {
                if (dgvsanpham.Rows.Count > 0)
                {
                    int index = dgvLoaisp.CurrentRow.Index;
                    DataGridViewRow cr = dgvLoaisp.Rows[index];
                    dgvLoaisp.Rows.Remove(cr);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể xóa dữ liệu!", "Thông Báo");

            }
            
        }

        private void btnsualsp_Click(object sender, EventArgs e)
        {

            
            try
            {
                if (dgvLoaisp.Rows.Count > 0)
                {
                    Order = ds.Tables[0];
                    int index = dgvLoaisp.CurrentRow.Index;
                    DataRow dr = Order.Rows[index];
                    dr.BeginEdit();
                    dr["TenLoaiSP"] = txtTenLoaisp.Text;
                    dr.EndEdit();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể sửa dữ liệu!", "Thông Báo");

            }
            
        }

        private void btnhuylsp_Click(object sender, EventArgs e)
        {
            ds.Tables[0].RejectChanges();
        }

        private void btnluulsp_Click(object sender, EventArgs e)
        {
            
        }
      
        private void fAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Bạn muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
              GetDataToComboboxLoaiSP();
              GetDataSetSP();
            //GetDataSetLoaiSP();
            //GetDataSetTaiKhoan();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabProduct")
            {
                GetDataToComboboxLoaiSP();
                GetDataSetSP();
            }
            else if (tabControl1.SelectedTab.Name == "tabTypeProduct")
            {
                GetDataSetLoaiSP();
            }
            else if (tabControl1.SelectedTab.Name == "tabAccount")
            {
                GetDataSetTaiKhoan();

            }
        }
    }
}
