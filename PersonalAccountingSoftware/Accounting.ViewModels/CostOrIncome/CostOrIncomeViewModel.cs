namespace Accounting.ViewModels.CostOrIncome
{
    public class CostOrIncomeViewModel
    {
        public long Id { get; set; }
        public string CostOrIncomeType { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public bool IsRemoved { get; set; }
    }
}