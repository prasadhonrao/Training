using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            // ENTER CONNECTION STRING
            const string connectionString = "";

            while (true)
            {
                var factory = MessagingFactory.CreateFromConnectionString(connectionString);
                var receiveClient = factory.CreateQueueClient("unsubscribe-queue");
                var receivedMessage = receiveClient.Receive();
                if (receivedMessage != null)
                {
                    var messageBody = receivedMessage.GetBody<string>();
                    receivedMessage.Complete();
                    Console.WriteLine("Message received from client : " +  messageBody);
                }
            }
        }
    }
}
