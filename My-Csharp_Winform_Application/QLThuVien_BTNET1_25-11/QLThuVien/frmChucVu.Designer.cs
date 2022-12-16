
namespace QLThuVien
{
    partial class frmChucVu
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnThoatChucVu = new System.Windows.Forms.Button();
            this.txtmachucvu = new System.Windows.Forms.TextBox();
            this.txtmanhanvienchucvu = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtgChucVu = new System.Windows.Forms.DataGridView();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lyDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctChucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._QLNhanVien_Net1_25_11DataSet = new QLThuVien._QLNhanVien_Net1_25_11DataSet();
            this.ctChucVuTableAdapter = new QLThuVien._QLNhanVien_Net1_25_11DataSetTableAdapters.ctChucVuTableAdapter();
            this.dtpngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.dtpngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtlydo = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluuchucvu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctChucVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._QLNhanVien_Net1_25_11DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(223, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(211, 29);
            this.bunifuCustomLabel1.TabIndex = 73;
            this.bunifuCustomLabel1.Text = "Danh mục Chức vụ";
            // 
            // btnThoatChucVu
            // 
            this.btnThoatChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoatChucVu.Location = new System.Drawing.Point(677, 393);
            this.btnThoatChucVu.Name = "btnThoatChucVu";
            this.btnThoatChucVu.Size = new System.Drawing.Size(98, 33);
            this.btnThoatChucVu.TabIndex = 72;
            this.btnThoatChucVu.Text = "Thoát";
            this.btnThoatChucVu.UseVisualStyleBackColor = false;
            this.btnThoatChucVu.Click += new System.EventHandler(this.btnThoatChucVu_Click);
            // 
            // txtmachucvu
            // 
            this.txtmachucvu.Location = new System.Drawing.Point(148, 320);
            this.txtmachucvu.Name = "txtmachucvu";
            this.txtmachucvu.Size = new System.Drawing.Size(150, 22);
            this.txtmachucvu.TabIndex = 71;
            // 
            // txtmanhanvienchucvu
            // 
            this.txtmanhanvienchucvu.Location = new System.Drawing.Point(148, 266);
            this.txtmanhanvienchucvu.Name = "txtmanhanvienchucvu";
            this.txtmanhanvienchucvu.Size = new System.Drawing.Size(150, 22);
            this.txtmanhanvienchucvu.TabIndex = 70;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(19, 320);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(80, 17);
            this.bunifuCustomLabel12.TabIndex = 69;
            this.bunifuCustomLabel12.Text = "Mã chức vụ";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(19, 266);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(93, 17);
            this.bunifuCustomLabel5.TabIndex = 68;
            this.bunifuCustomLabel5.Text = "Mã nhân viên";
            // 
            // dtgChucVu
            // 
            this.dtgChucVu.AllowUserToOrderColumns = true;
            this.dtgChucVu.AutoGenerateColumns = false;
            this.dtgChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVienDataGridViewTextBoxColumn,
            this.maCVDataGridViewTextBoxColumn,
            this.ngayBatDauDataGridViewTextBoxColumn,
            this.ngayKetThucDataGridViewTextBoxColumn,
            this.lyDoDataGridViewTextBoxColumn});
            this.dtgChucVu.DataSource = this.ctChucVuBindingSource;
            this.dtgChucVu.Location = new System.Drawing.Point(12, 41);
            this.dtgChucVu.Name = "dtgChucVu";
            this.dtgChucVu.RowHeadersWidth = 51;
            this.dtgChucVu.RowTemplate.Height = 24;
            this.dtgChucVu.Size = new System.Drawing.Size(681, 190);
            this.dtgChucVu.TabIndex = 67;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            this.maNhanVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // maCVDataGridViewTextBoxColumn
            // 
            this.maCVDataGridViewTextBoxColumn.DataPropertyName = "MaCV";
            this.maCVDataGridViewTextBoxColumn.HeaderText = "MaCV";
            this.maCVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maCVDataGridViewTextBoxColumn.Name = "maCVDataGridViewTextBoxColumn";
            this.maCVDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayBatDauDataGridViewTextBoxColumn
            // 
            this.ngayBatDauDataGridViewTextBoxColumn.DataPropertyName = "NgayBatDau";
            this.ngayBatDauDataGridViewTextBoxColumn.HeaderText = "NgayBatDau";
            this.ngayBatDauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayBatDauDataGridViewTextBoxColumn.Name = "ngayBatDauDataGridViewTextBoxColumn";
            this.ngayBatDauDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayKetThucDataGridViewTextBoxColumn
            // 
            this.ngayKetThucDataGridViewTextBoxColumn.DataPropertyName = "NgayKetThuc";
            this.ngayKetThucDataGridViewTextBoxColumn.HeaderText = "NgayKetThuc";
            this.ngayKetThucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayKetThucDataGridViewTextBoxColumn.Name = "ngayKetThucDataGridViewTextBoxColumn";
            this.ngayKetThucDataGridViewTextBoxColumn.Width = 125;
            // 
            // lyDoDataGridViewTextBoxColumn
            // 
            this.lyDoDataGridViewTextBoxColumn.DataPropertyName = "LyDo";
            this.lyDoDataGridViewTextBoxColumn.HeaderText = "LyDo";
            this.lyDoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lyDoDataGridViewTextBoxColumn.Name = "lyDoDataGridViewTextBoxColumn";
            this.lyDoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ctChucVuBindingSource
            // 
            this.ctChucVuBindingSource.DataMember = "ctChucVu";
            this.ctChucVuBindingSource.DataSource = this._QLNhanVien_Net1_25_11DataSet;
            // 
            // _QLNhanVien_Net1_25_11DataSet
            // 
            this._QLNhanVien_Net1_25_11DataSet.DataSetName = "_QLNhanVien_Net1_25_11DataSet";
            this._QLNhanVien_Net1_25_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ctChucVuTableAdapter
            // 
            this.ctChucVuTableAdapter.ClearBeforeFill = true;
            // 
            // dtpngaybatdau
            // 
            this.dtpngaybatdau.Location = new System.Drawing.Point(454, 260);
            this.dtpngaybatdau.Name = "dtpngaybatdau";
            this.dtpngaybatdau.Size = new System.Drawing.Size(200, 22);
            this.dtpngaybatdau.TabIndex = 74;
            // 
            // dtpngayketthuc
            // 
            this.dtpngayketthuc.Location = new System.Drawing.Point(454, 320);
            this.dtpngayketthuc.Name = "dtpngayketthuc";
            this.dtpngayketthuc.Size = new System.Drawing.Size(200, 22);
            this.dtpngayketthuc.TabIndex = 75;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(339, 265);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(93, 17);
            this.bunifuCustomLabel2.TabIndex = 76;
            this.bunifuCustomLabel2.Text = "Ngày bắt đầu";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(339, 320);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(95, 17);
            this.bunifuCustomLabel3.TabIndex = 77;
            this.bunifuCustomLabel3.Text = "Ngày kết thúc";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(339, 377);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(43, 17);
            this.bunifuCustomLabel4.TabIndex = 78;
            this.bunifuCustomLabel4.Text = "Lý do";
            // 
            // txtlydo
            // 
            this.txtlydo.Location = new System.Drawing.Point(454, 377);
            this.txtlydo.Name = "txtlydo";
            this.txtlydo.Size = new System.Drawing.Size(200, 22);
            this.txtlydo.TabIndex = 79;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(19, 382);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(86, 17);
            this.bunifuCustomLabel6.TabIndex = 80;
            this.bunifuCustomLabel6.Text = "Tên chức vụ";
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(148, 382);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(150, 22);
            this.txtchucvu.TabIndex = 81;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(700, 61);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 82;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(700, 118);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 83;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluuchucvu
            // 
            this.btnluuchucvu.Location = new System.Drawing.Point(700, 176);
            this.btnluuchucvu.Name = "btnluuchucvu";
            this.btnluuchucvu.Size = new System.Drawing.Size(75, 23);
            this.btnluuchucvu.TabIndex = 84;
            this.btnluuchucvu.Text = "Lưu";
            this.btnluuchucvu.UseVisualStyleBackColor = true;
            this.btnluuchucvu.Click += new System.EventHandler(this.btnluuchucvu_Click);
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.btnluuchucvu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtchucvu);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.txtlydo);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.dtpngayketthuc);
            this.Controls.Add(this.dtpngaybatdau);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnThoatChucVu);
            this.Controls.Add(this.txtmachucvu);
            this.Controls.Add(this.txtmanhanvienchucvu);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.dtgChucVu);
            this.Name = "frmChucVu";
            this.Text = "frmChucVu";
            this.Load += new System.EventHandler(this.frmChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctChucVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._QLNhanVien_Net1_25_11DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button btnThoatChucVu;
        private System.Windows.Forms.TextBox txtmachucvu;
        private System.Windows.Forms.TextBox txtmanhanvienchucvu;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.DataGridView dtgChucVu;
        private _QLNhanVien_Net1_25_11DataSet _QLNhanVien_Net1_25_11DataSet;
        private System.Windows.Forms.BindingSource ctChucVuBindingSource;
        private _QLNhanVien_Net1_25_11DataSetTableAdapters.ctChucVuTableAdapter ctChucVuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lyDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpngaybatdau;
        private System.Windows.Forms.DateTimePicker dtpngayketthuc;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TextBox txtlydo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluuchucvu;
    }
}