namespace BudgetApp.Application.ViewModels
{
    public class CreateExpenseRecordViewModel : RecordViewModel
    {
        public int Category { get; set; }

        public override string ToString()
        {
            return $"{Amount} {Comment} {Category}";
        }
    }
}
