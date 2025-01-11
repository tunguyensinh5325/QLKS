using QLKSBUS;
using QLKSDTO;
namespace QLKSGUI
{
    public partial class Form_Baocao : Form
    {
        List<Phong> p = PhongBUS.DSPhong();
        List<HoaDon> dshd = HoaDonBUS.LayDSHoaDon();
        public Form_Baocao()
        {
            InitializeComponent();
        }

        private void Form_Baocaomatdo_Load(object sender, EventArgs e)
        {
            foreach (HoaDon hd in dshd)
            {
                if (!cbbox_namlp.Items.Contains(hd.NgayDat.Year))
                {
                    cbbox_namlp.Items.Add(hd.NgayDat.Year);
                    cbbox_nammd.Items.Add(hd.NgayDat.Year);
                }
            }
        }

        private void btn_Locmd_Click(object sender, EventArgs e)
        {
            lv_DSMD.Items.Clear();
            if (cbbox_nammd.Text == "")
            {
                MessageBox.Show("Hãy chọn năm!");
                return;
            }
            List<int> sn = PhongBUS.DSmd(cbbox_thangmd.Text, cbbox_nammd.Text);
            int tong = sn.Sum();
            for (int i = 0; i < p.Count; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(p[i].MaPhong);
                item.SubItems.Add(sn[i].ToString());
                if (tong != 0)
                {
                    item.SubItems.Add((((double)sn[i] / tong) * 100).ToString() + "%");
                }
                else
                {
                    item.SubItems.Add("0%");
                }
                lv_DSMD.Items.Add(item);
            }
        }

        private void lv_DSMD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Loclp_Click(object sender, EventArgs e)
        {
            lv_DSLP.Items.Clear();
            if (cbbox_namlp.Text == "")
            {
                MessageBox.Show("Hãy chọn năm!");
                return;
            }

            List<string> dslp = PhongBUS.DSlp();
            List<int> dt = PhongBUS.DSdt(cbbox_thanglp.Text, cbbox_namlp.Text);
            int tong = dt.Sum();
            for (int i = 0; i < dslp.Count; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(dslp[i]);
                item.SubItems.Add(dt[i].ToString());
                if (tong != 0)
                {
                    item.SubItems.Add((((double)dt[i] / tong) * 100).ToString() + "%");
                }
                else
                {
                    item.SubItems.Add("0%");
                }
                lv_DSLP.Items.Add(item);
            }
        }
        private void lv_DSLP_Resize(object sender, EventArgs e)
        {

            int widthCot = lv_DSLP.ClientSize.Width / 7;
            lv_DSLP.Columns[0].Width = widthCot;

            for (int i = 1; i < lv_DSLP.Columns.Count; i++)
            {
                lv_DSLP.Columns[i].Width = widthCot * 2;
            }
        }
        private void lv_DSMD_Resize(object sender, EventArgs e)
        {

            int widthCot = lv_DSMD.ClientSize.Width / 7;
            lv_DSMD.Columns[0].Width = widthCot;

            for (int i = 1; i < lv_DSMD.Columns.Count; i++)
            {
                lv_DSMD.Columns[i].Width = widthCot * 2;
            }
        }

        private void Form_Baocao_Resize(object sender, EventArgs e)
        {
            lv_DSMD_Resize(sender, e);
            lv_DSLP_Resize(sender, e);
        }

    }
}
