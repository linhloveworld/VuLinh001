namespace WinFormsApp28_10
{
    partial class Form_SP
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtGiaSP = new System.Windows.Forms.TextBox();
            this.dataGridView_SP = new System.Windows.Forms.DataGridView();
            this.btn_add_SP = new System.Windows.Forms.Button();
            this.btn_edit_SP = new System.Windows.Forms.Button();
            this.btn_delete_SP = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(265, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(204, 107);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(125, 27);
            this.txtMaSP.TabIndex = 4;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(204, 166);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(125, 27);
            this.txtTenSP.TabIndex = 5;
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.Location = new System.Drawing.Point(204, 225);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.Size = new System.Drawing.Size(125, 27);
            this.txtGiaSP.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SP.Location = new System.Drawing.Point(432, 105);
            this.dataGridView_SP.Name = "dataGridView1";
            this.dataGridView_SP.RowHeadersWidth = 51;
            this.dataGridView_SP.RowTemplate.Height = 29;
            this.dataGridView_SP.Size = new System.Drawing.Size(300, 188);
            this.dataGridView_SP.TabIndex = 7;
            // 
            // btn_add_SP
            // 
            this.btn_add_SP.Location = new System.Drawing.Point(57, 332);
            this.btn_add_SP.Name = "btn_add_SP";
            this.btn_add_SP.Size = new System.Drawing.Size(94, 29);
            this.btn_add_SP.TabIndex = 8;
            this.btn_add_SP.Text = "Thêm TT";
            this.btn_add_SP.UseVisualStyleBackColor = true;
            this.btn_add_SP.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_edit_SP
            // 
            this.btn_edit_SP.Location = new System.Drawing.Point(204, 332);
            this.btn_edit_SP.Name = "btn_edit_SP";
            this.btn_edit_SP.Size = new System.Drawing.Size(94, 29);
            this.btn_edit_SP.TabIndex = 9;
            this.btn_edit_SP.Text = "Sửa TT";
            this.btn_edit_SP.UseVisualStyleBackColor = true;
            // 
            // btn_delete_SP
            // 
            this.btn_delete_SP.Location = new System.Drawing.Point(127, 392);
            this.btn_delete_SP.Name = "btn_delete_SP";
            this.btn_delete_SP.Size = new System.Drawing.Size(94, 29);
            this.btn_delete_SP.TabIndex = 10;
            this.btn_delete_SP.Text = "Xóa TT";
            this.btn_delete_SP.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(533, 381);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(94, 29);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Thoát ra";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_delete_SP);
            this.Controls.Add(this.btn_edit_SP);
            this.Controls.Add(this.btn_add_SP);
            this.Controls.Add(this.dataGridView_SP);
            this.Controls.Add(this.txtGiaSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private TextBox txtGiaSP;
        private DataGridView dataGridView_SP;
        private Button btn_add_SP;
        private Button btn_edit_SP;
        private Button btn_delete_SP;
        private Button btn_exit;
        private EventHandler button4_Click;
    }
}