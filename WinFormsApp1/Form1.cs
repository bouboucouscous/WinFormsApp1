using System.IO;
    
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        string 
            pathFichieACopier, nameFicheierAColler;


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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();

            try
            {
                textBox2.Text = treeView1.SelectedNode.Tag.ToString() + "/" + listView1.SelectedItems[0].Text;
                textBox3.Text = new FileInfo(treeView1.SelectedNode.Tag.ToString() + "/" + listView1.SelectedItems[0].Text).LastWriteTime.ToString("dd/MM/yyyy HH:mm");


                textBox5.Text = FormaterTaille(new FileInfo(treeView1.SelectedNode.Tag.ToString() + "/" + listView1.SelectedItems[0].Text).Length);
            }
            catch
            {

            }
        }

        static string FormaterTaille(long octets)
        {
            if (octets >= 1L << 30) // 1 Go = 2^30 octets
            {
                double tailleEnGo = octets / (double)(1L << 30);
                return $"{tailleEnGo:F2} Go"; // Format avec 2 décimales
            }
            else if (octets >= 1L << 20) // 1 Mo = 2^20 octets
            {
                double tailleEnMo = octets / (double)(1L << 20);
                return $"{tailleEnMo:F2} Mo"; // Format avec 2 décimales
            }
            else if (octets >= 1L << 10) // 1 Ko = 2^10 octets
            {
                double tailleEnKo = octets / (double)(1L << 10);
                return $"{tailleEnKo:F2} Ko"; // Format avec 2 décimales
            }
            else
            {
                return $"{octets} octets"; // Moins de 1 Ko
            }
        }


        private void copiezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameFicheierAColler = listView1.SelectedItems[0].Text;
            pathFichieACopier = treeView1.SelectedNode.Tag.ToString() + "/" + nameFicheierAColler;
        }


        private void copierA(string path)
        {
            File.Copy(path, treeView1.SelectedNode.Tag.ToString() + "/" + nameFicheierAColler);
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copierA(pathFichieACopier);
        }


        private void ListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Convertir les coordonnées du clic en coordonnées de l'élément
                ListViewHitTestInfo hitTestInfo = listView1.HitTest(e.Location);

                if (hitTestInfo.Item != null)
                {
                    // Afficher le ContextMenuStrip uniquement si un élément est sous le clic
                    copier.Show(listView1, e.Location);
                }
            }
        }

        private void suppriemrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet élément ?",
                                            "Confirmation de suppression",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

            if (resultat == DialogResult.Yes)
            {
                try
                {

                    File.Delete(treeView1.SelectedNode.Tag.ToString() + "/" + listView1.SelectedItems[0].Text);
                }
                catch { }
            }
            LoadListView(treeView1.SelectedNode.Tag.ToString());
        }
    }
}
