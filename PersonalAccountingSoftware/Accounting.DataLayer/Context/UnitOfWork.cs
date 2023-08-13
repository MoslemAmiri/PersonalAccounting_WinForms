using Accounting.DataLayer.Context;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
using System;

namespace Accounting.DataLayer.Models
{
    public class UnitOfWork : IDisposable
    {
        EfContext _context = new EfContext();

        #region cost and income types
        private ICostOrIncomeTypeRepository _costOrIncomeTypeRepository;
        public ICostOrIncomeTypeRepository CostOrIncomeTypeRepository
        {
            get
            {
                if (_costOrIncomeTypeRepository == null)
                    _costOrIncomeTypeRepository = new CostOrIncomeTypeRepository(_context);

                return _costOrIncomeTypeRepository;
            }
        }

        private IRepository<CostOrIncomeType> _genericCostOrIncomeTypeRepository;
        public IRepository<CostOrIncomeType> GenericCostOrIncomeTypeRepository
        {
            get
            {
                if (_genericCostOrIncomeTypeRepository == null)
                    _genericCostOrIncomeTypeRepository = new RepositoryBase<CostOrIncomeType>(_context);

                return _genericCostOrIncomeTypeRepository;
            }
        }
        #endregion

        #region costs and incomes
        private ICostOrIncomeRepository _costOrIncomeRepository;
        public ICostOrIncomeRepository CostOrIncomeRepository
        {
            get
            {
                if (_costOrIncomeRepository == null)
                    _costOrIncomeRepository = new CostOrIncomeRepository(_context);

                return _costOrIncomeRepository;
            }
        }

        private IRepository<CostOrIncome> _genericCostOrIncomeRepository;
        public IRepository<CostOrIncome> GenericCostOrIncomeRepository
        {
            get
            {
                if (_genericCostOrIncomeRepository == null)
                    _genericCostOrIncomeRepository = new RepositoryBase<CostOrIncome>(_context);

                return _genericCostOrIncomeRepository;
            }
        }
        #endregion

        #region users
        private IUserRepository _userRepository;
        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_context);

                return _userRepository;
            }
        }

        private IRepository<User> _genericUserRepository;
        public IRepository<User> GenericUserRepository
        {
            get
            {
                if (_genericUserRepository == null)
                    _genericUserRepository = new RepositoryBase<User>(_context);

                return _genericUserRepository;
            }
        }
        #endregion

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}