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
        }
        private DataTable loadsachtheotinhtrang(string tinhtrang)
        {
            string chuoikn = "SELECT * FROM SACH WHERE TinhTrang = @TinhTrang";
            SqlCommand cmd = new SqlCommand();
            DataTable sach = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TinhTrang", tinhtrang);
            try
            {
                cnn.Open();
                sach.Load(cmd.ExecuteReader());
            }catch(Exception exp)
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
    }
}
