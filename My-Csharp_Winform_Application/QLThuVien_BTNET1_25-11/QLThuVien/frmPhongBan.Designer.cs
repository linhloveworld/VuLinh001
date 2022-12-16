
namespace QLThuVien
{
    partial class frmPhongBan
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
            this.btnThoatphongban = new System.Windows.Forms.Button();
            this.txttenphongban = new System.Windows.Forms.TextBox();
            this.txtmaphongban = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtgPhongBan = new System.Windows.Forms.DataGridView();
            this.maPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._QLNhanVien_Net1_25_11DataSet = new QLThuVien._QLNhanVien_Net1_25_11DataSet();
            this.phongBanTableAdapter = new QLThuVien._QLNhanVien_Net1_25_11DataSetTableAdapters.PhongBanTableAdapter();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._QLNhanVien_Net1_25_11DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoatphongban
            // 
            this.btnThoatphongban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoatphongban.Location = new System.Drawing.Point(703, 229);
            this.btnThoatphongban.Name = "btnThoatphongban";
            this.btnThoatphongban.Size = new System.Drawing.Size(98, 33);
            this.btnThoatphongban.TabIndex = 65;
            this.btnThoatphongban.Text = "Thoát";
            this.btnThoatphongban.UseVisualStyleBackColor = false;
            this.btnThoatphongban.Click += new System.EventHandler(this.btnThoatphongban_Click);
            // 
            // txttenphongban
            // 
            this.txttenphongban.Location = new System.Drawing.Point(148, 208);
            this.txttenphongban.Name = "txttenphongban";
            this.txttenphongban.Size = new System.Drawing.Size(150, 22);
            this.txttenphongban.TabIndex = 63;
            // 
            // txtmaphongban
            // 
            this.txtmaphongban.Location = new System.Drawing.Point(148, 127);
            this.txtmaphongban.Name = "txtmaphongban";
            this.txtmaphongban.Size = new System.Drawing.Size(150, 22);
            this.txtmaphongban.TabIndex = 62;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(14, 213);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(105, 17);
            this.bunifuCustomLabel12.TabIndex = 61;
            this.bunifuCustomLabel12.Text = "Tên phòng ban";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(12, 132);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(99, 17);
            this.bunifuCustomLabel5.TabIndex = 59;
            this.bunifuCustomLabel5.Text = "Mã phòng ban";
            // 
            // dtgPhongBan
            // 
            this.dtgPhongBan.AllowUserToOrderColumns = true;
            this.dtgPhongBan.AutoGenerateColumns = false;
            this.dtgPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPBDataGridViewTextBoxColumn,
            this.tenPBDataGridViewTextBoxColumn});
            this.dtgPhongBan.DataSource = this.phongBanBindingSource;
            this.dtgPhongBan.Location = new System.Drawing.Point(338, 24);
            this.dtgPhongBan.Name = "dtgPhongBan";
            this.dtgPhongBan.RowHeadersWidth = 51;
            this.dtgPhongBan.RowTemplate.Height = 24;
            this.dtgPhongBan.Size = new System.Drawing.Size(311, 238);
            this.dtgPhongBan.TabIndex = 58;
            // 
            // maPBDataGridViewTextBoxColumn
            // 
            this.maPBDataGridViewTextBoxColumn.DataPropertyName = "MaPB";
            this.maPBDataGridViewTextBoxColumn.HeaderText = "MaPB";
            this.maPBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPBDataGridViewTextBoxColumn.Name = "maPBDataGridViewTextBoxColumn";
            this.maPBDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenPBDataGridViewTextBoxColumn
            // 
            this.tenPBDataGridViewTextBoxColumn.DataPropertyName = "TenPB";
            this.tenPBDataGridViewTextBoxColumn.HeaderText = "TenPB";
            this.tenPBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenPBDataGridViewTextBoxColumn.Name = "tenPBDataGridViewTextBoxColumn";
            this.tenPBDataGridViewTextBoxColumn.Width = 125;
            // 
            // phongBanBindingSource
            // 
            this.phongBanBindingSource.DataMember = "PhongBan";
            this.phongBanBindingSource.DataSource = this._QLNhanVien_Net1_25_11DataSet;
            // 
            // _QLNhanVien_Net1_25_11DataSet
            // 
            this._QLNhanVien_Net1_25_11DataSet.DataSetName = "_QLNhanVien_Net1_25_11DataSet";
            this._QLNhanVien_Net1_25_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phongBanTableAdapter
            // 
            this.phongBanTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(17, 24);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(240, 29);
            this.bunifuCustomLabel1.TabIndex = 66;
            this.bunifuCustomLabel1.Text = "Danh mục phòng ban";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(703, 24);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 67;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(703, 81);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 68;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(703, 148);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 69;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 288);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnThoatphongban);
            this.Controls.Add(this.txttenphongban);
            this.Controls.Add(this.txtmaphongban);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.dtgPhongBan);
            this.Name = "frmPhongBan";
            this.Text = "frmPhongBan";
            this.Load += new System.EventHandler(this.frmPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._QLNhanVien_Net1_25_11DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoatphongban;
        private System.Windows.Forms.TextBox txttenphongban;
        private System.Windows.Forms.TextBox txtmaphongban;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.DataGridView dtgPhongBan;
        private _QLNhanVien_Net1_25_11DataSet _QLNhanVien_Net1_25_11DataSet;
        private System.Windows.Forms.BindingSource phongBanBindingSource;
        private _QLNhanVien_Net1_25_11DataSetTableAdapters.PhongBanTableAdapter phongBanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPBDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
    }
}