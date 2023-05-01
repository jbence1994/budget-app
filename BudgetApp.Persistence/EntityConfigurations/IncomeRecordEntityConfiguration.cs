using BudgetApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BudgetApp.Persistence.EntityConfigurations
{
    public class IncomeRecordEntityConfiguration : IEntityTypeConfiguration<IncomeRecord>
    {
        public void Configure(EntityTypeBuilder<IncomeRecord> builder)
        {
            throw new NotImplementedException();
        }
    }
}
