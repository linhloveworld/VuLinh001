using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLThuvien_Csharp_Nhom10
{
    public partial class frmnoiquy : Form
    {
        public frmnoiquy()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult noti;
            noti = MessageBox.Show("Ban dang thoat ra", "Thong bao!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (noti == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
