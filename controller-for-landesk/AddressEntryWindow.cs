using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controller_for_landesk
{
    public partial class AddressEntryWindow : Form
    {
        /// <summary>
        /// The fully built URL entered by the user.
        /// </summary>
        public string Url { get; set; }

        public AddressEntryWindow()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Url =  string.Format("{0}://{1}:{2}", comboProtocol.SelectedItem, txtHost.Text, txtPort.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    
}
