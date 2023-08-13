using Accounting.DataLayer.Context;
using Accounting.DataLayer.Repositories;
using Accounting.Utility;
using Accounting.ViewModels.User;
using System.Collections.Generic;
using System.Linq;

namespace Accounting.DataLayer.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly EfContext _context;

        public UserRepository(EfContext context)
        {
            _context = context;
        }

        public List<UserViewModel> GetList(UserSearchModel searchModel)
        {
            var query = _context.Users
                .Select(x => new UserViewModel
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    Role = x.Role,
                    RoleName = x.Role == Statuses.AdminSystem ? "مدیر سیستم" : "کاربر سیستم",
                    Status = x.IsBlock == Statuses.Blocked ? "بلاک شده" : "فعال",
                    Mobile = x.Mobile,
                    UserName = x.UserName,
                    CreationDate = x.CreationDate,
                    IsBlock = x.IsBlock
                });

            if (!string.IsNullOrWhiteSpace(searchModel.FullName))
                query = query.Where(x => x.FullName.Contains(searchModel.FullName));

            return query.OrderByDescending(x => x.Id).ToList();
        }

        public void Block(long id)
        {
            var user = _context.Users.Find(id);
            user.IsBlock = Statuses.Block;
        }

        public void UnBlock(long id)
        {
            var user = _context.Users.Find(id);
            user.IsBlock = Statuses.UnBlock;
        }

        public User GetUserBy(string userName)
        {
            return _context.Users
                .SingleOrDefault(x => x.UserName == userName);
        }
    }
}