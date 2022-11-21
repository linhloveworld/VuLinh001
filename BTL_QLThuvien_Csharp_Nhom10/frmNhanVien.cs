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

namespace BTL_QLThuvien_Csharp_Nhom10
{
    public partial class frmNhanVien : Form
    {
        string A;
        SqlConnection con;
     
        public frmNhanVien()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.;Initial Catalog=QLThuVien;Integrated Security=True");
        }

        private void txtTennv_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtManv.Enabled = false;
            loadnvtodatagridview();
            A = label1.Text;
            label1.Text = "";
            timer1.Start();
            data_binding();
            hientieudecot();
        }
        private string taoMaNV()
        {
            string MaNV;
            Random r = new Random();
            MaNV = "NV" + r.Next(50, 999).ToString();
            return MaNV;
        }
        private DataTable docdulieu()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText "sp_LOADNHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            DataTable nhanvien = new DataTable();
            con.Open();
            nhanvien.Load(cmd.ExecuteReader());
            con.Close();
            return nhanvien;
        }
        private void loadnvtodatagridview()
        {
            dtgttnv.DataSource = docdulieu();
        }
        #region hien tieu de cot
        private void hientieudecot()
        {
            dtgttnv.Columns[0].HeaderText = "Ten SV";
            dtgttnv.Columns[1].HeaderText = "Gioi tinh";
            dtgttnv.Columns[2].HeaderText = "Dia chi";
            dtgttnv.Columns[3].HeaderText = "So dien thoai";
            dtgttnv.Columns[4].HeaderText = "Ngay sinh";
            dtgttnv.Columns[5].HeaderText = "Ma NV";
            dtgttnv.Columns[6].HeaderText = "Chuc vu";
            dtgttnv.Columns[7].HeaderText = "Ngay vao lam";
        }
        #endregion
        #region xu ly binding
        private void data_binding()
        {
            txtTennv.DataBindings.Add("Text", dtgttnv.DataSource, "TenNV");
            ckGioiTinhnv.DataBindings.Add("Text", dtgttnv.DataSource, "Gioitinh");
            txtDiachinv.DataBindings.Add("Text", dtgttnv.DataSource, "DiachiNV");
            txtDienthoainv.DataBindings.Add("Text", dtgttnv.DataSource, "SodienthoaiNV");
            txtManv.DataBindings.Add("Text", dtgttnv.DataSource, "MaNV");
            txtChucvunv.DataBindings.Add("Text", dtgttnv.DataSource, "ChucvuNV");
        }
        private void Huy_binding()
        {
            if(txtTennv.DataBindings != null)
            {
                txtTennv.DataBindings.Clear();
            }
            if (ckGioiTinhnv.DataBindings != null)
            {
                ckGioiTinhnv.DataBindings.Clear();
            }
            if (txtDiachinv.DataBindings != null)
            {
                txtDiachinv.DataBindings.Clear();
            }
            if (txtDienthoainv.DataBindings != null)
            {
                txtDienthoainv.DataBindings.Clear();
            }
            if (txtManv.DataBindings != null)
            {
                txtManv.DataBindings.Clear();
            }
            if (txtChucvunv.DataBindings != null)
            {
                txtChucvunv.DataBindings.Clear();
            }
        }
        #endregion

        private void btnthemnv_Click(object sender, EventArgs e)
        {
            txtTennv.DataBindings.Clear();
            txtManv.DataBindings.Clear();
            ckGioiTinhnv.DataBindings.Clear();
            txtChucvunv.DataBindings.Clear();
            txtDiachinv.DataBindings.Clear();
            txtDienthoainv.DataBindings.Clear();
            txtManv.Text = taoMaNV();
      
        }
        private void luunhanvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUNHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            string manv, tennv, chucvunv, diachinv, dienthoainv;
            bool gioitinhnv;
            if (txtTennv.Text == "")
            {
                MessageBox.Show("Ten khong duoc de trong");
                txtTennv.Focus();
                return;
            }
            if (txtChucvunv.Text == "")
            {
                MessageBox.Show("Chuc vu khong duoc de trong");
                txtChucvunv.Focus();
                return;
            }
            if (txtDiachinv.Text == "")
            {
                MessageBox.Show("Dia chi khong duoc de trong");
                txtChucvunv.Focus();
                return;
            }
            if (txtDienthoainv.Text == "")
            {
                MessageBox.Show("Chuc vu khong duoc de trong");
                txtDienthoainv.Focus();
                return;
            }
            DateTime ngaysinh, ngayvaolam;
            if(DateTime.Now.Year-dtpNgaysinhnv.Value.Year<18 || DateTime.Now.Year - dtpNgaysinhnv.Value.Year > 85)
            {
                MessageBox.Show("Tuoi phai lon hon 18 va nho hon 85!");
                dtpNgaysinhnv.Focus();
                return;
            }
            manv = txtManv.Text;
            tennv = txtTennv.Text;
            ngaysinh = DateTime.Parse(dtpNgaysinhnv.ToString());
            ngayvaolam = DateTime.Parse(dtpNgayvaolam.ToString());
            if (ckGioiTinhnv.Text == "Nam")
            {
                gioitinhnv = true;
            }
            else gioitinhnv = false;
            chucvunv = txtChucvunv.Text;
            diachinv = txtDiachinv.Text;
            dienthoainv = txtDienthoainv.Text;
            cmd.Parameters.AddWithValue("@MaNV", manv);
            cmd.Parameters.AddWithValue("@TenNV", tennv);
            cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
            cmd.Parameters.AddWithValue("@Ngayvaolam", ngayvaolam);
            cmd.Parameters.AddWithValue("@GioiTinh", gioitinhnv);
            cmd.Parameters.AddWithValue("@ChucvuNV", chucvunv);
            cmd.Parameters.AddWithValue("@DiaChiNV", diachinv);
            try
            {
                cmd.Parameters.Add("@kq",
                    SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                con.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbaonv.ForeColor = Color.Red;
                    lblthongbaonv.Text = "Ma trung";
                    return;
                }
                else
                {
                    lblthongbaonv.ForeColor = Color.Green;
                    lblthongbaonv.Text = "Luu thanh cong";
                }
            }
            catch(Exception excp)
            {
                MessageBox.Show("Khong the them duoc vi " + excp.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void btnluunv_Click(object sender, EventArgs e)
        {
            Huy_binding();
            luunhanvien();
            loadnvtodatagridview();
            data_binding();
        }
        private void XoaNhanVien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_XOANHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            string manv;
            manv = txtManv.Text;
            cmd.Parameters.Add("@MaNV", manv);
            DialogResult noti;
            noti = MessageBox.Show("Ban muon xoa"," ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (noti == DialogResult.Yes)
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            try
            {
                cmd.Parameters.Add("@kq",
                    SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                con.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbaonv.ForeColor = Color.Red;
                    lblthongbaonv.Text = "Ma da ton tai trong phieu nhac tra sach!";
                    return;
                }
                else
                {
                    lblthongbaonv.ForeColor = Color.Green;
                    lblthongbaonv.Text = "Xoa thanh cong";
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Khong them duoc vi " + excp.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void btnxoanv_Click(object sender, EventArgs e)
        {
            Huy_binding();
            XoaNhanVien();
            loadnvtodatagridview();
            data_binding();
        }
        private void suanv()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUANHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            string manv, tennv, chucvunv, diachinv, dienthoai;
            bool gioitinh;
            if (txtTennv.Text == "")
            {
                MessageBox.Show("Ten nhan vien khong duoc de trong!");
                txtTennv.Focus();
                return;
            }
            if (txtManv.Text == "")
            {
                MessageBox.Show("Ma nhan vien khong duoc de trong!");
                txtTennv.Focus();
                return;
            }
            if (txtChucvunv.Text == "")
            {
                MessageBox.Show("Chuc vu nhan vien khong duoc de trong!");
                txtTennv.Focus();
                return;
            }
            if (txtDiachinv.Text == "")
            {
                MessageBox.Show("Dia chi cua nhan vien khong duoc de trong!");
                txtTennv.Focus();
                return;
            }
            if (txtDienthoainv.Text == "")
            {
                MessageBox.Show("SDT nhan vien khong duoc de trong!");
                txtTennv.Focus();
                return;
            }
            DateTime ngaysinh, ngayvaolam;
            if (DateTime.Now.Year - dtpNgaysinhnv.Value.Year < 18 || DateTime.Now.Year - dtpNgaysinhnv.Value.Year > 85)
            {
                MessageBox.Show("Tuoi phai lon hon 18 va nho hon 85!");
                dtpNgaysinhnv.Focus();
                return;
            }
            manv = txtManv.Text;
            tennv = txtTennv.Text;
            ngaysinh = DateTime.Parse(dtpNgaysinhnv.ToString());
            ngayvaolam = DateTime.Parse(dtpNgayvaolam.ToString());
            if (ckGioiTinhnv.Text == "Nam")
            {
                gioitinh = true;
            }
            else gioitinh = false;
            chucvunv = txtChucvunv.Text;
            diachinv = txtDiachinv.Text;
            dienthoai = txtDienthoainv.Text;
            cmd.Parameters.AddWithValue("@MaNV", manv);
            cmd.Parameters.AddWithValue("@TenNV", tennv);
            cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
            cmd.Parameters.AddWithValue("@Ngayvaolam", ngayvaolam);
            cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
            cmd.Parameters.AddWithValue("@ChucvuNV", chucvunv);
            cmd.Parameters.AddWithValue("@DiaChiNV", diachinv);
            try
            {
                cmd.Parameters.Add("@kq",
                    SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                con.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbaonv.ForeColor = Color.Red;
                    lblthongbaonv.Text = "Ma khong ton tai";
                    return;
                }
                else
                {
                    lblthongbaonv.ForeColor = Color.Green;
                    lblthongbaonv.Text = "Sua thong tin nhan vien thanh cong";
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Khong the them duoc vi " + excp.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void btnsuanv_Click(object sender, EventArgs e)
        {
            Huy_binding();
            suanv();
            loadnvtodatagridview();
            data_binding();
        }

        private void btnthoatnv_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Ban thuc su muon xoa?", "Thong bao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int d = 0, x;
            x = A.Length;
            d++;
            string a = A.Substring(0, 1);
            A = A.Substring(1, A.Length - 1);
            label1.Text = label1.Text + a;
            if (d == x)
            {
                timer1.Stop();
            }
        }

        private void txtpage_TextChanged(object sender, EventArgs e)
        {
            loadnvtodatagridview();
            hientieudecot();
        }
    }
}
