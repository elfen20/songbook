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
using SongBook;

namespace WebView
{
    public partial class WebView : Form
    {
        const string SETTINGSFILE = "config.ini";
        readonly WVSettings wvSettings;

        public WebView()
        {
            InitializeComponent();
            if (!File.Exists(SETTINGSFILE))
            {
                Log("config.ini not found!");
            }
            wvSettings = WVSettings.FromFile(SETTINGSFILE);
            Init();
            Log("Ready");
        }

        void Log(string t)
        {
            tbLog.AppendText(DateTime.Now.ToString("HH:mm:ss.fff: ") + t + Environment.NewLine);
        }

        void Init()
        {
            if (File.Exists(wvSettings.HtmlTemplateFile))
            {
                tbHtml.Lines = File.ReadAllLines(wvSettings.HtmlTemplateFile);
            }
            else
            {
                Log("html template not found!");
            }

            if (File.Exists(wvSettings.CssTemplateFile))
            {
                tbCss.Lines = File.ReadAllLines(wvSettings.CssTemplateFile);
            }
            else
            {
                Log("css template not found!");
            }

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                if (File.Exists(args[1]))
                {
                    tbSongtext.Text = File.ReadAllText(args[1]);
                }
            }

        }

        private void saveTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(wvSettings.HtmlTemplateFile, tbHtml.Text);
            File.WriteAllText(wvSettings.CssTemplateFile, tbCss.Text);
        }

        private void Do()
        {
            var song = Song.FromText(tbSongtext.Text);

        }

        private void WebView_Shown(object sender, EventArgs e)
        {
            Do();
        }
    }
}
