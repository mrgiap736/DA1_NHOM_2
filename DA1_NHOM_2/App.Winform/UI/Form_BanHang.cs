using App.Data.Data;
using App.Data.Entities;
using App.Data.Repos;
using App.Services.Services;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace App.Winform.UI
{
    public partial class Form_BanHang : Form
    {
        BanHang_Services _bhsv;
        HoaDon_Services hdsv;
        KhachHang_Services khsv;
        ChiTietHD_Services ctsv;

        NhanVien nvien;
        KhachHang kHang;

        public Form_BanHang(NhanVien? nv)
        {

            InitializeComponent();

            _bhsv = new BanHang_Services();
            hdsv = new HoaDon_Services();
            ctsv = new ChiTietHD_Services();
            khsv = new KhachHang_Services();

            GetCtrl();

            LoadCBX1();
            LoadCBX2();

            cbx_Filter1.SelectedIndexChanged += cbx_Filter_SelectedIndexChanged;
            cbx_Filter2.SelectedIndexChanged += cbx_Filter_SelectedIndexChanged;
            //Lấy mã nhân viên từ tk pw đăng nhập vào app

            if (nv == null)
            {
                nvien = null;
            }
            else nvien = nv;
            
        }
       

        private void PhanQuyen_NhanVien(NhanVien nvien)
        {
            if (nvien.ChucVu.Equals("Nhân viên"))
            {
                pn_NhanVien.Click -= pn_NhanVien_Click;

                foreach (Control item in pn_NhanVien.Controls)
                {
                    item.Click -= pn_NhanVien_Click;

                    item.Click += NotClick;
                }

                pn_DSChucNang.Controls.Remove(pn_NhanVien);
                pn_DSChucNang.Controls.Remove(pn_SanPham);
                pn_DSChucNang.Controls.Remove(pn_ThongKe);

                pn_KhachHang.Location = new Point(0, 279);

            }
        }
        //Su kien thong bao nhan vien k dc phep su dung chuc nang
        private void NotClick(object sender, EventArgs e)
        {
            MessageBox.Show("Nhân viên không thể sử dụng chức năng này !");
        }

        #region chuyển panel


        List<Control> _lstCtrl = new List<Control>();
        public List<Control> GetCtrl()
        {
            foreach (Control item in pn_Form_BanHang.Controls)
            {
                _lstCtrl.Add(item);
            }

            return _lstCtrl;
        }
        private void pn_BanHang_Click(object sender, EventArgs e)
        {
            lb_TenChucNang.Text = "QUẢN LÝ BÁN HÀNG";
            pn_Form_BanHang.Controls.Clear();

            foreach (Control item in GetCtrl())
            {
                pn_Form_BanHang.Controls.Add(item);
            }

            pn_HoaDon.BackColor = Color.FromArgb(45, 149, 150);
            pn_KhachHang.BackColor = Color.FromArgb(45, 149, 150);
            pn_NhanVien.BackColor = Color.FromArgb(45, 149, 150);
            pn_SanPham.BackColor = Color.FromArgb(45, 149, 150);
            pn_BanHang.BackColor = Color.FromArgb(38, 80, 115);
            pn_ThongKe.BackColor = Color.FromArgb(45, 149, 150);
        }

        private void pn_HoaDon_Click(object sender, EventArgs e)
        {
            lb_TenChucNang.Text = "QUẢN LÝ HÓA ĐƠN";
            pn_Form_BanHang.Controls.Clear();

            Form_HoaDon form = new Form_HoaDon();

            foreach (var item in form.GetCtrl())
            {
                pn_Form_BanHang.Controls.Add(item);
            }

            pn_HoaDon.BackColor = Color.FromArgb(38, 80, 115);
            pn_KhachHang.BackColor = Color.FromArgb(45, 149, 150);
            pn_NhanVien.BackColor = Color.FromArgb(45, 149, 150);
            pn_SanPham.BackColor = Color.FromArgb(45, 149, 150);
            pn_BanHang.BackColor = Color.FromArgb(45, 149, 150);
            pn_ThongKe.BackColor = Color.FromArgb(45, 149, 150);
        }

        private void pn_SanPham_Click(object sender, EventArgs e)
        {
            lb_TenChucNang.Text = "QUẢN LÝ SẢN PHẨM";
            pn_Form_BanHang.Controls.Clear();

            Form_SanPham form = new Form_SanPham(nvien);

            foreach (var item in form.GetCtrl())
            {
                pn_Form_BanHang.Controls.Add(item);
            }

            pn_HoaDon.BackColor = Color.FromArgb(45, 149, 150);
            pn_KhachHang.BackColor = Color.FromArgb(45, 149, 150);
            pn_NhanVien.BackColor = Color.FromArgb(45, 149, 150);
            pn_SanPham.BackColor = Color.FromArgb(38, 80, 115);
            pn_BanHang.BackColor = Color.FromArgb(45, 149, 150);
            pn_ThongKe.BackColor = Color.FromArgb(45, 149, 150);
        }

        private void pn_KhachHang_Click(object sender, EventArgs e)
        {
            lb_TenChucNang.Text = "QUẢN LÝ KHÁCH HÀNG";
            pn_Form_BanHang.Controls.Clear();

            Form_KhachHang form = new Form_KhachHang(nvien);

            foreach (var item in form.Gekhtrl())
            {
                pn_Form_BanHang.Controls.Add(item);
            }

            pn_HoaDon.BackColor = Color.FromArgb(45, 149, 150);
            pn_KhachHang.BackColor = Color.FromArgb(38, 80, 115);
            pn_NhanVien.BackColor = Color.FromArgb(45, 149, 150);
            pn_SanPham.BackColor = Color.FromArgb(45, 149, 150);
            pn_BanHang.BackColor = Color.FromArgb(45, 149, 150);
            pn_ThongKe.BackColor = Color.FromArgb(45, 149, 150);
        }

        private void pn_NhanVien_Click(object sender, EventArgs e)
        {
            lb_TenChucNang.Text = "QUẢN LÝ NHÂN VIÊN";
            pn_Form_BanHang.Controls.Clear();

            Form_NhanVien form = new Form_NhanVien();

            foreach (var item in form.GetCtrl())
            {
                pn_Form_BanHang.Controls.Add(item);
            }

            pn_HoaDon.BackColor = Color.FromArgb(45, 149, 150);
            pn_KhachHang.BackColor = Color.FromArgb(45, 149, 150);
            pn_NhanVien.BackColor = Color.FromArgb(38, 80, 115);
            pn_SanPham.BackColor = Color.FromArgb(45, 149, 150);
            pn_BanHang.BackColor = Color.FromArgb(45, 149, 150);
            pn_ThongKe.BackColor = Color.FromArgb(45, 149, 150);
        }

        private void pn_ThongKe_Click(object sender, EventArgs e)
        {
            lb_TenChucNang.Text = "THỐNG KÊ";
            pn_Form_BanHang.Controls.Clear();

            Form_ThongKe form = new Form_ThongKe();

            foreach (var item in form.GetCtrl())
            {
                pn_Form_BanHang.Controls.Add(item);
            }

            pn_HoaDon.BackColor = Color.FromArgb(45, 149, 150);
            pn_KhachHang.BackColor = Color.FromArgb(45, 149, 150);
            pn_NhanVien.BackColor = Color.FromArgb(45, 149, 150);
            pn_SanPham.BackColor = Color.FromArgb(45, 149, 150);
            pn_BanHang.BackColor = Color.FromArgb(45, 149, 150);
            pn_ThongKe.BackColor = Color.FromArgb(38, 80, 115);
        }
        #endregion


        #region Load data
        private void Form_BanHang_Load(object sender, EventArgs e)
        {
            //Phân quyền chức năng trước khi thao tác
            PhanQuyen_NhanVien(nvien);
            //

            if (nvien == null)
            {
                lb_NameNV.Text = "Đang bảo trì";
            }
            else lb_NameNV.Text = nvien.TenNhanVien;

            
            LoadGrid(_bhsv.GetAllSanPham());


            tbx_TienKhachTra.Click += tbx_Click;
            tbx_Giamgia.Click += tbx_Click;

            tbx_TienKhachTra.LostFocus += tbx_LostFocus;
            tbx_Giamgia.LostFocus += tbx_LostFocus;

            foreach (DataGridViewColumn column in dtg_GioHang.Columns)
            {
                column.ReadOnly = true;
            }
            

        }

        //Hàm clear tb
        public void ClearInput()
        {
            cbx_Filter1.SelectedIndex = 0;
            cbx_Filter2.SelectedIndex = 0;

            tbx_Search.Text = "";
            tbx_TienKhachTra.Text = "0";
            tbx_Giamgia.Text = "0";
            tbx_GhiChu.Text = "";
            tbx_SDTkh.Text = "";
            dtg_GioHang.Rows.Clear();

            lb_TenKH.Text = "...";
            lb_TichLuy.Text = "...";
            lb_TongTien.Text = "0";
        }

        //Load du lieu cho 2 combobox
        public void LoadCBX1()
        {
            cbx_Filter1.Items.Clear(); // Xóa tất cả các mục đã tồn tại trong ComboBox trước khi thêm các mục mới

            cbx_Filter1.Items.Add("Tất cả"); // Thêm mục "Tất cả" vào ComboBox

            // Lấy danh sách hãng sản xuất từ cơ sở dữ liệu
            var sanPhamRepos = new SanPham_Repos();
            var manufacturers = sanPhamRepos.GetAllManufacturers();

            // Thêm các hãng sản xuất vào ComboBox
            foreach (var manufacturer in manufacturers)
            {
                cbx_Filter1.Items.Add(manufacturer);
            }

            //Tự động chọn item 0 (tất cả)
            cbx_Filter1.SelectedItem = "Tất cả";
            cbx_Filter1.DropDown += cbx_Filter1_DropDown;
        }


        public void LoadCBX2()
        {
            cbx_Filter2.Items.Add("Tất cả");
            cbx_Filter2.Items.Add("Dưới 1 triệu");
            cbx_Filter2.Items.Add("Từ 1 triệu đến 10 triệu");
            cbx_Filter2.Items.Add("Từ 10 triệu đến 50 triệu");
            cbx_Filter2.Items.Add("Trên 50 triệu");

            //Tự động chọn item 0 (tất cả)
            cbx_Filter2.SelectedItem = "Tất cả";
        }

        private void LoadGioHang(dynamic data) //note
        {
            //Xóa dữ liệu trước khi thêm
            dtg_GioHang.Rows.Clear();

            foreach (var item in data)
            {
                int sttGH = dtg_GioHang.Rows.Count;
                dtg_GioHang.Rows.Add(item.ChiTietSanPham.Id, sttGH++, item.ChiTietSanPham.SanPham.TenSanPham, item.SoLuong, _bhsv.AddThousandSeparators(item.DonGia));
            }
        }

        public void LoadGrid(dynamic data)
        {
            dtg_DSsanpham.Rows.Clear();

            //Tạo cột cho ds sản phẩm 
            dtg_DSsanpham.ColumnCount = 9;

            dtg_DSsanpham.Columns[0].Name = "stt";
            dtg_DSsanpham.Columns[0].HeaderText = "STT";
            dtg_DSsanpham.Columns[0].Width = 40;

            dtg_DSsanpham.Columns[1].Name = "ten";
            dtg_DSsanpham.Columns[1].HeaderText = "Tên sản phẩm";

            dtg_DSsanpham.Columns[2].Name = "loaisp";
            dtg_DSsanpham.Columns[2].HeaderText = "Loại sản phẩm";

            dtg_DSsanpham.Columns[3].Name = "soluong";
            dtg_DSsanpham.Columns[3].HeaderText = "Số lượng";

            dtg_DSsanpham.Columns[4].Name = "gia";
            dtg_DSsanpham.Columns[4].HeaderText = "Giá bán";

            dtg_DSsanpham.Columns[5].Name = "mausac";
            dtg_DSsanpham.Columns[5].HeaderText = "Màu";

            dtg_DSsanpham.Columns[6].Name = "chatlieu";
            dtg_DSsanpham.Columns[6].HeaderText = "Chất liệu";

            dtg_DSsanpham.Columns[7].Name = "hangsx";
            dtg_DSsanpham.Columns[7].HeaderText = "Hãng";

            dtg_DSsanpham.Columns[8].Name = "Id";
            dtg_DSsanpham.Columns[8].Visible = false;
            dtg_DSsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //Thêm dữ liệu vào ds sản phẩm
            //stt
            
            int stt = 1;
            foreach (var item in data)
            {
                dtg_DSsanpham.Rows.Add(stt++,
                    item.SanPham.TenSanPham,
                    item.SanPham.LoaiSanPham,
                    item.SoLuong,
                    item.GiaBan,
                    item.MauSac.Name,
                    item.ChatLieu.Name,
                    item.HangSanXuat.Name,
                    item.Id
                    );
            }




            //Tạo cột cho giỏ hàng
            dtg_GioHang.ColumnCount = 5;

            dtg_GioHang.Columns[0].Name = "Id";
            dtg_GioHang.Columns[0].Visible = false;

            dtg_GioHang.Columns[1].Name = "stt";
            dtg_GioHang.Columns[1].HeaderText = "STT";
            dtg_GioHang.Columns[1].Width = 40;

            dtg_GioHang.Columns[2].Name = "ten";
            dtg_GioHang.Columns[2].HeaderText = "Tên sản phẩm";

            dtg_GioHang.Columns[3].Name = "soluong";
            dtg_GioHang.Columns[3].HeaderText = "Số lượng";
            dtg_GioHang.Columns[3].Width = 40;
            dtg_GioHang.Columns[3].ReadOnly = false;


            dtg_GioHang.Columns[4].Name = "dongia";
            dtg_GioHang.Columns[4].HeaderText = "Đơn giá";
            dtg_GioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            //Tạo cột cho hóa đơn chờ 
            dtg_HoaDonCho.ColumnCount = 6;

            dtg_HoaDonCho.Columns[0].Name = "Id";
            dtg_HoaDonCho.Columns[0].HeaderText = "Mã";
            dtg_HoaDonCho.Columns[0].Visible = false;

            dtg_HoaDonCho.Columns[1].Name = "NameKH";
            dtg_HoaDonCho.Columns[1].HeaderText = "Tên khách hàng";


            dtg_HoaDonCho.Columns[2].Name = "tt";
            dtg_HoaDonCho.Columns[2].HeaderText = "Trạng thái";

            dtg_HoaDonCho.Columns[3].Name = "tongtien";
            dtg_HoaDonCho.Columns[3].Visible = false;

            dtg_HoaDonCho.Columns[4].Name = "tienkhachtra";
            dtg_HoaDonCho.Columns[4].Visible = false;

            dtg_HoaDonCho.Columns[5].Name = "giamgia";
            dtg_HoaDonCho.Columns[5].Visible = false;
            dtg_HoaDonCho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            dtg_HoaDonCho.Rows.Clear();
            //Thêm dữ liệu vào hóa đơn chờ 
            foreach (var item in hdsv.GetAllHoaDon())
            {
                string tenkh = "Không có";
                if (item.KhachHang != null)
                {
                    tenkh = item.KhachHang.TenKhachHang;
                }

                if (item.TrangThai == "Chưa thanh toán")
                {
                    dtg_HoaDonCho.Rows.Add(item.MaHoaDon, tenkh, item.TrangThai, item.TongTien, item.TienKhachTra, item.GiamGia);
                }

            }

        }


        #endregion


        #region Sự kiện cell click
        //Thêm sản phẩm vào giỏ hàng 
        private void dtg_DSsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            if (dtg_DSsanpham.SelectedRows.Count > 1 || e.RowIndex < 0)
            {
                return;
            }
            else
            {

                if (dtg_DSsanpham.Rows[rowIndex].Selected)
                {
                    if (dtg_DSsanpham.Rows[rowIndex].Cells[0].Value == null)
                    {
                        return;
                    }
                    else
                    {
                        if (Convert.ToInt32(dtg_DSsanpham.Rows[rowIndex].Cells[3].Value) == 0)
                        {
                            MessageBox.Show("Sản phẩm đang hết hàng !");
                            return;
                        }
                        else
                        {
                            string id = dtg_DSsanpham.Rows[rowIndex].Cells[8].Value.ToString();
                            string name = dtg_DSsanpham.Rows[rowIndex].Cells[1].Value.ToString();
                            string dongia = dtg_DSsanpham.Rows[rowIndex].Cells[4].Value.ToString();
                            int soluong = 1;
                            bool check = true;
                            var list = dtg_GioHang.Rows;
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i].Cells[0].Value != null && list[i].Cells[0].Value.ToString() == id)
                                {
                                    list[i].Cells[3].Value = Convert.ToInt32(list[i].Cells[3].Value) + 1;
                                    check = false;
                                }

                            }
                            if (check)
                            {
                                int sttGH = dtg_GioHang.Rows.Count;
                                dtg_GioHang.Rows.Add(id, sttGH++, name, soluong, _bhsv.AddThousandSeparators(Convert.ToInt32(dongia)));
                            }

                            lb_TongTien.Text = _bhsv.AddThousandSeparators(TinhTongTien());

                        }
                    }
                }
            }

        }

        //Cell click hóa đơn chờ 
        private void dtg_HoaDonCho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (dtg_HoaDonCho.Rows.Count <= 1)
            {
                if (dtg_HoaDonCho.SelectedRows.Count <= 1)
                {
                    return;
                }
            }

            if (dtg_HoaDonCho.Rows[rowIndex].Cells[0].Value == null || e.RowIndex < 0)
            {
                return;
            }
            else
            {
                idUpdate = Guid.Parse(dtg_HoaDonCho.Rows[rowIndex].Cells[0].Value.ToString());

                tbx_TienKhachTra.Text = dtg_HoaDonCho.Rows[rowIndex].Cells[4].Value.ToString();
                tbx_Giamgia.Text = dtg_HoaDonCho.Rows[rowIndex].Cells[5].Value.ToString();
                lb_TongTien.Text = _bhsv.AddThousandSeparators(Convert.ToInt32(dtg_HoaDonCho.Rows[rowIndex].Cells[3].Value));

                string nameKH_search = dtg_HoaDonCho.Rows[rowIndex].Cells[1].Value.ToString();

                //Load lại sản phẩm trong giỏ hàng của hóa đơn đó 
                LoadGioHang(ctsv.GetAllCTHoaDon(idUpdate));

                //Lấy dữ liệu khách hàng từ tên khách hàng
                kHang = khsv.Search_KH_By_Name(nameKH_search);
                string sdtKH = "";
                string nameKH = "...";
                string tichluy = "...";
                if (kHang != null)
                {
                    sdtKH = kHang.SoDienThoai;
                    nameKH = kHang.TenKhachHang;
                    tichluy = kHang.TichLuy.ToString();
                }


                tbx_SDTkh.Text = sdtKH;
                lb_TenKH.Text = nameKH;
                lb_TichLuy.Text = tichluy;


                int tienthua = Convert.ToInt32(dtg_HoaDonCho.Rows[rowIndex].Cells[4].Value) - Convert.ToInt32(dtg_HoaDonCho.Rows[rowIndex].Cells[3].Value);

                if (tienthua < 0)
                {
                    tienthua = 0;
                }

                lb_TienThua.Text = tienthua.ToString();
            }
        }


        //Cell click giỏ hàng
        string idGHindex;
        private void dtg_GioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;


            if (e.RowIndex < 0 || dtg_GioHang.SelectedRows.Count > 1 || dtg_GioHang.Rows[rowIndex].Cells[0].Value == null)
            {
                return;
            }
            {
                idGHindex = dtg_GioHang.Rows[rowIndex].Cells[0].Value.ToString();
            }
        }


        #endregion


        #region Các hàm xử lý logic 
        //Hàm tính tổng tiền sau khi giam gia
        public int TinhTongTien() //cần sửa
        {

            int kq = 0;
            int SauKhiGiamGia = 0;
            foreach (DataGridViewRow item in dtg_GioHang.Rows)
            {
                if (item.Cells[3].Value != null && item.Cells[4].Value != null)
                {
                    kq = kq + (Convert.ToInt32(item.Cells[4].Value.ToString().Replace(",", "")) * Convert.ToInt32(item.Cells[3].Value));
                }

            }

            if (int.TryParse(tbx_Giamgia.Text, out int giamgia))
            {
                SauKhiGiamGia = kq - (10000 * giamgia);

                if (SauKhiGiamGia < (kq / 100 * 70))
                {
                    SauKhiGiamGia = kq / 100 * 30;
                    tbx_Giamgia.Text = $"{kq / 100 * 70 / 10000}";
                }
            }


            return SauKhiGiamGia;

        }

        private int TinhTongTienKhongGiamGia() //cần sửa
        {
            int kq = 0;
            foreach (DataGridViewRow item in dtg_GioHang.Rows)
            {
                if (item.Cells[3].Value != null && item.Cells[4].Value != null)
                {
                    kq = kq + (Convert.ToInt32(item.Cells[4].Value.ToString().Replace(",", "")) * Convert.ToInt32(item.Cells[3].Value));
                }

            }

            return kq;
        }

        //Tính các loại tiền để gán cho các sự kiện textchanged
        public void TinhAllTien()
        {
            int tongtien = TinhTongTien();
            int tienthua = 0;

            string tienKhachTraStr = tbx_TienKhachTra.Text.Replace(",", ""); // Loại bỏ dấu phẩy từ chuỗi

            //Nếu đầu vào không phải số return
            if (!int.TryParse(tienKhachTraStr, out int tienKhachTra) || tienKhachTra > 999999999)
            {
                tbx_TienKhachTra.Text = "";
            }

            if (int.TryParse(tienKhachTraStr, out tienKhachTra))
            {
                tienthua = tienKhachTra - tongtien; //tính tiền thừa cho khách 
            }

            if (tienthua < 0)
            {
                tienthua = 0;
            }

            //Thêm dấu phảy ngăn cách phần nghìn 
            lb_TongTien.Text = _bhsv.AddThousandSeparators(tongtien);
            lb_TienThua.Text = _bhsv.AddThousandSeparators(tienthua);



        }



        //Hàm tìm kiếm khách hàng
        //Lấy mã khách hàng để tạo hóa đơn  
        Guid? maKH;
        public void SearchCustomer()
        {
            kHang = _bhsv.GetKhachHang(tbx_SDTkh.Text);

            if (kHang != null)
            {
                lb_TenKH.Text = kHang.TenKhachHang;
                lb_TichLuy.Text = kHang.TichLuy.ToString();
                maKH = kHang.MaKhachHang;
            }
            else
            {
                maKH = null;
                return;
            }
        }

        //Hàm validate dữ liệu đầu vào tạo hóa đơn 
        public bool ValidateTaoHD(string tienkhachtra, int tongtien, string trangthai)
        {
            bool check = true;
            //
            if (trangthai == "Đã thanh toán")
            {
                if (dtg_GioHang.Rows.Count == 1)
                {
                    MessageBox.Show("Không có sản phẩm nào được chọn !");
                    check = false;
                }
                else if (Convert.ToInt32(tienkhachtra) == 0)
                {
                    MessageBox.Show("Chưa nhập số tiền khách trả !");
                    check = false;
                }
                else if (Convert.ToInt32(tienkhachtra) < tongtien)
                {
                    MessageBox.Show("Số tiền khách gửi không đủ !");
                    check = false;
                }

            }
            if (trangthai == "Chưa thanh toán")
            {
                if (dtg_GioHang.Rows.Count == 1)
                {
                    MessageBox.Show("Không có sản phẩm nào được chọn !");
                    check = false;
                }
            }
            //
            return check;
        }

        //Hàm thanh toán (Tạo hóa đơn)
        public void ThanhToan()
        {
            if (!ValidateTaoHD(tbx_TienKhachTra.Text.Replace(",", ""), TinhTongTien(), "Đã thanh toán"))
            {
                return;
            }
            else
            {

                bool check = true;
                foreach (var item in hdsv.GetAllHoaDon())
                {
                    if (item.MaHoaDon == idUpdate)
                    {
                        check = false;
                    }
                }

                if (check)
                {

                    TaoHoaDon("Đã thanh toán");

                    if (kHang != null)
                    {
                        //cập nhật tích lũy cho khách hàng
                        int? tichluymoi;


                        tichluymoi = kHang.TichLuy + 1;
                        kHang.TichLuy = tichluymoi;


                        khsv.Update(kHang);
                    }

                    //Xoa du lieu input
                    ClearInput();

                }
                else
                {
                    HoaDon hd = new HoaDon();
                    hd.MaHoaDon = idUpdate;
                    hd.TienKhachTra = Convert.ToInt32(tbx_TienKhachTra.Text.Replace(",", ""));
                    hd.GiamGia = Convert.ToInt32(tbx_Giamgia.Text);
                    hd.TongTien = TinhTongTien();
                    hd.TrangThai = "Đã thanh toán";
                    //Thanh toán hóa đơn chờ
                    hdsv.CapNhatHoaDon(hd);
                    UpdateHDChiTiet();
                    MessageBox.Show("Thanh toán thành công");

                    if (kHang != null)
                    {
                        //cập nhật tích lũy cho khách hàng
                        int? tichluymoi;


                        tichluymoi = kHang.TichLuy + 1;
                        kHang.TichLuy = tichluymoi;


                        khsv.Update(kHang);
                    }

                    //In hoa don cho khach
                    InHoaDon(idUpdate);

                    //Xoa du lieu input
                    ClearInput();
                }

               
                LoadGrid(_bhsv.GetAllSanPham());
            }
        }

        //Hàm tạo hóa đơn
        public void TaoHoaDon(string trangthai)
        {
            Guid? makhachhang = maKH;
            Guid manhanvien = nvien.MaNhanVien;
            DateTime ngaymua = DateTime.Now;

            int tongtien = TinhTongTien();

            int tienkhachtra = Convert.ToInt32(tbx_TienKhachTra.Text.Replace(",", ""));

            int giamgia = Convert.ToInt32(tbx_Giamgia.Text);

            if (!ValidateTaoHD(tienkhachtra.ToString(), tongtien, "Chưa thanh toán"))
            {
                return;
            }
            {
                HoaDon hdonUpdate = hdsv.GetHD(idUpdate);
                if (hdonUpdate != null)
                {
                    UpdateHDChiTiet();
                }
                else
                {
                    HoaDon hd = new HoaDon
                    {
                        MaHoaDon = Guid.NewGuid(),
                        MaKhachHang = makhachhang,
                        MaNhanVien = manhanvien,
                        NgayMua = ngaymua,
                        TongTien = tongtien,
                        TienKhachTra = tienkhachtra,
                        GiamGia = giamgia,
                        TrangThai = trangthai
                    };
                    hdsv.TaoHoaDon(hd);
                    AddHDChiTiet(hd.MaHoaDon);

                    //Update số lượng sản phẩm 
                    _bhsv.UpdateSoLuongSP(hd.MaHoaDon);

                    //In hoa don cho khach
                    if (trangthai == "Đã thanh toán")
                    {
                        InHoaDon(hd.MaHoaDon);
                    }
                }

            }

            LoadGrid(_bhsv.GetAllSanPham());
            ClearInput();
        }

        //Hàm in hóa đơn vật lý 
        private void InHoaDon(Guid mahd)
        {
            // Tạo một tài liệu PDF mới
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            string fileName = $"HoaDon_{DateTime.Now.ToString("yyyyMMddHHmmss")}.pdf"; // Sử dụng timestamp trong tên file


            try
            {
                PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));

                // Mở tài liệu để bắt đầu viết
                document.Open();

                // Tạo một Paragraph cho nội dung hoá đơn
                Paragraph content = new Paragraph();
                content.Alignment = Element.ALIGN_CENTER; // Căn giữa nội dung

                // Tạo BaseFont từ tệp font Arial
                BaseFont arialBaseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                // Sử dụng BaseFont để tạo Font Arial với kích thước 24 và đặt chế độ in đậm
                iTextSharp.text.Font titleFont = new iTextSharp.text.Font(arialBaseFont, 17, iTextSharp.text.Font.BOLD);
                // Tạo một Font chữ từ BaseFont Arial với kích thước 12 và đặt chế độ in đậm
                iTextSharp.text.Font contentFont = new iTextSharp.text.Font(arialBaseFont, 12, iTextSharp.text.Font.NORMAL);



                // Thêm thông tin hoá đơn vào nội dung với font chữ đã được thiết lập
                content.Add(new iTextSharp.text.Chunk($"Cửa hàng: Magic Pro\n", contentFont));
                content.Add(new iTextSharp.text.Chunk($"Địa chỉ : Bắc Từ Liêm , Hà Nội\n", contentFont));
                content.Add(new iTextSharp.text.Chunk($"Số Điện thoại: 037509539\n", contentFont));

                content.Add(new iTextSharp.text.Chunk("----------------------\n\n", titleFont));
                content.Add(new iTextSharp.text.Chunk("HOÁ ĐƠN THANH TOÁN \n", titleFont));
                content.Add(new iTextSharp.text.Chunk($"Mã hoá đơn:  {mahd}\n", contentFont));
                content.Add(new iTextSharp.text.Chunk($"{DateTime.Now.ToLongDateString()}\n", contentFont));
                content.Add(new iTextSharp.text.Chunk($"{DateTime.Now.ToLongTimeString()}\n", contentFont));


                // Thêm thông tin nhân viên bán hàng và tên khách hàng
                PdfPTable infoTable = new PdfPTable(2);
                infoTable.WidthPercentage = 100;
                infoTable.SpacingBefore = 10f; // Khoảng cách trước của bảng

                PdfPCell nhanVienCell = new PdfPCell(new Phrase($"Nhân viên bán hàng: {lb_NameNV.Text}", contentFont));
                nhanVienCell.Border = PdfPCell.NO_BORDER;
                infoTable.AddCell(nhanVienCell);

                PdfPCell tenKhachHangCell = new PdfPCell(new Phrase($"Tên khách hàng: {lb_TenKH.Text}\n\n", contentFont));
                tenKhachHangCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                tenKhachHangCell.Border = PdfPCell.NO_BORDER;
                infoTable.AddCell(tenKhachHangCell);

                content.Add(infoTable);

                content.Add(CreateProductsTable());

                // Đặt tổng tiền, số tiền khách trả, giảm giá và tiền thừa bên trái
                // Thêm tổng tiền vào nội dung với căn chỉnh bên trái
                // Tạo một PdfPTable để chứa thông tin "Tổng tiền" và giá trị lb_TongTien.Text

                PdfPTable totalTable = new PdfPTable(2);
                totalTable.WidthPercentage = 100;
                totalTable.SpacingBefore = 10f; // Khoảng cách trước của bảng

                // Thêm cột "Thành tiền" với căn chỉnh bên trái
                PdfPCell totalLabelCell2 = new PdfPCell(new Phrase($"Thành tiền: ", contentFont));
                totalLabelCell2.Border = PdfPCell.NO_BORDER;
                totalTable.AddCell(totalLabelCell2);

                // Thêm giá trị lb_TongTien.Text với căn chỉnh bên phải
                PdfPCell totalValueCell2 = new PdfPCell(new Phrase($"{_bhsv.AddThousandSeparators(TinhTongTienKhongGiamGia())} VND", contentFont));
                totalValueCell2.HorizontalAlignment = Element.ALIGN_RIGHT;
                totalValueCell2.Border = PdfPCell.NO_BORDER;
                totalTable.AddCell(totalValueCell2);


                // Thêm cột "Tổng tiền" với căn chỉnh bên trái
                PdfPCell totalLabelCell = new PdfPCell(new Phrase($"Tổng tiền: ", contentFont));
                totalLabelCell.Border = PdfPCell.NO_BORDER;
                totalTable.AddCell(totalLabelCell);

                // Thêm giá trị lb_TongTien.Text với căn chỉnh bên phải
                PdfPCell totalValueCell = new PdfPCell(new Phrase($"{_bhsv.AddThousandSeparators(Convert.ToInt32(lb_TongTien.Text.Replace(",", "")))} VND", contentFont));
                totalValueCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                totalValueCell.Border = PdfPCell.NO_BORDER;
                totalTable.AddCell(totalValueCell);

                // Thêm bảng thông tin "Tổng tiền" và giá trị lb_TongTien.Text vào nội dung của tài liệu
                content.Add(totalTable);


                // Tạo một PdfPTable để chứa thông tin "Giảm giá", "Số tiền khách trả" và "Tiền thừa"
                PdfPTable paymentTable = new PdfPTable(2);
                paymentTable.WidthPercentage = 100;
                paymentTable.SpacingBefore = 10f; // Khoảng cách trước của bảng

                // Thêm cột "Giảm giá" với căn chỉnh bên trái
                PdfPCell discountLabelCell = new PdfPCell(new Phrase($"Giảm giá: ", contentFont));
                discountLabelCell.Border = PdfPCell.NO_BORDER;
                paymentTable.AddCell(discountLabelCell);

                // Thêm giá trị tbx_Giamgia.Text với căn chỉnh bên phải
                PdfPCell discountValueCell = new PdfPCell(new Phrase($"{_bhsv.AddThousandSeparators(Convert.ToInt32(tbx_Giamgia.Text) * 10000)} VND", contentFont));
                discountValueCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                discountValueCell.Border = PdfPCell.NO_BORDER;
                paymentTable.AddCell(discountValueCell);

                // Thêm cột "Số tiền khách trả" với căn chỉnh bên trái
                PdfPCell paymentLabelCell = new PdfPCell(new Phrase($"Số tiền khách trả: ", contentFont));
                paymentLabelCell.Border = PdfPCell.NO_BORDER;
                paymentTable.AddCell(paymentLabelCell);

                // Thêm giá trị tbx_TienKhachTra.Text với căn chỉnh bên phải
                PdfPCell paymentValueCell = new PdfPCell(new Phrase($"{_bhsv.AddThousandSeparators(Convert.ToInt32(tbx_TienKhachTra.Text.Replace(",", "")))} VND", contentFont));
                paymentValueCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                paymentValueCell.Border = PdfPCell.NO_BORDER;
                paymentTable.AddCell(paymentValueCell);

                // Thêm cột "Tiền thừa" với căn chỉnh bên trái
                PdfPCell changeLabelCell = new PdfPCell(new Phrase($"Tiền thừa: ", contentFont));
                changeLabelCell.Border = PdfPCell.NO_BORDER;
                paymentTable.AddCell(changeLabelCell);

                // Thêm giá trị lb_TienThua.Text với căn chỉnh bên phải
                PdfPCell changeValueCell = new PdfPCell(new Phrase($"{_bhsv.AddThousandSeparators(Convert.ToInt32(lb_TienThua.Text.Replace(",", "")))} VND", contentFont));
                changeValueCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                changeValueCell.Border = PdfPCell.NO_BORDER;
                paymentTable.AddCell(changeValueCell);
                // Thêm bảng thông tin "Giảm giá", "Số tiền khách trả" và "Tiền thừa" vào nội dung của tài liệu
                content.Add(paymentTable);
                content.Add(new iTextSharp.text.Chunk("----------------------\n\n", titleFont));
                content.Add(new iTextSharp.text.Chunk($"Cảm ơn quý khách và hẹn gặp lại quý khách!!\n", contentFont));



                // Đặt căn chỉnh nội dung của Paragraph ra giữa
                content.Alignment = Element.ALIGN_CENTER;


                // Thêm bảng sản phẩm


                // Đặt căn chỉnh nội dung của Paragraph ra giữa

                content.Alignment = Element.ALIGN_CENTER;


                // Thêm nội dung hoá đơn vào tài liệu
                document.Add(content);

                // Đóng tài liệu
                document.Close();

                MessageBox.Show("Hoá đơn đã được lưu thành công vào tệp PDF.");

                // Mở tệp PDF sau khi lưu
                Process.Start(@"E:\PRO131_NEW\SumatraPDF\SumatraPDF.exe", fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }


        //Hàm tạo chi tiết hóa đơn (được gọi sau khi tạo hóa đơn)
        public void AddHDChiTiet(Guid mahd)
        {
            foreach (DataGridViewRow item in dtg_GioHang.Rows)
            {
                if (item.Cells[0].Value != null)
                {
                    ChiTietHoaDon ctHoaDon = new ChiTietHoaDon();
                    ctHoaDon.MaHoaDon = mahd;
                    ctHoaDon.MaChiTietSanPham = Guid.Parse(item.Cells[0].Value.ToString());
                    ctHoaDon.SoLuong = Convert.ToInt32(item.Cells[3].Value);
                    ctHoaDon.DonGia = Convert.ToInt32(item.Cells[4].Value.ToString().Replace(",", ""));

                    ctsv.TaoChiTietHoaDon(ctHoaDon);
                }
            }
        }

        //Hàm update chi tiết hóa đơn (được gọi sau khi thanh toán hóa đơn chờ)
        public void UpdateHDChiTiet()
        {

            foreach (var item in ctsv.GetAllCTHoaDon(idUpdate).ToList())
            {
                bool foundInCart = false;
                foreach (DataGridViewRow row in dtg_GioHang.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if (item.MaChiTietSanPham == Guid.Parse(row.Cells[0].Value.ToString()))
                        {
                            // Cập nhật số lượng
                            item.SoLuong = Convert.ToInt32(row.Cells[3].Value);
                            ctsv.UpdateCTHoaDon(item);
                            foundInCart = true;
                            break;
                        }
                    }
                }

                // Xóa nếu không còn tồn tại trong giỏ hàng
                if (!foundInCart)
                {
                    ctsv.DeleteSPChiTietHoaDon(item);
                }
            }

            // Tạo mới nếu không tồn tại trong hóa đơn
            foreach (DataGridViewRow row in dtg_GioHang.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    bool foundInOrder = false;
                    foreach (var item in ctsv.GetAllCTHoaDon(idUpdate))
                    {
                        if (item.MaChiTietSanPham == Guid.Parse(row.Cells[0].Value.ToString()))
                        {
                            foundInOrder = true;
                            break;
                        }
                    }

                    if (!foundInOrder)
                    {
                        ChiTietHoaDon ctHoaDon = new ChiTietHoaDon();
                        ctHoaDon.MaHoaDon = idUpdate;
                        ctHoaDon.MaChiTietSanPham = Guid.Parse(row.Cells[0].Value.ToString());
                        ctHoaDon.SoLuong = Convert.ToInt32(row.Cells[3].Value);
                        ctHoaDon.DonGia = Convert.ToInt32(row.Cells[4].Value.ToString().Replace(",", ""));

                        ctsv.TaoChiTietHoaDon(ctHoaDon);
                    }
                }
            }
        }




        // Hàm tạo bảng sản phẩm cho hoá đơn
        private PdfPTable CreateProductsTable()
        {
            // Tạo font Unicode
            BaseFont bf = BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 12); // Chọn kích thước font tùy ý

            PdfPTable table = new PdfPTable(dtg_GioHang.Columns.Count - 1); // Trừ đi 1 cột trống đầu tiên
            table.WidthPercentage = 100;
            table.HorizontalAlignment = Element.ALIGN_LEFT;

            // Add tiêu đề cột vào bảng (bắt đầu từ cột thứ 1)
            for (int i = 1; i < dtg_GioHang.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(dtg_GioHang.Columns[i].HeaderText, font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
            }

            // Add dữ liệu sản phẩm vào bảng
            for (int rowIndex = 0; rowIndex < dtg_GioHang.Rows.Count; rowIndex++)
            {
                DataGridViewRow row = dtg_GioHang.Rows[rowIndex];
                for (int colIndex = 1; colIndex < dtg_GioHang.Columns.Count; colIndex++) // Bắt đầu từ cột thứ 1
                {
                    if (row.Cells[colIndex].Value != null)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(row.Cells[colIndex].Value.ToString(), font));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }
            }

            return table;
        }


        #endregion


        #region các nút 

        //Hủy hóa đơn
        private void pn_HuyHD_Click(object sender, EventArgs e)
        {
            HoaDon hdonUpdate = hdsv.GetHD(idUpdate);
            hdonUpdate.TrangThai = "Đã hủy";

            hdsv.CapNhatHoaDon(hdonUpdate);
        }

        //Nut xoa sp
        private void pn_BtnXoaSP_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dtg_GioHang.Rows)
            {
                if (item.Cells[0].Value == idGHindex)
                {
                    dtg_GioHang.Rows.Remove(item);
                }
            }

            lb_TongTien.Text = _bhsv.AddThousandSeparators(TinhTongTien());
        }

        //nut xoa gio hang
        private void pn_BtnXoaGioHang_Click(object sender, EventArgs e)
        {
            dtg_GioHang.Rows.Clear();
            lb_TongTien.Text = _bhsv.AddThousandSeparators(TinhTongTien());
        }

        //Nut tạo hóa đơn
        private void pn_BtnTaoHoaDon_Click(object sender, EventArgs e)
        {
            TaoHoaDon("Chưa thanh toán");
        }


        //Nút cập nhật
        private void pn_BtnCapNhat_Click(object sender, EventArgs e)
        {
            LoadGrid(_bhsv.GetAllSanPham());
        }


        //Nút thanh toán
        Guid idUpdate;
        private void pn_buttonThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan();
        }


        #endregion


        #region sự kiện textbox
        private void tbx_TienKhachTra_TextChanged(object sender, EventArgs e)
        {
            TinhAllTien();

            string text = tbx_TienKhachTra.Text.Replace(",", "");
            int tien;

            if (text == "" || text == "0")
            {
                return;
            }
            else
            {
                tien = Convert.ToInt32(text);
            }

            if (tien > 500000000)
            {
                tbx_TienKhachTra.Text = "0";
            }

            //Chia phần trăm, nghìn cho input
            tbx_TienKhachTra.Text = _bhsv.AddThousandSeparators(tien);

            //reset lại focus 
            tbx_TienKhachTra.SelectionStart = tbx_TienKhachTra.Text.Length;
        }

        //Sự kiện giảm giá 
        private void tbx_Giamgia_TextChanged(object sender, EventArgs e)
        {
            TinhAllTien();
        }

        //Sự kiện tìm kiếm khách hàng theo số điện thoại
        private void tbx_SDTkh_TextChanged(object sender, EventArgs e)
        {
            SearchCustomer();
        }

        //Chỉ được nhập số 
        private void tbx_TienKhachTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }
        }

        private void tbx_Giamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }
        }

        private void tbx_SDTkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }
        }

        //Click 
        private void tbx_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;

            // Kiểm tra nếu TextBox đã được chọn (đã bôi đen)
            if (textBox.SelectionLength > 0)
            {
                // Nếu đã bôi đen, xóa bôi đen
                textBox.SelectionLength = 0;
            }

            textBox.Text = "";
        }
        //Focus
        private void tbx_LostFocus(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;

            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
        }

        //su kien tim kiem san pham theo ten
        private void tbx_Search_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbx_Search.Text;
            int filter1Index = cbx_Filter1.SelectedIndex;
            int filter2Index = cbx_Filter2.SelectedIndex;

            // Gọi phương thức GetFilteredData và tải dữ liệu vào DataGridView
            LoadGrid(_bhsv.LocALL(searchText, filter1Index, filter2Index));


        }


        #endregion


        #region Sự kiện combobox
        private void cbx_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchText = tbx_Search.Text;
            int filter1Index = cbx_Filter1.SelectedIndex;
            int filter2Index = cbx_Filter2.SelectedIndex;

            // Gọi phương thức GetFilteredData và tải dữ liệu vào DataGridView
            LoadGrid(_bhsv.LocALL(searchText, filter1Index, filter2Index));

        }

        #endregion


        #region Sự kiện thay đổi giá trị cell 

        //Thay đổi số lượng mua thì cập nhật tổng giá tiền
        private void dtg_GioHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TinhAllTien();
        }

        #endregion


        #region Sự kiện cell content click 
        private void dtg_GioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            dtg_GioHang.Rows[index].Cells[3].ReadOnly = false;
        }

        #endregion

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Click(object sender, EventArgs e)
        {
            pn_DangXuat_Click(sender, e);
        }

        private void pn_DangXuat_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại (formTrangChu)
            this.Hide();

            // Tạo và mở form đăng nhập
            Form_DangNhap formDangNhap = new Form_DangNhap();
            formDangNhap.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            pn_DangXuat_Click(sender, e);
        }

        private int FindColumnIndexByName(DataGridView dataGridView, string columnName)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Name == columnName)
                {
                    return column.Index; // Trả về chỉ mục của cột nếu tìm thấy
                }
            }
            return -1; // Trả về -1 nếu không tìm thấy cột
        }

        private void cbx_Filter1_DropDown(object sender, EventArgs e)
        {
            cbx_Filter1.Items.Clear(); // Xóa tất cả các mục đã tồn tại trong ComboBox trước khi thêm các mục mới

            cbx_Filter1.Items.Add("Tất cả"); // Thêm mục "Tất cả" vào ComboBox

            // Lấy danh sách hãng sản xuất từ cơ sở dữ liệu
            var sanPhamRepos = new SanPham_Repos();
            var manufacturers = sanPhamRepos.GetAllManufacturers();

            // Thêm các hãng sản xuất vào ComboBox
            foreach (var manufacturer in manufacturers)
            {
                cbx_Filter1.Items.Add(manufacturer);
            }

        }
       
    }
}
