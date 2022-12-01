using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
namespace BTL_QLThuvien_Csharp_Nhom10
{
    public partial class frmtimkiemsach : Form
    {
        OpenFileDialog file;
        SqlConnection cnn;
        public frmtimkiemsach()
        {
            InitializeComponent();
            cnn = new SqlConnection("DataSource = THINKPADE14;" +
                "Initial Catalog=. ;" + "Intergrated Security=True");
        }

        private void frmtimkiemsach_Load(object sender, EventArgs e)
        {
            loaddlsach();
            hienthitieudde();
            lienket_dulieu();
        }
        private DataTable loadsachtheoma(string masach)
        {
            string chuoi = "SELECT * FROM SACH WHERE MaSach = @MaSach";
            DataTable sach = new DataTable();
            SqlCommand command = new SqlCommand(chuoi, cnn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MaSach", masach);
            try
            {
                cnn.Open();
                sach.Load(command.ExecuteReader());
            }
            catch (Exception exc)
            {
                MessageBox.Show("Loi khong thuc hien duoc: " + exc.Message);
            }
            finally
            {
                if (cnn != null) cnn.Close();
            }
            return sach;
        }
        private DataTable loadsachtheotinhtrang(string tinhtrang)
        {
            string chuoi = "SELECT * FROM SACH WHERE TinhTrang = @TinhTrang";
            SqlCommand cmd = new SqlCommand(chuoi, cnn);
            DataTable sach = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TinhTrang", tinhtrang);
            try
            {
                cnn.Open();
                sach.Load(cmd.ExecuteReader());
            }
            catch (Exception exp)
            {
                MessageBox.Show("Khong thuc hien duoc vi " +
                    exp.Message);
            }
            finally
            {
                if (cnn != null)
                    cnn.Close();
            }
            return sach;
        }
        private DataTable loadsachtheoten(string ten)
        {
            string chuoi = "SELECT * FROM SACH WHERE TenSach = @TenSach";
            SqlCommand cmd = new SqlCommand(chuoi, cnn);
            DataTable sach = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenSach", ten);
            try
            {
                cnn.Open();
                sach.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong thuc hien duoc vi" + ex.Message);
            }
            finally
            {
                if (cnn != null)
                    cnn.Close();
            }
            return sach;
        }
        private DataTable loadsachtheonamxb(string namxb)
        {
            string chuoi = "SELECT * FROM SACH WHERE NamXuatBan = @NamXuatBan";
            SqlCommand sqlCommand = new SqlCommand(chuoi,cnn);
            DataTable sach = new DataTable();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@NamXuatBan", namxb);
            try
            {
                cnn.Open();
                sach.Load(sqlCommand.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong thuc hien duoc vi" + ex.Message);
            }
            finally
            {
                if (cnn != null)
                    cnn.Close();
            }
            return sach;
        }
        private DataTable loadsachtheonhaxuatban(string nhaxb)
        {
            string chuoi = "SELECT * FROM SACH WHERE NhaXuatBan = @NhaXuatBan";
            SqlCommand sqlcmd = new SqlCommand(chuoi, cnn);
            DataTable sach = new DataTable();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@NhaXuatBan", nhaxb);
            try
            {
                cnn.Open();
                sach.Load(sqlcmd.ExecuteReader());
            }
            catch (Exception exc)
            {
                MessageBox.Show("Loi khong thuc hien duoc: " + exc.Message);
            }
            finally
            {
                if (cnn != null) cnn.Close();
            }
            return sach;
        }
        private DataTable loadsachtheotheloai(string theloai)
        {
            string chuoi = "SELECT * FROM SACH WHERE TheLoai = @TheLoai";
            SqlCommand cmd = new SqlCommand(chuoi, cnn);
            DataTable sach = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TheLoai", theloai);
            try
            {
                cnn.Open();
                sach.Load(cmd.ExecuteReader());
            }
            catch (Exception exc)
            {
                MessageBox.Show("Loi khong thuc hien duoc: " + exc.Message);
            }
            finally
            {
                if (cnn != null) cnn.Close();
            }
            return sach;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (txtmasach.Text != null)
            {
                dtgthongtin.DataSource = loadsachtheoma(txtmasach.Text);
            }
            if (txttensach.Text != null)
            {
                dtgthongtin.DataSource = loadsachtheoten(txttensach.Text);
            }
            if (txtnhaxb.Text != null)
            {
                dtgthongtin.DataSource = loadsachtheonhaxuatban(txtnhaxb.Text);
            }
            if (txtnamxb.Text != null)
            {
                dtgthongtin.DataSource = loadsachtheonamxb(txtnamxb.Text);
            }
            if (txttheloaisach.Text != null)
            {
                dtgthongtin.DataSource = loadsachtheotheloai(txttheloaisach.Text);
            }
            if (txttinhtrang.Text != null)
            {
                dtgthongtin.DataSource = loadsachtheotinhtrang(txttinhtrang.Text);
            }
        }
        private DataTable loadsach()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADSACH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            DataTable sach = new DataTable();
            cnn.Open();
            sach.Load(cmd.ExecuteReader());
            cnn.Close();
            return sach;
        }
        private void loaddlsach()
        {
            dtgthongtin.DataSource = loadsach();
            lbltong.Text = (dtgthongtin.Rows.Count).ToString() + " sach";
        }
        private void lienket_dulieu()
        {
            txtmasach.DataBindings.Add("Text", dtgthongtin.DataSource, "MaSach");
            txttensach.DataBindings.Add("Text", dtgthongtin.DataSource, "TenSach");
            txtnhaxb.DataBindings.Add("Text", dtgthongtin.DataSource, "NhaXuatBan");
            txtnamxb.DataBindings.Add("Text", dtgthongtin.DataSource, "NamXuatBan");
            txttheloaisach.DataBindings.Add("Text", dtgthongtin.DataSource, "TheLoaiSach");
            txttinhtrang.DataBindings.Add("Text", dtgthongtin.DataSource, "TinhTrangSach");
            txtsoluong.DataBindings.Add("Text", dtgthongtin.DataSource, "SoLuongSach");
            picsach.DataBindings.Add("Text", dtgthongtin.DataSource, "Hinhanh", true);
        }
        private void huy_bindings()
        {
            if (txtmasach.DataBindings != null)
            {
                txtmasach.DataBindings.Clear();
            }
            if (txttensach.DataBindings != null)
            {
                txttensach.DataBindings.Clear();
            }
            if (txtnhaxb.DataBindings != null)
            {
                txtnhaxb.DataBindings.Clear();
            }
            if (txtnamxb.DataBindings != null)
            {
                txtnamxb.DataBindings.Clear();
            }
            if (txttheloaisach.DataBindings != null)
            {
                txttheloaisach.DataBindings.Clear();
            }
            if (txttinhtrang.DataBindings != null)
            {
                txttinhtrang.DataBindings.Clear();
            }
            if (txtsoluong.DataBindings != null)
            {
                txtsoluong.DataBindings.Clear();
            }
            if (picsach.DataBindings != null)
            {
                picsach.DataBindings.Clear();
            }
        }
        private void hienthitieudde()
        {
            dtgthongtin.Columns[0].HeaderText = "MaSach";
            dtgthongtin.Columns[1].HeaderText = "TenSach";
            dtgthongtin.Columns[2].HeaderText = "NhaXuatBan";
            dtgthongtin.Columns[3].HeaderText = "NamXuatBan";
            dtgthongtin.Columns[4].HeaderText = "TheLoaiSach";
            dtgthongtin.Columns[5].HeaderText = "TinhTrang";
            dtgthongtin.Columns[6].HeaderText = "SoLuong";
            dtgthongtin.Columns[7].HeaderText = "Hinh";
        }

        private void btnhinhsach_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image file(*.jpg)|*.jpg";
            string tenhinh = openFileDialog1.FileName;
            Bitmap anh = new Bitmap(tenhinh);
            picsach.SizeMode = PictureBoxSizeMode.StretchImage;
            picsach.Image = (Image)anh;
            picsach.Text = "Duong dan file anh: " + tenhinh;
            picsach.Text = tenhinh;
        }
    }
}
