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

namespace BTL_QLThuvien_Csharp_Nhom10
{
    public partial class frmSachmuon : Form
    {
        int vt;
        SqlConnection conn;
        DataTable dtpm;
        public frmSachmuon()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=THINKPADE14;Initial Catalog=BTL_NET1_QLThuVienDataSet");
        }
        private DataTable loadphieumuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADPHIEUMUON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            DataTable pm = new DataTable();
            conn.Open();
            pm.Load(cmd.ExecuteReader());
            conn.Close();
            return pm;
        }
        private void loaddlphieumuon()
        {
            cbomapm.DataSource = loadphieumuon();
            cbomapm.ValueMember = "MaPhieuMuon";
            cbomapm.DisplayMember = "TenPhieuMuon";
        }
        private DataTable loadsachmuon()
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "sp_LOADSACHMUON";
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Connection = conn;
            DataTable sachmuon = new DataTable();
            conn.Open();
            sachmuon.Load(sqlcmd.ExecuteReader());
            conn.Close();
            return sachmuon;
        }
        private void loaddlsachmuon()
        {
            cbomasach.DataSource = loadsachmuon();
            cbomasach.ValueMember = "MaSach";
            cbomasach.DisplayMember = "TenSach";
        }
        private void lienket_dulieu()
        {
            txtsoluongsm.DataBindings.Add("Text", dtgsachmuon.DataSource, "So luong sach muon");
            txttinhtrang.DataBindings.Add("Text", dtgsachmuon.DataSource, "Tinh trang sach muon");
        }
        private void huy_lienket()
        {
            if(cbomapm.DataBindings != null)
            {
                cbomapm.DataBindings.Clear();
            }
            if(cbomasach.DataBindings != null)
            {
                cbomasach.DataBindings.Clear();
            }
            if (txttinhtrang.DataBindings != null)
            {
               txttinhtrang.DataBindings.Clear();
            }
            if (txtsoluongsm.DataBindings != null)
            {
                txtsoluongsm.DataBindings.Clear();
            }
            if (dtpngaytra.DataBindings != null)
            {
                dtpngaytra.DataBindings.Clear();
            }
        }
        private void hienthitieudecot()
        {
            dtgsachmuon.Columns[0].HeaderText = "Ma phieu muon";
            dtgsachmuon.Columns[1].HeaderText = "Ma sach muon";
            dtgsachmuon.Columns[2].HeaderText = "Tinh trang";
            dtgsachmuon.Columns[3].HeaderText = "So luong muon";
            dtgsachmuon.Columns[4].HeaderText = "Ngay tra";
        }

        private void frmSachmuon_Load(object sender, EventArgs e)
        {
            loaddlsachmuon();
            loaddlphieumuon();
            hienthitieudecot();
            lienket_dulieu();
            hienthimaphieudautien();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            huy_lienket();
            txtsoluongsm.Clear();
            txttinhtrang.Clear();
            lienket_dulieu();
        }
        private void luusachmuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUSACHMUON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            string mapm, masach, tinhtrang;
            int soluongsachmuon;
            DateTime ngaytra;
            mapm = cbomapm.SelectedIndex.ToString();
            masach = cbomasach.SelectedIndex.ToString();
            tinhtrang = txttinhtrang.Text;
            soluongsachmuon = int.Parse(txtsoluongsm.Text);
            if(soluongsachmuon<1 || soluongsachmuon > 3)
            {
                lblthongbao.ForeColor = Color.Orange;
                lblthongbao.Text = "Chi co the muon toi da 3 va toi thieu 1";
                txtsoluongsm.Focus();
                return;
            }
            if (cbomapm.Text == "")
            {
                lblthongbao.Text = "Can chon ma phieu muon";
                lblthongbao.ForeColor = Color.Red;
                cbomapm.Focus();
                return;
            }
            if (cbomasach.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Can chon ma sach";
                cbomasach.Focus();
                return;
            }
            ngaytra = DateTime.Parse(dtpngaytra.Value.ToString());
            cmd.Parameters.Add("@MaPieuMuon", mapm);
            cmd.Parameters.Add("@MaSachMuon", masach);
            cmd.Parameters.Add("@SoLuongSachMuon", soluongsachmuon);
            cmd.Parameters.Add("@TinhTrangSachMuon", tinhtrang);
            cmd.Parameters.Add("@NgayTra", ngaytra);
            try
            {
                cmd.Parameters.Add("@kq", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                conn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Da ton tai sach";
                    return;
                }
                else if (kq ==2)
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Khong ton tai ma phieu muon";
                    return;
                }
                else
                {
                    lblthongbao.ForeColor = Color.Green;
                    lblthongbao.Text = "Luu thanh cong";
                }
            }catch (Exception exp)
            {
                MessageBox.Show("Loi khong luu duoc vi " + exp.Message);

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            huy_lienket();
            luusachmuon();
            loaddlsachmuon();
            loaddlphieumuon();
            lienket_dulieu();
        }
        private void xoasachmuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_XOASACHMUON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            string mapm, masach, tinhtrang;
            int slsm;
            DateTime ngaytra;
            mapm = cbomapm.SelectedIndex.ToString();
            masach = cbomasach.SelectedIndex.ToString();
            cmd.Parameters.Add("MaPhieuMuon", mapm);
            cmd.Parameters.Add("MaSachMuon", masach);
            DialogResult dialog;
            dialog = MessageBox.Show("Ban thuc su muon xoa", "Thong bao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    cmd.Parameters.Add("@kq", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    int kq = (int)cmd.Parameters["@kq"].Value;
                    if (kq == 1)
                    {
                        lblthongbao.ForeColor = Color.Red;
                        lblthongbao.Text = "Khong ton tai phieu muon";
                        return;
                    }
                    else if (kq == 2)
                    {
                        lblthongbao.ForeColor = Color.Red;
                        lblthongbao.Text = "ma sach khong ton tai";
                    }
                    else
                    {
                        lblthongbao.ForeColor = Color.Green;
                        lblthongbao.Text = "Xoa thanh cong";
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Loi khong xoa duoc vi " + exc.Message);
                }
                finally
                {
                    if (conn != null)
                        conn.Close();
                }
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            huy_lienket();
            xoasachmuon();
            loaddlsachmuon();
            loaddlphieumuon();
            lienket_dulieu();
        }
        private void suasachmuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUASACHMUON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            string mapm, masm, tinhtrang;
            int slsachmuon;
            DateTime ngaytra;
            mapm = cbomapm.SelectedIndex.ToString();
            masm = cbomasach.SelectedIndex.ToString();
            tinhtrang = txttinhtrang.Text;
            slsachmuon = int.Parse(txtsoluongsm.Text);
            ngaytra = DateTime.Parse(dtpngaytra.Value.ToString());
            if (slsachmuon < 1 || slsachmuon > 3)
            {
                lblthongbao.ForeColor = Color.Orange;
                lblthongbao.Text = "Chi co the muon toi da 3 va toi thieu 1";
                txtsoluongsm.Focus();
                return;
            }
            if (cbomapm.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Can chon ma phieu muon";
                cbomapm.Focus();
                return;
            }
            if(cbomasach.Text == "")
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Can chon ma sach";
                cbomasach.Focus();
                return;
            }
            cmd.Parameters.Add("MaPhieuMuon", mapm);
            cmd.Parameters.Add("@MaSachMuon", masm);
            cmd.Parameters.Add("@SoLuongSachMuon", slsachmuon);
            cmd.Parameters.Add("@TinhTrangSachMuon", tinhtrang);
            cmd.Parameters.Add("@NgayTra", ngaytra);
            try
            {
                cmd.Parameters.Add("@kq", SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                conn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Ma sach da ton tai";
                    return;
                }else if (kq == 2)
                {
                    lblthongbao.ForeColor = Color.Red;
                    lblthongbao.Text = "Da ton tai phieu muon";
                    return;
                }
                else
                {
                    lblthongbao.ForeColor = Color.Green;
                    lblthongbao.Text = "Sua thanh cong";
                }
            }catch(Exception excp)
            {
                MessageBox.Show("Loi khong thuc hien duoc vi " + excp.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            huy_lienket();
            suasachmuon();
            loaddlsachmuon();
            loaddlphieumuon();
            lienket_dulieu();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Ban thuc su muon thoat?", "Thong bao", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void txtsoluongsm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<45||e.KeyChar>57)&&
                e.KeyChar!=8 && e.KeyChar != 46)
            {
                e.Handled = true;
                lblthongbao.ForeColor = Color.OrangeRed;
                lblthongbao.Text = "Khong nhap bang chu cai";
            }
        }
        private void hienthimaphieudautien()
        {
            txtpage.Text = vt.ToString();
            dtpm = new DataTable();
            dtpm = loadphieumuon();
            DataRow row = dtpm.Rows[vt];
            cbomapm.SelectedValue = row[0].ToString();
            cbomasach.SelectedValue = row[1].ToString();
            txtsoluongsm.Text = row[2].ToString();
            txttinhtrang.Text = row[3].ToString();
            dtpngaytra.Text = row[4].ToString();
            txtpage.Text = (1 + vt).ToString() + "/" + dtpm.Rows.Count.ToString();
        }
        private void btndau_Click(object sender, EventArgs e)
        {
            if (vt > 0)
            {
                vt = 0;
                DataRow row = dtpm.Rows[vt];
                cbomapm.SelectedValue = row[0].ToString();
                cbomasach.SelectedValue = row[1].ToString();
                txtsoluongsm.Text = row[2].ToString();
                txttinhtrang.Text = row[3].ToString();
                dtpngaytra.Text = row[4].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" + dtpm.Rows.Count.ToString();
                btndau.Enabled = true;
            }
            else
            {
                btndau.Enabled = false;
            }

        }
        private void btnlui_Click(object sender, EventArgs e)
        {
            if (vt > 0)
            {
                vt--;
                DataRow row = dtpm.Rows[vt];
                cbomapm.SelectedValue = row[0].ToString();
                cbomasach.SelectedValue = row[1].ToString();
                txtsoluongsm.Text = row[2].ToString();
                txttinhtrang.Text = row[3].ToString();
                dtpngaytra.Text = row[4].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" + dtpm.Rows.Count.ToString();
                btnlui.Enabled = true;
            }
            else
            {
                btnlui.Enabled = false;
            }
        }

        private void btntien_Click(object sender, EventArgs e)
        {
            if(vt > dtpm.Rows.Count - 1)
            {
                vt++;
                DataRow row = dtpm.Rows[vt];
                cbomapm.SelectedValue = row[0].ToString();
                cbomasach.SelectedValue = row[1].ToString();
                txtsoluongsm.Text = row[2].ToString();
                txttinhtrang.Text = row[3].ToString();
                dtpngaytra.Text = row[4].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" + dtpm.Rows.Count.ToString();
                btntien.Enabled = true;
            }
            else
            {
                btntien.Enabled = false;
            }
        }

        private void btncuoi_Click(object sender, EventArgs e)
        {
            if (vt < dtpm.Rows.Count + 1)
            {
                vt = dtpm.Rows.Count - 1;
                DataRow row = dtpm.Rows[vt];
                cbomapm.SelectedValue = row[0].ToString();
                cbomasach.SelectedValue = row[1].ToString();
                txtsoluongsm.Text = row[2].ToString();
                txttinhtrang.Text = row[3].ToString();
                dtpngaytra.Text = row[4].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" + dtpm.Rows.Count.ToString();
                btncuoi.Enabled = true;
            }
            else
            {
                btncuoi.Enabled = false;
            }
        }
    }
}
