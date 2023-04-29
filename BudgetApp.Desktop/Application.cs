using BudgetApp.Desktop.Windows;

namespace BudgetApp.Desktop
{
    public class Application
    {
        [STAThread]
        publicstatic void Main()
        {
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new MainWindow());
        }
    }
}
