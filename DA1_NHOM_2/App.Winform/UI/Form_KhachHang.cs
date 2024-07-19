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
    public partial class Form_KhachHang : Form
    {
        KhachHang_Services _service;
        List<KhachHang> _listKH = new();
        Guid _idwhenclick;
        public Form_KhachHang(NhanVien nv)
        {
            InitializeComponent();
            _service = new KhachHang_Services();
            PhanQuyen_NhanVien(nv);
            LoadGird(null);
        }

        private void PhanQuyen_NhanVien(NhanVien nv)
        {
            if (nv.ChucVu.Equals("Nhân viên"))
            {
                pn_Btn_Xoa.Click -= pn_Btn_Xoa_Click;

                pn_Btn_Xoa.Click += NotClick;


                foreach (Control item in pn_Btn_Xoa.Controls)
                {
                    item.Click += NotClick;
                }


            }
        }

        private void NotClick(object sender, EventArgs e)
        {
            MessageBox.Show("Nhân viên không thể sử dụng chức năng này !");
        }

        public List<Control> Gekhtrl()
        {
            List<Control> ctrls = new List<Control>();

            foreach (Control ctrl in pn_Form_KhachHang.Controls)
            {
                ctrls.Add(ctrl);
            }
            return ctrls;
        }
        public void LoadGird(string search)
        {
            dtgView.Rows.Clear();
            dtgView.ColumnCount = 5;
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "Mã khách hàng";
            dtgView.Columns[2].Name = "Tên khách hàng";
            dtgView.Columns[3].Name = "Số Điện Thoại";
            dtgView.Columns[4].Name = "Điểm Tích Luỹ";


            _listKH = _service.GetAll(search);
            foreach (var nv in _service.GetAll(txtSearch.Text))
            {
                int stt = _listKH.IndexOf(nv) + 1;
                dtgView.Rows.Add(stt, nv.MaKhachHang, nv.TenKhachHang, nv.SoDienThoai, nv.TichLuy);
            }
            dtgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void pn_Btn_Them_Click(object sender, EventArgs e)
        {
            // Kiểm tra không cho phép để trống thông tin
            if (string.IsNullOrEmpty(txt_TenKH.Text) || string.IsNullOrEmpty(txt_SĐT.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_TenKH.Text) || txt_TenKH.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng không quá 50 ký tự.");
                return;
            }
            // Kiểm tra tên khách hàng không được rỗng
            if (string.IsNullOrWhiteSpace(txt_TenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.");
                return;
            }

            // Kiểm tra số điện thoại phải bắt đầu bằng số 0


            // Kiểm tra số điện thoại chỉ chứa số và có đúng 10 chữ số
            string phoneNumber = txt_SĐT.Text.Trim();
            Regex regex = new Regex(@"^\d{10}$");
            if (!regex.IsMatch(phoneNumber))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại chỉ chứa số và có đúng 10 chữ số.");
                return;
            }
            foreach (var existingKH in _listKH)
            {
                if (existingKH.SoDienThoai == phoneNumber)
                {
                    MessageBox.Show("Số điện thoại này đã tồn tại cho một khách hàng khác. Vui lòng nhập số điện thoại khác.");
                    return;
                }
            }
            // Kiểm tra số điện thoại phải bắt đầu từ số 0
            if (!phoneNumber.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0.");
                return;
            }
            if (!phoneNumber.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0.");
                return;
            }

            var kh = new KhachHang();
            kh.MaKhachHang = Guid.NewGuid();
            kh.Email = "test@gmail.com";
            kh.TenKhachHang = txt_TenKH.Text;
            kh.SoDienThoai = phoneNumber;
            kh.TichLuy = 0;

            var option = MessageBox.Show("Xác nhận muốn thêm khách hàng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Add(kh));
                LoadGird(null);
            }
            else
            {
                return;
            }
        }

        private void pn_Btn_Sua_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem đã chọn một khách hàng từ danh sách hay chưa
            if (string.IsNullOrEmpty(txt_MaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để sửa.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_TenKH.Text) || txt_TenKH.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng không quá 50 ký tự.");
                return;
            }
            // Tạo đối tượng khách hàng mới để lưu thông tin sửa đổi
            var kh = new KhachHang();
            kh.MaKhachHang = Guid.Parse(txt_MaKH.Text);
         
            kh.TenKhachHang = txt_TenKH.Text;
            kh.SoDienThoai = txt_SĐT.Text;
            kh.TichLuy = diemtichluy;

            if (!Regex.IsMatch(kh.TenKhachHang, "^[a-zA-Z ]+$"))
            {
                MessageBox.Show("Tên khách hàng chỉ được nhập chữ và dấu cách.");
                return;
            }
            
            // Kiểm tra số điện thoại có đúng 10 chữ số hay không
            if (kh.SoDienThoai.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số.");
                return;
            }
            // Kiểm tra số điện thoại đã tồn tại trong danh sách khách hàng khác hay không
            foreach (var existingKH in _listKH)
            {
                if (existingKH.SoDienThoai == kh.SoDienThoai && existingKH.MaKhachHang != kh.MaKhachHang)
                {
                    MessageBox.Show("Số điện thoại này đã tồn tại cho một khách hàng khác. Vui lòng nhập số điện thoại khác.");
                    return;
                }
            }

            var option = MessageBox.Show("Xác nhận muốn update khách hàng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Update(kh));
                LoadGird(null);
            }
            else
            {
                return;
            }
        }


        private void pn_Btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_MaKH.Text = "";
            txt_TenKH.Text = "";
            txt_SĐT.Text = "";
        }

        private void pn_Btn_Xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn một khách hàng từ danh sách hay chưa
            if (string.IsNullOrEmpty(txt_MaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.");
                return;
            }
            // Kiểm tra số điện thoại có bắt đầu từ số 0 hay không
            string phoneNumber = txt_SĐT.Text.Trim();
            if (!phoneNumber.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0.");
                return;
            }


            // Xác nhận xóa khách hàng
            var option = MessageBox.Show("Xác nhận muốn Xoá khách hàng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                var kh = new KhachHang();
                kh.MaKhachHang = _idwhenclick;

                MessageBox.Show(_service.Remove(kh));
                LoadGird(null);
            }
            else
            {
                return;
            }
        }



        private void label4_Click(object sender, EventArgs e)
        {
            pn_Btn_Them_Click(sender, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            pn_Btn_Sua_Click(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pn_Btn_LamMoi_Click(sender, e);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            pn_Btn_Xoa_Click(sender, e);
        }

        int? diemtichluy;
        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _listKH.Count)
            {
                return;
            }
            var obj = _listKH[index];
            _idwhenclick = obj.MaKhachHang;
            txt_MaKH.Text = obj.MaKhachHang.ToString();
            txt_TenKH.Text = obj.TenKhachHang;
            txt_SĐT.Text = obj.SoDienThoai.ToString();
            diemtichluy = obj.TichLuy;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGird(null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
