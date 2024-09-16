using System.IO;
    
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTreeView();
        }

        private void LoadTreeView()
        {
            TreeNode racine = new TreeNode("racine");
            racine.Tag = "racine";
            racine.SelectedImageIndex = 110;
            racine.ImageIndex = 110;

            treeView1.Nodes.Add(racine);

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                TreeNode treeNode = new TreeNode(drive.Name);
                treeNode.Tag = drive.RootDirectory.FullName;
                treeNode.SelectedImageIndex = 54;
                treeNode.ImageIndex = 54;
                ListeRepertoire(treeNode);
                racine.Nodes.Add(treeNode);
            }
        }

        private void LoadListView(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            try
            {
                listView1.Items.Clear();
                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    listView1.Items.Add(file.Name, 54);

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void ListeRepertoire(TreeNode node)
        {
            node.Nodes.Clear();
            DirectoryInfo directorys = new DirectoryInfo(node.Tag.ToString());
            foreach (DirectoryInfo directory in directorys.GetDirectories())
            {
                try
                {
                    TreeNode treeNode = new TreeNode(directory.Name);
                    treeNode.Tag = directory.FullName;

                    treeNode.SelectedImageIndex = 102;
                    treeNode.ImageIndex = 102;

                    if (directory.GetDirectories().Length > 1)
                    {
                        try
                        {
                            TreeNode treeNodeChildren = new TreeNode();
                            treeNode.Nodes.Add("..");

                        }
                        catch (Exception e)
                        {

                        }
                    }
                    node.Nodes.Add(treeNode);
                }
                catch (Exception e)
                {

                }
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level > 1)
            {
                ListeRepertoire(e.Node);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadListView(e.Node.Tag.ToString());
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

    }
}
