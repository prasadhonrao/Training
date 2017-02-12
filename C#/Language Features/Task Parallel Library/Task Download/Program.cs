using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Training.CSharp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Download using TPL - asynchronous operation");
            // Asyc operation uses threads from thread pool. CLR manages threads from threadpool

            DownloadUsingParallelTasks();

            Console.WriteLine("Main thread id is {0}", Thread.CurrentThread.ManagedThreadId);

            Console.Read();
        }

        private static void DownloadUsingParallelTasks()
        {
            string[] urls = { "http://www.Microsoft.com", "http://Apple.com", "http://Google.com" };

            Parallel.ForEach(urls, url =>
            {
                var client = new WebClient();
                string result = client.DownloadString(url);
                Console.WriteLine("Downloading {0} chars for {1} using thread {2}", result.Length, url.ToString(), Thread.CurrentThread.ManagedThreadId);
            });

        }
    }
}
