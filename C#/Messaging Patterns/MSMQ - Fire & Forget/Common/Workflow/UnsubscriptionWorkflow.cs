using System.Threading;

namespace Workflow
{
    public class UnsubscriptionWorkflow
    {
        public static void Run(string emailAddress)
        {
            SoftDeleteFromDatabase();
            UpdateCRM();
            UpdateCustomerDetails();
        }

        private static void UpdateCustomerDetails()
        {
            Thread.Sleep(1000);
        }

        private static void UpdateCRM()
        {
            Thread.Sleep(1000);
        }

        private static void SoftDeleteFromDatabase()
        {
            Thread.Sleep(1000);
        }
    }
}
