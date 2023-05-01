using BudgetApp.Core.Models;
using BudgetApp.Core.Repositories;

namespace BudgetApp.Persistence.Repositories
{
    public class IncomeRecordRepository : IIncomeRecordRepository
    {
        private readonly ApplicationDbContext _context;

        public IncomeRecordRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IncomeRecord AddIncomeRecord(IncomeRecord incomeRecord)
        {
            throw new NotImplementedException();
        }
    }
}
