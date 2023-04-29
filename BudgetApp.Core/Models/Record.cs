namespace BudgetApp.Core.Models
{
    public class Record
    {
        public double Amount { get; set; }
        public Currency Currency { get; set; }
        public TransactionType TransactionType { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
