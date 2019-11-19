namespace QuanLiQuanTraSua
{
    partial class fAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.dgvsanpham = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsuasp = new System.Windows.Forms.Button();
            this.btnxoasp = new System.Windows.Forms.Button();
            this.btnthemsp = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbLoaiSP = new System.Windows.Forms.ComboBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabTypeProduct = new System.Windows.Forms.TabPage();
            this.btnluulsp = new System.Windows.Forms.Button();
            this.btnhuylsp = new System.Windows.Forms.Button();
            this.btnsualsp = new System.Windows.Forms.Button();
            this.btnxoalsp = new System.Windows.Forms.Button();
            this.btnthemlsp = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.txtTenLoaisp = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvLoaisp = new System.Windows.Forms.DataGridView();
            this.panel19 = new System.Windows.Forms.Panel();
            this.txtMaloaiSP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txtChucDanh = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.txtdisplayName = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnhuytk = new System.Windows.Forms.Button();
            this.btnluutk = new System.Windows.Forms.Button();
            this.btnsuatk = new System.Windows.Forms.Button();
            this.btnxoatk = new System.Windows.Forms.Button();
            this.btnthemtk = new System.Windows.Forms.Button();
            this.dgvtaikhoan = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.tabTypeProduct.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaisp)).BeginInit();
            this.panel19.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Controls.Add(this.tabTypeProduct);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.Location = new System.Drawing.Point(5, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 513);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.dgvsanpham);
            this.tabProduct.Controls.Add(this.panel9);
            this.tabProduct.Location = new System.Drawing.Point(4, 22);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(696, 487);
            this.tabProduct.TabIndex = 1;
            this.tabProduct.Text = "Thực phẩm ";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // dgvsanpham
            // 
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsanpham.Location = new System.Drawing.Point(7, 317);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.Size = new System.Drawing.Size(682, 167);
            this.dgvsanpham.TabIndex = 2;
            this.dgvsanpham.SelectionChanged += new System.EventHandler(this.dgvsanpham_SelectionChanged);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.btnsuasp);
            this.panel9.Controls.Add(this.btnxoasp);
            this.panel9.Controls.Add(this.btnthemsp);
            this.panel9.Controls.Add(this.panel13);
            this.panel9.Controls.Add(this.panel14);
            this.panel9.Controls.Add(this.panel16);
            this.panel9.Controls.Add(this.panel17);
            this.panel9.Controls.Add(this.panel18);
            this.panel9.Location = new System.Drawing.Point(7, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(679, 310);
            this.panel9.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(204, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "THÔNG TIN SẢN PHẨM";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnsuasp
            // 
            this.btnsuasp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuasp.Location = new System.Drawing.Point(545, 206);
            this.btnsuasp.Name = "btnsuasp";
            this.btnsuasp.Size = new System.Drawing.Size(75, 36);
            this.btnsuasp.TabIndex = 8;
            this.btnsuasp.Text = "Sửa";
            this.btnsuasp.UseVisualStyleBackColor = true;
            this.btnsuasp.Click += new System.EventHandler(this.btnsuasp_Click);
            // 
            // btnxoasp
            // 
            this.btnxoasp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoasp.Location = new System.Drawing.Point(545, 144);
            this.btnxoasp.Name = "btnxoasp";
            this.btnxoasp.Size = new System.Drawing.Size(75, 36);
            this.btnxoasp.TabIndex = 7;
            this.btnxoasp.Text = "Xóa";
            this.btnxoasp.UseVisualStyleBackColor = true;
            this.btnxoasp.Click += new System.EventHandler(this.btnxoasp_Click);
            // 
            // btnthemsp
            // 
            this.btnthemsp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemsp.Location = new System.Drawing.Point(545, 70);
            this.btnthemsp.Name = "btnthemsp";
            this.btnthemsp.Size = new System.Drawing.Size(75, 36);
            this.btnthemsp.TabIndex = 6;
            this.btnthemsp.Text = "Thêm";
            this.btnthemsp.UseVisualStyleBackColor = true;
            this.btnthemsp.Click += new System.EventHandler(this.btnthemsp_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.txtsoluong);
            this.panel13.Controls.Add(this.label10);
            this.panel13.Location = new System.Drawing.Point(26, 226);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(466, 37);
            this.panel13.TabIndex = 5;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(157, 0);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(306, 26);
            this.txtsoluong.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số Lượng";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txtdongia);
            this.panel14.Controls.Add(this.label11);
            this.panel14.Location = new System.Drawing.Point(24, 183);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(466, 37);
            this.panel14.TabIndex = 4;
            // 
            // txtdongia
            // 
            this.txtdongia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdongia.Location = new System.Drawing.Point(157, 3);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(306, 26);
            this.txtdongia.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Đơn Giá";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.label13);
            this.panel16.Controls.Add(this.cmbLoaiSP);
            this.panel16.Location = new System.Drawing.Point(24, 138);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(468, 37);
            this.panel16.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã Loại SP";
            // 
            // cmbLoaiSP
            // 
            this.cmbLoaiSP.FormattingEnabled = true;
            this.cmbLoaiSP.Location = new System.Drawing.Point(157, 6);
            this.cmbLoaiSP.Name = "cmbLoaiSP";
            this.cmbLoaiSP.Size = new System.Drawing.Size(306, 21);
            this.cmbLoaiSP.TabIndex = 16;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txttensp);
            this.panel17.Controls.Add(this.label14);
            this.panel17.Location = new System.Drawing.Point(24, 99);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(466, 37);
            this.panel17.TabIndex = 1;
            // 
            // txttensp
            // 
            this.txttensp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttensp.Location = new System.Drawing.Point(157, 5);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(306, 26);
            this.txttensp.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(31, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tên SP";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.txtmasp);
            this.panel18.Controls.Add(this.label15);
            this.panel18.Location = new System.Drawing.Point(24, 60);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(466, 37);
            this.panel18.TabIndex = 0;
            // 
            // txtmasp
            // 
            this.txtmasp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmasp.Location = new System.Drawing.Point(157, 6);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(306, 26);
            this.txtmasp.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(31, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Mã SP";
            // 
            // tabTypeProduct
            // 
            this.tabTypeProduct.Controls.Add(this.btnluulsp);
            this.tabTypeProduct.Controls.Add(this.btnhuylsp);
            this.tabTypeProduct.Controls.Add(this.btnsualsp);
            this.tabTypeProduct.Controls.Add(this.btnxoalsp);
            this.tabTypeProduct.Controls.Add(this.btnthemlsp);
            this.tabTypeProduct.Controls.Add(this.panel20);
            this.tabTypeProduct.Controls.Add(this.dgvLoaisp);
            this.tabTypeProduct.Controls.Add(this.panel19);
            this.tabTypeProduct.Controls.Add(this.label17);
            this.tabTypeProduct.Location = new System.Drawing.Point(4, 22);
            this.tabTypeProduct.Name = "tabTypeProduct";
            this.tabTypeProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabTypeProduct.Size = new System.Drawing.Size(696, 487);
            this.tabTypeProduct.TabIndex = 2;
            this.tabTypeProduct.Text = "Loại thực phẩm";
            this.tabTypeProduct.UseVisualStyleBackColor = true;
            // 
            // btnluulsp
            // 
            this.btnluulsp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluulsp.Location = new System.Drawing.Point(567, 109);
            this.btnluulsp.Name = "btnluulsp";
            this.btnluulsp.Size = new System.Drawing.Size(75, 36);
            this.btnluulsp.TabIndex = 20;
            this.btnluulsp.Text = "Lưu";
            this.btnluulsp.UseVisualStyleBackColor = true;
            this.btnluulsp.Click += new System.EventHandler(this.btnluulsp_Click);
            // 
            // btnhuylsp
            // 
            this.btnhuylsp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuylsp.Location = new System.Drawing.Point(521, 227);
            this.btnhuylsp.Name = "btnhuylsp";
            this.btnhuylsp.Size = new System.Drawing.Size(75, 36);
            this.btnhuylsp.TabIndex = 19;
            this.btnhuylsp.Text = "Hủy";
            this.btnhuylsp.UseVisualStyleBackColor = true;
            this.btnhuylsp.Click += new System.EventHandler(this.btnhuylsp_Click);
            // 
            // btnsualsp
            // 
            this.btnsualsp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsualsp.Location = new System.Drawing.Point(378, 227);
            this.btnsualsp.Name = "btnsualsp";
            this.btnsualsp.Size = new System.Drawing.Size(75, 36);
            this.btnsualsp.TabIndex = 18;
            this.btnsualsp.Text = "Sửa";
            this.btnsualsp.UseVisualStyleBackColor = true;
            this.btnsualsp.Click += new System.EventHandler(this.btnsualsp_Click);
            // 
            // btnxoalsp
            // 
            this.btnxoalsp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoalsp.Location = new System.Drawing.Point(248, 227);
            this.btnxoalsp.Name = "btnxoalsp";
            this.btnxoalsp.Size = new System.Drawing.Size(75, 36);
            this.btnxoalsp.TabIndex = 17;
            this.btnxoalsp.Text = "Xóa";
            this.btnxoalsp.UseVisualStyleBackColor = true;
            this.btnxoalsp.Click += new System.EventHandler(this.btnxoalsp_Click);
            // 
            // btnthemlsp
            // 
            this.btnthemlsp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemlsp.Location = new System.Drawing.Point(126, 227);
            this.btnthemlsp.Name = "btnthemlsp";
            this.btnthemlsp.Size = new System.Drawing.Size(75, 36);
            this.btnthemlsp.TabIndex = 16;
            this.btnthemlsp.Text = "Thêm";
            this.btnthemlsp.UseVisualStyleBackColor = true;
            this.btnthemlsp.Click += new System.EventHandler(this.btnthemlsp_Click);
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.txtTenLoaisp);
            this.panel20.Controls.Add(this.label18);
            this.panel20.Location = new System.Drawing.Point(72, 132);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(466, 37);
            this.panel20.TabIndex = 15;
            // 
            // txtTenLoaisp
            // 
            this.txtTenLoaisp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaisp.Location = new System.Drawing.Point(145, 7);
            this.txtTenLoaisp.Name = "txtTenLoaisp";
            this.txtTenLoaisp.Size = new System.Drawing.Size(306, 26);
            this.txtTenLoaisp.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(24, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 19);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tên Loại SP";
            // 
            // dgvLoaisp
            // 
            this.dgvLoaisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaisp.Location = new System.Drawing.Point(6, 310);
            this.dgvLoaisp.Name = "dgvLoaisp";
            this.dgvLoaisp.Size = new System.Drawing.Size(682, 171);
            this.dgvLoaisp.TabIndex = 14;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.txtMaloaiSP);
            this.panel19.Controls.Add(this.label16);
            this.panel19.Location = new System.Drawing.Point(72, 60);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(466, 37);
            this.panel19.TabIndex = 13;
            // 
            // txtMaloaiSP
            // 
            this.txtMaloaiSP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaloaiSP.Location = new System.Drawing.Point(145, 7);
            this.txtMaloaiSP.Name = "txtMaloaiSP";
            this.txtMaloaiSP.Size = new System.Drawing.Size(306, 26);
            this.txtMaloaiSP.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(31, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "Mã Loại  SP";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(216, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(270, 22);
            this.label17.TabIndex = 12;
            this.label17.Text = "THÔNG TIN LOẠI SẢN PHẨM";
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.btnResetPass);
            this.tabAccount.Controls.Add(this.panel26);
            this.tabAccount.Controls.Add(this.panel25);
            this.tabAccount.Controls.Add(this.panel23);
            this.tabAccount.Controls.Add(this.panel24);
            this.tabAccount.Controls.Add(this.btnhuytk);
            this.tabAccount.Controls.Add(this.btnluutk);
            this.tabAccount.Controls.Add(this.btnsuatk);
            this.tabAccount.Controls.Add(this.btnxoatk);
            this.tabAccount.Controls.Add(this.btnthemtk);
            this.tabAccount.Controls.Add(this.dgvtaikhoan);
            this.tabAccount.Controls.Add(this.label19);
            this.tabAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(696, 487);
            this.tabAccount.TabIndex = 3;
            this.tabAccount.Text = "Tài khoản ";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // btnResetPass
            // 
            this.btnResetPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetPass.AutoEllipsis = true;
            this.btnResetPass.BackColor = System.Drawing.Color.Blue;
            this.btnResetPass.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPass.ForeColor = System.Drawing.Color.White;
            this.btnResetPass.Location = new System.Drawing.Point(522, 135);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(119, 71);
            this.btnResetPass.TabIndex = 19;
            this.btnResetPass.Text = "Đặt Lại Mật Khẩu";
            this.btnResetPass.UseVisualStyleBackColor = false;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txtChucDanh);
            this.panel26.Controls.Add(this.label22);
            this.panel26.Location = new System.Drawing.Point(90, 238);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(396, 37);
            this.panel26.TabIndex = 18;
            // 
            // txtChucDanh
            // 
            this.txtChucDanh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucDanh.Location = new System.Drawing.Point(152, 6);
            this.txtChucDanh.Name = "txtChucDanh";
            this.txtChucDanh.Size = new System.Drawing.Size(241, 26);
            this.txtChucDanh.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 19);
            this.label22.TabIndex = 0;
            this.label22.Text = "Chức Danh:";
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.txtdisplayName);
            this.panel25.Controls.Add(this.label21);
            this.panel25.Location = new System.Drawing.Point(90, 152);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(396, 37);
            this.panel25.TabIndex = 17;
            // 
            // txtdisplayName
            // 
            this.txtdisplayName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisplayName.Location = new System.Drawing.Point(152, 11);
            this.txtdisplayName.Name = "txtdisplayName";
            this.txtdisplayName.Size = new System.Drawing.Size(241, 26);
            this.txtdisplayName.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(0, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 19);
            this.label21.TabIndex = 0;
            this.label21.Text = "Tên Hiển Thị:";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.txtMatKhau);
            this.panel23.Controls.Add(this.label32);
            this.panel23.Location = new System.Drawing.Point(90, 195);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(396, 37);
            this.panel23.TabIndex = 15;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(152, 6);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(241, 26);
            this.txtMatKhau.TabIndex = 0;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(3, 9);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(87, 19);
            this.label32.TabIndex = 0;
            this.label32.Text = "Mật Khẩu:";
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.txtusername);
            this.panel24.Controls.Add(this.label20);
            this.panel24.Location = new System.Drawing.Point(90, 109);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(396, 37);
            this.panel24.TabIndex = 16;
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(152, 6);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(241, 26);
            this.txtusername.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(134, 19);
            this.label20.TabIndex = 0;
            this.label20.Text = "Tên Đăng Nhập:";
            // 
            // btnhuytk
            // 
            this.btnhuytk.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuytk.Location = new System.Drawing.Point(584, 49);
            this.btnhuytk.Name = "btnhuytk";
            this.btnhuytk.Size = new System.Drawing.Size(75, 36);
            this.btnhuytk.TabIndex = 14;
            this.btnhuytk.Text = "Hủy";
            this.btnhuytk.UseVisualStyleBackColor = true;
            this.btnhuytk.Click += new System.EventHandler(this.btnhuytk_Click);
            // 
            // btnluutk
            // 
            this.btnluutk.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluutk.Location = new System.Drawing.Point(450, 49);
            this.btnluutk.Name = "btnluutk";
            this.btnluutk.Size = new System.Drawing.Size(75, 36);
            this.btnluutk.TabIndex = 13;
            this.btnluutk.Text = "Lưu";
            this.btnluutk.UseVisualStyleBackColor = true;
            this.btnluutk.Click += new System.EventHandler(this.btnluutk_Click);
            // 
            // btnsuatk
            // 
            this.btnsuatk.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuatk.Location = new System.Drawing.Point(308, 49);
            this.btnsuatk.Name = "btnsuatk";
            this.btnsuatk.Size = new System.Drawing.Size(75, 36);
            this.btnsuatk.TabIndex = 12;
            this.btnsuatk.Text = "Sửa";
            this.btnsuatk.UseVisualStyleBackColor = true;
            this.btnsuatk.Click += new System.EventHandler(this.btnsuatk_Click);
            // 
            // btnxoatk
            // 
            this.btnxoatk.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoatk.Location = new System.Drawing.Point(170, 49);
            this.btnxoatk.Name = "btnxoatk";
            this.btnxoatk.Size = new System.Drawing.Size(75, 36);
            this.btnxoatk.TabIndex = 11;
            this.btnxoatk.Text = "Xóa";
            this.btnxoatk.UseVisualStyleBackColor = true;
            this.btnxoatk.Click += new System.EventHandler(this.btnxoatk_Click);
            // 
            // btnthemtk
            // 
            this.btnthemtk.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemtk.Location = new System.Drawing.Point(32, 49);
            this.btnthemtk.Name = "btnthemtk";
            this.btnthemtk.Size = new System.Drawing.Size(75, 36);
            this.btnthemtk.TabIndex = 10;
            this.btnthemtk.Text = "Thêm";
            this.btnthemtk.UseVisualStyleBackColor = true;
            this.btnthemtk.Click += new System.EventHandler(this.btnthemtk_Click);
            // 
            // dgvtaikhoan
            // 
            this.dgvtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtaikhoan.Location = new System.Drawing.Point(6, 305);
            this.dgvtaikhoan.Name = "dgvtaikhoan";
            this.dgvtaikhoan.Size = new System.Drawing.Size(679, 176);
            this.dgvtaikhoan.TabIndex = 3;
            this.dgvtaikhoan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvtaikhoan_CellFormatting);
            this.dgvtaikhoan.SelectionChanged += new System.EventHandler(this.dgvtaikhoan_SelectionChanged);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(211, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(224, 22);
            this.label19.TabIndex = 2;
            this.label19.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 522);
            this.Controls.Add(this.tabControl1);
            this.Name = "fAdmin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAdmin_FormClosing);
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.tabTypeProduct.ResumeLayout(false);
            this.tabTypeProduct.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaisp)).EndInit();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.DataGridView dgvsanpham;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsuasp;
        private System.Windows.Forms.Button btnxoasp;
        private System.Windows.Forms.Button btnthemsp;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbLoaiSP;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabTypeProduct;
        private System.Windows.Forms.Button btnluulsp;
        private System.Windows.Forms.Button btnhuylsp;
        private System.Windows.Forms.Button btnsualsp;
        private System.Windows.Forms.Button btnxoalsp;
        private System.Windows.Forms.Button btnthemlsp;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox txtTenLoaisp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvLoaisp;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TextBox txtMaloaiSP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox txtChucDanh;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TextBox txtdisplayName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnhuytk;
        private System.Windows.Forms.Button btnluutk;
        private System.Windows.Forms.Button btnsuatk;
        private System.Windows.Forms.Button btnxoatk;
        private System.Windows.Forms.Button btnthemtk;
        private System.Windows.Forms.DataGridView dgvtaikhoan;
        private System.Windows.Forms.Label label19;
    }
}