using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_16_9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            loadTreeView();
        }
        void loadTreeView()
        {
            treeView1.CheckBoxes = true;
            MouseEventHandler TreeView1_MouseDoubleClick = null;
            treeView1.MouseDoubleClick += TreeView1_MouseDoubleClick;
            treeView1.NodeMouseClick += TreeView1_NodeMouseClick;
            TreeNode root = new TreeNode();
            root.Text = "Noi chuyen";
            treeView1.Nodes.Add(root);
            root.ImageIndex = 0;

            TreeNode rootchill = new TreeNode()
            {
                Text = "Noi chuyen di nay"
            };
            root.Nodes.Add(rootchill);



            TreeNode root2 = new TreeNode();
            root2.Text = "Noi chuyen 2";
            treeView1.Nodes.Add(root2);
        }

        private void TreeView1_NodeMouseClick(object? sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.Checked = !e.Node.Checked;
        }

        private void TreeView1_NodeDoubleClick(object? sender, MouseEventArgs e)
        {
          
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void treeView1_MouseDoubleClick(object sender, TreeViewEventArgs e)
        {
            throw new NotImplementedException();
            //MessageBox.Show(treeView1.SelectedNode.Text);
        }
    }
}
