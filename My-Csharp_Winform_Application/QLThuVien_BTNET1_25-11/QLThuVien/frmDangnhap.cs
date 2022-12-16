using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmDangnhap : Form
    {
        public static string UserName = "";
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void btnthoatdangnhap_Click(object sender, EventArgs e)
        {
            DialogResult noti = MessageBox.Show("Ban dang thoat ra?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (noti == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpassword.Checked)
            {
                txtmatkhau.PasswordChar = (char)0;
            }
            else
            {
                txtmatkhau.PasswordChar = '*';
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure();
                cmd.CommandText = "sp_Login";
                cmd.Parameters.AddWithValue("@TenDangNhap", txttentk.Text);
                cmd.Parameters.AddWithValue("@MatKhau", txtmatkhau.Text);
                cmd.Parameters.AddWithValue("@MaNhanVien", txtmanhanvien.Text);
                cmd.Parameters.AddWithValue("@TenQuyenHan", txtquyenhan.Text);
                cmd.Connection = connection;
                UserName = txttentk.Text;
                object result = cmd.ExecuteScalar();
                int code = Convert.ToInt32(result);
                if (code == 0)
                {
                    MessageBox.Show("Dang nhap voi tu cach member", "Thong bao",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }else if (code == 1)
                {
                    MessageBox.Show("Dang nhap voi tu cach admin", "Thong bao",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }else if (code == 2)
                {
                    MessageBox.Show("Dang nhap voi tu cach moderator", "Thong bao",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }else if(code == 3)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmatkhau.Text = "";
                    txttentk.Text = "";
                    txttentk.Focus();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttentk.Text = "";
                    txtmatkhau.Text = "";
                    txttentk.Focus();
                }
                connection.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
