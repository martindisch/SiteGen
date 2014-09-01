using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteGen
{
    class Util
    {
        public static String getFiletype(String extension)
        {
            String type;
            String lower = extension.ToLower();

            if (lower.Contains("doc"))
            {
                type = "Word";
            }
            else if (lower.Contains("ppt"))
            {
                type = "PowerPoint";
            }
            else if (lower.Contains("xls"))
            {
                type = "Excel";
            }
            else if (lower.Contains("pdf"))
            {
                type = "PDF";
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
            entry += "<td width='138'>S Kdt</td>";
            entry += "<td width='89'>01.01.2014</td></tr>";
            return entry;
        }
    }
}
