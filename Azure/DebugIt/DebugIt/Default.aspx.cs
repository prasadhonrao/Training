using System;

namespace DebugIt
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) => 
            System.Diagnostics.Trace.TraceInformation("Page Loaded @ " + DateTime.Now.ToShortTimeString());

        protected void AddButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.TraceInformation("Calling Add function");
            ResultLabel.Text = (int.Parse(FirstNumber.Text) + int.Parse(SecondNumber.Text)).ToString();
        }
    }
}