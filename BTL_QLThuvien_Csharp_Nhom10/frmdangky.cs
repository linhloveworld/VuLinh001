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

namespace BTL_QLThuvien_Csharp_Nhom10
{
    public partial class frmdangky : Form
    {
        SqlConnection cnn;
        public frmdangky()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=THINKPADE14;Initial Catalog=BTL_NET1_QLThuVienDataSet");
        }
        private void dangky()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_luutk";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string ten, mk, nlmk;
            ten = txttentk.Text;
            mk = txtmk.Text;
            nlmk = txtlmk.Text;
            if(txttentk.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Ten khong duoc de trong";
                txttentk.Focus();
                return;
            }
            if(txtmk.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Mat khau khong duoc de trong";
                txtmk.Focus();
                return;
            }
            if(txtlmk.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Mat khau phai duoc nhap lai";
                txtlmk.Focus();
                return;
            }
            if (txttentk.Text.Length - 1 < 5)
            {
                lblthongbao.ForeColor = Color.Orange;
                lblthongbao.Text = "Ten qua ngan";
                lblthongbao.Focus();
                return;
            }
            if (txtmk.Text.Length - 1 < 5)
            {
                lblthongbao.ForeColor = Color.Orange;
                lblthongbao.Text = "Mat khau khong an toan";
                txtmk.Focus();
                return;
            }
            if(txtlmk.Text != txtmk.Text)
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Mat khau can nhap lai dung";
                lblthongbao.Focus();
                return;
            }
            cmd.Parameters.AddWithValue("@tendn", ten);
            cmd.Parameters.AddWithValue("@mk", mk);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            this.Close();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            dangky();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txttentk.PasswordChar = '\0';
                txtmk.PasswordChar = '\0';
                txtlmk.PasswordChar = '\0';
            }
            else
            {
                txttentk.PasswordChar = '\0';
                txtmk.PasswordChar = '#';
                txtlmk.PasswordChar = '#';
            }
        }

        private void frmdangky_Load(object sender, EventArgs e)
        {
            txtmk.PasswordChar = '#';
            txtlmk.PasswordChar = '#';
        }

        private void frmdangky_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult noti;
            noti = MessageBox.Show("Ban dang thoat ra?"," ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (noti == DialogResult.Yes)
            {
                this.Close();
            }else if(noti == DialogResult.Cancel||noti==DialogResult.No)
            {
                return;
            }
        }
    }
}
