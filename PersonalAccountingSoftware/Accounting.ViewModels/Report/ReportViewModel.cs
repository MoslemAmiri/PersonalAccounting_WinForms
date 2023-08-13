namespace Accounting.ViewModels.Report
{
    public class ReportViewModel
    {
        public double TotalCosts { get; set; } 
        public int CostsCount { get; set; } 
        public double TotalIncomes { get; set; }
        public int IncomesCount { get; set; }

        private double _remaining;
        public double Remaining
        {
            get
            {
                return _remaining;
            }
            set
            {
                _remaining = value <= 0 ? 0 : value;
            }
        }
    }
}