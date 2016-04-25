using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace controller_for_landesk
{
    public partial class MainWindow : Form
    {

        private ChromiumWebBrowser Browser { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            //Initialize CEF
            var settings = new CefSettings();
            CefSharp.Cef.Initialize(settings);
            
            this.Browser = new ChromiumWebBrowser("google.com") { Dock = DockStyle.Fill};
            this.Controls.Add(this.Browser);

            openToolStripMenuItem_Click(this, new EventArgs());
        }

        /// <summary>
        /// Clears any old browsers and shows a new one.
        /// </summary>
        /// <param name="url"></param>
        private void ShowUrl(string url)
        {
            this.Browser = new ChromiumWebBrowser(url);
            this.Text = string.Format("LanDesk - {0}", url);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new AddressEntryWindow())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var url = form.Url;
                    ShowUrl(url);
                }
            }
        }
    }
}
