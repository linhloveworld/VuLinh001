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
    public partial class Form_SP : Form
    {
        private string conStr = @"Server=THINKPADE14/Vu_Linh_ThinkPade14;Database=QLBanHang;";
        private SqlConnection con;
        private SqlDataAdapter adapter;
        private SqlCommand cmd;
        private DataSet ds;
        private DataTable dt;

        public Form_SP()
        {
            InitializeComponent();
        }
        private void Form_SP_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            con = new SqlConnection(conStr);
            con.Open();

            string sqlStr = "SELECT * from SanPham";
            adapter = new SqlDataAdapter(sqlStr, con);

            ds = new DataSet();
            adapter.Fill(ds, "SanPham");
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Btn_add_SP(object sender, EventArgs e)
        {
            con = new SqlConnection(conStr);
            con.Open();

            string sqlStr = "INSERT INTO SanPham(MaSP,TenSP,Gia) VALUES ('" +
                txtMaSP + "',N'" + txtTenSP + "','" + txtGiaSP + "')";
            cmd = new SqlCommand(sqlStr, con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
        }

        private void Btn_edit_SP(object sender, EventArgs e)
        {
            con = new SqlConnection(conStr);
            con.Open();
            string sqlStr = "UPDATE SanPham SET TenSP =N'" + txtTenSP +
                "'Where MaSP='" + txtMaSP + "'";
            cmd = new SqlCommand(sqlStr,con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
        }
        private void Btn_delete_SP(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban muon xoa","Thong bao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                con = new SqlConnection(conStr);
                con.Open();
                string sqlStr = "DELETE FROM SanPham Where MaSP='" + txtMaSP + "'";
                cmd = new SqlCommand(conStr);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
            }
        }
        private void dataGridView_SP(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; 
            txtMaSP.Text = dt.Rows[row]["MaSP"].ToString();
            txtTenSP.Text = dt.Rows[row]["TenSP"].ToString();
            txtGiaSP.Text = dt.Rows[row]["GiaSP"].ToString();
        }
        private void label3_Click(object sender, EventArgs e)
        {}

        private void btn_exit_Click(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {}
    }
}
