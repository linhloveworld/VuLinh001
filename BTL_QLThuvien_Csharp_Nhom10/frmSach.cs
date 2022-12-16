using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BTL_QLThuvien_Csharp_Nhom10
{
    public partial class frmSach : Form
    {
        DataTable vtsach;
        OpenFileDialog file;
        //string A;
        byte[] anh;
        int vt;
        SqlConnection conn;
        public frmSach()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=THINKPADE14;Initial Catalog=BTL_NET1_QLThuVienDataSet");
            vtsach = new DataTable();
            vtsach = loadsach();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            txtmasach.Enabled = false;
            loaddlsach();
            hienthisachdautien();
            hienthitieudecot();
            lienket_dulieu();
        }
        private DataTable loadsach()
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "sp_LOADSACH";
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Connection = conn;
            DataTable sach = new DataTable();
            conn.Open();
            sach.Load(sqlcmd.ExecuteReader());
            conn.Close();
            return sach;
        }
        private void loaddlsach()
        {
            dtgsach.DataSource = loadsach();
            lbltong.ForeColor = Color.Red;
            lbltong.Text = (dtgsach.Rows.Count).ToString();
        }
        private void lienket_dulieu()
        {
            txtmasach.DataBindings.Add("Text", dtgsach.DataSource, "MaSach");
            txttensach.DataBindings.Add("Text", dtgsach.DataSource, "TenSach");
            txttheloaisach.DataBindings.Add("Text", dtgsach.DataSource, "TheLoaiSach");
            txttinhtrang.DataBindings.Add("Text", dtgsach.DataSource, "TinhTrangSach");
            txtsoluong.DataBindings.Add("Text", dtgsach.DataSource, "SoLuongSach");
            txtnhaxb.DataBindings.Add("Text", dtgsach.DataSource, "NhaXuatBan");
            txtnamxb.DataBindings.Add("Text", dtgsach.DataSource, "NamXuatBan");
            txttg.DataBindings.Add("Text", dtgsach.DataSource, "Tg");
            pichinh.DataBindings.Add("Image", dtgsach.DataSource, "Hinh", true);
        }
        private void huy_lienket()
        {
            if (txtmasach.DataBindings != null)
                txtmasach.DataBindings.Clear();
            if (txttensach.DataBindings != null)
                txttensach.DataBindings.Clear();
            if (txttheloaisach.DataBindings != null)
                txttheloaisach.DataBindings.Clear();
            if (txttinhtrang.DataBindings != null)
                txttinhtrang.DataBindings.Clear();
            if (txtsoluong.DataBindings != null)
                txtsoluong.DataBindings.Clear();
            if (txtnhaxb.DataBindings != null)
                txtnhaxb.DataBindings.Clear();
            if (txtnamxb.DataBindings != null)
                txtnamxb.DataBindings.Clear();
            if (txttg.DataBindings != null)
                txttg.DataBindings.Clear();
            if (pichinh.DataBindings != null)
                pichinh.DataBindings.Clear();
        }
        private void hienthitieudecot()
        {
            dtgsach.Columns[0].HeaderText = "Ma sach";
            dtgsach.Columns[1].HeaderText = "Ten Sach";
            dtgsach.Columns[2].HeaderText = "The loai sach";
            dtgsach.Columns[3].HeaderText = "Tinh trang";
            dtgsach.Columns[4].HeaderText = "So Luong";
            dtgsach.Columns[5].HeaderText = "Nha Xuat ban";
            dtgsach.Columns[6].HeaderText = "Nam xuat ban";
            dtgsach.Columns[7].HeaderText = "Ma tg";
            dtgsach.Columns[8].HeaderText = "Hinh anh";
        }
        private string taomasach()
        {
            string masach;
            Random rd = new Random();
            masach = "MS" + rd.Next(0, 999).ToString();
            return masach;
        }

        private void btnthemsach_Click(object sender, EventArgs e)
        {
            txtmasach.Clear();
            txttensach.Clear();
            txttheloaisach.Clear();
            txttinhtrang.Clear();
            txtsoluong.Clear();
            txtnhaxb.Clear();
            txtnamxb.Clear();
            txttg.Clear();
            txtmasach.Text = taomasach();
        }
        private void luusach()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUSACH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            string masach, ten, theloai, tinhtrang, nhaxb, namxb, tg, fileanh;
            int soluong;
            if (txttensach.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Tên không được trống";
                txttensach.Focus();
                return;
            }
            if (txtnamxb.TextLength > 4)
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "sai định dạng năm";
                txtnamxb.Focus();
                return;
            }
            if (txttg.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Tg không được trống";
                txttg.Focus();
                return;
            }
            if (txtnhaxb.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "nha xuat ban không được trống";
                txtnhaxb.Focus();
                return;
            }
            fileanh = openFileDialog1.FileName;
            anh = File.ReadAllBytes(fileanh);
            masach = txtmasach.Text;
            ten = txttensach.Text;
            theloai = txttheloaisach.Text;
            soluong = int.Parse(txtsoluong.Text);
            tinhtrang = txttinhtrang.Text;
            nhaxb = txtnhaxb.Text;
            namxb = txtnamxb.Text;
            tg = txttg.Text;
            cmd.Parameters.Add("@MaSach", masach);
            cmd.Parameters.Add("@TenSach", ten);
            cmd.Parameters.Add("@TheLoaiSach", theloai);
            cmd.Parameters.Add("@SoLuongSach", soluong);
            cmd.Parameters.Add("@TinhTrangSach", tinhtrang);
            cmd.Parameters.Add("@NhaXuatBan", nhaxb);
            cmd.Parameters.Add("@NamXuatBan", namxb);
            cmd.Parameters.Add("@Tg", tg);
            cmd.Parameters.Add("@Hinh", anh);
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
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "đã tồn tại sách";
                    return;
                }
                else
                {
                    lblthongbao.ForeColor = Color.Green;
                    lblthongbao.Text = "Lưu Thành Công";
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

        private void btnluusach_Click(object sender, EventArgs e)
        {
            huy_lienket();
            luusach();
            loaddlsach();
            lienket_dulieu();
        }
        private void xoasach()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_XOASACH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            string masach;
            masach = txtmasach.Text;
            cmd.Parameters.Add("@MaSach", masach);
            DialogResult kq1;
            kq1 = MessageBox.Show("Bạn Thật Sự Muốn Xóa", "Chú Ý",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq1 == DialogResult.Yes)
            {
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
                        lblthongbao.ForeColor = Color.Red;
                        lblthongbao.Text = "Đã tồn tại sách trong PMuon";
                        return;
                    }
                    else if (kq == 2)
                    {
                        lblthongbao.ForeColor = Color.Red;
                        lblthongbao.Text = "Đã tồn tại sách trong PNhắcTrả";
                        return;
                    }
                    else if (kq == 3)
                    {
                        lblthongbao.ForeColor = Color.Red;
                        lblthongbao.Text = "Đã tồn tại sách trong Sách Mượn";
                        return;
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
            lblthongbao.ForeColor = Color.Green;
            lblthongbao.Text = "Xóa Thành Công";
        }

        private void btnxoasach_Click(object sender, EventArgs e)
        {
            huy_lienket();
            xoasach();
            loaddlsach();
            lienket_dulieu();
        }
        private void suasach()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUASACH";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            string masach, ten, theloai, tinhtrang, nxb, namxb, tg, filehinh;
            int soluong;
            if (txttensach.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Tên không được trống";
                txttensach.Focus();
                return;
            }
            if (txttg.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Tg không được trống";
                txttg.Focus();
                return;
            }
            if (txtnamxb.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "nha xuat ban không được trống";
                txtnamxb.Focus();
                return;
            }
            masach = txtmasach.Text;
            ten = txttensach.Text;
            theloai = txttheloaisach.Text;
            soluong = int.Parse(txtsoluong.Text);
            tinhtrang = txttinhtrang.Text;
            nxb = txtnhaxb.Text;
            namxb = txtnamxb.Text;
            tg = txttg.Text;
            filehinh = openFileDialog1.FileName;
            try
            {
                anh = File.ReadAllBytes(filehinh);
            }
            catch (Exception)
            {
                anh = null;
            }
            cmd.Parameters.Add("@MaSach", masach);
            cmd.Parameters.Add("@TenSach", ten);
            cmd.Parameters.Add("@TheLoaiSach", theloai);
            cmd.Parameters.Add("@SoLuongSach", soluong);
            cmd.Parameters.Add("@TinhTrangSach", tinhtrang);
            cmd.Parameters.Add("@NhaXuatBan", nxb);
            cmd.Parameters.Add("@NamXuatBan", namxb);
            cmd.Parameters.Add("@TG", tg);
            cmd.Parameters.Add("@HINH", anh);
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
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Mã không tồn tại";
                    return;
                }
                else
                {
                    lblthongbao.ForeColor = Color.Green;
                    lblthongbao.Text = "Sửa Thành Công";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi kg sửa duoc vi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void btnsuasach_Click(object sender, EventArgs e)
        {
            huy_lienket();
            suasach();
            loaddlsach();
            lienket_dulieu();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnhinh_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image file(*.jpg)|*.jpg";//loai hinh anh
            pichinh.ImageLocation = openFileDialog1.FileName;//duong dan open
        }
        private void hienthisachdautien()
        {
            txtpage.Text = vt.ToString();
            vtsach = new DataTable();
            vtsach = loadsach();
            DataRow r = vtsach.Rows[vt];
            txtmasach.Text = r[0].ToString();
            txttensach.Text = r[1].ToString();
            txttheloaisach.Text = r[2].ToString();
            txttinhtrang.Text = r[3].ToString();
            txtsoluong.Text = r[4].ToString();
            txtnhaxb.Text = r[5].ToString();
            txtnamxb.Text = r[6].ToString();
            txttg.Text = r[7].ToString();
            txtpage.Text = (1 + vt).ToString() + "/" + vtsach.Rows.Count.ToString();
        }

        private void btndau_Click(object sender, EventArgs e)
        {
            if (vt > 0)
            {
                vt = 0;
                DataRow r = vtsach.Rows[vt];
                txtmasach.Text = r[0].ToString();
                txttensach.Text = r[1].ToString();
                txttheloaisach.Text = r[2].ToString();
                txttinhtrang.Text = r[3].ToString();
                txtsoluong.Text = r[4].ToString();
                txtnhaxb.Text = r[5].ToString();
                txtnamxb.Text = r[6].ToString();
                txttg.Text = r[7].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" + vtsach.Rows.Count.ToString();
                btncuoi.Enabled = true;
            }
            else btndau.Enabled = false;
        }

        private void btnlui_Click(object sender, EventArgs e)
        {
            if (vt > 0)
            {
                vt--;
                DataRow r = vtsach.Rows[vt];
                txtmasach.Text = r[0].ToString();
                txttensach.Text = r[1].ToString();
                txttheloaisach.Text = r[2].ToString();
                txttinhtrang.Text = r[3].ToString();
                txtsoluong.Text = r[4].ToString();
                txtnhaxb.Text = r[5].ToString();
                txtnamxb.Text = r[6].ToString();
                txttg.Text = r[7].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" + vtsach.Rows.Count.ToString();
                btntien.Enabled = true;
            }
            else btnlui.Enabled = false;
        }

        private void btntien_Click(object sender, EventArgs e)
        {
            if (vt < vtsach.Rows.Count - 1)
            {
                vt++;
                DataRow r = vtsach.Rows[vt];
                txtmasach.Text = r[0].ToString();
                txttensach.Text = r[1].ToString();
                txttheloaisach.Text = r[2].ToString();
                txttinhtrang.Text = r[3].ToString();
                txtsoluong.Text = r[4].ToString();
                txtnhaxb.Text = r[5].ToString();
                txtnamxb.Text = r[6].ToString();
                txttg.Text = r[7].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" + vtsach.Rows.Count.ToString();
                btnlui.Enabled = true;
            }
            else btntien.Enabled = false;
        }

        private void btncuoi_Click(object sender, EventArgs e)
        {
            if (vt < vtsach.Rows.Count - 1)
            {
                vt = vtsach.Rows.Count - 1;
                DataRow r = vtsach.Rows[vt];
                txtmasach.Text = r[0].ToString();
                txttensach.Text = r[1].ToString();
                txttheloaisach.Text = r[2].ToString();
                txttinhtrang.Text = r[3].ToString();
                txtsoluong.Text = r[4].ToString();
                txtnhaxb.Text = r[5].ToString();
                txtnamxb.Text = r[6].ToString();
                txttg.Text = r[7].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" + vtsach.Rows.Count.ToString();
                btndau.Enabled = true;
            }
            else btncuoi.Enabled = false;
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 45 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46)
            {
                e.Handled = true;
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Không được nhập chữ";
            }
        }

        private void txtnamxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 45 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46)
            {
                e.Handled = true;
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Không được nhập chữ";
            }
        }

        private void btntimkiemttv_Click(object sender, EventArgs e)
        {
            string masach;
            bool kq = false;
            for (int i = 0; i < vtsach.Rows.Count; i++)
            {
                DataRow r = vtsach.Rows[i];
                masach = r[0].ToString();
                if (masach.ToUpper() == txttimkiemma.Text.ToUpper())
                {
                    txtmasach.Text = r[0].ToString();
                    txttensach.Text = r[1].ToString();
                    txttheloaisach.Text = r[2].ToString();
                    txttinhtrang.Text = r[3].ToString();
                    txtsoluong.Text = r[4].ToString();
                    txtnhaxb.Text = r[5].ToString();
                    txtnamxb.Text = r[6].ToString();
                    txttg.Text = r[7].ToString();
                    pichinh.ImageLocation = r[8].ToString();
                    kq = true;
                    return;
                }
            }
            if (kq == false)
            {
                MessageBox.Show("Sách nay khong ton tai");
                txttimkiemma.SelectAll();
                txttimkiemma.Focus();
            }
        }
    }
}
