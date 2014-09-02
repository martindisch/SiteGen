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

namespace SiteGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Folder starts here

        private void folderSelectOrigin_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dg = new FolderBrowserDialog();
            dg.ShowNewFolderButton = false;
            dg.RootFolder = System.Environment.SpecialFolder.Desktop;
            if (dg.ShowDialog() == DialogResult.OK)
            {
                folderOriginPath.Text = dg.SelectedPath;
            }
        }

        private void folderSelectTarget_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dg = new FolderBrowserDialog();
            dg.RootFolder = System.Environment.SpecialFolder.Desktop;
            if (dg.ShowDialog() == DialogResult.OK)
            {
                folderTargetPath.Text = dg.SelectedPath;
            }
        }

        private void folderStart_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(folderOriginPath.Text) && Directory.Exists(folderTargetPath.Text))
            {
                folderProgress.Value = 0;
                folderProgress.Maximum = Directory.GetDirectories(folderOriginPath.Text, "*", SearchOption.AllDirectories).Count();
                folderProgress.Minimum = 0;
                folderProgress.Step = 1;
                generate(folderOriginPath.Text, folderTargetPath.Text, 1);
                MessageBox.Show("Alle Frames wurden erfolgreich generiert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nicht alle ausgewählten Verzeichnisse existieren.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generate(String path, String targetPath, int subLevel)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo[] directories = directory.GetDirectories();
            FileInfo[] files = directory.GetFiles();

            String content = "<!DOCTYPE HTML PUBLIC '-//W3C//DTD HTML 4.01 Transitional//EN' 'http://www.w3.org/TR/html4/loose.dtd'> <html> <head> <meta http-equiv='Content-Type' content='text/html; charset=utf-8'> <title>" + directory.Name + "</title> <style type='text/css'> body { 	background-color: #FFF; 	margin-top: 40px;	 } table { 	font-family: Arial, Helvetica, sans-serif; 	font-size: 11pt; } h1 { 	font-family: Arial, Helvetica, sans-serif; 	font-weight: bold; 	font-size: 24px; } </style> </head>  <body> <h1>" + directory.Name + "</h1> <table width='559' height='253' border='0'>";
            foreach (DirectoryInfo folder in directories)
            {
                String tempPath = targetPath + "\\" + folder.Name;
                Directory.CreateDirectory(tempPath);

                content += Util.createEntry(folder.Name, "Folder", subLevel);

                generate(path + "\\" + folder.Name, tempPath, subLevel + 1);
            }
            foreach (FileInfo file in files)
            {
                String ext = file.Extension;
                if (!ext.Equals(".db"))
                {
                    content += Util.createEntry(file.Name, file.Extension, subLevel);
                }
            }

            content += "</table> </body> </html>";
            TextWriter writer = new StreamWriter(targetPath + "\\frame.html", false, System.Text.Encoding.UTF8, 512);
            writer.Write(content);
            writer.Close();

            folderProgress.PerformStep();
        }

        // Contents starts here

        private void contentsSelectOrigin_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dg = new FolderBrowserDialog();
            dg.ShowNewFolderButton = false;
            dg.RootFolder = System.Environment.SpecialFolder.Desktop;
            if (dg.ShowDialog() == DialogResult.OK)
            {
                contentsOriginPath.Text = dg.SelectedPath;
            }
        }

        private void contentsGo_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(contentsOriginPath.Text))
            {
                contentsProgress.Value = 0;
                contentsProgress.Maximum = Directory.GetDirectories(contentsOriginPath.Text, "*", SearchOption.AllDirectories).Count();
                contentsProgress.Minimum = 0;
                contentsProgress.Step = 1;
                // Do work here
                // Show SaveFile dialog
                MessageBox.Show("Das Inhaltsverzeichnis wurde gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dieses Verzeichnis existiert nicht.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
