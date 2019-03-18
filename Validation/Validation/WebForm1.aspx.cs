using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            Valid valid = new Valid();
            if (TryUpdateModel(valid, new FormValueProvider(ModelBindingExecutionContext)))
            {
                lbl.Text = (valid.t1 / valid.t2).ToString();
            }
        }
    }
}