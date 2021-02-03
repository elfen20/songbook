
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
            this.tabpSource = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbHtml = new System.Windows.Forms.TextBox();
            this.tbCss = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tbSongtext = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabpView.SuspendLayout();
            this.tabpSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpView);
            this.tabControl1.Controls.Add(this.tabpSource);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 619);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpView
            // 
            this.tabpView.Controls.Add(this.splitContainer2);
            this.tabpView.Location = new System.Drawing.Point(4, 22);
            this.tabpView.Name = "tabpView";
            this.tabpView.Padding = new System.Windows.Forms.Padding(3);
            this.tabpView.Size = new System.Drawing.Size(953, 593);
            this.tabpView.TabIndex = 0;
            this.tabpView.Text = "View";
            this.tabpView.UseVisualStyleBackColor = true;
            // 
            // tabpSource
            // 
            this.tabpSource.Controls.Add(this.splitContainer1);
            this.tabpSource.Location = new System.Drawing.Point(4, 22);
            this.tabpSource.Name = "tabpSource";
            this.tabpSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabpSource.Size = new System.Drawing.Size(953, 593);
            this.tabpSource.TabIndex = 1;
            this.tabpSource.Text = "Source";
            this.tabpSource.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbHtml);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbCss);
            this.splitContainer1.Size = new System.Drawing.Size(947, 587);
            this.splitContainer1.SplitterDistance = 466;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbHtml
            // 
            this.tbHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHtml.Location = new System.Drawing.Point(0, 0);
            this.tbHtml.Multiline = true;
            this.tbHtml.Name = "tbHtml";
            this.tbHtml.Size = new System.Drawing.Size(466, 587);
            this.tbHtml.TabIndex = 0;
            // 
            // tbCss
            // 
            this.tbCss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCss.Location = new System.Drawing.Point(0, 0);
            this.tbCss.Multiline = true;
            this.tbCss.Name = "tbCss";
            this.tbCss.Size = new System.Drawing.Size(477, 587);
            this.tbCss.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.webBrowser1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbSongtext);
            this.splitContainer2.Size = new System.Drawing.Size(947, 587);
            this.splitContainer2.SplitterDistance = 511;
            this.splitContainer2.TabIndex = 0;
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
            this.webBrowser1.Size = new System.Drawing.Size(511, 587);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // tbSongtext
            // 
            this.tbSongtext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSongtext.Location = new System.Drawing.Point(0, 0);
            this.tbSongtext.Multiline = true;
            this.tbSongtext.Name = "tbSongtext";
            this.tbSongtext.Size = new System.Drawing.Size(432, 587);
            this.tbSongtext.TabIndex = 0;
            // 
            // WebView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 619);
            this.Controls.Add(this.tabControl1);
            this.Name = "WebView";
            this.Text = "Songbook WebView";
            this.tabControl1.ResumeLayout(false);
            this.tabpView.ResumeLayout(false);
            this.tabpSource.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpView;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox tbSongtext;
        private System.Windows.Forms.TabPage tabpSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbHtml;
        private System.Windows.Forms.TextBox tbCss;
    }
}

