namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            applicationToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            treeView1 = new TreeView();
            coller = new ContextMenuStrip(components);
            collerToolStripMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            listView1 = new ListView();
            copier = new ContextMenuStrip(components);
            copiezToolStripMenuItem = new ToolStripMenuItem();
            suppriemrToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            menuStrip1.SuspendLayout();
            coller.SuspendLayout();
            copier.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { applicationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1124, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitterToolStripMenuItem });
            applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            applicationToolStripMenuItem.Size = new Size(80, 20);
            applicationToolStripMenuItem.Text = "Application";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(111, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // treeView1
            // 
            treeView1.ContextMenuStrip = coller;
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.Location = new Point(40, 53);
            treeView1.Name = "treeView1";
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(301, 349);
            treeView1.TabIndex = 0;
            treeView1.AfterExpand += treeView1_AfterExpand;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // coller
            // 
            coller.Items.AddRange(new ToolStripItem[] { collerToolStripMenuItem });
            coller.Name = "coller";
            coller.Size = new Size(104, 26);
            // 
            // collerToolStripMenuItem
            // 
            collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            collerToolStripMenuItem.Size = new Size(103, 22);
            collerToolStripMenuItem.Text = "coller";
            collerToolStripMenuItem.Click += collerToolStripMenuItem_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "docx-icon (1).png");
            imageList1.Images.SetKeyName(1, "docx-icon.png");
            imageList1.Images.SetKeyName(2, "jpeg-image-icon (1).png");
            imageList1.Images.SetKeyName(3, "jpeg-image-icon (2).png");
            imageList1.Images.SetKeyName(4, "jpeg-image-icon.png");
            imageList1.Images.SetKeyName(5, "pdf-icon (1).png");
            imageList1.Images.SetKeyName(6, "pdf-icon (2).png");
            imageList1.Images.SetKeyName(7, "pdf-icon.png");
            imageList1.Images.SetKeyName(8, "txt-icon (1).png");
            imageList1.Images.SetKeyName(9, "txt-icon (2).png");
            imageList1.Images.SetKeyName(10, "txt-icon.png");
            imageList1.Images.SetKeyName(11, "xlsx-icon (1).png");
            imageList1.Images.SetKeyName(12, "xlsx-icon (2).png");
            imageList1.Images.SetKeyName(13, "xlsx-icon.png");
            imageList1.Images.SetKeyName(14, "app-x-yaml-icon (1).png");
            imageList1.Images.SetKeyName(15, "app-x-yaml-icon (2).png");
            imageList1.Images.SetKeyName(16, "app-x-yaml-icon (3).png");
            imageList1.Images.SetKeyName(17, "app-x-yaml-icon.png");
            imageList1.Images.SetKeyName(18, "doc-icon (1).png");
            imageList1.Images.SetKeyName(19, "doc-icon.png");
            imageList1.Images.SetKeyName(20, "Computer-icon.png");
            imageList1.Images.SetKeyName(21, "USB-icon - Copie.png");
            imageList1.Images.SetKeyName(22, "USB-icon.png");
            imageList1.Images.SetKeyName(23, "043.ICO");
            imageList1.Images.SetKeyName(24, "119.ICO");
            imageList1.Images.SetKeyName(25, "CD-ROM Drive.ico");
            imageList1.Images.SetKeyName(26, "CRDFLE07.ICO");
            imageList1.Images.SetKeyName(27, "DRAG2PG.ICO");
            imageList1.Images.SetKeyName(28, "DRIVE.ICO");
            imageList1.Images.SetKeyName(29, "DRIVE-C1.ICO");
            imageList1.Images.SetKeyName(30, "Empty Recycle Bin.ico");
            imageList1.Images.SetKeyName(31, "EXPLORER.ICO");
            imageList1.Images.SetKeyName(32, "FOLDER04.ICO");
            imageList1.Images.SetKeyName(33, "INSDISK.ICO");
            imageList1.Images.SetKeyName(34, "network.bmp");
            imageList1.Images.SetKeyName(35, "network.png");
            imageList1.Images.SetKeyName(36, "042.ICO");
            imageList1.Images.SetKeyName(37, "icon_accueil.png");
            imageList1.Images.SetKeyName(38, "icon1 - Copie.png");
            imageList1.Images.SetKeyName(39, "icon1.png");
            imageList1.Images.SetKeyName(40, "icon2.png");
            imageList1.Images.SetKeyName(41, "icon3.bmp");
            imageList1.Images.SetKeyName(42, "icon4.bmp");
            imageList1.Images.SetKeyName(43, "icone_precedent.png");
            imageList1.Images.SetKeyName(44, "icon-up-images.png");
            imageList1.Images.SetKeyName(45, "inav.bmp");
            imageList1.Images.SetKeyName(46, "irefresh.bmp");
            imageList1.Images.SetKeyName(47, "open.bmp");
            imageList1.Images.SetKeyName(48, "save.bmp");
            imageList1.Images.SetKeyName(49, "blanc-fichier-un-dossier-icone-9522-32.png");
            imageList1.Images.SetKeyName(50, "disque-go-icone-8759-16.png");
            imageList1.Images.SetKeyName(51, "disque-go-icone-8759-32.png");
            imageList1.Images.SetKeyName(52, "document-bleu-fichier-g98-papier-icone-9569-16.png");
            imageList1.Images.SetKeyName(53, "document-bleu-fichier-g98-papier-icone-9569-32.png");
            imageList1.Images.SetKeyName(54, "document-un-fichier-icone-9015-16.png");
            imageList1.Images.SetKeyName(55, "document-un-fichier-icone-9015-32.png");
            imageList1.Images.SetKeyName(56, "dossier-de-la-page-icone-5144-16.png");
            imageList1.Images.SetKeyName(57, "dossier-de-la-page-icone-5144-32.png");
            imageList1.Images.SetKeyName(58, "dossier-vert-icone-6633-16.png");
            imageList1.Images.SetKeyName(59, "dossier-vert-icone-6633-32.png");
            imageList1.Images.SetKeyName(60, "dossier-vert-ouvert-icone-8269-16.png");
            imageList1.Images.SetKeyName(61, "dossier-vert-ouvert-icone-8269-128.png");
            imageList1.Images.SetKeyName(62, "dvd-go-icone-5554-16.png");
            imageList1.Images.SetKeyName(63, "dvd-go-icone-5554-32.png");
            imageList1.Images.SetKeyName(64, "fichier-depot-un-dossier-complet-papier-icone-3848-16.png");
            imageList1.Images.SetKeyName(65, "fichier-depot-un-dossier-complet-papier-icone-3848-32.png");
            imageList1.Images.SetKeyName(66, "fichier-windows-icone-9317-16.png");
            imageList1.Images.SetKeyName(67, "fichier-windows-icone-9317-32.png");
            imageList1.Images.SetKeyName(68, "hd-fenetres-icone-4421-16.png");
            imageList1.Images.SetKeyName(69, "hd-fenetres-icone-4421-32.png");
            imageList1.Images.SetKeyName(70, "lecteur-dvd-dvd-icone-9537-16.png");
            imageList1.Images.SetKeyName(71, "lecteur-dvd-dvd-icone-9537-32.png");
            imageList1.Images.SetKeyName(72, "lecteur-optique-icone-8106-16.png");
            imageList1.Images.SetKeyName(73, "lecteur-optique-icone-8106-32.png");
            imageList1.Images.SetKeyName(74, "ordinateur-pc-icone-6183-16.png");
            imageList1.Images.SetKeyName(75, "ordinateur-pc-icone-6183-48.png");
            imageList1.Images.SetKeyName(76, "application-un-fichier-icone-6489-16.png");
            imageList1.Images.SetKeyName(77, "application-un-fichier-icone-6489-32.png");
            imageList1.Images.SetKeyName(78, "arrow-disque-telecharger-disque-dur-hdd-icone-7580-16.png");
            imageList1.Images.SetKeyName(79, "arrow-disque-telecharger-disque-dur-hdd-icone-7580-32.png");
            imageList1.Images.SetKeyName(80, "blanc-fichier-un-dossier-icone-9522-16.png");
            imageList1.Images.SetKeyName(81, "vista-030.ico");
            imageList1.Images.SetKeyName(82, "vista-031.ico");
            imageList1.Images.SetKeyName(83, "vista-032.ico");
            imageList1.Images.SetKeyName(84, "vista-033.ico");
            imageList1.Images.SetKeyName(85, "vista-034.ico");
            imageList1.Images.SetKeyName(86, "vista-035.ico");
            imageList1.Images.SetKeyName(87, "vista-036.ico");
            imageList1.Images.SetKeyName(88, "vista-037.ico");
            imageList1.Images.SetKeyName(89, "vista-038.ico");
            imageList1.Images.SetKeyName(90, "vista-039.ico");
            imageList1.Images.SetKeyName(91, "vista-040.ico");
            imageList1.Images.SetKeyName(92, "vista-041.ico");
            imageList1.Images.SetKeyName(93, "vista-042.ico");
            imageList1.Images.SetKeyName(94, "vista-043.ico");
            imageList1.Images.SetKeyName(95, "vista-044.ico");
            imageList1.Images.SetKeyName(96, "vista-045.ico");
            imageList1.Images.SetKeyName(97, "vista-046.ico");
            imageList1.Images.SetKeyName(98, "vista-047.ico");
            imageList1.Images.SetKeyName(99, "vista-048.ico");
            imageList1.Images.SetKeyName(100, "vista-121.ico");
            imageList1.Images.SetKeyName(101, "vista-122.ico");
            imageList1.Images.SetKeyName(102, "vista-123.ico");
            imageList1.Images.SetKeyName(103, "vista-124.ico");
            imageList1.Images.SetKeyName(104, "liste.png");
            imageList1.Images.SetKeyName(105, "vista-013.ico");
            imageList1.Images.SetKeyName(106, "vista-014.ico");
            imageList1.Images.SetKeyName(107, "vista-015.ico");
            imageList1.Images.SetKeyName(108, "vista-016.ico");
            imageList1.Images.SetKeyName(109, "vista-017.ico");
            imageList1.Images.SetKeyName(110, "vista-018.ico");
            imageList1.Images.SetKeyName(111, "vista-019.ico");
            imageList1.Images.SetKeyName(112, "vista-020.ico");
            imageList1.Images.SetKeyName(113, "vista-021.ico");
            imageList1.Images.SetKeyName(114, "vista-022.ico");
            imageList1.Images.SetKeyName(115, "vista-023.ico");
            imageList1.Images.SetKeyName(116, "vista-024.ico");
            imageList1.Images.SetKeyName(117, "vista-025.ico");
            imageList1.Images.SetKeyName(118, "vista-026.ico");
            imageList1.Images.SetKeyName(119, "vista-027.ico");
            imageList1.Images.SetKeyName(120, "vista-028.ico");
            imageList1.Images.SetKeyName(121, "vista-029.ico");
            // 
            // listView1
            // 
            listView1.ContextMenuStrip = copier;
            listView1.GroupImageList = imageList1;
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(347, 53);
            listView1.Name = "listView1";
            listView1.Size = new Size(237, 349);
            listView1.SmallImageList = imageList1;
            listView1.StateImageList = imageList1;
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ItemActivate += listView1_ItemActivate;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.MouseUp += ListView_MouseUp;
            // 
            // copier
            // 
            copier.Items.AddRange(new ToolStripItem[] { copiezToolStripMenuItem, suppriemrToolStripMenuItem });
            copier.Name = "Fichier";
            copier.Size = new Size(181, 70);
            // 
            // copiezToolStripMenuItem
            // 
            copiezToolStripMenuItem.Name = "copiezToolStripMenuItem";
            copiezToolStripMenuItem.Size = new Size(129, 22);
            copiezToolStripMenuItem.Text = "Copiez";
            copiezToolStripMenuItem.Click += copiezToolStripMenuItem_Click;
            // 
            // suppriemrToolStripMenuItem
            // 
            suppriemrToolStripMenuItem.Name = "suppriemrToolStripMenuItem";
            suppriemrToolStripMenuItem.Size = new Size(180, 22);
            suppriemrToolStripMenuItem.Text = "Suppriemr";
            suppriemrToolStripMenuItem.Click += suppriemrToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(347, 405);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "list";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(428, 405);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "small icon";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(509, 405);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Large Icon";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.AccessibleRole = AccessibleRole.SplitButton;
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Location = new Point(610, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 16);
            textBox1.TabIndex = 5;
            textBox1.Text = "Emplacement :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(701, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(398, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(787, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Enabled = false;
            textBox4.Location = new Point(610, 136);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 16);
            textBox4.TabIndex = 7;
            textBox4.Text = "Derniere date de modification :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(659, 194);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(122, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Control;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Enabled = false;
            textBox6.Location = new Point(610, 197);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(141, 16);
            textBox6.TabIndex = 9;
            textBox6.Text = "Taille :";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1124, 484);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(treeView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            coller.ResumeLayout(false);
            copier.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem applicationToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private TreeView treeView1;
        private ImageList imageList1;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ContextMenuStrip copier;
        private ToolStripMenuItem copiezToolStripMenuItem;
        private ToolStripMenuItem suppriemrToolStripMenuItem;
        private ContextMenuStrip coller;
        private ToolStripMenuItem collerToolStripMenuItem;
    }
}
