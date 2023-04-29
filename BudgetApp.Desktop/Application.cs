namespace BudgetApp.Desktop
{
    public class Application
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new Form1());
        }
    }
}
