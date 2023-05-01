using BudgetApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BudgetApp.Persistence.EntityConfigurations
{
    public class ExpenseRecordEntityConfiguration : IEntityTypeConfiguration<ExpenseRecord>
    {
        public void Configure(EntityTypeBuilder<ExpenseRecord> builder)
        {
            throw new NotImplementedException();
        }
    }
}
