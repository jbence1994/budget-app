using BudgetApp.Core.Models;
using BudgetApp.Core.Repositories;

namespace BudgetApp.Persistence.Repositories
{
    public class ExpenseRecordRepository : IExpenseRecordRepository
    {
        private readonly ApplicationDbContext _context;

        public ExpenseRecordRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ExpenseRecord AddExpenseRecord(ExpenseRecord expenseRecord)
        {
            throw new NotImplementedException();
        }
    }
}
