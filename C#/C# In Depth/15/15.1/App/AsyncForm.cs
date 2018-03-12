using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class AsyncForm : Form
    {
        public AsyncForm()
        {
            InitializeComponent();

            this.GetLengthButton.Click += DisplayWebSiteLength;
        }

        async void DisplayWebSiteLength(object sender, EventArgs e)
        {
            lblSize.Text = "Fetching...";

            using (HttpClient client = new HttpClient())
            {
                Task<string> task = client.GetStringAsync("http://Microsoft.com");
                string text = await task;

                lblSize.Text = text.Length.ToString();
            }
        }
    }
}
