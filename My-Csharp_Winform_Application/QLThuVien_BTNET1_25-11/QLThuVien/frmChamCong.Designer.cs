
namespace QLThuVien
{
    partial class frmChamCong
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
            this.btnThoatChamcong = new System.Windows.Forms.Button();
            this.dtpngaychamcong = new System.Windows.Forms.DateTimePicker();
            this.txtmanhanvienchamcong = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtgChamcong = new System.Windows.Forms.DataGridView();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._QLNhanVien_Net1_25_11DataSet = new QLThuVien._QLNhanVien_Net1_25_11DataSet();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txttinhtrangchamcong = new System.Windows.Forms.TextBox();
            this.chamCongTableAdapter = new QLThuVien._QLNhanVien_Net1_25_11DataSetTableAdapters.ChamCongTableAdapter();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnsuachamcong = new System.Windows.Forms.Button();
            this.btnluuchamcong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamcong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._QLNhanVien_Net1_25_11DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoatChamcong
            // 
            this.btnThoatChamcong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoatChamcong.Location = new System.Drawing.Point(807, 289);
            this.btnThoatChamcong.Name = "btnThoatChamcong";
            this.btnThoatChamcong.Size = new System.Drawing.Size(98, 33);
            this.btnThoatChamcong.TabIndex = 57;
            this.btnThoatChamcong.Text = "Thoát";
            this.btnThoatChamcong.UseVisualStyleBackColor = false;
            this.btnThoatChamcong.Click += new System.EventHandler(this.btnThoatChamcong_Click);
            // 
            // dtpngaychamcong
            // 
            this.dtpngaychamcong.Location = new System.Drawing.Point(160, 167);
            this.dtpngaychamcong.Name = "dtpngaychamcong";
            this.dtpngaychamcong.Size = new System.Drawing.Size(150, 22);
            this.dtpngaychamcong.TabIndex = 56;
            // 
            // txtmanhanvienchamcong
            // 
            this.txtmanhanvienchamcong.Location = new System.Drawing.Point(160, 102);
            this.txtmanhanvienchamcong.Name = "txtmanhanvienchamcong";
            this.txtmanhanvienchamcong.Size = new System.Drawing.Size(150, 22);
            this.txtmanhanvienchamcong.TabIndex = 50;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(26, 172);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(114, 17);
            this.bunifuCustomLabel7.TabIndex = 40;
            this.bunifuCustomLabel7.Text = "Ngày chấm công";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(26, 107);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(93, 17);
            this.bunifuCustomLabel5.TabIndex = 38;
            this.bunifuCustomLabel5.Text = "Mã nhân viên";
            // 
            // dtgChamcong
            // 
            this.dtgChamcong.AutoGenerateColumns = false;
            this.dtgChamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChamcong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVienDataGridViewTextBoxColumn,
            this.ngayDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn});
            this.dtgChamcong.DataSource = this.chamCongBindingSource;
            this.dtgChamcong.Location = new System.Drawing.Point(350, 12);
            this.dtgChamcong.Name = "dtgChamcong";
            this.dtgChamcong.RowHeadersWidth = 51;
            this.dtgChamcong.RowTemplate.Height = 24;
            this.dtgChamcong.Size = new System.Drawing.Size(429, 310);
            this.dtgChamcong.TabIndex = 33;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            this.maNhanVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayDataGridViewTextBoxColumn
            // 
            this.ngayDataGridViewTextBoxColumn.DataPropertyName = "Ngay";
            this.ngayDataGridViewTextBoxColumn.HeaderText = "Ngay";
            this.ngayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayDataGridViewTextBoxColumn.Name = "ngayDataGridViewTextBoxColumn";
            this.ngayDataGridViewTextBoxColumn.Width = 125;
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            this.tinhTrangDataGridViewTextBoxColumn.Width = 125;
            // 
            // chamCongBindingSource
            // 
            this.chamCongBindingSource.DataMember = "ChamCong";
            this.chamCongBindingSource.DataSource = this._QLNhanVien_Net1_25_11DataSet;
            // 
            // _QLNhanVien_Net1_25_11DataSet
            // 
            this._QLNhanVien_Net1_25_11DataSet.DataSetName = "_QLNhanVien_Net1_25_11DataSet";
            this._QLNhanVien_Net1_25_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(26, 231);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(73, 17);
            this.bunifuCustomLabel12.TabIndex = 45;
            this.bunifuCustomLabel12.Text = "Tình trạng";
            // 
            // txttinhtrangchamcong
            // 
            this.txttinhtrangchamcong.Location = new System.Drawing.Point(160, 228);
            this.txttinhtrangchamcong.Name = "txttinhtrangchamcong";
            this.txttinhtrangchamcong.Size = new System.Drawing.Size(150, 22);
            this.txttinhtrangchamcong.TabIndex = 55;
            // 
            // chamCongTableAdapter
            // 
            this.chamCongTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(24, 32);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(243, 29);
            this.bunifuCustomLabel1.TabIndex = 67;
            this.bunifuCustomLabel1.Text = "Danh mục chấm công";
            // 
            // btnsuachamcong
            // 
            this.btnsuachamcong.Location = new System.Drawing.Point(62, 289);
            this.btnsuachamcong.Name = "btnsuachamcong";
            this.btnsuachamcong.Size = new System.Drawing.Size(90, 33);
            this.btnsuachamcong.TabIndex = 69;
            this.btnsuachamcong.Text = "Sửa";
            this.btnsuachamcong.UseVisualStyleBackColor = true;
            this.btnsuachamcong.Click += new System.EventHandler(this.btnsuachamcong_Click);
            // 
            // btnluuchamcong
            // 
            this.btnluuchamcong.Location = new System.Drawing.Point(202, 289);
            this.btnluuchamcong.Name = "btnluuchamcong";
            this.btnluuchamcong.Size = new System.Drawing.Size(90, 33);
            this.btnluuchamcong.TabIndex = 70;
            this.btnluuchamcong.Text = "Lưu";
            this.btnluuchamcong.UseVisualStyleBackColor = true;
            this.btnluuchamcong.Click += new System.EventHandler(this.btnluuchamcong_Click);
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 343);
            this.Controls.Add(this.btnluuchamcong);
            this.Controls.Add(this.btnsuachamcong);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnThoatChamcong);
            this.Controls.Add(this.dtpngaychamcong);
            this.Controls.Add(this.txttinhtrangchamcong);
            this.Controls.Add(this.txtmanhanvienchamcong);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.dtgChamcong);
            this.Name = "frmChamCong";
            this.Text = "frmChamCong";
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamcong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._QLNhanVien_Net1_25_11DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoatChamcong;
        private System.Windows.Forms.DateTimePicker dtpngaychamcong;
        private System.Windows.Forms.TextBox txtmanhanvienchamcong;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.DataGridView dtgChamcong;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.TextBox txttinhtrangchamcong;
        private _QLNhanVien_Net1_25_11DataSet _QLNhanVien_Net1_25_11DataSet;
        private System.Windows.Forms.BindingSource chamCongBindingSource;
        private _QLNhanVien_Net1_25_11DataSetTableAdapters.ChamCongTableAdapter chamCongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button btnsuachamcong;
        private System.Windows.Forms.Button btnluuchamcong;
    }
}