using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB
{
    public partial class MainForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            listbox.Items.Add(textbox.Text);
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            listbox.SelectedItem.Text = textbox.Text;
        }

        protected void Unnamed_Click2(object sender, EventArgs e)
        {
            listbox.Items.Remove(listbox.SelectedItem);
        }
    }
}