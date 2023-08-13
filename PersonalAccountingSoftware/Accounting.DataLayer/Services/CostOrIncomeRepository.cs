using Accounting.DataLayer.Context;
using Accounting.DataLayer.Repositories;
using Accounting.Utility;
using Accounting.ViewModels.CostOrIncome;
using System.Collections.Generic;
using System.Linq;

namespace Accounting.DataLayer.Services
{
    public class CostOrIncomeRepository : ICostOrIncomeRepository
    {
        private readonly EfContext _context;

        public CostOrIncomeRepository(EfContext context)
        {
            _context = context;
        }

        public List<CostOrIncomeViewModel> GetList(CostOrIncomeSearchModel searchModel)
        {
            var query = _context.CostOrIncomes
                .Where(x => x.Type == searchModel.Type)
                .Where(x => x.UserId == PublicVariable.UserId)
                .Select(x => new CostOrIncomeViewModel
                {
                    Id = x.Id,
                    CostOrIncomeType = x.CostOrIncomeType.Title,
                    Amount = x.Amount,
                    Description = x.Description,
                    Date = x.Date,
                    Time = x.Time,
                    IsRemoved = x.IsRemoved
                });

            #region filter
            if (!string.IsNullOrWhiteSpace(searchModel.DateFrom))
                query = query.Where(x => x.Date.CompareTo(searchModel.DateFrom) >= 0);

            if (!string.IsNullOrWhiteSpace(searchModel.DateTo))
                query = query.Where(x => x.Date.CompareTo(searchModel.DateTo) <= 0);

            switch (searchModel.Status)
            {
                case Statuses.UnRemoved:
                    query = query.Where(x => !x.IsRemoved);
                    break;
                default:
                    query = query.Where(x => x.IsRemoved);
                    break;
            }

            if (!string.IsNullOrWhiteSpace(searchModel.Title))
                query = query.Where(x => x.CostOrIncomeType.Contains(searchModel.Title));
            #endregion

            return query.OrderByDescending(x => x.Id).ToList();
        }

        public void Remove(long id)
        {
            var costOrIncome = _context.CostOrIncomes.Find(id);
            costOrIncome.IsRemoved = Statuses.Remove;
        }

        public void Restore(long id)
        {
            var costOrIncome = _context.CostOrIncomes.Find(id);
            costOrIncome.IsRemoved = Statuses.Restore;
        }
    }
}