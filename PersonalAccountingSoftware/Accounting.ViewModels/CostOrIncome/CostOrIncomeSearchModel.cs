using System.Data;

namespace Accounting.ViewModels.CostOrIncome
{
    public class CostOrIncomeSearchModel
    {
        public byte Type { get; set; }
        public int Status { get; set; }
        public string Title { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
    }
}
