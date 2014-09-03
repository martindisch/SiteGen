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
                if (!file.Attributes.HasFlag(FileAttributes.Hidden))
                {
                    content += Util.createEntry(file.Name, file.Extension, subLevel);
                }
            }

            content += "</table> </body> </html>";
            
            File.WriteAllText(targetPath + "\\frame.html", content);

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

                String contents = @"<!DOCTYPE HTML PUBLIC '-//W3C//DTD HTML 4.01//EN' 'http://www.w3.org/TR/html4/strict.dtd'> <html> <head> 	<title>Menu</title> 	<link rel='stylesheet' href='css/slidedown-menu2.css'> 	<script type='text/javascript' src='js/slidedown-menu2.js'></script> 	<style type='text/css'> 	/* General css for this page */ 	html{ 		height:100%; 	} 	body{ 		font-family: Trebuchet MS, Lucida Sans Unicode, Arial, sans-serif; 		font-size:0.8em; 		margin:0px; 		padding:0px;  		background-color:#E2EBED; 		height:100%; 		text-align:center; 	} 	.clear{ 		clear:both; 	}  	#mainContainer{ 		width:760px; 		text-align:left; 		margin:0 auto; 		background-color: #FFF; 		border-left:1px solid #000; 		border-right:1px solid #000; 		height:100%; 	}  	#topBar{ 		width:760px; 		height:100px; 	} 	#leftMenu{ 		width:200px; 		padding-left:10px; 		padding-right:10px; 		float:left; 	} 	#mainContent{ 		width: 520px; 		padding-right:10px; 		float:left; 	} 	</style> </head> <body> <div id='mainContainer'>  	<br/><br/> 	<div id='leftMenu'> 		<!-- START OF MENU --> 		<div id='dhtmlgoodies_slidedown_menu'> 			<ul>";
                contents += getContentsEntries(contentsOriginPath.Text);
                contents += "</ul> 		</div> 		<!-- END OF MENU --> 		<script type='text/javascript'> 		initSlideDownMenu(); 		</script> 	</div>  </DIV>  </body> </html>";

                SaveFileDialog dg = new SaveFileDialog();
                dg.FileName = "navi_links2.html";
                dg.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";
                dg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (dg.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dg.FileName, contents, Encoding.UTF8);
                    MessageBox.Show("Das Inhaltsverzeichnis wurde gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Dieses Verzeichnis existiert nicht.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String getContentsEntries(String path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo[] directories = directory.GetDirectories();

            String entries = "";
            foreach (DirectoryInfo folder in directories)
            {
                entries += getContentsEntry(folder.FullName, "../data/" + folder.Name);
            }
            contentsProgress.PerformStep();
            return entries;
        }

        private String getContentsEntry(String path, String href)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo[] directories = directory.GetDirectories();

            String entry = "<li><a href='" + href + "/frame.html" + "' target='leftFrame1'>" + directory.Name + "</a>";
            if (directories.Length > 0)
            {
                entry += "<ul>";
                foreach (DirectoryInfo folder in directories)
                {
                    entry += getContentsEntry(folder.FullName, href + "/" + folder.Name);
                }
                entry += "</ul>";
            }
            entry += "</li>";
            contentsProgress.PerformStep();
            return entry;
        }
    }
}
