namespace Training.CSharp.NonChain
{
    class ExpenseReport : IExpenseReport
    {
        public ExpenseReport(decimal total)
        {
            this.Total = total;
        }

        public decimal Total
        {
            get;
            private set;
        }
    }
}
