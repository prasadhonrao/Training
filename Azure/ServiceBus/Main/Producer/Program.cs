using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = "<Add endpoint connection string>";
            var client = QueueClient.CreateFromConnectionString(connection);

            var lastKey = ' ';
            var count = 1;

            while (lastKey != 'q')
            {
                var body = $"New Message {count++}";
                BrokeredMessage message = new BrokeredMessage(body);
                client.Send(message);

                Console.WriteLine($"{body} sent");
                lastKey = Console.ReadKey().KeyChar;
            }
        }
    }
}
