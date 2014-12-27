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
                const string queueAddress = @"HomeOffice\private$\msmq-test-tx";

                using (var msmq = new MessageQueue(queueAddress))
                {
                    while (true)
                    {
                        using (var tx = new MessageQueueTransaction())
                        {
                            tx.Begin();
                            var message = msmq.Receive(tx);
                            message.Formatter = new XmlMessageFormatter(new[] {typeof (UnsubscribeCommand)});
                            var command = (UnsubscribeCommand) message.Body;
                            Console.WriteLine("Starting unsubscription for " + command.EmailAddress);
                            UnsubscriptionWorkflow.Run(command.EmailAddress);
                            Console.WriteLine("Unsubscribe process completed for " + command.EmailAddress);
                            tx.Commit();
                        }
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
