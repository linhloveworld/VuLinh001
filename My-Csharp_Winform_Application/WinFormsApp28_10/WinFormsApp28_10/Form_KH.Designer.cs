namespace WinFormsApp28_10
{
    partial class Form_KH
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete_KH = new System.Windows.Forms.Button();
            this.btn_edit_KH = new System.Windows.Forms.Button();
            this.btn_add_KH = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDCKH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(240, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý khách hàng";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(539, 343);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(94, 29);
            this.btn_exit.TabIndex = 22;
            this.btn_exit.Text = "Thoát ra";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_delete_KH
            // 
            this.btn_delete_KH.Location = new System.Drawing.Point(133, 354);
            this.btn_delete_KH.Name = "btn_delete_KH";
            this.btn_delete_KH.Size = new System.Drawing.Size(94, 29);
            this.btn_delete_KH.TabIndex = 21;
            this.btn_delete_KH.Text = "Xóa TT";
            this.btn_delete_KH.UseVisualStyleBackColor = true;
            // 
            // btn_edit_KH
            // 
            this.btn_edit_KH.Location = new System.Drawing.Point(210, 294);
            this.btn_edit_KH.Name = "btn_edit_KH";
            this.btn_edit_KH.Size = new System.Drawing.Size(94, 29);
            this.btn_edit_KH.TabIndex = 20;
            this.btn_edit_KH.Text = "Sửa TT";
            this.btn_edit_KH.UseVisualStyleBackColor = true;
            // 
            // btn_add_KH
            // 
            this.btn_add_KH.Location = new System.Drawing.Point(63, 294);
            this.btn_add_KH.Name = "btn_add_KH";
            this.btn_add_KH.Size = new System.Drawing.Size(94, 29);
            this.btn_add_KH.TabIndex = 19;
            this.btn_add_KH.Text = "Thêm TT";
            this.btn_add_KH.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(438, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 188);
            this.dataGridView1.TabIndex = 18;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(47, 228);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(125, 27);
            this.txtSDTKH.TabIndex = 17;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(226, 111);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(125, 27);
            this.txtTenKH.TabIndex = 16;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(47, 111);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(125, 27);
            this.txtMaKH.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "SDT khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Địa chỉ khách hàng";
            // 
            // txtDCKH
            // 
            this.txtDCKH.Location = new System.Drawing.Point(226, 228);
            this.txtDCKH.Name = "txtDCKH";
            this.txtDCKH.Size = new System.Drawing.Size(125, 27);
            this.txtDCKH.TabIndex = 24;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDCKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_delete_KH);
            this.Controls.Add(this.btn_edit_KH);
            this.Controls.Add(this.btn_add_KH);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSDTKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_exit;
        private Button btn_delete_KH;
        private Button btn_edit_KH;
        private Button btn_add_KH;
        private DataGridView dataGridView1;
        private TextBox txtSDTKH;
        private TextBox txtTenKH;
        private TextBox txtMaKH;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txtDCKH;
    }
}