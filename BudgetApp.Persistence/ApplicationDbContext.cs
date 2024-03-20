using BudgetApp.Core.Models;
using BudgetApp.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace BudgetApp.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<IncomeRecord> IncomeRecords { get; set; }
        public DbSet<ExpenseRecord> ExpenseRecords { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new IncomeRecordEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ExpenseRecordEntityConfiguration());
        }
    }
}
