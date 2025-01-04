using Microsoft.Data.SqlClient;
using QLKSDAO;
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

namespace Form_DSPhong_HoaDon
{
    public partial class Form_HoaDon : Form
    {
        public Form_HoaDon()
        {
            InitializeComponent();
            btn_Tim.Click += btn_Tim_Click;
            btn_reset.Click += btn_reset_Click;
            lv_HoaDonThanhToan.SelectedIndexChanged += lv_HoaDonThanhToan_SelectedIndexChanged;
        }
        private void LoadThueToListView(List<Thue> dsThue)
        {
            lv_HoaDonThanhToan.Items.Clear();
            int stt = 1;
            decimal tongTriGia = 0;

            foreach (var thue in dsThue)
            {
                decimal thanhTien = ThueDAO.TinhThanhTien(thue.MaPhong, thue.NgayDat, thue.NgayTra);
                var phong = PhongDAO.LayThongTinPhong(thue.MaPhong);

                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(thue.MaPhong);
                item.SubItems.Add((thue.NgayTra - thue.NgayDat).Days.ToString());
                item.SubItems.Add(string.Format("{0:#,##0}", phong.Gia));
                item.SubItems.Add(string.Format("{0:#,##0}", thanhTien));

                item.Tag = new { Thue = thue, ThanhTien = thanhTien };
                lv_HoaDonThanhToan.Items.Add(item);

                stt++;
                tongTriGia += thanhTien;
            }

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
            ClearForm();
        }
        private void lv_HoaDonThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_HoaDonThanhToan.SelectedItems.Count > 0)
            {
                dynamic itemData = lv_HoaDonThanhToan.SelectedItems[0].Tag;
                txt_TriGia.Text = string.Format("{0:#,##0}", itemData.ThanhTien);
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (lv_HoaDonThanhToan.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_HoaDonThanhToan.SelectedItems[0];
                dynamic itemData = selectedItem.Tag;
                var thue = itemData.Thue;
                decimal thanhTien = itemData.ThanhTien;

                string maHD = $"{thue.MaPhong}-{thue.NgayDat:yyMMdd}";

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
                    HoaDonDAO.ThemHoaDon(hoaDon);
                    MessageBox.Show("Thanh toán thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btn_Tim_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thanh toán: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần thanh toán!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string cmnd = txt_KhachHang.Text.Trim();
            if (string.IsNullOrEmpty(cmnd))
            {
                MessageBox.Show("Vui lòng nhập CMND để tìm kiếm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var khachHang = ThueDAO.LayThongTinKhachHang(cmnd);
            if (khachHang == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng với CMND này!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txt_DiaChi.Text = khachHang.DiaChi;

            var dsThue = ThueDAO.LayThueKhachChuaThanhToan(cmnd);
            LoadThueToListView(dsThue);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txt_KhachHang.Clear();
            txt_DiaChi.Clear();
            txt_TriGia.Clear();
            lv_HoaDonThanhToan.Items.Clear();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
