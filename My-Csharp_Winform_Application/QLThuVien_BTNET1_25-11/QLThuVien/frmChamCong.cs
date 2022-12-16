using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmChamCong : Form
    {
        SqlConnection con;
        public frmChamCong()
        {
            InitializeComponent();
            con = new SqlConnection("DataSource = THINKPADE14;" +
                "Initial Catalog=QLNhanVien_Net1_25_11;Intergrated Security=True");
        }
        private DataTable docdulieu()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADCHAMCONG";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            DataTable chamcong = new DataTable();
            con.Open();
            chamcong.Load(cmd.ExecuteReader());
            con.Close();
            return chamcong;
        }
        private void loadlendtg()
        {
            dtgChamcong.DataSource = docdulieu();
        }
        private void lienketdulieu()
        {
            txtmanhanvienchamcong.DataBindings.Add("Text", dtgChamcong.DataSource, "MaNV");
            dtpngaychamcong.DataBindings.Add("Text", dtgChamcong.DataSource, "NgayChamcong");
            txttinhtrangchamcong.DataBindings.Add("Text", dtgChamcong.DataSource, "TinhTrangchamcong");
        }
        private void frmChamCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_QLNhanVien_Net1_25_11DataSet.ChamCong' table. You can move, or remove it, as needed.
            this.chamCongTableAdapter.Fill(this._QLNhanVien_Net1_25_11DataSet.ChamCong);
            loadlendtg();
            lienketdulieu();
        }

        private void btnThoatChamcong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnluuchamcong_Click(object sender, EventArgs e)
        {
            luuchamcong();
            loadlendtg();
            lienketdulieu();
        }
        private void luuchamcong()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUNHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            string manv, tinhtrangchamcong;
            DateTime ngaychamcong;
            if (txtmanhanvienchamcong.Text == "")
            {
                MessageBox.Show("Ma nhan vien kg được trống!");
                txtmanhanvienchamcong.Focus();
                return;
            }
            if (txttinhtrangchamcong.Text == "")
            {
                MessageBox.Show("chức vụ kg duoc trong!");
                txttinhtrangchamcong.Focus();
                return;
            }
            manv = txtmanhanvienchamcong.Text;
            tinhtrangchamcong = txttinhtrangchamcong.Text;
            ngaychamcong = DateTime.Parse(s: dtpngaychamcong.Value.ToString());
            cmd.Parameters.AddWithValue("@MaNhanVien", manv);
            cmd.Parameters.AddWithValue("@Ngay", ngaychamcong);
            cmd.Parameters.AddWithValue("@TinhTrang", tinhtrangchamcong);
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
                    MessageBox.Show("Mã Trùng");
                    return;
                }
                else
                {
                    MessageBox.Show("Lưu Thành Công");
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
        private void btnsuachamcong_Click(object sender, EventArgs e)
        {
            suachamcong();
            loadlendtg();
            lienketdulieu();
        }
        private void suachamcong()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUACHAMCONG";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            string manv, tinhtrangchamcong;
            DateTime ngaychamcong;
            if (txtmanhanvienchamcong.Text == "")
            {
                MessageBox.Show("Ma nhan vien kg được trống!");
                txtmanhanvienchamcong.Focus();
                return;
            }
            if (txttinhtrangchamcong.Text == "")
            {
                MessageBox.Show("chức vụ kg duoc trong!");
                txttinhtrangchamcong.Focus();
                return;
            }
            manv = txtmanhanvienchamcong.Text;
            tinhtrangchamcong = txttinhtrangchamcong.Text;
            ngaychamcong = DateTime.Parse(s: dtpngaychamcong.Value.ToString());
            cmd.Parameters.AddWithValue("@MaNhanVien", manv);
            cmd.Parameters.AddWithValue("@Ngay", ngaychamcong);
            cmd.Parameters.AddWithValue("@TinhTrang", tinhtrangchamcong);
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
    }
}
