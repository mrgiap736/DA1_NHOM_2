﻿using App.Data.Entities;
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
        HoaDon_Services _hdsv;
        List<KhachHang> _listKH = new();
        Guid _idwhenclick = Guid.Parse("00000000-0000-0000-0000-000000000000");
        public Form_KhachHang(NhanVien nv)
        {
            InitializeComponent();
            _service = new KhachHang_Services();
            _hdsv = new HoaDon_Services();
            PhanQuyen_NhanVien(nv);
            LoadGrid(null);
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
        public void LoadGrid(string search)
        {
            dtgView.Rows.Clear();
            dtgView.ColumnCount = 6;
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[0].Width = 40;
            dtgView.Columns[1].Name = "Mã khách hàng";
            dtgView.Columns[1].Visible = false;
            dtgView.Columns[2].Name = "Tên khách hàng";
            dtgView.Columns[3].Name = "Số Điện Thoại";
            dtgView.Columns[4].Name = "Email";
            dtgView.Columns[5].Name = "Tổng giá trị mua hàng";


            _listKH = _service.GetAll(search);
            foreach (var kh in _service.GetAll(txtSearch.Text))
            {
                int tichluy = 0;
                List<HoaDon> lst = _hdsv.SearchByNameKH(kh.TenKhachHang);

                if(lst != null)
                {
                    foreach (var item in lst)
                    {
                        tichluy = tichluy + item.TongTien;
                    }
                }

                int stt = _listKH.IndexOf(kh) + 1;
                dtgView.Rows.Add(stt, kh.MaKhachHang, kh.TenKhachHang, kh.SoDienThoai, kh.Email, _hdsv.AddThousandSeparators(tichluy) + " VND");
            }
            dtgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void ResetInput()
        {
            txt_SĐT.Text = "";
            txt_Email.Text = "";
            txt_TenKH.Text = "";
            txtSearch.Text = "";
        }

        public bool CheckExistPhone(string phoneNumber)
        {
            bool check = true;

            foreach (var existingKH in _service.GetAll(null))
            {
                if (existingKH.SoDienThoai == phoneNumber)
                {
                    MessageBox.Show("Số điện thoại này đã tồn tại cho một khách hàng khác. Vui lòng nhập số điện thoại khác.");
                    check = false;
                }
            }

            return check;
        }

        public bool CheckExistEmail(string email)
        {
            bool check = true;

            foreach (var existingKH in _service.GetAll(null))
            {
                if (existingKH.Email == email)
                {
                    MessageBox.Show("Email này đã tồn tại cho một khách hàng khác. Vui lòng nhập email khác.");
                    check = false;
                }
            }

            return check;
        }

        private bool Validate()
        {
            bool check = true;
            // Kiểm tra không cho phép để trống thông tin
            if (string.IsNullOrEmpty(txt_TenKH.Text) || string.IsNullOrEmpty(txt_SĐT.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                check = false;
            }
            else
            {
                // Kiểm tra tên khách hàng không được rỗng
                if (string.IsNullOrWhiteSpace(txt_TenKH.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng.");
                    check = false;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txt_TenKH.Text) || txt_TenKH.Text.Length > 50)
                    {
                        MessageBox.Show("Vui lòng nhập tên khách hàng không quá 50 ký tự.");
                        check = false;
                    }
                }

                // Kiểm tra số điện thoại phải bắt đầu bằng số 0


                // Kiểm tra số điện thoại chỉ chứa số và có đúng 10 chữ số
                string phoneNumber = txt_SĐT.Text.Trim();
                string email = txt_Email.Text.ToLower().Trim();

                Regex regex = new Regex(@"^\d{10}$");
                string pattern = @"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,6}$";
                Regex regexemail = new Regex(pattern);

                if (!regexemail.IsMatch(email))
                {
                    MessageBox.Show("Email không hợp lệ");
                    check = false;
                }
                if (!regex.IsMatch(phoneNumber))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại chỉ chứa số và có đúng 10 chữ số.");
                    check = false;
                }
                else
                {
                    // Kiểm tra số điện thoại phải bắt đầu từ số 0
                    if (!phoneNumber.StartsWith("0"))
                    {
                        MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0.");
                        check = false;
                    }
                }
            }

            return check;
        }

        private void pn_Btn_Them_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                if(CheckExistEmail(txt_Email.Text.Trim().ToLower()) && CheckExistPhone(txt_SĐT.Text.Trim()))
                {
                    var kh = new KhachHang();
                    kh.MaKhachHang = Guid.NewGuid();
                    kh.Email = txt_Email.Text.Trim().ToLower();
                    kh.TenKhachHang = txt_TenKH.Text.Trim();
                    kh.SoDienThoai = txt_SĐT.Text.Trim();
                    kh.TichLuy = 0;

                    var option = MessageBox.Show("Xác nhận muốn thêm khách hàng?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (option == DialogResult.Yes)
                    {
                        MessageBox.Show(_service.Add(kh));
                        LoadGrid(null);
                        ResetInput();
                    }
                    else
                    {
                        return;
                    }
                }           
            }
        }

        private void pn_Btn_Sua_Click(object sender, EventArgs e)
        {
            KhachHang kh = null;

            // Kiểm tra xem đã chọn một khách hàng từ danh sách hay chưa
            if (_idwhenclick == Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để sửa.");
                return;
            }
            else
            {
                List<KhachHang> lst = _service.GetAll(null);

                kh = lst.FirstOrDefault(x => x.MaKhachHang == _idwhenclick);
            }

            if (kh != null)
            {
                if (Validate())
                {
                    kh.TenKhachHang = txt_TenKH.Text;

                    if (kh.Email != txt_Email.Text)
                    {
                        if (CheckExistEmail(txt_Email.Text)) 
                        {
                            kh.Email = txt_Email.Text;
                        }
                    }

                    if (kh.SoDienThoai != txt_SĐT.Text)
                    {
                        if (CheckExistPhone(txt_SĐT.Text))
                        {
                            kh.SoDienThoai = txt_SĐT.Text;
                        }
                    }


                    if (!Regex.IsMatch(kh.TenKhachHang, "^[a-zA-Z ]+$"))
                    {
                        MessageBox.Show("Tên khách hàng chỉ được nhập chữ và dấu cách.");
                        return;
                    }


                    var option = MessageBox.Show("Xác nhận muốn update khách hàng?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (option == DialogResult.Yes)
                    {
                        MessageBox.Show(_service.Update(kh));
                        LoadGrid(null);
                        ResetInput();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }


        private void pn_Btn_LamMoi_Click(object sender, EventArgs e)
        {
            LoadGrid(null);
            ResetInput();

        }

        private void pn_Btn_Xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn một khách hàng từ danh sách hay chưa
            if (_idwhenclick == Guid.Parse("00000000-0000-0000-0000-000000000000"))
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
                LoadGrid(null);
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
            txt_TenKH.Text = obj.TenKhachHang;
            txt_SĐT.Text = obj.SoDienThoai.ToString();
            txt_Email.Text = obj.Email;
            diemtichluy = obj.TichLuy;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(null);
        }


        private void txt_SĐT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
