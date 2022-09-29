namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblBaiSo3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnTachChuoi = new System.Windows.Forms.Button();
            this.btnChuanHoa = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(182, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bai thuc hanh so 3 + 4";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBaiSo3
            // 
            this.lblBaiSo3.AutoSize = true;
            this.lblBaiSo3.Location = new System.Drawing.Point(21, 118);
            this.lblBaiSo3.Name = "lblBaiSo3";
            this.lblBaiSo3.Size = new System.Drawing.Size(58, 15);
            this.lblBaiSo3.TabIndex = 1;
            this.lblBaiSo3.Text = "Ho va ten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ho lot ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ten";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(108, 106);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(303, 23);
            this.txtHoTen.TabIndex = 4;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtHoLot
            // 
            this.txtHoLot.Location = new System.Drawing.Point(108, 206);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(303, 23);
            this.txtHoLot.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(485, 206);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(303, 23);
            this.txtTen.TabIndex = 6;
            // 
            // btnTachChuoi
            // 
            this.btnTachChuoi.Location = new System.Drawing.Point(110, 299);
            this.btnTachChuoi.Name = "btnTachChuoi";
            this.btnTachChuoi.Size = new System.Drawing.Size(90, 31);
            this.btnTachChuoi.TabIndex = 7;
            this.btnTachChuoi.Text = "Tach chuoi";
            this.btnTachChuoi.UseVisualStyleBackColor = true;
            // 
            // btnChuanHoa
            // 
            this.btnChuanHoa.Location = new System.Drawing.Point(260, 299);
            this.btnChuanHoa.Name = "btnChuanHoa";
            this.btnChuanHoa.Size = new System.Drawing.Size(90, 31);
            this.btnChuanHoa.TabIndex = 8;
            this.btnChuanHoa.Text = "Chuan hoa chuoi";
            this.btnChuanHoa.UseVisualStyleBackColor = true;
            this.btnChuanHoa.Click += new System.EventHandler(this.btnChuanHoa_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(421, 299);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 31);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(599, 299);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 31);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChuanHoa);
            this.Controls.Add(this.btnTachChuoi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoLot);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBaiSo3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblBaiSo3;
        private Label label3;
        private Label label4;
        private TextBox txtHoTen;
        private TextBox txtHoLot;
        private TextBox txtTen;
        private Button btnTachChuoi;
        private Button btnChuanHoa;
        private Button btnXoa;
        private Button btnThoat;
    }
}