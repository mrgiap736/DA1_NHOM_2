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
            tc_SanPham = new TabControl();
            tabPage1 = new TabPage();
            grb_TimKiem = new GroupBox();
            label21 = new Label();
            label20 = new Label();
            cbx_FillLoaiRen = new ComboBox();
            cbx_FillMauSac = new ComboBox();
            label19 = new Label();
            cbx_FillChatLieu = new ComboBox();
            label18 = new Label();
            label7 = new Label();
            cbx_FillHangSX = new ComboBox();
            txt_Search = new TextBox();
            groupBox3 = new GroupBox();
            dtgView = new DataGridView();
            grb_ChucNang = new GroupBox();
            pn_XuatExcel = new Panel();
            label12 = new Label();
            pictureBox5 = new PictureBox();
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
            cbx_LoaiSP = new ComboBox();
            cbx_TrangThai = new ComboBox();
            label17 = new Label();
            cbx_MauSac = new ComboBox();
            label16 = new Label();
            cbx_ChatLieu = new ComboBox();
            label15 = new Label();
            cbx_LoaiRen = new ComboBox();
            label5 = new Label();
            txt_CanNang = new TextBox();
            label14 = new Label();
            cbx_HangSX = new ComboBox();
            label13 = new Label();
            txt_SoLuong = new TextBox();
            label1 = new Label();
            ptb_Anh = new PictureBox();
            txt_GiaBan = new TextBox();
            label6 = new Label();
            txt_ChieuDai = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txt_TenSanPham = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            dtg_DSHangSX = new DataGridView();
            dtg_DSLoaiRen = new DataGridView();
            dtg_DSChatLieu = new DataGridView();
            dtg_DSMau = new DataGridView();
            groupBox2 = new GroupBox();
            btn_Reset = new Button();
            btn_XoaTP = new Button();
            btn_AddTP = new Button();
            label24 = new Label();
            txt_HangSanXuat_2 = new TextBox();
            label23 = new Label();
            txt_LoaiRen_2 = new TextBox();
            label22 = new Label();
            txt_ChatLieu_2 = new TextBox();
            label11 = new Label();
            txt_MauSac_2 = new TextBox();
            pn_Form_SanPham.SuspendLayout();
            tc_SanPham.SuspendLayout();
            tabPage1.SuspendLayout();
            grb_TimKiem.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            grb_ChucNang.SuspendLayout();
            pn_XuatExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            pn_UpdateSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pn_ThemSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pn_LamMoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Anh).BeginInit();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_DSHangSX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_DSLoaiRen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_DSChatLieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_DSMau).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pn_Form_SanPham
            // 
            pn_Form_SanPham.BackColor = Color.FromArgb(255, 192, 192);
            pn_Form_SanPham.Controls.Add(tc_SanPham);
            pn_Form_SanPham.Location = new Point(188, 45);
            pn_Form_SanPham.Margin = new Padding(3, 2, 3, 2);
            pn_Form_SanPham.Name = "pn_Form_SanPham";
            pn_Form_SanPham.Size = new Size(1478, 684);
            pn_Form_SanPham.TabIndex = 0;
            // 
            // tc_SanPham
            // 
            tc_SanPham.Controls.Add(tabPage1);
            tc_SanPham.Controls.Add(tabPage2);
            tc_SanPham.Location = new Point(3, 2);
            tc_SanPham.Margin = new Padding(3, 2, 3, 2);
            tc_SanPham.Name = "tc_SanPham";
            tc_SanPham.SelectedIndex = 0;
            tc_SanPham.Size = new Size(1473, 680);
            tc_SanPham.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(241, 250, 218);
            tabPage1.Controls.Add(grb_TimKiem);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(grb_ChucNang);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1465, 652);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sản phẩm";
            // 
            // grb_TimKiem
            // 
            grb_TimKiem.Controls.Add(label21);
            grb_TimKiem.Controls.Add(label20);
            grb_TimKiem.Controls.Add(cbx_FillLoaiRen);
            grb_TimKiem.Controls.Add(cbx_FillMauSac);
            grb_TimKiem.Controls.Add(label19);
            grb_TimKiem.Controls.Add(cbx_FillChatLieu);
            grb_TimKiem.Controls.Add(label18);
            grb_TimKiem.Controls.Add(label7);
            grb_TimKiem.Controls.Add(cbx_FillHangSX);
            grb_TimKiem.Controls.Add(txt_Search);
            grb_TimKiem.Location = new Point(52, 270);
            grb_TimKiem.Margin = new Padding(3, 2, 3, 2);
            grb_TimKiem.Name = "grb_TimKiem";
            grb_TimKiem.Padding = new Padding(3, 2, 3, 2);
            grb_TimKiem.Size = new Size(1362, 94);
            grb_TimKiem.TabIndex = 7;
            grb_TimKiem.TabStop = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F);
            label21.Location = new Point(1005, 61);
            label21.Name = "label21";
            label21.Size = new Size(61, 19);
            label21.TabIndex = 33;
            label21.Text = "Loại ren:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F);
            label20.Location = new Point(1005, 21);
            label20.Name = "label20";
            label20.Size = new Size(63, 19);
            label20.TabIndex = 33;
            label20.Text = "Màu sắc:";
            // 
            // cbx_FillLoaiRen
            // 
            cbx_FillLoaiRen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_FillLoaiRen.FormattingEnabled = true;
            cbx_FillLoaiRen.Items.AddRange(new object[] { "Tất cả" });
            cbx_FillLoaiRen.Location = new Point(1088, 60);
            cbx_FillLoaiRen.Margin = new Padding(3, 2, 3, 2);
            cbx_FillLoaiRen.Name = "cbx_FillLoaiRen";
            cbx_FillLoaiRen.Size = new Size(133, 23);
            cbx_FillLoaiRen.TabIndex = 36;
            cbx_FillLoaiRen.SelectedIndexChanged += cbx_Fill_SelectedIndexChanged;
            // 
            // cbx_FillMauSac
            // 
            cbx_FillMauSac.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_FillMauSac.FormattingEnabled = true;
            cbx_FillMauSac.Items.AddRange(new object[] { "Tất cả" });
            cbx_FillMauSac.Location = new Point(1088, 20);
            cbx_FillMauSac.Margin = new Padding(3, 2, 3, 2);
            cbx_FillMauSac.Name = "cbx_FillMauSac";
            cbx_FillMauSac.Size = new Size(133, 23);
            cbx_FillMauSac.TabIndex = 35;
            cbx_FillMauSac.SelectedIndexChanged += cbx_Fill_SelectedIndexChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10F);
            label19.Location = new Point(654, 61);
            label19.Name = "label19";
            label19.Size = new Size(66, 19);
            label19.TabIndex = 33;
            label19.Text = "Chất liệu:";
            // 
            // cbx_FillChatLieu
            // 
            cbx_FillChatLieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_FillChatLieu.FormattingEnabled = true;
            cbx_FillChatLieu.Items.AddRange(new object[] { "Tất cả" });
            cbx_FillChatLieu.Location = new Point(781, 60);
            cbx_FillChatLieu.Margin = new Padding(3, 2, 3, 2);
            cbx_FillChatLieu.Name = "cbx_FillChatLieu";
            cbx_FillChatLieu.Size = new Size(133, 23);
            cbx_FillChatLieu.TabIndex = 34;
            cbx_FillChatLieu.SelectedIndexChanged += cbx_Fill_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F);
            label18.Location = new Point(654, 21);
            label18.Name = "label18";
            label18.Size = new Size(100, 19);
            label18.TabIndex = 33;
            label18.Text = "Hãng sản xuất:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(28, 41);
            label7.Name = "label7";
            label7.Size = new Size(67, 19);
            label7.TabIndex = 18;
            label7.Text = "Tìm kiếm:";
            // 
            // cbx_FillHangSX
            // 
            cbx_FillHangSX.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_FillHangSX.FormattingEnabled = true;
            cbx_FillHangSX.Items.AddRange(new object[] { "Tất cả" });
            cbx_FillHangSX.Location = new Point(781, 20);
            cbx_FillHangSX.Margin = new Padding(3, 2, 3, 2);
            cbx_FillHangSX.Name = "cbx_FillHangSX";
            cbx_FillHangSX.Size = new Size(133, 23);
            cbx_FillHangSX.TabIndex = 17;
            cbx_FillHangSX.SelectedIndexChanged += cbx_Fill_SelectedIndexChanged;
            // 
            // txt_Search
            // 
            txt_Search.Font = new Font("Segoe UI", 10F);
            txt_Search.Location = new Point(152, 38);
            txt_Search.Margin = new Padding(3, 2, 3, 2);
            txt_Search.Name = "txt_Search";
            txt_Search.PlaceholderText = " Mời nhập tên sản phẩm cần tìm?";
            txt_Search.Size = new Size(242, 25);
            txt_Search.TabIndex = 16;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtgView);
            groupBox3.Location = new Point(52, 373);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(1362, 269);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm";
            // 
            // dtgView
            // 
            dtgView.BackgroundColor = Color.White;
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.GridColor = SystemColors.ActiveBorder;
            dtgView.Location = new Point(5, 20);
            dtgView.Margin = new Padding(3, 2, 3, 2);
            dtgView.Name = "dtgView";
            dtgView.ReadOnly = true;
            dtgView.RowHeadersWidth = 51;
            dtgView.Size = new Size(1352, 245);
            dtgView.TabIndex = 0;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // grb_ChucNang
            // 
            grb_ChucNang.Controls.Add(pn_XuatExcel);
            grb_ChucNang.Controls.Add(pn_UpdateSP);
            grb_ChucNang.Controls.Add(pn_ThemSP);
            grb_ChucNang.Controls.Add(pn_LamMoi);
            grb_ChucNang.Location = new Point(1109, 14);
            grb_ChucNang.Margin = new Padding(3, 2, 3, 2);
            grb_ChucNang.Name = "grb_ChucNang";
            grb_ChucNang.Padding = new Padding(3, 2, 3, 2);
            grb_ChucNang.Size = new Size(305, 254);
            grb_ChucNang.TabIndex = 5;
            grb_ChucNang.TabStop = false;
            grb_ChucNang.Text = "Chức năng";
            // 
            // pn_XuatExcel
            // 
            pn_XuatExcel.BackColor = Color.FromArgb(255, 255, 192);
            pn_XuatExcel.BorderStyle = BorderStyle.FixedSingle;
            pn_XuatExcel.Controls.Add(label12);
            pn_XuatExcel.Controls.Add(pictureBox5);
            pn_XuatExcel.Location = new Point(46, 194);
            pn_XuatExcel.Margin = new Padding(3, 2, 3, 2);
            pn_XuatExcel.Name = "pn_XuatExcel";
            pn_XuatExcel.Size = new Size(217, 37);
            pn_XuatExcel.TabIndex = 1;
            pn_XuatExcel.Click += pn_XuatExcel_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(62, 7);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(89, 21);
            label12.TabIndex = 5;
            label12.Text = "Xuất Excel";
            label12.Click += pn_XuatExcel_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(2, 2);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pn_XuatExcel_Click;
            // 
            // pn_UpdateSP
            // 
            pn_UpdateSP.BackColor = Color.FromArgb(255, 255, 192);
            pn_UpdateSP.BorderStyle = BorderStyle.FixedSingle;
            pn_UpdateSP.Controls.Add(pictureBox2);
            pn_UpdateSP.Controls.Add(label10);
            pn_UpdateSP.Location = new Point(46, 140);
            pn_UpdateSP.Margin = new Padding(3, 2, 3, 2);
            pn_UpdateSP.Name = "pn_UpdateSP";
            pn_UpdateSP.Size = new Size(217, 37);
            pn_UpdateSP.TabIndex = 1;
            pn_UpdateSP.Click += pn_UpdateSP_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 2);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pn_UpdateSP_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(58, 7);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(146, 21);
            label10.TabIndex = 2;
            label10.Text = "Update Sản Phẩm";
            label10.Click += pn_UpdateSP_Click;
            // 
            // pn_ThemSP
            // 
            pn_ThemSP.BackColor = Color.FromArgb(255, 255, 192);
            pn_ThemSP.BorderStyle = BorderStyle.FixedSingle;
            pn_ThemSP.Controls.Add(pictureBox3);
            pn_ThemSP.Controls.Add(label9);
            pn_ThemSP.Location = new Point(46, 85);
            pn_ThemSP.Margin = new Padding(3, 2, 3, 2);
            pn_ThemSP.Name = "pn_ThemSP";
            pn_ThemSP.Size = new Size(217, 37);
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
            pictureBox3.Size = new Size(44, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pn_ThemSP_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(54, 8);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(133, 21);
            label9.TabIndex = 1;
            label9.Text = "Thêm Sản Phẩm";
            label9.Click += pn_ThemSP_Click;
            // 
            // pn_LamMoi
            // 
            pn_LamMoi.BackColor = Color.FromArgb(255, 255, 192);
            pn_LamMoi.BorderStyle = BorderStyle.FixedSingle;
            pn_LamMoi.Controls.Add(pictureBox4);
            pn_LamMoi.Controls.Add(label8);
            pn_LamMoi.Location = new Point(46, 31);
            pn_LamMoi.Margin = new Padding(3, 2, 3, 2);
            pn_LamMoi.Name = "pn_LamMoi";
            pn_LamMoi.Size = new Size(217, 37);
            pn_LamMoi.TabIndex = 0;
            pn_LamMoi.Click += pn_LamMoi_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(2, 2);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pn_LamMoi_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(78, 7);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(76, 21);
            label8.TabIndex = 0;
            label8.Text = "Làm Mới";
            label8.Click += pn_LamMoi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbx_LoaiSP);
            groupBox1.Controls.Add(cbx_TrangThai);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(cbx_MauSac);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(cbx_ChatLieu);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(cbx_LoaiRen);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_CanNang);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(cbx_HangSX);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txt_SoLuong);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ptb_Anh);
            groupBox1.Controls.Add(txt_GiaBan);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_ChieuDai);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_TenSanPham);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(52, 14);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1052, 254);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cbx_LoaiSP
            // 
            cbx_LoaiSP.FormattingEnabled = true;
            cbx_LoaiSP.Items.AddRange(new object[] { "Chuôi", "Ngọn" });
            cbx_LoaiSP.Location = new Point(152, 110);
            cbx_LoaiSP.Margin = new Padding(3, 2, 3, 2);
            cbx_LoaiSP.Name = "cbx_LoaiSP";
            cbx_LoaiSP.Size = new Size(218, 23);
            cbx_LoaiSP.TabIndex = 33;
            // 
            // cbx_TrangThai
            // 
            cbx_TrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_TrangThai.FormattingEnabled = true;
            cbx_TrangThai.Items.AddRange(new object[] { "Đang kinh doanh", "Ngừng kinh doanh" });
            cbx_TrangThai.Location = new Point(504, 216);
            cbx_TrangThai.Margin = new Padding(3, 2, 3, 2);
            cbx_TrangThai.Name = "cbx_TrangThai";
            cbx_TrangThai.Size = new Size(169, 23);
            cbx_TrangThai.TabIndex = 32;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F);
            label17.Location = new Point(390, 216);
            label17.Name = "label17";
            label17.Size = new Size(73, 19);
            label17.TabIndex = 31;
            label17.Text = "Trạng thái:";
            // 
            // cbx_MauSac
            // 
            cbx_MauSac.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_MauSac.FormattingEnabled = true;
            cbx_MauSac.Location = new Point(504, 182);
            cbx_MauSac.Margin = new Padding(3, 2, 3, 2);
            cbx_MauSac.Name = "cbx_MauSac";
            cbx_MauSac.Size = new Size(169, 23);
            cbx_MauSac.TabIndex = 30;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F);
            label16.Location = new Point(390, 182);
            label16.Name = "label16";
            label16.Size = new Size(63, 19);
            label16.TabIndex = 29;
            label16.Text = "Màu sắc:";
            // 
            // cbx_ChatLieu
            // 
            cbx_ChatLieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_ChatLieu.FormattingEnabled = true;
            cbx_ChatLieu.Location = new Point(504, 146);
            cbx_ChatLieu.Margin = new Padding(3, 2, 3, 2);
            cbx_ChatLieu.Name = "cbx_ChatLieu";
            cbx_ChatLieu.Size = new Size(169, 23);
            cbx_ChatLieu.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F);
            label15.Location = new Point(390, 146);
            label15.Name = "label15";
            label15.Size = new Size(66, 19);
            label15.TabIndex = 27;
            label15.Text = "Chất liệu:";
            // 
            // cbx_LoaiRen
            // 
            cbx_LoaiRen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_LoaiRen.FormattingEnabled = true;
            cbx_LoaiRen.Location = new Point(504, 107);
            cbx_LoaiRen.Margin = new Padding(3, 2, 3, 2);
            cbx_LoaiRen.Name = "cbx_LoaiRen";
            cbx_LoaiRen.Size = new Size(169, 23);
            cbx_LoaiRen.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(390, 111);
            label5.Name = "label5";
            label5.Size = new Size(61, 19);
            label5.TabIndex = 25;
            label5.Text = "Loại ren:";
            // 
            // txt_CanNang
            // 
            txt_CanNang.Font = new Font("Segoe UI", 10F);
            txt_CanNang.Location = new Point(152, 179);
            txt_CanNang.Margin = new Padding(3, 2, 3, 2);
            txt_CanNang.Name = "txt_CanNang";
            txt_CanNang.Size = new Size(218, 25);
            txt_CanNang.TabIndex = 24;
            txt_CanNang.KeyPress += txt_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F);
            label14.Location = new Point(28, 183);
            label14.Name = "label14";
            label14.Size = new Size(71, 19);
            label14.TabIndex = 23;
            label14.Text = "Cân nặng:";
            // 
            // cbx_HangSX
            // 
            cbx_HangSX.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_HangSX.FormattingEnabled = true;
            cbx_HangSX.Location = new Point(504, 70);
            cbx_HangSX.Margin = new Padding(3, 2, 3, 2);
            cbx_HangSX.Name = "cbx_HangSX";
            cbx_HangSX.Size = new Size(169, 23);
            cbx_HangSX.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.Location = new Point(28, 111);
            label13.Name = "label13";
            label13.Size = new Size(101, 19);
            label13.TabIndex = 19;
            label13.Text = "Loại sản phẩm:";
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Font = new Font("Segoe UI", 10F);
            txt_SoLuong.Location = new Point(152, 70);
            txt_SoLuong.Margin = new Padding(3, 2, 3, 2);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(218, 25);
            txt_SoLuong.TabIndex = 18;
            txt_SoLuong.KeyPress += txt_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(28, 72);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 17;
            label1.Text = "Số lượng:";
            // 
            // ptb_Anh
            // 
            ptb_Anh.BackColor = Color.White;
            ptb_Anh.BackgroundImage = (Image)resources.GetObject("ptb_Anh.BackgroundImage");
            ptb_Anh.BackgroundImageLayout = ImageLayout.Zoom;
            ptb_Anh.BorderStyle = BorderStyle.FixedSingle;
            ptb_Anh.Location = new Point(749, 26);
            ptb_Anh.Margin = new Padding(2);
            ptb_Anh.Name = "ptb_Anh";
            ptb_Anh.Size = new Size(212, 220);
            ptb_Anh.SizeMode = PictureBoxSizeMode.Zoom;
            ptb_Anh.TabIndex = 0;
            ptb_Anh.TabStop = false;
            ptb_Anh.Click += pictureBox1_Click;
            // 
            // txt_GiaBan
            // 
            txt_GiaBan.Font = new Font("Segoe UI", 10F);
            txt_GiaBan.Location = new Point(152, 214);
            txt_GiaBan.Margin = new Padding(3, 2, 3, 2);
            txt_GiaBan.Name = "txt_GiaBan";
            txt_GiaBan.Size = new Size(218, 25);
            txt_GiaBan.TabIndex = 11;
            txt_GiaBan.TextChanged += txt_GiaBan_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(28, 217);
            label6.Name = "label6";
            label6.Size = new Size(59, 19);
            label6.TabIndex = 10;
            label6.Text = "Giá bán:";
            // 
            // txt_ChieuDai
            // 
            txt_ChieuDai.Font = new Font("Segoe UI", 10F);
            txt_ChieuDai.Location = new Point(152, 144);
            txt_ChieuDai.Margin = new Padding(3, 2, 3, 2);
            txt_ChieuDai.Name = "txt_ChieuDai";
            txt_ChieuDai.Size = new Size(218, 25);
            txt_ChieuDai.TabIndex = 7;
            txt_ChieuDai.KeyPress += txt_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(28, 146);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 6;
            label4.Text = "Chiều dài:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(390, 72);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 4;
            label3.Text = "Hãng sản xuất:";
            // 
            // txt_TenSanPham
            // 
            txt_TenSanPham.Font = new Font("Segoe UI", 10F);
            txt_TenSanPham.Location = new Point(152, 34);
            txt_TenSanPham.Margin = new Padding(3, 2, 3, 2);
            txt_TenSanPham.Name = "txt_TenSanPham";
            txt_TenSanPham.Size = new Size(521, 25);
            txt_TenSanPham.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(28, 34);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 2;
            label2.Text = "Tên sản phẩm:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(241, 250, 218);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1465, 652);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thành phần";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label28);
            groupBox4.Controls.Add(label27);
            groupBox4.Controls.Add(label26);
            groupBox4.Controls.Add(label25);
            groupBox4.Controls.Add(dtg_DSHangSX);
            groupBox4.Controls.Add(dtg_DSLoaiRen);
            groupBox4.Controls.Add(dtg_DSChatLieu);
            groupBox4.Controls.Add(dtg_DSMau);
            groupBox4.Location = new Point(325, 286);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(812, 317);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(664, 44);
            label28.Name = "label28";
            label28.Size = new Size(83, 15);
            label28.TabIndex = 7;
            label28.Text = "Hãng sản xuất";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(474, 44);
            label27.Name = "label27";
            label27.Size = new Size(49, 15);
            label27.TabIndex = 6;
            label27.Text = "Loại ren";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(273, 44);
            label26.Name = "label26";
            label26.Size = new Size(54, 15);
            label26.TabIndex = 5;
            label26.Text = "Chất liệu";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(78, 44);
            label25.Name = "label25";
            label25.Size = new Size(51, 15);
            label25.TabIndex = 4;
            label25.Text = "Màu sắc";
            // 
            // dtg_DSHangSX
            // 
            dtg_DSHangSX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_DSHangSX.BackgroundColor = Color.White;
            dtg_DSHangSX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_DSHangSX.Location = new Point(608, 61);
            dtg_DSHangSX.Margin = new Padding(3, 2, 3, 2);
            dtg_DSHangSX.Name = "dtg_DSHangSX";
            dtg_DSHangSX.RowHeadersWidth = 51;
            dtg_DSHangSX.Size = new Size(195, 252);
            dtg_DSHangSX.TabIndex = 3;
            dtg_DSHangSX.CellClick += dtgView_CellClick_HangSX;
            // 
            // dtg_DSLoaiRen
            // 
            dtg_DSLoaiRen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_DSLoaiRen.BackgroundColor = Color.White;
            dtg_DSLoaiRen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_DSLoaiRen.Location = new Point(408, 61);
            dtg_DSLoaiRen.Margin = new Padding(3, 2, 3, 2);
            dtg_DSLoaiRen.Name = "dtg_DSLoaiRen";
            dtg_DSLoaiRen.RowHeadersWidth = 51;
            dtg_DSLoaiRen.Size = new Size(195, 252);
            dtg_DSLoaiRen.TabIndex = 2;
            dtg_DSLoaiRen.CellClick += dtgView_CellClick_LoaiRen;
            // 
            // dtg_DSChatLieu
            // 
            dtg_DSChatLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_DSChatLieu.BackgroundColor = Color.White;
            dtg_DSChatLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_DSChatLieu.Location = new Point(207, 61);
            dtg_DSChatLieu.Margin = new Padding(3, 2, 3, 2);
            dtg_DSChatLieu.Name = "dtg_DSChatLieu";
            dtg_DSChatLieu.RowHeadersWidth = 51;
            dtg_DSChatLieu.Size = new Size(195, 252);
            dtg_DSChatLieu.TabIndex = 1;
            dtg_DSChatLieu.CellClick += dtgView_CellClick_ChatLieu;
            // 
            // dtg_DSMau
            // 
            dtg_DSMau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_DSMau.BackgroundColor = Color.White;
            dtg_DSMau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_DSMau.Location = new Point(7, 61);
            dtg_DSMau.Margin = new Padding(3, 2, 3, 2);
            dtg_DSMau.Name = "dtg_DSMau";
            dtg_DSMau.RowHeadersWidth = 51;
            dtg_DSMau.Size = new Size(195, 252);
            dtg_DSMau.TabIndex = 0;
            dtg_DSMau.CellClick += dtgView_CellClick_MauSac;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Reset);
            groupBox2.Controls.Add(btn_XoaTP);
            groupBox2.Controls.Add(btn_AddTP);
            groupBox2.Controls.Add(label24);
            groupBox2.Controls.Add(txt_HangSanXuat_2);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(txt_LoaiRen_2);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(txt_ChatLieu_2);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txt_MauSac_2);
            groupBox2.Location = new Point(325, 4);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(812, 278);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin thành phần";
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(590, 153);
            btn_Reset.Margin = new Padding(3, 2, 3, 2);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(82, 22);
            btn_Reset.TabIndex = 10;
            btn_Reset.Text = "Làm mới";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_XoaTP
            // 
            btn_XoaTP.Location = new Point(664, 113);
            btn_XoaTP.Margin = new Padding(3, 2, 3, 2);
            btn_XoaTP.Name = "btn_XoaTP";
            btn_XoaTP.Size = new Size(82, 22);
            btn_XoaTP.TabIndex = 9;
            btn_XoaTP.Text = "Xóa";
            btn_XoaTP.UseVisualStyleBackColor = true;
            btn_XoaTP.Click += btn_DelTP_Click;
            // 
            // btn_AddTP
            // 
            btn_AddTP.Location = new Point(521, 113);
            btn_AddTP.Margin = new Padding(3, 2, 3, 2);
            btn_AddTP.Name = "btn_AddTP";
            btn_AddTP.Size = new Size(82, 22);
            btn_AddTP.TabIndex = 8;
            btn_AddTP.Text = "Thêm";
            btn_AddTP.UseVisualStyleBackColor = true;
            btn_AddTP.Click += btn_AddThanhPhan_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(44, 194);
            label24.Name = "label24";
            label24.Size = new Size(86, 15);
            label24.TabIndex = 7;
            label24.Text = "Hãng sản xuất:";
            // 
            // txt_HangSanXuat_2
            // 
            txt_HangSanXuat_2.Location = new Point(177, 192);
            txt_HangSanXuat_2.Margin = new Padding(3, 2, 3, 2);
            txt_HangSanXuat_2.Name = "txt_HangSanXuat_2";
            txt_HangSanXuat_2.Size = new Size(279, 23);
            txt_HangSanXuat_2.TabIndex = 6;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(44, 148);
            label23.Name = "label23";
            label23.Size = new Size(52, 15);
            label23.TabIndex = 5;
            label23.Text = "Loại ren:";
            // 
            // txt_LoaiRen_2
            // 
            txt_LoaiRen_2.Location = new Point(177, 146);
            txt_LoaiRen_2.Margin = new Padding(3, 2, 3, 2);
            txt_LoaiRen_2.Name = "txt_LoaiRen_2";
            txt_LoaiRen_2.Size = new Size(279, 23);
            txt_LoaiRen_2.TabIndex = 4;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(44, 103);
            label22.Name = "label22";
            label22.Size = new Size(57, 15);
            label22.TabIndex = 3;
            label22.Text = "Chất liệu:";
            // 
            // txt_ChatLieu_2
            // 
            txt_ChatLieu_2.Location = new Point(177, 100);
            txt_ChatLieu_2.Margin = new Padding(3, 2, 3, 2);
            txt_ChatLieu_2.Name = "txt_ChatLieu_2";
            txt_ChatLieu_2.Size = new Size(279, 23);
            txt_ChatLieu_2.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(44, 60);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 1;
            label11.Text = "Màu sắc:";
            // 
            // txt_MauSac_2
            // 
            txt_MauSac_2.Location = new Point(177, 58);
            txt_MauSac_2.Margin = new Padding(3, 2, 3, 2);
            txt_MauSac_2.Name = "txt_MauSac_2";
            txt_MauSac_2.Size = new Size(279, 23);
            txt_MauSac_2.TabIndex = 0;
            // 
            // Form_SanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 775);
            Controls.Add(pn_Form_SanPham);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_SanPham";
            Text = "Form_SanPham";
            pn_Form_SanPham.ResumeLayout(false);
            tc_SanPham.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            grb_TimKiem.ResumeLayout(false);
            grb_TimKiem.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            grb_ChucNang.ResumeLayout(false);
            pn_XuatExcel.ResumeLayout(false);
            pn_XuatExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_DSHangSX).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_DSLoaiRen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_DSChatLieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_DSMau).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Form_SanPham;
        private TabControl tc_SanPham;
        private TabPage tabPage1;
        private GroupBox grb_TimKiem;
        private Label label21;
        private Label label20;
        private ComboBox cbx_FillLoaiRen;
        private ComboBox cbx_FillMauSac;
        private Label label19;
        private ComboBox cbx_FillChatLieu;
        private Label label18;
        private Label label7;
        private ComboBox cbx_FillHangSX;
        private TextBox txt_Search;
        private GroupBox groupBox3;
        private DataGridView dtgView;
        private GroupBox grb_ChucNang;
        private Panel pn_XuatExcel;
        private Label label12;
        private PictureBox pictureBox5;
        private Panel pn_UpdateSP;
        private PictureBox pictureBox2;
        private Label label10;
        private Panel pn_ThemSP;
        private PictureBox pictureBox3;
        private Label label9;
        private Panel pn_LamMoi;
        private PictureBox pictureBox4;
        private Label label8;
        private GroupBox groupBox1;
        private ComboBox cbx_TrangThai;
        private Label label17;
        private ComboBox cbx_MauSac;
        private Label label16;
        private ComboBox cbx_ChatLieu;
        private Label label15;
        private ComboBox cbx_LoaiRen;
        private Label label5;
        private TextBox txt_CanNang;
        private Label label14;
        private ComboBox cbx_HangSX;
        private Label label13;
        private TextBox txt_SoLuong;
        private Label label1;
        private PictureBox ptb_Anh;
        private TextBox txt_GiaBan;
        private Label label6;
        private TextBox txt_ChieuDai;
        private Label label4;
        private Label label3;
        private TextBox txt_TenSanPham;
        private Label label2;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private Button btn_XoaTP;
        private Button btn_AddTP;
        private Label label24;
        private TextBox txt_HangSanXuat_2;
        private Label label23;
        private TextBox txt_LoaiRen_2;
        private Label label22;
        private TextBox txt_ChatLieu_2;
        private Label label11;
        private TextBox txt_MauSac_2;
        private GroupBox groupBox4;
        private DataGridView dtg_DSHangSX;
        private DataGridView dtg_DSLoaiRen;
        private DataGridView dtg_DSChatLieu;
        private DataGridView dtg_DSMau;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Button btn_Reset;
        private ComboBox cbx_LoaiSP;
    }
}