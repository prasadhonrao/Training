using Microsoft.ServiceBus.Messaging;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // ENTER CONNECTION STRING
            const string connectionString = "";

            while (true)
            {
                Console.Write("Enter message text : ");
                var userInput = Console.ReadLine();

                var factory = MessagingFactory.CreateFromConnectionString(connectionString);
                var queueClient = factory.CreateMessageSender("unsubscribe-queue");
                var message = new BrokeredMessage(userInput);
                queueClient.Send(message);
                Console.WriteLine("Message sent successfully");
            }
        }
    }
}
