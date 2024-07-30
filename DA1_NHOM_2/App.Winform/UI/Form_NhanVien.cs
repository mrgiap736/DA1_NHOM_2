using App.Data.Entities;
using App.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Winform.UI
{
    public partial class Form_NhanVien : Form
    {
        NhanVien _nv;
        NhanVien_Services _service;
        List<NhanVien> _listNV = new();
        Guid _idwhenclick = Guid.Parse("00000000-0000-0000-0000-000000000000");
        public Form_NhanVien(NhanVien nv)
        {
            InitializeComponent();
            _nv = nv;
            _service = new NhanVien_Services();
            LoadGird(null);
            Cmb_ChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_ChucVu.SelectedIndex = 1;

        }
        public List<Control> GetCtrl()
        {
            List<Control> ctrls = new List<Control>();

            foreach (Control ctrl in pn_Form_NhanVien.Controls)
            {
                ctrls.Add(ctrl);
            }
            return ctrls;
        }
        public void LoadGird(string search)
        {
            dtgView.Rows.Clear();
            dtgView.ColumnCount = 11;
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[0].Width = 40;
            dtgView.Columns[1].Name = "Mã Nhân Viên";
            dtgView.Columns[1].Visible = false;
            dtgView.Columns[2].Name = "Tên Nhân Viên";
            dtgView.Columns[3].Name = "Chức vụ";
            dtgView.Columns[4].Name = "Số điện thoại";
            dtgView.Columns[5].Name = "Email";
            dtgView.Columns[6].Name = "Tài khoản";
            dtgView.Columns[7].Name = "Mật khẩu";
            dtgView.Columns[8].Name = "Ngày bắt đầu";
            dtgView.Columns[9].Name = "Ngày kết thúc";
            dtgView.Columns[10].Name = "Trạng thái";

            _listNV = _service.GetAll(search);
            foreach (var nv in _service.GetAll(txt_Search.Text))
            {
                int stt = _listNV.IndexOf(nv) + 1;
                string matkhau = "******";
                if(nv.MatKhau == _nv.MatKhau)
                {
                    matkhau = nv.MatKhau;
                }
                dtgView.Rows.Add(stt, nv.MaNhanVien, nv.TenNhanVien, nv.ChucVu, nv.SoDienThoai, nv.Email, nv.TaiKhoan, matkhau,nv.NgayBatDau.ToShortDateString(), nv.NgayKetThuc, nv.TrangThai);
            }
            dtgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void ResetInput()
        {
            txt_TenNV.Text = "";
            txt_SdtNv.Text = "";
            txt_EmailNV.Text = "";
            txt_TaiKhoan.Text = "";
            txt_MatKhau.Text = "";
        }

        private void pn_Btn_Them_Click(object sender, EventArgs e)
        {
            if (Cmb_ChucVu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ.");
                return;
            }
            if (string.IsNullOrEmpty(txt_TenNV.Text) ||
                string.IsNullOrEmpty(txt_TaiKhoan.Text) ||
                string.IsNullOrEmpty(txt_MatKhau.Text)  ||
                string.IsNullOrEmpty(txt_EmailNV.Text)  ||
                string.IsNullOrEmpty(txt_SdtNv.Text))

            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }


            // Kiểm tra tên nhân viên có chứa số không
            if (Regex.IsMatch(txt_TenNV.Text, @"\d"))
            {
                MessageBox.Show("Tên nhân viên không được chứa số.");
                return;
            }

            // Kiểm tra độ dài của tên nhân viên
            if (txt_TenNV.Text.Length > 50)
            {
                MessageBox.Show("Tên nhân viên chỉ được nhập tối đa 50 ký tự.");
                return;
            }

            if (txt_TaiKhoan.Text.Length > 20 || txt_MatKhau.Text.Length > 20)
            {
                MessageBox.Show("Tài khoản và mật khẩu chỉ được nhập tối đa 20 ký tự.");
                return;
            }
            if (Regex.IsMatch(txt_TenNV.Text, @"\d"))
            {
                MessageBox.Show("Tên nhân viên không được chứa số.");
                return;
            }
            string selectedValue = Cmb_ChucVu.SelectedItem.ToString();
            var option = MessageBox.Show("Xác nhận muốn thêm nhân viên?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                var nv = new NhanVien
                {
                    MaNhanVien = Guid.NewGuid(),
                    TenNhanVien = txt_TenNV.Text,
                    ChucVu = selectedValue,
                    SoDienThoai = txt_SdtNv.Text,
                    Email = txt_EmailNV.Text,
                    TaiKhoan = txt_TaiKhoan.Text,
                    MatKhau = txt_MatKhau.Text,
                    NgayBatDau = DateTime.Now,
                    TrangThai = "Đang làm việc"
                };

                string result = _service.Add(nv);
                MessageBox.Show(result);
                LoadGird(null);

                ResetInput();
            }
        }


        private void pn_Btn_Sua_Click(object sender, EventArgs e)
        {
            if (_idwhenclick == Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                MessageBox.Show("Vui lòng chọn một Nhân Viên để sửa.");
                return;
            }
            if (Regex.IsMatch(txt_TenNV.Text, @"\d"))
            {
                MessageBox.Show("Tên nhân viên không được chứa số.");
                return;
            }

            // Kiểm tra tên nhân viên có chứa số không
            if (Regex.IsMatch(txt_TenNV.Text, @"\d"))
            {
                MessageBox.Show("Tên nhân viên không được chứa số.");
                return;
            }

            // Kiểm tra độ dài của tên nhân viên
            if (txt_TenNV.Text.Length > 50)
            {
                MessageBox.Show("Tên nhân viên chỉ được nhập tối đa 50 ký tự.");
                return;
            }

            if (Cmb_ChucVu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ.");
                return;
            }
            if (txt_TaiKhoan.Text.Length > 20 || txt_MatKhau.Text.Length > 20)
            {
                MessageBox.Show("Tài khoản và mật khẩu chỉ được nhập tối đa 20 ký tự.");
                return;
            }


            if (string.IsNullOrEmpty(txt_TenNV.Text) ||
                string.IsNullOrEmpty(txt_TaiKhoan.Text) ||
                string.IsNullOrEmpty(txt_MatKhau.Text) ||
                string.IsNullOrEmpty(txt_EmailNV.Text) ||
                string.IsNullOrEmpty(txt_SdtNv.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }

            // Lấy giá trị của ComboBox Chức vụ đã chọn
            string selectedValue = Cmb_ChucVu.SelectedItem.ToString();

            var option = MessageBox.Show("Xác nhận muốn sửa nhân viên?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                var nv = new NhanVien
                {
                    MaNhanVien = _idwhenclick,
                    TenNhanVien = txt_TenNV.Text,
                    ChucVu = selectedValue, // Gán giá trị từ ComboBox Chức vụ
                    SoDienThoai = txt_SdtNv.Text,
                    Email = txt_EmailNV.Text,
                    TaiKhoan = txt_TaiKhoan.Text,
                    MatKhau = txt_MatKhau.Text
                };

                string result = _service.Update(nv);
                MessageBox.Show(result);

                // Cập nhật lại danh sách nhân viên trên giao diện
                LoadGird(null);

                ResetInput();
            }
        }




        private void pn_Btn_Xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn một nhân viên từ danh sách hay chưa
            if (_idwhenclick == Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để hủy.");
                return;
            }

            var nv = new NhanVien();
            nv.MaNhanVien = _idwhenclick;

            var option = MessageBox.Show("Xác nhận muốn hủy nhân viên?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Remove(nv));
                LoadGird(null);
            }
            else
            {
                return;
            }
        }


        private void pn_Btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_TenNV.Text = "";
            Cmb_ChucVu.Text = "";
            txt_TaiKhoan.Text = "";
            txt_MatKhau.Text = "";
        }

        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _listNV.Count)
            {
                return;
            }
            var obj = _listNV[index];
            _idwhenclick = obj.MaNhanVien;
            txt_TenNV.Text = obj.TenNhanVien;
            Cmb_ChucVu.Text = obj.ChucVu;
            txt_EmailNV.Text = obj.Email;
            txt_SdtNv.Text = obj.SoDienThoai;
            txt_TaiKhoan.Text = obj.TaiKhoan;

            string matkhau = "";
            if(obj.MaNhanVien == _nv.MaNhanVien)
            {
                matkhau = obj.MatKhau;
            }
            txt_MatKhau.Text = matkhau;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pn_Btn_Them_Click(sender, e);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            pn_Btn_Sua_Click(sender, e);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            pn_Btn_LamMoi_Click(sender, e);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            pn_Btn_Xoa_Click(sender, e);
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            LoadGird(null);
        }
    }
}
