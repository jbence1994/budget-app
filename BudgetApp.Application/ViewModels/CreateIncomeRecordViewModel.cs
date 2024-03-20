﻿namespace BudgetApp.Application.ViewModels
{
    public class CreateIncomeRecordViewModel : RecordViewModel
    {
        public string Source { get; set; }
        public int Category { get; set; }

        public override string ToString()
        {
            return $"{Amount} {Source} {Comment} {Category}";
        }
    }
}
