using Accounting.DataLayer.Context;
using Accounting.ViewModels.User;
using System.Collections.Generic;

namespace Accounting.DataLayer.Repositories
{
    public interface IUserRepository
    {
        void Block(long id);
        void UnBlock(long id);
        User GetUserBy(string userName);
        List<UserViewModel> GetList(UserSearchModel searchModel);
    }
}