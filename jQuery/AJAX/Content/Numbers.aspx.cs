using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _05Ajax.Content
{
    public partial class Numbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var pageSize = (Request["pagesize"] == null ? 10 : int.Parse(Request["pagesize"]));

            for (int i = 0; i < pageSize; i++)
            {
                ListItem item = new ListItem(i.ToString());
                lstNumbers.Items.Add(item);
            }
        }
    }
}