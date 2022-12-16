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
    public partial class insach : Form
    {
        SqlConnection conn;
        public insach()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=THINKPADE14;Initial Catalog=BTL_NET1_QLThuVienDataSet;Intergrated Security=True");
        }

        private void insach_Load(object sender, EventArgs e)
        {

        }
    }
}
