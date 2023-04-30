using System.Diagnostics;

namespace BudgetApp.UI.Windows
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonCreateIncomeRecord_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Creating income record...");
        }

        private void ButtonCreateExpenseRecord_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Creating expense record...");
        }
    }
}
