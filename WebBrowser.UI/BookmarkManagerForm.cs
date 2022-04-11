using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;



namespace WebBrowser.UI
{
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            // get items from the bookmark database
            var items = BookmarkManager.GetItems();
            foreach (var item in items)
            {
                // show bookmark items in the listbox
                listBox1.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
            }
        }
    }
}
