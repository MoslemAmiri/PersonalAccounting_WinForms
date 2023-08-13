using Accounting.ViewModels.CostOrIncomeType;
using System.Collections.Generic;

namespace Accounting.DataLayer.Repositories
{
    public interface ICostOrIncomeTypeRepository
    {
        List<CostOrIncomeTypeViewModel> GetList(byte type);
        List<CostOrIncomeTypeViewModel> GetCostOrIncomeTypes(byte type);
    }
}