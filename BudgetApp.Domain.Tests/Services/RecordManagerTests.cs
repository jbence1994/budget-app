using BudgetApp.Core.Models;
using BudgetApp.Domain.Services;
using NUnit.Framework;

namespace BudgetApp.Domain.Tests.Services
{
    public class RecordManagerTests
    {
        private readonly RecordManager _recordManager = new();

        [Test]
        public void CreateIncomeRecordTest()
        {
            var result = _recordManager.CreateIncomeRecord(
                amount: 500_000,
                source: "Acme",
                incomeCategory: IncomeCategory.Salary,
                comment: ""
            );

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void CreateExpenseRecordTest()
        {
            var result = _recordManager.CreateExpenseRecord(
                amount: 200_000,
                expenseCategory: ExpenseCategory.Saving,
                comment: ""
            );

            Assert.That(result, Is.Not.Null);
        }
    }
}
