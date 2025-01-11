using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QLKSBUS;
using QLKSDTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QLKSGUI
{

    public partial class Form_PhieuThuePhong : Form
    {
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public string LoaiPhong { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }
        private int offsetY = 0;
        private int step = 5;
        private Bitmap[] images;
        private int currentImageIndex = 0;
        private int waitTime = 1000;
        private DateTime lastChangeTime = DateTime.Now;

        public Form_PhieuThuePhong()
        {
            InitializeComponent();
        }

        private void Form_PhieuThuePhong_Load(object sender, EventArgs e)
        {
            dtp_NgayThue.MinDate = DateTime.Now;
            LoadPhongTrong();

            string[] imagePaths = { "pic/h4.jpg", "pic/h3.jpg", "pic/h2.jpg", "pic/h1.jpg" };

            images = new Bitmap[imagePaths.Length];
            for (int i = 0; i < imagePaths.Length; i++)
            {
                if (!File.Exists(imagePaths[i]))
                {
                    MessageBox.Show($"Tệp hình ảnh không tồn tại: {imagePaths[i]}");
                    images[i] = null;
                }
                else
                {
                    try
                    {
                        images[i] = new Bitmap(imagePaths[i]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải ảnh {imagePaths[i]}: {ex.Message}");
                        images[i] = null;
                    }
                }
            }

            currentImageIndex = Array.FindIndex(images, image => image != null);
            if (currentImageIndex != -1)
            {
                picb_QuangCao.Image = images[currentImageIndex];
            }
            else
            {
                MessageBox.Show("Không có hình ảnh hợp lệ nào được tìm thấy.");
                timer1.Stop();
                return;
            }

            timer1.Interval = 50;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (images == null || images.Length == 0 || picb_QuangCao.Image == null) return;

            if ((DateTime.Now - lastChangeTime).TotalMilliseconds >= waitTime)
            {
                offsetY -= step;

                if (offsetY <= -picb_QuangCao.Image.Height + picb_QuangCao.Height)
                {
                    offsetY = 0;
                    currentImageIndex = (currentImageIndex + 1) % images.Length;

                    while (images[currentImageIndex] == null)
                    {
                        currentImageIndex = (currentImageIndex + 1) % images.Length;
                        if (currentImageIndex == (currentImageIndex - 1 + images.Length) % images.Length)
                        {
                            timer1.Stop();
                            return;
                        }

                    }
                    picb_QuangCao.Image = images[currentImageIndex];
                    lastChangeTime = DateTime.Now;
                }
                picb_QuangCao.Invalidate();
            }
        }

        private void picb_QuangCao_Paint(object sender, PaintEventArgs e)
        {
            if (picb_QuangCao.Image == null) return;

            e.Graphics.Clear(picb_QuangCao.BackColor);

            int visibleHeight = Math.Min(picb_QuangCao.Height, picb_QuangCao.Image.Height - Math.Abs(offsetY));
            if (visibleHeight > 0)
            {
                Rectangle sourceRect;
                Rectangle destRect;

                if (offsetY >= 0)
                {
                    sourceRect = new Rectangle(0, 0, picb_QuangCao.Image.Width, visibleHeight);
                    destRect = new Rectangle(0, offsetY, picb_QuangCao.Width, visibleHeight);
                }
                else
                {
                    sourceRect = new Rectangle(0, -offsetY, picb_QuangCao.Image.Width, visibleHeight);
                    destRect = new Rectangle(0, 0, picb_QuangCao.Width, visibleHeight);
                }
                e.Graphics.DrawImage(picb_QuangCao.Image, destRect, sourceRect, GraphicsUnit.Pixel);
            }
        }

        private void LoadPhongTrong()
        {
            try
            {
                List<Phong> dsPhongTrong = PhongBUS.LayDSPhongTrong();

                cbb_Phong.DrawMode = DrawMode.OwnerDrawFixed;
                cbb_Phong.Items.Clear();

                foreach (var phong in dsPhongTrong)
                {
                    string displayText = $"{phong.MaPhong}, {phong.LoaiPhong} ({phong.Gia} VND)";
                    cbb_Phong.Items.Add(new ComboBoxItem { Text = displayText, LoaiPhong = phong.LoaiPhong });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phòng: " + ex.Message);
            }
        }

        private void cbb_Phong_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            var item = (ComboBoxItem)cbb_Phong.Items[e.Index];
            Color textColor;

            // Tô màu theo loại phòng
            switch (item.LoaiPhong)
            {
                case "Phòng đơn":
                    textColor = Color.Gold;
                    break;
                case "Phòng đôi":
                    textColor = Color.Green;
                    break;
                case "Phòng Lớn":
                    textColor = Color.Blue;
                    break;
                default:
                    textColor = Color.Black;
                    break;
            }

            using (Brush brush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(item.Text, e.Font, brush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }
        private void liv_KhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liv_KhachHang.SelectedItems.Count > 0)
            {
                btn_Them.Text = "Xóa";
                btn_SuaThongTin.Enabled = true;
                ListViewItem selectedItem = liv_KhachHang.SelectedItems[0];

                txt_Ten.Text = selectedItem.SubItems[1].Text;
                txt_CMND.Text = selectedItem.SubItems[3].Text;
                txt_DiaChi.Text = selectedItem.SubItems[4].Text;

                string loaiKhach = selectedItem.SubItems[2].Text;

                if (loaiKhach.Equals("Nước ngoài", StringComparison.OrdinalIgnoreCase))
                {
                    rdbtn_NuocNgoai.Checked = true;
                }
                else
                {
                    rdbtn_NoiDia.Checked = true;
                }
            }
            else
            {
                btn_SuaThongTin.Enabled = false;
                btn_Them.Text = "Thêm";
            }

        }
        private void ClearCustomerForm()
        {
            txt_Ten.Clear();
            txt_CMND.Clear();
            txt_DiaChi.Clear();
            rdbtn_NoiDia.Checked = true;
            cbb_Phong.SelectedIndex = -1;
        }

        private void btn_XuatPhieu_Click(object sender, EventArgs e)
        {
            if (cbb_Phong.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn phòng.");
                return;
            }
            string maPhong = cbb_Phong.SelectedItem.ToString().Split(',')[0].Trim();
            
            if (liv_KhachHang.Items.Count == 0)
            {
                MessageBox.Show("Không có khách hàng nào trong danh sách.");
                return;
            }
            

            foreach (ListViewItem item in liv_KhachHang.Items)
            {
                string cmnd = item.SubItems[cl_CMND.Index].Text;
                string tenKH = item.SubItems[cl_KhachHang.Index].Text;
                string loaiKH = item.SubItems[cl_LoaiKhach.Index].Text;
                string diaChi = item.SubItems[cl_DiaChi.Index].Text;
                {
                    KhachHang kh = new KhachHang
                    {
                        CMND = cmnd,
                        TenKH = tenKH,
                        LoaiKH = loaiKH,
                        DiaChi = diaChi
                    };

                    KhachHangBUS.ThemKhachHang(kh);
                }
            }
            ListViewItem nguoiDauTien = liv_KhachHang.Items[0];
            string cmndNguoiDauTien = nguoiDauTien.SubItems[cl_CMND.Index].Text;

            DateTime ngayDat = dtp_NgayThue.Value;

            Thue thue = new Thue
            {
                MaPhong = maPhong,
                CMND = cmndNguoiDauTien,
                NgayDat = ngayDat,
                NgayTra = DateTime.MinValue 
            };
            ThueBUS.ThemThue(thue);

            string maHD = $"{maPhong}-{ngayDat:ddMMyy}";

            PhongBUS.CapNhatTinhTrangPhong(maPhong, "Đã thuê");

            XoaPhongKhoiComboBox(maPhong);

            MessageBox.Show("Phiếu đã được xuất thành công.");
        }

        private void XoaPhongKhoiComboBox(string maPhong)
        {
            for (int i = 0; i < cbb_Phong.Items.Count; i++)
            {
                string item = cbb_Phong.Items[i].ToString();
                if (item.StartsWith(maPhong))
                {
                    cbb_Phong.Items.RemoveAt(i);
                    break;
                }
            }
        }

        public static KhachHang SaiKHCoSan(KhachHang kh)
        {
            KhachHang check = KhachHangBUS.LayKhachHangTheoCMND(kh.CMND);
            if (check==null)
            {
                return kh;
            }
            if (check.LoaiKH != kh.LoaiKH || kh.DiaChi!=check.DiaChi || kh.TenKH!=check.TenKH)
            {
                DialogResult result = MessageBox.Show(
                $"Thông tin của bạn đã tồn tại với Tên: {check.TenKH}, Địa chỉ: {check.DiaChi}, Loại Khách Hàng: {check.LoaiKH}\n" +
                $"Bạn có muốn đổi không?",
                "Xác nhận",
                MessageBoxButtons.YesNo
                );
                if (result == DialogResult.Yes)
                {
                    KhachHangBUS.CapNhatKhachHang(kh);                
                }
                else if (result == DialogResult.No)
                {
                    return check;
                }
            }
            return kh;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (btn_Them.Text == "Thêm")
            {
                foreach (ListViewItem i in liv_KhachHang.Items)
                {
                    if (i.SubItems[3].Text == txt_CMND.Text)
                    {
                        MessageBox.Show("Đã tồn tại trong danh sách thuê, không thể thêm!");
                        return;
                    }
                }
                if (string.IsNullOrEmpty(txt_CMND.Text) || string.IsNullOrEmpty(txt_Ten.Text))
                {
                    MessageBox.Show("Tên và CMND không được để trống.");
                    return;
                }
                if (cbb_Phong.SelectedItem == null)
                {
                    MessageBox.Show("Bạn chưa chọn loại phòng!");
                    return;
                }
                
                int sttMoi = liv_KhachHang.Items.Count + 1;
                KhachHang khachHang = new KhachHang
                {
                    CMND = txt_CMND.Text,
                    TenKH = txt_Ten.Text,
                    DiaChi = txt_DiaChi.Text,
                    LoaiKH = rdbtn_NoiDia.Checked ? "Nội địa" : "Nước ngoài"
                };

                khachHang = SaiKHCoSan(khachHang);
                
                ListViewItem item = new ListViewItem(sttMoi.ToString()); 
                item.SubItems.Add(khachHang.TenKH);                     
                item.SubItems.Add(khachHang.LoaiKH);                    
                item.SubItems.Add(khachHang.CMND);                      
                item.SubItems.Add(khachHang.DiaChi);                    
                liv_KhachHang.Items.Add(item);

                ClearCustomerForm();
            }
            else if (btn_Them.Text == "Xóa")
            {
                if (liv_KhachHang.SelectedItems.Count > 0)
                {
                    liv_KhachHang.Items.Remove(liv_KhachHang.SelectedItems[0]);
                    for (int i = 0; i < liv_KhachHang.Items.Count; i++)
                    {
                        liv_KhachHang.Items[i].SubItems[0].Text = (i + 1).ToString(); 
                    }
                    MessageBox.Show("Người được chọn đã bị xóa.");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn người để xóa.");
                }

                btn_Them.Text = "Thêm"; 
                
            }
        }
        private void btn_SuaThongTin_Click(object sender, EventArgs e)
        {
            if (liv_KhachHang.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa.");
                return;
            }

            string cmnd = txt_CMND.Text;  
            string tenKhachHang = txt_Ten.Text;
            string diaChi = txt_DiaChi.Text;
            string loaiKhach = rdbtn_NoiDia.Checked ? "Nội địa" : "Nước ngoài";


            ListViewItem selectedItem = liv_KhachHang.SelectedItems[0];
            selectedItem.SubItems[1].Text = tenKhachHang;
            selectedItem.SubItems[2].Text = loaiKhach;
            selectedItem.SubItems[3].Text = diaChi;
            ClearCustomerForm();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThongTinPhong_Click(object sender, EventArgs e)
        {
            Form Form_DSPhong= new Form_DSPhong();
            Form_DSPhong.ShowDialog();

        }
        private void cbb_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Phong.SelectedIndex < 0) return; 

            var selectedItem = (ComboBoxItem)cbb_Phong.SelectedItem;
            string loaiPhong = selectedItem.LoaiPhong;

            int soNguoiToiDa = loaiPhong == "Phòng đơn" ? 1 : (loaiPhong == "Phòng đôi" ? 2 : int.MaxValue);

            if (liv_KhachHang.Items.Count > soNguoiToiDa)
            {
                MessageBox.Show($"Phòng {loaiPhong} chỉ chứa được tối đa {soNguoiToiDa} người.\n" +
                                "Vui lòng xóa bớt người trong danh sách bằng cách chọn người và nhấn nút Xóa.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }

}
