using BudgetApp.Application.ViewModels;
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
            var result = _recordManager.CreateIncomeRecord(new CreateIncomeRecordViewModel());

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void CreateExpenseRecordTest()
        {
            var result = _recordManager.CreateExpenseRecord(new CreateExpenseRecordViewModel());

            Assert.That(result, Is.Not.Null);
        }
    }
}
