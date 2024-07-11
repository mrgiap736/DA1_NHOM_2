using App.Data.Entities;
using App.Services.Services;
using Microsoft.IdentityModel.Tokens;
using OfficeOpenXml;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace App.Winform.UI
{
    public partial class Form_SanPham : Form
    {
        SanPham_Services _service;
        List<SanPham> _listSP = new();
        string _idwhenclick;
        public Form_SanPham(NhanVien nv)
        {
            InitializeComponent();
            _service = new SanPham_Services();
            LoadGird(null);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ///123///////2113232
            PhanQuyen_NhanVien(nv);
        }
        

        private void Form_SanPham_Load(object sender, EventArgs e)
        {
            
        }

        private void PhanQuyen_NhanVien(NhanVien nv)
        {
            if (nv.ChucVu.Equals("Nhân viên"))
            {
                grb_ChucNang.Enabled = false;

                grb_ChucNang.Click += NotClick;
            }
            else return;
        }

        //khong cho phep nv su dung chuc nang
        private void NotClick(object sender, EventArgs e)
        {
            MessageBox.Show("Nhân viên không thể sử dụng chức năng này !");
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
        public void LoadGird(string search)
        {
            dtgView.Rows.Clear();
            dtgView.ColumnCount = 9;
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "Mã Sản Phẩm";
            dtgView.Columns[2].Name = "Tên Sản Phẩm";
            dtgView.Columns[3].Name = "Hàng Sản Phẩm";
            dtgView.Columns[4].Name = "Thông Số Kỹ Thuật";
            dtgView.Columns[5].Name = "Giá Nhập";
            dtgView.Columns[6].Name = "Giá Bán";
            dtgView.Columns[7].Name = "Trạng Thái";
            dtgView.Columns[8].Name = "Hình Ảnh";

            _listSP = _service.GetAll(txt_Search.Text);
            foreach (var sp in _listSP)
            {
                int stt = _listSP.IndexOf(sp) + 1;
                string giaNhapFormatted = sp.GiaNhap.ToString("#,##0");
                string giaBanFormatted = sp.GiaBan.ToString("#,##0");
                dtgView.Rows.Add(stt, sp.MaSanPham, sp.TenSanPham, sp.HangSanXuat, sp.ThongSoKyThuat,
                    giaNhapFormatted, giaBanFormatted, sp.TrangThai,sp.HinhAnh);
            }
            dtgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void pn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_MaSanPham.Text = "";
            txt_TenSanPham.Text = "";
            txt_HangSanPham.Text = "";
            txt_ThongSoKyThuat.Text = "";
            txt_GiaNhap.Text = "";
            txt_GiaBan.Text = "";

            rd_ConHang.Checked = false;
            rd_HetHang.Checked = false;
            ptb_Anh.Image = null;
        }

        private void pn_ThemSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(txt_MaSanPham.Text) || string.IsNullOrWhiteSpace(txt_TenSanPham.Text) ||
                string.IsNullOrWhiteSpace(txt_HangSanPham.Text) || string.IsNullOrWhiteSpace(txt_ThongSoKyThuat.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ptb_Anh.Image == null)
            {
                MessageBox.Show("Vui lòng tải ảnh sản phẩm.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_MaSanPham.Text.Length < 3 || txt_MaSanPham.Text.Length > 10)
            {
                MessageBox.Show("Mã sản phẩm phải có ít nhất 3 và tối đa 10 ký tự.",
                                "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra độ dài tên sản phẩm
            if (txt_TenSanPham.Text.Length > 50)
            {
                MessageBox.Show("Tên sản phẩm chỉ được phép nhập tối đa 50 ký tự.",
                                "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra độ dài hãng sản xuất
            if (txt_HangSanPham.Text.Length > 20)
            {
                MessageBox.Show("Hãng sản xuất chỉ được phép nhập tối đa 20 ký tự.",
                                "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra độ dài thông số kỹ thuật
            if (txt_ThongSoKyThuat.Text.Length > 200)
            {
                MessageBox.Show("Thông số kỹ thuật chỉ được phép nhập tối đa 200 ký tự.",
                                "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra giá nhập và giá bán có phải số không
            if (!int.TryParse(txt_GiaNhap.Text.Replace(",", ""), out int giaNhap) ||
                !int.TryParse(txt_GiaBan.Text.Replace(",", ""), out int giaBan))
            {
                MessageBox.Show("Giá nhập và giá bán phải là số.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Kiểm tra giá nhập và giá bán có lớn hơn hoặc bằng 1,000 không
            if (giaNhap < 1000 || giaBan < 1000)
            {
                MessageBox.Show(
                    "Giá nhập và giá bán phải lớn hơn hoặc bằng 1,000.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra xem mã sản phẩm đã tồn tại hay chưa
            foreach (var existingSP in _listSP)
            {
                if (existingSP.MaSanPham == txt_MaSanPham.Text)
                {
                    MessageBox.Show(
                        text: "Mã sản phẩm đã bị trùng, vui lòng nhập mã sản phẩm khác.",
                        caption: "Thông báo",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Warning);
                    return;
                }
            }
            // Kiểm tra xem mã sản phẩm có chứa ký tự đặc biệt hay không
            string maSanPham = txt_MaSanPham.Text;
            if (!Regex.IsMatch(maSanPham, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Mã sản phẩm không được chứa ký tự đặc biệt.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        ptb_Anh.Image.Save(ms, ptb_Anh.Image.RawFormat);
                        ptb_Anh.BackgroundImage = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu ảnh ");
                    }
                    imageData = ms.ToArray();
                }
            }
            var sp = new SanPham();
            sp.MaSanPham = txt_MaSanPham.Text;
            sp.TenSanPham = txt_TenSanPham.Text;
            sp.HangSanXuat = txt_HangSanPham.Text;
            sp.ThongSoKyThuat = txt_ThongSoKyThuat.Text;
            sp.GiaNhap = giaNhap;
            sp.GiaBan = giaBan;
            sp.HinhAnh = imageData;

            // Kiểm tra trạng thái sản phẩm
            if (rd_ConHang.Checked)
            {
                sp.TrangThai = 1;
            }
            else if (rd_HetHang.Checked)
            {
                sp.TrangThai = 0;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn trạng thái sản phẩm.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận
            var option = MessageBox.Show("Xác nhận muốn thêm sản phẩm?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                // Thêm sản phẩm vào cơ sở dữ liệu và xử lý kết quả
                MessageBox.Show(_service.Add(sp));
                // Tải lại danh sách sản phẩm sau khi thêm thành công
                LoadGird(null);
            }
            else
            {
                return;
            }
        }



        private void pn_UpdateSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn sản phẩm để cập nhật chưa
            if (_idwhenclick == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn cập nhật.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra dữ liệu nhập vào và các điều kiện khác
            if (string.IsNullOrWhiteSpace(txt_MaSanPham.Text) ||
                string.IsNullOrWhiteSpace(txt_TenSanPham.Text) ||
                string.IsNullOrWhiteSpace(txt_HangSanPham.Text) ||
                string.IsNullOrWhiteSpace(txt_ThongSoKyThuat.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_MaSanPham.Text.Length < 3 || txt_MaSanPham.Text.Length > 10)
            {
                MessageBox.Show("Mã sản phẩm phải có ít nhất 3 và tối đa 10 ký tự.",
                                "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra độ dài tên sản phẩm
            if (txt_TenSanPham.Text.Length > 50)
            {
                MessageBox.Show("Tên sản phẩm chỉ được phép nhập tối đa 50 ký tự.",
                                "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra độ dài hãng sản xuất
            if (txt_HangSanPham.Text.Length > 20)
            {
                MessageBox.Show("Hãng sản xuất chỉ được phép nhập tối đa 20 ký tự.",
                                "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra độ dài thông số kỹ thuật
            if (txt_ThongSoKyThuat.Text.Length > 200)
            {
                MessageBox.Show("Thông số kỹ thuật chỉ được phép nhập tối đa 200 ký tự.",
                                "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra giá nhập và giá bán có phải số không
            if (!int.TryParse(txt_GiaNhap.Text.Replace(",", ""), out int giaNhap) ||
                !int.TryParse(txt_GiaBan.Text.Replace(",", ""), out int giaBan))
            {
                MessageBox.Show("Giá nhập và giá bán phải là số.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giá nhập và giá bán có lớn hơn hoặc bằng 1,000 không
            if (giaNhap < 1000 || giaBan < 1000)
            {
                MessageBox.Show("Giá nhập và giá bán phải lớn hơn hoặc bằng 1,000.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem mã sản phẩm có chứa ký tự đặc biệt hay không
            string maSanPham = txt_MaSanPham.Text;
            if (!Regex.IsMatch(maSanPham, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Mã sản phẩm không được chứa ký tự đặc biệt.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        ptb_Anh.Image.Save(ms, ptb_Anh.Image.RawFormat);
                        ptb_Anh.BackgroundImage = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu ảnh ");
                    }

                    imageData = ms.ToArray();
                    

                }
            }
            else
            {
                // Nếu không chọn ảnh mới, giữ nguyên ảnh cũ từ dữ liệu sản phẩm
                // Thay vì gán giá trị null cho imageData, hãy lấy dữ liệu ảnh từ cơ sở dữ liệu hoặc dịch vụ của bạn
                // Ví dụ: imageData = _service.GetImageData(_idwhenclick);
                // hoặc imageData = GetImageDataFromDatabase(_idwhenclick);
            }

            var sp = new SanPham();
            sp.MaSanPham = _idwhenclick;
            sp.TenSanPham = txt_TenSanPham.Text;
            sp.HangSanXuat = txt_HangSanPham.Text;
            sp.ThongSoKyThuat = txt_ThongSoKyThuat.Text;
            sp.GiaNhap = giaNhap;
            sp.GiaBan = giaBan;

            // Chỉ gán dữ liệu hình ảnh nếu có dữ liệu hình ảnh mới
            if (imageData != null)
            {
                sp.HinhAnh = imageData;
            }

            // Kiểm tra trạng thái sản phẩm
            if (rd_ConHang.Checked)
            {
                sp.TrangThai = 1;
            }
            else if (rd_HetHang.Checked)
            {
                sp.TrangThai = 0;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn trạng thái sản phẩm.", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại xác nhận
            var option = MessageBox.Show("Xác nhận muốn cập nhật sản phẩm?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                // Thêm sản phẩm vào cơ sở dữ liệu và xử lý kết quả
                MessageBox.Show(_service.Update(sp));
                // Tải lại danh sách sản phẩm sau khi thêm thành công
                LoadGird(null);
            }
            else
            {
                return;
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
            if (string.IsNullOrEmpty(_idwhenclick))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sp = new SanPham();
            sp.MaSanPham = _idwhenclick;
            var option = MessageBox.Show("Xác nhận muốn xoá sản phẩm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Remove(sp));
                LoadGird(null);
            }
            else
            {
                return;
            }
        }



        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            LoadGird(null);
        }

        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _listSP.Count)
            {
                return;
            }
            var obj = _listSP[index];
            _idwhenclick = obj.MaSanPham;
            txt_MaSanPham.Text = obj.MaSanPham;
            txt_TenSanPham.Text = obj.TenSanPham;
            txt_HangSanPham.Text = obj.HangSanXuat;
            txt_ThongSoKyThuat.Text = obj.ThongSoKyThuat;
            txt_GiaNhap.Text = obj.GiaNhap.ToString();
            txt_GiaBan.Text = obj.GiaBan.ToString();

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


            if (obj.TrangThai == 1)
            {
                rd_ConHang.Checked = true;
            }
            else if (obj.TrangThai == 0)
            {
                rd_HetHang.Checked = true;
            }
        }



        private void dtgView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.Value != null) // Kiểm tra nếu đây là cột hình ảnh và giá trị không null
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
            //(ví dụ: cột có index = 7)
            if (e.ColumnIndex == 7 && e.Value != null)
            {
                int trangThai = Convert.ToInt32(e.Value);
                if (trangThai == 1)
                {
                    e.Value = "Còn hàng";
                }
                else if (trangThai == 0)
                {
                    e.Value = "Hết hàng";
                }
                e.FormattingApplied = true;
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
        private void ExportToExcel(List<SanPham> data)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Danh sách sản phẩm");

                worksheet.Cells[1, 1].Value = "Mã Sản Phẩm";
                worksheet.Cells[1, 2].Value = "Tên Sản Phẩm";
                worksheet.Cells[1, 3].Value = "Hãng Sản Xuất";
                worksheet.Cells[1, 4].Value = "Thông Số Kỹ Thuật";
                worksheet.Cells[1, 5].Value = "Giá Nhập";
                worksheet.Cells[1, 6].Value = "Giá Bán";
                worksheet.Cells[1, 7].Value = "Trạng Thái";

                int row = 2;
                foreach (var sp in data)
                {
                    worksheet.Cells[row, 1].Value = sp.MaSanPham;
                    worksheet.Cells[row, 2].Value = sp.TenSanPham;
                    worksheet.Cells[row, 3].Value = sp.HangSanXuat;
                    worksheet.Cells[row, 4].Value = sp.ThongSoKyThuat;
                    worksheet.Cells[row, 5].Value = sp.GiaNhap;
                    worksheet.Cells[row, 6].Value = sp.GiaBan;
                    worksheet.Cells[row, 7].Value = sp.TrangThai == 1 ? "Còn hàng" : "Hết hàng";

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


        private void pn_XuatExcel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_XuatExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(_listSP);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pn_LamMoi_Click(sender, e);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            pn_LamMoi_Click(sender, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pn_ThemSP_Click(sender, e);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            pn_ThemSP_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pn_UpdateSP_Click(sender, e);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            pn_UpdateSP_Click(sender, e);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pn_XoaSP_Click(sender, e);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            pn_XoaSP_Click(sender, e);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pn_XuatExcel_Click(sender, e);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            pn_XuatExcel_Click(sender, e);
        }

        private void txt_GiaNhap_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem chuỗi có độ dài lớn hơn 0 không
            if (txt_GiaNhap.Text.Length > 0)
            {
                // Lọc chuỗi chỉ giữ lại ký tự số và dấu "."
                string input = Regex.Replace(txt_GiaNhap.Text, "[^0-9.]", "");

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
                            txt_GiaNhap.Text = giaNhap.ToString("#,##0");
                            // Di chuyển con trỏ về cuối textbox để người dùng có thể tiếp tục nhập
                            txt_GiaNhap.SelectionStart = txt_GiaNhap.Text.Length;
                        }
                        else
                        {
                            // Nếu người dùng nhập không phải là số, xóa ký tự vừa nhập và hiển thị thông báo
                            txt_GiaNhap.Text = txt_GiaNhap.Text.Substring(0, txt_GiaNhap.Text.Length - 1);
                            MessageBox.Show("Vui lòng nhập số nguyên.");
                        }
                    }
                    else
                    {
                        // Nếu chuỗi chứa nhiều hơn một dấu ".", xóa ký tự vừa nhập và hiển thị thông báo
                        txt_GiaNhap.Text = txt_GiaNhap.Text.Substring(0, txt_GiaNhap.Text.Length - 1);
                        MessageBox.Show("Số tiền không hợp lệ.");
                    }
                }
            }
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

        private void pn_LamMoi_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pn_LamMoi_MouseLeave(object sender, EventArgs e)
        {

        }

      
    }

}

