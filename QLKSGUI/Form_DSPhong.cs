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
        }
        private void Form_DSPhong_Load(object sender, EventArgs e)
        {
            dtgv_dsphong.TopLeftHeaderCell.Value = "STT";
            dtgv_dsphong.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void LoadData()
        {
            dtgv_dsphong.DataSource = PhongDAO.LayDSPhongTrong();
            cbbox_Phong.SelectedIndex = 0;
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
            string selectedItem = cbbox_Phong.SelectedItem?.ToString();

            if (selectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng!", "Thông báo");
                return;
            }

            if (selectedItem == "Tất cả")
            {
                dtgv_dsphong.DataSource = PhongDAO.LayDSPhongTrong();
                return;
            }

            string searchType = "Phòng " + selectedItem.ToLower();
            dtgv_dsphong.DataSource = PhongDAO.TimPhongTheoLoai(searchType);
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_DSPhong_Load_1(object sender, EventArgs e)
        {

        }
    }
}
