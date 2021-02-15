
namespace WebView
{
    partial class WebView
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpView = new System.Windows.Forms.TabPage();
            this.scView = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tbSongtext = new System.Windows.Forms.TextBox();
            this.tabpSource = new System.Windows.Forms.TabPage();
            this.scSource = new System.Windows.Forms.SplitContainer();
            this.tbHtml = new System.Windows.Forms.TextBox();
            this.tbCss = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabpView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scView)).BeginInit();
            this.scView.Panel1.SuspendLayout();
            this.scView.Panel2.SuspendLayout();
            this.scView.SuspendLayout();
            this.tabpSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSource)).BeginInit();
            this.scSource.Panel1.SuspendLayout();
            this.scSource.Panel2.SuspendLayout();
            this.scSource.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpView);
            this.tabControl1.Controls.Add(this.tabpSource);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1131, 416);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpView
            // 
            this.tabpView.Controls.Add(this.scView);
            this.tabpView.Location = new System.Drawing.Point(4, 22);
            this.tabpView.Name = "tabpView";
            this.tabpView.Padding = new System.Windows.Forms.Padding(3);
            this.tabpView.Size = new System.Drawing.Size(1123, 390);
            this.tabpView.TabIndex = 0;
            this.tabpView.Text = "View";
            this.tabpView.UseVisualStyleBackColor = true;
            // 
            // scView
            // 
            this.scView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scView.Location = new System.Drawing.Point(3, 3);
            this.scView.Name = "scView";
            // 
            // scView.Panel1
            // 
            this.scView.Panel1.Controls.Add(this.webBrowser1);
            // 
            // scView.Panel2
            // 
            this.scView.Panel2.Controls.Add(this.tbSongtext);
            this.scView.Size = new System.Drawing.Size(1117, 384);
            this.scView.SplitterDistance = 602;
            this.scView.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(602, 384);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // tbSongtext
            // 
            this.tbSongtext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSongtext.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSongtext.Location = new System.Drawing.Point(0, 0);
            this.tbSongtext.Multiline = true;
            this.tbSongtext.Name = "tbSongtext";
            this.tbSongtext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSongtext.Size = new System.Drawing.Size(511, 384);
            this.tbSongtext.TabIndex = 0;
            // 
            // tabpSource
            // 
            this.tabpSource.Controls.Add(this.scSource);
            this.tabpSource.Location = new System.Drawing.Point(4, 22);
            this.tabpSource.Name = "tabpSource";
            this.tabpSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabpSource.Size = new System.Drawing.Size(1123, 390);
            this.tabpSource.TabIndex = 1;
            this.tabpSource.Text = "Source";
            this.tabpSource.UseVisualStyleBackColor = true;
            // 
            // scSource
            // 
            this.scSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSource.Location = new System.Drawing.Point(3, 3);
            this.scSource.Name = "scSource";
            // 
            // scSource.Panel1
            // 
            this.scSource.Panel1.Controls.Add(this.tbHtml);
            // 
            // scSource.Panel2
            // 
            this.scSource.Panel2.Controls.Add(this.tbCss);
            this.scSource.Size = new System.Drawing.Size(1117, 384);
            this.scSource.SplitterDistance = 544;
            this.scSource.TabIndex = 0;
            // 
            // tbHtml
            // 
            this.tbHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHtml.Font = new System.Drawing.Font("Consolas", 10F);
            this.tbHtml.Location = new System.Drawing.Point(0, 0);
            this.tbHtml.Multiline = true;
            this.tbHtml.Name = "tbHtml";
            this.tbHtml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbHtml.Size = new System.Drawing.Size(544, 384);
            this.tbHtml.TabIndex = 0;
            // 
            // tbCss
            // 
            this.tbCss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCss.Font = new System.Drawing.Font("Consolas", 10F);
            this.tbCss.Location = new System.Drawing.Point(0, 0);
            this.tbCss.Multiline = true;
            this.tbCss.Name = "tbCss";
            this.tbCss.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCss.Size = new System.Drawing.Size(569, 384);
            this.tbCss.TabIndex = 1;
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLog.Location = new System.Drawing.Point(0, 440);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(1131, 131);
            this.tbLog.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.doToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1131, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.saveTemplateToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            // 
            // saveTemplateToolStripMenuItem
            // 
            this.saveTemplateToolStripMenuItem.Name = "saveTemplateToolStripMenuItem";
            this.saveTemplateToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.saveTemplateToolStripMenuItem.Text = "Save Template";
            this.saveTemplateToolStripMenuItem.Click += new System.EventHandler(this.saveTemplateToolStripMenuItem_Click);
            // 
            // doToolStripMenuItem
            // 
            this.doToolStripMenuItem.Name = "doToolStripMenuItem";
            this.doToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.doToolStripMenuItem.Text = "Do";
            // 
            // WebView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 571);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WebView";
            this.Text = "Songbook WebView";
            this.Shown += new System.EventHandler(this.WebView_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabpView.ResumeLayout(false);
            this.scView.Panel1.ResumeLayout(false);
            this.scView.Panel2.ResumeLayout(false);
            this.scView.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scView)).EndInit();
            this.scView.ResumeLayout(false);
            this.tabpSource.ResumeLayout(false);
            this.scSource.Panel1.ResumeLayout(false);
            this.scSource.Panel1.PerformLayout();
            this.scSource.Panel2.ResumeLayout(false);
            this.scSource.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSource)).EndInit();
            this.scSource.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpView;
        private System.Windows.Forms.SplitContainer scView;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox tbSongtext;
        private System.Windows.Forms.TabPage tabpSource;
        private System.Windows.Forms.SplitContainer scSource;
        private System.Windows.Forms.TextBox tbHtml;
        private System.Windows.Forms.TextBox tbCss;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTemplateToolStripMenuItem;
    }
}

