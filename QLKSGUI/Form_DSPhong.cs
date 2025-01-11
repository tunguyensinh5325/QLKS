using QLKSBUS;
using QLKSDAO;
using QLKSDTO;

namespace QLKSGUI
{
    public partial class Form_DSPhong : Form
    {
        private Panel tenantPanel;
        private DataGridView tenantGrid;
        private Panel overlayPanel;
        public Form_DSPhong()
        {

            InitializeComponent();
            LoadData();
            dtgv_dsphong.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dtgv_dsphong_RowPostPaint);
            dtgv_dsphong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InitializeTenantPanel();
        }

        private void InitializeTenantPanel()
        {
            overlayPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Black,
                Visible = false
            };
            this.Controls.Add(overlayPanel);

            tenantPanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(700, 400),
                Visible = false,
                BackColor = Color.White
            };

            tenantGrid = new DataGridView
            {
                Dock = DockStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                Location = new Point(10, 40), 
                Size = new Size(680, 350) 
            };

            Button closeBtn = new Button
            {
                Text = "×", 
                Size = new Size(30, 30),
                Location = new Point(tenantPanel.Width - 40, 5),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            closeBtn.Click += (s, e) => HideTenantPanel();

            Label titleLabel = new Label
            {
                Text = "Danh sách khách hàng đang thuê",
                Font = new Font("Times New Roman", 14, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            tenantPanel.Controls.Add(tenantGrid);
            tenantPanel.Controls.Add(closeBtn);
            tenantPanel.Controls.Add(titleLabel);

            this.Controls.Add(tenantPanel);

            overlayPanel.Click += (s, e) => HideTenantPanel();

            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape && tenantPanel.Visible)
                    HideTenantPanel();
            };
        }
        private void HideTenantPanel()
        {
            tenantPanel.Visible = false;
            overlayPanel.Visible = false;
        }
        private void Form_DSPhong_Load(object sender, EventArgs e)
        {
            dtgv_dsphong.TopLeftHeaderCell.Value = "STT";
            dtgv_dsphong.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void LoadData()
        {
            dtgv_dsphong.DataSource = PhongBUS.LayDSPhongTrong();
            cbbox_Phong.SelectedIndex = 0;
            cbb_TinhTrang.SelectedIndex = 0;
            btn_TimPhong.Click += btn_TimPhong_Click;

            this.dtgv_dsphong.Columns["MaPhong"].HeaderText = "Mã Phòng";
            this.dtgv_dsphong.Columns["LoaiPhong"].HeaderText = "Loại Phòng";
            this.dtgv_dsphong.Columns["TinhTrang"].HeaderText = "Tình Trạng";
            this.dtgv_dsphong.Columns["Gia"].HeaderText = "Giá";
            this.dtgv_dsphong.Columns["GhiChu"].HeaderText = "Ghi Chú";
            this.Text = "Danh Sách Phòng";
        }
        private void dtgv_dsphong_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maPhong = dtgv_dsphong.Rows[e.RowIndex].Cells["MaPhong"].Value.ToString();
            var tenants = KhachHangDAO.LayDSKhachHangDangThueCuaPhong(maPhong);

            tenantGrid.DataSource = tenants;

            tenantPanel.Location = new Point(
                (this.ClientSize.Width - tenantPanel.Width) / 2,
                (this.ClientSize.Height - tenantPanel.Height) / 2
            );

            overlayPanel.BringToFront();
            overlayPanel.Visible = true;
            tenantPanel.BringToFront();
            tenantPanel.Visible = true;
            this.tenantGrid.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
            this.tenantGrid.Columns["LoaiKH"].HeaderText = "Loại Khách Hàng";
            this.tenantGrid.Columns["DiaChi"].HeaderText = "Địa Chỉ";
        }
        private void dtgv_dsphong_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
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
            string selectedRoom = cbbox_Phong.SelectedItem?.ToString();
            string selectedStatus = cbb_TinhTrang.SelectedItem?.ToString();

            if (selectedRoom == null || selectedStatus == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng và tình trạng!", "Thông báo");
                return;
            }

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


        private void Form_DSPhong_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_Thanhtoan_Click(object sender, EventArgs e)
        {
            Form_HoaDon hoaDonForm = new Form_HoaDon();
            hoaDonForm.ShowDialog();
        }

        private void btn_Baocao_Click(object sender, EventArgs e)
        {
            Form_Baocao baocaoForm = new Form_Baocao();
            baocaoForm.ShowDialog();
        }

        private void btn_Datphong_Click(object sender, EventArgs e)
        {
            Form_PhieuThuePhong thuePhongForm = new Form_PhieuThuePhong();
            thuePhongForm.ShowDialog();

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
