namespace WinFormsApp_16_9
{
    partial class Form3
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
            Form3 form3 = this;
            form3.panel1 = new System.Windows.Forms.Panel();
            form3.button4 = new System.Windows.Forms.Button();
            form3.button3 = new System.Windows.Forms.Button();
            form3.button2 = new System.Windows.Forms.Button();
            form3.button1 = new System.Windows.Forms.Button();
            form3.panel1.SuspendLayout();
            form3.SuspendLayout();
            // 
            // panel1
            // 
            form3.panel1.Controls.Add(form3.button4);
            form3.panel1.Controls.Add(form3.button3);
            form3.panel1.Controls.Add(form3.button2);
            form3.panel1.Controls.Add(form3.button1);
            form3.panel1.Location = new System.Drawing.Point(61, 34);
            form3.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            form3.panel1.Name = "panel1";
            form3.panel1.Size = new System.Drawing.Size(252, 212);
            form3.panel1.TabIndex = 0;
            form3.panel1.Paint += new System.Windows.Forms.PaintEventHandler(form3.panel1);
            // 
            // button4
            // 
            form3.button4.Location = new System.Drawing.Point(182, 145);
            form3.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            form3.button4.Name = "button4";
            form3.button4.Size = new System.Drawing.Size(40, 31);
            form3.button4.TabIndex = 3;
            form3.button4.Text = "button4";
            form3.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            form3.button3.Location = new System.Drawing.Point(76, 93);
            form3.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            form3.button3.Name = "button3";
            form3.button3.Size = new System.Drawing.Size(40, 31);
            form3.button3.TabIndex = 2;
            form3.button3.Text = "button3";
            form3.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            form3.button2.Location = new System.Drawing.Point(135, 16);
            form3.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            form3.button2.Name = "button2";
            form3.button2.Size = new System.Drawing.Size(40, 31);
            form3.button2.TabIndex = 1;
            form3.button2.Text = "button2";
            form3.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            form3.button1.Location = new System.Drawing.Point(25, 26);
            form3.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            form3.button1.Name = "button1";
            form3.button1.Size = new System.Drawing.Size(40, 31);
            form3.button1.TabIndex = 0;
            form3.button1.Text = "button1";
            form3.button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            form3.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            form3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form3.ClientSize = new System.Drawing.Size(700, 338);
            form3.Controls.Add(form3.panel1);
            form3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            form3.Name = "Form3";
            form3.Text = "Form3";
            form3.panel1.ResumeLayout(false);
            form3.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}