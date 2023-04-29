using BudgetApp.UI.Windows;

namespace BudgetApp.UI
{
    public class Application
    {
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new MainWindow());
        }
    }
}
