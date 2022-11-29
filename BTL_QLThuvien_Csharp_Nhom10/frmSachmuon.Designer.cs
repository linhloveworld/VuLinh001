
namespace BTL_QLThuvien_Csharp_Nhom10
{
    partial class frmSachmuon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgsachmuon = new System.Windows.Forms.DataGridView();
            this.dtpngaytra = new System.Windows.Forms.DateTimePicker();
            this.cbomapm = new System.Windows.Forms.ComboBox();
            this.cbomasach = new System.Windows.Forms.ComboBox();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.txtsoluongsm = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btndau = new System.Windows.Forms.Button();
            this.btnlui = new System.Windows.Forms.Button();
            this.btntien = new System.Windows.Forms.Button();
            this.btncuoi = new System.Windows.Forms.Button();
            this.txtpage = new System.Windows.Forms.TextBox();
            this.lblthongbao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsachmuon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpage);
            this.groupBox1.Controls.Add(this.btncuoi);
            this.groupBox1.Controls.Add(this.btntien);
            this.groupBox1.Controls.Add(this.btnlui);
            this.groupBox1.Controls.Add(this.btndau);
            this.groupBox1.Controls.Add(this.dtgsachmuon);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bang thong tin";
            // 
            // dtgsachmuon
            // 
            this.dtgsachmuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgsachmuon.Location = new System.Drawing.Point(6, 25);
            this.dtgsachmuon.Name = "dtgsachmuon";
            this.dtgsachmuon.RowHeadersWidth = 51;
            this.dtgsachmuon.RowTemplate.Height = 24;
            this.dtgsachmuon.Size = new System.Drawing.Size(375, 183);
            this.dtgsachmuon.TabIndex = 1;
            // 
            // dtpngaytra
            // 
            this.dtpngaytra.Location = new System.Drawing.Point(588, 203);
            this.dtpngaytra.Name = "dtpngaytra";
            this.dtpngaytra.Size = new System.Drawing.Size(200, 22);
            this.dtpngaytra.TabIndex = 2;
            // 
            // cbomapm
            // 
            this.cbomapm.FormattingEnabled = true;
            this.cbomapm.Location = new System.Drawing.Point(588, 53);
            this.cbomapm.Name = "cbomapm";
            this.cbomapm.Size = new System.Drawing.Size(121, 24);
            this.cbomapm.TabIndex = 4;
            this.cbomapm.Text = "ma pm";
            // 
            // cbomasach
            // 
            this.cbomasach.FormattingEnabled = true;
            this.cbomasach.Location = new System.Drawing.Point(588, 90);
            this.cbomasach.Name = "cbomasach";
            this.cbomasach.Size = new System.Drawing.Size(121, 24);
            this.cbomasach.TabIndex = 5;
            this.cbomasach.Text = "ma sach";
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(588, 161);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(100, 22);
            this.txttinhtrang.TabIndex = 6;
            // 
            // txtsoluongsm
            // 
            this.txtsoluongsm.Location = new System.Drawing.Point(588, 124);
            this.txtsoluongsm.Name = "txtsoluongsm";
            this.txtsoluongsm.Size = new System.Drawing.Size(100, 22);
            this.txtsoluongsm.TabIndex = 7;
            this.txtsoluongsm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluongsm_KeyPress);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(472, 203);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(62, 17);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Ngay tra";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(402, 129);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(137, 17);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = "So luong sach muon";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(434, 60);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(105, 17);
            this.bunifuCustomLabel3.TabIndex = 10;
            this.bunifuCustomLabel3.Text = "Ma phieu muon";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(461, 166);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(73, 17);
            this.bunifuCustomLabel4.TabIndex = 11;
            this.bunifuCustomLabel4.Text = "Tinh trang";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(478, 97);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(61, 17);
            this.bunifuCustomLabel5.TabIndex = 12;
            this.bunifuCustomLabel5.Text = "Ma sach";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(15, 352);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 13;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(117, 352);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 14;
            this.btnsua.Text = "Sua";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(222, 355);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.Text = "Xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "DANH MUC SACH MUON";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(324, 355);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 17;
            this.btnluu.Text = "Luu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(437, 355);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(75, 23);
            this.btnin.TabIndex = 18;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthoat.Location = new System.Drawing.Point(705, 355);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(83, 33);
            this.btnthoat.TabIndex = 19;
            this.btnthoat.Text = "Thoat";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btndau
            // 
            this.btndau.Location = new System.Drawing.Point(6, 226);
            this.btndau.Name = "btndau";
            this.btndau.Size = new System.Drawing.Size(75, 23);
            this.btndau.TabIndex = 3;
            this.btndau.Text = "Dau";
            this.btndau.UseVisualStyleBackColor = true;
            this.btndau.Click += new System.EventHandler(this.btndau_Click);
            // 
            // btnlui
            // 
            this.btnlui.Location = new System.Drawing.Point(105, 226);
            this.btnlui.Name = "btnlui";
            this.btnlui.Size = new System.Drawing.Size(75, 23);
            this.btnlui.TabIndex = 4;
            this.btnlui.Text = "Lui";
            this.btnlui.UseVisualStyleBackColor = true;
            this.btnlui.Click += new System.EventHandler(this.btnlui_Click);
            // 
            // btntien
            // 
            this.btntien.Location = new System.Drawing.Point(210, 226);
            this.btntien.Name = "btntien";
            this.btntien.Size = new System.Drawing.Size(75, 23);
            this.btntien.TabIndex = 5;
            this.btntien.Text = "Tien";
            this.btntien.UseVisualStyleBackColor = true;
            this.btntien.Click += new System.EventHandler(this.btntien_Click);
            // 
            // btncuoi
            // 
            this.btncuoi.Location = new System.Drawing.Point(306, 226);
            this.btncuoi.Name = "btncuoi";
            this.btncuoi.Size = new System.Drawing.Size(75, 23);
            this.btncuoi.TabIndex = 6;
            this.btncuoi.Text = "Cuoi";
            this.btncuoi.UseVisualStyleBackColor = true;
            this.btncuoi.Click += new System.EventHandler(this.btncuoi_Click);
            // 
            // txtpage
            // 
            this.txtpage.Location = new System.Drawing.Point(105, 260);
            this.txtpage.Name = "txtpage";
            this.txtpage.Size = new System.Drawing.Size(180, 22);
            this.txtpage.TabIndex = 7;
            // 
            // lblthongbao
            // 
            this.lblthongbao.AutoSize = true;
            this.lblthongbao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblthongbao.Location = new System.Drawing.Point(467, 280);
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(82, 17);
            this.lblthongbao.TabIndex = 20;
            this.lblthongbao.Text = "(thong bao)";
            // 
            // frmSachmuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.lblthongbao);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtsoluongsm);
            this.Controls.Add(this.txttinhtrang);
            this.Controls.Add(this.cbomasach);
            this.Controls.Add(this.cbomapm);
            this.Controls.Add(this.dtpngaytra);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSachmuon";
            this.Text = "frmSachmuon";
            this.Load += new System.EventHandler(this.frmSachmuon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsachmuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncuoi;
        private System.Windows.Forms.Button btntien;
        private System.Windows.Forms.Button btnlui;
        private System.Windows.Forms.Button btndau;
        private System.Windows.Forms.DataGridView dtgsachmuon;
        private System.Windows.Forms.DateTimePicker dtpngaytra;
        private System.Windows.Forms.ComboBox cbomapm;
        private System.Windows.Forms.ComboBox cbomasach;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.TextBox txtsoluongsm;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtpage;
        private System.Windows.Forms.Label lblthongbao;
    }
}