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
                folderProgress.Maximum = System.IO.Directory.GetDirectories(folderOriginPath.Text, "*", System.IO.SearchOption.AllDirectories).Count();
                folderProgress.Minimum = 0;
                folderProgress.Step = 1;
                generate(folderOriginPath.Text, folderTargetPath.Text);
                MessageBox.Show("Alle Frames wurden erfolgreich generiert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nicht alle ausgewählten Verzeichnisse existieren.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generate(String path, String targetPath)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo[] directories = directory.GetDirectories();
            FileInfo[] files = directory.GetFiles();

            String content = "<ul>";
            foreach (DirectoryInfo folder in directories)
            {
                String tempPath = targetPath + "\\" + folder.Name;
                Directory.CreateDirectory(tempPath);

                content += Util.createEntry(folder.Name, "", Util.getIconPath(Filetype.FOLDER));

                generate(path + "\\" + folder.Name, tempPath);
            }
            foreach (FileInfo file in files)
            {
                String ext = file.Extension;
                if (!ext.Equals(".db"))
                {
                    content += Util.createEntry(file.Name, "", Util.getIconPath(Util.getFiletype(file.Extension)));
                }
            }

            content += "</ul>";
            TextWriter writer = new StreamWriter(targetPath + "\\frame.html", false, System.Text.Encoding.UTF8, 512);
            writer.Write(content);
            writer.Close();

            folderProgress.PerformStep();
        }
    }
}
