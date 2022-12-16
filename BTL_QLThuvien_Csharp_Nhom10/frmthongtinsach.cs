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
    public partial class frmthongtinsach : Form
    {
        SqlConnection con;
        DataTable dssach;
        public frmthongtinsach()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=THINKPADE14;Initial Catalog=BTL_NET1_QLThuVienDataSet");
        }
        private DataTable loadsachbihu()
        {
            string truyvan = "SELECT * FROM SACH WHERE TinhTrang=N'Cu or TinhTrang=N'cu or TinhTrang=N'Chu hoi mo";
            SqlCommand cmd = new SqlCommand(truyvan, con);
            DataTable sachhu = new DataTable();
            con.Open();
            sachhu.Load(cmd.ExecuteReader());
            con.Close();
            return sachhu;
        }
        private DataTable loadsachbanchay()
        {
            string truyvan = "SELECT * FROM SACH WHERE MaSach IN(SELECT MaSach FROM PHIEUMUON WHERE Sach.MaSach = PHIEUMUON.MaSach)";
            SqlCommand command = new SqlCommand(truyvan, con);
            DataTable sachbanchay = new DataTable();
            con.Open();
            sachbanchay.Load(command.ExecuteReader());
            con.Close();
            return sachbanchay;
        }
        private DataTable loadsachtonkho()
        {
            string truyvan = "SELECT * FROM SACH WHERE MaSach " +
                "NOT IN(SELECT MaSach form SACHMUON)";
            SqlCommand cmd = new SqlCommand();
            DataTable sachtonkho = new DataTable();
            con.Open();
            sachtonkho.Load(cmd.ExecuteReader());
            con.Close();
            return sachtonkho;
        }
        private void btnthongtin_Click(object sender, EventArgs e)
        {
            if (chksachbihu.Checked)
            {
                dtgthongtin.DataSource = loadsachbihu();
                txttong.ForeColor = Color.Yellow;
                txttong.Text = (dtgthongtin.Rows.Count).ToString();
            }
            if (chksachtonkho.Checked)
            {
                dtgthongtin.DataSource = loadsachtonkho();
                txttong.ForeColor = Color.Yellow;
                txttong.Text = (dtgthongtin.Rows.Count).ToString();
            }
            if (chksachbanchay.Checked)
            {
                dtgthongtin.DataSource = loadsachbanchay();
                txttong.ForeColor = Color.Yellow;
                txttong.Text = (dtgthongtin.Rows.Count).ToString();
            }
        }
    }
}
