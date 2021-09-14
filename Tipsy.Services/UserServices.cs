using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipsy.Data;
using Tipsy.Models;

namespace Tipsy.Services
{
    public class UserService
    {
        private readonly Guid _userId;

        public UserService(Guid userId)
        {
            _userId = userId;
        }

        //Create Method
        public bool CreateUser(UserCreate model)
        {
            var entity =
                new User()
                {
                    UserId = _userId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Password = model.Password,
                    Status = model.Status,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Users.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //Read Method
        public IEnumerable<UserListItem> GetUsers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Users
                        .Where(e => e.UserId == _userId)
                        .Select(
                            e =>
                                new UserListItem
                                {
                                    UserId = e.UserId,
                                    FirstName = e.FirstName,
                                    LastName = e.LastName,
                                    Password = e.Password,
                                    Status = e.Status
                                }
                                );
                return query.ToArray();
            }
        }

        public UserDetail GetUserById(Guid id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Users
                        .Single(e => e.UserId == id && e.UserId == _userId);
                return
                    new UserDetail
                    {
                        UserId = entity.UserId,
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        Password = entity.Password,
                        Status = entity.Status
                    };
            }
        }

        public bool UpdateUser(UserEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Users
                        .Single(e => e.UserId == model.UserId && e.UserId == _userId);

                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.Password = model.Password;
                entity.Status = model.Status;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteUser(Guid userId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Users
                        .Single(e => e.UserId == userId && e.UserId == _userId);

                ctx.Users.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
