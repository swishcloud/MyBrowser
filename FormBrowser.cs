using CefSharp.WinForms;
using MyBrowser.CefSharp.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser
{
    public partial class FormBrowser : Form
    {
        TabPage tabPage;
        string uri;
        ChromiumWebBrowser browser;
        public FormBrowser(string uri, TabPage tabPage)
        {
            this.tabPage = tabPage;
            this.uri = uri;
            InitializeComponent();

            var uriBarHeight = 40;
            panelBrowser.Width = this.Width;
            panelBrowser.Height = this.Height - uriBarHeight;
            panelBrowser.Location = new Point(0, uriBarHeight);
        }

        private void Browser_TitleChanged(object sender, global::CefSharp.TitleChangedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                tabPage.Text = e.Title;
            }));
        }

        private void FormBrowser_Load(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                browser = new ChromiumWebBrowser(uri);
                browser.LifeSpanHandler = new LifeSpanHandler();
                browser.RequestHandler = new RequestHandler();
                browser.TitleChanged += Browser_TitleChanged;
                browser.Tag = this;
                panelBrowser.Controls.Add(browser);
            }));
        }
        public void UpdateUriBar(string uri)
        {
            this.Invoke(new Action(() =>
            {
                txtUriBar.Text = uri;
            }));
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            browser.Load(txtUriBar.Text);
        }
    }
}
