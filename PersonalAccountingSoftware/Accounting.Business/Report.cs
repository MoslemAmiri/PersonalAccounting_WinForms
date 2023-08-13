using Accounting.DataLayer.Models;
using Accounting.Utility;
using Accounting.ViewModels.CostOrIncome;
using Accounting.ViewModels.Report;
using System.Linq;

namespace Accounting.Business
{
    public class Report
    {
        public static ReportViewModel Statistics(string dateFrom, string dateTo)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var costsOrIncomes = db.GenericCostOrIncomeRepository
                   .Get(x => x.Date.CompareTo(dateFrom) >= 0 && x.Date.CompareTo(dateTo) <= 0 && !x.IsRemoved && x.UserId == PublicVariable.UserId);

                ReportViewModel report = new ReportViewModel
                {
                    CostsCount = costsOrIncomes.Count(x => x.Type == Statuses.Cost),
                    IncomesCount = costsOrIncomes.Count(x => x.Type == Statuses.Income),
                    TotalCosts = costsOrIncomes.Where(x => x.Type == Statuses.Cost).Sum(x => x.Amount),
                    TotalIncomes = costsOrIncomes.Where(x => x.Type == Statuses.Income).Sum(x => x.Amount)
                };

                report.Remaining = report.TotalIncomes - report.TotalCosts;
                return report;
            }
        }

        public static double SumOfCostOrIncomes(CostOrIncomeSearchModel searchModel)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return db.GenericCostOrIncomeRepository
                    .Get(x => x.Type == searchModel.Type && x.Date.CompareTo(searchModel.DateFrom) >= 0 && x.Date.CompareTo(searchModel.DateTo) <= 0 && x.CostOrIncomeType.Title.Contains(searchModel.Title) && (searchModel.Status == 0 ? !x.IsRemoved : x.IsRemoved) && x.UserId == PublicVariable.UserId)
                    .Sum(x => x.Amount);
            }
        }
    }
}