using Microsoft.Data.SqlClient;
using QLKSBUS;
using QLKSDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKSGUI
{
    public partial class Form_HoaDon : Form
    {
        public Form_HoaDon()
        {
            InitializeComponent();
            btn_Tim.Click += btn_Tim_Click; // Gán sự kiện Click cho nút tìm
            btn_reset.Click += btn_reset_Click; // Gán sự kiện Click cho nút reset
            lv_HoaDonThanhToan.SelectedIndexChanged += lv_HoaDonThanhToan_SelectedIndexChanged; // Gán sự kiện khi chọn item trong ListView
            btn_ThanhToan.Enabled = false;
        }

        // Tải danh sách thuê lên ListView
        private void LoadThueToListView(List<Thue> dsThue)
        {
            lv_HoaDonThanhToan.Items.Clear(); // Xóa danh sách cũ
            int stt = 1; // Khởi tạo số thứ tự
            decimal tongTriGia = 0; // Tổng trị giá ban đầu

            foreach (var thue in dsThue)
            {
                decimal thanhTien = ThueBUS.TinhThanhTien(thue.MaPhong, thue.NgayDat, thue.NgayTra); // Tính thành tiền
                var phong = PhongBUS.LayTTPhong(thue.MaPhong); // Lấy thông tin phòng

                // Tạo item ListView
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(thue.MaPhong);
                item.SubItems.Add((thue.NgayTra - thue.NgayDat).Days.ToString()); // Số ngày thuê
                item.SubItems.Add(string.Format("{0:#,##0}", phong.Gia)); // Hiển thị giá phòng
                item.SubItems.Add(string.Format("{0:#,##0}", thanhTien)); // Hiển thị thành tiền

                item.Tag = new { Thue = thue, ThanhTien = thanhTien }; // Lưu dữ liệu trong Tag
                lv_HoaDonThanhToan.Items.Add(item);

                stt++;
                tongTriGia += thanhTien; // Cộng dồn thành tiền vào tổng trị giá
            }

            // Hiển thị tổng trị giá
            if (dsThue.Count > 0)
            {
                txt_TriGia.Text = string.Format("{0:#,##0}", tongTriGia);
            }
            else
            {
                MessageBox.Show("Khách hàng này không có phòng nào chưa thanh toán!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            ClearForm(); // Xóa dữ liệu khi form được load
        }

        private void lv_HoaDonThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_HoaDonThanhToan.SelectedItems.Count > 0)
            {
                dynamic itemData = lv_HoaDonThanhToan.SelectedItems[0].Tag;
                txt_TriGia.Text = string.Format("{0:#,##0}", itemData.ThanhTien); // Hiển thị thành tiền
                btn_ThanhToan.Enabled = true; // Bật nút thanh toán
            }
            else
            {
                txt_TriGia.Clear(); // Xóa thông tin trị giá
                btn_ThanhToan.Enabled = false; // Tắt nút thanh toán
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (lv_HoaDonThanhToan.SelectedItems.Count > 0)
            {
                // Lấy item đã chọn trong ListView
                ListViewItem selectedItem = lv_HoaDonThanhToan.SelectedItems[0];
                dynamic itemData = selectedItem.Tag;
                var thue = itemData.Thue;
                decimal thanhTien = itemData.ThanhTien;

                // Tạo mã hóa đơn
                string maHD = $"{thue.MaPhong}-{thue.NgayDat:yyMMdd}";

                // Khởi tạo đối tượng Hóa Đơn
                HoaDon hoaDon = new HoaDon
                {
                    MaHD = maHD,
                    ThanhTien = Convert.ToInt32(thanhTien),
                    NgayDat = thue.NgayDat,
                    NgayTra = thue.NgayTra,
                    CMND = thue.CMND,
                    MaPhong = thue.MaPhong
                };

                try
                {
                    // Thêm hóa đơn vào cơ sở dữ liệu
                    bool hoaDonSuccess = HoaDonBUS.ThemHoaDon(hoaDon);
                    if (hoaDonSuccess)
                    {
                        MessageBox.Show("Thanh toán thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btn_Tim_Click(sender, e); // Tải lại danh sách thuê
                    }
                    else
                    {
                        throw new Exception("Không thể tạo hóa đơn");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thanh toán: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_ThanhToan.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần thanh toán!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btn_ThanhToan.Enabled = false;
            txt_TriGia.Clear();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string cmnd = txt_KhachHang.Text.Trim(); // Lấy CMND nhập từ người dùng
            if (string.IsNullOrEmpty(cmnd))
            {
                MessageBox.Show("Vui lòng nhập CMND để tìm kiếm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var khachHang = KhachHangBUS.LayKhachHangTheoCMND(cmnd); // Lấy thông tin khách hàng
            if (khachHang == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng với CMND này!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txt_DiaChi.Text = khachHang.DiaChi; // Hiển thị địa chỉ khách hàng

            var dsThue = ThueBUS.LayDSPKhachChuaThanhToan(cmnd); // Lấy danh sách phòng chưa thanh toán
            LoadThueToListView(dsThue); // Hiển thị danh sách phòng
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ClearForm(); // Xóa dữ liệu trên form
        }

        private void ClearForm()
        {
            txt_KhachHang.Clear(); // Xóa CMND
            txt_DiaChi.Clear(); // Xóa địa chỉ
            txt_TriGia.Clear(); // Xóa trị giá
            lv_HoaDonThanhToan.Items.Clear(); // Xóa danh sách phòng
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form
        }
    }
}
