using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Download using single thread - synchronous operation");

            DownloadInformationUsingSingleThread();

            // main thread is blocked till the download is complete
            Console.WriteLine("Main thread id is {0}", Thread.CurrentThread.ManagedThreadId);

            Console.Read();
        }

        private static void DownloadInformationUsingSingleThread()
        {
            var watch = new Stopwatch();
            watch.Start();

            string[] urls = {
                                "http://www.Microsoft.com",
                                "http://www.Apple.com",
                                "http://www.Google.com"
                            };

            foreach (var url in urls)
            {
                var client = new WebClient();
                var result = client.DownloadString(url);
                Console.WriteLine("Downloading {0} chars for {1} using thread {2}", result.Length, url.ToString(), Thread.CurrentThread.ManagedThreadId);
            }

            watch.Stop();
            Console.WriteLine("Execution Time {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
