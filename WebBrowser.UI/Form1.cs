using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        //private void toolStripTextBox1_Click(object sender, KeyEventArgs e)
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = textBox1.Text;
                if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                {
                    tabPage1.Text = url;
                    webBrowser1.Navigate(url);
                }
            }
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Browser developed by Nicole Mills @nam0068");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                tabPage1.Text=url;
                webBrowser1.Navigate(url);
            }
        }
    }
}
