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
    public partial class frmPhieuNhacTra : Form
    {
        string A;
        SqlConnection conn;
        public frmPhieuNhacTra()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=THINKPADE14;Initial Catalog=BTL_NET1_QLThuVienDataSet");
        }
        
        private void txtghichu_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpngaylap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnthoatpnt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPhieuNhacTra_Load(object sender, EventArgs e)
        {

        }
        private string taomapnt()
        {
            string mapnt;
            Random r = new Random();
            mapnt = "PNT" + r.Next(0, 999).ToString();
            return mapnt;
        }
        private void lienket_dulieu()
        {
            txtmapnt.DataBindings.Add("Text", dtgttpnt.DataSource, "MaPNT");
            cbomathe.DataBindings.Add("Text", dtgttpnt.DataSource, "Mathe");
            cbomasach.DataBindings.Add("Text", dtgttpnt.DataSource, "MaSach");
            cbomanv.DataBindings.Add("Text", dtgttpnt.DataSource, "Manhanvien");
            txtghichu.DataBindings.Add("Text", dtgttpnt.DataSource, "GhiChu");
            txtdgp.DataBindings.Add("Text", dtgttpnt.DataSource, "DonGiaphat");
        }
        private void huy_lienketdulieu()
        {
            if (txtmapnt.DataBindings != null)
                txtmapnt.DataBindings.Clear();
            if (txtghichu.DataBindings != null)
                txtghichu.DataBindings.Clear();
            if (dtpngaylap.DataBindings != null)
                dtpngaylap.DataBindings.Clear();
            if (txtdgp.DataBindings != null)
                txtdgp.DataBindings.Clear();
            if (cbomasach.DataBindings != null)
                cbomasach.DataBindings.Clear();
            if (cbomanv.DataBindings != null)
                cbomanv.DataBindings.Clear();
            if (cbomathe.DataBindings != null)
                cbomathe.DataBindings.Clear();
        }
        private void hienthitieudecotDataTable()
        {
            dtgttpnt.Columns[0].HeaderText = "Ma phieu nt";
            dtgttpnt.Columns[1].HeaderText = "Ma the";
            dtgttpnt.Columns[2].HeaderText = "Ma sach";
            dtgttpnt.Columns[3].HeaderText = "Ma nhan vien";
            dtgttpnt.Columns[4].HeaderText = "Ghi chu";
            dtgttpnt.Columns[5].HeaderText = "Don gia phat";
        }
        private DataTable loadsach()
        {
            SqlCommand sql = new SqlCommand();
            sql.CommandType = CommandType.StoredProcedure;
            sql.CommandText = "sp_LOADSACH";
            sql.Connection = conn;
            DataTable sach = new DataTable();
            conn.Open();
            sach.Load(sql.ExecuteReader());
            conn.Close();
            return sach;
        }
        private void hienthidlsach()
        {
            cbomasach.DataSource = loadsach();
            cbomasach.ValueMember = "MaSach";
            cbomasach.DisplayMember = "TenSach";
        }
        private DataTable loadnv()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LOADNHANVIEN";
            cmd.Connection = conn;
            DataTable nhanvien = new DataTable();
            conn.Open();
            nhanvien.Load(cmd.ExecuteReader());
            conn.Close();
            return nhanvien;
        }
        private void hienthidlnhanvien()
        {
            cbomanv.DataSource = loadnv();
            cbomanv.DisplayMember = "TenNhanVien";
            cbomanv.ValueMember = "MaNhanVien";
        }
        private DataTable loadthethuvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LOADTHETHUVIEN";
            cmd.Connection = conn;
            DataTable thethuvien
                = new DataTable();
            conn.Open();
            thethuvien.Load(cmd.ExecuteReader());
            conn.Close();
            return thethuvien;
        }
        private void hienthidlthethuvien()
        {
            cbomanv.DataSource = loadthethuvien();
            cbomanv.DisplayMember = "TenSinhVien";
            cbomanv.ValueMember = "MaTheThuVien";
        }
        private DataTable loadphieunhactra()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LOADPHIEUNHACTRA";
            cmd.Connection = conn;
            DataTable phieunhactra = new DataTable();
            conn.Open();
            phieunhactra.Load(cmd.ExecuteReader());
            conn.Close();
            return phieunhactra;
        }
        private void hienthidlphieunt()
        {
            dtgttpnt.DataSource = loadphieunhactra();
        }

        private void btnthempnt_Click(object sender, EventArgs e)
        {
            txtmapnt.Clear();
            txtghichu.Clear();
            txtdgp.Clear();
            txtmapnt.Text = taomapnt();
        }
        private void luuphieunhactra()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LUUPHIEUNHACTRA";
            cmd.Connection = conn;
            string mapnt, masach, manv, mathe, ghichu;
            double dongiaphat;
            DateTime ngaylapphieu;
            mapnt = txtmapnt.Text;
            masach = cbomasach.SelectedValue.ToString();
            manv = cbomanv.SelectedValue.ToString();
            mathe = cbomathe.SelectedValue.ToString();
            ghichu = txtghichu.Text;
            ngaylapphieu = DateTime.Parse(dtpngaylap.Value.ToString());
            if (txtdgp.Text == "")
            {
                dongiaphat = 0;
            }
            else
            {
                dongiaphat = double.Parse(txtdgp.Text);
            }
            cmd.Parameters.Add("@MaPNT", mapnt);
            cmd.Parameters.Add("@MaTheThuVien", mathe);
            cmd.Parameters.Add("@MaSach", masach);
            cmd.Parameters.Add("@MaNhanVien", manv);
            cmd.Parameters.Add("@NgayLapPhieu", ngaylapphieu);
            cmd.Parameters.Add("@DonGiaphat", dongiaphat);
            cmd.Parameters.Add("@GhiChu", ghichu);
            try
            {
                cmd.Parameters.Add("@kq", SqlDbType.Int).Direction = 
                    ParameterDirection.ReturnValue;
                conn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Da ton tai phieu";
                    return;
                }else if (kq == 2)
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Khong ton tai nhan vien";
                    return;
                }else if (kq == 3)
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Khong ton tai sinh vien";
                    return;
                }else if (kq == 4)
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Khong ton tai sach";
                    return;
                }else
                {
                    lblthongbaopnt.ForeColor = Color.Green;
                    lblthongbaopnt.Text = "Luu thanh cong";
                }
            }catch(Exception exp)
            {
                MessageBox.Show("Loi khong luu duoc vi" + exp.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        private void btnluupnt_Click(object sender, EventArgs e)
        {
            huy_lienketdulieu();
            luuphieunhactra();
            loadphieunhactra();
            lienket_dulieu();
        }
        private void suaphieunhactra()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUAPHIEUNHACTRA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            string mapnt, manv, mathe, masach, ghichu;
            double dongiaphat;
            DateTime ngaylap;
            mapnt = txtmapnt.Text;
            ghichu = txtghichu.Text;
            manv = cbomanv.SelectedValue.ToString();
            mathe = cbomathe.SelectedValue.ToString();
            masach = cbomasach.SelectedValue.ToString();
            ngaylap = DateTime.Parse(dtpngaylap.Value.ToString());
            if (txtdgp.Text == "")
            {
                dongiaphat = 0;
            }
            else dongiaphat = double.Parse(txtdgp.Text);
            cmd.Parameters.Add("@MaPNT", mapnt);
            cmd.Parameters.Add("@NgayLap", ngaylap);
            cmd.Parameters.Add("@DonGiaPhat", dongiaphat);
            cmd.Parameters.Add("@MaNV", manv);
            cmd.Parameters.Add("@MaSach", masach);
            cmd.Parameters.Add("@MaThe", mathe);
            cmd.Parameters.Add("@GhiChu", ghichu);
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
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Không tồn tại PNT";
                    return;
                }
                else if (kq == 2)
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Không tồn tại nhân viên";
                    return;
                }
                else if (kq == 3)
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Không tồn tại Sinh Viên";
                    return;
                }
                else if (kq == 4)
                {
                    lblthongbaopnt.ForeColor = Color.Red;
                    lblthongbaopnt.Text = "Không tồn tại Sách";
                    return;
                }
                else
                {
                    lblthongbaopnt.ForeColor = Color.Green;
                    lblthongbaopnt.Text = "Sửa Thành công";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi kg them duoc vi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void btnsuapnt_Click(object sender, EventArgs e)
        {
            huy_lienketdulieu();
            suaphieunhactra();
            loadphieunhactra();
            lienket_dulieu();
        }
        private void xoaphieunhactra()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_XOAPHIEUNHACTRA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            string mapnt;
            mapnt = txtmapnt.Text;
            cmd.Parameters.Add("@MaPNT", mapnt);
            DialogResult kq;
            kq = MessageBox.Show("Bạn Thật Sự Muốn Xóa", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            lblthongbaopnt.ForeColor = Color.Green;
            lblthongbaopnt.Text = "Xóa Thành Công";
        }

        private void btnxoapnt_Click(object sender, EventArgs e)
        {
            huy_lienketdulieu();
            xoaphieunhactra();
            loadphieunhactra();
            lienket_dulieu();
        }

        private void txtdgp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 45 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46)
            {
                e.Handled = true;
                lblthongbaopnt.ForeColor = Color.Red;
                lblthongbaopnt.Text = "Không được nhập chữ";
            }
        }
    }
}