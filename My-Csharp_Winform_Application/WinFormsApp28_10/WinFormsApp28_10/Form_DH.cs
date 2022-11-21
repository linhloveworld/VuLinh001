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

namespace WinFormsApp28_10
{
    public partial class Form_DH : Form
    {
        private string conStr = @"Server=THINKPADE14/Vu_Linh_ThinkPade14;Database=QLBanHang;";
        private SqlConnection con;
        private SqlDataAdapter adapter;
        private SqlCommand cmd;
        private DataSet ds;
        private DataTable dt;
        public Form_DH()
        {
            InitializeComponent();
        }
        private void Form_DH_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            con = new SqlConnection(conStr);
            con.Open();

            string sqlStr = "SELECT * from DonHang";
            adapter = new SqlDataAdapter(sqlStr, con);

            ds = new DataSet();
            adapter.Fill(ds, "DonHang");
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Btn_add_DH(object sender, EventArgs e)
        {
            con = new SqlConnection(conStr);
            con.Open();

            string sqlStr = "INSERT INTO DonHang(MaDH,MaSP,MaKH,SoLuongDH,TongTien) VALUES ('" +
                txtMaDH + "','" + txtMaKH + "','" + txtMaSP + "','" +
                txtSoLuongDH + "','" + txtTongTien + "'";
            cmd = new SqlCommand(sqlStr, con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
        }

        private void Btn_edit_DH(object sender, EventArgs e)
        {
            con = new SqlConnection(conStr);
            con.Open();
            string sqlStr = "UPDATE DonHang SET SoLuongDH ='" + txtSoLuongDH + 
                "'TongTien "+ txtTongTien +
                "'Where MaDH='" + txtMaDH + "'";
            cmd = new SqlCommand(sqlStr, con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
        }
        private void Btn_delete_DH(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban muon xoa", "Thong bao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                con = new SqlConnection(conStr);
                con.Open();
                string sqlStr = "DELETE FROM DonHang Where MaDH='" +
                    txtMaDH + "'";
                cmd = new SqlCommand(conStr);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
            }
        }
        private void dataGridView_DH(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaDH.Text = dt.Rows[row]["MaDH"].ToString();
            txtMaSP.Text = dt.Rows[row]["MaSP"].ToString();
            txtMaKH.Text = dt.Rows[row]["MaKH"].ToString();
            txtSoLuongDH.Text = dt.Rows[row]["SoLuongDH"].ToString();
            txtTongTien.Text = dt.Rows[row]["TongTien"].ToString();
        }
    }
}

