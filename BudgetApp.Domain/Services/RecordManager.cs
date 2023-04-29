using BudgetApp.Core.Models;

namespace BudgetApp.Domain.Services
{
    public class RecordManager
    {
        public IncomeRecord CreateIncomeRecord(
            double amount,
            string source,
            IncomeCategory incomeCategory,
            string comment
        )
        {
            return new IncomeRecord
            {
                Amount = amount,
                Source = source,
                Category = incomeCategory,
                Comment = comment,
                CreatedDateTime = DateTime.Now
            };
        }

        public ExpenseRecord CreateExpenseRecord(
            double amount,
            ExpenseCategory expenseCategory,
            string comment
        )
        {
            return new ExpenseRecord
            {
                Amount = amount,
                Category = expenseCategory,
                Comment = comment,
                CreatedDateTime = DateTime.Now
            };
        }
    }
}
