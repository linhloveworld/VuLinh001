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
    public partial class Form_KH : Form
    {
        private string conStr = @"Server=THINKPADE14/Vu_Linh_ThinkPade14;Database=QLBanHang;";
        private SqlConnection con;
        private SqlDataAdapter adapter;
        private SqlCommand cmd;
        private DataSet ds;
        private DataTable dt;
        public Form_KH()
        {
            InitializeComponent();
        }
        private void Form_KH_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            con = new SqlConnection(conStr);
            con.Open();

            string sqlStr = "SELECT * from KhachHang";
            adapter = new SqlDataAdapter(sqlStr, con);

            ds = new DataSet();
            adapter.Fill(ds, "KhachHang");
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Btn_add_KH(object sender, EventArgs e)
        {
            con = new SqlConnection(conStr);
            con.Open();

            string sqlStr = "INSERT INTO KhachHang(MaKH,TenKH,DCKH,SDTKH) VALUES ('" +
                txtMaKH + "','" + txtTenKH + "','" + txtDCKH + "','"+txtSDTKH +"')";
            cmd = new SqlCommand(sqlStr, con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
        }

        private void Btn_edit_KH(object sender, EventArgs e)
        {
            con = new SqlConnection(conStr);
            con.Open();
            string sqlStr = "UPDATE KhachHang SET TenKH =N'" + txtTenKH +
                "'Where MaKH='" + txtMaKH + "'";
            cmd = new SqlCommand(sqlStr, con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
        }
        private void Btn_delete_SP(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban muon xoa", "Thong bao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                con = new SqlConnection(conStr);
                con.Open();
                string sqlStr = "DELETE FROM SanPham Where MaKH='" + 
                    txtMaKH + "'";
                cmd = new SqlCommand(conStr);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
            }
        }
        private void dataGridView_KH(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaKH.Text = dt.Rows[row]["MaKH"].ToString();
            txtTenKH.Text = dt.Rows[row]["TenKH"].ToString();
            txtDCKH.Text = dt.Rows[row]["DCKH"].ToString();
            txtSDTKH.Text = dt.Rows[row]["SDTKH"].ToString();
        }
    }
}
