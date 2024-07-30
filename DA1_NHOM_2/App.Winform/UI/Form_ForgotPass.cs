using App.Data.Entities;
using App.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace App.Winform.UI
{
    public partial class Form_ForgotPass : Form
    {
        Login_Services _sv;
        NhanVien_Services _nvsv;
        public Form_ForgotPass()
        {
            InitializeComponent();
            _sv = new Login_Services();
            _nvsv = new NhanVien_Services();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Form_DangNhap fd = new Form_DangNhap();

            fd.FormBorderStyle = FormBorderStyle.None;
            fd.TopLevel = false;
            fd.Dock = DockStyle.Fill;

            this.Controls.Add(fd);
            fd.Show();
        }

        private void btn_GuiMK_Click(object sender, EventArgs e)
        {
            string toE = tbx_email.Text;
            List<NhanVien> lst = _nvsv.GetAll(null);

            var nv = lst.FirstOrDefault(x => x.Email.Equals(tbx_email.Text.Trim()) && x.TaiKhoan.Equals(tbx_usn.Text.Trim()));

            if (nv == null)
            {
                MessageBox.Show("Email không tồn tại");
                return;
            }

            _sv.ForgotPass(toE, NewPass(nv));
        }

        private string NewPass(NhanVien nv)
        {
            Random rd = new Random();
            int r1 = rd.Next(10000,99999);

            nv.MatKhau = r1.ToString();

            _nvsv.Update(nv);

            return r1.ToString();
        }


    }
}
