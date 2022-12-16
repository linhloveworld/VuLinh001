using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmPhongBan : Form
    {
        SqlConnection con;
        public frmPhongBan()
        {
            InitializeComponent();
            con = new SqlConnection("DataSource = THINKPADE14;" +
                "Initial Catalog=QLNhanVien_Net1_25_11;" +
                "Intergrated Security=True");
        }
        private DataTable docdulieu()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADPHONGBAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            DataTable phongban
                = new DataTable();
            con.Open();
            phongban.Load(cmd.ExecuteReader());
            con.Close();
            return phongban;
        }
        private void loadlendtg()
        {
            dtgPhongBan.DataSource = docdulieu();
        }
        private void lienketdulieu()
        {
            txtmaphongban.DataBindings.Add("Text", dtgPhongBan.DataSource, "MaChucVu");
            txttenphongban.DataBindings.Add("Text", dtgPhongBan.DataSource, "MaNhanVien");
        }
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_QLNhanVien_Net1_25_11DataSet.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this._QLNhanVien_Net1_25_11DataSet.PhongBan);
            loadlendtg();
            lienketdulieu();
        }
        private void suaphongban()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUAPHONGBAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            string maphongban, tenphongban;
            if (txtmaphongban.Text == "")
            {
                MessageBox.Show("Ma Phong ban kg được trống!");
                txtmaphongban.Focus();
                return;
            }
            if (txttenphongban.Text == "")
            {
                MessageBox.Show("Ten Phong ban kg duoc trong!");
                txttenphongban.Focus();
                return;
            }
            maphongban = txtmaphongban.Text;
            tenphongban = txttenphongban.Text;
            cmd.Parameters.AddWithValue("@MaPhongBan", maphongban);
            cmd.Parameters.AddWithValue("@TenPhongBan", tenphongban);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                con.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    MessageBox.Show("Mã ko ton tai");
                    return;
                }
                else
                {
                    MessageBox.Show("Sua Thành Công");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong them duoc vi" + ex.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }
        private void luuphongban()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUPHONGBAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            string maphongban, tenphongban;
            if (txtmaphongban.Text == "")
            {
                MessageBox.Show("Ma phong ban kg được trống!");
                txtmaphongban.Focus();
                return;
            }
            if (txttenphongban.Text == "")
            {
                MessageBox.Show("Ten Phong ban kg duoc trong!");
                txttenphongban.Focus();
                return;
            }
            maphongban = txtmaphongban.Text;
            tenphongban = txttenphongban.Text;
            cmd.Parameters.AddWithValue("@MaPhongBan", maphongban);
            cmd.Parameters.AddWithValue("@TenPhongBan", tenphongban);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                con.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    MessageBox.Show("Ma bi trung");
                    return;
                }
                else
                {
                    MessageBox.Show("Luu Thành Công");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong them duoc vi" + ex.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            loadlendtg();
            lienketdulieu();
            suaphongban();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            loadlendtg();
            lienketdulieu();
            luuphongban();
        }

        private void btnThoatphongban_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
