namespace WinFormsApp_16_9
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node13", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node9");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vidu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachhangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text3Text4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text31ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text32ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachHangToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vidu1ToolStripMenuItem,
            this.khachHangToolStripMenuItem1,
            this.sanPhamToolStripMenuItem,
            this.text4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vidu1ToolStripMenuItem
            // 
            this.vidu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khachhangToolStripMenuItem,
            this.text2ToolStripMenuItem,
            this.text3Text4ToolStripMenuItem});
            this.vidu1ToolStripMenuItem.Name = "vidu1ToolStripMenuItem";
            this.vidu1ToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.vidu1ToolStripMenuItem.Text = "text 1";
            // 
            // khachhangToolStripMenuItem
            // 
            this.khachhangToolStripMenuItem.Name = "khachhangToolStripMenuItem";
            this.khachhangToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.khachhangToolStripMenuItem.Text = "text 1.1";
            this.khachhangToolStripMenuItem.Click += new System.EventHandler(this.khachhangToolStripMenuItem_Click);
            // 
            // text2ToolStripMenuItem
            // 
            this.text2ToolStripMenuItem.Name = "text2ToolStripMenuItem";
            this.text2ToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.text2ToolStripMenuItem.Text = "text 1.2";
            // 
            // text3Text4ToolStripMenuItem
            // 
            this.text3Text4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.text31ToolStripMenuItem,
            this.text32ToolStripMenuItem});
            this.text3Text4ToolStripMenuItem.Name = "text3Text4ToolStripMenuItem";
            this.text3Text4ToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.text3Text4ToolStripMenuItem.Text = "text 1.3";
            // 
            // text31ToolStripMenuItem
            // 
            this.text31ToolStripMenuItem.Name = "text31ToolStripMenuItem";
            this.text31ToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.text31ToolStripMenuItem.Text = "text  1.1.1";
            // 
            // text32ToolStripMenuItem
            // 
            this.text32ToolStripMenuItem.Name = "text32ToolStripMenuItem";
            this.text32ToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.text32ToolStripMenuItem.Text = "text 1.1.2";
            // 
            // khachHangToolStripMenuItem1
            // 
            this.khachHangToolStripMenuItem1.Name = "khachHangToolStripMenuItem1";
            this.khachHangToolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.khachHangToolStripMenuItem1.Text = "text 2";
            // 
            // sanPhamToolStripMenuItem
            // 
            this.sanPhamToolStripMenuItem.Name = "sanPhamToolStripMenuItem";
            this.sanPhamToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.sanPhamToolStripMenuItem.Text = "text 3";
            // 
            // text4ToolStripMenuItem
            // 
            this.text4ToolStripMenuItem.Name = "text4ToolStripMenuItem";
            this.text4ToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.text4ToolStripMenuItem.Text = "text 4";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 28);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node10";
            treeNode1.Text = "Node10";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Node1";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Node2";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Node0";
            treeNode5.Name = "Node13";
            treeNode5.Text = "Node13";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Node3";
            treeNode7.Name = "Node4";
            treeNode7.Text = "Node4";
            treeNode8.Name = "Node5";
            treeNode8.Text = "Node5";
            treeNode9.Name = "Node6";
            treeNode9.Text = "Node6";
            treeNode10.Name = "Node7";
            treeNode10.Text = "Node7";
            treeNode11.Name = "Node8";
            treeNode11.Text = "Node8";
            treeNode12.Name = "Node9";
            treeNode12.Text = "Node9";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(800, 422);
            this.treeView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem vidu1ToolStripMenuItem;
        private ToolStripMenuItem khachhangToolStripMenuItem;
        private ToolStripMenuItem text2ToolStripMenuItem;
        private ToolStripMenuItem text3Text4ToolStripMenuItem;
        private ToolStripMenuItem text31ToolStripMenuItem;
        private ToolStripMenuItem text32ToolStripMenuItem;
        private ToolStripMenuItem khachHangToolStripMenuItem1;
        private ToolStripMenuItem sanPhamToolStripMenuItem;
        private ToolStripMenuItem text4ToolStripMenuItem;
        private TreeView treeView1;
    }
}