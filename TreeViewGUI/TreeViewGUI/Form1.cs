namespace TreeViewGUI
{
    public partial class Form1 : Form
    {
        string path = @"D:\";
        public Form1()
        {
            InitializeComponent();
            //loadTreeView();
            if (Directory.Exists(path))
            {
                TreeNode root = new TreeNode() { Text = path};
                treeViewShow.Nodes.Add(root);
                loadExplorer(root);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeViewShow_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        void loadExplorer(TreeNode root)
        {   
            if (root == null)
            {
                return;
            }
            try
            {
                var folderList = new DirectoryInfo(root.Text).GetDirectories();

                if (folderList.Count() == 0)
                {
                    return;
                }
                foreach (DirectoryInfo item in folderList)
                {
                    if (Directory.Exists(item.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = item.FullName };
                        root.Nodes.Add(node);
                        loadExplorer(node);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        void loadTreeView()
        {
            treeViewShow.CheckBoxes = true;
            treeViewShow.NodeMouseClick += TreeViewShow_NodeMouseClick;

            TreeNode root1 = new TreeNode();
            root1.Text = "Root 1";
            root1.ImageIndex = 0;

            TreeNode node1 = new TreeNode() { Text = "Node 1"};
            root1.Nodes.Add(node1);
            node1.ImageIndex = 1;
            node1.Checked = true;


            TreeNode root2 = new TreeNode();
            root2.Text = "Root 2";
            root2.ImageIndex = 2;

            treeViewShow.Nodes.Add(root1);
            treeViewShow.Nodes.Add(root2);
        }

        private void TreeViewShow_NodeMouseClick(object? sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.Checked = !e.Node.Checked; 
        }
    }
}