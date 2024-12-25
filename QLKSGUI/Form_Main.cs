using Form_DSPhong_HoaDon;
namespace QLKSGUI
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            Form_HoaDon form = new Form_HoaDon();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}