using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DebugIt
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            Trace.Write("Calling Add function");
            ResultLabel.Text = (int.Parse(FirstNumber.Text) + int.Parse(SecondNumber.Text)).ToString();
        }
    }
}