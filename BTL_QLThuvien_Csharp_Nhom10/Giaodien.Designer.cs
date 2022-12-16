
namespace BTL_QLThuvien_Csharp_Nhom10
{
    partial class Giaodien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giaodien));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudx = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudmqlsv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudmqlnv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudmqlsach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudlsach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudlsachmuon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudmqlphieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudlphieumuon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudlphieunhactra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuxuly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ckhienthimk = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblthongbao = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.mnudanhmuc,
            this.mnutimkiem,
            this.mnuxuly,
            this.mnubaocao,
            this.mnutrogiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1037, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudn,
            this.mnudk,
            this.mnudx});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnudn
            // 
            this.mnudn.Name = "mnudn";
            this.mnudn.Size = new System.Drawing.Size(165, 26);
            this.mnudn.Text = "Đăng nhập";
            // 
            // mnudk
            // 
            this.mnudk.Name = "mnudk";
            this.mnudk.Size = new System.Drawing.Size(165, 26);
            this.mnudk.Text = "Đăng ký";
            this.mnudk.Click += new System.EventHandler(this.mnudk_Click);
            // 
            // mnudx
            // 
            this.mnudx.Name = "mnudx";
            this.mnudx.Size = new System.Drawing.Size(165, 26);
            this.mnudx.Text = "Đăng xuất";
            this.mnudx.Click += new System.EventHandler(this.mnudx_Click);
            // 
            // mnudanhmuc
            // 
            this.mnudanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudmqlsv,
            this.mnudmqlnv,
            this.mnudmqlsach,
            this.mnudmqlphieu});
            this.mnudanhmuc.Name = "mnudanhmuc";
            this.mnudanhmuc.Size = new System.Drawing.Size(90, 24);
            this.mnudanhmuc.Text = "Danh mục";
            // 
            // mnudmqlsv
            // 
            this.mnudmqlsv.Name = "mnudmqlsv";
            this.mnudmqlsv.Size = new System.Drawing.Size(275, 26);
            this.mnudmqlsv.Text = "Danh muc quan li sinh vien";
            this.mnudmqlsv.Click += new System.EventHandler(this.mnudmqlsv_Click);
            // 
            // mnudmqlnv
            // 
            this.mnudmqlnv.Name = "mnudmqlnv";
            this.mnudmqlnv.Size = new System.Drawing.Size(275, 26);
            this.mnudmqlnv.Text = "Danh muc quan li nhan vien";
            this.mnudmqlnv.Click += new System.EventHandler(this.mnudmqlnv_Click);
            // 
            // mnudmqlsach
            // 
            this.mnudmqlsach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudlsach,
            this.mnudlsachmuon});
            this.mnudmqlsach.Name = "mnudmqlsach";
            this.mnudmqlsach.Size = new System.Drawing.Size(275, 26);
            this.mnudmqlsach.Text = "Danh muc quan ly Sach";
            // 
            // mnudlsach
            // 
            this.mnudlsach.Name = "mnudlsach";
            this.mnudlsach.Size = new System.Drawing.Size(214, 26);
            this.mnudlsach.Text = "Du lieu sach";
            this.mnudlsach.Click += new System.EventHandler(this.mnudlsach_Click);
            // 
            // mnudlsachmuon
            // 
            this.mnudlsachmuon.Name = "mnudlsachmuon";
            this.mnudlsachmuon.Size = new System.Drawing.Size(214, 26);
            this.mnudlsachmuon.Text = "Du lieu sach muon";
            this.mnudlsachmuon.Click += new System.EventHandler(this.mnudlsachmuon_Click);
            // 
            // mnudmqlphieu
            // 
            this.mnudmqlphieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudlphieumuon,
            this.mnudlphieunhactra});
            this.mnudmqlphieu.Name = "mnudmqlphieu";
            this.mnudmqlphieu.Size = new System.Drawing.Size(275, 26);
            this.mnudmqlphieu.Text = "Danh muc quan ly Phieu";
            // 
            // mnudlphieumuon
            // 
            this.mnudlphieumuon.Name = "mnudlphieumuon";
            this.mnudlphieumuon.Size = new System.Drawing.Size(236, 26);
            this.mnudlphieumuon.Text = "Du lieu Phieu muon";
            this.mnudlphieumuon.Click += new System.EventHandler(this.mnudlphieumuon_Click);
            // 
            // mnudlphieunhactra
            // 
            this.mnudlphieunhactra.Name = "mnudlphieunhactra";
            this.mnudlphieunhactra.Size = new System.Drawing.Size(236, 26);
            this.mnudlphieunhactra.Text = "Du lieu Phieu nhac tra";
            this.mnudlphieunhactra.Click += new System.EventHandler(this.mnudlphieunhactra_Click);
            // 
            // mnutimkiem
            // 
            this.mnutimkiem.Name = "mnutimkiem";
            this.mnutimkiem.Size = new System.Drawing.Size(148, 24);
            this.mnutimkiem.Text = "Tìm kiếm thong tin";
            this.mnutimkiem.Click += new System.EventHandler(this.mnutimkiem_Click);
            // 
            // mnuxuly
            // 
            this.mnuxuly.Name = "mnuxuly";
            this.mnuxuly.Size = new System.Drawing.Size(56, 24);
            this.mnuxuly.Text = "Xử lý";
            this.mnuxuly.Click += new System.EventHandler(this.mnuxuly_Click);
            // 
            // mnubaocao
            // 
            this.mnubaocao.Name = "mnubaocao";
            this.mnubaocao.Size = new System.Drawing.Size(77, 24);
            this.mnubaocao.Text = "Báo cáo";
            this.mnubaocao.Click += new System.EventHandler(this.mnubaocao_Click);
            // 
            // mnutrogiup
            // 
            this.mnutrogiup.Name = "mnutrogiup";
            this.mnutrogiup.Size = new System.Drawing.Size(78, 24);
            this.mnutrogiup.Text = "Trợ giup";
            this.mnutrogiup.Click += new System.EventHandler(this.mnutrogiup_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl1.Location = new System.Drawing.Point(334, 56);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(386, 55);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Quản lý thư viện";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 414);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(241, 27);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Giáo viên hướng dẫn";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(780, 414);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(245, 27);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Nhóm làm bài tập lớn";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(12, 447);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(216, 38);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "Phạm Văn Đồng";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(779, 447);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(115, 32);
            this.bunifuCustomLabel5.TabIndex = 5;
            this.bunifuCustomLabel5.Text = "Nhóm 10";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(285, 133);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(155, 35);
            this.bunifuCustomLabel6.TabIndex = 6;
            this.bunifuCustomLabel6.Text = "Tài khoản ";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(285, 198);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(137, 35);
            this.bunifuCustomLabel7.TabIndex = 7;
            this.bunifuCustomLabel7.Text = "Mật khẩu";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButton1.ButtonText = "Đăng nhập";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = global::BTL_QLThuvien_Csharp_Nhom10.Properties.Resources.accept_icon;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(328, 267);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Lime;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(94, 41);
            this.bunifuFlatButton1.TabIndex = 10;
            this.bunifuFlatButton1.Text = "Đăng nhập";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // ckhienthimk
            // 
            this.ckhienthimk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ckhienthimk.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ckhienthimk.Checked = true;
            this.ckhienthimk.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ckhienthimk.ForeColor = System.Drawing.Color.White;
            this.ckhienthimk.Location = new System.Drawing.Point(808, 213);
            this.ckhienthimk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckhienthimk.Name = "ckhienthimk";
            this.ckhienthimk.Size = new System.Drawing.Size(20, 20);
            this.ckhienthimk.TabIndex = 11;
            this.ckhienthimk.OnChange += new System.EventHandler(this.ckhienthimk_OnChange);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(835, 213);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(99, 17);
            this.bunifuCustomLabel8.TabIndex = 12;
            this.bunifuCustomLabel8.Text = "hiện password";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(49, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // lblthongbao
            // 
            this.lblthongbao.AutoSize = true;
            this.lblthongbao.Location = new System.Drawing.Point(211, 267);
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(0, 17);
            this.lblthongbao.TabIndex = 15;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(479, 211);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(296, 22);
            this.txtmatkhau.TabIndex = 16;
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(480, 145);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(296, 22);
            this.txttaikhoan.TabIndex = 17;
            // 
            // Giaodien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL_QLThuvien_Csharp_Nhom10.Properties.Resources._9320262_4144946;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1037, 488);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.lblthongbao);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.ckhienthimk);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Giaodien";
            this.Text = "Giao diện";
            this.Load += new System.EventHandler(this.Giaodien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCheckbox ckhienthimk;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnudn;
        private System.Windows.Forms.ToolStripMenuItem mnudk;
        private System.Windows.Forms.ToolStripMenuItem mnudx;
        private System.Windows.Forms.ToolStripMenuItem mnudanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnudmqlsv;
        private System.Windows.Forms.ToolStripMenuItem mnudmqlnv;
        private System.Windows.Forms.ToolStripMenuItem mnudmqlsach;
        private System.Windows.Forms.ToolStripMenuItem mnudlsach;
        private System.Windows.Forms.ToolStripMenuItem mnudlsachmuon;
        private System.Windows.Forms.ToolStripMenuItem mnudmqlphieu;
        private System.Windows.Forms.ToolStripMenuItem mnudlphieumuon;
        private System.Windows.Forms.ToolStripMenuItem mnudlphieunhactra;
        private System.Windows.Forms.ToolStripMenuItem mnutimkiem;
        private System.Windows.Forms.ToolStripMenuItem mnuxuly;
        private System.Windows.Forms.ToolStripMenuItem mnubaocao;
        private System.Windows.Forms.ToolStripMenuItem mnutrogiup;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblthongbao;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttaikhoan;
    }
}

