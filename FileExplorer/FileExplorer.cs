using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Explorer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] drives = Directory.GetLogicalDrives();
            TreeNode root = null;

            foreach (string drive in drives)
            {
                DriveInfo driveInfo = new DriveInfo(drive);

                if (driveInfo.DriveType == DriveType.Fixed)
                {
                    root = treeViewer.Nodes.Add(drive.ToString());
                    root.Nodes.Add("*");
                    //root.Expand();
                }
            }
        }

        private void treeViewer_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            Fill(e.Node);
        }

        private void treeViewer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.FullPath == null)
            {
                Console.WriteLine("empty node");

                return;
            }

            ShowDirandFileList(e.Node.FullPath);
        }

        private void Fill(TreeNode dirNode)
        {
            TreeNode nonExtensionDirName = null;

            try
            {
                if (dirNode.Nodes.Count == 1 && dirNode.Nodes[0].Text.Equals("*"))
                {
                    //test code
                    //Console.WriteLine(dirNode.Text);
                    //Console.WriteLine(dirNode.Nodes.Count);
                    //for (int i = 0; i < dirNode.Nodes.Count; i++)
                    //{
                    //    Console.WriteLine(dirNode.Nodes[i].Text);
                    //}

                    dirNode.Nodes.Clear();
                    string path = dirNode.FullPath;
                    string[] dirs = Directory.GetDirectories(path);

                    foreach (string dir in dirs)
                    {
                        //test code
                        //Console.WriteLine(dir);
                        nonExtensionDirName = dirNode.Nodes.Add(dir.Substring(dir.LastIndexOf("\\") + 1));
                        nonExtensionDirName.Nodes.Add("*");
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("treeViewer_BeforeExpand Exception : " + exception);
            }
        }

        private void ShowDirandFileList(string path)
        {
            try
            {
                listViewer.Items.Clear();

                string[] directories = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

                foreach (string directory in directories)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(directory);
                    ListViewItem item = new ListViewItem(new string[] {dirInfo.Name, "", "폴더", dirInfo.LastWriteTime.ToString()});
                    listViewer.Items.Add(item);
                }

                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    ListViewItem item = new ListViewItem(new string[] 
                    { fileInfo.Name, (fileInfo.Length/1000 + 1).ToString() + "KB", fileInfo.Extension.Substring(fileInfo.Extension.LastIndexOf(".")+1), fileInfo.LastWriteTime.ToString()});
                    listViewer.Items.Add(item);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("ShowDirandFileList Exception : " + exception);
            }
        }
    }
}
