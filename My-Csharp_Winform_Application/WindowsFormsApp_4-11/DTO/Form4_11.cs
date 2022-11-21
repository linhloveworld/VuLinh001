using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_4_11.DTO
{
    public partial class Form4_11 : Form
    {
        private DBBanHangEntities db;
        public Form4_11()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            DBBanHangEntities db = new DBBanHangEntities();
            var res = from c in db.SanPhams
                      where c.MaSP > 1 && c.MaSP < 5
                      select c;
            dataGridView1.DataSource = res.ToList();
        }
        public void BindingData()
        {
            textBox1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaSP", true, DataSourceUpdateMode.Never));
            textBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenSP", true, DataSourceUpdateMode.Never));
            textBox3.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Gia", true, DataSourceUpdateMode.Never));
        }
        public void CreateSP()
        {
            SanPham sp = new SanPham()
            {
                MaSP = Convert.ToInt32(textBox1.text),
                TenSP = textBox2.text,
                Gia = textBox3.text
            };
            db.SanPhams.Add(sp);
            db.SaveChanges();
        }
        public void UpdateSP()
        {
            DBBanHangEntities db = new DBBanHangEntities();
            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["MaSP"]);
            SanPham sp = db.SanPhams.Find(id);
            sp.TenSP = textBox2.text;
            db.SaveChanges();
        }
        public void DeleteSP()
        {
            int id = Convert.ToInt32(textBox1.Text);
            SanPham sp = db.SanPhams.Where(p => p.MaSP == id && p.TenSP == textBox2.text).SingleOrDefault();
            db.SanPhams.Remove(sp);
        }
        private void Form4_11_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            UpdateSP();
            LoadData();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            CreateSP();
            LoadData();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            DeleteSP();
            LoadData();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingData();
        }
    }
}
