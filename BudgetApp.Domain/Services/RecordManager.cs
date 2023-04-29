using BudgetApp.Core.Models;

namespace BudgetApp.Domain.Services
{
    public class RecordManager
    {
        public IncomeRecord CreateIncomeRecord()
        {
            return new IncomeRecord();
        }

        public ExpenseRecord CreateExpenseRecord()
        {
            return new ExpenseRecord();
        }
    }
}
