using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZMQ;

namespace ZeroMQ___Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press [Enter] key to read the messages");
            Console.ReadLine();

            var context = new Context();
            using (var server = context.Socket(SocketType.PULL))
            {
                server.Bind("tcp://127.0.0.1:5555");
                while (true)
                {
                    var message = server.Recv(Encoding.UTF8);
                    Console.WriteLine(message);
                }
            }

            Console.ReadLine();
        }
    }
}
