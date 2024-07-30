namespace App.Winform.UI
{
    partial class Form_ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ForgotPass));
            btn_Login = new Button();
            pn_passicon = new Panel();
            pn_iconus = new Panel();
            tbx_email = new TextBox();
            label2 = new Label();
            btn_GuiMK = new Button();
            tbx_usn = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(255, 128, 0);
            btn_Login.Font = new Font("Times New Roman", 11F);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(258, 174);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(132, 40);
            btn_Login.TabIndex = 15;
            btn_Login.Text = "Đăng nhập";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // pn_passicon
            // 
            pn_passicon.BackColor = Color.Transparent;
            pn_passicon.BackgroundImage = (Image)resources.GetObject("pn_passicon.BackgroundImage");
            pn_passicon.BackgroundImageLayout = ImageLayout.Stretch;
            pn_passicon.Location = new Point(65, 132);
            pn_passicon.Name = "pn_passicon";
            pn_passicon.Size = new Size(30, 27);
            pn_passicon.TabIndex = 14;
            // 
            // pn_iconus
            // 
            pn_iconus.BackColor = Color.Transparent;
            pn_iconus.BackgroundImage = (Image)resources.GetObject("pn_iconus.BackgroundImage");
            pn_iconus.BackgroundImageLayout = ImageLayout.Stretch;
            pn_iconus.ForeColor = SystemColors.ActiveCaptionText;
            pn_iconus.Location = new Point(65, 67);
            pn_iconus.Name = "pn_iconus";
            pn_iconus.Size = new Size(30, 27);
            pn_iconus.TabIndex = 13;
            // 
            // tbx_email
            // 
            tbx_email.Location = new Point(101, 132);
            tbx_email.Name = "tbx_email";
            tbx_email.PlaceholderText = "Nhập email";
            tbx_email.Size = new Size(305, 27);
            tbx_email.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(101, 109);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 11;
            label2.Text = "Email";
            // 
            // btn_GuiMK
            // 
            btn_GuiMK.BackColor = Color.FromArgb(255, 128, 0);
            btn_GuiMK.Font = new Font("Times New Roman", 11F);
            btn_GuiMK.ForeColor = Color.White;
            btn_GuiMK.Location = new Point(113, 174);
            btn_GuiMK.Name = "btn_GuiMK";
            btn_GuiMK.Size = new Size(129, 40);
            btn_GuiMK.TabIndex = 12;
            btn_GuiMK.Text = "Gửi mật khẩu";
            btn_GuiMK.UseVisualStyleBackColor = false;
            btn_GuiMK.Click += btn_GuiMK_Click;
            // 
            // tbx_usn
            // 
            tbx_usn.Location = new Point(101, 67);
            tbx_usn.Name = "tbx_usn";
            tbx_usn.PlaceholderText = "Nhập tài khoản";
            tbx_usn.Size = new Size(305, 27);
            tbx_usn.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(101, 44);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 8;
            label1.Text = "Tài khoản";
            // 
            // Form_ForgotPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(482, 253);
            Controls.Add(btn_Login);
            Controls.Add(pn_passicon);
            Controls.Add(pn_iconus);
            Controls.Add(tbx_email);
            Controls.Add(label2);
            Controls.Add(btn_GuiMK);
            Controls.Add(tbx_usn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form_ForgotPass";
            Text = "Form_ForgotPass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private Panel pn_passicon;
        private Panel pn_iconus;
        private TextBox tbx_email;
        private Label label2;
        private Button btn_GuiMK;
        private TextBox tbx_usn;
        private Label label1;
    }
}