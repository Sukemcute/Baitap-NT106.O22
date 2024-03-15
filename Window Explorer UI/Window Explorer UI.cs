using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Explorer_UI
{
    public partial class FormFE : Form
    {
        public FormFE()
        {
            InitializeComponent();
        }

        private void Path_Click(object sender, EventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    webBrowser.Url = new Uri(fbd.SelectedPath);
                    txtPath.Text = fbd.SelectedPath;
                }
                    
            }          
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if ( webBrowser.CanGoBack)
                webBrowser.GoBack();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward) 
                webBrowser.GoForward();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
