using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuVien.Properties;

namespace QLThuVien
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            frmDangnhap Dangnhap = new frmDangnhap();
            Dangnhap.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDanhmucNhanvien danhmucnv = new frmDanhmucNhanvien();
            danhmucnv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPhongBan phongBan = new frmPhongBan();
            phongBan.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmChamCong chamCong = new frmChamCong();
            chamCong.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmLuong luong = new frmLuong();
            luong.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmChucVu chucVu = new frmChucVu();
            chucVu.Show();
        }

        private void btnexitmainpage_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
