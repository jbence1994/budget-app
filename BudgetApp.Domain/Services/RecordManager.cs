using BudgetApp.Application.ViewModels;
using BudgetApp.Core.Models;

namespace BudgetApp.Domain.Services
{
    public class RecordManager
    {
        public IncomeRecord CreateIncomeRecord(CreateIncomeRecordViewModel createIncomeRecordViewModel)
        {
            return new IncomeRecord
            {
                Amount = createIncomeRecordViewModel.Amount,
                Source = createIncomeRecordViewModel.Source,
                Category = (IncomeCategory)createIncomeRecordViewModel.Category,
                Comment = createIncomeRecordViewModel.Comment,
                CreatedDateTime = DateTime.Now
            };
        }

        public ExpenseRecord CreateExpenseRecord(CreateExpenseRecordViewModel createExpenseRecordViewModel)
        {
            return new ExpenseRecord
            {
                Amount = createExpenseRecordViewModel.Amount,
                Category = (ExpenseCategory)createExpenseRecordViewModel.Category,
                Comment = createExpenseRecordViewModel.Comment,
                CreatedDateTime = DateTime.Now
            };
        }
    }
}
