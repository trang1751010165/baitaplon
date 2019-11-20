
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
       private  DBConection _dbConnection = new DBConection();     
        public fAdmin()
        {
            InitializeComponent();
            dgvLoaisp.DataSource = GetDataSetLoaiSP();
            dgvsanpham.DataSource = GetDataSetSP();
            dgvtaikhoan.DataSource = GetDataSetTaiKhoan();

        }
        public DataTable GetDataSetSP()
        {
            DataTable spTable; 
            try
            {
                
                string sql = @"SELECT * FROM SanPham";
                
                
                spTable = _dbConnection.Getdata(sql);

                return spTable;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
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
            string masp = txtmasp.Text;
            string tensp = txttensp.Text;
            string maloaisp = cmbLoaiSP.SelectedValue.ToString();
            string dongia = txtdongia.Text;
            string soluong = txtsoluong.Text;


            themsp(masp, tensp, maloaisp, dongia, soluong);
        }
        public void themsp(string masp, string tensp, string maloaisp, string dongia, string soluong)
        {
            try
            {
                

                string sql = $" INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoaiSP], [DonGia], [SoLuong]) VALUES (N'{masp}   ', N'{tensp}', N'{maloaisp} ', {dongia}, {soluong})";

                bool isSuccess = _dbConnection.execData(sql);
                if (isSuccess)
                {
                    dgvsanpham.DataSource = GetDataSetSP();
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
          //  int index = dgvsanpham.CurrentRow.Index;
           // DataGridViewRow cr = dgvsanpham.Rows[index];
            string masp = txtmasp.Text;
            xoasp(masp);

        }
        public void xoasp(string masp)
        {
            try
            {
                if (dgvsanpham.Rows.Count > 0)
                {
                    
                    string sql = $"delete from [QuanLiQuanTraSua].[dbo].[SanPham] where MaSP = N'{masp}'";
                    bool isSuccess = _dbConnection.execData(sql);
                    if (isSuccess)
                    {
                      //  dgvsanpham.Rows.Remove(cr);
                        dgvsanpham.DataSource = GetDataSetSP();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoa Sản Phẩm khỏi cơ sở dữ liệu!", "Thông Báo");
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
           
            string masp = txtmasp.Text;
            string tensp = txttensp.Text;
            string maloaisp = cmbLoaiSP.SelectedValue.ToString();
            string dongia = txtdongia.Text;
            string soluong = txtsoluong.Text;

            suasp(masp, tensp, maloaisp, dongia, soluong);

            
        }
       public void suasp(string masp, string tensp, string maloaisp, string dongia, string soluong)
        {
            string sql = $" Update SanPham SET  TenSP =N' {tensp} ', MaLoaiSP =N'{maloaisp} ', DonGia =N'{dongia} ', SoLuong =N'{soluong} ' where MaSP =N'{masp} '";
            bool isSuccess = _dbConnection.execData(sql);
            if (isSuccess)
            {
                dgvsanpham.DataSource = GetDataSetSP();
            }
            else
            {
                MessageBox.Show("Không thể sửa Sản Phẩm trong cơ sở dữ liệu!", "Thông Báo");
            }
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
        public DataTable GetDataSetTaiKhoan()
        {
            DataTable spTable; 

            try
            {
                string sql = @"SELECT * FROM TaiKhoan";

                spTable = _dbConnection.Getdata(sql);


                return spTable;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
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
        

        
        private void btnsuatk_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtusername.Text;
            string tenhienthi = txtdisplayName.Text;
            string matkhau = txtMatKhau.Text;
            string chucdanh = txtChucDanh.Text;

            suatk(tendangnhap, tenhienthi, matkhau, chucdanh);
           
        }
        public void suatk(string tendangnhap, string tenhienthi, string matkhau, string chucdanh)
        {
            string sql = $" Update TaiKhoan SET   TenHienThi=N'{tenhienthi}', MatKhau =N'{matkhau}', ChucDanh =N'{chucdanh}'  where TenDangNhap =N'{tendangnhap}'";
            bool isSuccess = _dbConnection.execData(sql);
            if (isSuccess)
            {
                dgvtaikhoan.DataSource = GetDataSetTaiKhoan();
            }
            else
            {
                MessageBox.Show("Không thể sửa tài khoản trong cơ sở dữ liệu!", "Thông Báo");
            }

        }
        private void btnthemtk_Click(object sender, EventArgs e)
        {

            string tendn = txtusername.Text;
            string tenhienthi = txtdisplayName.Text;
            string chucdanh = txtChucDanh.Text;
            string matkhau = txtMatKhau.Text;
            themtk(tendn, tenhienthi, chucdanh, matkhau);
        }
        public void themtk(string tendn, string tenhienthi, string chucdanh, string matkhau)
        {
            try
            {
               

                string sql = $"INSERT [dbo].[TaiKhoan] ([TenDangNhap], [TenHienThi], [MatKhau], [ChucDanh]) VALUES (N'{tendn}', N'{tenhienthi}', {matkhau} ,N'{chucdanh}')";

                bool isSuccess = _dbConnection.execData(sql);
                if (isSuccess)
                {
                    dgvtaikhoan.DataSource = GetDataSetTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Không thể thêm tài Khoản vào cơ sở dữ liệu!", "Thông Báo");
                }



            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể thêm Tài Khoản vào cơ sở dữ liệu!", "Thông Báo");

            }
        }

        private void btnxoatk_Click(object sender, EventArgs e)
        {

           // int index = dgvsanpham.CurrentRow.Index;
           // DataGridViewRow cr = dgvsanpham.Rows[index];
            string tendangnhap = txtusername.Text;
           
            xoatk(tendangnhap);

        }
        public void xoatk(string tendangnhap)
        {
            try
            {
                if (dgvsanpham.Rows.Count > 0)
                {
                   
                    string sql = $"delete from [QuanLiQuanTraSua].[dbo].[TaiKhoan] where TenDangNhap = N'{tendangnhap}' ";
                    bool isSuccess = _dbConnection.execData(sql);
                    if (isSuccess)
                    {
                        //dgvsanpham.Rows.Remove(cr);
                        dgvtaikhoan.DataSource = GetDataSetTaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa tài khoản khỏi cơ sở dữ liệu!", "Thông Báo");
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể xóa dữ liệu!", "Thông Báo");

            }
        }
        //----------------------LOẠI SẢN PHẨM--------------
        public  DataTable GetDataSetLoaiSP()
        {
            DataTable spTable;

            try
            {

                string sql = @"SELECT * FROM LoaiSanPham";


               
                spTable = _dbConnection.Getdata(sql);
                return spTable;



            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
       
        private void btnthemlsp_Click(object sender, EventArgs e)
        {
            string maloaisp = txtMaloaiSP.Text;
            string tenloaisp = txtTenLoaisp.Text;
            themlsp(maloaisp, tenloaisp);


        }      
        public void themlsp(string maloaisp, string tenloaisp)
        {
            try
            {
                


                string sql = $"INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'{maloaisp}   ', N'{tenloaisp}')";

                bool isSuccess = _dbConnection.execData(sql);
                if (isSuccess)
                {
                    dgvLoaisp.DataSource = GetDataSetLoaiSP();
                }
                else
                {
                    MessageBox.Show("Không thể thêm loai sp vào cơ sở dữ liệu!", "Thông Báo");
                }



            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể thêm loai sp vào cơ sở dữ liệu!", "Thông Báo");

            }
        }
        private void btnxoalsp_Click(object sender, EventArgs e)
        {
           // int index = dgvLoaisp.CurrentRow.Index;
           // DataGridViewRow cr = dgvLoaisp.Rows[index];
            string maloaisp = txtMaloaiSP.Text;
            xoalsp(maloaisp);


        }
        public void xoalsp(string maloaisp)
        {
            try
            {
                if (dgvLoaisp.Rows.Count > 0)
                {
                   

                    string sql = $"delete from [QuanLiQuanTraSua].[dbo].[LoaiSanPham] where MaLoaiSP = N'{maloaisp}' ";
                    bool isSuccess = _dbConnection.execData(sql);
                    if (isSuccess)
                    {
                       // dgvLoaisp.Rows.Remove(cr);
                        dgvLoaisp.DataSource = GetDataSetLoaiSP();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoa loại sản phẩm tu cơ sở dữ liệu!", "Thông Báo");
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể xóa dữ liệu!", "Thông Báo");

            }
        }

        private void btnsualsp_Click(object sender, EventArgs e)
        {


            string maloaisp = txtMaloaiSP.Text;
            string tenloaisp = txtTenLoaisp.Text;

            sualsp(maloaisp, tenloaisp);
          

        }
        public void sualsp(string maloaisp, string tenloaisp)
        {
            string sql = $" Update LoaiSanPham SET    TenLoaiSP =N'{tenloaisp}' where MALoaiSP =N'{maloaisp} '";
            bool isSuccess = _dbConnection.execData(sql);
            if (isSuccess)
            {
                dgvLoaisp.DataSource = GetDataSetLoaiSP();
            }
            else
            {
                MessageBox.Show("Không thể sửa loại sp từ cơ sở dữ liệu!", "Thông Báo");
            }
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
            dgvLoaisp.DataSource = GetDataSetLoaiSP();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabProduct")
            {
                GetDataToComboboxLoaiSP();
                dgvsanpham.DataSource = GetDataSetSP();
            }
            else if (tabControl1.SelectedTab.Name == "tabTypeProduct")
            {
                dgvLoaisp.DataSource = GetDataSetLoaiSP();
            }
            else if (tabControl1.SelectedTab.Name == "tabAccount")
            {
                dgvtaikhoan.DataSource = GetDataSetTaiKhoan();

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
    }
}
