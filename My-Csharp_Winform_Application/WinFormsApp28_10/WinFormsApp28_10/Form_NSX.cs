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
    public partial class Form_NSX : Form
    {
        private string conStr = @"Server=THINKPADE14/Vu_Linh_ThinkPade14;Database=QLBanHang;";
        private SqlConnection con;
        private SqlDataAdapter adapter;
        private SqlCommand cmd;
        private DataSet ds;
        private DataTable dt;
        public Form_NSX()
        {
            InitializeComponent();
        }
        private void Form_NSX_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            con = new SqlConnection(conStr);
            con.Open();

            string sqlStr = "SELECT * from NhaSanXuat";
            adapter = new SqlDataAdapter(sqlStr, con);

            ds = new DataSet();
            adapter.Fill(ds, "NhaSanXuat");
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Btn_add_NSX(object sender, EventArgs e)
        {
            con = new SqlConnection(conStr);
            con.Open();

            string sqlStr = "INSERT INTO NhaSanXuat(MaNSX,TenNSX,DiaChiNSX,SoLuongNhap) VALUES ('" +
                txtMaNSX + "','" + txtTenNSX + "','" + txtDiaChiNSX + "','" + txtSLNhap + "')";
            cmd = new SqlCommand(sqlStr, con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
        }

        private void Btn_edit_NSX(object sender, EventArgs e)
        {
            con = new SqlConnection(conStr);
            con.Open();
            string sqlStr = "UPDATE NhaSanXuat SET SoLuongNhap ='" + txtSLNhap +
                "'Where MaNSX='" + txtMaNSX + "'";
            cmd = new SqlCommand(sqlStr, con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
        }
        private void Btn_delete_NSX(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban muon xoa", "Thong bao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                con = new SqlConnection(conStr);
                con.Open();
                string sqlStr = "DELETE FROM NhaSanXuat Where MaNSX='" +
                    txtMaNSX + "'";
                cmd = new SqlCommand(conStr);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
            }
        }
        private void dataGridView_NSX(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaNSX.Text = dt.Rows[row]["MaNSX"].ToString();
            txtTenNSX.Text = dt.Rows[row]["TenNSX"].ToString();
            txtDiaChiNSX.Text = dt.Rows[row]["DiaChiNSX"].ToString();
            txtSLNhap.Text = dt.Rows[row]["SoLuongNhap"].ToString();
        }
    }
}
