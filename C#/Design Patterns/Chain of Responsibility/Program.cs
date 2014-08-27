using Training.CSharp.NonChain;
using System;
using System.Collections.Generic;

namespace Training.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> mgrs = new List<Employee>
            {
                new Employee("Prasad Honrao", 1000),
                new Employee("Colin Gray", 2000),
                new Employee("John Papa", 3000),
                new Employee("Dan Wahlin", 4000)
            };

            while (true)
            {
                Console.WriteLine("Enter expense amount");
                var amount = Console.ReadLine();
                ExpenseReport report = new ExpenseReport(Convert.ToDecimal(amount));

                bool expenseReportProcessed = false;

                foreach (var approver in mgrs)
                {
                    ApprovalResponse response = approver.ApproveExpense(report);
                    if (response != ApprovalResponse.BeyondApprovalLimit)
                    {
                        Console.WriteLine("The expense report with amount {0} was approved by {1}", report.Total, approver.Name);
                        expenseReportProcessed = true;
                        break;
                    }
                }

                if (!expenseReportProcessed)
                {
                    Console.WriteLine("No one was able to approve expense report!");
                }
            }
        }
    }
}
