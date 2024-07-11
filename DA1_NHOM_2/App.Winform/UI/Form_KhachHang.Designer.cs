namespace App.Winform.UI
{
    partial class Form_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_KhachHang));
            pn_Form_KhachHang = new Panel();
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            pn_Btn_Xoa = new Panel();
            panel4 = new Panel();
            label7 = new Label();
            pn_Btn_LamMoi = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            pn_Btn_Sua = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            pn_Btn_Them = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            grb_DanhSach = new GroupBox();
            dtgView = new DataGridView();
            grb_ThongTin = new GroupBox();
            txt_SĐT = new TextBox();
            label3 = new Label();
            txt_TenKH = new TextBox();
            label2 = new Label();
            txt_MaKH = new TextBox();
            label1 = new Label();
            pn_Form_KhachHang.SuspendLayout();
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
            // pn_Form_KhachHang
            // 
            pn_Form_KhachHang.BackColor = Color.FromArgb(255, 192, 192);
            pn_Form_KhachHang.Controls.Add(groupBox1);
            pn_Form_KhachHang.Controls.Add(pn_Btn_Xoa);
            pn_Form_KhachHang.Controls.Add(pn_Btn_LamMoi);
            pn_Form_KhachHang.Controls.Add(pn_Btn_Sua);
            pn_Form_KhachHang.Controls.Add(pn_Btn_Them);
            pn_Form_KhachHang.Controls.Add(grb_DanhSach);
            pn_Form_KhachHang.Controls.Add(grb_ThongTin);
            pn_Form_KhachHang.Location = new Point(215, 60);
            pn_Form_KhachHang.Name = "pn_Form_KhachHang";
            pn_Form_KhachHang.Size = new Size(1689, 912);
            pn_Form_KhachHang.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Location = new Point(673, 356);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 64);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Mời nhập Tên/ SĐT khách hàng cần tìm?";
            txtSearch.Size = new Size(473, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pn_Btn_Xoa
            // 
            pn_Btn_Xoa.BackColor = Color.FromArgb(255, 255, 192);
            pn_Btn_Xoa.Controls.Add(panel4);
            pn_Btn_Xoa.Controls.Add(label7);
            pn_Btn_Xoa.Location = new Point(927, 477);
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
            panel4.TabIndex = 21;
            panel4.Click += pn_Btn_Xoa_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(62, 12);
            label7.Name = "label7";
            label7.Size = new Size(153, 25);
            label7.TabIndex = 20;
            label7.Text = "Xoá khách hàng";
            label7.Click += label7_Click;
            // 
            // pn_Btn_LamMoi
            // 
            pn_Btn_LamMoi.BackColor = Color.FromArgb(255, 255, 192);
            pn_Btn_LamMoi.Controls.Add(panel3);
            pn_Btn_LamMoi.Controls.Add(label6);
            pn_Btn_LamMoi.Location = new Point(644, 477);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(87, 12);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 19;
            label6.Text = "làm mới";
            label6.Click += label6_Click;
            // 
            // pn_Btn_Sua
            // 
            pn_Btn_Sua.BackColor = Color.FromArgb(255, 255, 192);
            pn_Btn_Sua.Controls.Add(panel2);
            pn_Btn_Sua.Controls.Add(label5);
            pn_Btn_Sua.Location = new Point(347, 477);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(62, 12);
            label5.Name = "label5";
            label5.Size = new Size(153, 25);
            label5.TabIndex = 18;
            label5.Text = "Sửa khách hàng";
            label5.Click += label5_Click;
            // 
            // pn_Btn_Them
            // 
            pn_Btn_Them.BackColor = Color.FromArgb(255, 255, 192);
            pn_Btn_Them.Controls.Add(panel1);
            pn_Btn_Them.Controls.Add(label4);
            pn_Btn_Them.Location = new Point(48, 477);
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
            panel1.TabIndex = 18;
            panel1.Click += pn_Btn_Them_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(58, 12);
            label4.Name = "label4";
            label4.Size = new Size(168, 25);
            label4.TabIndex = 17;
            label4.Text = "Thêm khách hàng";
            label4.Click += label4_Click;
            // 
            // grb_DanhSach
            // 
            grb_DanhSach.Controls.Add(dtgView);
            grb_DanhSach.Location = new Point(673, 21);
            grb_DanhSach.Name = "grb_DanhSach";
            grb_DanhSach.Size = new Size(978, 329);
            grb_DanhSach.TabIndex = 12;
            grb_DanhSach.TabStop = false;
            grb_DanhSach.Text = "Danh sách khách hàng";
            // 
            // dtgView
            // 
            dtgView.BackgroundColor = Color.White;
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(6, 26);
            dtgView.Name = "dtgView";
            dtgView.RowHeadersWidth = 51;
            dtgView.RowTemplate.Height = 29;
            dtgView.Size = new Size(966, 297);
            dtgView.TabIndex = 0;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // grb_ThongTin
            // 
            grb_ThongTin.Controls.Add(txt_SĐT);
            grb_ThongTin.Controls.Add(label3);
            grb_ThongTin.Controls.Add(txt_TenKH);
            grb_ThongTin.Controls.Add(label2);
            grb_ThongTin.Controls.Add(txt_MaKH);
            grb_ThongTin.Controls.Add(label1);
            grb_ThongTin.Location = new Point(27, 21);
            grb_ThongTin.Name = "grb_ThongTin";
            grb_ThongTin.Size = new Size(592, 329);
            grb_ThongTin.TabIndex = 11;
            grb_ThongTin.TabStop = false;
            grb_ThongTin.Text = "Thông tin nhân viên";
            // 
            // txt_SĐT
            // 
            txt_SĐT.Location = new Point(174, 161);
            txt_SĐT.Name = "txt_SĐT";
            txt_SĐT.Size = new Size(331, 27);
            txt_SĐT.TabIndex = 16;
            //txt_SĐT.TextChanged += this.txt_SĐT_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 164);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 15;
            label3.Text = "Số điện thoại:";
            //label3.Click += this.label3_Click;
            // 
            // txt_TenKH
            // 
            txt_TenKH.Location = new Point(174, 115);
            txt_TenKH.Name = "txt_TenKH";
            txt_TenKH.Size = new Size(331, 27);
            txt_TenKH.TabIndex = 14;
            //txt_TenKH.TextChanged += this.txt_TenKH_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 118);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 13;
            label2.Text = "Tên khách hàng:";
            //label2.Click += this.label2_Click;
            // 
            // txt_MaKH
            // 
            txt_MaKH.Enabled = false;
            txt_MaKH.Location = new Point(174, 71);
            txt_MaKH.Name = "txt_MaKH";
            txt_MaKH.Size = new Size(331, 27);
            txt_MaKH.TabIndex = 12;
            //txt_MaKH.TextChanged += this.txt_MaKH_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 74);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 11;
            label1.Text = "Mã khách hàng:";
            label1.Click += label1_Click;
            // 
            // Form_KhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 840);
            Controls.Add(pn_Form_KhachHang);
            Name = "Form_KhachHang";
            Text = "Form_KhachHang";
            pn_Form_KhachHang.ResumeLayout(false);
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

        private Panel pn_Form_KhachHang;
        private GroupBox groupBox1;
        private TextBox txtSearch;
        private Panel pn_Btn_Xoa;
        private Panel pn_Btn_LamMoi;
        private Panel pn_Btn_Sua;
        private Panel pn_Btn_Them;
        private GroupBox grb_DanhSach;
        private DataGridView dtgView;
        private GroupBox grb_ThongTin;
        private TextBox txt_SĐT;
        private Label label3;
        private TextBox txt_TenKH;
        private Label label2;
        private TextBox txt_MaKH;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
    }
}