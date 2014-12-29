using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZMQ;

namespace ZeroMQ___Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press [Enter] key to send the messages");
            Console.ReadLine();

            var watch = new Stopwatch();
            watch.Start();

            var context = new Context();
            using (var client = context.Socket(SocketType.PUSH))
            {
                client.Connect("tcp://127.0.0.1:5555");
                for (int i = 0; i < 1000; i++)
                {
                    client.Send("Message " + i, Encoding.UTF8);
                }
            }

            watch.Stop();
            Console.WriteLine("Total time elapsed " + watch.ElapsedMilliseconds);

            Console.ReadLine(); 
        }
    }
}
