using System.Threading;

namespace Workflow
{
    public class UnsubscriptionWorkflow
    {
        private const int sleepTime = 50000;

        public static void Run(string emailAddress)
        {
            SoftDeleteFromDatabase();
            UpdateCRM();
            UpdateCustomerDetails();
        }

        private static void UpdateCustomerDetails()
        {
            Thread.Sleep(sleepTime);
        }

        private static void UpdateCRM()
        {
            Thread.Sleep(sleepTime);
        }

        private static void SoftDeleteFromDatabase()
        {
            Thread.Sleep(sleepTime);
        }
    }
}
