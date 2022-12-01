using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace BTL_QLThuvien_Csharp_Nhom10
{
    public partial class frmmuontrasach : Form
    {
        SqlConnection cnn;
        DataTable vt_thetv;
        DataRow r1;
        int vt;
        public frmmuontrasach()
        {
            InitializeComponent();
            cnn = new SqlConnection("DataSource = THINKPADE14;" +
                "Initial Catalog=. ;" + "Intergrated Security=True");
            vt_thetv = new DataTable();
            vt_thetv = loadthethuvien();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void frmmuontrasach_Load(object sender, EventArgs e)
        {
            loadthethuvien();
            hienbangpm(txtmapm.Text);
            hienbangpnt(txtmathe1.Text);
            hienthisvdautien2();
            hienthisvdautien1();
            loaddlsach();
            txtmapnt.Enabled = false;
            txtmapm.Enabled = false;
        }
        private string taomapnt()
        {
            string mapnt;
            Random ran = new Random();
            mapnt = "PNT" + ran.Next(50, 999).ToString();
            return mapnt;
        }
        public DataTable loadthethuvien()
        {
            frmthethuvien frmttv = new frmthethuvien();
            return frmttv.loadthetv();
        }
        public string taomathe()
        {
            string mathe;
            Random ran = new Random();
            mathe = "SV" + ran.Next(50, 999).ToString();
            return mathe;
        }
        //TabPage1: Quan ly muon 
        public string taomapm()
        {
            string mapm;
            Random ran = new Random();
            mapm = "PM" + ran.Next(50, 999).ToString();
            return mapm;
        }
        
        private void hienthisvdautien1()
        {
            txtpage1.Text = vt.ToString();
            vt_thetv = new DataTable();
            vt_thetv = loadthethuvien();
            DataRow row = vt_thetv.Rows[vt];
            txtmathe1.Text = row[0].ToString();
            txtten1.Text = row[1].ToString();
            cbogioitinh1.Text = row[2].ToString();
            dtpngaysinh1.Text = row[3].ToString();
            txtdiachi1.Text = row[4].ToString();
            txtsdt1.Text = row[5].ToString();
            dtpngaytao1.Text = row[6].ToString();
            dtpngayhethan1.Text = row[0].ToString();
            txtpage1.Text = (1 + vt).ToString() + "/" + vt_thetv.Rows.Count.ToString();
        }
        private void data_bindings()
        {
            txtmathe1.DataBindings.Add("Text", dtgds1.DataSource, "MaPhieuMuon");
            txtten1.DataBindings.Add("Text", dtgds1.DataSource, "HoTenSinhVien");
            cbogioitinh1.DataBindings.Add("Text", dtgds1.DataSource, "GioiTinh");
            dtpngaysinh1.DataBindings.Add("Text", dtgds1.DataSource, "NgaySinh");
            txtdiachi1.DataBindings.Add("Text", dtgds1.DataSource, "DiaChi");
            txtsdt1.DataBindings.Add("Text", dtgds1.DataSource, "SoDienThoai");
            dtpngaytao1.DataBindings.Add("Text", dtgds1.DataSource, "NgayLapThe");
            dtpngayhethan1.DataBindings.Add("Text", dtgds1.DataSource, "NgayTheHetHan");
        }
        private void huy_lienketdl()
        {
            if (dtpngaysinh1.DataBindings != null)
            {
                dtpngaysinh1.DataBindings.Clear();
            }
            if (txtsdt1.DataBindings != null)
            {
                txtsdt1.DataBindings.Clear();
            }
            if (txtmathe1.DataBindings != null)
            {
                txtmathe1.DataBindings.Clear();
            }
            if (txtten1.DataBindings != null)
            {
                txtten1.DataBindings.Clear();
            }
            if (dtpngaytao1.DataBindings != null)
            {
                dtpngaytao1.DataBindings.Clear();
            }
            if (dtpngayhethan1.DataBindings != null)
            {
                dtpngayhethan1.DataBindings.Clear();
            }
            if (txtdiachi1.DataBindings != null)
            {
                txtdiachi1.DataBindings.Clear();
            }
            if (cbogioitinh1.DataBindings != null)
            {
                cbogioitinh1.DataBindings.Clear();
            }
        }

        private void btnthem1_Click(object sender, EventArgs e)
        {
            txtmathe1.Clear();
            txtten1.Clear();
            txtsdt1.Clear();
            txtpage1.Clear();
            txtmathe1.Text = taomathe();
        }
        private void btnthempm_Click(object sender, EventArgs e)
        {
            txtmapm.Clear();
            txtmapm.Text = taomapm();
        }
        private void luuthethuvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUTHETHUVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mathe, tensv, diachi, sdt;
            DateTime ngaytaothe, ngayhethanthe, ngaysinh;
            bool gioitinh;
            mathe = txtmathe1.Text;
            tensv = txtten1.Text;
            diachi = txtdiachi1.Text;
            sdt = txtsdt1.Text;
            ngaytaothe = DateTime.Parse(dtpngaytao1.Value.ToString());
            ngayhethanthe = DateTime.Parse(dtpngayhethan1.Value.ToString());
            ngaysinh = DateTime.Parse(dtpngaysinh1.Value.ToString());
            if (DateTime.Now.Year - ngaysinh.Year > 85 || DateTime.Now.Year - ngaysinh.Year < 18)
            {
                lblthongbao_tp1.ForeColor = Color.Red;
                lblthongbao_tp1.Text = "sinh viên phải đủ tuổi từ 18-85";
                dtpngaysinh1.Focus();
                return;
            }
            if (txtten1.Text == "")
            {
                lblthongbao_tp1.ForeColor = Color.Red;
                lblthongbao_tp1.Text = "Tên không được để trống";
                txtten1.Focus();
                return;
            }
            if (txtdiachi1.Text == "")
            {
                lblthongbao_tp1.ForeColor = Color.Red;
                lblthongbao_tp1.Text = "Địa chỉ không được để trống";
                txtdiachi1.Focus();
                return;
            }
            if (cbogioitinh1.Text == "Nam")
            {
                gioitinh = true;
            }
            else gioitinh = false;
            cmd.Parameters.Add("@MaTheThuVien", mathe);
            cmd.Parameters.Add("@TenSinhVien", tensv);
            cmd.Parameters.Add("@GioiTinh", gioitinh);
            cmd.Parameters.Add("@NgaySinh", ngaysinh);
            cmd.Parameters.Add("@DiaChi", diachi);
            cmd.Parameters.Add("@SoDienThoai", sdt);
            cmd.Parameters.Add("@NgayTaoThe", ngaytaothe);
            cmd.Parameters.Add("@NgayHetHanThe", ngayhethanthe);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                cnn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbao_tp1.ForeColor = Color.Red;
                    lblthongbao_tp1.Text = "đã tồn tại TheThuViện";
                    return;
                }
                else
                {
                    lblthongbao_tp1.ForeColor = Color.Green;
                    lblthongbao_tp1.Text = "Lưu Thành Công";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi kg them duoc vi" + ex.Message);
            }
            finally
            {
                if (cnn != null)
                    cnn.Close();
            }
        }
        private void suathethuvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUATHETHUVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string ma, ten, diachi, dt;
            DateTime ngaytao, ngayhethan, ngaysinh;
            bool gioitinh;
            ma = txtmathe1.Text;
            ten = txtten1.Text;
            diachi = txtdiachi1.Text;
            dt = txtsdt1.Text;
            ngayhethan = DateTime.Parse(dtpngayhethan1.Value.ToString());
            ngaytao = DateTime.Parse(dtpngaytao1.Value.ToString());
            ngaysinh = DateTime.Parse(dtpngaysinh1.Value.ToString());
            if (cbogioitinh1.Text == "Nam")
            {
                gioitinh = true;
            }
            else gioitinh = false;
            cmd.Parameters.Add("@MaThe", ma);
            cmd.Parameters.Add("@TenSinhVien", ten);
            cmd.Parameters.Add("@GioiTinh", gioitinh);
            cmd.Parameters.Add("@NgaySinh", ngaysinh);
            cmd.Parameters.Add("@DiaChi", diachi);
            cmd.Parameters.Add("@SoDienThoai", dt);
            cmd.Parameters.Add("@NgayTaoThe", ngaytao);
            cmd.Parameters.Add("@NgayHetHanThe", ngayhethan);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                cnn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbao_tp1.ForeColor = Color.Red;
                    lblthongbao_tp1.Text = "đã tồn tại TheThuViện";
                    return;
                }
                else
                {
                    lblthongbao_tp1.ForeColor = Color.Green;
                    lblthongbao_tp1.Text = "Sua Thành Công";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khong them duoc vi" + ex.Message);
            }
            finally
            {
                if (cnn != null)
                    cnn.Close();
            }
        }
        private void btnsua1_Click(object sender, EventArgs e)
        {
            huy_lienketdl();
            suathethuvien();
            data_bindings();
        }
        private void xoathethuvien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_XOATHETHUVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mathe;
            mathe = txtmathe1.Text;
            cmd.Parameters.Add("@MaTheThuVien", mathe);
            DialogResult kq1;
            kq1 = MessageBox.Show("Bạn Thật Sự Muốn Xóa", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq1 == DialogResult.Yes)
            {
                try
                {
                    cmd.Parameters.Add("@kq",
                    SqlDbType.Int).Direction =
                        ParameterDirection.ReturnValue;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    int kq2 = (int)cmd.Parameters["@kq"].Value;
                    if (kq2 == 1)
                    {
                        lblthongbao_tp1.ForeColor = Color.Red;
                        lblthongbao_tp1.Text = "đã tồn tại TheThuViện trong phieu muon";
                        return;
                    }
                    if (kq2 == 2)
                    {
                        lblthongbao_tp1.ForeColor = Color.Red;
                        lblthongbao_tp1.Text = "đã tồn tại TheThuViện trong phieu nhac tra";
                        return;
                    }
                    else
                    {
                        lblthongbao_tp1.ForeColor = Color.Green;
                        lblthongbao_tp1.Text = "Xoa Thành Công";
                    }
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
            }

        }
        private void btnxoa1_Click(object sender, EventArgs e)
        {
            huy_lienketdl();
            xoathethuvien();
            data_bindings();
        }
        private DataTable loadsach()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LOADSACH";
            cmd.Connection = cnn;
            DataTable sach = new DataTable();
            cnn.Open();
            sach.Load(cmd.ExecuteReader());
            cnn.Close();
            return sach;
        }
        private void loaddlsach()
        {
            cbomasach.DataSource = loadsach();
            cbomasach.ValueMember = "MaSachMuon";
            cbomasach.DisplayMember = "TenSachMuon";
        }
        private DataTable loadphieumuon(string mathe)
        {
            DataTable pm = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_Docphieumuonsinhvien";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            //masv = txtmasv.Text;
            cmd.Parameters.AddWithValue("@mathe", mathe);
            try
            {
                cnn.Open();
                pm.Load(cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi khong doc duoc phieu muon", e.Message);
            }
            finally
            {
                if (cnn != null) cnn.Close();
            }
            return pm;
        }
        private void hienbangpm(string mathe)
        {
            huy_lienketdlkq();
            dtgds1.DataSource = loadphieumuon(mathe);
            lienket_dulieukq();
        }
        private void lienket_dulieukq()
        {
            cbomasach.DataBindings.Add("SelectedValue", dtgds1.DataSource, "MaSach");
            txtmapm.DataBindings.Add("Text", dtgds1.DataSource, "MaPhieuMuon");
        }
        private void huy_lienketdlkq()
        {
            if (cbomasach.DataBindings != null) cbomasach.DataBindings.Clear();
            if (txtmapm.DataBindings != null) txtmapm.DataBindings.Clear();
        }
        private void btndau1_Click(object sender, EventArgs e)
        {
            if (vt > 0)
            {
                vt = 0;
                DataRow r = vt_thetv.Rows[vt];
                txtmathe1.Text = r[0].ToString();
                txtten1.Text = r[1].ToString();
                cbogioitinh1.Text = r[2].ToString();
                dtpngaysinh1.Text = r[3].ToString();
                txtdiachi1.Text = r[4].ToString();
                txtsdt1.Text = r[5].ToString();
                dtpngaytao1.Text = r[6].ToString();
                dtpngayhethan1.Text = r[7].ToString();
                txtpage1.Text = (1 + vt).ToString() + "/" + vt_thetv.Rows.Count.ToString();
                btndau1.Enabled = true;
                hienbangpm(txtmathe1.Text);
            }
            else btndau1.Enabled = false;
        }
        private void btnlui1_Click(object sender, EventArgs e)
        {
            if (vt > 0)
            {
                vt--;
                DataRow r = vt_thetv.Rows[vt];
                txtmathe1.Text = r[0].ToString();
                txtten1.Text = r[1].ToString();
                cbogioitinh1.Text = r[2].ToString();
                dtpngaysinh1.Text = r[3].ToString();
                txtdiachi1.Text = r[4].ToString();
                txtsdt1.Text = r[5].ToString();
                dtpngaytao1.Text = r[6].ToString();
                dtpngayhethan1.Text = r[7].ToString();
                txtpage1.Text = (1 + vt).ToString() + "/" + vt_thetv.Rows.Count.ToString();
                btnlui1.Enabled = true;
                hienbangpm(txtmathe1.Text);
            }
            else btnlui1.Enabled = false;
        }

        private void btntien1_Click(object sender, EventArgs e)
        {
            if (vt < vt_thetv.Rows.Count - 1)
            {
                vt++;
                DataRow r = vt_thetv.Rows[vt];
                txtmathe1.Text = r[0].ToString();
                txtten1.Text = r[1].ToString();
                cbogioitinh1.Text = r[2].ToString();
                dtpngaysinh1.Text = r[3].ToString();
                txtdiachi1.Text = r[4].ToString();
                txtsdt1.Text = r[5].ToString();
                dtpngaytao1.Text = r[6].ToString();
                dtpngayhethan1.Text = r[7].ToString();
                txtpage1.Text = vt.ToString();
                txtpage1.Text = (1 + vt).ToString() + "/" + vt_thetv.Rows.Count.ToString();
                btntien1.Enabled = true;
                hienbangpm(txtmathe1.Text);
            }
            else btntien1.Enabled = false;
        }

        private void btncuoi1_Click(object sender, EventArgs e)
        {
            if (vt < vt_thetv.Rows.Count - 1)
            {
                vt = vt_thetv.Rows.Count - 1;
                DataRow r = vt_thetv.Rows[vt];
                txtmathe1.Text = r[0].ToString();
                txtten1.Text = r[1].ToString();
                cbogioitinh1.Text = r[2].ToString();
                dtpngaysinh1.Text = r[3].ToString();
                txtdiachi1.Text = r[4].ToString();
                txtsdt1.Text = r[5].ToString();
                dtpngaytao1.Text = r[6].ToString();
                dtpngayhethan1.Text = r[7].ToString();
                txtpage1.Text = (1 + vt).ToString() + "/" + vt_thetv.Rows.Count.ToString();
                btndau1.Enabled = true;
                hienbangpm(txtmathe1.Text);
            }
            else btncuoi1.Enabled = false;
        }
        private void suaphieumuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUAPHIEUMUON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mapm, mathe, masach;
            DateTime ngaymuon;
            mapm = txtmapm.Text;
            masach = cbomasach.SelectedValue.ToString();
            mathe = txtmathe.Text;
            ngaymuon = DateTime.Parse(dtpngaymuon.Value.ToString());
            cmd.Parameters.Add("@MaPM", mapm);
            cmd.Parameters.Add("@MaSach", masach);
            cmd.Parameters.Add("@MaThe", mathe);
            cmd.Parameters.Add("@NgayMuon", ngaymuon);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                cnn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbaopm.ForeColor = Color.Red;
                    lblthongbaopm.Text = "không tồn tại phiếu mượn";
                    return;
                }
                else if (kq == 1)
                {
                    lblthongbaopm.ForeColor = Color.Red;
                    lblthongbaopm.Text = "Không tồn tại sách ";
                    return;
                }
                else if (kq == 1)
                {
                    lblthongbaopm.ForeColor = Color.Red;
                    lblthongbaopm.Text = "Không tồn tại Sinh Viên";
                    return;
                }
                else
                {
                    lblthongbaopm.ForeColor = Color.Green;
                    lblthongbaopm.Text = "Sửa Thành Công";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong thuc hien duoc vi: " + ex.Message);
            }
            finally
            {
                if (cnn != null)
                    cnn.Close();
            }
        }

        private void btnsuapm_Click(object sender, EventArgs e)
        {
            huy_lienketdl();
            suaphieumuon();
            hienbangpm(txtmathe.Text);
            loadthethuvien();
            data_bindings();
        }
        private void xoaphieumuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_Xoaphieumuonsinhvien";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mapm;
            mapm = txtmapm.Text;
            cmd.Parameters.Add("@MaPM", mapm);
            DialogResult kq1;
            kq1 = MessageBox.Show("Bạn Thật Sự Muốn Xóa", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                cnn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbaopm.ForeColor = Color.Red;
                    lblthongbaopm.Text = "Đã tồn tại PM trong sách mượn";
                    return;
                }
                else
                {
                    lblthongbaopm.ForeColor = Color.Green;
                    lblthongbaopm.Text = "Xóa Thành Công";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong thuc hien duoc vi: " + ex.Message);
            }
            finally
            {
                if (cnn != null) cnn.Close();
            }
        }

        private void btnxoapm_Click(object sender, EventArgs e)
        {
            huy_lienketdlkq();
            xoaphieumuon();
            hienbangpm(txtmapm.Text);
        }
        //Tabpage2: Quan li nhac tra
        private void data_bindings2()
        {
            txtmathe2.DataBindings.Add("Text", dtgds1.DataSource, "MaPhieuMuon");
            txtten2.DataBindings.Add("Text", dtgds1.DataSource, "HoTenSinhVien");
            cbogioitinh2.DataBindings.Add("Text", dtgds1.DataSource, "GioiTinh");
            dtpngaysinh2.DataBindings.Add("Text", dtgds1.DataSource, "NgaySinh");
            txtdiachi2.DataBindings.Add("Text", dtgds1.DataSource, "DiaChi");
            txtsdt2.DataBindings.Add("Text", dtgds1.DataSource, "SoDienThoai");
            dtpngaytao2.DataBindings.Add("Text", dtgds1.DataSource, "NgayLapThe");
            dtpngayhethan2.DataBindings.Add("Text", dtgds1.DataSource, "NgayTheHetHan");
        }
        private void huy_lienketdl2()
        {
            if (dtpngaysinh2.DataBindings != null)
                dtpngaysinh2.DataBindings.Clear();
            if (txtsdt2.DataBindings != null)
                txtsdt2.DataBindings.Clear();
            if (txtmathe2.DataBindings != null)
                txtmathe2.DataBindings.Clear();
            if (txtten2.DataBindings != null)
                txtten2.DataBindings.Clear();
            if (dtpngaytao2.DataBindings != null)
                dtpngaytao2.DataBindings.Clear();
            if (dtpngayhethan2.DataBindings != null)
                dtpngayhethan2.DataBindings.Clear();
            if (txtdiachi2.DataBindings != null)
                txtdiachi2.DataBindings.Clear();
            if (cbogioitinh2.DataBindings != null)
                cbogioitinh2.DataBindings.Clear();
        }

        //[Obsolete]
        private void luuthethuvien2()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LUUTHETHUVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mathe, tensv, diachi, sdt;
            DateTime ngaytaothe, ngayhethanthe, ngaysinh;
            bool gioitinh;
            mathe = txtmathe2.Text;
            tensv = txtten2.Text;
            diachi = txtdiachi2.Text;
            sdt = txtsdt2.Text;
            ngaytaothe = DateTime.Parse(dtpngaytao2.Value.ToString());
            ngayhethanthe = DateTime.Parse(dtpngayhethan2.Value.ToString());
            ngaysinh = DateTime.Parse(dtpngaysinh2.Value.ToString());
            if (DateTime.Now.Year - ngaysinh.Year > 85 || DateTime.Now.Year - ngaysinh.Year < 18)
            {
                lblthongbao_tp2.ForeColor = Color.Red;
                lblthongbao_tp2.Text = "sinh viên phải đủ tuổi từ 18-85";
                dtpngaysinh2.Focus();
                return;
            }
            if (txtten2.Text == "")
            {
                lblthongbao_tp2.ForeColor = Color.Red;
                lblthongbao_tp2.Text = "Tên không được để trống";
                txtten2.Focus();
                return;
            }
            if (txtdiachi2.Text == "")
            {
                lblthongbao_tp2.ForeColor = Color.Red;
                lblthongbao_tp2.Text = "Địa chỉ không được để trống";
                txtdiachi2.Focus();
                return;
            }
            if (cbogioitinh2.Text == "Nam")
            {
                gioitinh = true;
            }
            else gioitinh = false;
            cmd.Parameters.Add("@MaTheThuVien", mathe);
            cmd.Parameters.Add("@TenSinhVien", tensv);
            cmd.Parameters.Add("@GioiTinh", gioitinh);
            cmd.Parameters.Add("@NgaySinh", ngaysinh);
            cmd.Parameters.Add("@DiaChi", diachi);
            cmd.Parameters.Add("@SoDienThoai", sdt);
            cmd.Parameters.Add("@NgayTaoThe", ngaytaothe);
            cmd.Parameters.Add("@NgayHetHanThe", ngayhethanthe);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                cnn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbao_tp2.ForeColor = Color.Red;
                    lblthongbao_tp2.Text = "The thu viện đã tồn tại";
                    return;
                }
                else
                {
                    lblthongbao_tp2.ForeColor = Color.Green;
                    lblthongbao_tp2.Text = "Lưu Thành Công";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong the thuc hien duoc vi: " + ex.Message);
            }
            finally
            {
                if (cnn != null) cnn.Close();
            }
        }
        private void btnluu2_Click(object sender, EventArgs e)
        {
            huy_lienketdl();
            luuthethuvien2();
            loadthethuvien();
            data_bindings();
        }
        private void suathethuvien2()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_SUATHETHUVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string ma, ten, diachi, dt;
            DateTime ngaytao, ngayhethan, ngaysinh;
            bool gioitinh;
            ma = txtmathe2.Text;
            ten = txtten2.Text;
            diachi = txtdiachi2.Text;
            dt = txtsdt2.Text;
            ngayhethan = DateTime.Parse(dtpngayhethan2.Value.ToString());
            ngaytao = DateTime.Parse(dtpngaytao2.Value.ToString());
            ngaysinh = DateTime.Parse(dtpngaysinh2.Value.ToString());
            if (cbogioitinh2.Text == "Nam")
            {
                gioitinh = true;
            }
            else gioitinh = false;
            cmd.Parameters.Add("@MaThe", ma);
            cmd.Parameters.Add("@TenSinhVien", ten);
            cmd.Parameters.Add("@GioiTinh", gioitinh);
            cmd.Parameters.Add("@NgaySinh", ngaysinh);
            cmd.Parameters.Add("@DiaChi", diachi);
            cmd.Parameters.Add("@SoDienThoai", dt);
            cmd.Parameters.Add("@NgayTaoThe", ngaytao);
            cmd.Parameters.Add("@NgayHetHanThe", ngayhethan);
            try
            {
                cmd.Parameters.Add("@kq",
                SqlDbType.Int).Direction =
                    ParameterDirection.ReturnValue;
                cnn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@kq"].Value;
                if (kq == 1)
                {
                    lblthongbao_tp2.ForeColor = Color.Red;
                    lblthongbao_tp2.Text = "The Thu Viện đã tồn tại ";
                    return;
                }
                else
                {
                    lblthongbao_tp2.ForeColor = Color.Green;
                    lblthongbao_tp2.Text = "Sua Thành Công";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong thuc hien duoc vi: " + ex.Message);
            }
            finally
            {
                if (cnn != null) cnn.Close();
            }
        }
        private void btnsua2_Click(object sender, EventArgs e)
        {
            huy_lienketdl2();
            suathethuvien2();
            loadthethuvien();
            data_bindings();
        }
        private void xoathethuvien2()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_XOATHETHUVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            string mathe;
            mathe = txtmathe2.Text;
            cmd.Parameters.Add("@MaTheThuVien", mathe);
            DialogResult kq1;
            kq1 = MessageBox.Show("Bạn Thật Sự Muốn Xóa", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq1 == DialogResult.Yes)
            {
                try
                {
                    cmd.Parameters.Add("@kq",
                    SqlDbType.Int).Direction =
                        ParameterDirection.ReturnValue;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    int kq2 = (int)cmd.Parameters["@kq"].Value;
                    if (kq2 == 1)
                    {
                        lblthongbao_tp2.ForeColor = Color.Red;
                        lblthongbao_tp2.Text = "The Thu Viện đã tồn tại trong phieu muon";
                        return;
                    }
                    if (kq2 == 2)
                    {
                        lblthongbao_tp2.ForeColor = Color.Red;
                        lblthongbao_tp2.Text = "The Thu Viện đã tồn tại trong phieu nhac tra";
                        return;
                    }
                    else
                    {
                        lblthongbao_tp2.ForeColor = Color.Green;
                        lblthongbao_tp2.Text = "Xoa Thành Công";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Khong thuc hien duoc vi" + ex.Message);
                }
                finally
                {
                    if (cnn != null) cnn.Close();
                }
            }
        }
        private void btnxoa2_Click(object sender, EventArgs e)
        {
            huy_lienketdl2();
            xoathethuvien2();
            loadthethuvien();
            data_bindings();
        }
        private void hienthisvdautien2()
        {
            txtpage1.Text = vt.ToString();
            vt_thetv = new DataTable();
            vt_thetv = loadthethuvien();
            DataRow r = vt_thetv.Rows[vt];
            txtmathe1.Text = r[0].ToString();
            txtten1.Text = r[1].ToString();
            cbogioitinh2.Text = r[2].ToString();
            dtpngaysinh2.Text = r[3].ToString();
            txtdiachi2.Text = r[4].ToString();
            txtsdt2.Text = r[5].ToString();
            dtpngaytao2.Text = r[6].ToString();
            dtpngayhethan2.Text = r[7].ToString();
            txtpage2.Text = vt.ToString();
            txtpage2.Text = (1 + vt).ToString() + "/" + vt_thetv.Rows.Count.ToString();
        }
        private void btndau2_Click(object sender, EventArgs e)
        {
            if (vt > 0)
            {
                vt = 0;
                DataRow r = vt_thetv.Rows[vt];
                txtmathe2.Text = r[0].ToString();
                txtten2.Text = r[1].ToString();
                cbogioitinh2.Text = r[2].ToString();
                dtpngaysinh2.Text = r[3].ToString();
                txtdiachi2.Text = r[4].ToString();
                txtsdt2.Text = r[5].ToString();
                dtpngaytao2.Text = r[6].ToString();
                dtpngayhethan2.Text = r[7].ToString();
                txtpage2.Text = (1 + vt).ToString() + "/" + vt_thetv.Rows.Count.ToString();
                btndau2.Enabled = true;
                hienbangpm(txtmathe2.Text);
            }
            else btndau2.Enabled = false;
        }
        private void btnlui2_Click(object sender, EventArgs e)
        {
            if (vt > 0)
            {
                vt--;
                DataRow r = vt_thetv.Rows[vt];
                txtmathe1.Text = r[0].ToString();
                txtten2.Text = r[1].ToString();
                cbogioitinh2.Text = r[2].ToString();
                dtpngaysinh2.Text = r[3].ToString();
                txtdiachi2.Text = r[4].ToString();
                txtsdt2.Text = r[5].ToString();
                dtpngaytao2.Text = r[6].ToString();
                dtpngayhethan2.Text = r[7].ToString();
                txtpage2.Text = (1 + vt).ToString() + "/" + vt_thetv.Rows.Count.ToString();
                btnlui2.Enabled = true;
                hienbangpm(txtmathe2.Text);
            }
            else btnlui2.Enabled = false;
        }

        private void btntien2_Click(object sender, EventArgs e)
        {
            if (vt < vt_thetv.Rows.Count - 1)
            {
                vt++;
                DataRow r = vt_thetv.Rows[vt];
                txtmathe2.Text = r[0].ToString();
                txtten2.Text = r[1].ToString();
                cbogioitinh2.Text = r[2].ToString();
                dtpngaysinh2.Text = r[3].ToString();
                txtdiachi2.Text = r[4].ToString();
                txtsdt2.Text = r[5].ToString();
                dtpngaytao2.Text = r[6].ToString();
                dtpngayhethan2.Text = r[7].ToString();
                txtpage2.Text = vt.ToString();
                txtpage2.Text = (1 + vt).ToString() + "/" + vt_thetv.Rows.Count.ToString();
                btntien2.Enabled = true;
                hienbangpm(txtmathe2.Text);
            }
            else btntien2.Enabled = false;
        }
        private void btncuoi2_Click(object sender, EventArgs e)
        {
            if (vt < vt_thetv.Rows.Count - 1)
            {
                vt = vt_thetv.Rows.Count - 1;
                DataRow r = vt_thetv.Rows[vt];
                txtmathe2.Text = r[0].ToString();
                txtten2.Text = r[1].ToString();
                cbogioitinh2.Text = r[2].ToString();
                dtpngaysinh2.Text = r[3].ToString();
                txtdiachi2.Text = r[4].ToString();
                txtsdt2.Text = r[5].ToString();
                dtpngaytao2.Text = r[6].ToString();
                dtpngayhethan2.Text = r[7].ToString();
                txtpage2.Text = (1 + vt).ToString() + "/" + vt_thetv.Rows.Count.ToString();
                btndau2.Enabled = true;
                hienbangpm(txtmathe2.Text);
            }
            else btncuoi2.Enabled = false;
        }

    }
}
