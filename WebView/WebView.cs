using Cave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebView
{
    public partial class WebView : Form
    {
        const string SETTINGSFILE = "config.ini";

        public WebView()
        {
            InitializeComponent();
            Init();
            Log("Ready");
        }

        void Log(string t)
        {
            tbLog.AppendText(DateTime.Now.ToString("HH:mm:ss.fff: ") + t + Environment.NewLine);
        }

        void Init()
        {
            if (!File.Exists(SETTINGSFILE))
            {
                Log("config.ini not found!");
            }

            var reader = IniReader.FromFile(SETTINGSFILE);
            string s = reader.ReadString("Files", "HtmlTemplate", "../../template/template.html");
            if (File.Exists(s))
            {
                tbHtml.Lines = File.ReadAllLines(s);
            }
            else
            {
                Log("html template not found!");
            }

            s = reader.ReadString("Files", "CssTemplate", "../../template/template.css");
            if (File.Exists(s))
            {
                tbCss.Lines = File.ReadAllLines(s);
            }
            else
            {
                Log("css template not found!");
            }
        }
    }
}
