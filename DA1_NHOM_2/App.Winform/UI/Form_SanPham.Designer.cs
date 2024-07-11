namespace App.Winform.UI
{
    partial class Form_SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SanPham));
            pn_Form_SanPham = new Panel();
            groupBox3 = new GroupBox();
            dtgView = new DataGridView();
            grb_ChucNang = new GroupBox();
            pn_XuatExcel = new Panel();
            label12 = new Label();
            pictureBox5 = new PictureBox();
            pn_XoaSP = new Panel();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            pn_UpdateSP = new Panel();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            pn_ThemSP = new Panel();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            pn_LamMoi = new Panel();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            ptb_Anh = new PictureBox();
            txt_Search = new TextBox();
            rd_HetHang = new RadioButton();
            rd_ConHang = new RadioButton();
            label7 = new Label();
            txt_GiaBan = new TextBox();
            label6 = new Label();
            txt_GiaNhap = new TextBox();
            label5 = new Label();
            txt_ThongSoKyThuat = new TextBox();
            label4 = new Label();
            txt_HangSanPham = new TextBox();
            label3 = new Label();
            txt_TenSanPham = new TextBox();
            label2 = new Label();
            txt_MaSanPham = new TextBox();
            label1 = new Label();
            pn_Form_SanPham.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            grb_ChucNang.SuspendLayout();
            pn_XuatExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            pn_XoaSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pn_UpdateSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pn_ThemSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pn_LamMoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Anh).BeginInit();
            SuspendLayout();
            // 
            // pn_Form_SanPham
            // 
            pn_Form_SanPham.BackColor = Color.FromArgb(255, 192, 192);
            pn_Form_SanPham.Controls.Add(groupBox3);
            pn_Form_SanPham.Controls.Add(grb_ChucNang);
            pn_Form_SanPham.Controls.Add(groupBox1);
            pn_Form_SanPham.Location = new Point(269, 75);
            pn_Form_SanPham.Margin = new Padding(4, 4, 4, 4);
            pn_Form_SanPham.Name = "pn_Form_SanPham";
            pn_Form_SanPham.Size = new Size(2111, 1140);
            pn_Form_SanPham.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtgView);
            groupBox3.Location = new Point(4, 646);
            groupBox3.Margin = new Padding(4, 4, 4, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 4, 4, 4);
            groupBox3.Size = new Size(1946, 490);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm";
            // 
            // dtgView
            // 
            dtgView.BackgroundColor = Color.White;
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.GridColor = SystemColors.ActiveBorder;
            dtgView.Location = new Point(8, 32);
            dtgView.Margin = new Padding(4, 4, 4, 4);
            dtgView.Name = "dtgView";
            dtgView.ReadOnly = true;
            dtgView.RowHeadersWidth = 51;
            dtgView.RowTemplate.Height = 29;
            dtgView.Size = new Size(1931, 445);
            dtgView.TabIndex = 0;
            dtgView.CellClick += dtgView_CellClick;
            dtgView.CellFormatting += dtgView_CellFormatting;
            // 
            // grb_ChucNang
            // 
            grb_ChucNang.Controls.Add(pn_XuatExcel);
            grb_ChucNang.Controls.Add(pn_XoaSP);
            grb_ChucNang.Controls.Add(pn_UpdateSP);
            grb_ChucNang.Controls.Add(pn_ThemSP);
            grb_ChucNang.Controls.Add(pn_LamMoi);
            grb_ChucNang.Location = new Point(1514, 4);
            grb_ChucNang.Margin = new Padding(4, 4, 4, 4);
            grb_ChucNang.Name = "grb_ChucNang";
            grb_ChucNang.Padding = new Padding(4, 4, 4, 4);
            grb_ChucNang.Size = new Size(436, 628);
            grb_ChucNang.TabIndex = 1;
            grb_ChucNang.TabStop = false;
            grb_ChucNang.Text = "Chức năng";
            // 
            // pn_XuatExcel
            // 
            pn_XuatExcel.BackColor = Color.FromArgb(255, 255, 192);
            pn_XuatExcel.BorderStyle = BorderStyle.FixedSingle;
            pn_XuatExcel.Controls.Add(label12);
            pn_XuatExcel.Controls.Add(pictureBox5);
            pn_XuatExcel.Location = new Point(54, 510);
            pn_XuatExcel.Margin = new Padding(4, 4, 4, 4);
            pn_XuatExcel.Name = "pn_XuatExcel";
            pn_XuatExcel.Size = new Size(310, 61);
            pn_XuatExcel.TabIndex = 1;
            pn_XuatExcel.Click += pn_XuatExcel_Click;
            pn_XuatExcel.Paint += pn_XuatExcel_Paint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(89, 11);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(132, 32);
            label12.TabIndex = 5;
            label12.Text = "Xuất Excel";
            label12.Click += label12_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(2, 2);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(62, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pn_XoaSP
            // 
            pn_XoaSP.BackColor = Color.FromArgb(255, 255, 192);
            pn_XoaSP.BorderStyle = BorderStyle.FixedSingle;
            pn_XoaSP.Controls.Add(pictureBox1);
            pn_XoaSP.Controls.Add(label11);
            pn_XoaSP.Location = new Point(54, 394);
            pn_XoaSP.Margin = new Padding(4, 4, 4, 4);
            pn_XoaSP.Name = "pn_XoaSP";
            pn_XoaSP.Size = new Size(310, 61);
            pn_XoaSP.TabIndex = 1;
            pn_XoaSP.Click += pn_XoaSP_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 4);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(89, 11);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(177, 32);
            label11.TabIndex = 3;
            label11.Text = "Xoá Sản Phẩm";
            label11.Click += label11_Click;
            // 
            // pn_UpdateSP
            // 
            pn_UpdateSP.BackColor = Color.FromArgb(255, 255, 192);
            pn_UpdateSP.BorderStyle = BorderStyle.FixedSingle;
            pn_UpdateSP.Controls.Add(pictureBox2);
            pn_UpdateSP.Controls.Add(label10);
            pn_UpdateSP.Location = new Point(54, 286);
            pn_UpdateSP.Margin = new Padding(4, 4, 4, 4);
            pn_UpdateSP.Name = "pn_UpdateSP";
            pn_UpdateSP.Size = new Size(310, 61);
            pn_UpdateSP.TabIndex = 1;
            pn_UpdateSP.Click += pn_UpdateSP_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 4);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(82, 11);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(215, 32);
            label10.TabIndex = 2;
            label10.Text = "Update Sản Phẩm";
            label10.Click += label10_Click;
            // 
            // pn_ThemSP
            // 
            pn_ThemSP.BackColor = Color.FromArgb(255, 255, 192);
            pn_ThemSP.BorderStyle = BorderStyle.FixedSingle;
            pn_ThemSP.Controls.Add(pictureBox3);
            pn_ThemSP.Controls.Add(label9);
            pn_ThemSP.Location = new Point(54, 185);
            pn_ThemSP.Margin = new Padding(4, 4, 4, 4);
            pn_ThemSP.Name = "pn_ThemSP";
            pn_ThemSP.Size = new Size(310, 61);
            pn_ThemSP.TabIndex = 1;
            pn_ThemSP.Click += pn_ThemSP_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(2, 2);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(78, 12);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(196, 32);
            label9.TabIndex = 1;
            label9.Text = "Thêm Sản Phẩm";
            label9.Click += label9_Click;
            // 
            // pn_LamMoi
            // 
            pn_LamMoi.BackColor = Color.FromArgb(255, 255, 192);
            pn_LamMoi.BorderStyle = BorderStyle.FixedSingle;
            pn_LamMoi.Controls.Add(pictureBox4);
            pn_LamMoi.Controls.Add(label8);
            pn_LamMoi.Location = new Point(54, 88);
            pn_LamMoi.Margin = new Padding(4, 4, 4, 4);
            pn_LamMoi.Name = "pn_LamMoi";
            pn_LamMoi.Size = new Size(310, 61);
            pn_LamMoi.TabIndex = 0;
            pn_LamMoi.Click += pn_LamMoi_Click;
            pn_LamMoi.MouseEnter += pn_LamMoi_MouseEnter;
            pn_LamMoi.MouseLeave += pn_LamMoi_MouseLeave;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(2, 2);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(62, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(111, 11);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(113, 32);
            label8.TabIndex = 0;
            label8.Text = "Làm Mới";
            label8.Click += label8_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ptb_Anh);
            groupBox1.Controls.Add(txt_Search);
            groupBox1.Controls.Add(rd_HetHang);
            groupBox1.Controls.Add(rd_ConHang);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txt_GiaBan);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_GiaNhap);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_ThongSoKyThuat);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_HangSanPham);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_TenSanPham);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_MaSanPham);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(4, 4);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(1502, 628);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // ptb_Anh
            // 
            ptb_Anh.BackColor = Color.White;
            ptb_Anh.BackgroundImage = (Image)resources.GetObject("ptb_Anh.BackgroundImage");
            ptb_Anh.BackgroundImageLayout = ImageLayout.Zoom;
            ptb_Anh.BorderStyle = BorderStyle.FixedSingle;
            ptb_Anh.Location = new Point(1071, 56);
            ptb_Anh.Margin = new Padding(2);
            ptb_Anh.Name = "ptb_Anh";
            ptb_Anh.Size = new Size(302, 364);
            ptb_Anh.SizeMode = PictureBoxSizeMode.Zoom;
            ptb_Anh.TabIndex = 0;
            ptb_Anh.TabStop = false;
            ptb_Anh.Click += pictureBox1_Click;
            // 
            // txt_Search
            // 
            txt_Search.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Search.Location = new Point(290, 568);
            txt_Search.Margin = new Padding(4, 4, 4, 4);
            txt_Search.Name = "txt_Search";
            txt_Search.PlaceholderText = "Mời nhập tên sản phẩm cần tìm?";
            txt_Search.Size = new Size(602, 34);
            txt_Search.TabIndex = 16;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // rd_HetHang
            // 
            rd_HetHang.AutoSize = true;
            rd_HetHang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rd_HetHang.Location = new Point(1289, 476);
            rd_HetHang.Margin = new Padding(4, 4, 4, 4);
            rd_HetHang.Name = "rd_HetHang";
            rd_HetHang.Size = new Size(117, 32);
            rd_HetHang.TabIndex = 15;
            rd_HetHang.TabStop = true;
            rd_HetHang.Text = "Hết hàng";
            rd_HetHang.UseVisualStyleBackColor = true;
            // 
            // rd_ConHang
            // 
            rd_ConHang.AutoSize = true;
            rd_ConHang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rd_ConHang.Location = new Point(1104, 476);
            rd_ConHang.Margin = new Padding(4, 4, 4, 4);
            rd_ConHang.Name = "rd_ConHang";
            rd_ConHang.Size = new Size(121, 32);
            rd_ConHang.TabIndex = 14;
            rd_ConHang.TabStop = true;
            rd_ConHang.Text = "Còn hàng\r\n";
            rd_ConHang.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(951, 476);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(102, 28);
            label7.TabIndex = 13;
            label7.Text = "Trạng thái:";
            // 
            // txt_GiaBan
            // 
            txt_GiaBan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_GiaBan.Location = new Point(290, 510);
            txt_GiaBan.Margin = new Padding(4, 4, 4, 4);
            txt_GiaBan.Name = "txt_GiaBan";
            txt_GiaBan.Size = new Size(602, 34);
            txt_GiaBan.TabIndex = 11;
            txt_GiaBan.TextChanged += txt_GiaBan_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(65, 514);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 28);
            label6.TabIndex = 10;
            label6.Text = "Giá bán:";
            // 
            // txt_GiaNhap
            // 
            txt_GiaNhap.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_GiaNhap.Location = new Point(290, 434);
            txt_GiaNhap.Margin = new Padding(4, 4, 4, 4);
            txt_GiaNhap.Name = "txt_GiaNhap";
            txt_GiaNhap.Size = new Size(602, 34);
            txt_GiaNhap.TabIndex = 9;
            txt_GiaNhap.TextChanged += txt_GiaNhap_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(65, 438);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 8;
            label5.Text = "Giá nhập:";
            // 
            // txt_ThongSoKyThuat
            // 
            txt_ThongSoKyThuat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ThongSoKyThuat.Location = new Point(290, 259);
            txt_ThongSoKyThuat.Margin = new Padding(4, 4, 4, 4);
            txt_ThongSoKyThuat.Multiline = true;
            txt_ThongSoKyThuat.Name = "txt_ThongSoKyThuat";
            txt_ThongSoKyThuat.Size = new Size(602, 136);
            txt_ThongSoKyThuat.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(65, 262);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(168, 28);
            label4.TabIndex = 6;
            label4.Text = "Thông số kĩ thuật:";
            // 
            // txt_HangSanPham
            // 
            txt_HangSanPham.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_HangSanPham.Location = new Point(290, 185);
            txt_HangSanPham.Margin = new Padding(4, 4, 4, 4);
            txt_HangSanPham.Name = "txt_HangSanPham";
            txt_HangSanPham.Size = new Size(602, 34);
            txt_HangSanPham.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(65, 189);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 28);
            label3.TabIndex = 4;
            label3.Text = "Hãng sản xuất:";
            // 
            // txt_TenSanPham
            // 
            txt_TenSanPham.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TenSanPham.Location = new Point(290, 116);
            txt_TenSanPham.Margin = new Padding(4, 4, 4, 4);
            txt_TenSanPham.Name = "txt_TenSanPham";
            txt_TenSanPham.Size = new Size(602, 34);
            txt_TenSanPham.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 120);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 2;
            label2.Text = "Tên sản phẩm:";
            // 
            // txt_MaSanPham
            // 
            txt_MaSanPham.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaSanPham.Location = new Point(290, 52);
            txt_MaSanPham.Margin = new Padding(4, 4, 4, 4);
            txt_MaSanPham.Name = "txt_MaSanPham";
            txt_MaSanPham.Size = new Size(602, 34);
            txt_MaSanPham.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(65, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm:";
            // 
            // Form_SanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(pn_Form_SanPham);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form_SanPham";
            Text = "Form_SanPham";
            Load += Form_SanPham_Load;
            pn_Form_SanPham.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            grb_ChucNang.ResumeLayout(false);
            pn_XuatExcel.ResumeLayout(false);
            pn_XuatExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            pn_XoaSP.ResumeLayout(false);
            pn_XoaSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pn_UpdateSP.ResumeLayout(false);
            pn_UpdateSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pn_ThemSP.ResumeLayout(false);
            pn_ThemSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pn_LamMoi.ResumeLayout(false);
            pn_LamMoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Anh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Form_SanPham;
        private GroupBox groupBox3;
        private GroupBox grb_ChucNang;
        private GroupBox groupBox1;
        private TextBox txt_GiaNhap;
        private Label label5;
        private TextBox txt_ThongSoKyThuat;
        private Label label4;
        private TextBox txt_HangSanPham;
        private Label label3;
        private TextBox txt_TenSanPham;
        private Label label2;
        private TextBox txt_MaSanPham;
        private Label label1;
        private Label label6;
        private DataGridView dtgView;
        private Panel pn_XuatExcel;
        private Panel pn_XoaSP;
        private Panel pn_UpdateSP;
        private Panel pn_ThemSP;
        private Panel pn_LamMoi;
        private RadioButton rd_HetHang;
        private RadioButton rd_ConHang;
        private Label label7;
        private TextBox txt_Search;
        private TextBox txt_GiaBan;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private PictureBox ptb_Anh;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label12;
        private PictureBox pictureBox5;
    }
}