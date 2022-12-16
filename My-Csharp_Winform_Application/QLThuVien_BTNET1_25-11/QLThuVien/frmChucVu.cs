using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmChucVu : Form
    {
        SqlConnection con;
        public frmChucVu()
        {
            InitializeComponent();
            con = new SqlConnection("DataSource = THINKPADE14;" +
                "Initial Catalog=QLNhanVien_Net1_25_11;Intergrated Security=True");
        }
        private DataTable docdulieu()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADCHUCVU";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            DataTable chucvu
                = new DataTable();
            con.Open();
            chucvu.Load(cmd.ExecuteReader());
            con.Close();
            return chucvu;
        }
        private void loadlendtg()
        {
            dtgChucVu.DataSource = docdulieu();
        }
        private void lienketdulieu()
        {
            txtmachucvu.DataBindings.Add("Text",dtgChucVu.DataSource, "MaChucVu");
            txtmanhanvienchucvu.DataBindings.Add("Text", dtgChucVu.DataSource, "MaNhanVien");
            txtchucvu.DataBindings.Add("Text", dtgChucVu.DataSource, "ChucVu");
            txtlydo.DataBindings.Add("Text", dtgChucVu.DataSource, "LyDo");
            dtpngaybatdau.DataBindings.Add("Text", dtgChucVu.DataSource, "NgayBatDau");
            dtpngayketthuc.DataBindings.Add("Text", dtgChucVu.DataSource, "NgayKetThuc");
        }
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_QLNhanVien_Net1_25_11DataSet.ctChucVu' table. You can move, or remove it, as needed.
            this.ctChucVuTableAdapter.Fill(this._QLNhanVien_Net1_25_11DataSet.ctChucVu);
            loadlendtg();
            lienketdulieu();
        }
        private void suachucvu()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUACHUCVU";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            string manv, machucvu,lydo;
            DateTime ngaybatdau, ngayketthuc;
            if (txtmanhanvienchucvu.Text == "")
            {
                MessageBox.Show("Ma nhan vien kg được trống!");
                txtmanhanvienchucvu.Focus();
                return;
            }
            if (txtmachucvu.Text == "")
            {
                MessageBox.Show("ma chức vụ kg duoc trong!");
                txtmachucvu.Focus();
                return;
            }
            if (txtchucvu.Text == "")
            {
                MessageBox.Show("chức vụ kg duoc trong!");
                txtmachucvu.Focus();
                return;
            }
            if (txtlydo.Text == "")
            {
                MessageBox.Show("Ly do kg duoc trong!");
                txtlydo.Focus();
                return;
            }
            manv = txtmanhanvienchucvu.Text;
            machucvu = txtchucvu.Text;
            lydo = txtlydo.Text;
            ngaybatdau= DateTime.Parse(dtpngaybatdau.Value.ToString());
            ngayketthuc = DateTime.Parse(dtpngayketthuc.Value.ToString());
            cmd.Parameters.AddWithValue("@MaNhanVienChucVu", manv);
            cmd.Parameters.AddWithValue("@MaChucVu", machucvu);
            cmd.Parameters.AddWithValue("@LyDo", lydo);
            cmd.Parameters.AddWithValue("@NgayBatDau", ngaybatdau);
            cmd.Parameters.AddWithValue("@NgayKetThuc", ngayketthuc);
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
        private void luuchucvu()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUACHUCVU";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            string manv, machucvu, lydo;
            DateTime ngaybatdau, ngayketthuc;
            if (txtmanhanvienchucvu.Text == "")
            {
                MessageBox.Show("Ma nhan vien kg được trống!");
                txtmanhanvienchucvu.Focus();
                return;
            }
            if (txtmachucvu.Text == "")
            {
                MessageBox.Show("ma chức vụ kg duoc trong!");
                txtmachucvu.Focus();
                return;
            }
            if (txtchucvu.Text == "")
            {
                MessageBox.Show("chức vụ kg duoc trong!");
                txtmachucvu.Focus();
                return;
            }
            if (txtlydo.Text == "")
            {
                MessageBox.Show("Ly do kg duoc trong!");
                txtlydo.Focus();
                return;
            }
            manv = txtmanhanvienchucvu.Text;
            machucvu = txtchucvu.Text;
            lydo = txtlydo.Text;
            ngaybatdau = DateTime.Parse(dtpngaybatdau.Value.ToString());
            ngayketthuc = DateTime.Parse(dtpngayketthuc.Value.ToString());
            cmd.Parameters.AddWithValue("@MaNhanVienChucVu", manv);
            cmd.Parameters.AddWithValue("@MaChucVu", machucvu);
            cmd.Parameters.AddWithValue("@LyDo", lydo);
            cmd.Parameters.AddWithValue("@NgayBatDau", ngaybatdau);
            cmd.Parameters.AddWithValue("@NgayKetThuc", ngayketthuc);
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
                    MessageBox.Show("Mã trung");
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

        private void btnThoatChucVu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            suachucvu();
            loadlendtg();
            lienketdulieu();
        }

        private void btnluuchucvu_Click(object sender, EventArgs e)
        {
            luuchucvu();
            loadlendtg();
            lienketdulieu();
            
        }
    }
}
