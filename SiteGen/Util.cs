using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SiteGen
{
    class Util
    {
        private static String getFiletype(String extension)
        {
            String type;
            String lower = extension.ToLower();

            if (lower.Contains("doc"))
            {
                type = "DOC";
                if (lower.Contains("docx"))
                {
                    type = "DOCX";
                }
            }
            else if (lower.Contains("ppt"))
            {
                type = "PPT";
                if (lower.Contains("pptx")) {
                    type = "PPTX";
                }
            }
            else if (lower.Contains("xls"))
            {
                type = "XLS";
                if (lower.Contains("xlsx")) {
                    type = "XLSX";
                }
            }
            else if (lower.Contains("pdf"))
            {
                type = "PDF";
            }
            else if (lower.Contains("wmv"))
            {
                type = "Movie";
            }
            else if (lower.Contains("folder"))
            {
                type = "Folder";
            }
            else
            {
                type = "File";
            }
            return type;
        }

        private static String getIconPath(String filetype, int subLevel)
        {
            String iconPath = "";
            for (int i = 0; i < subLevel; i++)
            {
                iconPath += "..\\";
            }
            iconPath += "icons\\" + filetype + ".png";
            return iconPath;
        }

        public static String createEntry(String fileName, String extension, int subLevel) {
            String entry;
            String iconPath = getIconPath(getFiletype(extension), subLevel);
            if (extension.Equals("Folder"))
            {
                entry = "<tr><td width='60'><a href='" + fileName + "/frame.html'><img src='" + iconPath + "' width='30' height='30'></a></td>";
                entry += "<td width='254'><a href='" + fileName + "/frame.html'>" + fileName + "</a></td>";
            }
            else
            {
                entry = "<tr><td width='60'><a href='" + fileName + "'><img src='" + iconPath + "' width='30' height='30'></a></td>";
                entry += "<td width='254'><a href='" + fileName + "'>" + fileName + "</a></td>";
            }
            entry += "</tr>";
            return entry;
        }
    }
}
