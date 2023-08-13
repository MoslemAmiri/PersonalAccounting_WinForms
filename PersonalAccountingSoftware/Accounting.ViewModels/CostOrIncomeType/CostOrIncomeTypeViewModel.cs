namespace Accounting.ViewModels.CostOrIncomeType
{
    public class CostOrIncomeTypeViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int CostOrIncomesCount { get; set; }
        public string CreationDate { get; set; }
        public bool IsRemoved { get; set; }
    }
}