using BudgetApp.Application.ViewModels;
using BudgetApp.Domain.Services;
using Microsoft.Extensions.Logging;

namespace BudgetApp.UI.Windows
{
    public partial class MainWindow : Form
    {
        private readonly ILogger<MainWindow> _logger;
        private readonly RecordManager _recordManager;

        public MainWindow(
            ILogger<MainWindow> logger,
            RecordManager recordManager
        )
        {
            InitializeComponent();

            _logger = logger;
            _recordManager = recordManager;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            comboBoxIncomeCategories.DataSource = Enum.GetValues(typeof(IncomeCategoryViewModel));
            comboBoxExpenseCategories.DataSource = Enum.GetValues(typeof(ExpenseCategoryViewModel));
        }

        private void ButtonCreateIncomeRecord_Click(object sender, EventArgs e)
        {
            var incomeRecord = _recordManager.CreateIncomeRecord(
                new CreateIncomeRecordViewModel()
            );
            _logger.Log(LogLevel.Information, $"Creating income record: {incomeRecord}");
        }

        private void ButtonCreateExpenseRecord_Click(object sender, EventArgs e)
        {
            var expenseRecord = _recordManager.CreateExpenseRecord(
                new CreateExpenseRecordViewModel()
            );
            _logger.Log(LogLevel.Information, $"Creating expense record: {expenseRecord}");
        }

        private void ComboBoxIncomeCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: set the selected category into the VM.
        }

        private void ComboBoxExpenseCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: set the selected category into the VM.
        }
    }
}
