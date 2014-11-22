using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Serialization.Json;

namespace _05Ajax.Content
{
    public partial class GetCustomerInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "application/json";

            var id = int.Parse(Request["id"]);
            var customer = new Customer
            {
                ID = id,
                FirstName = "Prasad",
                LastName = "Honrao"
            };

            var ser = new DataContractJsonSerializer(typeof(Customer));
            ser.WriteObject(Response.OutputStream, customer);
        }
    }

    [Serializable]
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}