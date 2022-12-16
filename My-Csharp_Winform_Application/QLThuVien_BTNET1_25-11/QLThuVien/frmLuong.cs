using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLThuVien
{
    public partial class frmLuong : Form
    {
        SqlConnection con;
        public frmLuong()
        {
            InitializeComponent();
            con = new SqlConnection("DataSource = THINKPADE14;" +
                "Initial Catalog=QLNhanVien_Net1_25_11;" +
                "Intergrated Security=True");
        }
        private DataTable docdulieu()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADLUONG";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            DataTable luong
                = new DataTable();
            con.Open();
            luong.Load(cmd.ExecuteReader());
            con.Close();
            return luong;
        }
        private void loadlendtg()
        {
            dtgLuong.DataSource = docdulieu();
        }
        private void lienketdulieu()
        {
            txthesoluong.DataBindings.Add("Text", dtgLuong.DataSource, "HeSoLuongCoBan");
            txtluongcoban.DataBindings.Add("Text", dtgLuong.DataSource, "LuongCoBan");
        }
        private void frmLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_QLNhanVien_Net1_25_11DataSet.Luong' table. You can move, or remove it, as needed.
            this.luongTableAdapter.Fill(this._QLNhanVien_Net1_25_11DataSet.Luong);
            // TODO: This line of code loads data into the '_QLNhanVien_Net1_25_11DataSet.ctChucVu' table. You can move, or remove it, as needed.
            this.ctChucVuTableAdapter.Fill(this._QLNhanVien_Net1_25_11DataSet.ctChucVu);
            loadlendtg();
            lienketdulieu();
        }
        private void sualuong()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUALUONG";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            string hesoluong, luongcoban;
            if (txthesoluong.Text == "")
            {
                MessageBox.Show("He so luong kg được trống!");
                txthesoluong.Focus();
                return;
            }
            if (txtluongcoban.Text == "")
            {
                MessageBox.Show("Luong co ban kg duoc trong!");
                txtluongcoban.Focus();
                return;
            }
            hesoluong = txthesoluong.Text;
            luongcoban = txtluongcoban.Text;
            cmd.Parameters.AddWithValue("@HeSoLuong", hesoluong);
            cmd.Parameters.AddWithValue("@LuongCoBan", luongcoban);
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
        private void luuluong()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUULUONG";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            string hesoluong, luongcoban;
            if (txthesoluong.Text == "")
            {
                MessageBox.Show("He so luong kg được trống!");
                txthesoluong.Focus();
                return;
            }
            if (txtluongcoban.Text == "")
            {
                MessageBox.Show("Luong co ban kg duoc trong!");
                txtluongcoban.Focus();
                return;
            }
            hesoluong = txthesoluong.Text;
            luongcoban = txtluongcoban.Text;
            cmd.Parameters.AddWithValue("@HeSoLuong", hesoluong);
            cmd.Parameters.AddWithValue("@LuongCoBan", luongcoban);
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
                    MessageBox.Show("Bi trung");
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

        private void btnluuluong_Click(object sender, EventArgs e)
        {
            luuluong();
            loadlendtg();
            lienketdulieu();
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            sualuong();
            loadlendtg();
            lienketdulieu();
            
        }

        private void btnthoatLuong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
