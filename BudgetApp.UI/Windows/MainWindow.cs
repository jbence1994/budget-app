using System.Diagnostics;
using BudgetApp.Application.ViewModels;
using BudgetApp.Domain.Services;

namespace BudgetApp.UI.Windows
{
    public partial class MainWindow : Form
    {
        private readonly RecordManager _recordManager;

        public MainWindow(RecordManager recordManager)
        {
            InitializeComponent();

            _recordManager = recordManager;
        }

        private void ButtonCreateIncomeRecord_Click(object sender, EventArgs e)
        {
            var incomeRecord = _recordManager.CreateIncomeRecord(
                new CreateIncomeRecordViewModel()
            );
            Debug.WriteLine($"Creating income record: {incomeRecord}");
        }

        private void ButtonCreateExpenseRecord_Click(object sender, EventArgs e)
        {
            var expenseRecord = _recordManager.CreateExpenseRecord(
                new CreateExpenseRecordViewModel()
            );
            Debug.WriteLine($"Creating expense record: {expenseRecord}");
        }
    }
}
