using SmartQueue.DataAccess.Abstract.IRepositories;
using SmartQueue.DataAccess.Concrete.EntityFramework.Context;
using SmartQueue.DataAccess.Concrete.EntityFramework.Repositories.GenericRepository;
using SmartQueue.DataAccess.Concrete.ReturnResult;
using SmartQueue.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.DataAccess.Concrete.EntityFramework.Repositories
{
    public class UserRoleRepository : EFGenericRepository<UserRole, DataAccessReturnResult<UserRole>, SmartQueueDbContext>, IUserRoleRepository
    {
        public UserRoleRepository(SmartQueueDbContext context) : base(context) { }
    }
}
