using BudgetApp.Core.Models;

namespace BudgetApp.Core.Repositories
{
    public interface IExpenseRecordRepository
    {
        ExpenseRecord AddExpenseRecord(ExpenseRecord expenseRecord);
    }
}
