namespace BudgetApp.Core.Models
{
    public class IncomeRecord : Record
    {
        public string Source { get; set; }
        public IncomeCategory Category { get; set; }
    }
}
