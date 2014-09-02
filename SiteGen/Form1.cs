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

                String contents = @"<!DOCTYPE HTML PUBLIC '-//W3C//DTD HTML 4.01 Transitional//EN' 'http://www.w3.org/TR/html4/loose.dtd'> <html> <head>    	<style type='text/css'> 	 	/* The following CSS is only for the demo */ 	 	html{ 		 		height:100%; 	 	} 	 	body{  	margin-left: 0px; 	margin-top: 0px;   	 		 		font-family: Trebuchet MS, Lucida Sans Unicode, Arial, sans-serif; 		 		margin:0px; 		 		padding:0px; 		 		height:100%; 		 		font-size:0.9em; 		 		line-height:130%; 		 		background-color:#E2EBED; 		 		text-align:left; 	 	} 	 	  	#mainContainer{ 		 		width:760px; 		 		margin: 0 auto; 		 		border-left:1px solid #000; 		 		border-right:1px solid #000; 		 		height:100%; 		 		text-align:left; 		 		background-color:#FFF; 	 	} 	 	#leftColumn{  		width:140px;  		float:left;  		padding-left:20px;  	}  	#mainContent{  		width:590px;  		padding-left:10px;  		padding-right:10px;  		float:left;  	}  	#topBar{  		height:40px;  	}  	/* End of demo CSS */  	 /**************************************************************************************** 	* 	LAYOUT CSS FOR THE MENU 	****************************************************************************************/  	#dhtmlgoodies_listMenu a{	/* Main menu items */  		color:#000;  		text-decoration:none;  		font-weight:bold;   	}  	#dhtmlgoodies_listMenu ul li a{	/* Sub menu */  		color: #000;  		font-weight:normal;  	}  	#dhtmlgoodies_listMenu ul li ul li a{	/* Sub Sub menu */  		color: #000;  		font-style:italic;  		font-size:0.9em;  		font-weight:normal; 	}   	#dhtmlgoodies_listMenu .activeMenuLink{	/* Styling of active menu item */  		color:blue;  	}     	/* 	No bullets 	*/  	#dhtmlgoodies_listMenu li{  		list-style-type:none;  	}   	/* 	No margin and padding 	*/  	#dhtmlgoodies_listMenu, #dhtmlgoodies_listMenu ul{  		margin:0px;  		padding:0px;  	}   	/* Margin of sub menu items */  	#dhtmlgoodies_listMenu ul{  		display:none;  		margin-left:10px;  	}  	</style>   	<script type='text/javascript'> 	 	/************************************************************************************************************ 	Copyright (C) October 2005  DTHMLGoodies.com, Alf Magne Kalleland  	This library is free software; you can redistribute it and/or 	modify it under the terms of the GNU Lesser General Public 	License as published by the Free Software Foundation; either 	version 2.1 of the License, or (at your option) any later version.  	This library is distributed in the hope that it will be useful, 	but WITHOUT ANY WARRANTY; without even the implied warranty of 	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU 	Lesser General Public License for more details.  	You should have received a copy of the GNU Lesser General Public 	License along with this library; if not, write to the Free Software 	Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA  	Dhtmlgoodies.com., hereby disclaims all copyright interest in this script 	written by Alf Magne Kalleland.  	Alf Magne Kalleland, 2010 	Owner of DHTMLgoodies.com  	************************************************************************************************************/    	var activeMenuItem = new Array();    	function isUlInArray(inputObj,ulObj) 	{  		while(inputObj && inputObj.id!='dhtmlgoodies_listMenu'){  			if(inputObj==ulObj)return true;  			inputObj = inputObj.parentNode; 		}		 		 		return false;  	}    	function showHideSub(e,inputObj) 	 	{ 		  		   		if(!inputObj)inputObj=this;  		var parentObj = inputObj.parentNode;  		var ul = parentObj.getElementsByTagName('UL')[0];  		if(activeMenuItem.length>0){  			for(var no=0;no<activeMenuItem.length;no++){  				if(!isUlInArray(ul,activeMenuItem[0]) && !isUlInArray(activeMenuItem[0],ul)){  					activeMenuItem[no].style.display='none';  					activeMenuItem.splice(no,1);  					no--;  				}  			}   		}  		if(ul.offsetHeight == 0){  			ul.style.display='block';  			activeMenuItem.push(ul);  		}else{  			ul.style.display='none';  		}  	}    	function showHidePath(inputObj) 	 	{  		var startTag = inputObj; 		showHideSub(false,inputObj);  		inputObj = inputObj.parentNode;  		while(inputObj){  			inputObj = inputObj.parentNode; 			if(inputObj.tagName=='LI')showHideSub(false,inputObj.getElementsByTagName('A')[0]);  			if(inputObj.id=='dhtmlgoodies_listMenu')inputObj=false; 	 	} 	}    	function initMenu()  	{  		var obj = document.getElementById('dhtmlgoodies_listMenu');  		var linkCounter=0;  		var aTags = obj.getElementsByTagName('A');  		var activeMenuItem = false;  		var activeMenuLink = false;  		var thisLocationArray = location.href.split(/\//);  		var fileNameThis = thisLocationArray[thisLocationArray.length-1];  		if(fileNameThis.indexOf('?')>0)fileNameThis = fileNameThis.substr(0,fileNameThis.indexOf('?'));  		if(fileNameThis.indexOf('#')>0)fileNameThis = fileNameThis.substr(0,fileNameThis.indexOf('#'));   		for(var no=0;no<aTags.length;no++){  			var parent = aTags[no].parentNode;  			var subs = parent.getElementsByTagName('UL');  			if(subs.length>0){  				aTags[no].onclick = showHideSub; 	 			linkCounter++;  				aTags[no].id = 'aLink' + linkCounter;  			} 	 			 			 			if(aTags[no].href.indexOf(fileNameThis)>=0 && aTags[no].href.charAt(aTags[no].href.length-1)!='#'){ 				 if(aTags[no].parentNode.parentNode){ 					var parentObj = aTags[no].parentNode.parentNode.parentNode;  					var a = parentObj.getElementsByTagName('A')[0]; 	 					if(a.id && !activeMenuLink){   						activeMenuLink = aTags[no];  						activeMenuItem = a.id;  					}  				}  			}  		}   		if(activeMenuLink){  			activeMenuLink.className='activeMenuLink';  		}  		if(activeMenuItem){  			if(document.getElementById(activeMenuItem))showHidePath(document.getElementById(activeMenuItem)); 	 		}  	} 	 	window.onload = initMenu;  	</script>      <meta http-equiv='Content-Type' content='text/html; charset=utf-8'> <title>Unbenanntes Dokument</title> <style type='text/css'> body { 	background-color: #00F; } </style> </head>  <body>  <div id='mainContainer'>  	<div id='topBar'>   	</div> 	 	<div id='leftColumn'>  		<ul id='dhtmlgoodies_listMenu'>";
                contents += getContentsEntries(contentsOriginPath.Text);
                contents += "</ul>  	</div>  	<div id='mainContent'>  				 	</div>  </div>      </body> </html>";

                SaveFileDialog dg = new SaveFileDialog();
                dg.FileName = "navi_links2.html";
                dg.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";
                dg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (dg.ShowDialog() == DialogResult.OK)
                {
                    /*System.IO.TextWriter writer = new System.IO.StreamWriter(dg.FileName);
                    writer.Write(contents, false, System.Text.Encoding.UTF8, 512);
                    writer.Close();*/
                    File.WriteAllText(dg.FileName, @contents);
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
