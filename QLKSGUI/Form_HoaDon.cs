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
            LoadDataToListView();
            btn_Tim.Click += btn_Tim_Click;
            btn_reset.Click += btn_reset_Click;
            lv_HoaDonThanhToan.SelectedIndexChanged += lv_HoaDonThanhToan_SelectedIndexChanged;
        }
        private void LoadDataToListView()
        {
            lv_HoaDonThanhToan.Items.Clear();

            string query = @"
        WITH RoomOccupancy AS (
            SELECT 
                t.MaPhong,
                t.NgayDat,
                t.NgayTra,
                MIN(t.CMND) as MainCMND, -- Lấy CMND đầu tiên làm người đại diện
                COUNT(*) as OccupantCount,
                MAX(CASE WHEN k.LoaiKH = N'Nước ngoài' THEN 1 ELSE 0 END) as HasForeignGuest
            FROM Thue t
            INNER JOIN KhachHang k ON t.CMND = k.CMND
            GROUP BY t.MaPhong, t.NgayDat, t.NgayTra
        )
        SELECT DISTINCT -- Đảm bảo không có bản ghi trùng lặp
            t.MaPhong,
            p.Gia as BasePrice,
            t.NgayDat,
            t.NgayTra,
            ro.OccupantCount,
            ro.HasForeignGuest,
            DATEDIFF(day, t.NgayDat, t.NgayTra) as SoNgayThue,
            p.LoaiPhong,
            k.CMND,
            k.TenKH,
            k.DiaChi,
            CASE 
                WHEN p.LoaiPhong = N'Phòng đơn' AND ro.OccupantCount > 1 THEN p.Gia * 1.25
                WHEN p.LoaiPhong = N'Phòng đôi' AND ro.OccupantCount > 2 THEN p.Gia * 1.25
                WHEN p.LoaiPhong = N'Phòng lớn' AND ro.OccupantCount > 8 THEN p.Gia * 1.25
                ELSE p.Gia
            END * 
            CASE WHEN ro.HasForeignGuest = 1 THEN 1.5 ELSE 1 END * 
            DATEDIFF(day, t.NgayDat, t.NgayTra) as ThanhTien
        FROM Thue t
        INNER JOIN Phong p ON t.MaPhong = p.MaPhong
        INNER JOIN RoomOccupancy ro ON t.MaPhong = ro.MaPhong 
            AND t.NgayDat = ro.NgayDat 
            AND t.NgayTra = ro.NgayTra
            AND t.CMND = ro.MainCMND -- Chỉ lấy thông tin của người đại diện
        INNER JOIN KhachHang k ON t.CMND = k.CMND
        WHERE NOT EXISTS (
            SELECT 1 
            FROM HoaDon h 
            WHERE h.MaPhong = t.MaPhong 
            AND h.NgayDat = t.NgayDat 
            AND h.NgayTra = t.NgayTra
        )
        ORDER BY t.MaPhong";

            DataTable dt = DataProvider.TruyVan_LayDuLieu(query);

            int stt = 1;
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(stt.ToString());

                // Store additional data in the ListViewItem's Tag property
                var itemData = new
                {
                    CMND = row["CMND"].ToString(),
                    TenKH = row["TenKH"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    ThanhTien = Convert.ToDouble(row["ThanhTien"]),
                    SoNguoi = Convert.ToInt32(row["OccupantCount"])
                };
                item.Tag = itemData;

                // Add visible columns
                item.SubItems.Add(row["MaPhong"].ToString());
                item.SubItems.Add(row["SoNgayThue"].ToString());
                item.SubItems.Add(string.Format("{0:#,##0}", Convert.ToDouble(row["BasePrice"])));
                item.SubItems.Add(string.Format("{0:#,##0}", Convert.ToDouble(row["ThanhTien"])));

                // Thêm thông tin về phụ thu
                string priceInfo = $"Số người ở: {itemData.SoNguoi}\n";
                if (Convert.ToBoolean(row["HasForeignGuest"]))
                    priceInfo += "Phụ thu khách nước ngoài (x1.5)\n";

                if ((row["LoaiPhong"].ToString() == "Phòng đơn" && Convert.ToInt32(row["OccupantCount"]) > 1) ||
                    (row["LoaiPhong"].ToString() == "Phòng đôi" && Convert.ToInt32(row["OccupantCount"]) > 2) ||
                    (row["LoaiPhong"].ToString() == "Phòng lớn" && Convert.ToInt32(row["OccupantCount"]) > 8))
                {
                    priceInfo += "Phụ thu vượt sức chứa (x1.25)";
                }

                item.ToolTipText = priceInfo;
                lv_HoaDonThanhToan.Items.Add(item);
                stt++;
            }
        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            LoadDataToListView();
        }
        private void lv_HoaDonThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_HoaDonThanhToan.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_HoaDonThanhToan.SelectedItems[0];
                dynamic itemData = selectedItem.Tag;

                // Update the textboxes with the selected row's data
                txt_KhachHang.Text = itemData.CMND;
                txt_DiaChi.Text = itemData.DiaChi;
                txt_TriGia.Text = string.Format("{0:#,##0}", itemData.ThanhTien);
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (lv_HoaDonThanhToan.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_HoaDonThanhToan.SelectedItems[0];

                string maPhong = selectedItem.SubItems[1].Text;
                int thanhTien = Convert.ToInt32(selectedItem.SubItems[4].Text.Replace(",", ""));

                string queryDates = @"
                    SELECT NgayDat, NgayTra, CMND 
                    FROM Thue 
                    WHERE MaPhong = @MaPhong 
                    AND NOT EXISTS (
                        SELECT 1 FROM HoaDon 
                        WHERE HoaDon.MaPhong = Thue.MaPhong 
                        AND HoaDon.NgayDat = Thue.NgayDat
                        AND HoaDon.NgayTra = Thue.NgayTra
                    )";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@MaPhong", maPhong)
                };

                DataTable dtDates = DataProvider.SelectData(queryDates, CommandType.Text, parameters);

                if (dtDates.Rows.Count > 0)
                {
                    DateTime ngayDat = Convert.ToDateTime(dtDates.Rows[0]["NgayDat"]);
                    DateTime ngayTra = Convert.ToDateTime(dtDates.Rows[0]["NgayTra"]);
                    string cmnd = dtDates.Rows[0]["CMND"].ToString();

                    string maHD = $"{maPhong}-{ngayDat:yyMMdd}";

                    HoaDon hoaDon = new HoaDon
                    {
                        MaHD = maHD,
                        ThanhTien = thanhTien,
                        NgayDat = ngayDat,
                        NgayTra = ngayTra,
                        CMND = cmnd,
                        MaPhong = maPhong
                    };

                    HoaDonDAO.ThemHoaDon(hoaDon);

                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDataToListView();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                string cmnd = txt_KhachHang.Text.Trim();
                if (string.IsNullOrEmpty(cmnd))
                {
                    MessageBox.Show("Vui lòng nhập CMND để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"
            WITH RoomOccupancy AS (
                SELECT 
                    t.MaPhong,
                    t.NgayDat,
                    t.NgayTra,
                    COUNT(*) as OccupantCount,
                    MAX(CASE WHEN k.LoaiKH = N'Nước ngoài' THEN 1 ELSE 0 END) as HasForeignGuest
                FROM Thue t
                INNER JOIN KhachHang k ON t.CMND = k.CMND
                GROUP BY t.MaPhong, t.NgayDat, t.NgayTra
            )
            SELECT DISTINCT
                t.MaPhong,
                p.Gia as BasePrice,
                t.NgayDat,
                t.NgayTra,
                ro.OccupantCount,
                ro.HasForeignGuest,
                DATEDIFF(day, t.NgayDat, t.NgayTra) as SoNgayThue,
                p.LoaiPhong,
                k.CMND,
                k.TenKH,
                k.DiaChi,
                CASE 
                    WHEN p.LoaiPhong = N'Phòng đơn' AND ro.OccupantCount > 1 THEN p.Gia * 1.25
                    WHEN p.LoaiPhong = N'Phòng đôi' AND ro.OccupantCount > 2 THEN p.Gia * 1.25
                    WHEN p.LoaiPhong = N'Phòng lớn' AND ro.OccupantCount > 8 THEN p.Gia * 1.25
                    ELSE p.Gia
                END * 
                CASE WHEN ro.HasForeignGuest = 1 THEN 1.5 ELSE 1 END * 
                DATEDIFF(day, t.NgayDat, t.NgayTra) as ThanhTien
            FROM Thue t
            INNER JOIN Phong p ON t.MaPhong = p.MaPhong
            INNER JOIN RoomOccupancy ro ON t.MaPhong = ro.MaPhong 
                AND t.NgayDat = ro.NgayDat 
                AND t.NgayTra = ro.NgayTra
            INNER JOIN KhachHang k ON t.CMND = k.CMND
            WHERE t.CMND = @CMND
            AND NOT EXISTS (
                SELECT 1 
                FROM HoaDon h 
                WHERE h.MaPhong = t.MaPhong 
                AND h.NgayDat = t.NgayDat 
                AND h.NgayTra = t.NgayTra
            )";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@CMND", cmnd)
                };

                DataTable dt = DataProvider.SelectData(query, CommandType.Text, parameters);

                lv_HoaDonThanhToan.Items.Clear();
                txt_DiaChi.Clear();
                txt_TriGia.Clear();

                if (dt.Rows.Count > 0)
                {
                    int stt = 1;
                    double tongTriGia = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(stt.ToString());

                        var itemData = new
                        {
                            CMND = row["CMND"].ToString(),
                            TenKH = row["TenKH"].ToString(),
                            DiaChi = row["DiaChi"].ToString(),
                            ThanhTien = Convert.ToDouble(row["ThanhTien"]),
                            SoNguoi = Convert.ToInt32(row["OccupantCount"])
                        };
                        item.Tag = itemData;

                        item.SubItems.Add(row["MaPhong"].ToString());
                        item.SubItems.Add(row["SoNgayThue"].ToString());
                        item.SubItems.Add(string.Format("{0:#,##0}", Convert.ToInt32(row["BasePrice"])));
                        item.SubItems.Add(string.Format("{0:#,##0}", Convert.ToInt32(row["ThanhTien"])));

                        // Add tooltip information
                        string priceInfo = $"Số người ở: {itemData.SoNguoi}\n";
                        if (Convert.ToBoolean(row["HasForeignGuest"]))
                            priceInfo += "Phụ thu khách nước ngoài (x1.5)\n";

                        if ((row["LoaiPhong"].ToString() == "Phòng đơn" && Convert.ToInt32(row["OccupantCount"]) > 1) ||
                            (row["LoaiPhong"].ToString() == "Phòng đôi" && Convert.ToInt32(row["OccupantCount"]) > 2) ||
                            (row["LoaiPhong"].ToString() == "Phòng lớn" && Convert.ToInt32(row["OccupantCount"]) > 8))
                        {
                            priceInfo += "Phụ thu vượt sức chứa (x1.25)";
                        }

                        item.ToolTipText = priceInfo;
                        lv_HoaDonThanhToan.Items.Add(item);
                        stt++;

                        tongTriGia += Convert.ToDouble(row["ThanhTien"]);
                        txt_DiaChi.Text = row["DiaChi"].ToString();
                    }

                    txt_TriGia.Text = string.Format("{0:#,##0}", tongTriGia);
                }
                else
                {
                    MessageBox.Show("CMND này hiện không thuê phòng nào!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            try
            {

                txt_KhachHang.Clear();
                txt_DiaChi.Clear();
                txt_TriGia.Clear();

                LoadDataToListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi reset: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
