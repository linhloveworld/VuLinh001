
namespace QLThuVien
{
    partial class frmThuongPhat
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
            this.dtgthuongphat = new System.Windows.Forms.DataGridView();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lyDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuongPhatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._QLNhanVien_Net1_25_11DataSet = new QLThuVien._QLNhanVien_Net1_25_11DataSet();
            this.thuongPhatTableAdapter = new QLThuVien._QLNhanVien_Net1_25_11DataSetTableAdapters.ThuongPhatTableAdapter();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txttenphongban = new System.Windows.Forms.TextBox();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtloai = new System.Windows.Forms.TextBox();
            this.txttien = new System.Windows.Forms.TextBox();
            this.txtlydo = new System.Windows.Forms.TextBox();
            this.dtpngay = new System.Windows.Forms.DateTimePicker();
            this.btnthoatThuongPhat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnluuthuongphat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgthuongphat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuongPhatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._QLNhanVien_Net1_25_11DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgthuongphat
            // 
            this.dtgthuongphat.AutoGenerateColumns = false;
            this.dtgthuongphat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgthuongphat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVienDataGridViewTextBoxColumn,
            this.loaiDataGridViewTextBoxColumn,
            this.tienDataGridViewTextBoxColumn,
            this.lyDoDataGridViewTextBoxColumn,
            this.ngayDataGridViewTextBoxColumn});
            this.dtgthuongphat.DataSource = this.thuongPhatBindingSource;
            this.dtgthuongphat.Location = new System.Drawing.Point(48, 59);
            this.dtgthuongphat.Name = "dtgthuongphat";
            this.dtgthuongphat.RowHeadersWidth = 51;
            this.dtgthuongphat.RowTemplate.Height = 24;
            this.dtgthuongphat.Size = new System.Drawing.Size(682, 246);
            this.dtgthuongphat.TabIndex = 0;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            this.maNhanVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // loaiDataGridViewTextBoxColumn
            // 
            this.loaiDataGridViewTextBoxColumn.DataPropertyName = "Loai";
            this.loaiDataGridViewTextBoxColumn.HeaderText = "Loai";
            this.loaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiDataGridViewTextBoxColumn.Name = "loaiDataGridViewTextBoxColumn";
            this.loaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienDataGridViewTextBoxColumn
            // 
            this.tienDataGridViewTextBoxColumn.DataPropertyName = "Tien";
            this.tienDataGridViewTextBoxColumn.HeaderText = "Tien";
            this.tienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienDataGridViewTextBoxColumn.Name = "tienDataGridViewTextBoxColumn";
            this.tienDataGridViewTextBoxColumn.Width = 125;
            // 
            // lyDoDataGridViewTextBoxColumn
            // 
            this.lyDoDataGridViewTextBoxColumn.DataPropertyName = "LyDo";
            this.lyDoDataGridViewTextBoxColumn.HeaderText = "LyDo";
            this.lyDoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lyDoDataGridViewTextBoxColumn.Name = "lyDoDataGridViewTextBoxColumn";
            this.lyDoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayDataGridViewTextBoxColumn
            // 
            this.ngayDataGridViewTextBoxColumn.DataPropertyName = "Ngay";
            this.ngayDataGridViewTextBoxColumn.HeaderText = "Ngay";
            this.ngayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayDataGridViewTextBoxColumn.Name = "ngayDataGridViewTextBoxColumn";
            this.ngayDataGridViewTextBoxColumn.Width = 125;
            // 
            // thuongPhatBindingSource
            // 
            this.thuongPhatBindingSource.DataMember = "ThuongPhat";
            this.thuongPhatBindingSource.DataSource = this._QLNhanVien_Net1_25_11DataSet;
            // 
            // _QLNhanVien_Net1_25_11DataSet
            // 
            this._QLNhanVien_Net1_25_11DataSet.DataSetName = "_QLNhanVien_Net1_25_11DataSet";
            this._QLNhanVien_Net1_25_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thuongPhatTableAdapter
            // 
            this.thuongPhatTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(256, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(261, 29);
            this.bunifuCustomLabel1.TabIndex = 74;
            this.bunifuCustomLabel1.Text = "Danh mục Thưởng phạt";
            // 
            // txttenphongban
            // 
            this.txttenphongban.Location = new System.Drawing.Point(158, 368);
            this.txttenphongban.Name = "txttenphongban";
            this.txttenphongban.Size = new System.Drawing.Size(150, 22);
            this.txttenphongban.TabIndex = 78;
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(158, 324);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(150, 22);
            this.txtmanhanvien.TabIndex = 77;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(22, 373);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(35, 17);
            this.bunifuCustomLabel12.TabIndex = 76;
            this.bunifuCustomLabel12.Text = "Loại";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(22, 329);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(93, 17);
            this.bunifuCustomLabel5.TabIndex = 75;
            this.bunifuCustomLabel5.Text = "Mã nhân viên";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(355, 329);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(35, 17);
            this.bunifuCustomLabel2.TabIndex = 79;
            this.bunifuCustomLabel2.Text = "Loại";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(354, 373);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(36, 17);
            this.bunifuCustomLabel3.TabIndex = 80;
            this.bunifuCustomLabel3.Text = "Tiền";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(549, 329);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(43, 17);
            this.bunifuCustomLabel4.TabIndex = 81;
            this.bunifuCustomLabel4.Text = "Lý do";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(549, 373);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(41, 17);
            this.bunifuCustomLabel6.TabIndex = 82;
            this.bunifuCustomLabel6.Text = "Ngày";
            // 
            // txtloai
            // 
            this.txtloai.Location = new System.Drawing.Point(405, 324);
            this.txtloai.Name = "txtloai";
            this.txtloai.Size = new System.Drawing.Size(124, 22);
            this.txtloai.TabIndex = 83;
            // 
            // txttien
            // 
            this.txttien.Location = new System.Drawing.Point(405, 368);
            this.txttien.Name = "txttien";
            this.txttien.Size = new System.Drawing.Size(124, 22);
            this.txttien.TabIndex = 84;
            // 
            // txtlydo
            // 
            this.txtlydo.Location = new System.Drawing.Point(611, 324);
            this.txtlydo.Name = "txtlydo";
            this.txtlydo.Size = new System.Drawing.Size(150, 22);
            this.txtlydo.TabIndex = 85;
            // 
            // dtpngay
            // 
            this.dtpngay.Location = new System.Drawing.Point(611, 373);
            this.dtpngay.Name = "dtpngay";
            this.dtpngay.Size = new System.Drawing.Size(150, 22);
            this.dtpngay.TabIndex = 86;
            // 
            // btnthoatThuongPhat
            // 
            this.btnthoatThuongPhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnthoatThuongPhat.Location = new System.Drawing.Point(795, 400);
            this.btnthoatThuongPhat.Name = "btnthoatThuongPhat";
            this.btnthoatThuongPhat.Size = new System.Drawing.Size(98, 33);
            this.btnthoatThuongPhat.TabIndex = 87;
            this.btnthoatThuongPhat.Text = "Thoát";
            this.btnthoatThuongPhat.UseVisualStyleBackColor = false;
            this.btnthoatThuongPhat.Click += new System.EventHandler(this.btnthoatThuongPhat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 88;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(795, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 89;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnluuthuongphat
            // 
            this.btnluuthuongphat.Location = new System.Drawing.Point(795, 282);
            this.btnluuthuongphat.Name = "btnluuthuongphat";
            this.btnluuthuongphat.Size = new System.Drawing.Size(75, 23);
            this.btnluuthuongphat.TabIndex = 90;
            this.btnluuthuongphat.Text = "Luu";
            this.btnluuthuongphat.UseVisualStyleBackColor = true;
            this.btnluuthuongphat.Click += new System.EventHandler(this.btnluuthuongphat_Click);
            // 
            // frmThuongPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 437);
            this.Controls.Add(this.btnluuthuongphat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnthoatThuongPhat);
            this.Controls.Add(this.dtpngay);
            this.Controls.Add(this.txtlydo);
            this.Controls.Add(this.txttien);
            this.Controls.Add(this.txtloai);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txttenphongban);
            this.Controls.Add(this.txtmanhanvien);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dtgthuongphat);
            this.Name = "frmThuongPhat";
            this.Text = "frmThuongPhat";
            this.Load += new System.EventHandler(this.frmThuongPhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgthuongphat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuongPhatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._QLNhanVien_Net1_25_11DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgthuongphat;
        private _QLNhanVien_Net1_25_11DataSet _QLNhanVien_Net1_25_11DataSet;
        private System.Windows.Forms.BindingSource thuongPhatBindingSource;
        private _QLNhanVien_Net1_25_11DataSetTableAdapters.ThuongPhatTableAdapter thuongPhatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lyDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox txttenphongban;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.TextBox txtloai;
        private System.Windows.Forms.TextBox txttien;
        private System.Windows.Forms.TextBox txtlydo;
        private System.Windows.Forms.DateTimePicker dtpngay;
        private System.Windows.Forms.Button btnthoatThuongPhat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnluuthuongphat;
    }
}