
namespace BTL_QLThuvien_Csharp_Nhom10
{
    partial class frmthongtinsach
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
            this.dtgthongtin = new System.Windows.Forms.DataGridView();
            this.btnin = new System.Windows.Forms.Button();
            this.btnthongtin = new System.Windows.Forms.Button();
            this.chksachtonkho = new System.Windows.Forms.CheckBox();
            this.chksachbanchay = new System.Windows.Forms.CheckBox();
            this.chksachbihu = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttong = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgthongtin)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgthongtin
            // 
            this.dtgthongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgthongtin.Location = new System.Drawing.Point(12, 12);
            this.dtgthongtin.Name = "dtgthongtin";
            this.dtgthongtin.RowHeadersWidth = 51;
            this.dtgthongtin.RowTemplate.Height = 24;
            this.dtgthongtin.Size = new System.Drawing.Size(339, 299);
            this.dtgthongtin.TabIndex = 0;
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(569, 35);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(98, 33);
            this.btnin.TabIndex = 1;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            // 
            // btnthongtin
            // 
            this.btnthongtin.Location = new System.Drawing.Point(409, 35);
            this.btnthongtin.Name = "btnthongtin";
            this.btnthongtin.Size = new System.Drawing.Size(105, 33);
            this.btnthongtin.TabIndex = 2;
            this.btnthongtin.Text = "Thong tin";
            this.btnthongtin.UseVisualStyleBackColor = true;
            this.btnthongtin.Click += new System.EventHandler(this.btnthongtin_Click);
            // 
            // chksachtonkho
            // 
            this.chksachtonkho.AutoSize = true;
            this.chksachtonkho.Location = new System.Drawing.Point(416, 112);
            this.chksachtonkho.Name = "chksachtonkho";
            this.chksachtonkho.Size = new System.Drawing.Size(198, 21);
            this.chksachtonkho.TabIndex = 3;
            this.chksachtonkho.Text = "So sach khong duoc muon";
            this.chksachtonkho.UseVisualStyleBackColor = true;
            // 
            // chksachbanchay
            // 
            this.chksachbanchay.AutoSize = true;
            this.chksachbanchay.Location = new System.Drawing.Point(416, 172);
            this.chksachbanchay.Name = "chksachbanchay";
            this.chksachbanchay.Size = new System.Drawing.Size(226, 21);
            this.chksachbanchay.TabIndex = 4;
            this.chksachbanchay.Text = "So sach duoc muon nhieu nhat";
            this.chksachbanchay.UseVisualStyleBackColor = true;
            // 
            // chksachbihu
            // 
            this.chksachbihu.AutoSize = true;
            this.chksachbihu.Location = new System.Drawing.Point(416, 228);
            this.chksachbihu.Name = "chksachbihu";
            this.chksachbihu.Size = new System.Drawing.Size(195, 21);
            this.chksachbihu.TabIndex = 5;
            this.chksachbihu.Text = "So sach hu hong can thay";
            this.chksachbihu.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(416, 289);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hien co";
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(676, 170);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(100, 22);
            this.txttong.TabIndex = 8;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(676, 336);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(100, 30);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "Thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // frmthongtinsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 378);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txttong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chksachbihu);
            this.Controls.Add(this.chksachbanchay);
            this.Controls.Add(this.chksachtonkho);
            this.Controls.Add(this.btnthongtin);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.dtgthongtin);
            this.Name = "frmthongtinsach";
            this.Text = "frmthongtinsach";
            ((System.ComponentModel.ISupportInitialize)(this.dtgthongtin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgthongtin;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btnthongtin;
        private System.Windows.Forms.CheckBox chksachtonkho;
        private System.Windows.Forms.CheckBox chksachbanchay;
        private System.Windows.Forms.CheckBox chksachbihu;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.Button btnthoat;
    }
}