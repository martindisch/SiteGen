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

            }
            else
            {
                MessageBox.Show("Nicht alle ausgewählten Verzeichnisse existieren.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
