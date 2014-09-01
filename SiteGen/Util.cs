using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteGen
{
    enum Filetype
    {
        UNKNOWN,
        POWERPOINT,
        WORD,
        EXCEL,
        PDF,
        FOLDER
    };

    class Util
    {
        public static Filetype getFiletype(String extension)
        {
            Filetype type;
            String lower = extension.ToLower();

            if (lower.Contains("doc"))
            {
                type = Filetype.WORD;
            }
            else if (lower.Contains("ppt"))
            {
                type = Filetype.POWERPOINT;
            }
            else if (lower.Contains("xls"))
            {
                type = Filetype.EXCEL;
            }
            else if (lower.Contains("pdf"))
            {
                type = Filetype.PDF;
            }
            else
            {
                type = Filetype.UNKNOWN;
            }
            return type;
        }

        public static String getIconPath(Filetype filetype)
        {
            return filetype.ToString();
        }

        public static String createEntry(String fileName, String filePath, String iconPath) {
            return "<li>" + fileName + "  -  " + iconPath + "</li>";
        }
    }
}
