using QLKSBUS;
using QLKSDAO;
using QLKSDTO;

namespace QLKSGUI
{
    public partial class Form_DSPhong : Form
    {
        public Form_DSPhong()
        {

            InitializeComponent();
            LoadData();
            dtgv_dsphong.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dtgv_dsphong_RowPostPaint);
            dtgv_dsphong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
