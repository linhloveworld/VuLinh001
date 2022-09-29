namespace WinFormsApp_16_9
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.text1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text21ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text22ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.text1ToolStripMenuItem,
            this.text2ToolStripMenuItem,
            this.text3ToolStripMenuItem,
            this.text4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // text1ToolStripMenuItem
            // 
            this.text1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.text11ToolStripMenuItem,
            this.text12ToolStripMenuItem});
            this.text1ToolStripMenuItem.Name = "text1ToolStripMenuItem";
            this.text1ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.text1ToolStripMenuItem.Text = "Text 1 ";
            // 
            // text11ToolStripMenuItem
            // 
            this.text11ToolStripMenuItem.Name = "text11ToolStripMenuItem";
            this.text11ToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.text11ToolStripMenuItem.Text = "Text 1.1";
            // 
            // text12ToolStripMenuItem
            // 
            this.text12ToolStripMenuItem.Name = "text12ToolStripMenuItem";
            this.text12ToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.text12ToolStripMenuItem.Text = "Text 1.2";
            // 
            // text2ToolStripMenuItem
            // 
            this.text2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.text21ToolStripMenuItem,
            this.text22ToolStripMenuItem});
            this.text2ToolStripMenuItem.Name = "text2ToolStripMenuItem";
            this.text2ToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.text2ToolStripMenuItem.Text = "Text 2";
            // 
            // text21ToolStripMenuItem
            // 
            this.text21ToolStripMenuItem.Name = "text21ToolStripMenuItem";
            this.text21ToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.text21ToolStripMenuItem.Text = "Text 2.1";
            // 
            // text22ToolStripMenuItem
            // 
            this.text22ToolStripMenuItem.Name = "text22ToolStripMenuItem";
            this.text22ToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.text22ToolStripMenuItem.Text = "Text 2.2";
            // 
            // text3ToolStripMenuItem
            // 
            this.text3ToolStripMenuItem.Name = "text3ToolStripMenuItem";
            this.text3ToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.text3ToolStripMenuItem.Text = "Text 3";
            // 
            // text4ToolStripMenuItem
            // 
            this.text4ToolStripMenuItem.Name = "text4ToolStripMenuItem";
            this.text4ToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.text4ToolStripMenuItem.Text = "Text 4";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(125, 65);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(528, 241);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "10334384_1379224072363879_5099041148200536895_n.png");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem text1ToolStripMenuItem;
        private ToolStripMenuItem text11ToolStripMenuItem;
        private ToolStripMenuItem text12ToolStripMenuItem;
        private ToolStripMenuItem text2ToolStripMenuItem;
        private ToolStripMenuItem text21ToolStripMenuItem;
        private ToolStripMenuItem text22ToolStripMenuItem;
        private ToolStripMenuItem text3ToolStripMenuItem;
        private ToolStripMenuItem text4ToolStripMenuItem;
        private TreeView treeView1;
        private ImageList imageList1;
        private ImageList imageList2;
    }
}