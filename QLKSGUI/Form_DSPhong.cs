using QLKSBUS;
using QLKSDAO;
using QLKSDTO;

namespace QLKSGUI
{
    public partial class Form_DSPhong : Form
    {
        // Khai báo các thành phần giao diện
        private Panel tenantPanel; // Panel hiển thị danh sách khách hàng thuê phòng
        private DataGridView tenantGrid; // Bảng hiển thị danh sách khách hàng thuê
        private Panel overlayPanel; // Lớp phủ để làm mờ giao diện khi hiển thị tenantPanel

        public Form_DSPhong()
        {
            InitializeComponent();
            LoadData(); // Nạp dữ liệu danh sách phòng

            // Gắn sự kiện vẽ chỉ số dòng và thiết lập chế độ chọn dòng
            dtgv_dsphong.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dtgv_dsphong_RowPostPaint);
            dtgv_dsphong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            InitializeTenantPanel(); // Khởi tạo giao diện hiển thị danh sách khách hàng thuê
        }

        private void InitializeTenantPanel()
        {
            // Khởi tạo lớp phủ giao diện
            overlayPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Black, // Màu đen để làm mờ nền
                Visible = false
            };
            this.Controls.Add(overlayPanel);

            // Khởi tạo panel hiển thị danh sách khách hàng
            tenantPanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(700, 400), // Kích thước panel
                Visible = false,
                BackColor = Color.White
            };

            // Khởi tạo bảng hiển thị khách hàng thuê
            tenantGrid = new DataGridView
            {
                Dock = DockStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, // Tự động chỉnh cột vừa khung
                ReadOnly = true,
                Location = new Point(10, 40),
                Size = new Size(680, 350)
            };

            // Nút đóng panel
            Button closeBtn = new Button
            {
                Text = "×", // Dấu nhân để đóng
                Size = new Size(30, 30),
                Location = new Point(tenantPanel.Width - 40, 5),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            closeBtn.Click += (s, e) => HideTenantPanel(); // Gắn sự kiện đóng panel

            // Tiêu đề của panel
            Label titleLabel = new Label
            {
                Text = "Danh sách khách hàng đang thuê",
                Font = new Font("Times New Roman", 14, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            // Thêm các thành phần vào panel
            tenantPanel.Controls.Add(tenantGrid);
            tenantPanel.Controls.Add(closeBtn);
            tenantPanel.Controls.Add(titleLabel);

            this.Controls.Add(tenantPanel);

            // Sự kiện click vào overlayPanel sẽ đóng tenantPanel
            overlayPanel.Click += (s, e) => HideTenantPanel();

            // Thiết lập phím tắt Escape để đóng panel
            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape && tenantPanel.Visible)
                    HideTenantPanel();
            };
        }

        private void HideTenantPanel()
        {
            // Ẩn panel hiển thị danh sách khách hàng thuê và lớp phủ
            tenantPanel.Visible = false;
            overlayPanel.Visible = false;
        }

        private void Form_DSPhong_Load(object sender, EventArgs e)
        {
            // Thiết lập chỉ số dòng (STT) cho bảng danh sách phòng
            dtgv_dsphong.TopLeftHeaderCell.Value = "STT";
            dtgv_dsphong.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void LoadData()
        {
            // Nạp danh sách phòng từ lớp nghiệp vụ
            dtgv_dsphong.DataSource = PhongBUS.LayDSPhongTrong();

            // Thiết lập giá trị mặc định cho combobox
            cbbox_Phong.SelectedIndex = 0;
            cbb_TinhTrang.SelectedIndex = 0;

            // Gắn sự kiện tìm kiếm cho nút btn_TimPhong
            btn_TimPhong.Click += btn_TimPhong_Click;

            // Thiết lập tiêu đề cho các cột trong bảng danh sách phòng
            this.dtgv_dsphong.Columns["MaPhong"].HeaderText = "Mã Phòng";
            this.dtgv_dsphong.Columns["LoaiPhong"].HeaderText = "Loại Phòng";
            this.dtgv_dsphong.Columns["TinhTrang"].HeaderText = "Tình Trạng";
            this.dtgv_dsphong.Columns["Gia"].HeaderText = "Giá";
            this.dtgv_dsphong.Columns["GhiChu"].HeaderText = "Ghi Chú";
            this.Text = "Danh Sách Phòng";
        }

        private void dtgv_dsphong_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Nếu nhấp đúp chuột ngoài vùng dữ liệu thì không xử lý
            if (e.RowIndex < 0) return;

            // Lấy mã phòng từ hàng được chọn
            string maPhong = dtgv_dsphong.Rows[e.RowIndex].Cells["MaPhong"].Value.ToString();

            // Lấy danh sách khách hàng đang thuê phòng này từ cơ sở dữ liệu
            var tenants = KhachHangDAO.LayDSKhachHangDangThueCuaPhong(maPhong);

            // Hiển thị danh sách khách thuê lên bảng tenantGrid
            tenantGrid.DataSource = tenants;

            // Căn giữa tenantPanel trong form
            tenantPanel.Location = new Point(
                (this.ClientSize.Width - tenantPanel.Width) / 2,
                (this.ClientSize.Height - tenantPanel.Height) / 2
            );

            // Hiển thị panel và overlay
            overlayPanel.BringToFront();
            overlayPanel.Visible = true;
            tenantPanel.BringToFront();
            tenantPanel.Visible = true;

            // Đặt tiêu đề cho các cột của tenantGrid
            this.tenantGrid.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
            this.tenantGrid.Columns["LoaiKH"].HeaderText = "Loại Khách Hàng";
            this.tenantGrid.Columns["DiaChi"].HeaderText = "Địa Chỉ";
        }

        private void dtgv_dsphong_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Vẽ chỉ số dòng (STT) ở cột đầu tiên
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText,
                headerBounds, centerFormat);
        }

        private void btn_TimPhong_Click(object sender, EventArgs e)
        {
            // Lấy giá trị loại phòng và tình trạng từ combobox
            string selectedRoom = cbbox_Phong.SelectedItem?.ToString();
            string selectedStatus = cbb_TinhTrang.SelectedItem?.ToString();

            // Kiểm tra nếu chưa chọn giá trị
            if (selectedRoom == null || selectedStatus == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng và tình trạng!", "Thông báo");
                return;
            }

            // Lọc danh sách phòng theo loại phòng và tình trạng
            if (selectedRoom == "Tất cả")
            {
                dtgv_dsphong.DataSource = PhongDAO.LayDSPhongTheoTinhTrang(selectedStatus);
            }
            else
            {
                string searchType = "Phòng " + selectedRoom.ToLower();
                dtgv_dsphong.DataSource = PhongDAO.LayDSPhongTheoLoaiVaTinhTrang(searchType, selectedStatus);
            }
        }

        private void btn_Thanhtoan_Click(object sender, EventArgs e)
        {
            // Mở form hóa đơn khi nhấn nút thanh toán
            Form_HoaDon hoaDonForm = new Form_HoaDon();
            hoaDonForm.ShowDialog();
        }

        private void btn_Baocao_Click(object sender, EventArgs e)
        {
            // Mở form báo cáo khi nhấn nút báo cáo
            Form_Baocao baocaoForm = new Form_Baocao();
            baocaoForm.ShowDialog();
        }

        private void btn_Datphong_Click(object sender, EventArgs e)
        {
            // Mở form đặt phòng khi nhấn nút đặt phòng
            Form_PhieuThuePhong thuePhongForm = new Form_PhieuThuePhong();
            thuePhongForm.ShowDialog();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận trước khi thoát
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
