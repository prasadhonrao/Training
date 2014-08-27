namespace Training.CSharp.NonChain
{
    class Employee : IExpenseApprover
    {
        public string Name { get; private set; }
        public decimal ApprovalLimit { get; private set; }

        public Employee(string name, decimal approvalLimit)
        {
            this.Name = name;
            this.ApprovalLimit = approvalLimit;
        }

        public ApprovalResponse ApproveExpense(IExpenseReport report)
        {
            if (report.Total <= this.ApprovalLimit)
                return ApprovalResponse.Approved;
            return ApprovalResponse.BeyondApprovalLimit;
        }

    }
}
