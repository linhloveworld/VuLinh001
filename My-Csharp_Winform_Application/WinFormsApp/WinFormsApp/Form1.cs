namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            txtHoTen.Clear();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan khong?", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnChuanHoa_Click(object sender, EventArgs e)
        {
            static string ChuanHoaChuoi(string HoTen)
            {

                return HoTen;
            }
        }
    }
}