namespace BudgetApp.Core.Models
{
    public class ExpenseRecord : Record
    {
        public ExpenseCategory Category { get; set; }

        public override string ToString()
        {
            return $"{Amount} {Comment} {Category} {CreatedDateTime}";
        }
    }
}
