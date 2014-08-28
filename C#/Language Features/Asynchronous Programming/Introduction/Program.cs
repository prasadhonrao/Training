using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making a request");
            DownloadWebSiteDetails(); // Note this is async call as 'Request completed' gets displayed before it shows response text
            Console.WriteLine("Request completed");
            Console.ReadLine();
        }

        private static async void DownloadWebSiteDetails()
        {
            string url = "http://Microsoft.com";
            var client = new WebClient();
            var response = await client.DownloadStringTaskAsync(url);
            Console.WriteLine(response);
        }
    }
}
