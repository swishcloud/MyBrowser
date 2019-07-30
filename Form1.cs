using CefSharp;
using CefSharp.WinForms;
using MyBrowser.CefSharp.Handlers;
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

namespace MyBrowser
{
    public partial class FormMain : Form
    {
        public static FormMain Instance { get; private set; }
        public FormMain()
        {
            Instance = this;
            InitializeComponent();

            var settings = new CefSettings();
            settings.CachePath = Directory.GetCurrentDirectory() + "/cache";
            Cef.Initialize(settings);


        }
        public ChromiumWebBrowser AddBrowserTab(string uri)
        {
            ChromiumWebBrowser browser = null;
            this.Invoke(new Action(() =>
            {
                var tabPage = new TabPage(uri);
                var formBrowser = new FormBrowser(uri,tabPage);
                formBrowser.TopLevel = false;
                formBrowser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formBrowser.Dock = DockStyle.Fill;
                formBrowser.Show();
                tabPage.Controls.Add(formBrowser);
                tabControl.Controls.Add(tabPage);
                tabControl.SelectedTab = tabPage;
            }));
            return browser;
        }


        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AddBrowserTab("https://translate.google.cn/?hl=zh-CN&tab=TT#view=home&op=translate&sl=en&tl=zh-CN");
            AddBrowserTab("https://fanyi.baidu.com/");
        }
    }
}
