
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
    public partial class fManage : Form
    {
        SqlConnection cnn;
        SqlDataAdapter da, daa, adapter;
        string cnstr;
        DataSet ds, datasetmoi;
        
        SqlCommandBuilder cb;
        DataTable Order;
        
        public static string quyen;

        private void addminToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fManage_Load(object sender, EventArgs e)
        {
            if (string.Compare(quyen,"admin",true)==0)
            {
                addminToolStripMenuItem.Enabled = true;
            }
            GetDataToComboboxKhachHang();     
            GetDataToComboboxSanPham();
            GetDataToComboboxLoaiSP();
            Layhet();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }             
        public fManage()
        {
            InitializeComponent();
            cnstr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLiQuanTraSua;Integrated Security=True";
            cnn = new SqlConnection(cnstr);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DataSet GetDataSetSP(string sql)
        {
            try
            {
                daa = new SqlDataAdapter(sql, cnn);
                cb = new SqlCommandBuilder(daa);
                ds = new DataSet();
                daa.Fill(ds);
                return ds;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cnn.Close();
            }
        }
        private void GetDataToComboboxKhachHang()
        {
            cnn.Open();
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT * FROM KhachHang";
                da = new SqlDataAdapter(sql, cnn);
                ds = new DataSet();
                da.Fill(dt);
                cbMaKH.DataSource = dt;
                cbMaKH.DisplayMember = "MaKH";
                cbMaKH.ValueMember = "MaKH";
                txtTenKH.DataBindings.Add("Text", dt, "TenKH");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM SanPham WHERE ";
            if (radTheoMa.Checked == true)
                sql += "MaSP = N'" + txtTim.Text + "'";
            else if (radTheoTen.Checked == true)
                sql += "TenSP LIKE '%" + txtTim.Text + "%'";
            dgvTimSP.DataSource = GetDataSetSP(sql).Tables[0];
        }

        private void GetDataToComboboxSanPham()
        {
            try
            {
                DataTable dtt = new DataTable();
                string sql = @"SELECT * FROM SanPham";
                daa = new SqlDataAdapter(sql, cnn);
                ds = new DataSet();
                daa.Fill(dtt);
                cbMaSP.DataSource = dtt;
                cbMaSP.DisplayMember = "MaSP";
                cbMaSP.ValueMember = "MaSP";
                txtTenSP.DataBindings.Add("Text", dtt, "TenSP");               
                txtDonGia.DataBindings.Add("Text", dtt, "DonGia");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Mã HĐ rỗng. Vui lòng nhập dữ liệu");
                return;
            }

            ThanhTien();
            cnn.Open();

            try
            {
                
                DataRow tt = datasetmoi.Tables[0].NewRow();

                tt["MaHD"] = txtMaHD.Text;
                tt["MaKH"] = cbMaKH.SelectedValue;             
                tt["GiaTriHD"] = float.Parse(txtTongTien.Text);              
                tt["MaSP"] = cbMaSP.SelectedValue;
                tt["SoLuong"] = int.Parse(txtSoLuong.Text);
                tt["DonGia"] = txtDonGia.Text;              
                datasetmoi.Tables[0].Rows.Add(tt);


            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể thêm thông tin vào hóa đơn vào cơ sở dữ liệu!", "Thông Báo");

            }
            finally
            {
                cnn.Close();
            }
        }
        private void LuuHD()
        {
            cnn.Open();
            try
            {
                string sql = @"SELECT * FROM HoaDon ";

                da = new SqlDataAdapter(sql, cnn);

                ds = new DataSet();
                da.Fill(ds);

                DataRow tt = ds.Tables[0].NewRow();

                tt["MaHD"] = txtMaHD.Text;
                tt["MaKH"] = cbMaKH.SelectedValue;
                tt["GiaTriHD"] = float.Parse(txtTongTien.Text);
                ds.Tables[0].Rows.Add(tt);
                cb = new SqlCommandBuilder(da);
                da.Update(ds);
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Không thể lưu hóa đơn");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
            finally
            {
                cnn.Close();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTienKhachTra.Text == "")
                {
                    float tongtin = float.Parse(txtTongTien.Text);
                    txtTienKhachTra.Text = tongtin.ToString();
                }
                float tienkhachtra = float.Parse(txtTienKhachTra.Text);
                float tongtien2 = float.Parse(txtTongTien.Text);
                float tientrakhach = tienkhachtra - tongtien2;
                txtTienTraLai.Text = tientrakhach.ToString();
                int index =dgvHDChiTietHD.CurrentRow.Index;
                dgvHDChiTietHD.Rows.RemoveAt(index);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       

        

        private void dgvHDChiTietHD_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHDChiTietHD.CurrentRow != null)
            {
                txtThanhTien.Text = dgvHDChiTietHD.CurrentRow.Cells[2].Value.ToString();
                txtTongTien.Text = dgvHDChiTietHD.CurrentRow.Cells[2].Value.ToString();
                
            }
        }

        private void GetDataToComboboxLoaiSP()
        {
            try
            {
                DataTable dtt = new DataTable();
                string sql = @"SELECT * FROM LoaiSanPham";
                daa = new SqlDataAdapter(sql, cnn);              
                ds = new DataSet();
                daa.Fill(dtt);
                cbMaLoaiSP.DataSource = dtt;
                cbMaLoaiSP.DisplayMember = "MaLoaiSP";
                cbMaLoaiSP.ValueMember = "MaLoaiSP";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        private void ThanhTien()
        {
            float dongia = float.Parse(txtDonGia.Text);
            int soluong = int.Parse(txtSoLuong.Text);
            float thanhtien = (dongia * soluong);
            txtThanhTien.Text = thanhtien.ToString();
            float tongtien = thanhtien;
            txtTongTien.Text = tongtien.ToString();
        }
        private void Layhet()
        {
            cnn.Open();
            try
            {
                string sql = @"SELECT * FROM HoaDon , ChiTietHoaDon WHERE HoaDon.MaHD = ChiTietHoaDon.MaHD ";

                adapter = new SqlDataAdapter(sql, cnn);
                cb = new SqlCommandBuilder(adapter);
                datasetmoi = new DataSet();
                adapter.Fill(datasetmoi);
                dgvHDChiTietHD.DataSource = datasetmoi.Tables[0];
                Order = datasetmoi.Tables[0];

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

    }
}
