namespace C_PRL.UI
{
    partial class Form_HoaDon
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
            pn_Form_HoaDon = new Panel();
            groupBox2 = new GroupBox();
            dtg_DSHoaDonCT = new DataGridView();
            groupBox1 = new GroupBox();
            rbt_payed = new RadioButton();
            rbt_notpayed = new RadioButton();
            tbx_Search = new TextBox();
            dtg_DSHoaDon = new DataGridView();
            rbt_all = new RadioButton();
            pn_Form_HoaDon.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_DSHoaDonCT).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_DSHoaDon).BeginInit();
            SuspendLayout();
            // 
            // pn_Form_HoaDon
            // 
            pn_Form_HoaDon.BackColor = Color.FromArgb(255, 192, 192);
            pn_Form_HoaDon.Controls.Add(groupBox2);
            pn_Form_HoaDon.Controls.Add(groupBox1);
            pn_Form_HoaDon.Location = new Point(215, 60);
            pn_Form_HoaDon.Name = "pn_Form_HoaDon";
            pn_Form_HoaDon.Size = new Size(1689, 912);
            pn_Form_HoaDon.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtg_DSHoaDonCT);
            groupBox2.Location = new Point(9, 468);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1666, 322);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dtg_DSHoaDonCT
            // 
            dtg_DSHoaDonCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_DSHoaDonCT.BackgroundColor = Color.White;
            dtg_DSHoaDonCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_DSHoaDonCT.Location = new Point(6, 26);
            dtg_DSHoaDonCT.Name = "dtg_DSHoaDonCT";
            dtg_DSHoaDonCT.ReadOnly = true;
            dtg_DSHoaDonCT.RowHeadersWidth = 51;
            dtg_DSHoaDonCT.RowTemplate.Height = 29;
            dtg_DSHoaDonCT.Size = new Size(1654, 282);
            dtg_DSHoaDonCT.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbt_all);
            groupBox1.Controls.Add(rbt_payed);
            groupBox1.Controls.Add(rbt_notpayed);
            groupBox1.Controls.Add(tbx_Search);
            groupBox1.Controls.Add(dtg_DSHoaDon);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1672, 459);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn";
            // 
            // rbt_payed
            // 
            rbt_payed.AutoSize = true;
            rbt_payed.Location = new Point(861, 55);
            rbt_payed.Name = "rbt_payed";
            rbt_payed.Size = new Size(124, 24);
            rbt_payed.TabIndex = 5;
            rbt_payed.TabStop = true;
            rbt_payed.Text = "Đã thanh toán";
            rbt_payed.UseVisualStyleBackColor = true;
            // 
            // rbt_notpayed
            // 
            rbt_notpayed.AutoSize = true;
            rbt_notpayed.Location = new Point(696, 55);
            rbt_notpayed.Name = "rbt_notpayed";
            rbt_notpayed.Size = new Size(139, 24);
            rbt_notpayed.TabIndex = 4;
            rbt_notpayed.TabStop = true;
            rbt_notpayed.Text = "Chưa thanh toán";
            rbt_notpayed.UseVisualStyleBackColor = true;
            // 
            // tbx_Search
            // 
            tbx_Search.Location = new Point(19, 51);
            tbx_Search.Name = "tbx_Search";
            tbx_Search.PlaceholderText = "Tìm kiếm";
            tbx_Search.Size = new Size(260, 27);
            tbx_Search.TabIndex = 1;
            tbx_Search.TextChanged += tbx_Search_TextChanged;
            // 
            // dtg_DSHoaDon
            // 
            dtg_DSHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_DSHoaDon.BackgroundColor = Color.White;
            dtg_DSHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_DSHoaDon.Location = new Point(6, 96);
            dtg_DSHoaDon.Name = "dtg_DSHoaDon";
            dtg_DSHoaDon.ReadOnly = true;
            dtg_DSHoaDon.RowHeadersWidth = 51;
            dtg_DSHoaDon.RowTemplate.Height = 29;
            dtg_DSHoaDon.Size = new Size(1660, 357);
            dtg_DSHoaDon.TabIndex = 0;
            dtg_DSHoaDon.CellClick += dtg_DSHoaDon_CellClick;
            // 
            // rbt_all
            // 
            rbt_all.AutoSize = true;
            rbt_all.Location = new Point(562, 55);
            rbt_all.Name = "rbt_all";
            rbt_all.Size = new Size(70, 24);
            rbt_all.TabIndex = 6;
            rbt_all.TabStop = true;
            rbt_all.Text = "Tất cả";
            rbt_all.UseVisualStyleBackColor = true;
            // 
            // Form_HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 971);
            Controls.Add(pn_Form_HoaDon);
            Name = "Form_HoaDon";
            Text = "Form_HoaDon";
            Load += Form_HoaDon_Load;
            pn_Form_HoaDon.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_DSHoaDonCT).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_DSHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Form_HoaDon;
        private GroupBox groupBox2;
        private DataGridView dtg_DSHoaDonCT;
        private GroupBox groupBox1;
        private RadioButton rbt_payed;
        private RadioButton rbt_notpayed;
        private TextBox tbx_Search;
        private DataGridView dtg_DSHoaDon;
        private RadioButton rbt_all;
    }
}