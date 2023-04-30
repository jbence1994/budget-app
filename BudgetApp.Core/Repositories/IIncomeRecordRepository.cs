using BudgetApp.Core.Models;

namespace BudgetApp.Core.Repositories
{
    public interface IIncomeRecordRepository
    {
        IncomeRecord AddIncomeRecord(IncomeRecord incomeRecord);
    }
}
