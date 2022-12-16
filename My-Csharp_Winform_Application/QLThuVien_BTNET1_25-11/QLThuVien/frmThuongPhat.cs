using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmThuongPhat : Form
    {
        SqlConnection con;
        public frmThuongPhat()
        {
            InitializeComponent();
            con = new SqlConnection("DataSource = THINKPADE14;" +
                "Initial Catalog=QLNhanVien_Net1_25_11;Intergrated Security=True");
        }
        private DataTable docdulieu()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADTHUONGPHAT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            DataTable thuongphat
                = new DataTable();
            con.Open();
            thuongphat.Load(cmd.ExecuteReader());
            con.Close();
            return thuongphat;
        }
        private void loadlendtg()
        {
            dtgthuongphat.DataSource = docdulieu();
        }
        private void lienketdulieu()
        {
            txtmanhanvien.DataBindings.Add("Text", dtgthuongphat.DataSource, "MaNhanVien");
            txttenphongban.DataBindings.Add("Text", dtgthuongphat.DataSource, "TenPhongBan");
        }
        private void frmThuongPhat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_QLNhanVien_Net1_25_11DataSet.ThuongPhat' table. You can move, or remove it, as needed.
            this.thuongPhatTableAdapter.Fill(this._QLNhanVien_Net1_25_11DataSet.ThuongPhat);
            loadlendtg();
            lienketdulieu();
        }
        private void suathuongphat()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUATHUONGPHAT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            string manhanvien, loai, tien, lydo;
            DateTime ngay;
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("Ma nhan vien khong duoc de trong");
                txtmanhanvien.Focus();
                return;
            }
            if (txttien.Text == "")
            {
                MessageBox.Show("So tien khong duoc de trong");
                txttien.Focus();
                return;
            }
            if (txtlydo.Text == "")
            {
                MessageBox.Show("Ly do khong duoc de trong");
                txtlydo.Focus();
                return;
            }
            manhanvien = txtmanhanvien.Text;
            loai = txtloai.Text;
            tien = txttien.Text;
            lydo = txtlydo.Text;
            ngay = DateTime.Parse(dtpngay.Value.ToString());
            cmd.Parameters.AddWithValue("@MaNhanVien", manhanvien);
            cmd.Parameters.AddWithValue("@Loai", loai);
            cmd.Parameters.AddWithValue("@Lydo", lydo);
            cmd.Parameters.AddWithValue("@tien", tien);
            cmd.Parameters.AddWithValue("@Ngay", ngay);
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

        private void button2_Click(object sender, EventArgs e)
        {
            loadlendtg();
            lienketdulieu();
            suathuongphat();
        }
        private void luuthuongphat()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUTHUONGPHAT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            string manhanvien, loai, tien, lydo;
            DateTime ngay;
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("Ma nhan vien khong duoc de trong");
                txtmanhanvien.Focus();
                return;
            }
            if (txttien.Text == "")
            {
                MessageBox.Show("So tien khong duoc de trong");
                txttien.Focus();
                return;
            }
            if (txtlydo.Text == "")
            {
                MessageBox.Show("Ly do khong duoc de trong");
                txtlydo.Focus();
                return;
            }
            manhanvien = txtmanhanvien.Text;
            loai = txtloai.Text;
            tien = txttien.Text;
            lydo = txtlydo.Text;
            ngay = DateTime.Parse(dtpngay.Value.ToString());
            cmd.Parameters.AddWithValue("@MaNhanVien", manhanvien);
            cmd.Parameters.AddWithValue("@Loai", loai);
            cmd.Parameters.AddWithValue("@Lydo", lydo);
            cmd.Parameters.AddWithValue("@tien", tien);
            cmd.Parameters.AddWithValue("@Ngay", ngay);
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
                    MessageBox.Show("Mã da ton tai");
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

        private void btnluuthuongphat_Click(object sender, EventArgs e)
        {
            loadlendtg();
            lienketdulieu();
            luuthuongphat();
        }

        private void btnthoatThuongPhat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
