
namespace Training.CSharp.NonChain
{
    interface IExpenseApprover
    {
        ApprovalResponse ApproveExpense(IExpenseReport report);
    }
}
