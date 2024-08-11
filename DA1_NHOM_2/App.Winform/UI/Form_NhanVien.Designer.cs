namespace App.Winform.UI
{
    partial class Form_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NhanVien));
            pn_Form_NhanVien = new Panel();
            groupBox1 = new GroupBox();
            txt_Search = new TextBox();
            pn_Btn_Xoa = new Panel();
            panel4 = new Panel();
            label9 = new Label();
            pn_Btn_LamMoi = new Panel();
            panel3 = new Panel();
            label8 = new Label();
            pn_Btn_Sua = new Panel();
            panel2 = new Panel();
            label7 = new Label();
            pn_Btn_Them = new Panel();
            panel1 = new Panel();
            label6 = new Label();
            grb_DanhSach = new GroupBox();
            dtgView = new DataGridView();
            grb_ThongTin = new GroupBox();
            label11 = new Label();
            cbx_TrangThai = new ComboBox();
            txt_EmailNV = new TextBox();
            label10 = new Label();
            txt_SdtNv = new TextBox();
            label1 = new Label();
            Cmb_ChucVu = new ComboBox();
            txt_MatKhau = new TextBox();
            label5 = new Label();
            txt_TaiKhoan = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txt_TenNV = new TextBox();
            label2 = new Label();
            pn_Form_NhanVien.SuspendLayout();
            groupBox1.SuspendLayout();
            pn_Btn_Xoa.SuspendLayout();
            pn_Btn_LamMoi.SuspendLayout();
            pn_Btn_Sua.SuspendLayout();
            pn_Btn_Them.SuspendLayout();
            grb_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            grb_ThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // pn_Form_NhanVien
            // 
            pn_Form_NhanVien.BackColor = Color.FromArgb(255, 192, 192);
            pn_Form_NhanVien.Controls.Add(groupBox1);
            pn_Form_NhanVien.Controls.Add(pn_Btn_Xoa);
            pn_Form_NhanVien.Controls.Add(pn_Btn_LamMoi);
            pn_Form_NhanVien.Controls.Add(pn_Btn_Sua);
            pn_Form_NhanVien.Controls.Add(pn_Btn_Them);
            pn_Form_NhanVien.Controls.Add(grb_DanhSach);
            pn_Form_NhanVien.Controls.Add(grb_ThongTin);
            pn_Form_NhanVien.Location = new Point(215, 60);
            pn_Form_NhanVien.Name = "pn_Form_NhanVien";
            pn_Form_NhanVien.Size = new Size(1689, 912);
            pn_Form_NhanVien.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Search);
            groupBox1.Location = new Point(673, 356);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 78);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(6, 26);
            txt_Search.Name = "txt_Search";
            txt_Search.PlaceholderText = "Mời nhập tên nhân viên muốn tìm?";
            txt_Search.Size = new Size(473, 27);
            txt_Search.TabIndex = 0;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // pn_Btn_Xoa
            // 
            pn_Btn_Xoa.BackColor = Color.FromArgb(255, 255, 192);
            pn_Btn_Xoa.Controls.Add(panel4);
            pn_Btn_Xoa.Controls.Add(label9);
            pn_Btn_Xoa.Location = new Point(965, 466);
            pn_Btn_Xoa.Name = "pn_Btn_Xoa";
            pn_Btn_Xoa.Size = new Size(228, 50);
            pn_Btn_Xoa.TabIndex = 16;
            pn_Btn_Xoa.Click += pn_Btn_Xoa_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(49, 44);
            panel4.TabIndex = 19;
            panel4.Click += pn_Btn_Xoa_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.Location = new Point(73, 12);
            label9.Name = "label9";
            label9.Size = new Size(141, 25);
            label9.TabIndex = 24;
            label9.Text = "Hủy nhân viên";
            label9.Click += label9_Click;
            // 
            // pn_Btn_LamMoi
            // 
            pn_Btn_LamMoi.BackColor = Color.FromArgb(255, 255, 192);
            pn_Btn_LamMoi.Controls.Add(panel3);
            pn_Btn_LamMoi.Controls.Add(label8);
            pn_Btn_LamMoi.Location = new Point(673, 466);
            pn_Btn_LamMoi.Name = "pn_Btn_LamMoi";
            pn_Btn_LamMoi.Size = new Size(228, 50);
            pn_Btn_LamMoi.TabIndex = 15;
            pn_Btn_LamMoi.Click += pn_Btn_LamMoi_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(49, 44);
            panel3.TabIndex = 19;
            panel3.Click += pn_Btn_LamMoi_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.Location = new Point(95, 12);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 23;
            label8.Text = "Làm mới";
            label8.Click += label8_Click;
            // 
            // pn_Btn_Sua
            // 
            pn_Btn_Sua.BackColor = Color.FromArgb(255, 255, 192);
            pn_Btn_Sua.Controls.Add(panel2);
            pn_Btn_Sua.Controls.Add(label7);
            pn_Btn_Sua.Location = new Point(376, 466);
            pn_Btn_Sua.Name = "pn_Btn_Sua";
            pn_Btn_Sua.Size = new Size(228, 50);
            pn_Btn_Sua.TabIndex = 14;
            pn_Btn_Sua.Click += pn_Btn_Sua_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(49, 44);
            panel2.TabIndex = 19;
            panel2.Click += pn_Btn_Sua_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(56, 12);
            label7.Name = "label7";
            label7.Size = new Size(169, 25);
            label7.TabIndex = 22;
            label7.Text = "Update nhân viên";
            label7.Click += label7_Click;
            // 
            // pn_Btn_Them
            // 
            pn_Btn_Them.BackColor = Color.FromArgb(255, 255, 192);
            pn_Btn_Them.Controls.Add(panel1);
            pn_Btn_Them.Controls.Add(label6);
            pn_Btn_Them.Location = new Point(60, 466);
            pn_Btn_Them.Name = "pn_Btn_Them";
            pn_Btn_Them.Size = new Size(228, 50);
            pn_Btn_Them.TabIndex = 13;
            pn_Btn_Them.Click += pn_Btn_Them_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(49, 44);
            panel1.TabIndex = 19;
            panel1.Click += pn_Btn_Them_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(61, 12);
            label6.Name = "label6";
            label6.Size = new Size(153, 25);
            label6.TabIndex = 21;
            label6.Text = "Thêm nhân viên";
            label6.Click += label6_Click;
            // 
            // grb_DanhSach
            // 
            grb_DanhSach.Controls.Add(dtgView);
            grb_DanhSach.Location = new Point(673, 21);
            grb_DanhSach.Name = "grb_DanhSach";
            grb_DanhSach.Size = new Size(978, 329);
            grb_DanhSach.TabIndex = 12;
            grb_DanhSach.TabStop = false;
            grb_DanhSach.Text = "Danh sách nhân viên";
            // 
            // dtgView
            // 
            dtgView.BackgroundColor = Color.White;
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(6, 26);
            dtgView.Name = "dtgView";
            dtgView.RowHeadersWidth = 51;
            dtgView.Size = new Size(966, 297);
            dtgView.TabIndex = 0;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // grb_ThongTin
            // 
            grb_ThongTin.Controls.Add(label11);
            grb_ThongTin.Controls.Add(cbx_TrangThai);
            grb_ThongTin.Controls.Add(txt_EmailNV);
            grb_ThongTin.Controls.Add(label10);
            grb_ThongTin.Controls.Add(txt_SdtNv);
            grb_ThongTin.Controls.Add(label1);
            grb_ThongTin.Controls.Add(Cmb_ChucVu);
            grb_ThongTin.Controls.Add(txt_MatKhau);
            grb_ThongTin.Controls.Add(label5);
            grb_ThongTin.Controls.Add(txt_TaiKhoan);
            grb_ThongTin.Controls.Add(label4);
            grb_ThongTin.Controls.Add(label3);
            grb_ThongTin.Controls.Add(txt_TenNV);
            grb_ThongTin.Controls.Add(label2);
            grb_ThongTin.Location = new Point(27, 21);
            grb_ThongTin.Name = "grb_ThongTin";
            grb_ThongTin.Size = new Size(592, 329);
            grb_ThongTin.TabIndex = 11;
            grb_ThongTin.TabStop = false;
            grb_ThongTin.Text = "Thông tin nhân viên";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(65, 293);
            label11.Name = "label11";
            label11.Size = new Size(78, 20);
            label11.TabIndex = 26;
            label11.Text = "Trạng thái:";
            // 
            // cbx_TrangThai
            // 
            cbx_TrangThai.FormattingEnabled = true;
            cbx_TrangThai.Items.AddRange(new object[] { "Đang làm việc", "Đã nghỉ việc" });
            cbx_TrangThai.Location = new Point(190, 290);
            cbx_TrangThai.Name = "cbx_TrangThai";
            cbx_TrangThai.Size = new Size(331, 28);
            cbx_TrangThai.TabIndex = 25;
            // 
            // txt_EmailNV
            // 
            txt_EmailNV.Location = new Point(190, 155);
            txt_EmailNV.Name = "txt_EmailNV";
            txt_EmailNV.Size = new Size(331, 27);
            txt_EmailNV.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(64, 158);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 23;
            label10.Text = "Email:";
            // 
            // txt_SdtNv
            // 
            txt_SdtNv.Location = new Point(190, 111);
            txt_SdtNv.Name = "txt_SdtNv";
            txt_SdtNv.Size = new Size(331, 27);
            txt_SdtNv.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 114);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 21;
            label1.Text = "Số điện thoại:";
            // 
            // Cmb_ChucVu
            // 
            Cmb_ChucVu.BackColor = SystemColors.ButtonHighlight;
            Cmb_ChucVu.ForeColor = Color.Black;
            Cmb_ChucVu.Items.AddRange(new object[] { "Admin", "Nhân viên" });
            Cmb_ChucVu.Location = new Point(190, 67);
            Cmb_ChucVu.Name = "Cmb_ChucVu";
            Cmb_ChucVu.Size = new Size(331, 28);
            Cmb_ChucVu.TabIndex = 20;
            Cmb_ChucVu.Text = "---Chọn chức vụ---";
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(190, 244);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(331, 27);
            txt_MatKhau.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 247);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 18;
            label5.Text = "Mật khẩu:";
            // 
            // txt_TaiKhoan
            // 
            txt_TaiKhoan.Location = new Point(190, 199);
            txt_TaiKhoan.Name = "txt_TaiKhoan";
            txt_TaiKhoan.Size = new Size(331, 27);
            txt_TaiKhoan.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 202);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 16;
            label4.Text = "Tài khoản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 70);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 15;
            label3.Text = "Chức  vụ:";
            // 
            // txt_TenNV
            // 
            txt_TenNV.Location = new Point(190, 26);
            txt_TenNV.Name = "txt_TenNV";
            txt_TenNV.Size = new Size(331, 27);
            txt_TenNV.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 29);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 13;
            label2.Text = "Tên nhân viên:";
            // 
            // Form_NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pn_Form_NhanVien);
            Name = "Form_NhanVien";
            Text = "Form_NhanVien";
            pn_Form_NhanVien.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pn_Btn_Xoa.ResumeLayout(false);
            pn_Btn_Xoa.PerformLayout();
            pn_Btn_LamMoi.ResumeLayout(false);
            pn_Btn_LamMoi.PerformLayout();
            pn_Btn_Sua.ResumeLayout(false);
            pn_Btn_Sua.PerformLayout();
            pn_Btn_Them.ResumeLayout(false);
            pn_Btn_Them.PerformLayout();
            grb_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            grb_ThongTin.ResumeLayout(false);
            grb_ThongTin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Form_NhanVien;
        private GroupBox grb_ThongTin;
        private ComboBox Cmb_ChucVu;
        private TextBox txt_MatKhau;
        private Label label5;
        private TextBox txt_TaiKhoan;
        private Label label4;
        private Label label3;
        private TextBox txt_TenNV;
        private Label label2;
        private Panel pn_Btn_Xoa;
        private Panel pn_Btn_LamMoi;
        private Panel pn_Btn_Sua;
        private Panel pn_Btn_Them;
        private GroupBox grb_DanhSach;
        private DataGridView dtgView;
        private GroupBox groupBox1;
        private TextBox txt_Search;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label9;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private TextBox txt_SdtNv;
        private Label label1;
        private TextBox txt_EmailNV;
        private Label label10;
        private Label label11;
        private ComboBox cbx_TrangThai;
    }
}