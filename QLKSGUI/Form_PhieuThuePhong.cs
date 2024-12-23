using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKSDTO;
using QLKSBUS;

namespace QLKSGUI
{
    public partial class Form_PhieuThuePhong : Form
    {
        private ErrorProvider errorProvider;
        private List<KhachHang> danhSachKhachHang;
        private string maPhong;
        public Form_PhieuThuePhong()
        {
            InitializeComponent();
            this.maPhong = maPhong;
            danhSachKhachHang = new List<KhachHang>();
            errorProvider = new ErrorProvider();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            lbl_PhieuThuePhong.Text = $"Phiếu thuê phòng: {maPhong}"; // Gán tên phòng
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

            // Kiểm tra tên khách hàng
            if (string.IsNullOrWhiteSpace(txt_Ten.Text))
            {
                errorProvider.SetError(txt_Ten, "Vui lòng nhập tên khách hàng.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txt_Ten, "");
            }

            // Kiểm tra CMND
            if (string.IsNullOrWhiteSpace(txt_CMND.Text))
            {
                errorProvider.SetError(txt_CMND, "Vui lòng nhập số CMND.");
                isValid = false;
            }
            else if (txt_CMND.Text.Length != 9 && txt_CMND.Text.Length != 12)
            {
                errorProvider.SetError(txt_CMND, "Số CMND phải có 9 hoặc 12 chữ số.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txt_CMND, "");
            }

            // Kiểm tra loại khách
            if (!rdbtn_NoiDia.Checked && !rdbtn_NuocNgoai.Checked)
            {
                errorProvider.SetError(gr_LoaiKhach, "Vui lòng chọn loại khách hàng.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(gr_LoaiKhach, "");
            }

            return isValid;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            string loaiKhach = rdbtn_NoiDia.Checked ? "Nội địa" : "Nước ngoài";

            KhachHang kh = new KhachHang
            {
                CMND = txt_CMND.Text,
                TenKH = txt_Ten.Text,
                LoaiKH = loaiKhach,
                DiaChi = txt_DiaChi.Text
            };

            danhSachKhachHang.Add(kh);

            // Thêm vào ListView
            ListViewItem item = new ListViewItem(new[]
            {
                (liv_KhachHang.Items.Count + 1).ToString(),
                kh.TenKH,
                kh.LoaiKH,
                kh.CMND,
                kh.DiaChi
            });
            liv_KhachHang.Items.Add(item);

            // Reset form
            txt_Ten.Clear();
            txt_CMND.Clear();
            txt_DiaChi.Clear();
            rdbtn_NoiDia.Checked = false;
            rdbtn_NuocNgoai.Checked = false;

            MessageBox.Show("Thêm khách hàng vào danh sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_XuatPhieu_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (KhachHang kh in danhSachKhachHang)
            {
                bool result = KhachHangBUS.ThemKhachHang(kh);
                if (!result)
                {
                    MessageBox.Show($"Thêm khách hàng {kh.TenKH} vào cơ sở dữ liệu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Xuất phiếu thuê phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
