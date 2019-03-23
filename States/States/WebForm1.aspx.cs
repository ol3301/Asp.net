using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace States
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            var player = new Player {Username=username.Text,Passw=passw.Text,Age=int.Parse(age.Text) };
            ViewState["player"] = player;
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            var player = (Player)ViewState["player"];
            username.Text = player.Username;
            passw.Text = player.Passw;
            age.Text = player.Age.ToString();
        }
    }
}