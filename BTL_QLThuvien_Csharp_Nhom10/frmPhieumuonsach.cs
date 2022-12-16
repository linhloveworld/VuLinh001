using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BTL_QLThuvien_Csharp_Nhom10
{
    public partial class frmPhieumuonsach : Form
    {
        string A;
        DataTable dtpm;
        int vt;
        SqlConnection con;
        public frmPhieumuonsach()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=THINKPADE14;Initial Catalog=BTL_NET1_QLThuVienDataSet");
        }

        private void frmPhieumuonsach_Load(object sender, EventArgs e)
        {
            txtmapm.Enabled = false;
            loaddlphieumuon();
            hienthitieudecot();
            loaddlsach();
            loaddlthethuvien();
            A = lbl19.Text;
            lbl19.Text = "";
            //timer1.Start();
            data_binding();
            hienthiphieudautien();
        }
        #region hien ma phieu muon
        private string taomapm()
        {
            string mapm;
            Random ran = new Random();
            mapm = "PM" + ran.Next(10, 999).ToString();
            return mapm;
        }
        #endregion
        private void data_binding()
        {
            txtmapm.DataBindings.Add("Text", dgvttpm.DataSource, "MaPM");
            cbomathe.DataBindings.Add("SelectedValue", dgvttpm.DataSource, "MaThe");
            cbomasach.DataBindings.Add("SelectedValue", dgvttpm.DataSource, "MaSach");
        }
        private void huy_binding()
        {
            if (txtmapm.DataBindings != null)
            {
                txtmapm.DataBindings.Clear();
            }
            if (cbomathe.DataBindings != null)
            {
                cbomathe.DataBindings.Clear();
            }
            if (cbomasach.DataBindings != null)
            {
                cbomasach.DataBindings.Clear();
            }
            if (dtpngaymuon.DataBindings != null)
            {
                dtpngaymuon.DataBindings.Clear();
            }
        }
        #region hien thi tieu cot
        private void hienthitieudecot()
        {
            dgvttpm.Columns[0].HeaderText = "Ma Phieu muon";
            dgvttpm.Columns[1].HeaderText = "Ma Sach";
            dgvttpm.Columns[2].HeaderText = "Ma the";
            dgvttpm.Columns[3].HeaderText = "Ngay muon sach";
        }
        #endregion
        private DataTable loadsach()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LOADSACH";
            cmd.Connection = con;
            DataTable sach = new DataTable();
            con.Open();
            sach.Load(cmd.ExecuteReader());
            con.Close();
            return sach;
        }
        private void loaddlsach()
        {
            cbomasach.DataSource = loadsach();
            cbomasach.ValueMember = "MaSach";
            cbomasach.DisplayMember = "TenSach";
        }
        private DataTable loadthethuvien()
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_LOADTHETHUVIEN";
            sqlcmd.Connection = con;
            DataTable thethuvien = new DataTable();
            con.Open();
            thethuvien.Load(sqlcmd.ExecuteReader());
            con.Close();
            return thethuvien;
        }
        private void loaddlthethuvien()
        {
            cbomathe.DataSource = loadthethuvien();
            cbomathe.ValueMember = "MaThe";
            cbomathe.DisplayMember = "TenSV";
        }
        #region doc file
        private DataTable docphieumuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LOADPHIEUMUON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            DataTable phieumuon = new DataTable();
            con.Open();
            phieumuon.Load(cmd.ExecuteReader());
            con.Close();
            return phieumuon;
        }
        private void loaddlphieumuon()
        {
            dgvttpm.DataSource = docphieumuon();
        }
        #endregion 
        private void luuphieumuon()
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_LUUPHIEUMUON";
            sqlcmd.Connection = con;
            string mapm, mathe, masach;
            DateTime ngaymuon;
            mapm = txtmapm.Text;
            mathe = cbomathe.SelectedValue.ToString();
            masach = cbomasach.SelectedValue.ToString();
            ngaymuon = DateTime.Parse(dtpngaymuon.Value.ToString());
            sqlcmd.Parameters.AddWithValue("@MaPM", mapm);
            sqlcmd.Parameters.AddWithValue("@MaSach", masach);
            sqlcmd.Parameters.AddWithValue("@MaThe", mathe);
            sqlcmd.Parameters.AddWithValue("@MNgayMuon", ngaymuon);
            try
            {
                sqlcmd.Parameters.Add("@kq",
                    SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                con.Open();
                sqlcmd.ExecuteNonQuery();
                int kq = (int)sqlcmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbaomp.ForeColor = Color.Red;
                    lblthongbaomp.Text = "Da ton tai phieu muon";
                    return;
                }
                else if (kq == 1)
                {
                    lblthongbaomp.ForeColor = Color.Red;
                    lblthongbaomp.Text = " Khong ton tai sach";
                    return;
                }
                else if (kq == 1)
                {
                    lblthongbaomp.ForeColor = Color.Red;
                    lblthongbaomp.Text = " Khong ton tai sinh vien";
                    return;
                }
                else
                {
                    lblthongbaomp.ForeColor = Color.Green;
                    lblthongbaomp.Text = "Luu thanh cong";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Khong the them duoc vi: " + exp.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void btnluump_Click(object sender, EventArgs e)
        {
            huy_binding();
            luuphieumuon();
            loaddlphieumuon();
            data_binding();
        }

        private void btnthemmp_Click(object sender, EventArgs e)
        {
            txtmapm.Clear();
            txtmapm.Text = taomapm();
        }
        private void suaphieumuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_SUAPHIEUMUON";
            cmd.Connection = con;
            string mapm, mathe, masach;
            DateTime ngaymuon;
            mapm = txtmapm.Text;
            mathe = cbomathe.SelectedValue.ToString();
            masach = cbomasach.SelectedValue.ToString();
            ngaymuon = DateTime.Parse(dtpngaymuon.Value.ToString());
            cmd.Parameters.Add("@MaPM", mapm);
            cmd.Parameters.Add("@MaSach", masach);
            cmd.Parameters.Add("@MaSach", mathe);
            cmd.Parameters.Add("@MaSach", ngaymuon);
            try
            {
                cmd.Parameters.Add("@kq",
                    SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                con.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbaomp.ForeColor = Color.Red;
                    lblthongbaomp.Text = "khong ton tai phieu muon";
                    return;
                }
                else if (kq == 1)
                {
                    lblthongbaomp.ForeColor = Color.Red;
                    lblthongbaomp.Text = " Khong ton tai sach";
                    return;
                }
                else if (kq == 1)
                {
                    lblthongbaomp.ForeColor = Color.Red;
                    lblthongbaomp.Text = " Khong ton tai sinh vien";
                    return;
                }
                else
                {
                    lblthongbaomp.ForeColor = Color.Green;
                    lblthongbaomp.Text = "Sua thanh cong";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Khong the them duoc vi: " + exp.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void btnsuamp_Click(object sender, EventArgs e)
        {
            huy_binding();
            suaphieumuon();
            loaddlphieumuon();
            data_binding();
        }
        private void xoaphieumuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_XOAPHIEUMUON";
            cmd.Connection = con;
            string mapm;
            DateTime ngaymuon;
            mapm = txtmapm.Text;
            cmd.Parameters.Add("@MaPM", mapm);
            DialogResult kq1;
            kq1 = MessageBox.Show("Ban thuc su muon xoa?", "Chu y!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq1 == DialogResult.Yes)
            {
                try
                {
                    cmd.Parameters.Add("@kq",
                        SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    int kq = (int)cmd.Parameters["@kq"].Value;
                    if (kq == 1)
                    {
                        lblthongbaomp.ForeColor = Color.Red;
                        lblthongbaomp.Text = "da ton tai phieu muon";
                        return;
                    }
                    else
                    {
                        lblthongbaomp.ForeColor = Color.Green;
                        lblthongbaomp.Text = "Xoa thanh cong";
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Khong the them duoc vi: " + exp.Message);
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnxoamp_Click(object sender, EventArgs e)
        {
            huy_binding();
            xoaphieumuon();
            loaddlphieumuon();
            data_binding();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult noti;
            noti = MessageBox.Show("Ban dang thoat ra?", "Chu y", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (noti == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #region phieumuon dautien
        private void hienthiphieudautien()
        {
            txtpage.Text = vt.ToString();
            dtpm = new DataTable();
            dtpm = docphieumuon();
            DataRow row = dtpm.Rows[vt];
            txtmapm.Text = row[0].ToString();
            cbomasach.SelectedValue = row[1].ToString();
            cbomathe.SelectedValue = row[2].ToString();
            dtpngaymuon.Text = row[3].ToString();
            txtpage.Text = (1 + vt).ToString() + "/" + dtpm.Rows.Count.ToString();
        }
        #endregion
        #region nutlui
        private void btnlui_Click(object sender, EventArgs e)
        {
            if (vt > 0)
            {
                vt--;
                DataRow row = dtpm.Rows[vt];
                txtmapm.Text = row[0].ToString();
                cbomasach.SelectedValue = row[1].ToString();
                cbomathe.SelectedValue = row[2].ToString();
                dtpngaymuon.Text = row[3].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" + dtpm.Rows.Count.ToString();
                btnlui.Enabled = true;
            }
            else
            {
                btnlui.Enabled = false;
            }
        }
        #endregion
        #region nuttien
        private void btntoi_Click(object sender, EventArgs e)
        {
            if (vt > dtpm.Rows.Count - 1)
            {
                vt++;
                DataRow row = dtpm.Rows[vt];
                txtmapm.Text = row[0].ToString();
                cbomasach.SelectedValue = row[1].ToString();
                cbomathe.SelectedValue = row[2].ToString();
                dtpngaymuon.Text = row[3].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" + dtpm.Rows.Count.ToString();
                btntoi.Enabled = true;
            }
            else
            {
                btntoi.Enabled = false;
            }
        }



        #endregion
        #region nut cuoi

        private void btncuoi_Click(object sender, EventArgs e)
        {
            if (vt < dtpm.Rows.Count+1)
            {
                vt=dtpm.Rows.Count-1;
                DataRow row = dtpm.Rows[vt];
                txtmapm.Text = row[0].ToString();
                cbomasach.SelectedValue = row[1].ToString();
                cbomathe.SelectedValue = row[2].ToString();
                dtpngaymuon.Text = row[3].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" + dtpm.Rows.Count.ToString();
                btncuoi.Enabled = true;
            }
            else
            {
                btncuoi.Enabled = false;
            }
        }
        #endregion
        #region nut dau
        private void btndau_Click(object sender, EventArgs e)
        {
            if (vt > 0)
            {
                vt=0;
                DataRow row = dtpm.Rows[vt];
                txtmapm.Text = row[0].ToString();
                cbomasach.SelectedValue = row[1].ToString();
                cbomathe.SelectedValue = row[2].ToString();
                dtpngaymuon.Text = row[3].ToString();
                txtpage.Text = (1 + vt).ToString() + "/" + dtpm.Rows.Count.ToString();
                btndau.Enabled = true;
            }
            else
            {
                btndau.Enabled = false;
            }
        }
        #endregion

        #region nut tim kiem
        private void btntimkiemmp_Click(object sender, EventArgs e)
        {
            string mapm;
            bool result = false;
            for (int i=0; i < dtpm.Rows.Count; i++)
            {
                DataRow row = dtpm.Rows[i];
                mapm = row[0].ToString();
                if (mapm.ToUpper() == txttimkiempm.Text.ToUpper())
                {
                    txtmapm.Text = row[0].ToString();
                    cbomasach.SelectedValue = row[1].ToString();
                    cbomathe.SelectedValue = row[2].ToString();
                    dtpngaymuon.Text = row[3].ToString();
                    result = true;
                    return;
                }
                if (result == false)
                {
                    MessageBox.Show("Khong co ket qua tim kiem");
                    txttimkiempm.SelectAll();
                    txttimkiempm.Focus();
                }
            }
        }
        #endregion
    }
}
