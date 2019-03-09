using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB1
{
    public partial class MainForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MoveIn(ListBox source, ListBox target, int[] indexes)
        {
            foreach (var index in indexes)
                target.Items.Add(source.Items[index]);
            foreach (var index in indexes)
                source.Items.RemoveAt(indexes[0]);
        }

        private int[] GetAllIndexesFromListBox(ListBox target)
        {
            int[] idxs = new int[target.Items.Count];
            for (int i = 0; i < target.Items.Count; ++i)
                idxs[i] = i;
            return idxs;
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            MoveIn(listbox1,listbox2, listbox1.GetSelectedIndices());
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            MoveIn(listbox2, listbox1, listbox2.GetSelectedIndices());
        }

        protected void Unnamed_Click2(object sender, EventArgs e)
        {
            MoveIn(listbox1, listbox2, GetAllIndexesFromListBox(listbox1));
        }

        protected void Unnamed_Click3(object sender, EventArgs e)
        {
            MoveIn(listbox2, listbox1, GetAllIndexesFromListBox(listbox2));
        }
    }
}