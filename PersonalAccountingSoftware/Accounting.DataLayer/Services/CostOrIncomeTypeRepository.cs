using Accounting.DataLayer.Context;
using Accounting.DataLayer.Repositories;
using Accounting.Utility;
using Accounting.ViewModels.CostOrIncomeType;
using System.Collections.Generic;
using System.Linq;

namespace Accounting.DataLayer.Services
{
    public class CostOrIncomeTypeRepository : ICostOrIncomeTypeRepository
    {
        private readonly EfContext _context;

        public CostOrIncomeTypeRepository(EfContext context)
        {
            _context = context;
        }

        public List<CostOrIncomeTypeViewModel> GetCostOrIncomeTypes(byte type)
        {
            var query = _context.CostOrIncomeTypes
                .Where(x => x.Type == type)
                .Select(x => new CostOrIncomeTypeViewModel
                {
                    Id = x.Id,
                    Title = x.Title
                }).OrderByDescending(x => x.Id).ToList();

            string message = type == Statuses.Cost ? "*لطفا نوع هزینه را انتخاب کنید*" : "*لطفا نوع درآمد را انتخاب کنید*";
            query.Insert(0, new CostOrIncomeTypeViewModel { Id = -1, Title = message });

            return query;
        }

        public List<CostOrIncomeTypeViewModel> GetList(byte type)
        {
            var query = _context.CostOrIncomeTypes
                .Where(x => x.Type == type)
                .Select(x => new CostOrIncomeTypeViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    CostOrIncomesCount = x.CostOrIncomes.Count(z => z.UserId == PublicVariable.UserId),
                    CreationDate = x.CreationDate
                });

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}