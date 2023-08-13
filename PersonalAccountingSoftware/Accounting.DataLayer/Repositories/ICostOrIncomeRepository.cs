using Accounting.ViewModels.CostOrIncome;
using System.Collections.Generic;

namespace Accounting.DataLayer.Repositories
{
    public interface ICostOrIncomeRepository
    {
        void Remove(long id);
        void Restore(long id);
        List<CostOrIncomeViewModel> GetList(CostOrIncomeSearchModel searchModel);
    }
}