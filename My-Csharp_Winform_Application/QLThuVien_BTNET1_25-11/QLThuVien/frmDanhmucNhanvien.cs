using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLThuVien
{
    public partial class frmDanhmucNhanvien : Form
    {
        SqlConnection conn;
        public frmDanhmucNhanvien()
        {
            InitializeComponent();
            conn = new SqlConnection("DataSource = THINKPADE14;" +
                "Initial Catalog=QLNhanVien_Net1_25_11;" +
                "Intergrated Security=True");
        }
        private DataTable readdata()
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "sp_LOADNHANVIEN";
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Connection = conn;
            DataTable nhanvien = new DataTable();
            conn.Open();
            nhanvien.Load(sqlcmd.ExecuteReader());
            conn.Close();
            return nhanvien;
        }
        private void loadtodtg()
        {
            dtgNhanVien.DataSource = readdata();
        }
        private void data_binding()
        {
            txtmanhanvien.DataBindings.Add("Text", dtgNhanVien.DataSource, "MaNhanVien");
            txtmahopdong.DataBindings.Add("Text", dtgNhanVien.DataSource, "MaHopDong");
            txtmaphongban.DataBindings.Add("Text", dtgNhanVien.DataSource, "MaPhongBan");
            txttennv.DataBindings.Add("Text", dtgNhanVien.DataSource, "TenNhanVien");
            txtdiachi.DataBindings.Add("Text", dtgNhanVien.DataSource, "DiaChi");
            txtemail.DataBindings.Add("Text", dtgNhanVien.DataSource, "Email");
            txtsocmnd.DataBindings.Add("Text", dtgNhanVien.DataSource, "SoCMND");
            txtsodienthoai.DataBindings.Add("Text", dtgNhanVien.DataSource, "SoDienThoai");
            txthesoluong.DataBindings.Add("Text", dtgNhanVien.DataSource, "HeSoLuong");
            txttinhtranghonnhan.DataBindings.Add("Text", dtgNhanVien.DataSource, "TinhTrangHonNhan");
        }
        private void del_binding()
        {
            if(txtmanhanvien.DataBindings != null)
            {
                txtmanhanvien.DataBindings.Clear();
            }
            if (txtmahopdong.DataBindings != null)
            {
                txtmahopdong.DataBindings.Clear();
            }
            if (txtmaphongban.DataBindings != null)
            {
                txtmaphongban.DataBindings.Clear();
            }
            if (txttennv.DataBindings != null)
            {
                txttennv.DataBindings.Clear();
            }
            if (txtsocmnd.DataBindings != null)
            {
                txtsocmnd.DataBindings.Clear();
            }
            if (txtsodienthoai.DataBindings != null)
            {
                txtsodienthoai.DataBindings.Clear();
            }
            if (txtemail.DataBindings != null)
            {
                txtemail.DataBindings.Clear();
            }
            if (txtdiachi.DataBindings != null)
            {
                txtdiachi.DataBindings.Clear();
            }
            if (txthesoluong.DataBindings != null)
            {
                txthesoluong.DataBindings.Clear();
            }
            if (txttinhtranghonnhan.DataBindings != null)
            {
                txttinhtranghonnhan.DataBindings.Clear();
            }
        }
        private void frmDanhmucNhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_QLNhanVien_Net1_25_11DataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this._QLNhanVien_Net1_25_11DataSet.NhanVien);
            loadtodtg();
            data_binding();
        }
        private void suanhanvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUANHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            string manhanvien,mahopdong,maphongban,tennv,diachi,email,
                socmnd,sodienthoai,hesoluong,tinhtranghonnhan;
            bool gioitinh;
            DateTime ngaysinh;
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("Ma nhan vien khong được trống!");
                txthesoluong.Focus();
                return;
            }
            if (txtmahopdong.Text == "")
            {
                MessageBox.Show("Ma hop dong khong duoc trong!");
                txtmahopdong.Focus();
                return;
            }
            if (txttennv.Text == "")
            {
                MessageBox.Show("Ten nhan vien khong duoc trong!");
                txttennv.Focus();
                return;
            }
            if (txtsocmnd.Text == "")
            {
                MessageBox.Show("So CMND nhan vien khong duoc trong!");
                txtsocmnd.Focus();
                return;
            }
            if (txtsodienthoai.Text == "")
            {
                MessageBox.Show("So dien thoai nhan vien khong duoc trong!");
                txtsodienthoai.Focus();
                return;
            }
            if (txtemail.Text == "")
            {
                MessageBox.Show("Email nhan vien khong duoc trong!");
                txtemail.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Dia chi cua nhan vien khong duoc de trong!");
                txtdiachi.Focus();
                return;
            }
            manhanvien = txtmanhanvien.Text;
            mahopdong = txtmahopdong.Text;
            maphongban = txtmaphongban.Text;
            tennv = txttennv.Text;
            if (cbogioitinhnv.Text == "Nam")
            {
                gioitinh = true;
            }
            else
            {
                gioitinh = false;
            }
            socmnd = txtsocmnd.Text;
            sodienthoai = txtsodienthoai.Text;
            email = txtemail.Text;
            diachi = txtdiachi.Text;
            tinhtranghonnhan = txttinhtranghonnhan.Text;
            hesoluong = txthesoluong.Text;
            ngaysinh = DateTime.Parse(dtpngaysinhnv.ToString());
            cmd.Parameters.AddWithValue("@MaNhanVien", manhanvien);
            cmd.Parameters.AddWithValue("@MaHopDong", mahopdong);
            cmd.Parameters.AddWithValue("@MaPhongBan", maphongban);
            cmd.Parameters.AddWithValue("@TenNhanVien", tennv);
            cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
            cmd.Parameters.AddWithValue("@SoCMND", socmnd);
            cmd.Parameters.AddWithValue("@SoDienThoai", sodienthoai);
            cmd.Parameters.AddWithValue("@DiaChi", diachi);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@HeSoLuong", hesoluong);
            cmd.Parameters.AddWithValue("@TinhTrangHonNhan", tinhtranghonnhan);
            cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                conn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    MessageBox.Show("Mã nhan vien ko ton tai");
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
                if (conn != null)
                    conn.Close();
            }
        }
        private void luunhanvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUNHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            string manhanvien, mahopdong, maphongban, tennv, diachi, email,
                socmnd, sodienthoai, hesoluong, tinhtranghonnhan;
            bool gioitinh;
            DateTime ngaysinh;
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("Ma nhan vien khong được trống!");
                txthesoluong.Focus();
                return;
            }
            if (txtmahopdong.Text == "")
            {
                MessageBox.Show("Ma hop dong khong duoc trong!");
                txtmahopdong.Focus();
                return;
            }
            if (txttennv.Text == "")
            {
                MessageBox.Show("Ten nhan vien khong duoc trong!");
                txttennv.Focus();
                return;
            }
            if (txtsocmnd.Text == "")
            {
                MessageBox.Show("So CMND nhan vien khong duoc trong!");
                txtsocmnd.Focus();
                return;
            }
            if (txtsodienthoai.Text == "")
            {
                MessageBox.Show("So dien thoai nhan vien khong duoc trong!");
                txtsodienthoai.Focus();
                return;
            }
            if (txtemail.Text == "")
            {
                MessageBox.Show("Email nhan vien khong duoc trong!");
                txtemail.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Dia chi cua nhan vien khong duoc de trong!");
                txtdiachi.Focus();
                return;
            }
            manhanvien = txtmanhanvien.Text;
            mahopdong = txtmahopdong.Text;
            maphongban = txtmaphongban.Text;
            tennv = txttennv.Text;
            if (cbogioitinhnv.Text == "Nam")
            {
                gioitinh = true;
            }
            else
            {
                gioitinh = false;
            }
            socmnd = txtsocmnd.Text;
            sodienthoai = txtsodienthoai.Text;
            email = txtemail.Text;
            diachi = txtdiachi.Text;
            tinhtranghonnhan = txttinhtranghonnhan.Text;
            hesoluong = txthesoluong.Text;
            ngaysinh = DateTime.Parse(dtpngaysinhnv.ToString());
            cmd.Parameters.AddWithValue("@MaNhanVien", manhanvien);
            cmd.Parameters.AddWithValue("@MaHopDong", mahopdong);
            cmd.Parameters.AddWithValue("@MaPhongBan", maphongban);
            cmd.Parameters.AddWithValue("@TenNhanVien", tennv);
            cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
            cmd.Parameters.AddWithValue("@SoCMND", socmnd);
            cmd.Parameters.AddWithValue("@SoDienThoai", sodienthoai);
            cmd.Parameters.AddWithValue("@DiaChi", diachi);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@HeSoLuong", hesoluong);
            cmd.Parameters.AddWithValue("@TinhTrangHonNhan", tinhtranghonnhan);
            cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                conn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    MessageBox.Show("Mã nhan vien da ton tai");
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
                if (conn != null)
                    conn.Close();
            }
        }
        private void btnsuanhanvien_Click(object sender, EventArgs e)
        {
            del_binding();
            suanhanvien();
            loadtodtg();
            data_binding();
        }

        private void btnluunhanvien_Click(object sender, EventArgs e)
        {
            del_binding();
            luunhanvien();
            loadtodtg();
            data_binding();
        }
        private void btnThoatNhanVien_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
