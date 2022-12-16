using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BTL_QLThuvien_Csharp_Nhom10
{
    public partial class Giaodien : Form
    {
        SqlDataAdapter dat;
        DataTable dataTable;
        string A;
        SqlConnection conn;
        SqlCommand cmd;
        private void mnudk_Click(object sender, EventArgs e)
        {
            frmdangky dangky = new frmdangky();
            dangky.ShowDialog();
        }

        private void mnudmqlsv_Click(object sender, EventArgs e)
        {
            frmthethuvien frmthethuvien = new frmthethuvien();
            frmthethuvien.ShowDialog();
        }

        private void mnudlsach_Click(object sender, EventArgs e)
        {
            frmSach frm = new frmSach();
            frm.ShowDialog();
        }

        private void mnudlsachmuon_Click(object sender, EventArgs e)
        {
            frmSachmuon frm = new frmSachmuon();
            frm.ShowDialog();
        }

        private void mnudlphieumuon_Click(object sender, EventArgs e)
        {
            frmPhieumuonsach frm = new frmPhieumuonsach();
            frm.ShowDialog();
        }

        private void mnudlphieunhactra_Click(object sender, EventArgs e)
        {
            frmPhieuNhacTra frm = new frmPhieuNhacTra();
            frm.ShowDialog();
        }

        private void mnudmqlnv_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }
        public Object laygiatri(string sql)
        {
            cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            //chi can lay ve gia tri cua mot truong thoi
            Object o = cmd.ExecuteScalar();
            //neu co loi thi phai xem lai cua lenh SQL o ben kia
            conn.Close();
            return o;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            dangnhap();
        }

        private void ckhienthimk_OnChange(object sender, EventArgs e)
        {
            if (ckhienthimk.Checked)
            {
                txttaikhoan.PasswordChar = '\0';
                txtmatkhau.PasswordChar = '\0';
            }
            else
            {
                txttaikhoan.PasswordChar = '\0';
                txtmatkhau.PasswordChar = '*';
            }
        }

        private void Giaodien_Load(object sender, EventArgs e)
        {
            A = lbl1.Text;
            txtmatkhau.PasswordChar = '*';
            mnudanhmuc.Enabled = true;
            mnuxuly.Enabled = false;
            mnubaocao.Enabled = false;
        }

        private void dangnhap()
        {
            lblthongbao.Text = "";
            string ten, mk;
            ten = txttaikhoan.Text;
            mk = txtmatkhau.Text;
            if (txttaikhoan.Text == "")
            {
                lblthongbao.Text = "Ten khong duoc de trong";
                lblthongbao.ForeColor = Color.Red;
                txttaikhoan.Focus();
                return;
            }
            if (txtmatkhau.Text == "")
            {
                lblthongbao.Text = "Mat khau khong duoc de trong";
                lblthongbao.ForeColor = Color.Red;
                txtmatkhau.Focus();
                return;
            }
            if (ten != "")
            {
                object Q = laygiatri("select * from TAIKHOAN where TenDN='" + ten + "'AND MK='" + mk + "'");
                if (Q == null)
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Sai tai khoan";
                }
                else
                {
                    lblthongbao.ForeColor = Color.Green;
                    lblthongbao.Text = "Thanh cong";
                    txttaikhoan.Text = "";
                    txtmatkhau.Text = "";
                    mnudanhmuc.Enabled = true;
                    mnuxuly.Enabled = true;
                    mnubaocao.Enabled = true;
                }
            }
        }

        public Giaodien()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=THINKPADE14;Initial Catalog=BTL_NET1_QLThuVienDataSet");
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dữToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = A.Length;
            d++;
            string a = A.Substring(0, 1);
            A = A.Substring(1, A.Length - 1);
            lbl1.Text = lbl1.Text + a;
            if (d == x)
            {
                timer1.Stop();
            }
        }

        private void mnudx_Click(object sender, EventArgs e)
        {
            mnudanhmuc.Enabled = false;
            mnuxuly.Enabled = false;
            mnubaocao.Enabled = false;
        }

        private void mnubaocao_Click(object sender, EventArgs e)
        {
            frmthongtinsach frm = new frmthongtinsach();
            frm.ShowDialog();
        }

        private void mnutimkiem_Click(object sender, EventArgs e)
        {
            frmtimkiemsach frm = new frmtimkiemsach();
            frm.ShowDialog();
        }

        private void mnuxuly_Click(object sender, EventArgs e)
        {
            frmmuontrasach frm = new frmmuontrasach();
            frm.ShowDialog();
        }

        private void mnutrogiup_Click(object sender, EventArgs e)
        {
            frmnoiquy frm = new frmnoiquy();
            frm.ShowDialog();
        }
    }
}
