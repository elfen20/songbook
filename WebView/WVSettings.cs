using Cave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebView
{
    struct WVSettings
    {
        public string HtmlTemplateFile;
        public string CssTemplateFile;


        public static WVSettings FromFile(string settingsFile)
        {
            WVSettings newSettings = default;
            var reader = IniReader.FromFile(settingsFile);
            newSettings.HtmlTemplateFile = reader.ReadString("Files", "HtmlTemplate", "../../template/template.html");
            newSettings.CssTemplateFile = reader.ReadString("Files", "CssTemplate", "../../template/template.css");
            return newSettings;
        }
    }
}
