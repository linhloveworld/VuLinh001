
namespace QLThuVien
{
    partial class frmLuong
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
            this.dtgLuong = new System.Windows.Forms.DataGridView();
            this.heSoLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongCBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._QLNhanVien_Net1_25_11DataSet = new QLThuVien._QLNhanVien_Net1_25_11DataSet();
            this.ctChucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctChucVuTableAdapter = new QLThuVien._QLNhanVien_Net1_25_11DataSetTableAdapters.ctChucVuTableAdapter();
            this.luongTableAdapter = new QLThuVien._QLNhanVien_Net1_25_11DataSetTableAdapters.LuongTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txthesoluong = new System.Windows.Forms.TextBox();
            this.txtluongcoban = new System.Windows.Forms.TextBox();
            this.btnthoatLuong = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnluuluong = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._QLNhanVien_Net1_25_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctChucVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgLuong
            // 
            this.dtgLuong.AllowUserToOrderColumns = true;
            this.dtgLuong.AutoGenerateColumns = false;
            this.dtgLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heSoLuongDataGridViewTextBoxColumn,
            this.luongCBDataGridViewTextBoxColumn});
            this.dtgLuong.DataSource = this.luongBindingSource;
            this.dtgLuong.Location = new System.Drawing.Point(394, 60);
            this.dtgLuong.Name = "dtgLuong";
            this.dtgLuong.RowHeadersWidth = 51;
            this.dtgLuong.RowTemplate.Height = 24;
            this.dtgLuong.Size = new System.Drawing.Size(306, 150);
            this.dtgLuong.TabIndex = 0;
            // 
            // heSoLuongDataGridViewTextBoxColumn
            // 
            this.heSoLuongDataGridViewTextBoxColumn.DataPropertyName = "HeSoLuong";
            this.heSoLuongDataGridViewTextBoxColumn.HeaderText = "HeSoLuong";
            this.heSoLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.heSoLuongDataGridViewTextBoxColumn.Name = "heSoLuongDataGridViewTextBoxColumn";
            this.heSoLuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongCBDataGridViewTextBoxColumn
            // 
            this.luongCBDataGridViewTextBoxColumn.DataPropertyName = "LuongCB";
            this.luongCBDataGridViewTextBoxColumn.HeaderText = "LuongCB";
            this.luongCBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongCBDataGridViewTextBoxColumn.Name = "luongCBDataGridViewTextBoxColumn";
            this.luongCBDataGridViewTextBoxColumn.Width = 125;
            // 
            // luongBindingSource
            // 
            this.luongBindingSource.DataMember = "Luong";
            this.luongBindingSource.DataSource = this._QLNhanVien_Net1_25_11DataSet;
            // 
            // _QLNhanVien_Net1_25_11DataSet
            // 
            this._QLNhanVien_Net1_25_11DataSet.DataSetName = "_QLNhanVien_Net1_25_11DataSet";
            this._QLNhanVien_Net1_25_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ctChucVuBindingSource
            // 
            this.ctChucVuBindingSource.DataMember = "ctChucVu";
            this.ctChucVuBindingSource.DataSource = this._QLNhanVien_Net1_25_11DataSet;
            // 
            // ctChucVuTableAdapter
            // 
            this.ctChucVuTableAdapter.ClearBeforeFill = true;
            // 
            // luongTableAdapter
            // 
            this.luongTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hệ số lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lương cơ bản";
            // 
            // txthesoluong
            // 
            this.txthesoluong.Location = new System.Drawing.Point(215, 41);
            this.txthesoluong.Name = "txthesoluong";
            this.txthesoluong.Size = new System.Drawing.Size(152, 22);
            this.txthesoluong.TabIndex = 3;
            // 
            // txtluongcoban
            // 
            this.txtluongcoban.Location = new System.Drawing.Point(215, 125);
            this.txtluongcoban.Name = "txtluongcoban";
            this.txtluongcoban.Size = new System.Drawing.Size(152, 22);
            this.txtluongcoban.TabIndex = 4;
            // 
            // btnthoatLuong
            // 
            this.btnthoatLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnthoatLuong.Location = new System.Drawing.Point(602, 227);
            this.btnthoatLuong.Name = "btnthoatLuong";
            this.btnthoatLuong.Size = new System.Drawing.Size(98, 33);
            this.btnthoatLuong.TabIndex = 88;
            this.btnthoatLuong.Text = "Thoát";
            this.btnthoatLuong.UseVisualStyleBackColor = false;
            this.btnthoatLuong.Click += new System.EventHandler(this.btnthoatLuong_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(18, 187);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 89;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnluuluong
            // 
            this.btnluuluong.Location = new System.Drawing.Point(146, 187);
            this.btnluuluong.Name = "btnluuluong";
            this.btnluuluong.Size = new System.Drawing.Size(75, 23);
            this.btnluuluong.TabIndex = 90;
            this.btnluuluong.Text = "Lưu";
            this.btnluuluong.UseVisualStyleBackColor = false;
            this.btnluuluong.Click += new System.EventHandler(this.btnluuluong_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(282, 187);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 91;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(389, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(193, 29);
            this.bunifuCustomLabel1.TabIndex = 92;
            this.bunifuCustomLabel1.Text = "Danh mục Lương";
            // 
            // frmLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 287);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluuluong);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnthoatLuong);
            this.Controls.Add(this.txtluongcoban);
            this.Controls.Add(this.txthesoluong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgLuong);
            this.Name = "frmLuong";
            this.Text = "frmLuong";
            this.Load += new System.EventHandler(this.frmLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._QLNhanVien_Net1_25_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctChucVuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLuong;
        private _QLNhanVien_Net1_25_11DataSet _QLNhanVien_Net1_25_11DataSet;
        private System.Windows.Forms.BindingSource ctChucVuBindingSource;
        private _QLNhanVien_Net1_25_11DataSetTableAdapters.ctChucVuTableAdapter ctChucVuTableAdapter;
        private System.Windows.Forms.BindingSource luongBindingSource;
        private _QLNhanVien_Net1_25_11DataSetTableAdapters.LuongTableAdapter luongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn heSoLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongCBDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthesoluong;
        private System.Windows.Forms.TextBox txtluongcoban;
        private System.Windows.Forms.Button btnthoatLuong;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnluuluong;
        private System.Windows.Forms.Button btnsua;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}