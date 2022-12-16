
namespace QLThuVien
{
    partial class frmDanhmucNhanvien
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
            this.btnthem = new System.Windows.Forms.Button();
            this.btnluunhanvien = new System.Windows.Forms.Button();
            this.btnsuanhanvien = new System.Windows.Forms.Button();
            this.dtgNhanVien = new System.Windows.Forms.DataGridView();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heSoLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soCMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhDoHVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tTHonNhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._QLNhanVien_Net1_25_11DataSet = new QLThuVien._QLNhanVien_Net1_25_11DataSet();
            this.qLNhanVienNet12511DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmaphongban = new System.Windows.Forms.TextBox();
            this.txtmahopdong = new System.Windows.Forms.TextBox();
            this.txthesoluong = new System.Windows.Forms.TextBox();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.txtsocmnd = new System.Windows.Forms.TextBox();
            this.txtsodienthoai = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttinhtranghonnhan = new System.Windows.Forms.TextBox();
            this.dtpngaysinhnv = new System.Windows.Forms.DateTimePicker();
            this.btnThoatNhanVien = new System.Windows.Forms.Button();
            this.cbogioitinhnv = new System.Windows.Forms.ComboBox();
            this.nhanVienTableAdapter = new QLThuVien._QLNhanVien_Net1_25_11DataSetTableAdapters.NhanVienTableAdapter();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._QLNhanVien_Net1_25_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanVienNet12511DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(880, 19);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(78, 28);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnluunhanvien
            // 
            this.btnluunhanvien.Location = new System.Drawing.Point(880, 124);
            this.btnluunhanvien.Name = "btnluunhanvien";
            this.btnluunhanvien.Size = new System.Drawing.Size(78, 27);
            this.btnluunhanvien.TabIndex = 1;
            this.btnluunhanvien.Text = "Lưu";
            this.btnluunhanvien.UseVisualStyleBackColor = true;
            this.btnluunhanvien.Click += new System.EventHandler(this.btnluunhanvien_Click);
            // 
            // btnsuanhanvien
            // 
            this.btnsuanhanvien.Location = new System.Drawing.Point(880, 72);
            this.btnsuanhanvien.Name = "btnsuanhanvien";
            this.btnsuanhanvien.Size = new System.Drawing.Size(78, 27);
            this.btnsuanhanvien.TabIndex = 2;
            this.btnsuanhanvien.Text = "Sửa";
            this.btnsuanhanvien.UseVisualStyleBackColor = true;
            this.btnsuanhanvien.Click += new System.EventHandler(this.btnsuanhanvien_Click);
            // 
            // dtgNhanVien
            // 
            this.dtgNhanVien.AutoGenerateColumns = false;
            this.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVienDataGridViewTextBoxColumn,
            this.maPBDataGridViewTextBoxColumn,
            this.maHDDataGridViewTextBoxColumn,
            this.heSoLuongDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.soCMDataGridViewTextBoxColumn,
            this.dienThoaiDataGridViewTextBoxColumn,
            this.trinhDoHVDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.hinhDataGridViewImageColumn,
            this.tTHonNhanDataGridViewTextBoxColumn});
            this.dtgNhanVien.DataSource = this.nhanVienBindingSource;
            this.dtgNhanVien.Location = new System.Drawing.Point(12, 57);
            this.dtgNhanVien.Name = "dtgNhanVien";
            this.dtgNhanVien.RowHeadersWidth = 51;
            this.dtgNhanVien.RowTemplate.Height = 24;
            this.dtgNhanVien.Size = new System.Drawing.Size(283, 310);
            this.dtgNhanVien.TabIndex = 3;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            this.maNhanVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // maPBDataGridViewTextBoxColumn
            // 
            this.maPBDataGridViewTextBoxColumn.DataPropertyName = "MaPB";
            this.maPBDataGridViewTextBoxColumn.HeaderText = "MaPB";
            this.maPBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPBDataGridViewTextBoxColumn.Name = "maPBDataGridViewTextBoxColumn";
            this.maPBDataGridViewTextBoxColumn.Width = 125;
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "MaHD";
            this.maHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.Width = 125;
            // 
            // heSoLuongDataGridViewTextBoxColumn
            // 
            this.heSoLuongDataGridViewTextBoxColumn.DataPropertyName = "HeSoLuong";
            this.heSoLuongDataGridViewTextBoxColumn.HeaderText = "HeSoLuong";
            this.heSoLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.heSoLuongDataGridViewTextBoxColumn.Name = "heSoLuongDataGridViewTextBoxColumn";
            this.heSoLuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // soCMDataGridViewTextBoxColumn
            // 
            this.soCMDataGridViewTextBoxColumn.DataPropertyName = "SoCM";
            this.soCMDataGridViewTextBoxColumn.HeaderText = "SoCM";
            this.soCMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soCMDataGridViewTextBoxColumn.Name = "soCMDataGridViewTextBoxColumn";
            this.soCMDataGridViewTextBoxColumn.Width = 125;
            // 
            // dienThoaiDataGridViewTextBoxColumn
            // 
            this.dienThoaiDataGridViewTextBoxColumn.DataPropertyName = "DienThoai";
            this.dienThoaiDataGridViewTextBoxColumn.HeaderText = "DienThoai";
            this.dienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dienThoaiDataGridViewTextBoxColumn.Name = "dienThoaiDataGridViewTextBoxColumn";
            this.dienThoaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // trinhDoHVDataGridViewTextBoxColumn
            // 
            this.trinhDoHVDataGridViewTextBoxColumn.DataPropertyName = "TrinhDoHV";
            this.trinhDoHVDataGridViewTextBoxColumn.HeaderText = "TrinhDoHV";
            this.trinhDoHVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trinhDoHVDataGridViewTextBoxColumn.Name = "trinhDoHVDataGridViewTextBoxColumn";
            this.trinhDoHVDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // hinhDataGridViewImageColumn
            // 
            this.hinhDataGridViewImageColumn.DataPropertyName = "Hinh";
            this.hinhDataGridViewImageColumn.HeaderText = "Hinh";
            this.hinhDataGridViewImageColumn.MinimumWidth = 6;
            this.hinhDataGridViewImageColumn.Name = "hinhDataGridViewImageColumn";
            this.hinhDataGridViewImageColumn.Width = 125;
            // 
            // tTHonNhanDataGridViewTextBoxColumn
            // 
            this.tTHonNhanDataGridViewTextBoxColumn.DataPropertyName = "TTHonNhan";
            this.tTHonNhanDataGridViewTextBoxColumn.HeaderText = "TTHonNhan";
            this.tTHonNhanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tTHonNhanDataGridViewTextBoxColumn.Name = "tTHonNhanDataGridViewTextBoxColumn";
            this.tTHonNhanDataGridViewTextBoxColumn.Width = 125;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this._QLNhanVien_Net1_25_11DataSet;
            // 
            // _QLNhanVien_Net1_25_11DataSet
            // 
            this._QLNhanVien_Net1_25_11DataSet.DataSetName = "_QLNhanVien_Net1_25_11DataSet";
            this._QLNhanVien_Net1_25_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNhanVienNet12511DataSetBindingSource
            // 
            this.qLNhanVienNet12511DataSetBindingSource.DataSource = this._QLNhanVien_Net1_25_11DataSet;
            this.qLNhanVienNet12511DataSetBindingSource.Position = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(301, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(99, 17);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Tên nhân viên";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(301, 72);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(99, 17);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Mã phòng ban";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(301, 129);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(91, 17);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "Mã hợp đồng";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(301, 188);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(84, 17);
            this.bunifuCustomLabel4.TabIndex = 7;
            this.bunifuCustomLabel4.Text = "Hệ số lương";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(301, 246);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(93, 17);
            this.bunifuCustomLabel5.TabIndex = 8;
            this.bunifuCustomLabel5.Text = "Mã nhân viên";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(301, 312);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(60, 17);
            this.bunifuCustomLabel6.TabIndex = 9;
            this.bunifuCustomLabel6.Text = "Giới tính";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(609, 19);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(71, 17);
            this.bunifuCustomLabel7.TabIndex = 10;
            this.bunifuCustomLabel7.Text = "Ngày sinh";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(609, 72);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(69, 17);
            this.bunifuCustomLabel8.TabIndex = 11;
            this.bunifuCustomLabel8.Text = "Số CMND";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(609, 129);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(91, 17);
            this.bunifuCustomLabel9.TabIndex = 12;
            this.bunifuCustomLabel9.Text = "Số điện thoại";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(609, 188);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(51, 17);
            this.bunifuCustomLabel10.TabIndex = 13;
            this.bunifuCustomLabel10.Text = "Địa chỉ";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(609, 246);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(42, 17);
            this.bunifuCustomLabel11.TabIndex = 14;
            this.bunifuCustomLabel11.Text = "Email";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(609, 307);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(137, 17);
            this.bunifuCustomLabel12.TabIndex = 15;
            this.bunifuCustomLabel12.Text = "Tình trạnh hôn nhân";
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(417, 13);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(150, 22);
            this.txttennv.TabIndex = 16;
            // 
            // txtmaphongban
            // 
            this.txtmaphongban.Location = new System.Drawing.Point(417, 69);
            this.txtmaphongban.Name = "txtmaphongban";
            this.txtmaphongban.Size = new System.Drawing.Size(150, 22);
            this.txtmaphongban.TabIndex = 17;
            // 
            // txtmahopdong
            // 
            this.txtmahopdong.Location = new System.Drawing.Point(417, 129);
            this.txtmahopdong.Name = "txtmahopdong";
            this.txtmahopdong.Size = new System.Drawing.Size(150, 22);
            this.txtmahopdong.TabIndex = 18;
            // 
            // txthesoluong
            // 
            this.txthesoluong.Location = new System.Drawing.Point(417, 188);
            this.txthesoluong.Name = "txthesoluong";
            this.txthesoluong.Size = new System.Drawing.Size(150, 22);
            this.txthesoluong.TabIndex = 19;
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(417, 246);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(150, 22);
            this.txtmanhanvien.TabIndex = 20;
            // 
            // txtsocmnd
            // 
            this.txtsocmnd.Location = new System.Drawing.Point(704, 67);
            this.txtsocmnd.Name = "txtsocmnd";
            this.txtsocmnd.Size = new System.Drawing.Size(150, 22);
            this.txtsocmnd.TabIndex = 22;
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.Location = new System.Drawing.Point(704, 124);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(150, 22);
            this.txtsodienthoai.TabIndex = 23;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(704, 183);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(150, 22);
            this.txtdiachi.TabIndex = 24;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(704, 246);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(150, 22);
            this.txtemail.TabIndex = 25;
            // 
            // txttinhtranghonnhan
            // 
            this.txttinhtranghonnhan.Location = new System.Drawing.Point(752, 304);
            this.txttinhtranghonnhan.Name = "txttinhtranghonnhan";
            this.txttinhtranghonnhan.Size = new System.Drawing.Size(102, 22);
            this.txttinhtranghonnhan.TabIndex = 26;
            // 
            // dtpngaysinhnv
            // 
            this.dtpngaysinhnv.Location = new System.Drawing.Point(687, 13);
            this.dtpngaysinhnv.Name = "dtpngaysinhnv";
            this.dtpngaysinhnv.Size = new System.Drawing.Size(167, 22);
            this.dtpngaysinhnv.TabIndex = 27;
            // 
            // btnThoatNhanVien
            // 
            this.btnThoatNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoatNhanVien.Location = new System.Drawing.Point(860, 344);
            this.btnThoatNhanVien.Name = "btnThoatNhanVien";
            this.btnThoatNhanVien.Size = new System.Drawing.Size(98, 33);
            this.btnThoatNhanVien.TabIndex = 28;
            this.btnThoatNhanVien.Text = "Thoát";
            this.btnThoatNhanVien.UseVisualStyleBackColor = false;
            this.btnThoatNhanVien.Click += new System.EventHandler(this.btnThoatNhanVien_Click);
            // 
            // cbogioitinhnv
            // 
            this.cbogioitinhnv.FormattingEnabled = true;
            this.cbogioitinhnv.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbogioitinhnv.Location = new System.Drawing.Point(417, 307);
            this.cbogioitinhnv.Name = "cbogioitinhnv";
            this.cbogioitinhnv.Size = new System.Drawing.Size(150, 24);
            this.cbogioitinhnv.TabIndex = 29;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(12, 6);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(228, 29);
            this.bunifuCustomLabel13.TabIndex = 67;
            this.bunifuCustomLabel13.Text = "Danh mục nhân viên";
            // 
            // frmDanhmucNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 379);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.cbogioitinhnv);
            this.Controls.Add(this.btnThoatNhanVien);
            this.Controls.Add(this.dtpngaysinhnv);
            this.Controls.Add(this.txttinhtranghonnhan);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtsodienthoai);
            this.Controls.Add(this.txtsocmnd);
            this.Controls.Add(this.txtmanhanvien);
            this.Controls.Add(this.txthesoluong);
            this.Controls.Add(this.txtmahopdong);
            this.Controls.Add(this.txtmaphongban);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dtgNhanVien);
            this.Controls.Add(this.btnsuanhanvien);
            this.Controls.Add(this.btnluunhanvien);
            this.Controls.Add(this.btnthem);
            this.Name = "frmDanhmucNhanvien";
            this.Text = "frmDanhmucNhanvien";
            this.Load += new System.EventHandler(this.frmDanhmucNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._QLNhanVien_Net1_25_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhanVienNet12511DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnluunhanvien;
        private System.Windows.Forms.Button btnsuanhanvien;
        private System.Windows.Forms.DataGridView dtgNhanVien;
        private System.Windows.Forms.BindingSource qLNhanVienNet12511DataSetBindingSource;
        private _QLNhanVien_Net1_25_11DataSet _QLNhanVien_Net1_25_11DataSet;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmaphongban;
        private System.Windows.Forms.TextBox txtmahopdong;
        private System.Windows.Forms.TextBox txthesoluong;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.TextBox txtsocmnd;
        private System.Windows.Forms.TextBox txtsodienthoai;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttinhtranghonnhan;
        private System.Windows.Forms.DateTimePicker dtpngaysinhnv;
        private System.Windows.Forms.Button btnThoatNhanVien;
        private System.Windows.Forms.ComboBox cbogioitinhnv;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private _QLNhanVien_Net1_25_11DataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heSoLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhDoHVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTHonNhanDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
    }
}