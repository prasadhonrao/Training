using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            var connection = "<Add endpoint connection string>";
            var client = QueueClient.CreateFromConnectionString(connection);

            client.OnMessage(message =>
            {
                Console.WriteLine("Received : " + message.GetBody<string>());
            });

            Console.ReadLine();
        }
    }
}
