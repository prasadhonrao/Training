using Entity;
using System;
using System.Diagnostics;
using System.Messaging;
using Workflow;

namespace AsyncMessageHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Listening...");
                var queueAddress = @"HomeOffice\private$\msmq-test";

                using (var msmq = new MessageQueue(queueAddress))
                {
                    while (true)
                    {
                        var message = msmq.Receive();
                        message.Formatter = new XmlMessageFormatter(new[] { typeof(UnsubscribeCommand) });
                        var command =  (UnsubscribeCommand) message.Body;
                        UnsubscriptionWorkflow.Run(command.EmailAddress);
                        Console.WriteLine("Unsubscribe process completed for " + command.EmailAddress);
                    }
                }
                
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }
    }
}
