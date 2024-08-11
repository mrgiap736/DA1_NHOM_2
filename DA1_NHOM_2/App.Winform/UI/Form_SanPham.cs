using App.Data.Data;
using App.Data.Entities;
using App.Services.Services;
using Microsoft.IdentityModel.Tokens;
using OfficeOpenXml;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Twilio.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App.Winform.UI
{
    public partial class Form_SanPham : Form
    {
        SanPham_Services _service;
        List<ChiTietSanPham> _listSP = new();
        Guid _idwhenclick;

        Guid _idMS;
        Guid _idCL;
        Guid _idLR;
        Guid _idHS;
        public Form_SanPham(NhanVien nv)
        {
            InitializeComponent();
            _service = new SanPham_Services();
            LoadGird(ApplyFilters());
            LoadGrid2();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ///123///////2113232
            LoadComboBox();

            cbx_FillHangSX.SelectedItem = "Tất cả";
            cbx_FillMauSac.SelectedItem = "Tất cả";
            cbx_FillChatLieu.SelectedItem = "Tất cả";
            cbx_FillLoaiRen.SelectedItem = "Tất cả";
            cbx_TrangThai.SelectedItem = "Còn hàng";


        }

        public List<Control> GetCtrl()
        {
            List<Control> ctrls = new List<Control>();

            foreach (Control ctrl in pn_Form_SanPham.Controls)
            {
                ctrls.Add(ctrl);
            }
            return ctrls;
        }


        public void LoadGird(dynamic data)
        {
            dtgView.Rows.Clear();
            dtgView.ColumnCount = 13;
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "Tên Sản Phẩm";
            dtgView.Columns[2].Name = "Số lượng";
            dtgView.Columns[3].Name = "Loại sản phẩm";
            dtgView.Columns[4].Name = "Giá bán";
            dtgView.Columns[5].Name = "Chiều dài";
            dtgView.Columns[6].Name = "Cân nặng";
            dtgView.Columns[7].Name = "Chất liệu";
            dtgView.Columns[8].Name = "Màu sắc";
            dtgView.Columns[9].Name = "Loại ren";
            dtgView.Columns[10].Name = "Hãng sản xuất";
            dtgView.Columns[11].Name = "Trạng thái";
            dtgView.Columns[12].Name = "Mã sản phẩm ct";
            dtgView.Columns[12].Visible = false;

            _listSP = _service.GetAll();
            foreach (var sp in data)
            {
                int stt = _listSP.IndexOf(sp) + 1;
                string giaBanFormatted = sp.GiaBan.ToString("#,##0");
                dtgView.Rows.Add(stt, sp.SanPham.TenSanPham,
                    sp.SoLuong,
                    sp.SanPham.LoaiSanPham,
                    giaBanFormatted,
                    sp.ChieuDai,
                    sp.CanNang,
                    sp.ChatLieu.Name,
                    sp.MauSac.Name,
                    sp.LoaiRen.Name,
                    sp.HangSanXuat.Name,
                    sp.TrangThai,
                    sp.Id,
                    sp.HinhAnh
                    );
            }
            dtgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadGrid2()
        {
            dtg_DSMau.Rows.Clear();
            dtg_DSChatLieu.Rows.Clear();
            dtg_DSLoaiRen.Rows.Clear();
            dtg_DSHangSX.Rows.Clear();

            dtg_DSMau.ColumnCount = 3;
            dtg_DSChatLieu.ColumnCount = 3;
            dtg_DSLoaiRen.ColumnCount = 3;
            dtg_DSHangSX.ColumnCount = 3;

            dtg_DSMau.Columns[0].Name = "Id";
            dtg_DSChatLieu.Columns[0].Name = "Id";
            dtg_DSLoaiRen.Columns[0].Name = "Id";
            dtg_DSHangSX.Columns[0].Name = "Id";

            dtg_DSMau.Columns[0].Visible = false;
            dtg_DSChatLieu.Columns[0].Visible = false;
            dtg_DSLoaiRen.Columns[0].Visible = false;
            dtg_DSHangSX.Columns[0].Visible = false;

            dtg_DSMau.Columns[1].Name = "STT";
            dtg_DSChatLieu.Columns[1].Name = "STT";
            dtg_DSLoaiRen.Columns[1].Name = "STT";
            dtg_DSHangSX.Columns[1].Name = "STT";

            dtg_DSMau.Columns[1].Width = 40;
            dtg_DSChatLieu.Columns[1].Width = 40;
            dtg_DSLoaiRen.Columns[1].Width = 40;
            dtg_DSHangSX.Columns[1].Width = 40;

            dtg_DSMau.Columns[2].Name = "Màu";
            dtg_DSChatLieu.Columns[2].Name = "Chất liệu";
            dtg_DSLoaiRen.Columns[2].Name = "Loại";
            dtg_DSHangSX.Columns[2].Name = "Hãng";

            int stt = 1;
            foreach (var item in _service.GetAllMauSac())
            {
                dtg_DSMau.Rows.Add(item.Id, stt++, item.Name);
            }

            foreach (var item in _service.GetAllChatLieu())
            {
                dtg_DSChatLieu.Rows.Add(item.Id, stt++, item.Name);
            }

            foreach (var item in _service.GetAllLoaiRen())
            {
                dtg_DSLoaiRen.Rows.Add(item.Id, stt++, item.Name);
            }

            foreach (var item in _service.GetAllHangSanXuat())
            {
                dtg_DSHangSX.Rows.Add(item.Id, stt++, item.Name);
            }

        }

        public void ResetInputSP()
        {
            txt_SoLuong.Text = "";
            txt_TenSanPham.Text = "";
            cbx_LoaiSP.Text = "";
            txt_ChieuDai.Text = "";
            txt_CanNang.Text = "";
            txt_GiaBan.Text = "";

            cbx_HangSX.Text = "";
            cbx_LoaiRen.Text = "";
            cbx_ChatLieu.Text = "";
            cbx_MauSac.Text = "";
            cbx_TrangThai.Text = "Còn hàng";

            txt_Search.Text = "";
            cbx_FillChatLieu.Text = "Tất cả";
            cbx_FillMauSac.Text = "Tất cả";
            cbx_FillLoaiRen.Text = "Tất cả";
            cbx_FillHangSX.Text = "Tất cả";

            checkbox_suaten.Checked = false;
            ptb_Anh.Image = null;
        }

        private void pn_LamMoi_Click(object sender, EventArgs e)
        {
            ResetInputSP();
            LoadGird(ApplyFilters());
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            cbx_HangSX.Items.Clear();
            cbx_MauSac.Items.Clear();
            cbx_ChatLieu.Items.Clear();
            cbx_LoaiRen.Items.Clear();

            cbx_FillHangSX.Items.Clear();
            cbx_FillMauSac.Items.Clear();
            cbx_FillChatLieu.Items.Clear();
            cbx_FillLoaiRen.Items.Clear();

            cbx_FillHangSX.Items.Add("Tất cả");
            cbx_FillMauSac.Items.Add("Tất cả");
            cbx_FillChatLieu.Items.Add("Tất cả");
            cbx_FillLoaiRen.Items.Add("Tất cả");

            foreach (var item in _service.GetAllHangSanXuat())
            {
                cbx_HangSX.Items.Add(item.Name);
                cbx_FillHangSX.Items.Add(item.Name);
            }

            foreach (var item in _service.GetAllMauSac())
            {
                cbx_MauSac.Items.Add(item.Name);
                cbx_FillMauSac.Items.Add(item.Name);
            }

            foreach (var item in _service.GetAllLoaiRen())
            {
                cbx_LoaiRen.Items.Add(item.Name);
                cbx_FillLoaiRen.Items.Add(item.Name);
            }

            foreach (var item in _service.GetAllChatLieu())
            {
                cbx_ChatLieu.Items.Add(item.Name);
                cbx_FillChatLieu.Items.Add(item.Name);
            }
        }

        private bool CheckExistProduct(ChiTietSanPham ctsp)
        {
            bool check = true;

            List<ChiTietSanPham> lst = _service.GetAll();

            foreach (var item in lst)
            {
                if (
                    item.MaSanPham == ctsp.MaSanPham &&
                    item.ChieuDai == ctsp.ChieuDai &&
                    item.CanNang == ctsp.CanNang &&
                    item.MaLoaiRen == ctsp.MaLoaiRen &&
                    item.MaMauSac == ctsp.MaMauSac &&
                    item.MaChatLieu == ctsp.MaChatLieu &&
                    item.MaHangSanXuat == ctsp.MaHangSanXuat
                  )
                {
                    check = false;
                }
            }

            return check;
        }
        private bool CheckExistName(string namesp)
        {
            bool check = true;


            foreach (var existingSP in _service.GetAllSP())
            {
                if (existingSP.TenSanPham == namesp)
                {
                    MessageBox.Show("Tên sản phẩm này đã tồn tại. Vui lòng nhập tên khác.");
                    check = false;
                }
            }

            return check;
        }

        private void pn_ThemSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(txt_SoLuong.Text) || string.IsNullOrWhiteSpace(txt_TenSanPham.Text) ||
                string.IsNullOrWhiteSpace(cbx_LoaiSP.Text) || string.IsNullOrWhiteSpace(txt_ChieuDai.Text) ||
                string.IsNullOrWhiteSpace(txt_CanNang.Text) || string.IsNullOrWhiteSpace(txt_GiaBan.Text) ||
                string.IsNullOrWhiteSpace(cbx_ChatLieu.Text) || string.IsNullOrWhiteSpace(cbx_LoaiRen.Text) ||
                string.IsNullOrWhiteSpace(cbx_MauSac.Text) || string.IsNullOrWhiteSpace(cbx_HangSX.Text)
                )
            {
                MessageBox.Show("Vui lòng nhập và chọn đầy đủ thông tin sản phẩm.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ptb_Anh.Image == null)
            {
                MessageBox.Show("Vui lòng tải ảnh sản phẩm.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra độ dài tên sản phẩm
            if (txt_TenSanPham.Text.Length > 50)
            {
                MessageBox.Show("Tên sản phẩm chỉ được phép nhập tối đa 50 ký tự.",
                                "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giá nhập và giá bán có phải số không
            if (!int.TryParse(txt_GiaBan.Text.Replace(",", ""), out int giaBan))
            {
                MessageBox.Show("Giá nhập và giá bán phải là số.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Kiểm tra giá nhập và giá bán có lớn hơn hoặc bằng 1,000 không
            if (giaBan < 1000)
            {
                MessageBox.Show(
                    "Giá nhập và giá bán phải lớn hơn hoặc bằng 1,000.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuẩn bị dữ liệu hình ảnh
            byte[] imageData = null;
            if (ptb_Anh.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    try
                    {
                        // Tạo một bản sao của hình ảnh để lưu
                        using (Bitmap bitmap = new Bitmap(ptb_Anh.Image))
                        {
                            bitmap.Save(ms, ptb_Anh.Image.RawFormat);
                        }
                        ptb_Anh.BackgroundImage = null;
                        imageData = ms.ToArray();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message);
                    }
                }
            }

            //Check xem Sản phẩm đã tồn tại hay chưa nếu đã tồn tại thì 
            List<SanPham> lstSP = _service.GetAllSP();
            List<ChiTietSanPham> lstCTSP = _service.GetAll();
            bool checkExist = true;


            foreach (var item in lstSP)
            {
                if (txt_TenSanPham.Text == item.TenSanPham)
                {
                    checkExist = false;
                }
            }

            if (checkExist)
            {

                var sp = new SanPham();
                sp.MaSanPham = Guid.NewGuid();
                sp.TenSanPham = txt_TenSanPham.Text;
                sp.LoaiSanPham = cbx_LoaiSP.Text;

                //
                var ctsp = new ChiTietSanPham();

                ctsp.Id = Guid.NewGuid();
                ctsp.MaSanPham = sp.MaSanPham;
                ctsp.MaHangSanXuat = _service.GetIdHangSX(cbx_HangSX.Text);
                ctsp.MaMauSac = _service.GetIdMauSac(cbx_MauSac.Text);
                ctsp.MaChatLieu = _service.GetIdChatLieu(cbx_ChatLieu.Text);
                ctsp.MaLoaiRen = _service.GetIdLoaiRen(cbx_LoaiRen.Text);
                ctsp.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
                ctsp.ChieuDai = Convert.ToDouble(txt_ChieuDai.Text);
                ctsp.CanNang = Convert.ToDouble(txt_CanNang.Text);
                ctsp.GiaBan = giaBan;
                ctsp.TrangThai = cbx_TrangThai.Text;
                ctsp.HinhAnh = imageData;

                // Hiển thị hộp thoại xác nhận
                var option = MessageBox.Show("Xác nhận muốn thêm sản phẩm?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (option == DialogResult.Yes)
                {
                    if (_service.Add(sp))
                    {
                        // Thêm sản phẩm vào cơ sở dữ liệu và xử lý kết quả
                        MessageBox.Show(_service.AddCTSP(ctsp));
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại");
                    }

                    // Tải lại danh sách sản phẩm sau khi thêm thành công
                    LoadGird(ApplyFilters());
                    ResetInput();
                }
                else
                {
                    return;
                }
            }
            else
            {
                SanPham sp = lstSP.FirstOrDefault(x => x.TenSanPham == txt_TenSanPham.Text);

                var ctsp = new ChiTietSanPham();

                ctsp.Id = Guid.NewGuid();
                ctsp.MaSanPham = sp.MaSanPham;
                ctsp.MaHangSanXuat = _service.GetIdHangSX(cbx_HangSX.Text);
                ctsp.MaMauSac = _service.GetIdMauSac(cbx_MauSac.Text);
                ctsp.MaChatLieu = _service.GetIdChatLieu(cbx_ChatLieu.Text);
                ctsp.MaLoaiRen = _service.GetIdLoaiRen(cbx_LoaiRen.Text);
                ctsp.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
                ctsp.ChieuDai = Convert.ToDouble(txt_ChieuDai.Text);
                ctsp.CanNang = Convert.ToDouble(txt_CanNang.Text);
                ctsp.GiaBan = giaBan;
                ctsp.TrangThai = cbx_TrangThai.Text;
                ctsp.HinhAnh = imageData;


                // Hiển thị hộp thoại xác nhận
                var option = MessageBox.Show("Xác nhận muốn thêm sản phẩm?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (option == DialogResult.Yes)
                {
                    if (CheckExistProduct(ctsp))
                    {
                        // Thêm sản phẩm vào cơ sở dữ liệu và xử lý kết quả
                        MessageBox.Show(_service.AddCTSP(ctsp));

                        // Tải lại danh sách sản phẩm sau khi thêm thành công
                        LoadGird(ApplyFilters());
                        ResetInput();
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm đã tồn tại trong kho");
                        return;
                    }
                }
                else
                {
                    return;
                }


            }


        }



        private void pn_UpdateSP_Click(object sender, EventArgs e)
        {
            ChiTietSanPham ctsp = null;
            // Kiểm tra đã chọn sản phẩm để cập nhật chưa  //cần sửa
            if (_idwhenclick == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn cập nhật.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                List<ChiTietSanPham> lst = _service.GetAll();

                ctsp = lst.FirstOrDefault(x => x.Id == _idwhenclick);
            }

            // Kiểm tra dữ liệu nhập vào và các điều kiện khác
            if (string.IsNullOrWhiteSpace(txt_SoLuong.Text) || string.IsNullOrWhiteSpace(txt_TenSanPham.Text) ||
                string.IsNullOrWhiteSpace(cbx_LoaiSP.Text) || string.IsNullOrWhiteSpace(txt_ChieuDai.Text) ||
                string.IsNullOrWhiteSpace(txt_CanNang.Text) || string.IsNullOrWhiteSpace(txt_GiaBan.Text) ||
                string.IsNullOrWhiteSpace(cbx_ChatLieu.Text) || string.IsNullOrWhiteSpace(cbx_LoaiRen.Text) ||
                string.IsNullOrWhiteSpace(cbx_MauSac.Text) || string.IsNullOrWhiteSpace(cbx_HangSX.Text))
            {
                MessageBox.Show("Vui lòng nhập và chọn đầy đủ thông tin sản phẩm.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra độ dài tên sản phẩm
            if (txt_TenSanPham.Text.Length > 50)
            {
                MessageBox.Show("Tên sản phẩm chỉ được phép nhập tối đa 50 ký tự.",
                                "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giá nhập và giá bán có phải số không
            if (!int.TryParse(txt_GiaBan.Text.Replace(",", ""), out int giaBan))
            {
                MessageBox.Show("Giá nhập và giá bán phải là số.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giá nhập và giá bán có lớn hơn hoặc bằng 1,000 không
            if (giaBan < 1000)
            {
                MessageBox.Show("Giá nhập và giá bán phải lớn hơn hoặc bằng 1,000.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            byte[] imageData = null;
            // Kiểm tra xem người dùng đã chọn ảnh mới hay chưa
            if (ptb_Anh.Image != null && !IsDefaultImage(ptb_Anh.Image))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    try
                    {
                        // Tạo một bản sao của hình ảnh để lưu
                        using (Bitmap bitmap = new Bitmap(ptb_Anh.Image))
                        {
                            bitmap.Save(ms, ptb_Anh.Image.RawFormat);
                        }
                        ptb_Anh.BackgroundImage = null;
                        imageData = ms.ToArray();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message);
                    }
                }
            }

            if (ctsp != null)
            {
                if (checkbox_suaten.Checked)
                {
                    if (CheckExistName(txt_TenSanPham.Text))
                    {
                        _service.UpdateNameSP(ctsp.MaSanPham, txt_TenSanPham.Text.Trim());
                    }
                }
                ctsp.MaHangSanXuat = _service.GetIdHangSX(cbx_HangSX.Text);
                ctsp.MaMauSac = _service.GetIdMauSac(cbx_MauSac.Text);
                ctsp.MaChatLieu = _service.GetIdChatLieu(cbx_ChatLieu.Text);
                ctsp.MaLoaiRen = _service.GetIdLoaiRen(cbx_LoaiRen.Text);
                ctsp.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
                ctsp.ChieuDai = Convert.ToDouble(txt_ChieuDai.Text);
                ctsp.CanNang = Convert.ToDouble(txt_CanNang.Text);
                ctsp.TrangThai = cbx_TrangThai.Text;
                ctsp.GiaBan = giaBan;


                // Chỉ gán dữ liệu hình ảnh nếu có dữ liệu hình ảnh mới
                if (imageData != null)
                {
                    ctsp.HinhAnh = imageData;
                }

                // Hiển thị hộp thoại xác nhận
                var option = MessageBox.Show("Xác nhận muốn cập nhật sản phẩm?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (option == DialogResult.Yes)
                {

                    // Thêm sản phẩm vào cơ sở dữ liệu và xử lý kết quả
                    MessageBox.Show(_service.Update(ctsp));
                    // Tải lại danh sách sản phẩm sau khi thêm thành công
                    LoadGird(ApplyFilters());
                    ResetInput();


                }
                else
                {
                    return;
                }
            }
        }


        // Phương thức kiểm tra xem ảnh có phải là ảnh mặc định hay không
        private bool IsDefaultImage(Image image)
        {
            // Đặc tả cách kiểm tra ảnh mặc định tại đây
            // Ví dụ:
            // return (image == defaultImage);
            return false; // Cập nhật logic kiểm tra ảnh mặc định ở đây
        }



        private void pn_XoaSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có sản phẩm được chọn hay không
            if (_idwhenclick == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ctsp = new ChiTietSanPham();
            ctsp.Id = _idwhenclick;
            var option = MessageBox.Show("Xác nhận muốn xoá sản phẩm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Remove(ctsp));
                LoadGird(ApplyFilters());
            }
            else
            {
                return;
            }
        }



        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            LoadGird(ApplyFilters());
        }

        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _listSP.Count)
            {
                return;
            }
            var obj = _listSP[index];
            _idwhenclick = obj.Id;
            txt_TenSanPham.Text = obj.SanPham.TenSanPham;
            cbx_HangSX.SelectedItem = obj.HangSanXuat.Name;
            cbx_MauSac.SelectedItem = obj.MauSac.Name;
            cbx_ChatLieu.SelectedItem = obj.ChatLieu.Name;
            cbx_LoaiRen.SelectedItem = obj.LoaiRen.Name;
            txt_SoLuong.Text = obj.SoLuong.ToString();
            txt_GiaBan.Text = obj.GiaBan.ToString();
            txt_ChieuDai.Text = obj.ChieuDai.ToString();
            txt_CanNang.Text = obj.CanNang.ToString();
            cbx_LoaiSP.SelectedItem = obj.SanPham.LoaiSanPham.ToString();
            cbx_TrangThai.SelectedItem = obj.TrangThai.ToString();

            // Kiểm tra xem dữ liệu VARBINARY có tồn tại không
            if (obj.HinhAnh != null && obj.HinhAnh.Length > 0)
            {
                // Chuyển đổi dữ liệu byte thành hình ảnh
                using (MemoryStream ms = new MemoryStream(obj.HinhAnh))
                {
                    ptb_Anh.Image = Image.FromStream(ms);
                    ptb_Anh.BackgroundImage = null;
                }
            }
            else
            {
                // Nếu không có hình ảnh, gán hình mặc định hoặc hiển thị một thông báo khác
                ptb_Anh.Image = null; // Gán hình mặc định
                                      // Hoặc hiển thị một thông báo khác
                MessageBox.Show("Không có hình ảnh.");
            }


        }

        private void dtgView_CellClick_MauSac(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index < 0 || dtg_DSMau.SelectedRows.Count > 1)
            {
                return;
            }
            else
            {
                if (dtg_DSMau.Rows[index].Cells[0].Value == null)
                {
                    return;
                }

                _idMS = Guid.Parse(dtg_DSMau.Rows[index].Cells[0].Value.ToString());

                txt_MauSac_2.Text = dtg_DSMau.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void dtgView_CellClick_ChatLieu(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index < 0 || dtg_DSChatLieu.SelectedRows.Count > 1)
            {
                return;
            }
            else
            {
                if (dtg_DSChatLieu.Rows[index].Cells[0].Value == null)
                {
                    return;
                }

                _idCL = Guid.Parse(dtg_DSChatLieu.Rows[index].Cells[0].Value.ToString());

                txt_ChatLieu_2.Text = dtg_DSChatLieu.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void dtgView_CellClick_LoaiRen(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index < 0 || dtg_DSLoaiRen.SelectedRows.Count > 1)
            {
                return;
            }
            else
            {
                if (dtg_DSLoaiRen.Rows[index].Cells[0].Value == null)
                {
                    return;
                }

                _idLR = Guid.Parse(dtg_DSLoaiRen.Rows[index].Cells[0].Value.ToString());

                txt_LoaiRen_2.Text = dtg_DSLoaiRen.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void dtgView_CellClick_HangSX(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index < 0 || dtg_DSHangSX.SelectedRows.Count > 1)
            {
                return;
            }
            else
            {
                if (dtg_DSHangSX.Rows[index].Cells[0].Value == null)
                {
                    return;
                }

                _idHS = Guid.Parse(dtg_DSHangSX.Rows[index].Cells[0].Value.ToString());

                txt_HangSanXuat_2.Text = dtg_DSHangSX.Rows[index].Cells[2].Value.ToString();
            }
        }



        private void dtgView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 13 && e.Value != null) // Kiểm tra nếu đây là cột hình ảnh và giá trị không null
            {
                // Kiểm tra xem dữ liệu VARBINARY có tồn tại không
                byte[] imageData = (byte[])e.Value; // Cast giá trị của cột thành mảng byte hình ảnh
                if (imageData.Length > 0)
                {
                    // Chuyển đổi dữ liệu byte thành hình ảnh
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        // Gán hình ảnh vào ô cột tương ứng
                        e.Value = Image.FromStream(ms);
                        ;
                    }
                }
                else
                {
                    // Nếu không có hình ảnh, gán hình mặc định hoặc hiển thị một thông báo khác
                    e.Value = null; // Gán hình mặc định hoặc null
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chức năng thêm ảnh chưa được hoàn thiện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // Tạo một hộp thoại mở tệp tin
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";
            openFileDialog.Title = "Chọn ảnh sản phẩm";

            // Hiển thị hộp thoại mở tệp tin và kiểm tra kết quả
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy đường dẫn đến tệp tin hình ảnh đã chọn
                    string imagePath = openFileDialog.FileName;

                    // Đọc hình ảnh từ đường dẫn và hiển thị trong PictureBox
                    ptb_Anh.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải hình ảnh: " + ex.Message);
                }
            }
        }
        private void ExportToExcel(List<ChiTietSanPham> data)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Danh sách sản phẩm");

                worksheet.Cells[1, 1].Value = "Mã Sản Phẩm";
                worksheet.Cells[1, 2].Value = "Tên Sản Phẩm";
                worksheet.Cells[1, 3].Value = "Hãng Sản Xuất";
                worksheet.Cells[1, 4].Value = "Màu sắc";
                worksheet.Cells[1, 5].Value = "Chất liệu";
                worksheet.Cells[1, 6].Value = "Loại ren";
                worksheet.Cells[1, 7].Value = "Chiều dài";
                worksheet.Cells[1, 8].Value = "Cân nặng";
                worksheet.Cells[1, 9].Value = "Giá Bán";
                worksheet.Cells[1, 10].Value = "Loại sản phẩm";
                worksheet.Cells[1, 11].Value = "Trạng Thái";

                int row = 2;
                foreach (var ctsp in data)
                {
                    worksheet.Cells[row, 1].Value = ctsp.Id;
                    worksheet.Cells[row, 2].Value = ctsp.SanPham.TenSanPham;
                    worksheet.Cells[row, 3].Value = ctsp.HangSanXuat.Name;
                    worksheet.Cells[row, 4].Value = ctsp.MauSac.Name;
                    worksheet.Cells[row, 5].Value = ctsp.ChatLieu.Name;
                    worksheet.Cells[row, 6].Value = ctsp.LoaiRen.Name;
                    worksheet.Cells[row, 7].Value = ctsp.ChieuDai;
                    worksheet.Cells[row, 8].Value = ctsp.CanNang;
                    worksheet.Cells[row, 9].Value = ctsp.GiaBan;
                    worksheet.Cells[row, 10].Value = ctsp.SanPham.LoaiSanPham;
                    worksheet.Cells[row, 11].Value = ctsp.TrangThai;

                    row++;
                }

                // Lưu file Excel
                using (var stream = new MemoryStream())
                {
                    excelPackage.SaveAs(stream);
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (Path.GetExtension(saveFileDialog.FileName).ToLower() != ".xlsx")
                        {
                            MessageBox.Show("Chỉ chấp nhận định dạng .xlsx cho tệp tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create);
                            stream.WriteTo(fs);
                            fs.Close();
                        }
                    }
                }
            }
        }

        private void pn_XuatExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(_listSP);
        }

        private void txt_GiaBan_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem chuỗi có độ dài lớn hơn 0 không
            if (txt_GiaBan.Text.Length > 0)
            {
                // Lọc chuỗi chỉ giữ lại ký tự số và dấu "."
                string input = Regex.Replace(txt_GiaBan.Text, "[^0-9.]", "");

                // Kiểm tra xem sau khi lọc, chuỗi có độ dài lớn hơn 0 không
                if (input.Length > 0)
                {
                    // Kiểm tra xem chuỗi chỉ có duy nhất một dấu "."
                    if (input.Count(c => c == '.') <= 1)
                    {
                        // Chuyển đổi chuỗi thành số nguyên
                        if (decimal.TryParse(input, out decimal giaNhap))
                        {
                            // Định dạng số tiền và hiển thị lại trong textbox
                            txt_GiaBan.Text = giaNhap.ToString("#,##0");
                            // Di chuyển con trỏ về cuối textbox để người dùng có thể tiếp tục nhập
                            txt_GiaBan.SelectionStart = txt_GiaBan.Text.Length;
                        }
                        else
                        {
                            // Nếu người dùng nhập không phải là số, xóa ký tự vừa nhập và hiển thị thông báo
                            txt_GiaBan.Text = txt_GiaBan.Text.Substring(0, txt_GiaBan.Text.Length - 1);
                            MessageBox.Show("Vui lòng nhập số nguyên.");
                        }
                    }
                    else
                    {
                        // Nếu chuỗi chứa nhiều hơn một dấu ".", xóa ký tự vừa nhập và hiển thị thông báo
                        txt_GiaBan.Text = txt_GiaBan.Text.Substring(0, txt_GiaBan.Text.Length - 1);
                        MessageBox.Show("Số tiền không hợp lệ.");
                    }
                }
            }
        }

        private void pn_LamMoi_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập các ký tự số và điều khiển
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbx_Fill_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGird(ApplyFilters());
        }

        private List<ChiTietSanPham> ApplyFilters()
        {
            Func<ChiTietSanPham, bool> dk1 = null;
            Func<ChiTietSanPham, bool> dk2 = null;
            Func<ChiTietSanPham, bool> dk3 = null;
            Func<ChiTietSanPham, bool> dk4 = null;
            Func<ChiTietSanPham, bool> dk5 = null;

            if (cbx_FillHangSX.SelectedItem != null && cbx_FillHangSX.SelectedItem.ToString() != "Tất cả")
            {
                dk1 = sp => sp.MaHangSanXuat == _service.GetIdHangSX(cbx_FillHangSX.SelectedItem.ToString());
            }

            if (cbx_FillMauSac.SelectedItem != null && cbx_FillMauSac.SelectedItem.ToString() != "Tất cả")
            {
                dk2 = sp => sp.MaMauSac == _service.GetIdMauSac(cbx_FillMauSac.SelectedItem.ToString());
            }

            if (cbx_FillChatLieu.SelectedItem != null && cbx_FillChatLieu.SelectedItem.ToString() != "Tất cả")
            {
                dk3 = sp => sp.MaChatLieu == _service.GetIdChatLieu(cbx_FillChatLieu.SelectedItem.ToString());
            }

            if (cbx_FillLoaiRen.SelectedItem != null && cbx_FillLoaiRen.SelectedItem.ToString() != "Tất cả")
            {
                dk4 = sp => sp.MaLoaiRen == _service.GetIdLoaiRen(cbx_FillLoaiRen.SelectedItem.ToString());
            }

            if (txt_Search.Text != null)
            {
                dk5 = sp => sp.SanPham.TenSanPham.ToLower().Contains(txt_Search.Text.Trim().ToLower());
            }

            var filterSP = _service.FillSP(_service.GetAll(), dk1, dk2, dk3, dk4, dk5);

            return filterSP;
        }

        private void cbx_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CheckStatus(string input)
        {


        }

        public void btn_AddThanhPhan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_ChatLieu_2.Text))
            {
                _service.CreateThanhPhan<ChatLieu>(new ChatLieu { Id = Guid.NewGuid(), Name = txt_ChatLieu_2.Text.Trim() });
            }

            if (!string.IsNullOrWhiteSpace(txt_MauSac_2.Text))
            {
                _service.CreateThanhPhan<MauSac>(new MauSac { Id = Guid.NewGuid(), Name = txt_MauSac_2.Text.Trim() });
            }

            if (!string.IsNullOrWhiteSpace(txt_LoaiRen_2.Text))
            {
                _service.CreateThanhPhan<LoaiRen>(new LoaiRen { Id = Guid.NewGuid(), Name = txt_LoaiRen_2.Text.Trim() });
            }

            if (!string.IsNullOrWhiteSpace(txt_HangSanXuat_2.Text))
            {
                _service.CreateThanhPhan<HangSanXuat>(new HangSanXuat { Id = Guid.NewGuid(), Name = txt_HangSanXuat_2.Text.Trim() });
            }

            MessageBox.Show("Thêm thành công");
            ResetInput();
            LoadGrid2();
        }

        public void btn_DelTP_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (!string.IsNullOrWhiteSpace(txt_ChatLieu_2.Text))
            {
                if (!_service.DeleteThanhPhan<ChatLieu>(_idCL)) check = false;
            }

            if (!string.IsNullOrWhiteSpace(txt_MauSac_2.Text))
            {
                if (!_service.DeleteThanhPhan<MauSac>(_idMS)) check = false;
            }

            if (!string.IsNullOrWhiteSpace(txt_LoaiRen_2.Text))
            {
                if (!_service.DeleteThanhPhan<LoaiRen>(_idLR)) check = false;
            }

            if (!string.IsNullOrWhiteSpace(txt_HangSanXuat_2.Text))
            {
                if (!_service.DeleteThanhPhan<HangSanXuat>(_idHS)) check = false;
            }

            if (check)
            {
                MessageBox.Show("Xóa thành công");
                ResetInput();
                LoadGrid2();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                ResetInput();
                LoadGrid2();
            }
        }

        public void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetInput();
            LoadGrid2();
        }

        public void ResetInput()
        {
            txt_ChatLieu_2.Text = null;
            txt_MauSac_2.Text = null;
            txt_HangSanXuat_2.Text = null;
            txt_LoaiRen_2.Text = null;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (textBox != txt_SoLuong)
            {
                // Kiểm tra nếu ký tự không phải là số (0-9) và không phải là dấu chấm (.)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                // Kiểm tra nếu đã có dấu chấm trong TextBox
                if (e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }

                // Không cho phép dấu chấm ở đầu chuỗi
                if (e.KeyChar == '.' && textBox.SelectionStart == 0)
                {
                    e.Handled = true;
                }

                // Không cho phép dấu âm
                if (e.KeyChar == '-' && textBox.SelectionStart != 0)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }
    }

}

