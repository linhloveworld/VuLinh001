using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BTL_QLThuvien_Csharp_Nhom10
{
    public partial class frmthethuvien : Form
    {
        SqlConnection sqlconn;
        DataTable vtttv;
        int vt;
        public frmthethuvien()
        {
            InitializeComponent();
            sqlconn = new SqlConnection("DataSource = THINKPADE14;" +
                "Initial Catalog=. ;" + "Intergrated Security=True");
        }
        private string taomathe()
        {
            string mathe;
            Random ran = new Random();
            mathe = "TTV" + ran.Next(50, 999).ToString();
            return mathe;
        }
        private void lienket_dulieu()
        {
            txttensv.DataBindings.Add("Text", dtgttthethuvien.DataSource, "TenSinhVien");
            txtsdt.DataBindings.Add("Text", dtgttthethuvien.DataSource, "SoDienThoaiSinhVien");
            txtdiachisv.DataBindings.Add("Text", dtgttthethuvien.DataSource, "DiaChiSinhVien");
            txtma.DataBindings.Add("Text", dtgttthethuvien.DataSource, "MaTheThuVien");
        }
        private void huy_lienket()
        {
            if (dtpngaysinh.DataBindings != null)
            {
                dtpngaysinh.DataBindings.Clear();
            }
            if (txttensv.DataBindings != null)
            {
                txttensv.DataBindings.Clear();
            }
            if (cbogioitinh.DataBindings != null)
            {
                cbogioitinh.DataBindings.Clear();
            }
            if (txtdiachisv.DataBindings != null)
            {
                txtdiachisv.DataBindings.Clear();
            }
            if (txtsdt.DataBindings != null)
            {
                txtsdt.DataBindings.Clear();
            }
            if (dtpngaytao_thetv.DataBindings != null)
            {
                dtpngaytao_thetv.DataBindings.Clear();
            }
            if (dtpngayhethan_thetv.DataBindings != null)
            {
                dtpngayhethan_thetv.DataBindings.Clear();
            }
        }
        private void hienthitieudecot()
        {
            dtgttthethuvien.Columns[0].HeaderText = "MaTheThuVien";
            dtgttthethuvien.Columns[1].HeaderText = "TenSinhVien";
            dtgttthethuvien.Columns[2].HeaderText = "GioiTinh";
            dtgttthethuvien.Columns[3].HeaderText = "NgaySinh";
            dtgttthethuvien.Columns[4].HeaderText = "DiaChiSinhVien";
            dtgttthethuvien.Columns[5].HeaderText = "SoDienThoai";
            dtgttthethuvien.Columns[6].HeaderText = "Ngaylapthe";
            dtgttthethuvien.Columns[7].HeaderText = "Ngaythehethan";
        }
        private DataTable loadthetv()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADTHETHUVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlconn;
            DataTable thetv = new DataTable();
            sqlconn.Open();
            thetv.Load(cmd.ExecuteReader());
            sqlconn.Close();
            return thetv;
        }
        private void loaddlthetv()
        {
            dtgttthethuvien.DataSource = loadthetv();
            lbltong.ForeColor = Color.Orange;
            lbltong.Text = (dtgttthethuvien.Rows.Count).ToString();
        }
        private void hienthidldautien()
        {
            txtpage.Text = vt.ToString();
            vtttv = new DataTable();
            vtttv = loadthetv();
            DataRow row = vtttv.Rows[vt];
            txtma.Text = row[0].ToString();
            txttensv.Text = row[1].ToString();
            txtdiachisv.Text = row[2].ToString();
            txtsdt.Text = row[3].ToString();
            cbogioitinh.Text = row[4].ToString();
            dtpngaysinh.Text = row[5].ToString();
            dtpngaytao_thetv.Text = row[6].ToString();
            dtpngayhethan_thetv.Text = row[7].ToString();
            txtpage.Text = (1 + vt).ToString() +
                "/" + vtttv.Rows.Count.ToString();
        }

        private void frmthethuvien_Load(object sender, EventArgs e)
        {
            txtma.Enabled = true;
            loaddlthetv();
            hienthitieudecot();
            hienthidldautien();
            lienket_dulieu();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtma.Clear();
            txttensv.Clear();
            txtdiachisv.Clear();
            txtsdt.Clear();
            txtma.Text = taomathe();
        }
        private void luuthethuvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUTHETHUVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlconn;
            string mathe, tensv, diachi, sdt;
            DateTime ngaysinh, ngaylapthe, ngaythehethan;
            bool gioitinh;
            if (txtma.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Ma the khong duoc de trong";
                txtma.Focus();
                return;
            }
            if (txttensv.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Ten sinh vien khong duoc de trong";
                txttensv.Focus();
                return;
            }
            if (txtdiachisv.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Dia chi khong duoc de trong";
                txtdiachisv.Focus();
                return;
            }
            if (DateTime.Now.Year - dtpngaysinh.Value.Year < 18 ||
                DateTime.Now.Year - dtpngaysinh.Value.Year > 30)
            {
                lblthongbao.Text = "Sinh vien la nguoi du tuoi 18 den 30";
                lblthongbao.ForeColor = Color.Orange;
                dtpngaysinh.Focus();
                return;
            }
            mathe = txtma.Text;
            tensv = txttensv.Text;
            diachi = txtdiachisv.Text;
            sdt = txtsdt.Text;
            if (cbogioitinh.Text == "Nam")
            {
                gioitinh = true;
            }
            else
            {
                gioitinh = false;
            }
            ngaysinh = DateTime.Parse(dtpngaysinh.ToString());
            ngaylapthe = DateTime.Parse(dtpngaytao_thetv.ToString());
            ngaythehethan = DateTime.Parse(dtpngayhethan_thetv.ToString());
            cmd.Parameters.Add("@MaTheThuVien", mathe);
            cmd.Parameters.Add("@TenSinhVien", tensv);
            cmd.Parameters.Add("@GioiTinh", gioitinh);
            cmd.Parameters.Add("@DiaChiSV", diachi);
            cmd.Parameters.Add("@SoDienThoaiSV", sdt);
            cmd.Parameters.Add("@NgaySinh",ngaysinh);
            cmd.Parameters.Add("@NgayTaoThe",ngaylapthe);
            cmd.Parameters.Add("@NgayTheHetHan",ngaythehethan);
            try
            {
                cmd.Parameters.Add("@kq", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                sqlconn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Ma the bi trung";
                    return;
                }
                else
                {
                    lblthongbao.ForeColor = Color.Green;
                    lblthongbao.Text = "Luu thanh cong";
                    return;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Khong thuc hien duoc vi " + ex.Message);
            }
            finally
            {
                if (sqlconn != null)
                    sqlconn.Close();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            huy_lienket();
            luuthethuvien();
            loaddlthetv();
            lienket_dulieu();
        }
        private void suathethuvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUATHETHUVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlconn;
            string mathe, tensv, diachi, sdt;
            DateTime ngaysinh, ngaylapthe, ngaythehethan;
            bool gioitinh;
            if (txtma.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Ma the khong duoc de trong";
                txtma.Focus();
                return;
            }
            if (txttensv.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Ten sinh vien khong duoc de trong";
                txttensv.Focus();
                return;
            }
            if (txtdiachisv.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Dia chi khong duoc de trong";
                txtdiachisv.Focus();
                return;
            }
            if (DateTime.Now.Year - dtpngaysinh.Value.Year < 18 ||
                DateTime.Now.Year - dtpngaysinh.Value.Year > 30)
            {
                lblthongbao.Text = "Sinh vien la nguoi du tuoi 18 den 30";
                lblthongbao.ForeColor = Color.Orange;
                dtpngaysinh.Focus();
                return;
            }
            mathe = txtma.Text;
            tensv = txttensv.Text;
            diachi = txtdiachisv.Text;
            sdt = txtsdt.Text;
            if (cbogioitinh.Text == "Nam")
            {
                gioitinh = true;
            }
            else
            {
                gioitinh = false;
            }
            ngaysinh = DateTime.Parse(dtpngaysinh.ToString());
            ngaylapthe = DateTime.Parse(dtpngaytao_thetv.ToString());
            ngaythehethan = DateTime.Parse(dtpngayhethan_thetv.ToString());
            cmd.Parameters.Add("@MaTheThuVien", mathe);
            cmd.Parameters.Add("@TenSinhVien", tensv);
            cmd.Parameters.Add("@GioiTinh", gioitinh);
            cmd.Parameters.Add("@DiaChiSV", diachi);
            cmd.Parameters.Add("@SoDienThoaiSV", sdt);
            cmd.Parameters.Add("@NgaySinh", ngaysinh);
            cmd.Parameters.Add("@NgayTaoThe", ngaylapthe);
            cmd.Parameters.Add("@NgayTheHetHan", ngaythehethan);
            try
            {
                cmd.Parameters.Add("@kq", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                sqlconn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Khong ton tai ma the thu vien";
                    return;
                }
                else
                {
                    lblthongbao.ForeColor = Color.Green;
                    lblthongbao.Text = "Luu thanh cong";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong thuc hien duoc vi " + ex.Message);
            }
            finally
            {
                if (sqlconn != null)
                    sqlconn.Close();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            huy_lienket();
            suathethuvien();
            loaddlthetv();
            lienket_dulieu();
        }
        private void xoathethuvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_XOATHETHUVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlconn;
            string mathethuvien;
            mathethuvien = txtma.Text;
            cmd.Parameters.Add("@MaTheThuVien", mathethuvien);
            DialogResult noti;
            noti = MessageBox.Show("Ban dang xoa?", "Thong bao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (noti == DialogResult.Yes)
            {
                sqlconn.Open();
                cmd.ExecuteNonQuery();
                sqlconn.Close();
            }
            try
            {
                cmd.Parameters.Add("@kq", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                sqlconn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "đã tồn tại TheThuViện trong phieu muon";
                    return;
                }else if (kq == 2)
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "đã tồn tại TheThuViện trong phieu nhac tra";
                    return;
                }
                else
                {
                    lblthongbao.ForeColor = Color.Green;
                    lblthongbao.Text = "Xoa thanh cong";
                }
            }catch(Exception excp)
            {
                MessageBox.Show("Loi khong the thuc hien duoc vi " +
                    excp.Message);
            }
            finally
            {
                if (sqlconn != null)
                    sqlconn.Close();
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            huy_lienket();
            xoathethuvien();
            loaddlthetv();
            lienket_dulieu();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Ban dang thoat ra ngoai?", "Chu y",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.Close();
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<45 || e.KeyChar>57)&&e.KeyChar!=8 && e.KeyChar!=45
                && e.KeyChar != 46)
            {
                e.Handled = true;
                lblthongbao.Text = "Khong duoc nhap chu cai";
            }
        }
        private void txtma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 45 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 45
                 && e.KeyChar != 46)
            {
                e.Handled = true;
                lblthongbao.Text = "Khong duoc nhap chu cai";
            }
        }

        private void txttensv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar>45 && e.KeyChar < 57)
            {
                e.Handled = true;
                lblthongbao.Text = "Khong duoc nhap chu so";
            }
        }

        private void btndau_Click(object sender, EventArgs e)
        {
            if (vt > 0)
            {
                vt = 0;
                DataRow row = vtttv.Rows[vt];
                txtma.Text = row[0].ToString();
                txttensv.Text = row[1].ToString();
                cbogioitinh.Text = row[2].ToString();
                dtpngaysinh.Text = row[3].ToString();
                txtsdt.Text = row[4].ToString();
                txtdiachisv.Text = row[5].ToString();
                dtpngaytao_thetv.Text = row[6].ToString();
                dtpngayhethan_thetv.Text = row[7].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" +
                    vtttv.Rows.Count.ToString();
                btndau.Enabled = true;
            }
            else btndau.Enabled = false;
        }

        private void btnlui_Click(object sender, EventArgs e)
        {
            if (vt > 0)
            {
                vt--;
                DataRow row = vtttv.Rows[vt];
                txtma.Text = row[0].ToString();
                txttensv.Text = row[1].ToString();
                cbogioitinh.Text = row[2].ToString();
                dtpngaysinh.Text = row[3].ToString();
                txtsdt.Text = row[4].ToString();
                txtdiachisv.Text = row[5].ToString();
                dtpngaytao_thetv.Text = row[6].ToString();
                dtpngayhethan_thetv.Text = row[7].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" +
                    vtttv.Rows.Count.ToString();
                btnlui.Enabled = true;
            }
            else btnlui.Enabled = false;
        }

        private void btntien_Click(object sender, EventArgs e)
        {
            if (vt < vtttv.Rows.Count - 1)
            {
                vt++;
                DataRow row = vtttv.Rows[vt];
                txtma.Text = row[0].ToString();
                txttensv.Text = row[1].ToString();
                cbogioitinh.Text = row[2].ToString();
                dtpngaysinh.Text = row[3].ToString();
                txtsdt.Text = row[4].ToString();
                txtdiachisv.Text = row[5].ToString();
                dtpngaytao_thetv.Text = row[6].ToString();
                dtpngayhethan_thetv.Text = row[7].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" +
                    vtttv.Rows.Count.ToString();
                btntien.Enabled = true;
            }
            else btntien.Enabled = false;
        }

        private void btncuoi_Click(object sender, EventArgs e)
        {
            if (vt < vtttv.Rows.Count - 1)
            {
                vt = vtttv.Rows.Count - 1;
                DataRow row = vtttv.Rows[vt];
                txtma.Text = row[0].ToString();
                txttensv.Text = row[1].ToString();
                cbogioitinh.Text = row[2].ToString();
                dtpngaysinh.Text = row[3].ToString();
                txtsdt.Text = row[4].ToString();
                txtdiachisv.Text = row[5].ToString();
                dtpngaytao_thetv.Text = row[6].ToString();
                dtpngayhethan_thetv.Text = row[7].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" +
                    vtttv.Rows.Count.ToString();
                btncuoi.Enabled = true;
            }
            else btncuoi.Enabled = false;
        }
    }
}
